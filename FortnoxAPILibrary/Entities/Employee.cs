using System.Runtime.Serialization;
using System.Xml.Serialization;
using FortnoxAPILibrary.Serialization;
using Newtonsoft.Json;

namespace FortnoxAPILibrary.Entities
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot(ElementName = "Employee")]
    [Entity(SingularName = "Employee", PluralName = "Employees")]
    public class Employee
    {
        /// <summary>
        /// Unique employee-id. Can never be changed once an employee has been created.
        /// Max-length 15.
        /// </summary>
        [XmlElement(ElementName = "EmployeeId")]
        [JsonProperty]
        public string EmployeeId { get; set; }

        /// <summary>
        /// Personal identity number
        /// </summary>
        [XmlElement(ElementName = "PersonalIdentityNumber")]
        [JsonProperty]
        public string PersonalIdentityNumber { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        [XmlElement(ElementName = "FirstName")]
        [JsonProperty]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        [XmlElement(ElementName = "LastName")]
        [JsonProperty]
        public string LastName { get; set; }

        /// <summary>
        /// Full name. Read-only
        /// </summary>
        [XmlElement(ElementName = "FullName")]
        [JsonProperty]
        public string FullName { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        [XmlElement(ElementName = "Address1")]
        [JsonProperty]
        public string Address1 { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        [XmlElement(ElementName = "Address2")]
        [JsonProperty]
        public string Address2 { get; set; }

        /// <summary>
        /// Post code
        /// </summary>
        [XmlElement(ElementName = "PostCode")]
        [JsonProperty]
        public string PostCode { get; set; }

        /// <summary>
        /// City
        /// </summary>
        [XmlElement(ElementName = "City")]
        [JsonProperty]
        public string City { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        [XmlElement(ElementName = "Country")]
        [JsonProperty]
        public string Country { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        [XmlElement(ElementName = "Phone1")]
        [JsonProperty]
        public string Phone1 { get; set; }

        /// <summary>
        /// Phone number 2
        /// </summary>
        [XmlElement(ElementName = "Phone2")]
        [JsonProperty]
        public string Phone2 { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        [XmlElement(ElementName = "Email")]
        [JsonProperty]
        public string Email { get; set; }

        /// <summary>
        /// Startdate of employment
        /// </summary>
        [XmlElement(ElementName = "EmploymentDate")]
        [JsonProperty]
        public string EmploymentDate { get; set; }

        /// <summary>
        /// Type of employment
        /// </summary>
        [XmlElement(ElementName = "EmploymentForm")]
        [JsonProperty]
        public EmployeeEmploymentForm EmploymentForm { get; set; }

        /// <summary>
        /// Type of salary form. Required.
        /// </summary>
        [XmlElement(ElementName = "SalaryForm")]
        [JsonProperty]
        public EmployeeSalaryForm SalaryForm { get; set; }

        /// <summary>
        /// Job title
        /// </summary>
        [XmlElement(ElementName = "JobTitle")]
        [JsonProperty]
        public string JobTitle { get; set; }

        /// <summary>
        /// Personel type
        /// </summary>
        [XmlElement(ElementName = "PersonelType")]
        [JsonProperty]
        public EmployeePersonelType PersonelType { get; set; }

        /// <summary>
        /// Schedule ID for scheduletimes. Max-length 10
        /// </summary>
        [XmlElement(ElementName = "ScheduleId")]
        [JsonProperty]
        public string ScheduleId { get; set; }

        /// <summary>
        /// Assigned fora type
        /// </summary>
        [XmlElement(ElementName = "ForaType")]
        [JsonProperty]
        public EmployeeForaType ForaType { get; set; }

        /// <summary>
        /// Monthly salary
        /// </summary>
        [XmlElement(ElementName = "MonthlySalary")]
        [JsonProperty]
        public double? MonthlySalary { get; set; }

        /// <summary>
        /// Hourly pay
        /// </summary>
        [XmlElement(ElementName = "HourlyPay")]
        [JsonProperty]
        public double? HourlyPay { get; set; }

        /// <summary>
        /// Tax allowance
        /// </summary>
        [XmlElement(ElementName = "TaxAllowance")]
        [JsonProperty]
        public EmployeeTaxAllowance TaxAllowance { get; set; }

        /// <summary>
        /// Tax table
        /// </summary>
        [XmlElement(ElementName = "TaxTable")]
        [JsonProperty]
        public double? TaxTable { get; set; }

        /// <summary>
        /// Tax column
        /// </summary>
        [XmlElement(ElementName = "TaxColumn")]
        [JsonProperty]
        public int? TaxColumn { get; set; }

        /// <summary>
        /// Non-recurring tax %
        /// </summary>
        [XmlElement(ElementName = "NonRecurringTax")]
        [JsonProperty]
        public double? NonRecurringTax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(ElementName = "Inactive")]
        [JsonProperty]
        public bool Inactive { get; set; }

        /// <summary>
        /// Clearing number
        /// </summary>
        [XmlElement(ElementName = "ClearingNo")]
        [JsonProperty]
        public string ClearingNo { get; set; }

        /// <summary>
        /// Bankaccount number
        /// </summary>
        [XmlElement(ElementName = "BankAccountNo")]
        [JsonProperty]
        public virtual string BankAccountNo { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public enum EmployeeEmploymentForm
    {
        /// <summary>
        /// Post with conditional tenure
        /// </summary>
        [XmlEnum("TV")]
        [EnumMember(Value = "TV")]
        ConditionalTenure,
        /// <summary>
        /// Probationary appointment
        /// </summary>
        [XmlEnum("PRO")]
        [EnumMember(Value = "PRO")]
        ProbationaryAppointment,
        /// <summary>
        /// Temporary employment
        /// </summary>
        [XmlEnum("TID")]
        [EnumMember(Value = "TID")]
        TemporaryEmployment,
        /// <summary>
        /// Cover staff
        /// </summary>
        [XmlEnum("VIK")]
        [EnumMember(Value = "VIK")]
        CoverStaff,
        /// <summary>
        /// Project employment
        /// </summary>
        [XmlEnum("PRJ")]
        [EnumMember(Value = "PRJ")]
        ProjectEmployment,
        /// <summary>
        /// Work experience
        /// </summary>
        [XmlEnum("PRA")]
        [EnumMember(Value = "PRA")]
        WorkExperience,
        /// <summary>
        /// Holiday work
        /// </summary>
        [XmlEnum("FER")]
        [EnumMember(Value = "FER")]
        HolidayWork,
        /// <summary>
        /// Seasonal employment
        /// </summary>
        [XmlEnum("SES")]
        [EnumMember(Value = "SES")]
        SeasonalEmployment,
        /// <summary>
        /// Not employed
        /// </summary>
        [XmlEnum("NEJ")]
        [EnumMember(Value = "NEJ")]
        NotEmployed
    }

    /// <summary>
    /// 
    /// </summary>
    public enum EmployeeSalaryForm
    {
        /// <summary>
        /// Monthly salary
        /// </summary>
        [XmlEnum("MAN")]
        [EnumMember(Value = "MAN")]
        MonthlySalary,
        /// <summary>
        /// Hourly pay
        /// </summary>
        [XmlEnum("TIM")]
        [EnumMember(Value = "TIM")]
        HourlyPay
    }

    /// <summary>
    /// 
    /// </summary>
    public enum EmployeePersonelType
    {
        /// <summary>
        /// Salaried employee
        /// </summary>
        [XmlEnum("TJM")]
        [EnumMember(Value = "TJM")]
        SalariedEmployee,
        /// <summary>
        /// Worker
        /// </summary>
        [XmlEnum("ARB")]
        [EnumMember(Value = "ARB")]
        Worker
    }

    /// <summary>
    /// 
    /// </summary>
    public enum EmployeeForaType
    {
        /// <summary>
        /// Not signed
        /// </summary>
        [XmlEnum("-")]
        [EnumMember(Value = "-")]
        NotSigned,
        /// <summary>
        /// Worker
        /// </summary>
        [XmlEnum("A")]
        [EnumMember(Value = "A")]
        Worker,
        /// <summary>
        /// Workers, Painters
        /// </summary>
        [XmlEnum("A3")]
        [EnumMember(Value = "A3")]
        WorkersPainters,
        /// <summary>
        /// Worker, Electrician – Installation plant contract
        /// </summary>
        [XmlEnum("A91")]
        [EnumMember(Value = "A91")]
        WorkerElectricianInstallationPlantContract,
        /// <summary>
        /// Worker, Electrician – Power plant contract
        /// </summary>
        [XmlEnum("A92")]
        [EnumMember(Value = "A92")]
        WorkerElectricianPowerPlantContract,
        /// <summary>
        /// Worker, Electrician – Elektroskandia contract
        /// </summary>
        [XmlEnum("A93")]
        [EnumMember(Value = "A93")]
        WorkerElectricianElektroskandiaContract,
        /// <summary>
        /// Worker, Technology Agreement IF Metall
        /// </summary>
        [XmlEnum("A51")]
        [EnumMember(Value = "A51")]
        WorkerTechnologyAgreementIfMetall,
        /// <summary>
        /// Worker, TEKO Agreement
        /// </summary>
        [XmlEnum("A52")]
        [EnumMember(Value = "A52")]
        WorkerTekoAgreement,
        /// <summary>
        /// Worker, Food Production Agreement
        /// </summary>
        [XmlEnum("A53")]
        [EnumMember(Value = "A53")]
        WorkerFoodProductionAgreement,
        /// <summary>
        /// Worker, Tobacco Industry
        /// </summary>
        [XmlEnum("A54")]
        [EnumMember(Value = "A54")]
        WorkerTobaccoIndustry,
        /// <summary>
        /// Worker, Company Agreement for V&S Vin & Sprit AB
        /// </summary>
        [XmlEnum("A55")]
        [EnumMember(Value = "A55")]
        WorkerCompanyAgreementForVAndSVinAndSpritAb,
        /// <summary>
        /// Worker, Coffee Roasters and Spice Factories
        /// </summary>
        [XmlEnum("A56")]
        [EnumMember(Value = "A56")]
        WorkerCoffeeRoastersAndSpiceFactories,
        /// <summary>
        /// Worker, Construction Materials Industry
        /// </summary>
        [XmlEnum("A57")]
        [EnumMember(Value = "A57")]
        WorkerConstructionMaterialsIndustry,
        /// <summary>
        /// Worker, Bottle Glass Industry
        /// </summary>
        [XmlEnum("A58")]
        [EnumMember(Value = "A58")]
        WorkerBottleGlassIndustry,
        /// <summary>
        /// Worker, Motor Industry Agreement
        /// </summary>
        [XmlEnum("A59")]
        [EnumMember(Value = "A59")]
        WorkerMotorIndustryAgreement,
        /// <summary>
        /// Worker, Industry Agreement
        /// </summary>
        [XmlEnum("A60")]
        [EnumMember(Value = "A60")]
        WorkerIndustryAgreement,
        /// <summary>
        /// Worker, Leather & Sporting Goods
        /// </summary>
        [XmlEnum("A61")]
        [EnumMember(Value = "A61")]
        WorkerLeatherAndSportingGoods,
        /// <summary>
        /// Worker, Chemical Factories
        /// </summary>
        [XmlEnum("A62")]
        [EnumMember(Value = "A62")]
        WorkerChemicalFactories,
        /// <summary>
        /// Worker, Glass Industry
        /// </summary>
        [XmlEnum("A63")]
        [EnumMember(Value = "A63")]
        WorkerGlassIndustry,
        /// <summary>
        /// Worker, Common Metals
        /// </summary>
        [XmlEnum("A64")]
        [EnumMember(Value = "A64")]
        WorkerCommonMetals,
        /// <summary>
        /// Worker, Explosive Materials Industry
        /// </summary>
        [XmlEnum("A65")]
        [EnumMember(Value = "A65")]
        WorkerExplosiveMaterialsIndustry,
        /// <summary>
        /// Worker, Allochemical Industry
        /// </summary>
        [XmlEnum("A66")]
        [EnumMember(Value = "A66")]
        WorkerAllochemicalIndustry,
        /// <summary>
        /// Worker, Recycling Company
        /// </summary>
        [XmlEnum("A67")]
        [EnumMember(Value = "A67")]
        WorkerRecyclingCompany,
        /// <summary>
        /// Worker, Laundy Industry
        /// </summary>
        [XmlEnum("A68")]
        [EnumMember(Value = "A68")]
        WorkerLaundyIndustry,
        /// <summary>
        /// Worker, Quarrying Industry
        /// </summary>
        [XmlEnum("A69")]
        [EnumMember(Value = "A69")]
        WorkerQuarryingIndustry,
        /// <summary>
        /// Worker, Oil Refineries
        /// </summary>
        [XmlEnum("A70")]
        [EnumMember(Value = "A70")]
        WorkerOilRefineries,
        /// <summary>
        /// Worker, Sugar Industry (Nordic Sugar AB)
        /// </summary>
        [XmlEnum("A71")]
        [EnumMember(Value = "A71")]
        WorkerSugarIndustryNordicSugarAb,
        /// <summary>
        /// Worker, IMG Agreement
        /// </summary>
        [XmlEnum("A72")]
        [EnumMember(Value = "A72")]
        WorkerImgAgreement,
        /// <summary>
        /// Worker, Sawmill Agreement
        /// </summary>
        [XmlEnum("A73")]
        [EnumMember(Value = "A73")]
        WorkerSawmillAgreement,
        /// <summary>
        /// Worker, Forestry Agreement
        /// </summary>
        [XmlEnum("A74")]
        [EnumMember(Value = "A74")]
        WorkerForestryAgreement,
        /// <summary>
        /// Worker, Scaling of timber
        /// </summary>
        [XmlEnum("A75")]
        [EnumMember(Value = "A75")]
        WorkerScalingOfTimber,
        /// <summary>
        /// Worker, Upholstery Industry
        /// </summary>
        [XmlEnum("A76")]
        [EnumMember(Value = "A76")]
        WorkerUpholsteryIndustry,
        /// <summary>
        /// Worker, Wood Industry
        /// </summary>
        [XmlEnum("A77")]
        [EnumMember(Value = "A77")]
        WorkerWoodIndustry,
        /// <summary>
        /// Salaried employee
        /// </summary>
        [XmlEnum("T")]
        [EnumMember(Value = "T")]
        SalariedEmployee,
        /// <summary>
        /// Salaried employee, Employed CEO
        /// </summary>
        [XmlEnum("T6")]
        [EnumMember(Value = "T6")]
        SalariedEmployeeEmployedCeo
    }

    /// <summary>
    /// 
    /// </summary>
    public enum EmployeeTaxAllowance
    {
        /// <summary>
        /// Main employer
        /// </summary>
        [XmlEnum("HUV")]
        [EnumMember(Value = "HUV")]
        MainEmployer,
        /// <summary>
        /// Extra income or short-time work
        /// </summary>
        [XmlEnum("EXT")]
        [EnumMember(Value = "EXT")]
        ExtraIncomeOrShortTimeWork,
        /// <summary>
        /// Short-time work less than one week
        /// </summary>
        [XmlEnum("TMP")]
        [EnumMember(Value = "TMP")]
        ShortTimeWorkLessThanOneWeek,
        /// <summary>
        /// Student without tax deduction
        /// </summary>
        [XmlEnum("STU")]
        [EnumMember(Value = "STU")]
        StudentWithoutTaxDeduction,
        /// <summary>
        /// Not tax allowance
        /// </summary>
        [XmlEnum("EJ")]
        [EnumMember(Value = "EJ")]
        NotTaxAllowance,
        /// <summary>
        /// Unknown tax circumstances
        /// </summary>
        [XmlEnum("???")]
        [EnumMember(Value = "???")]
        UnknownTaxCircumstances
    }
}
