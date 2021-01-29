// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using zAppDev.DotNet.Framework.Linq;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Workflow;
using zAppDev.DotNet.Framework.Identity.Model;

namespace DSS4_ECompliance.BO
{
    /// <summary>
    /// The tblCustomsWayPoint class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class tblCustomsWayPoint : IDomainModelClass
    {
        #region tblCustomsWayPoint's Fields

        protected Guid _transientId= Guid.NewGuid();
        public virtual Guid TransientId
        {
            get
            {
                return _transientId;
            }
            set
            {
                _transientId = value;
            }
        }
        [DataMember(Name="Id")]
        protected int? id = 0;
        [DataMember(Name="Waypoint")]
        protected string waypoint;
        [DataMember(Name="DateTime")]
        protected DateTime? dateTime;
        [DataMember(Name="Location")]
        protected string location;
        [DataMember(Name="VesselName")]
        protected string vesselName;
        [DataMember(Name="ShippingAgent")]
        protected string shippingAgent;
        [DataMember(Name="TotalConsignments")]
        protected int? totalConsignments;
        [DataMember(Name="DirectConsignments")]
        protected int? directConsignments;
        [DataMember(Name="TranshipmentConsignments")]
        protected int? transhipmentConsignments;
        [DataMember(Name="TotalEquipments")]
        protected int? totalEquipments;
        [DataMember(Name="FullEquipments")]
        protected int? fullEquipments;
        [DataMember(Name="EmptyEquipments")]
        protected int? emptyEquipments;
        [DataMember(Name="TEUSEquipments")]
        protected int? tEUSEquipments;
        [DataMember(Name="RiskDetection")]
        protected int? riskDetection;
        [DataMember(Name="From")]
        protected string from;
        [DataMember(Name="To")]
        protected string to;
        [DataMember(Name="TotalRisks")]
        protected int? totalRisks;
        [DataMember(Name="ConveyanceID")]
        protected string conveyanceID;
        [DataMember(Name="ConveyanceRef")]
        protected string conveyanceRef;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region tblCustomsWayPoint's Properties
/// <summary>
/// The Id property
///
/// </summary>
///
        [Key]
        public virtual int? Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
/// <summary>
/// The Waypoint property
///
/// </summary>
///
        public virtual string Waypoint
        {
            get
            {
                return waypoint;
            }
            set
            {
                waypoint = value;
            }
        }
/// <summary>
/// The DateTime property
///
/// </summary>
///
        public virtual DateTime? DateTime
        {
            get
            {
                return dateTime;
            }
            set
            {
                dateTime = value;
            }
        }
/// <summary>
/// The Location property
///
/// </summary>
///
        public virtual string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }
/// <summary>
/// The VesselName property
///
/// </summary>
///
        public virtual string VesselName
        {
            get
            {
                return vesselName;
            }
            set
            {
                vesselName = value;
            }
        }
/// <summary>
/// The ShippingAgent property
///
/// </summary>
///
        public virtual string ShippingAgent
        {
            get
            {
                return shippingAgent;
            }
            set
            {
                shippingAgent = value;
            }
        }
/// <summary>
/// The TotalConsignments property
///
/// </summary>
///
        public virtual int? TotalConsignments
        {
            get
            {
                return totalConsignments;
            }
            set
            {
                totalConsignments = value;
            }
        }
/// <summary>
/// The DirectConsignments property
///
/// </summary>
///
        public virtual int? DirectConsignments
        {
            get
            {
                return directConsignments;
            }
            set
            {
                directConsignments = value;
            }
        }
/// <summary>
/// The TranshipmentConsignments property
///
/// </summary>
///
        public virtual int? TranshipmentConsignments
        {
            get
            {
                return transhipmentConsignments;
            }
            set
            {
                transhipmentConsignments = value;
            }
        }
/// <summary>
/// The TotalEquipments property
///
/// </summary>
///
        public virtual int? TotalEquipments
        {
            get
            {
                return totalEquipments;
            }
            set
            {
                totalEquipments = value;
            }
        }
/// <summary>
/// The FullEquipments property
///
/// </summary>
///
        public virtual int? FullEquipments
        {
            get
            {
                return fullEquipments;
            }
            set
            {
                fullEquipments = value;
            }
        }
/// <summary>
/// The EmptyEquipments property
///
/// </summary>
///
        public virtual int? EmptyEquipments
        {
            get
            {
                return emptyEquipments;
            }
            set
            {
                emptyEquipments = value;
            }
        }
/// <summary>
/// The TEUSEquipments property
///
/// </summary>
///
        public virtual int? TEUSEquipments
        {
            get
            {
                return tEUSEquipments;
            }
            set
            {
                tEUSEquipments = value;
            }
        }
/// <summary>
/// The RiskDetection property
///
/// </summary>
///
        public virtual int? RiskDetection
        {
            get
            {
                return riskDetection;
            }
            set
            {
                riskDetection = value;
            }
        }
/// <summary>
/// The From property
///
/// </summary>
///
        public virtual string From
        {
            get
            {
                return from;
            }
            set
            {
                from = value;
            }
        }
/// <summary>
/// The To property
///
/// </summary>
///
        public virtual string To
        {
            get
            {
                return to;
            }
            set
            {
                to = value;
            }
        }
/// <summary>
/// The TotalRisks property
///
/// </summary>
///
        public virtual int? TotalRisks
        {
            get
            {
                return totalRisks;
            }
            set
            {
                totalRisks = value;
            }
        }
/// <summary>
/// The ConveyanceID property
///
/// </summary>
///
        public virtual string ConveyanceID
        {
            get
            {
                return conveyanceID;
            }
            set
            {
                conveyanceID = value;
            }
        }
/// <summary>
/// The ConveyanceRef property
///
/// </summary>
///
        public virtual string ConveyanceRef
        {
            get
            {
                return conveyanceRef;
            }
            set
            {
                conveyanceRef = value;
            }
        }
/// <summary>
/// The VersionTimestamp property
///Provides concurrency control for the class
/// </summary>
///
        public virtual byte[] VersionTimestamp
        {
            get
            {
                return versionTimestamp;
            }
            set
            {
                versionTimestamp = value;
            }
        }
        #endregion
        #region tblCustomsWayPoint's Participant Properties
        [DataMember(Name="CustomsWayPoint")]
        protected tblCustomsWayPoint customsWayPoint;
        public virtual tblCustomsWayPoint CustomsWayPoint
        {
            get
            {
                return customsWayPoint;
            }
            set
            {
                if(Equals(customsWayPoint, value)) return;
                var __oldValue = customsWayPoint;
                if (value != null)
                {
                    customsWayPoint = value;
                }
                else
                {
                    if (customsWayPoint != null)
                    {
                        customsWayPoint = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the tblCustomsWayPoint class
/// </summary>
/// <returns>New tblCustomsWayPoint object</returns>
/// <remarks></remarks>
        public tblCustomsWayPoint() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (Waypoint != null && Waypoint.Length > 100)
            {
                __errors.Add("Length of property 'Waypoint' cannot be greater than 100.");
            }
            if (Location != null && Location.Length > 100)
            {
                __errors.Add("Length of property 'Location' cannot be greater than 100.");
            }
            if (VesselName != null && VesselName.Length > 100)
            {
                __errors.Add("Length of property 'VesselName' cannot be greater than 100.");
            }
            if (ShippingAgent != null && ShippingAgent.Length > 100)
            {
                __errors.Add("Length of property 'ShippingAgent' cannot be greater than 100.");
            }
            if (From != null && From.Length > 100)
            {
                __errors.Add("Length of property 'From' cannot be greater than 100.");
            }
            if (To != null && To.Length > 100)
            {
                __errors.Add("Length of property 'To' cannot be greater than 100.");
            }
            if (ConveyanceID != null && ConveyanceID.Length > 100)
            {
                __errors.Add("Length of property 'ConveyanceID' cannot be greater than 100.");
            }
            if (ConveyanceRef != null && ConveyanceRef.Length > 100)
            {
                __errors.Add("Length of property 'ConveyanceRef' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'tblCustomsWayPoint' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (Id?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Waypoint?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (DateTime?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Location?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (VesselName?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (ShippingAgent?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TotalConsignments?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (DirectConsignments?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TranshipmentConsignments?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TotalEquipments?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (FullEquipments?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (EmptyEquipments?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TEUSEquipments?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (RiskDetection?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (From?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (To?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (TotalRisks?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (ConveyanceID?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (ConveyanceRef?.GetHashCode() ?? 0);
            return hashCode;
        }






/// <summary>
/// Copies the current object to a new instance
/// </summary>
/// <param name="deep">Copy members that refer to objects external to this class (not dependent)</param>
/// <param name="copiedObjects">Objects that should be reused</param>
/// <param name="asNew">Copy the current object as a new one, ready to be persisted, along all its members.</param>
/// <param name="reuseNestedObjects">If asNew is true, this flag if set, forces the reuse of all external objects.</param>
/// <param name="copy">Optional - An existing [tblCustomsWayPoint] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual tblCustomsWayPoint Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, tblCustomsWayPoint copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (tblCustomsWayPoint)copiedObjects[this];
            copy = copy ?? new tblCustomsWayPoint();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Waypoint = this.Waypoint;
            copy.DateTime = this.DateTime;
            copy.Location = this.Location;
            copy.VesselName = this.VesselName;
            copy.ShippingAgent = this.ShippingAgent;
            copy.TotalConsignments = this.TotalConsignments;
            copy.DirectConsignments = this.DirectConsignments;
            copy.TranshipmentConsignments = this.TranshipmentConsignments;
            copy.TotalEquipments = this.TotalEquipments;
            copy.FullEquipments = this.FullEquipments;
            copy.EmptyEquipments = this.EmptyEquipments;
            copy.TEUSEquipments = this.TEUSEquipments;
            copy.RiskDetection = this.RiskDetection;
            copy.From = this.From;
            copy.To = this.To;
            copy.TotalRisks = this.TotalRisks;
            copy.ConveyanceID = this.ConveyanceID;
            copy.ConveyanceRef = this.ConveyanceRef;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.customsWayPoint != null)
            {
                if (!copiedObjects.Contains(this.customsWayPoint))
                {
                    if (asNew && reuseNestedObjects)
                        copy.CustomsWayPoint = this.CustomsWayPoint;
                    else if (asNew)
                        copy.CustomsWayPoint = this.CustomsWayPoint.Copy(deep, copiedObjects, true);
                    else
                        copy.customsWayPoint = this.customsWayPoint.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.CustomsWayPoint = (tblCustomsWayPoint)copiedObjects[this.CustomsWayPoint];
                    else
                        copy.customsWayPoint = (tblCustomsWayPoint)copiedObjects[this.CustomsWayPoint];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as tblCustomsWayPoint;
            if (ReferenceEquals(this, compareTo))
            {
                return true;
            }
            if (compareTo == null || !this.GetType().Equals(compareTo.GetTypeUnproxied()))
            {
                return false;
            }
            if (this.HasSameNonDefaultIdAs(compareTo))
            {
                return true;
            }
            // Since the Ids aren't the same, both of them must be transient to
            // compare domain signatures; because if one is transient and the
            // other is a persisted entity, then they cannot be the same object.
            return this.IsTransient() && compareTo.IsTransient() && (base.Equals(compareTo) || this.TransientId.Equals(compareTo.TransientId));
        }

// Maintain equality operator semantics for entities.
        public static bool operator ==(tblCustomsWayPoint x, tblCustomsWayPoint y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(tblCustomsWayPoint x, tblCustomsWayPoint y)
        {
            return !(x == y);
        }

        private PropertyInfo __propertyKeyCache;
        public virtual PropertyInfo GetPrimaryKey()
        {
            if (__propertyKeyCache == null)
            {
                __propertyKeyCache = this.GetType().GetProperty("Id");
            }
            return __propertyKeyCache;
        }


/// <summary>
///     To help ensure hashcode uniqueness, a carefully selected random number multiplier
///     is used within the calculation.  Goodrich and Tamassia's Data Structures and
///     Algorithms in Java asserts that 31, 33, 37, 39 and 41 will produce the fewest number
///     of collissions.  See http://computinglife.wordpress.com/2008/11/20/why-do-hash-functions-use-prime-numbers/
///     for more information.
/// </summary>
        private const int HashMultiplier = 31;
        private int? cachedHashcode;

        public override int GetHashCode()
        {
            if (this.cachedHashcode.HasValue)
            {
                return this.cachedHashcode.Value;
            }
            if (this.IsTransient())
            {
                //this.cachedHashcode = base.GetHashCode();
                return this.TransientId.GetHashCode(); //don't cache because this won't stay transient forever
            }
            else
            {
                unchecked
                {
                    // It's possible for two objects to return the same hash code based on
                    // identically valued properties, even if they're of two different types,
                    // so we include the object's type in the hash calculation
                    var hashCode = this.GetType().GetHashCode();
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.Id.GetHashCode();
                }
            }
            return this.cachedHashcode.Value;
        }

/// <summary>
///     Transient objects are not associated with an item already in storage.  For instance,
///     a Customer is transient if its Id is 0.  It's virtual to allow NHibernate-backed
///     objects to be lazily loaded.
/// </summary>
        public virtual bool IsTransient()
        {
            return this.Id == default(int) || this.Id.Equals(default(int));
        }

/// <summary>
///     When NHibernate proxies objects, it masks the type of the actual entity object.
///     This wrapper burrows into the proxied object to get its actual type.
///
///     Although this assumes NHibernate is being used, it doesn't require any NHibernate
///     related dependencies and has no bad side effects if NHibernate isn't being used.
///
///     Related discussion is at http://groups.google.com/group/sharp-architecture/browse_thread/thread/ddd05f9baede023a ...thanks Jay Oliver!
/// </summary>
        protected virtual System.Type GetTypeUnproxied()
        {
            return this.GetType();
        }

/// <summary>
///     Returns true if self and the provided entity have the same Id values
///     and the Ids are not of the default Id value
/// </summary>
        protected bool HasSameNonDefaultIdAs(tblCustomsWayPoint compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion


    }
}