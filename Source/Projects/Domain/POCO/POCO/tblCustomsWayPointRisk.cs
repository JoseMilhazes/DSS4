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
    /// The tblCustomsWayPointRisk class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class tblCustomsWayPointRisk : IDomainModelClass
    {
        #region tblCustomsWayPointRisk's Fields

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
        [DataMember(Name="WaypointriskID")]
        protected long? waypointriskID = 0L;
        [DataMember(Name="Consignment")]
        protected string consignment;
        [DataMember(Name="CargoId")]
        protected string cargoId;
        [DataMember(Name="RiskTypeId")]
        protected string riskTypeId;
        [DataMember(Name="RiskScore")]
        protected string riskScore;
        [DataMember(Name="Severity")]
        protected string severity;
        [DataMember(Name="Details")]
        protected string details;
        [DataMember(Name="Suggestions")]
        protected string suggestions;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region tblCustomsWayPointRisk's Properties
/// <summary>
/// The WaypointriskID property
///
/// </summary>
///
        [Key]
        public virtual long? WaypointriskID
        {
            get
            {
                return waypointriskID;
            }
            set
            {
                waypointriskID = value;
            }
        }
/// <summary>
/// The Consignment property
///
/// </summary>
///
        public virtual string Consignment
        {
            get
            {
                return consignment;
            }
            set
            {
                consignment = value;
            }
        }
/// <summary>
/// The CargoId property
///
/// </summary>
///
        public virtual string CargoId
        {
            get
            {
                return cargoId;
            }
            set
            {
                cargoId = value;
            }
        }
/// <summary>
/// The RiskTypeId property
///
/// </summary>
///
        public virtual string RiskTypeId
        {
            get
            {
                return riskTypeId;
            }
            set
            {
                riskTypeId = value;
            }
        }
/// <summary>
/// The RiskScore property
///
/// </summary>
///
        public virtual string RiskScore
        {
            get
            {
                return riskScore;
            }
            set
            {
                riskScore = value;
            }
        }
/// <summary>
/// The Severity property
///
/// </summary>
///
        public virtual string Severity
        {
            get
            {
                return severity;
            }
            set
            {
                severity = value;
            }
        }
/// <summary>
/// The Details property
///
/// </summary>
///
        public virtual string Details
        {
            get
            {
                return details;
            }
            set
            {
                details = value;
            }
        }
/// <summary>
/// The Suggestions property
///
/// </summary>
///
        public virtual string Suggestions
        {
            get
            {
                return suggestions;
            }
            set
            {
                suggestions = value;
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
        #region tblCustomsWayPointRisk's Participant Properties
        [DataMember(Name="tblCustomsWayPoint")]
        protected tblCustomsWayPoint _tblCustomsWayPoint;
        public virtual tblCustomsWayPoint tblCustomsWayPoint
        {
            get
            {
                return _tblCustomsWayPoint;
            }
            set
            {
                if(Equals(_tblCustomsWayPoint, value)) return;
                var __oldValue = _tblCustomsWayPoint;
                if (value != null)
                {
                    _tblCustomsWayPoint = value;
                }
                else
                {
                    if (_tblCustomsWayPoint != null)
                    {
                        _tblCustomsWayPoint = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the tblCustomsWayPointRisk class
/// </summary>
/// <returns>New tblCustomsWayPointRisk object</returns>
/// <remarks></remarks>
        public tblCustomsWayPointRisk() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (WaypointriskID == null)
            {
                __errors.Add("Property 'WaypointriskID' is required.");
            }
            if (Consignment != null && Consignment.Length > 100)
            {
                __errors.Add("Length of property 'Consignment' cannot be greater than 100.");
            }
            if (CargoId != null && CargoId.Length > 100)
            {
                __errors.Add("Length of property 'CargoId' cannot be greater than 100.");
            }
            if (RiskTypeId != null && RiskTypeId.Length > 100)
            {
                __errors.Add("Length of property 'RiskTypeId' cannot be greater than 100.");
            }
            if (RiskScore != null && RiskScore.Length > 100)
            {
                __errors.Add("Length of property 'RiskScore' cannot be greater than 100.");
            }
            if (Severity != null && Severity.Length > 100)
            {
                __errors.Add("Length of property 'Severity' cannot be greater than 100.");
            }
            if (Details != null && Details.Length > 100)
            {
                __errors.Add("Length of property 'Details' cannot be greater than 100.");
            }
            if (Suggestions != null && Suggestions.Length > 100)
            {
                __errors.Add("Length of property 'Suggestions' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'tblCustomsWayPointRisk' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (WaypointriskID?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Consignment?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (CargoId?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (RiskTypeId?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (RiskScore?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Severity?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Details?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Suggestions?.GetHashCode() ?? 0);
            return hashCode;
        }






/// <summary>
/// Copies the current object to a new instance
/// </summary>
/// <param name="deep">Copy members that refer to objects external to this class (not dependent)</param>
/// <param name="copiedObjects">Objects that should be reused</param>
/// <param name="asNew">Copy the current object as a new one, ready to be persisted, along all its members.</param>
/// <param name="reuseNestedObjects">If asNew is true, this flag if set, forces the reuse of all external objects.</param>
/// <param name="copy">Optional - An existing [tblCustomsWayPointRisk] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual tblCustomsWayPointRisk Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, tblCustomsWayPointRisk copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (tblCustomsWayPointRisk)copiedObjects[this];
            copy = copy ?? new tblCustomsWayPointRisk();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.WaypointriskID = this.WaypointriskID;
            }
            copy.Consignment = this.Consignment;
            copy.CargoId = this.CargoId;
            copy.RiskTypeId = this.RiskTypeId;
            copy.RiskScore = this.RiskScore;
            copy.Severity = this.Severity;
            copy.Details = this.Details;
            copy.Suggestions = this.Suggestions;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this._tblCustomsWayPoint != null)
            {
                if (!copiedObjects.Contains(this._tblCustomsWayPoint))
                {
                    if (asNew && reuseNestedObjects)
                        copy.tblCustomsWayPoint = this.tblCustomsWayPoint;
                    else if (asNew)
                        copy.tblCustomsWayPoint = this.tblCustomsWayPoint.Copy(deep, copiedObjects, true);
                    else
                        copy._tblCustomsWayPoint = this._tblCustomsWayPoint.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.tblCustomsWayPoint = (tblCustomsWayPoint)copiedObjects[this.tblCustomsWayPoint];
                    else
                        copy._tblCustomsWayPoint = (tblCustomsWayPoint)copiedObjects[this.tblCustomsWayPoint];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as tblCustomsWayPointRisk;
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
        public static bool operator ==(tblCustomsWayPointRisk x, tblCustomsWayPointRisk y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(tblCustomsWayPointRisk x, tblCustomsWayPointRisk y)
        {
            return !(x == y);
        }

        private PropertyInfo __propertyKeyCache;
        public virtual PropertyInfo GetPrimaryKey()
        {
            if (__propertyKeyCache == null)
            {
                __propertyKeyCache = this.GetType().GetProperty("WaypointriskID");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.WaypointriskID.GetHashCode();
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
            return this.WaypointriskID == default(long) || this.WaypointriskID.Equals(default(long));
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
        protected bool HasSameNonDefaultIdAs(tblCustomsWayPointRisk compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.WaypointriskID.Equals(compareTo.WaypointriskID);
        }

        #endregion


    }
}
