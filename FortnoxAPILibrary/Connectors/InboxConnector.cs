using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using FortnoxAPILibrary.Entities;
using MimeTypes;

namespace FortnoxAPILibrary.Connectors
{
    public interface IInboxConnector : IEntityConnector<Sort.By.Folder>
    {
        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string Path { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string FolderId { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// Gets at list of Files and Folders
        /// </summary>
        /// <returns>A list of Files and Folders</returns>
        Folder Find(InboxConnector.InboxFolder inboxFolder = InboxConnector.InboxFolder.Root);

        ///<summary>
        /// Uploads a file from local storage to Fortnox Inbox
        ///</summary>
        ///<param name="localPath">The local path to the file to upload</param>
        ///<param name="inboxFolder">The folder in Fortnox inbox to save the file in</param>
        ///<returns>Information of the uploaded file</returns>
        File UploadFile(string localPath, InboxConnector.InboxFolder inboxFolder = InboxConnector.InboxFolder.Root);

        /// <summary>
        /// Uploads a file to Fortnox Inbox from provided data array.
        /// </summary>
        /// <returns>Created file.</returns>
        File UploadFileData(byte[] data, string name, InboxConnector.InboxFolder inboxFolder = InboxConnector.InboxFolder.Root);

        /// <summary>
        /// Uploads a file to Fortnox Inbox from provided data stream.
        /// </summary>
        /// <returns>Created file.</returns>
        File UploadFileData(System.IO.Stream stream, string name, InboxConnector.InboxFolder inboxFolder = InboxConnector.InboxFolder.Root);

        /// <summary>
        /// Downloads a file fron Fortnox Inbox
        /// </summary>
        /// <param name="fileIdOrFilePath">The id or path of the file to download</param>
        /// <param name="localPath">The local path to save the file to </param>
        void DownloadFile(string fileIdOrFilePath, string localPath);

        /// <summary>
        /// Downloads actual file data from Fortnox Inbox into existing file object. Please note that the file object needs a valid file id.
        /// </summary>
        /// <param name="file">File object to be injected with file data.</param>
        void DownloadFileData(File file);

        /// <summary>
        /// Deletes a file from Fortnox Archive.
        /// </summary>
        /// <param name="fileId">The id of the file to be deleted.</param>
        void DeleteFile(string fileId);
    }

    /// <remarks/>
    public class InboxConnector : EntityConnector<Folder, EntityWrapper<Folder>, Sort.By.Folder>, IInboxConnector
    {
        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        public string FolderId { get; set; }

        ///// <summary>
        ///// Use with Find() to limit the search result
        ///// </summary>
        //public string Destination { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        public string Id { get; set; }

        const string BaseResource = "inbox";

        /// <remarks/>
        public InboxConnector()
        {
            Resource = BaseResource;
        }

        /// <summary>
        /// Use this to set what folder to read from. 
        /// </summary>
        public enum InboxFolder
        {
            /// <remarks/>
            [StringValue("")]
            Root,
            /// <remarks/>
            [StringValue("inbox_s")]
            SupplierInvoices,
            /// <remarks/>
            [StringValue("inbox_v")]
            Vouchers,
            /// <remarks/>
            [StringValue("inbox_d")]
            DailyTakings,
            /// <remarks/>
            [StringValue("inbox_a")]
            AssetRegister,
            /// <remarks/>
            [StringValue("inbox_b")]
            BankFiles,
            /// <remarks/>
            [StringValue("inbox_kf")]
            CustomerInvoices
        }

        /// <summary>
        /// Gets at list of Files and Folders
        /// </summary>
        /// <returns>A list of Files and Folders</returns>
        public Folder Find(InboxFolder inboxFolder = InboxFolder.Root)
        {
            Parameters = new Dictionary<string, string>();

            if (inboxFolder == InboxFolder.Root)
            {
                if (!string.IsNullOrWhiteSpace(Path))
                {
                    Parameters.Add("path", Path);
                }

                if (!string.IsNullOrWhiteSpace(FolderId))
                {
                    Resource = BaseResource + "/" + FolderId;
                }
                else if (!string.IsNullOrWhiteSpace(Id))
                {
                    Resource = BaseResource + "/" + Id;
                }
            }
            else
            {
                Resource = BaseResource + "/" + GetRealValueFromAttribute(inboxFolder);
            }
			
            return BaseFind(Parameters)?.Entity;
        }

        private static string GetRealValueFromAttribute(InboxFolder f)
        {
            string resource = "";

            Type type = f.GetType();
            MemberInfo[] memInfo = type.GetMember(f.ToString());
            object[] attrs = memInfo[0].GetCustomAttributes(typeof(StringValueAttribute), false);
            if (attrs.Length > 0)
            {
                resource = ((StringValueAttribute)attrs[0]).RealValue;
            }
            return resource;
        }

        ///<summary>
        /// Uploads a file from local storage to Fortnox Inbox
        ///</summary>
        ///<param name="localPath">The local path to the file to upload</param>
        ///<param name="inboxFolder">The folder in Fortnox inbox to save the file in</param>
        ///<returns>Information of the uploaded file</returns>
        public File UploadFile(string localPath, InboxFolder inboxFolder = InboxFolder.Root)
        {
            Resource = BaseResource;
            
            return UploadFile<File>(localPath, null, GetRealValueFromAttribute(inboxFolder));
        }

        /// <summary>
        /// Uploads a file to Fortnox Inbox from provided data array.
        /// </summary>
        /// <returns>Created file.</returns>
        public File UploadFileData(byte[] data, string name, InboxFolder inboxFolder = InboxFolder.Root)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));

