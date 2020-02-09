﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.6.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using AdventureWorks.Dal.Adapter.HelperClasses;
using AdventureWorks.Dal.Adapter.FactoryClasses;
using AdventureWorks.Dal.Adapter.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'SalesTaxRate'.<br/><br/></summary>
	[Serializable]
	public partial class SalesTaxRateEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private StateProvinceEntity _stateProvince;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static SalesTaxRateEntityStaticMetaData _staticMetaData = new SalesTaxRateEntityStaticMetaData();
		private static SalesTaxRateRelations _relationsFactory = new SalesTaxRateRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name StateProvince</summary>
			public static readonly string StateProvince = "StateProvince";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class SalesTaxRateEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public SalesTaxRateEntityStaticMetaData()
			{
				SetEntityCoreInfo("SalesTaxRateEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.SalesTaxRateEntity, typeof(SalesTaxRateEntity), typeof(SalesTaxRateEntityFactory), false);
				AddNavigatorMetaData<SalesTaxRateEntity, StateProvinceEntity>("StateProvince", "SalesTaxRates", (a, b) => a._stateProvince = b, a => a._stateProvince, (a, b) => a.StateProvince = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticSalesTaxRateRelations.StateProvinceEntityUsingStateProvinceIdStatic, ()=>new SalesTaxRateRelations().StateProvinceEntityUsingStateProvinceId, null, new int[] { (int)SalesTaxRateFieldIndex.StateProvinceId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.StateProvinceEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static SalesTaxRateEntity()
		{
		}

		/// <summary> CTor</summary>
		public SalesTaxRateEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public SalesTaxRateEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this SalesTaxRateEntity</param>
		public SalesTaxRateEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="salesTaxRateId">PK value for SalesTaxRate which data should be fetched into this SalesTaxRate object</param>
		public SalesTaxRateEntity(System.Int32 salesTaxRateId) : this(salesTaxRateId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="salesTaxRateId">PK value for SalesTaxRate which data should be fetched into this SalesTaxRate object</param>
		/// <param name="validator">The custom validator object for this SalesTaxRateEntity</param>
		public SalesTaxRateEntity(System.Int32 salesTaxRateId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.SalesTaxRateId = salesTaxRateId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesTaxRateEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'StateProvince' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoStateProvince() { return CreateRelationInfoForNavigator("StateProvince"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this SalesTaxRateEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static SalesTaxRateRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'StateProvince' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathStateProvince { get { return _staticMetaData.GetPrefetchPathElement("StateProvince", CommonEntityBase.CreateEntityCollection<StateProvinceEntity>()); } }

		/// <summary>The ModifiedDate property of the Entity SalesTaxRate<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTaxRate"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SalesTaxRateFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SalesTaxRateFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The Name property of the Entity SalesTaxRate<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTaxRate"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)SalesTaxRateFieldIndex.Name, true); }
			set	{ SetValue((int)SalesTaxRateFieldIndex.Name, value); }
		}

		/// <summary>The Rowguid property of the Entity SalesTaxRate<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTaxRate"."rowguid".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)SalesTaxRateFieldIndex.Rowguid, true); }
			set	{ SetValue((int)SalesTaxRateFieldIndex.Rowguid, value); }
		}

		/// <summary>The SalesTaxRateId property of the Entity SalesTaxRate<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTaxRate"."SalesTaxRateID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 SalesTaxRateId
		{
			get { return (System.Int32)GetValue((int)SalesTaxRateFieldIndex.SalesTaxRateId, true); }
			set { SetValue((int)SalesTaxRateFieldIndex.SalesTaxRateId, value); }		}

		/// <summary>The StateProvinceId property of the Entity SalesTaxRate<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTaxRate"."StateProvinceID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 StateProvinceId
		{
			get { return (System.Int32)GetValue((int)SalesTaxRateFieldIndex.StateProvinceId, true); }
			set	{ SetValue((int)SalesTaxRateFieldIndex.StateProvinceId, value); }
		}

		/// <summary>The TaxRate property of the Entity SalesTaxRate<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTaxRate"."TaxRate".<br/>Table field type characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal TaxRate
		{
			get { return (System.Decimal)GetValue((int)SalesTaxRateFieldIndex.TaxRate, true); }
			set	{ SetValue((int)SalesTaxRateFieldIndex.TaxRate, value); }
		}

		/// <summary>The TaxType property of the Entity SalesTaxRate<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTaxRate"."TaxType".<br/>Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte TaxType
		{
			get { return (System.Byte)GetValue((int)SalesTaxRateFieldIndex.TaxType, true); }
			set	{ SetValue((int)SalesTaxRateFieldIndex.TaxType, value); }
		}

		/// <summary>Gets / sets related entity of type 'StateProvinceEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual StateProvinceEntity StateProvince
		{
			get { return _stateProvince; }
			set { SetSingleRelatedEntityNavigator(value, "StateProvince"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum SalesTaxRateFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalesTaxRateId. </summary>
		SalesTaxRateId,
		///<summary>StateProvinceId. </summary>
		StateProvinceId,
		///<summary>TaxRate. </summary>
		TaxRate,
		///<summary>TaxType. </summary>
		TaxType,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: SalesTaxRate. </summary>
	public partial class SalesTaxRateRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between SalesTaxRateEntity and StateProvinceEntity over the m:1 relation they have, using the relation between the fields: SalesTaxRate.StateProvinceId - StateProvince.StateProvinceId</summary>
		public virtual IEntityRelation StateProvinceEntityUsingStateProvinceId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "StateProvince", false, new[] { StateProvinceFields.StateProvinceId, SalesTaxRateFields.StateProvinceId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticSalesTaxRateRelations
	{
		internal static readonly IEntityRelation StateProvinceEntityUsingStateProvinceIdStatic = new SalesTaxRateRelations().StateProvinceEntityUsingStateProvinceId;

		/// <summary>CTor</summary>
		static StaticSalesTaxRateRelations() { }
	}
}
