using System;
using System.Collections.Generic;
using System.Text;

namespace JsonSerializerBenchmark
{
    public class Test
    {
        public Guid Id { get; set; }
    }

	public class UserProfile
    {
		public int ID { get; set; }

		public string NetworkID { get; set; }

		public string Domain { get; set; }

		public string CICSOPID { get; set; }

		public string CCN { get; set; }

		//[JsonIgnore]
		public string EmployeeNbr { get; set; }

		public string LastName { get; set; }

		public string FirstName { get; set; }

		public string MiddleInit { get; set; }

		public string MfgLocationID { get; set; }

		public string LanguageCode { get; set; }

		public string TimeZone { get; set; }

		public string DivMDTCode { get; set; }

		public string DateFormat { get; set; }

		public string ActiveCD { get; set; }

		public string AMAPSOPID { get; set; }

		public string AMAPSPWD { get; set; }

		public string GMTTime { get; set; }

		public string PrimarySalesmanCD { get; set; }

		public string RepSecurity { get; set; }

		public string PaidCommisions { get; set; }

		public string RepDeptCode { get; set; }

		public string PrimaryRepDeptNo { get; set; }

		public string Email { get; set; }

		public string NativeLastName { get; set; }

		public string NativeFirstName { get; set; }

		public string MgrEmpCode { get; set; }

		public string ShortLangCode { get; set; }

		public string SecondaryRepNos { get; set; }

		public bool ViewCommissions { get; set; }

		public string DeptNos { get; set; }

		public bool? ViewCustData { get; set; }

		public bool? ViewCostData { get; set; }

		public bool? ViewIntraFacility { get; set; }

		public string PurchasingSpentLimit { get; set; }

		public DateTime? lastUpdateDate { get; set; }

		public DateTime? firstUpdateDate { get; set; }

		public int? lastUpdateUser { get; set; }

		public string IntraFacilityRepNos { get; set; }

		public int? GMTID { get; set; }

		public bool ViewGrossMargin { get; set; }

		public string AssignedSalesmanCDs { get; set; }

		public string SSCoEmp { get; set; }

		public int? PurLimitid { get; set; }

		public Guid? AzureObjectId { get; set; }

		public string UserPrincipalName { get; set; }

		public Guid dhGuid { get; set; }

		public Test Test { get; set; }
	}
}