            if (!System.IO.Path.HasExtension(name)) throw new ArgumentException("File name with extention must be set.", nameof(name));

            Resource = BaseResource;

            RequestUriString += "?folderid=" + Uri.EscapeDataString(GetRealValueFromAttribute(inboxFolder));
            
            var uploadedFile = UploadFile<File>("", data, name);

            uploadedFile.ContentType = GetMimeType(name);

            uploadedFile.Data = new byte[data.Length];

            data.CopyTo(uploadedFile.Data, 0);

            return uploadedFile;
        }
        
        private static string GetMimeType(string name)
        {
            var extension = System.IO.Path.GetExtension(name);
            return MimeTypeMap.GetMimeType(extension);
        }

        /// <summary>
        /// Uploads a file stream to Fortnox Inbox from provided data stream.
        /// </summary>
        /// <returns>Created file.</returns>
        public File UploadFileData(System.IO.Stream stream, string name, InboxFolder inboxFolder = InboxFolder.Root)
        {
            stream.Position = 0;
            var arr = new byte[stream.Length];
            stream.Read(arr, 0, (int)stream.Length);
            return UploadFileData(arr, name, inboxFolder);
        }

        /// <summary>
        /// Downloads a file fron Fortnox Inbox
        /// </summary>
        /// <param name="fileIdOrFilePath">The id or path of the file to download</param>
        /// <param name="localPath">The local path to save the file to </param>
        public void DownloadFile(string fileIdOrFilePath, string localPath)
        {
            Resource = BaseResource;

            base.DownloadFile(fileIdOrFilePath, localPath);
        }

        /// <summary>
        /// Downloads actual file data from Fortnox Archive into existing file object. Please note that the file object needs a valid file id.
        /// </summary>
        /// <param name="file">File object to be injected with file data.</param>
        public void DownloadFileData(File file)
        {
            if (file == null)
            {
                throw new ArgumentNullException(nameof(file));
            }

            if (string.IsNullOrEmpty(file.Id))
            {
                throw new ArgumentException("File id must be set.");
            }

            Resource = BaseResource;

            base.DownloadFile(file.Id, "", file);
        }

        /// <summary>
        /// Deletes a file from Fortnox Inbox.
        /// </summary>
        /// <param name="fileId">The id of the file to be deleted.</param>
        public void DeleteFile(string fileId)
        {
            BaseDelete(fileId);
        }
    }
}