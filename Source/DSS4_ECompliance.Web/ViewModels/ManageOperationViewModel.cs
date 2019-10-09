// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS4_ECompliance.BO;
using DSS4_ECompliance.UI.Controllers.ManageOperation;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS4_ECompliance.UI.ViewModels.MasterPageForSlide;
using DSS4_ECompliance.UI.Controllers.MasterPageForSlide;
namespace DSS4_ECompliance.UI.ViewModels.ManageOperation
{
    public class ManageOperationViewModel : MasterPageForSlideViewModel
    {
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation ApplicationOperation;
        public List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission>> Button2SelectedItems;


        public ManageOperationViewModel()
        {
            ApplicationOperation = new zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation();
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
            if (manager.Session.Contains(ApplicationOperation))
            {
                manager.Session.Evict(ApplicationOperation);
            }
        }

    }


    [OriginalType(typeof(DSS4_ECompliance.UI.ViewModels.ManageOperation.ManageOperationViewModel))]
    public class ManageOperationViewModelDTO : MasterPageForSlideViewModelDTO, IViewModelDTO<DSS4_ECompliance.UI.ViewModels.ManageOperation.ManageOperationViewModel>
    {

        [JsonConstructor]
        public ManageOperationViewModelDTO() { }
        public ManageOperationViewModelDTO(DSS4_ECompliance.UI.ViewModels.ManageOperation.ManageOperationViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            ApplicationOperation = original.ApplicationOperation == null ? null : new ApplicationOperation_ApplicationOperationDTO(original.ApplicationOperation);
            Button2SelectedItemKeys = original.Button2SelectedItems == null
                                      ? null
                                      : original.Button2SelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
        public ApplicationOperation_ApplicationOperationDTO ApplicationOperation;
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS4_ECompliance.UI.ViewModels.ManageOperation.ManageOperationViewModel).FullName;
        public List<SelectedItemInfo<int?>> Button2SelectedItemKeys;

