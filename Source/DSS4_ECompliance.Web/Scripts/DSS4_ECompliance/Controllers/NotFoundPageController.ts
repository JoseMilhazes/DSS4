// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var directiveScopeReadyLimit = 10;
var directiveScopeReadyTimeout = 200;
window.onbeforeunload = (e) => {
    if (window._context.isDirty) {
        var msg = window._resourcesManager.getGlobalResource("RES_WEBFORM_DirtyMessage");
        e.returnValue = msg;     // Gecko, Trident, Chrome 34+
        return msg;
    }
};
interface Window { scope_NotFoundPage: DSS4_ECompliance.Controllers.INotFoundPageScope; }
namespace DSS4_ECompliance.Controllers {
const NotFoundPageConditionalFormattings = [
        ];
const NotFoundPageDataValidations = [
                                    ];
const NotFoundPageCalculatedExpressions = [
        ];

// Datasets Column Info

// Datasets Projection Shemas


export interface INotFoundPageScope extends Joove.IWebPageScope {
model:
    DSS4_ECompliance.ViewModels.NotFoundPage.NotFoundPageViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,

    },
    _masterValidations?: any;
}

class NotFoundPageController {
private timeoutDelayLockButtonClicked:
    any;


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_NotFoundPage.model = window.scope_NotFoundPage.dehydrate();
        //window.scope_MasterPageSignIn.model = window.scope_NotFoundPage.model;
        DSS4_ECompliance.ViewModels.NotFoundPage.NotFoundPageViewModel._lightCast(window.scope_NotFoundPage.model);
        // Joove.Common.applyScope(window.scope_NotFoundPage);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: INotFoundPageScope, $timeout: ng.ITimeoutService) {
        window.scope_NotFoundPage = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DSS4_ECompliance.ViewModels.NotFoundPage.NotFoundPageViewModel._initializeFrom($scope.model, context);
        $scope._validationsMaster =  window.scope_MasterPageSignIn._validations;
        $scope._validations = { summary:
                                [],
                              };

        this.init($scope, $timeout);
        $timeout(() => {

            window._ruleEngine.update(Joove.EvaluationTimes.OnLoad, null, () => {

                $("body").fadeIn(200);

            });
        });

    }

    init($scope: INotFoundPageScope, $timeout: ng.ITimeoutService) {


        $scope.model = DSS4_ECompliance.ViewModels.NotFoundPage.NotFoundPageViewModel._initializeFrom(window.viewDTO.Model);

        window.scope_MasterPageSignIn.model = $scope.model;

        new Joove.ReferencesReconstructor().reconstructReferences($scope.model);
        $scope.trackObject = obj => Joove.Common.trackObject(obj);


        //}

        $.connection['eventsHub'].on('__connectedEvent');

        $.connection['eventsHub'].on('forcePageReload', () => {
            window.onbeforeunload = null;
            setTimeout(() => {
                window.location.reload();
            }, 3000);
        });
        $.connection.hub.start(() => {
            Joove.Common.getScope().connectedToSignals();
            Joove.Common.getMasterScope().connectedToSignals();

        });
        $scope.connectedToSignals = () => {
        }
// Event Listeners
        $scope.events = {
        };
        $scope.expressions = {
        }
// Dataset Handler
        $scope.datasets = {
        };
// Controller actions
        $scope.actions = {
Render:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("NotFoundPage", "Render", "GET", [], {}, _modalOptions);
            },
        };
// Events
        $scope.eventCallbacks = {
ButtonClicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                if (this.timeoutDelayLockButtonClicked != null) {
                    $timeout.cancel(this.timeoutDelayLockButtonClicked);
                }

                this.timeoutDelayLockButtonClicked = $timeout(() => {
                    Joove.Common.setControlKeyPressed(e, 0); Joove.Common.setLastClickedElement(e);

                    Joove.Validation.Manager.validateFormAndExecute(() => {
                        //This is true only when the menu item is clicked programmatically
                        //and occurs when the middle mouse button click is triggered
                        var openInNewWindow = $(e.target).data("openInNewWindow") === true || undefined;
                        if (openInNewWindow) $(e.target).data("openInNewWindow", undefined); Joove.Core.executeRedirectControllerAction("HomePage", "Render", "GET", [], null, null, openInNewWindow);
}, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                }, 0);
            },

        };

// Rules
        window._ruleEngine.addDataValidations(NotFoundPageDataValidations);
        window._ruleEngine.addConditionalFormattings(NotFoundPageConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(NotFoundPageCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPageSignIn as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("NotFoundPageController", ["$scope", "$timeout", NotFoundPageController] as Array<string>);
}
