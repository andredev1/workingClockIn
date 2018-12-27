using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using Microsoft.AspNetCore.Hosting;
using MaxMind.GeoIP2;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller {

        private  IConfiguration configuration;

        public void FirstController(IConfiguration config)
        {
            this.configuration = config;
        }
        public IActionResult Index()
        {
            string ID = "EN569534";
            string connectionstring = "Server=localhost\\MSSQLSERVER01;Database=master;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand com = new SqlCommand("Select count(*) from tbl_ClockIn where fld_personalIDnumber='" + ID + "'", connection);
            var count = (int)com.ExecuteScalar();
            
                ViewData["Message"] = count;
            
            com = new SqlCommand("insert into tbl_ClockIn(fld_firstName,fld_lastName,fld_personalIDnumber,fld_osName,fld_osVersion,fld_browserName,fld_browserVersion,fld_navigatorUserAgent,fld_navigatorAppVersion,fld_navigatorPlatform,fld_navigatorVendor,fld_latitube,fld_longitude,fld_dateTime) values('penis', 'penis', '69', 'penis', 'penis', 'penis', 'penis', 'penis', 'penis', 'penis', 'penis', 'penis', 'penis', '2018-03-03'); ", connection);
            com.ExecuteScalar();
            return View();
        }

        public IActionResult MyAction()
        {
            return View();
        }

        public void NewRecord()
        {
            string ID = "EN569534";
            string connectionstring = "Server=localhost\\MSSQLSERVER01;Database=master;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand com = new SqlCommand("Select count(*) from tbl_ClockIn where fld_personalIDnumber='" + ID + "'", connection);
            var count = (int)com.ExecuteScalar();

            ViewData["Message"] = count;

            com = new SqlCommand("insert into tbl_ClockIn(fld_firstName,fld_lastName,fld_personalIDnumber,fld_osName,fld_osVersion,fld_browserName,fld_browserVersion,fld_navigatorUserAgent,fld_navigatorAppVersion,fld_navigatorPlatform,fld_navigatorVendor,fld_latitube,fld_longitude,fld_dateTime) values('penis', 'penis', '69', 'penis', 'penis', 'penis', 'penis', 'penis', 'penis', 'penis', 'penis', 'penis', 'penis', '2018-03-03'); ", connection);
            com.ExecuteScalar();
        }

        public IActionResult SendData()
        {

            return View();
        }

            public IActionResult About()
        {
            ViewData["Message"] = "You have been logged";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public String GetString(String Type)
        {
            String sReturn = "Test";
            switch (Type)
            {
                case "1":
                    sReturn = "Test 1";
                    break;
                case "2":
                    sReturn = "Test 2";
                    break;
            }
            return sReturn;
        }
    }
}

