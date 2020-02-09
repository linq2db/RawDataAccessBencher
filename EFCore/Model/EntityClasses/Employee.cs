﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.6.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'Employee'.</summary>
	public partial class Employee : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="Employee"/> class.</summary>
		public Employee() : base()
		{
			this.Documents = new List<Document>();
			this.EmployeeDepartmentHistories = new List<EmployeeDepartmentHistory>();
			this.EmployeePayHistories = new List<EmployeePayHistory>();
			this.JobCandidates = new List<JobCandidate>();
			this.PurchaseOrderHeaders = new List<PurchaseOrderHeader>();
			OnCreated();
		}

		/// <summary>Gets or sets the BirthDate field. </summary>
		public System.DateTime BirthDate { get; set;}
		/// <summary>Gets or sets the CurrentFlag field. </summary>
		public System.Boolean CurrentFlag { get; set;}
		/// <summary>Gets or sets the EmployeeId field. </summary>
		public System.Int32 EmployeeId { get; set;}
		/// <summary>Gets or sets the Gender field. </summary>
		public System.String Gender { get; set;}
		/// <summary>Gets or sets the HireDate field. </summary>
		public System.DateTime HireDate { get; set;}
		/// <summary>Gets or sets the LoginId field. </summary>
		public System.String LoginId { get; set;}
		/// <summary>Gets or sets the MaritalStatus field. </summary>
		public System.String MaritalStatus { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the NationalIdnumber field. </summary>
		public System.String NationalIdnumber { get; set;}
		/// <summary>Gets or sets the OrganizationLevel field. </summary>
		public Nullable<System.Int16> OrganizationLevel { get; set;}
		/// <summary>Gets or sets the OrganizationNode field. </summary>
		public System.String OrganizationNode { get; set;}
		/// <summary>Gets or sets the Rowguid field. </summary>
		public System.Guid Rowguid { get; set;}
		/// <summary>Gets or sets the SalariedFlag field. </summary>
		public System.Boolean SalariedFlag { get; set;}
		/// <summary>Gets or sets the SickLeaveHours field. </summary>
		public System.Int16 SickLeaveHours { get; set;}
		/// <summary>Gets or sets the Title field. </summary>
		public System.String Title { get; set;}
		/// <summary>Gets or sets the VacationHours field. </summary>
		public System.Int16 VacationHours { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Document.Employee - Employee.Documents (m:1)'</summary>
		public virtual List<Document> Documents { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'EmployeeDepartmentHistory.Employee - Employee.EmployeeDepartmentHistories (m:1)'</summary>
		public virtual List<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'EmployeePayHistory.Employee - Employee.EmployeePayHistories (m:1)'</summary>
		public virtual List<EmployeePayHistory> EmployeePayHistories { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'JobCandidate.Employee - Employee.JobCandidates (m:1)'</summary>
		public virtual List<JobCandidate> JobCandidates { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Employee.Person - Person.Employee (1:1)'</summary>
		public virtual Person Person { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'PurchaseOrderHeader.Employee - Employee.PurchaseOrderHeaders (m:1)'</summary>
		public virtual List<PurchaseOrderHeader> PurchaseOrderHeaders { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'SalesPerson.Employee - Employee.SalesPerson (1:1)'</summary>
		public virtual SalesPerson SalesPerson { get; set;}
	}
}
