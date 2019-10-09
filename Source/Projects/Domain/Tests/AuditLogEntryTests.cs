// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using FluentNHibernate.Testing;
using DSS4_ECompliance.BO;
using DSS4_ECompliance.BoTesting.Tests.Common;
using DSS4_ECompliance.DAL;

namespace DSS4_ECompliance.BoTesting.Tests
{
    /// <summary>
    ///This is a test class for AuditLogEntryTest and is intended
    ///to contain all AuditLogEntryTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("AuditLogEntry Repository Tests")]
    [Category("AuditLogEntry Repository Tests")]
    internal class AuditLogEntryTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `AuditLogEntry`")]
        [Order(0)]
        public void AuditLogEntry_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<zAppDev.DotNet.Framework.Auditing.Model.AuditLogEntry>(Session)
            .CheckProperty(p => p.UserName, "AuditLogEntry_UserName")
            .CheckProperty(p => p.IPAddress, "AuditLogEntry_IPAddress")
            .CheckProperty(p => p.EntityFullName, "AuditLogEntry_EntityFullName")
            .CheckProperty(p => p.EntityShortName, "AuditLogEntry_EntityShortName")
            .CheckProperty(p => p.EntityId, "AuditLogEntry_EntityId")
            .CheckProperty(p => p.Timestamp, now)
            .CheckProperty(p => p.EntryTypeId, 5722)
            .CheckProperty(p => p.ActionTypeId, 4784)
            .CheckProperty(p => p.OldValue, "AuditLogEntry_OldValue")
            .CheckProperty(p => p.NewValue, "AuditLogEntry_NewValue")
            .CheckProperty(p => p.PropertyName, "AuditLogEntry_PropertyName")
            .CheckProperty(p => p.ExtraField1, "AuditLogEntry_ExtraField1")
            .CheckProperty(p => p.ExtraField2, "AuditLogEntry_ExtraField2")
            .CheckProperty(p => p.ExtraField3, "AuditLogEntry_ExtraField3")
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `AuditLogEntry`")]
        [Order(1)]
        public void AuditLogEntry_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<zAppDev.DotNet.Framework.Auditing.Model.AuditLogEntry> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<zAppDev.DotNet.Framework.Auditing.Model.AuditLogEntry>(
                              a => true
                              && (a.UserName != string.Empty && a.UserName != null)
                              && (a.IPAddress != string.Empty && a.IPAddress != null)
                              && (a.EntityFullName != string.Empty && a.EntityFullName != null)
                              && (a.EntityShortName != string.Empty && a.EntityShortName != null)
                              && (a.EntityId != string.Empty && a.EntityId != null)
                              && a.Timestamp.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.EntryTypeId + 123 > 0)
                              && (a.ActionTypeId + 123 > 0)
                              && (a.OldValue != string.Empty && a.OldValue != null)
                              && (a.NewValue != string.Empty && a.NewValue != null)
                              && (a.PropertyName != string.Empty && a.PropertyName != null)
                              && (a.ExtraField1 != string.Empty && a.ExtraField1 != null)
                              && (a.ExtraField2 != string.Empty && a.ExtraField2 != null)
                              && (a.ExtraField3 != string.Empty && a.ExtraField3 != null)
                              ,
                              cacheQuery: true)
                          .OrderBy(a => a)
                          .Skip(0)
                          .Take(3)
                          .ToList();
            });
            Assert.AreNotEqual(null, results);
        }
    }
}