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
    ///This is a test class for ApplicationPermissionTest and is intended
    ///to contain all ApplicationPermissionTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("ApplicationPermission Repository Tests")]
    [Category("ApplicationPermission Repository Tests")]
    internal class ApplicationPermissionTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `ApplicationPermission`")]
        [Order(0)]
        public void ApplicationPermission_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _applicationsystembo_users_permissions = new zAppDev.DotNet.Framework.Identity.Model.ApplicationUser
            {
                UserName = "2940974f-5b82-495f-8746-b78a146c498cApplicationUser_UserName",
                PasswordHash = "ApplicationUser_PasswordHash",
                SecurityStamp = "ApplicationUser_SecurityStamp",
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = true,
                AccessFailedCount = 5102,
                Name = "ApplicationUser_Name",
                Email = "ApplicationUser_Email",
                PhoneNumber = "ApplicationUser_PhoneNumber",
                LockoutEndDate = now,
            };
            var _applicationsystembo_users_permissions2 = new zAppDev.DotNet.Framework.Identity.Model.ApplicationUser
            {
                UserName = "1111",
                PasswordHash = "ApplicationUser_PasswordHash",
                SecurityStamp = "ApplicationUser_SecurityStamp",
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = true,
                AccessFailedCount = 6875,
                Name = "ApplicationUser_Name",
                Email = "ApplicationUser_Email",
                PhoneNumber = "ApplicationUser_PhoneNumber",
                LockoutEndDate = now,
            };
            var _applicationsystembo_roles_permissions = new zAppDev.DotNet.Framework.Identity.Model.ApplicationRole
            {
                Name = "ApplicationRole_Name",
                Description = "ApplicationRole_Description",
                IsCustom = true,
            };
            var _applicationsystembo_roles_permissions2 = new zAppDev.DotNet.Framework.Identity.Model.ApplicationRole
            {
                Name = "ApplicationRole_Name",
                Description = "ApplicationRole_Description",
                IsCustom = true,
            };
            var _applicationsystembo_operations_permissions = new zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation
            {
                Name = "ApplicationOperation_Name",
                ParentControllerName = "ApplicationOperation_ParentControllerName",
                Type = "ApplicationOperation_Type",
                IsAvailableToAnonymous = true,
                IsAvailableToAllAuthorizedUsers = true,
            };
            var _applicationsystembo_operations_permissions2 = new zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation
            {
                Name = "ApplicationOperation_Name",
                ParentControllerName = "ApplicationOperation_ParentControllerName",
                Type = "ApplicationOperation_Type",
                IsAvailableToAnonymous = true,
                IsAvailableToAllAuthorizedUsers = true,
            };
            new PersistenceSpecification<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission>(Session)
            .CheckProperty(p => p.Name, "ApplicationPermission_Name")
            .CheckProperty(p => p.Description, "ApplicationPermission_Description")
            .CheckProperty(p => p.IsCustom, true)
            .CheckBag(p => p.Users, (new List<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>
            {
                _applicationsystembo_users_permissions,
                _applicationsystembo_users_permissions2
            }))
            .CheckBag(p => p.Roles, (new List<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>
            {
                _applicationsystembo_roles_permissions,
                _applicationsystembo_roles_permissions2
            }))
            .CheckBag(p => p.Operations, (new List<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>
            {
                _applicationsystembo_operations_permissions,
                _applicationsystembo_operations_permissions2
            }))
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `ApplicationPermission`")]
        [Order(1)]
        public void ApplicationPermission_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission>(
                              a => true
                              && (a.Name != string.Empty && a.Name != null)
                              && (a.Description != string.Empty && a.Description != null)
                              && !a.IsCustom
                              && a.Users.Any()
                              && a.Roles.Any()
                              && a.Operations.Any()
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