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
	/// <summary>Entity class which represents the entity 'WorkOrderRouting'.<br/><br/></summary>
	[Serializable]
	public partial class WorkOrderRoutingEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private LocationEntity _location;
		private WorkOrderEntity _workOrder;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static WorkOrderRoutingEntityStaticMetaData _staticMetaData = new WorkOrderRoutingEntityStaticMetaData();
		private static WorkOrderRoutingRelations _relationsFactory = new WorkOrderRoutingRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Location</summary>
			public static readonly string Location = "Location";
			/// <summary>Member name WorkOrder</summary>
			public static readonly string WorkOrder = "WorkOrder";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class WorkOrderRoutingEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public WorkOrderRoutingEntityStaticMetaData()
			{
				SetEntityCoreInfo("WorkOrderRoutingEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.WorkOrderRoutingEntity, typeof(WorkOrderRoutingEntity), typeof(WorkOrderRoutingEntityFactory), false);
				AddNavigatorMetaData<WorkOrderRoutingEntity, LocationEntity>("Location", "WorkOrderRoutings", (a, b) => a._location = b, a => a._location, (a, b) => a.Location = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticWorkOrderRoutingRelations.LocationEntityUsingLocationIdStatic, ()=>new WorkOrderRoutingRelations().LocationEntityUsingLocationId, null, new int[] { (int)WorkOrderRoutingFieldIndex.LocationId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.LocationEntity);
				AddNavigatorMetaData<WorkOrderRoutingEntity, WorkOrderEntity>("WorkOrder", "WorkOrderRoutings", (a, b) => a._workOrder = b, a => a._workOrder, (a, b) => a.WorkOrder = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticWorkOrderRoutingRelations.WorkOrderEntityUsingWorkOrderIdStatic, ()=>new WorkOrderRoutingRelations().WorkOrderEntityUsingWorkOrderId, null, new int[] { (int)WorkOrderRoutingFieldIndex.WorkOrderId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.WorkOrderEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static WorkOrderRoutingEntity()
		{
		}

		/// <summary> CTor</summary>
		public WorkOrderRoutingEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public WorkOrderRoutingEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this WorkOrderRoutingEntity</param>
		public WorkOrderRoutingEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productId">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="workOrderId">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		public WorkOrderRoutingEntity(System.Int16 operationSequence, System.Int32 productId, System.Int32 workOrderId) : this(operationSequence, productId, workOrderId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productId">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="workOrderId">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="validator">The custom validator object for this WorkOrderRoutingEntity</param>
		public WorkOrderRoutingEntity(System.Int16 operationSequence, System.Int32 productId, System.Int32 workOrderId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.OperationSequence = operationSequence;
			this.ProductId = productId;
			this.WorkOrderId = workOrderId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected WorkOrderRoutingEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Location' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoLocation() { return CreateRelationInfoForNavigator("Location"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'WorkOrder' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrder() { return CreateRelationInfoForNavigator("WorkOrder"); }
		
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
		/// <param name="validator">The validator object for this WorkOrderRoutingEntity</param>
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
		public static WorkOrderRoutingRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Location' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathLocation { get { return _staticMetaData.GetPrefetchPathElement("Location", CommonEntityBase.CreateEntityCollection<LocationEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrder' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrder { get { return _staticMetaData.GetPrefetchPathElement("WorkOrder", CommonEntityBase.CreateEntityCollection<WorkOrderEntity>()); } }

		/// <summary>The ActualCost property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ActualCost".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> ActualCost
		{
			get { return (Nullable<System.Decimal>)GetValue((int)WorkOrderRoutingFieldIndex.ActualCost, false); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ActualCost, value); }
		}

		/// <summary>The ActualEndDate property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ActualEndDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> ActualEndDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)WorkOrderRoutingFieldIndex.ActualEndDate, false); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ActualEndDate, value); }
		}

		/// <summary>The ActualResourceHrs property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ActualResourceHrs".<br/>Table field type characteristics (type, precision, scale, length): Decimal, 9, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> ActualResourceHrs
		{
			get { return (Nullable<System.Decimal>)GetValue((int)WorkOrderRoutingFieldIndex.ActualResourceHrs, false); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ActualResourceHrs, value); }
		}

		/// <summary>The ActualStartDate property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ActualStartDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> ActualStartDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)WorkOrderRoutingFieldIndex.ActualStartDate, false); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ActualStartDate, value); }
		}

		/// <summary>The LocationId property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."LocationID".<br/>Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 LocationId
		{
			get { return (System.Int16)GetValue((int)WorkOrderRoutingFieldIndex.LocationId, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.LocationId, value); }
		}

		/// <summary>The ModifiedDate property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)WorkOrderRoutingFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The OperationSequence property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."OperationSequence".<br/>Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int16 OperationSequence
		{
			get { return (System.Int16)GetValue((int)WorkOrderRoutingFieldIndex.OperationSequence, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.OperationSequence, value); }
		}

		/// <summary>The PlannedCost property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."PlannedCost".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal PlannedCost
		{
			get { return (System.Decimal)GetValue((int)WorkOrderRoutingFieldIndex.PlannedCost, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.PlannedCost, value); }
		}

		/// <summary>The ProductId property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ProductID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)WorkOrderRoutingFieldIndex.ProductId, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ProductId, value); }
		}

		/// <summary>The ScheduledEndDate property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ScheduledEndDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ScheduledEndDate
		{
			get { return (System.DateTime)GetValue((int)WorkOrderRoutingFieldIndex.ScheduledEndDate, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ScheduledEndDate, value); }
		}

		/// <summary>The ScheduledStartDate property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ScheduledStartDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ScheduledStartDate
		{
			get { return (System.DateTime)GetValue((int)WorkOrderRoutingFieldIndex.ScheduledStartDate, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ScheduledStartDate, value); }
		}

		/// <summary>The WorkOrderId property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."WorkOrderID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 WorkOrderId
		{
			get { return (System.Int32)GetValue((int)WorkOrderRoutingFieldIndex.WorkOrderId, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.WorkOrderId, value); }
		}

		/// <summary>Gets / sets related entity of type 'LocationEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual LocationEntity Location
		{
			get { return _location; }
			set { SetSingleRelatedEntityNavigator(value, "Location"); }
		}

		/// <summary>Gets / sets related entity of type 'WorkOrderEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual WorkOrderEntity WorkOrder
		{
			get { return _workOrder; }
			set { SetSingleRelatedEntityNavigator(value, "WorkOrder"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum WorkOrderRoutingFieldIndex
	{
		///<summary>ActualCost. </summary>
		ActualCost,
		///<summary>ActualEndDate. </summary>
		ActualEndDate,
		///<summary>ActualResourceHrs. </summary>
		ActualResourceHrs,
		///<summary>ActualStartDate. </summary>
		ActualStartDate,
		///<summary>LocationId. </summary>
		LocationId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>OperationSequence. </summary>
		OperationSequence,
		///<summary>PlannedCost. </summary>
		PlannedCost,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>ScheduledEndDate. </summary>
		ScheduledEndDate,
		///<summary>ScheduledStartDate. </summary>
		ScheduledStartDate,
		///<summary>WorkOrderId. </summary>
		WorkOrderId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: WorkOrderRouting. </summary>
	public partial class WorkOrderRoutingRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between WorkOrderRoutingEntity and LocationEntity over the m:1 relation they have, using the relation between the fields: WorkOrderRouting.LocationId - Location.LocationId</summary>
		public virtual IEntityRelation LocationEntityUsingLocationId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Location", false, new[] { LocationFields.LocationId, WorkOrderRoutingFields.LocationId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between WorkOrderRoutingEntity and WorkOrderEntity over the m:1 relation they have, using the relation between the fields: WorkOrderRouting.WorkOrderId - WorkOrder.WorkOrderId</summary>
		public virtual IEntityRelation WorkOrderEntityUsingWorkOrderId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "WorkOrder", false, new[] { WorkOrderFields.WorkOrderId, WorkOrderRoutingFields.WorkOrderId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticWorkOrderRoutingRelations
	{
		internal static readonly IEntityRelation LocationEntityUsingLocationIdStatic = new WorkOrderRoutingRelations().LocationEntityUsingLocationId;
		internal static readonly IEntityRelation WorkOrderEntityUsingWorkOrderIdStatic = new WorkOrderRoutingRelations().WorkOrderEntityUsingWorkOrderId;

		/// <summary>CTor</summary>
		static StaticWorkOrderRoutingRelations() { }
	}
}
