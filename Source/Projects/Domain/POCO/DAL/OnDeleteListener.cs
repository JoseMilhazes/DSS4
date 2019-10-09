// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using Iesi.Collections;
using log4net;
using NHibernate.Event;
using NHibernate.Util;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DSS4_ECompliance.BO;

namespace DSS4_ECompliance.DAL
{
    public class OnDeleteListener : IDeleteEventListener
    {
        public System.Threading.Tasks.Task OnDeleteAsync(DeleteEvent @event, CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.Run(() => OnDelete(@event), cancellationToken);
        }

        public System.Threading.Tasks.Task OnDeleteAsync(DeleteEvent @event, ISet<object> transientEntities, CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.Run(() => OnDelete(@event, transientEntities), cancellationToken);
        }

        public void OnDelete(DeleteEvent @event)
        {
            OnDelete(@event, new IdentitySet());
        }

        public void OnDelete(DeleteEvent @event, ISet<object> transientEntities)
        {
            var entity = @event.Entity;
            System.Type entityType = entity.GetType();
            if (entityType.AssemblyQualifiedName.IndexOf("ProxyAssembly", StringComparison.OrdinalIgnoreCase) > -1)
            {
                entityType = entityType.BaseType;
            }
            try
            {
                switch (entity.GetType().FullName)
                {
                case "DSS4_ECompliance.BO.tblCustomsFinder":
                    (new Repository()).DeletetblCustomsFinder((DSS4_ECompliance.BO.tblCustomsFinder)entity, true, true, null);
                    break;
                case "DSS4_ECompliance.BO.tblCustomsOveralMonitoring":
                    (new Repository()).DeletetblCustomsOveralMonitoring((DSS4_ECompliance.BO.tblCustomsOveralMonitoring)entity, true, true, null);
                    break;
                case "DSS4_ECompliance.BO.tblCustomsWayPointRisk":
                    (new Repository()).DeletetblCustomsWayPointRisk((DSS4_ECompliance.BO.tblCustomsWayPointRisk)entity, true, true, null);
                    break;
                case "DSS4_ECompliance.BO.tblCustomsWayPointVisibility":
                    (new Repository()).DeletetblCustomsWayPointVisibility((DSS4_ECompliance.BO.tblCustomsWayPointVisibility)entity, true, true, null);
                    break;
                case "DSS4_ECompliance.BO.tblCustomsWayPoint":
                    (new Repository()).DeletetblCustomsWayPoint((DSS4_ECompliance.BO.tblCustomsWayPoint)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationUserAction":
                    (new Repository()).DeleteApplicationUserAction((zAppDev.DotNet.Framework.Identity.Model.ApplicationUserAction)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationUserExternalProfile":
                    (new Repository()).DeleteApplicationUserExternalProfile((zAppDev.DotNet.Framework.Identity.Model.ApplicationUserExternalProfile)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting":
                    (new Repository()).DeleteApplicationSetting((zAppDev.DotNet.Framework.Identity.Model.ApplicationSetting)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationUser":
                    (new Repository()).DeleteApplicationUser((zAppDev.DotNet.Framework.Identity.Model.ApplicationUser)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationRole":
                    (new Repository()).DeleteApplicationRole((zAppDev.DotNet.Framework.Identity.Model.ApplicationRole)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation":
                    (new Repository()).DeleteApplicationOperation((zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission":
                    (new Repository()).DeleteApplicationPermission((zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationClient":
                    (new Repository()).DeleteApplicationClient((zAppDev.DotNet.Framework.Identity.Model.ApplicationClient)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationUserLogin":
                    (new Repository()).DeleteApplicationUserLogin((zAppDev.DotNet.Framework.Identity.Model.ApplicationUserLogin)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationUserClaim":
                    (new Repository()).DeleteApplicationUserClaim((zAppDev.DotNet.Framework.Identity.Model.ApplicationUserClaim)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ProfileSetting":
                    (new Repository()).DeleteProfileSetting((zAppDev.DotNet.Framework.Identity.Model.ProfileSetting)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.Profile":
                    (new Repository()).DeleteProfile((zAppDev.DotNet.Framework.Identity.Model.Profile)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage":
                    (new Repository()).DeleteApplicationLanguage((zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.DateTimeFormat":
                    (new Repository()).DeleteDateTimeFormat((zAppDev.DotNet.Framework.Identity.Model.DateTimeFormat)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Identity.Model.ApplicationTheme":
                    (new Repository()).DeleteApplicationTheme((zAppDev.DotNet.Framework.Identity.Model.ApplicationTheme)entity, true, true, null);
                    break;
                case "DSS4_ECompliance.BO.FileData":
                    (new Repository()).DeleteFileData((DSS4_ECompliance.BO.FileData)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Auditing.Model.AuditEntityConfiguration":
                    (new Repository()).DeleteAuditEntityConfiguration((zAppDev.DotNet.Framework.Auditing.Model.AuditEntityConfiguration)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Auditing.Model.AuditPropertyConfiguration":
                    (new Repository()).DeleteAuditPropertyConfiguration((zAppDev.DotNet.Framework.Auditing.Model.AuditPropertyConfiguration)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Auditing.Model.AuditLogEntry":
                    (new Repository()).DeleteAuditLogEntry((zAppDev.DotNet.Framework.Auditing.Model.AuditLogEntry)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Auditing.Model.AuditLogEntryType":
                    (new Repository()).DeleteAuditLogEntryType((zAppDev.DotNet.Framework.Auditing.Model.AuditLogEntryType)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Auditing.Model.AuditLogPropertyActionType":
                    (new Repository()).DeleteAuditLogPropertyActionType((zAppDev.DotNet.Framework.Auditing.Model.AuditLogPropertyActionType)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Workflow.WorkflowContextBase":
                    (new Repository()).DeleteWorkflowContextBase((zAppDev.DotNet.Framework.Workflow.WorkflowContextBase)entity, true, true, null);
                    break;
                case "zAppDev.DotNet.Framework.Workflow.WorkflowSchedule":
                    (new Repository()).DeleteWorkflowSchedule((zAppDev.DotNet.Framework.Workflow.WorkflowSchedule)entity, true, true, null);
                    break;
                }
            }
            catch (Exception e)
            {
                (LogManager.GetLogger(this.GetType())).Error("Error deleting: " + entityType.FullName, e);
                throw;
            }
        }
    }
}
