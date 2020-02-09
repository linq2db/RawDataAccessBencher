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
	/// <summary>Entity class which represents the entity 'EmployeeDepartmentHistory'.<br/><br/></summary>
	[Serializable]
	public partial class EmployeeDepartmentHistoryEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private DepartmentEntity _department;
		private EmployeeEntity _employee;
		private ShiftEntity _shift;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static EmployeeDepartmentHistoryEntityStaticMetaData _staticMetaData = new EmployeeDepartmentHistoryEntityStaticMetaData();
		private static EmployeeDepartmentHistoryRelations _relationsFactory = new EmployeeDepartmentHistoryRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Department</summary>
			public static readonly string Department = "Department";
			/// <summary>Member name Employee</summary>
			public static readonly string Employee = "Employee";
			/// <summary>Member name Shift</summary>
			public static readonly string Shift = "Shift";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class EmployeeDepartmentHistoryEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public EmployeeDepartmentHistoryEntityStaticMetaData()
			{
				SetEntityCoreInfo("EmployeeDepartmentHistoryEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.EmployeeDepartmentHistoryEntity, typeof(EmployeeDepartmentHistoryEntity), typeof(EmployeeDepartmentHistoryEntityFactory), false);
				AddNavigatorMetaData<EmployeeDepartmentHistoryEntity, DepartmentEntity>("Department", "EmployeeDepartmentHistories", (a, b) => a._department = b, a => a._department, (a, b) => a.Department = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticEmployeeDepartmentHistoryRelations.DepartmentEntityUsingDepartmentIdStatic, ()=>new EmployeeDepartmentHistoryRelations().DepartmentEntityUsingDepartmentId, null, new int[] { (int)EmployeeDepartmentHistoryFieldIndex.DepartmentId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.DepartmentEntity);
				AddNavigatorMetaData<EmployeeDepartmentHistoryEntity, EmployeeEntity>("Employee", "EmployeeDepartmentHistories", (a, b) => a._employee = b, a => a._employee, (a, b) => a.Employee = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticEmployeeDepartmentHistoryRelations.EmployeeEntityUsingEmployeeIdStatic, ()=>new EmployeeDepartmentHistoryRelations().EmployeeEntityUsingEmployeeId, null, new int[] { (int)EmployeeDepartmentHistoryFieldIndex.EmployeeId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.EmployeeEntity);
				AddNavigatorMetaData<EmployeeDepartmentHistoryEntity, ShiftEntity>("Shift", "EmployeeDepartmentHistories", (a, b) => a._shift = b, a => a._shift, (a, b) => a.Shift = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticEmployeeDepartmentHistoryRelations.ShiftEntityUsingShiftIdStatic, ()=>new EmployeeDepartmentHistoryRelations().ShiftEntityUsingShiftId, null, new int[] { (int)EmployeeDepartmentHistoryFieldIndex.ShiftId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.ShiftEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static EmployeeDepartmentHistoryEntity()
		{
		}

		/// <summary> CTor</summary>
		public EmployeeDepartmentHistoryEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public EmployeeDepartmentHistoryEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this EmployeeDepartmentHistoryEntity</param>
		public EmployeeDepartmentHistoryEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="departmentId">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="employeeId">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="shiftId">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="startDate">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		public EmployeeDepartmentHistoryEntity(System.Int16 departmentId, System.Int32 employeeId, System.Byte shiftId, System.DateTime startDate) : this(departmentId, employeeId, shiftId, startDate, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="departmentId">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="employeeId">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="shiftId">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="startDate">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="validator">The custom validator object for this EmployeeDepartmentHistoryEntity</param>
		public EmployeeDepartmentHistoryEntity(System.Int16 departmentId, System.Int32 employeeId, System.Byte shiftId, System.DateTime startDate, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.DepartmentId = departmentId;
			this.EmployeeId = employeeId;
			this.ShiftId = shiftId;
			this.StartDate = startDate;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EmployeeDepartmentHistoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Department' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDepartment() { return CreateRelationInfoForNavigator("Department"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Employee' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployee() { return CreateRelationInfoForNavigator("Employee"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Shift' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoShift() { return CreateRelationInfoForNavigator("Shift"); }
		
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
		/// <param name="validator">The validator object for this EmployeeDepartmentHistoryEntity</param>
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
		public static EmployeeDepartmentHistoryRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Department' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDepartment { get { return _staticMetaData.GetPrefetchPathElement("Department", CommonEntityBase.CreateEntityCollection<DepartmentEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployee { get { return _staticMetaData.GetPrefetchPathElement("Employee", CommonEntityBase.CreateEntityCollection<EmployeeEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Shift' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathShift { get { return _staticMetaData.GetPrefetchPathElement("Shift", CommonEntityBase.CreateEntityCollection<ShiftEntity>()); } }

		/// <summary>The DepartmentId property of the Entity EmployeeDepartmentHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "EmployeeDepartmentHistory"."DepartmentID".<br/>Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int16 DepartmentId
		{
			get { return (System.Int16)GetValue((int)EmployeeDepartmentHistoryFieldIndex.DepartmentId, true); }
			set	{ SetValue((int)EmployeeDepartmentHistoryFieldIndex.DepartmentId, value); }
		}

		/// <summary>The EmployeeId property of the Entity EmployeeDepartmentHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "EmployeeDepartmentHistory"."BusinessEntityID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 EmployeeId
		{
			get { return (System.Int32)GetValue((int)EmployeeDepartmentHistoryFieldIndex.EmployeeId, true); }
			set	{ SetValue((int)EmployeeDepartmentHistoryFieldIndex.EmployeeId, value); }
		}

		/// <summary>The EndDate property of the Entity EmployeeDepartmentHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "EmployeeDepartmentHistory"."EndDate".<br/>Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> EndDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)EmployeeDepartmentHistoryFieldIndex.EndDate, false); }
			set	{ SetValue((int)EmployeeDepartmentHistoryFieldIndex.EndDate, value); }
		}

		/// <summary>The ModifiedDate property of the Entity EmployeeDepartmentHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "EmployeeDepartmentHistory"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)EmployeeDepartmentHistoryFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)EmployeeDepartmentHistoryFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The ShiftId property of the Entity EmployeeDepartmentHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "EmployeeDepartmentHistory"."ShiftID".<br/>Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Byte ShiftId
		{
			get { return (System.Byte)GetValue((int)EmployeeDepartmentHistoryFieldIndex.ShiftId, true); }
			set	{ SetValue((int)EmployeeDepartmentHistoryFieldIndex.ShiftId, value); }
		}

		/// <summary>The StartDate property of the Entity EmployeeDepartmentHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "EmployeeDepartmentHistory"."StartDate".<br/>Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.DateTime StartDate
		{
			get { return (System.DateTime)GetValue((int)EmployeeDepartmentHistoryFieldIndex.StartDate, true); }
			set	{ SetValue((int)EmployeeDepartmentHistoryFieldIndex.StartDate, value); }
		}

		/// <summary>Gets / sets related entity of type 'DepartmentEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual DepartmentEntity Department
		{
			get { return _department; }
			set { SetSingleRelatedEntityNavigator(value, "Department"); }
		}

		/// <summary>Gets / sets related entity of type 'EmployeeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual EmployeeEntity Employee
		{
			get { return _employee; }
			set { SetSingleRelatedEntityNavigator(value, "Employee"); }
		}

		/// <summary>Gets / sets related entity of type 'ShiftEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ShiftEntity Shift
		{
			get { return _shift; }
			set { SetSingleRelatedEntityNavigator(value, "Shift"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum EmployeeDepartmentHistoryFieldIndex
	{
		///<summary>DepartmentId. </summary>
		DepartmentId,
		///<summary>EmployeeId. </summary>
		EmployeeId,
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ShiftId. </summary>
		ShiftId,
		///<summary>StartDate. </summary>
		StartDate,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: EmployeeDepartmentHistory. </summary>
	public partial class EmployeeDepartmentHistoryRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between EmployeeDepartmentHistoryEntity and DepartmentEntity over the m:1 relation they have, using the relation between the fields: EmployeeDepartmentHistory.DepartmentId - Department.DepartmentId</summary>
		public virtual IEntityRelation DepartmentEntityUsingDepartmentId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Department", false, new[] { DepartmentFields.DepartmentId, EmployeeDepartmentHistoryFields.DepartmentId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeDepartmentHistoryEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields: EmployeeDepartmentHistory.EmployeeId - Employee.EmployeeId</summary>
		public virtual IEntityRelation EmployeeEntityUsingEmployeeId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Employee", false, new[] { EmployeeFields.EmployeeId, EmployeeDepartmentHistoryFields.EmployeeId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeDepartmentHistoryEntity and ShiftEntity over the m:1 relation they have, using the relation between the fields: EmployeeDepartmentHistory.ShiftId - Shift.ShiftId</summary>
		public virtual IEntityRelation ShiftEntityUsingShiftId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Shift", false, new[] { ShiftFields.ShiftId, EmployeeDepartmentHistoryFields.ShiftId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticEmployeeDepartmentHistoryRelations
	{
		internal static readonly IEntityRelation DepartmentEntityUsingDepartmentIdStatic = new EmployeeDepartmentHistoryRelations().DepartmentEntityUsingDepartmentId;
		internal static readonly IEntityRelation EmployeeEntityUsingEmployeeIdStatic = new EmployeeDepartmentHistoryRelations().EmployeeEntityUsingEmployeeId;
		internal static readonly IEntityRelation ShiftEntityUsingShiftIdStatic = new EmployeeDepartmentHistoryRelations().ShiftEntityUsingShiftId;

		/// <summary>CTor</summary>
		static StaticEmployeeDepartmentHistoryRelations() { }
	}
}
