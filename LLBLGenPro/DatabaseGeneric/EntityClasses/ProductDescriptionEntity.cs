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
	/// <summary>Entity class which represents the entity 'ProductDescription'.<br/><br/></summary>
	[Serializable]
	public partial class ProductDescriptionEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<ProductModelProductDescriptionCultureEntity> _productModelProductDescriptionCultures;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static ProductDescriptionEntityStaticMetaData _staticMetaData = new ProductDescriptionEntityStaticMetaData();
		private static ProductDescriptionRelations _relationsFactory = new ProductDescriptionRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name ProductModelProductDescriptionCultures</summary>
			public static readonly string ProductModelProductDescriptionCultures = "ProductModelProductDescriptionCultures";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class ProductDescriptionEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public ProductDescriptionEntityStaticMetaData()
			{
				SetEntityCoreInfo("ProductDescriptionEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.ProductDescriptionEntity, typeof(ProductDescriptionEntity), typeof(ProductDescriptionEntityFactory), false);
				AddNavigatorMetaData<ProductDescriptionEntity, EntityCollection<ProductModelProductDescriptionCultureEntity>>("ProductModelProductDescriptionCultures", a => a._productModelProductDescriptionCultures, (a, b) => a._productModelProductDescriptionCultures = b, a => a.ProductModelProductDescriptionCultures, () => new ProductDescriptionRelations().ProductModelProductDescriptionCultureEntityUsingProductDescriptionId, typeof(ProductModelProductDescriptionCultureEntity), (int)AdventureWorks.Dal.Adapter.EntityType.ProductModelProductDescriptionCultureEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static ProductDescriptionEntity()
		{
		}

		/// <summary> CTor</summary>
		public ProductDescriptionEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ProductDescriptionEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ProductDescriptionEntity</param>
		public ProductDescriptionEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="productDescriptionId">PK value for ProductDescription which data should be fetched into this ProductDescription object</param>
		public ProductDescriptionEntity(System.Int32 productDescriptionId) : this(productDescriptionId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="productDescriptionId">PK value for ProductDescription which data should be fetched into this ProductDescription object</param>
		/// <param name="validator">The custom validator object for this ProductDescriptionEntity</param>
		public ProductDescriptionEntity(System.Int32 productDescriptionId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.ProductDescriptionId = productDescriptionId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductDescriptionEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductModelProductDescriptionCulture' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductModelProductDescriptionCultures() { return CreateRelationInfoForNavigator("ProductModelProductDescriptionCultures"); }
		
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
		/// <param name="validator">The validator object for this ProductDescriptionEntity</param>
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
		public static ProductDescriptionRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductModelProductDescriptionCulture' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductModelProductDescriptionCultures { get { return _staticMetaData.GetPrefetchPathElement("ProductModelProductDescriptionCultures", CommonEntityBase.CreateEntityCollection<ProductModelProductDescriptionCultureEntity>()); } }

		/// <summary>The Description property of the Entity ProductDescription<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductDescription"."Description".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 400.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)ProductDescriptionFieldIndex.Description, true); }
			set	{ SetValue((int)ProductDescriptionFieldIndex.Description, value); }
		}

		/// <summary>The ModifiedDate property of the Entity ProductDescription<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductDescription"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductDescriptionFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductDescriptionFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The ProductDescriptionId property of the Entity ProductDescription<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductDescription"."ProductDescriptionID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductDescriptionId
		{
			get { return (System.Int32)GetValue((int)ProductDescriptionFieldIndex.ProductDescriptionId, true); }
			set { SetValue((int)ProductDescriptionFieldIndex.ProductDescriptionId, value); }		}

		/// <summary>The Rowguid property of the Entity ProductDescription<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductDescription"."rowguid".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)ProductDescriptionFieldIndex.Rowguid, true); }
			set	{ SetValue((int)ProductDescriptionFieldIndex.Rowguid, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'ProductModelProductDescriptionCultureEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductModelProductDescriptionCultureEntity))]
		public virtual EntityCollection<ProductModelProductDescriptionCultureEntity> ProductModelProductDescriptionCultures { get { return GetOrCreateEntityCollection<ProductModelProductDescriptionCultureEntity, ProductModelProductDescriptionCultureEntityFactory>("ProductDescription", true, false, ref _productModelProductDescriptionCultures); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum ProductDescriptionFieldIndex
	{
		///<summary>Description. </summary>
		Description,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductDescriptionId. </summary>
		ProductDescriptionId,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: ProductDescription. </summary>
	public partial class ProductDescriptionRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between ProductDescriptionEntity and ProductModelProductDescriptionCultureEntity over the 1:n relation they have, using the relation between the fields: ProductDescription.ProductDescriptionId - ProductModelProductDescriptionCulture.ProductDescriptionId</summary>
		public virtual IEntityRelation ProductModelProductDescriptionCultureEntityUsingProductDescriptionId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "ProductModelProductDescriptionCultures", true, new[] { ProductDescriptionFields.ProductDescriptionId, ProductModelProductDescriptionCultureFields.ProductDescriptionId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticProductDescriptionRelations
	{
		internal static readonly IEntityRelation ProductModelProductDescriptionCultureEntityUsingProductDescriptionIdStatic = new ProductDescriptionRelations().ProductModelProductDescriptionCultureEntityUsingProductDescriptionId;

		/// <summary>CTor</summary>
		static StaticProductDescriptionRelations() { }
	}
}
