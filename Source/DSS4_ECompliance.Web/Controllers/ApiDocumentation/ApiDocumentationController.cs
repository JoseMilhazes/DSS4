// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System.Web.Mvc;

namespace DSS4_ECompliance.Web.Controllers
{
    [RoutePrefix("ApiDocumentation")]
    public class ApiDocumentationController : Controller
    {
        [HttpGet]
        [Route("Index")]
        public ActionResult Index()
        {
            return View("ApiDocumentation/api-documentation");
        }
    }
}
