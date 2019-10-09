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
    ///This is a test class for ApplicationOperationTest and is intended
    ///to contain all ApplicationOperationTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("ApplicationOperation Repository Tests")]
    [Category("ApplicationOperation Repository Tests")]
    internal class ApplicationOperationTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `ApplicationOperation`")]
        [Order(0)]
        public void ApplicationOperation_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _applicationsystembo_permissions_operations = new zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission
            {
                Name = "ApplicationPermission_Name",
                Description = "ApplicationPermission_Description",
                IsCustom = true,
            };
            var _applicationsystembo_permissions_operations2 = new zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission
            {
                Name = "ApplicationPermission_Name",
                Description = "ApplicationPermission_Description",
                IsCustom = true,
            };
            new PersistenceSpecification<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(Session)
            .CheckProperty(p => p.Name, "ApplicationOperation_Name")
            .CheckProperty(p => p.ParentControllerName, "ApplicationOperation_ParentControllerName")
            .CheckProperty(p => p.Type, "ApplicationOperation_Type")
            .CheckProperty(p => p.IsAvailableToAnonymous, true)
            .CheckProperty(p => p.IsAvailableToAllAuthorizedUsers, true)
            .CheckBag(p => p.Permissions, (new List<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission>
            {
                _applicationsystembo_permissions_operations,
                _applicationsystembo_permissions_operations2
            }))
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `ApplicationOperation`")]
        [Order(1)]
        public void ApplicationOperation_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(
                              a => true
                              && (a.Name != string.Empty && a.Name != null)
                              && (a.ParentControllerName != string.Empty && a.ParentControllerName != null)
                              && (a.Type != string.Empty && a.Type != null)
                              && !a.IsAvailableToAnonymous
                              && !a.IsAvailableToAllAuthorizedUsers
                              && a.Permissions.Any()
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