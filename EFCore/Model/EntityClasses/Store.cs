﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.6.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'Store'.</summary>
	public partial class Store : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="Store"/> class.</summary>
		public Store() : base()
		{
			this.Customers = new List<Customer>();
			OnCreated();
		}

		/// <summary>Gets or sets the CustomerId field. </summary>
		public System.Int32 CustomerId { get; set;}
		/// <summary>Gets or sets the Demographics field. </summary>
		public System.String Demographics { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the Name field. </summary>
		public System.String Name { get; set;}
		/// <summary>Gets or sets the Rowguid field. </summary>
		public System.Guid Rowguid { get; set;}
		/// <summary>Gets or sets the SalesPersonId field. </summary>
		public Nullable<System.Int32> SalesPersonId { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Store.BusinessEntity - BusinessEntity.Store (1:1)'</summary>
		public virtual BusinessEntity BusinessEntity { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Customer.Store - Store.Customers (m:1)'</summary>
		public virtual List<Customer> Customers { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Store.SalesPerson - SalesPerson.Stores (m:1)'</summary>
		public virtual SalesPerson SalesPerson { get; set;}
	}
}
