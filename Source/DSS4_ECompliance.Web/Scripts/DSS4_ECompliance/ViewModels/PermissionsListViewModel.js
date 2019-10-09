var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var DSS4_ECompliance;
(function (DSS4_ECompliance) {
    var ViewModels;
    (function (ViewModels) {
        var PermissionsList;
        (function (PermissionsList) {
            var PermissionsListViewModel = (function (_super) {
                __extends(PermissionsListViewModel, _super);
                function PermissionsListViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {};
                    }
                    else {
                    }
                    return _this;
                }
                PermissionsListViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    return instance;
                };
                PermissionsListViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new PermissionsListViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydratePermissionsListViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                PermissionsListViewModel.prototype._hydratePermissionsListViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    this._hydrateMasterPageViewModel(original, ignoreReadOnlyProperties, context);
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    this.ListSelectedItemKeys = original.ListSelectedItemKeys;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = PermissionsListViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        PermissionsListViewModel._deleteDropDownInitialValues(reduced);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                PermissionsListViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = PermissionsListViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    PermissionsListViewModel._deleteDropDownInitialValues(reduced);
                    return reduced;
                };
                PermissionsListViewModel._deleteDropDownInitialValues = function (reduced) {
                    if (reduced == null)
                        return;
                    DSS4_ECompliance.ViewModels.MasterPage.MasterPageViewModel._deleteDropDownInitialValues(reduced);
                };
                PermissionsListViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return PermissionsListViewModel;
            }(DSS4_ECompliance.ViewModels.MasterPage.MasterPageViewModel));
            PermissionsList.PermissionsListViewModel = PermissionsListViewModel;
        })(PermissionsList = ViewModels.PermissionsList || (ViewModels.PermissionsList = {}));
    })(ViewModels = DSS4_ECompliance.ViewModels || (DSS4_ECompliance.ViewModels = {}));
})(DSS4_ECompliance || (DSS4_ECompliance = {}));
