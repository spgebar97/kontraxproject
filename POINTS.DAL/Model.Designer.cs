﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("PointsModel", "FK_EVENT_POINT", "POINT", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(POINTS.DAL.POINT), "EVENT", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(POINTS.DAL.EVENT), true)]
[assembly: EdmRelationshipAttribute("PointsModel", "FK_EVENT_STATUS", "STATUS", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(POINTS.DAL.STATUS), "EVENT", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(POINTS.DAL.EVENT), true)]

#endregion

namespace POINTS.DAL
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class PointsEntities1 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new PointsEntities1 object using the connection string found in the 'PointsEntities1' section of the application configuration file.
        /// </summary>
        public PointsEntities1() : base("name=PointsEntities1", "PointsEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PointsEntities1 object.
        /// </summary>
        public PointsEntities1(string connectionString) : base(connectionString, "PointsEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PointsEntities1 object.
        /// </summary>
        public PointsEntities1(EntityConnection connection) : base(connection, "PointsEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<EVENT> EVENT
        {
            get
            {
                if ((_EVENT == null))
                {
                    _EVENT = base.CreateObjectSet<EVENT>("EVENT");
                }
                return _EVENT;
            }
        }
        private ObjectSet<EVENT> _EVENT;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<POINT> POINT
        {
            get
            {
                if ((_POINT == null))
                {
                    _POINT = base.CreateObjectSet<POINT>("POINT");
                }
                return _POINT;
            }
        }
        private ObjectSet<POINT> _POINT;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<STATUS> STATUS
        {
            get
            {
                if ((_STATUS == null))
                {
                    _STATUS = base.CreateObjectSet<STATUS>("STATUS");
                }
                return _STATUS;
            }
        }
        private ObjectSet<STATUS> _STATUS;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<EVENTS> EVENTS
        {
            get
            {
                if ((_EVENTS == null))
                {
                    _EVENTS = base.CreateObjectSet<EVENTS>("EVENTS");
                }
                return _EVENTS;
            }
        }
        private ObjectSet<EVENTS> _EVENTS;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the EVENT EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEVENT(EVENT eVENT)
        {
            base.AddObject("EVENT", eVENT);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the POINT EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPOINT(POINT pOINT)
        {
            base.AddObject("POINT", pOINT);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the STATUS EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSTATUS(STATUS sTATUS)
        {
            base.AddObject("STATUS", sTATUS);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the EVENTS EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEVENTS(EVENTS eVENTS)
        {
            base.AddObject("EVENTS", eVENTS);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PointsModel", Name="EVENT")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class EVENT : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new EVENT object.
        /// </summary>
        /// <param name="eVENT_ID">Initial value of the EVENT_ID property.</param>
        /// <param name="eVENT_DATE">Initial value of the EVENT_DATE property.</param>
        public static EVENT CreateEVENT(global::System.Int64 eVENT_ID, global::System.DateTime eVENT_DATE)
        {
            EVENT eVENT = new EVENT();
            eVENT.EVENT_ID = eVENT_ID;
            eVENT.EVENT_DATE = eVENT_DATE;
            return eVENT;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 EVENT_ID
        {
            get
            {
                return _EVENT_ID;
            }
            set
            {
                if (_EVENT_ID != value)
                {
                    OnEVENT_IDChanging(value);
                    ReportPropertyChanging("EVENT_ID");
                    _EVENT_ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("EVENT_ID");
                    OnEVENT_IDChanged();
                }
            }
        }
        private global::System.Int64 _EVENT_ID;
        partial void OnEVENT_IDChanging(global::System.Int64 value);
        partial void OnEVENT_IDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime EVENT_DATE
        {
            get
            {
                return _EVENT_DATE;
            }
            set
            {
                OnEVENT_DATEChanging(value);
                ReportPropertyChanging("EVENT_DATE");
                _EVENT_DATE = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EVENT_DATE");
                OnEVENT_DATEChanged();
            }
        }
        private global::System.DateTime _EVENT_DATE;
        partial void OnEVENT_DATEChanging(global::System.DateTime value);
        partial void OnEVENT_DATEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String EVENT_TEXT
        {
            get
            {
                return _EVENT_TEXT;
            }
            set
            {
                OnEVENT_TEXTChanging(value);
                ReportPropertyChanging("EVENT_TEXT");
                _EVENT_TEXT = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("EVENT_TEXT");
                OnEVENT_TEXTChanged();
            }
        }
        private global::System.String _EVENT_TEXT;
        partial void OnEVENT_TEXTChanging(global::System.String value);
        partial void OnEVENT_TEXTChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Byte> STATUS_ID
        {
            get
            {
                return _STATUS_ID;
            }
            set
            {
                OnSTATUS_IDChanging(value);
                ReportPropertyChanging("STATUS_ID");
                _STATUS_ID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("STATUS_ID");
                OnSTATUS_IDChanged();
            }
        }
        private Nullable<global::System.Byte> _STATUS_ID;
        partial void OnSTATUS_IDChanging(Nullable<global::System.Byte> value);
        partial void OnSTATUS_IDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> POINT_ID
        {
            get
            {
                return _POINT_ID;
            }
            set
            {
                OnPOINT_IDChanging(value);
                ReportPropertyChanging("POINT_ID");
                _POINT_ID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("POINT_ID");
                OnPOINT_IDChanged();
            }
        }
        private Nullable<global::System.Int32> _POINT_ID;
        partial void OnPOINT_IDChanging(Nullable<global::System.Int32> value);
        partial void OnPOINT_IDChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PointsModel", "FK_EVENT_POINT", "POINT")]
        public POINT POINT
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<POINT>("PointsModel.FK_EVENT_POINT", "POINT").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<POINT>("PointsModel.FK_EVENT_POINT", "POINT").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<POINT> POINTReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<POINT>("PointsModel.FK_EVENT_POINT", "POINT");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<POINT>("PointsModel.FK_EVENT_POINT", "POINT", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PointsModel", "FK_EVENT_STATUS", "STATUS")]
        public STATUS STATUS
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<STATUS>("PointsModel.FK_EVENT_STATUS", "STATUS").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<STATUS>("PointsModel.FK_EVENT_STATUS", "STATUS").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<STATUS> STATUSReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<STATUS>("PointsModel.FK_EVENT_STATUS", "STATUS");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<STATUS>("PointsModel.FK_EVENT_STATUS", "STATUS", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PointsModel", Name="EVENTS")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class EVENTS : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new EVENTS object.
        /// </summary>
        /// <param name="eVENT_DATE">Initial value of the EVENT_DATE property.</param>
        public static EVENTS CreateEVENTS(global::System.DateTime eVENT_DATE)
        {
            EVENTS eVENTS = new EVENTS();
            eVENTS.EVENT_DATE = eVENT_DATE;
            return eVENTS;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime EVENT_DATE
        {
            get
            {
                return _EVENT_DATE;
            }
            set
            {
                if (_EVENT_DATE != value)
                {
                    OnEVENT_DATEChanging(value);
                    ReportPropertyChanging("EVENT_DATE");
                    _EVENT_DATE = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("EVENT_DATE");
                    OnEVENT_DATEChanged();
                }
            }
        }
        private global::System.DateTime _EVENT_DATE;
        partial void OnEVENT_DATEChanging(global::System.DateTime value);
        partial void OnEVENT_DATEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String TEXT
        {
            get
            {
                return _TEXT;
            }
            set
            {
                OnTEXTChanging(value);
                ReportPropertyChanging("TEXT");
                _TEXT = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("TEXT");
                OnTEXTChanged();
            }
        }
        private global::System.String _TEXT;
        partial void OnTEXTChanging(global::System.String value);
        partial void OnTEXTChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String POINT_NUMBER
        {
            get
            {
                return _POINT_NUMBER;
            }
            set
            {
                OnPOINT_NUMBERChanging(value);
                ReportPropertyChanging("POINT_NUMBER");
                _POINT_NUMBER = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("POINT_NUMBER");
                OnPOINT_NUMBERChanged();
            }
        }
        private global::System.String _POINT_NUMBER;
        partial void OnPOINT_NUMBERChanging(global::System.String value);
        partial void OnPOINT_NUMBERChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String POINT_NAME
        {
            get
            {
                return _POINT_NAME;
            }
            set
            {
                OnPOINT_NAMEChanging(value);
                ReportPropertyChanging("POINT_NAME");
                _POINT_NAME = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("POINT_NAME");
                OnPOINT_NAMEChanged();
            }
        }
        private global::System.String _POINT_NAME;
        partial void OnPOINT_NAMEChanging(global::System.String value);
        partial void OnPOINT_NAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String STATUS
        {
            get
            {
                return _STATUS;
            }
            set
            {
                OnSTATUSChanging(value);
                ReportPropertyChanging("STATUS");
                _STATUS = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("STATUS");
                OnSTATUSChanged();
            }
        }
        private global::System.String _STATUS;
        partial void OnSTATUSChanging(global::System.String value);
        partial void OnSTATUSChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PointsModel", Name="POINT")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class POINT : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new POINT object.
        /// </summary>
        /// <param name="pOINT_ID">Initial value of the POINT_ID property.</param>
        /// <param name="pOINT_NUMBER">Initial value of the POINT_NUMBER property.</param>
        /// <param name="iS_ACTIVE">Initial value of the IS_ACTIVE property.</param>
        public static POINT CreatePOINT(global::System.Int32 pOINT_ID, global::System.String pOINT_NUMBER, global::System.Boolean iS_ACTIVE)
        {
            POINT pOINT = new POINT();
            pOINT.POINT_ID = pOINT_ID;
            pOINT.POINT_NUMBER = pOINT_NUMBER;
            pOINT.IS_ACTIVE = iS_ACTIVE;
            return pOINT;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 POINT_ID
        {
            get
            {
                return _POINT_ID;
            }
            set
            {
                if (_POINT_ID != value)
                {
                    OnPOINT_IDChanging(value);
                    ReportPropertyChanging("POINT_ID");
                    _POINT_ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("POINT_ID");
                    OnPOINT_IDChanged();
                }
            }
        }
        private global::System.Int32 _POINT_ID;
        partial void OnPOINT_IDChanging(global::System.Int32 value);
        partial void OnPOINT_IDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String POINT_NUMBER
        {
            get
            {
                return _POINT_NUMBER;
            }
            set
            {
                OnPOINT_NUMBERChanging(value);
                ReportPropertyChanging("POINT_NUMBER");
                _POINT_NUMBER = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("POINT_NUMBER");
                OnPOINT_NUMBERChanged();
            }
        }
        private global::System.String _POINT_NUMBER;
        partial void OnPOINT_NUMBERChanging(global::System.String value);
        partial void OnPOINT_NUMBERChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String POINT_NAME
        {
            get
            {
                return _POINT_NAME;
            }
            set
            {
                OnPOINT_NAMEChanging(value);
                ReportPropertyChanging("POINT_NAME");
                _POINT_NAME = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("POINT_NAME");
                OnPOINT_NAMEChanged();
            }
        }
        private global::System.String _POINT_NAME;
        partial void OnPOINT_NAMEChanging(global::System.String value);
        partial void OnPOINT_NAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IS_ACTIVE
        {
            get
            {
                return _IS_ACTIVE;
            }
            set
            {
                OnIS_ACTIVEChanging(value);
                ReportPropertyChanging("IS_ACTIVE");
                _IS_ACTIVE = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IS_ACTIVE");
                OnIS_ACTIVEChanged();
            }
        }
        private global::System.Boolean _IS_ACTIVE;
        partial void OnIS_ACTIVEChanging(global::System.Boolean value);
        partial void OnIS_ACTIVEChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PointsModel", "FK_EVENT_POINT", "EVENT")]
        public EntityCollection<EVENT> EVENT
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<EVENT>("PointsModel.FK_EVENT_POINT", "EVENT");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<EVENT>("PointsModel.FK_EVENT_POINT", "EVENT", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PointsModel", Name="STATUS")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class STATUS : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new STATUS object.
        /// </summary>
        /// <param name="sTATUS_ID">Initial value of the STATUS_ID property.</param>
        /// <param name="sTATUS_NAME">Initial value of the STATUS_NAME property.</param>
        public static STATUS CreateSTATUS(global::System.Byte sTATUS_ID, global::System.String sTATUS_NAME)
        {
            STATUS sTATUS = new STATUS();
            sTATUS.STATUS_ID = sTATUS_ID;
            sTATUS.STATUS_NAME = sTATUS_NAME;
            return sTATUS;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte STATUS_ID
        {
            get
            {
                return _STATUS_ID;
            }
            set
            {
                if (_STATUS_ID != value)
                {
                    OnSTATUS_IDChanging(value);
                    ReportPropertyChanging("STATUS_ID");
                    _STATUS_ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("STATUS_ID");
                    OnSTATUS_IDChanged();
                }
            }
        }
        private global::System.Byte _STATUS_ID;
        partial void OnSTATUS_IDChanging(global::System.Byte value);
        partial void OnSTATUS_IDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String STATUS_NAME
        {
            get
            {
                return _STATUS_NAME;
            }
            set
            {
                OnSTATUS_NAMEChanging(value);
                ReportPropertyChanging("STATUS_NAME");
                _STATUS_NAME = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("STATUS_NAME");
                OnSTATUS_NAMEChanged();
            }
        }
        private global::System.String _STATUS_NAME;
        partial void OnSTATUS_NAMEChanging(global::System.String value);
        partial void OnSTATUS_NAMEChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PointsModel", "FK_EVENT_STATUS", "EVENT")]
        public EntityCollection<EVENT> EVENT
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<EVENT>("PointsModel.FK_EVENT_STATUS", "EVENT");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<EVENT>("PointsModel.FK_EVENT_STATUS", "EVENT", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}