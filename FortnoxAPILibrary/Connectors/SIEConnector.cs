using System;
using System.Collections.Generic;
using System.Net;
using FortnoxAPILibrary.Entities;
// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    public interface ISIEConnector : IFinancialYearBasedEntityConnector<SieSummary, SieSummary, Sort.By.Sie?>
    {
        /// <remarks/>
        ExportOptions ExportOptions { get; set; }

        /// <summary>
        /// Export SIE to a string
        /// </summary>
        /// <param name="sieType">The type of SIE to export</param>
        /// <returns>SIE</returns>
        SieFile ExportSIE(SIEType sieType);

        /// <summary>
        /// Export SIE to a file
        /// </summary>
        /// <param name="sieType">The type of SIE to export</param>
        /// <param name="localPath">Path to sie-file</param>
        void ExportSIE(SIEType sieType, string localPath);
    }

    /// <remarks/>
    public class SIEConnector : FinancialYearBasedEntityConnector<SieSummary, SieSummary, Sort.By.Sie?>, ISIEConnector
    {
        /// <remarks/>
        public ExportOptions ExportOptions { get; set; }

        /// <remarks/>
        public SIEConnector()
        {
            Resource = "sie";
            ExportOptions = new ExportOptions();
        }

        /// <summary>
        /// Export SIE to a string
        /// </summary>
        /// <param name="sieType">The type of SIE to export</param>
        /// <returns>SIE</returns>
        public SieFile ExportSIE(SIEType sieType)
        {
            return Export(sieType);
        }

        /// <summary>
        /// Export SIE to a file
        /// </summary>
        /// <param name="sieType">The type of SIE to export</param>
        /// <param name="localPath">Path to sie-file</param>
        public void ExportSIE(SIEType sieType, string localPath)
        {
            Export(sieType, localPath);
        }

        private SieFile Export(SIEType sieType, string localPath = "")
        {
            Resource = "sie/" + (int)sieType;
            var requestString = GetUrl();

            Parameters = new Dictionary<string, string>();
            AddExportOptions();

            requestString = AddParameters(requestString);

            var wr = SetupRequest(requestString, "GET");

            var data = Array.Empty<byte>();

            var sieFile = new SieFile();

            try
            {
                using var response = wr.GetResponse();
                using var responseStream = response.GetResponseStream();

                if (localPath != "")
                    responseStream.ToFile(localPath);
                else
                    data = responseStream.ToBytes();

                sieFile.ContentDisposition = response.Headers.Get("Content-Disposition");
                sieFile.Content = data;
            }
            catch (WebException we)
            {
                Error = HandleException(we);
            }

            return sieFile;
        }

        private void AddExportOptions()
        {
            if (ExportOptions.Selection != null && ExportOptions.Selection.Count > 0)
                Parameters.Add("selection", SelectionToString(ExportOptions.Selection));

            if (ExportOptions.ExportAll)
                Parameters.Add("exportall", "true");

            if (!string.IsNullOrEmpty(ExportOptions.FromDate))
                Parameters.Add("fromdate", ExportOptions.FromDate);

            if (!string.IsNullOrEmpty(ExportOptions.ToDate))
                Parameters.Add("todate", ExportOptions.ToDate);
        }
        
        private static string SelectionToString(List<Selection> selection)
        {
            string str = "";

            foreach (var currentSelection in selection)
            {
                if (!string.IsNullOrEmpty(currentSelection.VoucherSeries))
                {
                    if (str != "")
                        str += ";";

                    str += currentSelection.VoucherSeries;

                    if (!string.IsNullOrEmpty(currentSelection.FromVoucherNumber) && !string.IsNullOrEmpty(currentSelection.ToVoucherNumber))
                    {
                        str += "," + currentSelection.FromVoucherNumber + "," + currentSelection.ToVoucherNumber;
                    }
                }
            }

            return str;
        }
    }

    /// <remarks/>
    public class Selection
    {
        /// <remarks/>
        public string VoucherSeries { get; set; }
        /// <remarks/>
        public string FromVoucherNumber { get; set; }
        /// <remarks/>
        public string ToVoucherNumber { get; set; }
    }
    
    /// <remarks/>
    public class ExportOptions
    {
        /// <remarks/>
        public bool ExportAll;
        /// <remarks/>
        public List<Selection> Selection;
        /// <remarks/>
        public string FromDate;
        /// <remarks/>
        public string ToDate;
    }

    /// <remarks/>
    public enum SIEType
    {
        /// <remarks/>
        SIE1 = 1,
        /// <remarks/>
        SIE2 = 2,
        /// <remarks/>
        SIE3 = 3,
        /// <remarks/>
        SIE4 = 4
    }

    public class SieFile
    {
        /// <remarks/>
        public byte[] Content;

        /// <remarks/>
        public string ContentDisposition;
    }
}
