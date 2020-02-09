﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.6.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'SalesTaxRate'.</summary>
	public partial class SalesTaxRate : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="SalesTaxRate"/> class.</summary>
		public SalesTaxRate() : base()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the Name field. </summary>
		public System.String Name { get; set;}
		/// <summary>Gets or sets the Rowguid field. </summary>
		public System.Guid Rowguid { get; set;}
		/// <summary>Gets or sets the SalesTaxRateId field. </summary>
		public System.Int32 SalesTaxRateId { get; set;}
		/// <summary>Gets or sets the StateProvinceId field. </summary>
		public System.Int32 StateProvinceId { get; set;}
		/// <summary>Gets or sets the TaxRate field. </summary>
		public System.Decimal TaxRate { get; set;}
		/// <summary>Gets or sets the TaxType field. </summary>
		public System.Byte TaxType { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'SalesTaxRate.StateProvince - StateProvince.SalesTaxRates (m:1)'</summary>
		public virtual StateProvince StateProvince { get; set;}
	}
}
