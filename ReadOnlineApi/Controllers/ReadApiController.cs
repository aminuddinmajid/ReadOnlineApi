
using ReadOnlineApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;


namespace ReadOnlineApi.Controllers
{
    public class ReadApiController : Controller
    {
        // GET: ReadApi
        public ActionResult Index()
        {
            DataModel entity = new DataModel();

            string subUrl = $"users?page=2"; 
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync(subUrl).Result;
            if (response.IsSuccessStatusCode)
            {
                //need to install Microsoft.AspNet.WebApi.Client NuGet
                entity = response.Content.ReadAsAsync<DataModel>().Result;
            }

            return View(entity);
        }
    }
}