        public new DSS4_ECompliance.UI.ViewModels.ManageOperation.ManageOperationViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS4_ECompliance.UI.ViewModels.ManageOperation.ManageOperationViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS4_ECompliance.UI.ViewModels.ManageOperation.ManageOperationViewModel();
        }
        new  public DSS4_ECompliance.UI.ViewModels.ManageOperation.ManageOperationViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS4_ECompliance.UI.ViewModels.ManageOperation.ManageOperationViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS4_ECompliance.UI.ViewModels.ManageOperation.ManageOperationViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.ApplicationOperation = ApplicationOperation == null
                                            ? null
                                            : ApplicationOperation.Convert();
            original.Button2SelectedItems = Button2SelectedItemKeys == null
                                            ? new List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission>>()
                                            : Button2SelectedItemKeys.Select(x => new SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission>(x.SelectedItems.Select(y => ViewModels.ManageOperation.Button2DataSet_ApplicationPermissionDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
    }

    [OriginalType(typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation))]
    public class ApplicationOperation_ApplicationOperationDTO : ViewModelDTOBase, IViewModelDTO<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>
    {

        [JsonConstructor]
        public ApplicationOperation_ApplicationOperationDTO() { }
        public ApplicationOperation_ApplicationOperationDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.Id as object;
            Id = original.Id;
            IsAvailableToAllAuthorizedUsers = original.IsAvailableToAllAuthorizedUsers;
            IsAvailableToAnonymous = original.IsAvailableToAnonymous;
            Name = original.Name;
            ParentControllerName = original.ParentControllerName;
            Type = original.Type;
            Permissions = original.Permissions?.Select(x => new ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionDTO(x)).ToList();
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public bool IsAvailableToAllAuthorizedUsers;
        public bool IsAvailableToAnonymous;
        public string Name;
        public string ParentControllerName;
        public string Type;
        public List<ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionDTO> Permissions;
        public string _versionTimestamp;
        public  string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation).FullName;
        public override List<string> _baseClasses => null;
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            if (_key == null) return null;
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            if (parsedKey == default(int) || Equals(parsedKey, default(int)))
            {
                return new zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation();
            }
            return new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(parsedKey, false);
        }
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation original)
        {
            if (original == null) return;
            original.Id = Id ?? 0;
            original.IsAvailableToAllAuthorizedUsers = IsAvailableToAllAuthorizedUsers;
            original.IsAvailableToAnonymous = IsAvailableToAnonymous;
            original.Name = Name;
            original.ParentControllerName = ParentControllerName;
            original.Type = Type;
            original.Permissions = Permissions == null
                                   ? null
                                   : Permissions.Select(q => q.Convert()).ToList();
            original.VersionTimestamp = string.IsNullOrEmpty(this._versionTimestamp) ? null : BitConverter.GetBytes(Int64.Parse(this._versionTimestamp));
        }
        public static ApplicationOperation_ApplicationOperationDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(parsedKey, true);
            if(foundEntry != null)
            {
                return new ApplicationOperation_ApplicationOperationDTO(foundEntry);
            }
            return null;
        }
    }

    [OriginalType(typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission))]
    public class ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionDTO : ViewModelDTOBase, IViewModelDTO<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission>
    {

        [JsonConstructor]
        public ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionDTO() { }
        public ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.Id as object;
            Description = original.Description;
            Id = original.Id;
            IsCustom = original.IsCustom;
            Name = original.Name;
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public string Description;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public bool IsCustom;
        public string Name;
        public string _versionTimestamp;
        public  string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission).FullName;
        public override List<string> _baseClasses => null;
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            if (_key == null) return null;
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            if (parsedKey == default(int) || Equals(parsedKey, default(int)))
            {
                return new zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission();
            }
            return new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission>(parsedKey, false);
        }
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission original)
        {
            if (original == null) return;
            original.Description = Description;
            original.Id = Id ?? 0;
            original.IsCustom = IsCustom;
            original.Name = Name;
            original.VersionTimestamp = string.IsNullOrEmpty(this._versionTimestamp) ? null : BitConverter.GetBytes(Int64.Parse(this._versionTimestamp));
        }
        public static ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission>(parsedKey, true);
            if(foundEntry != null)
            {
                return new ApplicationOperation_ApplicationOperation_Permissions_ApplicationPermissionDTO(foundEntry);
            }
            return null;
        }
    }


    #region Datasource DTOs
    [OriginalType(typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission))]
    [DataSetDTO]
    public class Button2DataSet_ApplicationPermissionDTO : ViewModelDTOBase, IViewModelDTO<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission>
    {
        public override string _originalTypeClassName => typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public string Name;
        public string Description;


        [JsonConstructor]
        public Button2DataSet_ApplicationPermissionDTO() : base() {}
        public  static Button2DataSet_ApplicationPermissionDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new ManageOperationController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new Button2DataSet_ApplicationPermissionDTO(foundEntry);
            }
            return null;
        }
        public Button2DataSet_ApplicationPermissionDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public Button2DataSet_ApplicationPermissionDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission original)
        {
            if(original == null) throw new ApplicationException(BaseViewPage<object>.GetResourceValue("GlobalResources", "RES_DATASOURCE_Null_Value_In_Resultset", null, "The resultset of your DataSource contains null values."));
            _key = (original.Id == 0) ? original._GetUniqueIdentifier() as object : original.Id as object;
            _runtimeType = original?.GetType().FullName;
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            Id = original.Id;
            if (!DTOHelper.SeenDTOInstances.ContainsKey(original))
            {
                DTOHelper.SeenDTOInstances.Add(original, this);
            }
            Name = original.Name;
            Description = original.Description;
        }

        public static zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            return new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission>(parsedKey, false);
        }
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission Convert()
        {
            var model = new zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission();
            if (_key != null && _key.ToString() != "0")
            {
                var rawKey = _key.ToString();
                var parsedKey = int.Parse(rawKey);
                model = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationPermission>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.Id = Id ?? 0;
            model.Name = Name;
            model.Description = Description;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }

    #endregion

}
