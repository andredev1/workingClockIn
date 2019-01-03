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
using Newtonsoft.Json;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller {

        private  IConfiguration configuration;

        public void FirstController(IConfiguration config)
        {
            this.configuration = config;
        }
        public IActionResult Index(string firstName, string lastName, string personalIDnumber, string latitude, string longitude, string osName, string osVersion, string browserName, string browserVersion, string navigatorUserAgent, string navigatorAppVersion, string navigatorPlatform, string navigatorVendor, string dateTime)
        {
            string ID = personalIDnumber;
            string connectionstring = "Server=tcp:dv-server1234567.database.windows.net,1433;Initial Catalog=DVchoc;Persist Security Info=False;User ID=andredev1234567;Password=Kooler1234567;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand com = new SqlCommand("Select count(*) from tbl_ClockIn where fld_personalIDnumber='" + ID + "'", connection);
            var count = (int)com.ExecuteScalar();
            
            

            com = new SqlCommand("insert into tbl_ClockIn(fld_firstName,fld_lastName,fld_personalIDnumber,fld_osName,fld_osVersion,fld_browserName,fld_browserVersion,fld_navigatorUserAgent,fld_navigatorAppVersion,fld_navigatorPlatform,fld_navigatorVendor,fld_latitube,fld_longitude,fld_dateTime) values('" + firstName + "', '" + lastName + "', '" + personalIDnumber + "', '" + osName + "', '" + osVersion + "', '" + browserName + "', '" + browserVersion + "', '" + navigatorUserAgent + "', '" + navigatorAppVersion + "', '" + navigatorPlatform + "', '" + navigatorVendor + "', '" + latitude + "', '" + longitude + "', '"+System.DateTime.Now.AddHours(2) + "'); ", connection);
            com.ExecuteScalar();

            com = new SqlCommand(" DELETE FROM tbl_ClockIn WHERE fld_firstName = '';", connection);
            com.ExecuteScalar();


            return View();
        }

        [HttpPost]
        public IActionResult Send(string html)
        {
            // Process html here...

            return View();
        }

        public IActionResult MyAction()
        {
            return View();
        }

        public void NewRecord()
        {
            
        }

        public IActionResult SendData()
        {

            return View();
        }

        [HttpPost]
        public IActionResult PostAmount(int country, double amount)
        {
            return View();
        }

        public IActionResult About(string firstName, string lastName, string personalIDnumber, string latitude, string longitude, string osName, string osVersion, string browserName, string browserVersion, string navigatorUserAgent, string navigatorAppVersion, string navigatorPlatform, string navigatorVendor, string dateTime)
        {
            
            string connectionstring = "Server=tcp:dv-server1234567.database.windows.net,1433;Initial Catalog=DVchoc;Persist Security Info=False;User ID=andredev1234567;Password=Kooler1234567;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand com = new SqlCommand("insert into tbl_ClockIn(fld_firstName,fld_lastName,fld_personalIDnumber,fld_osName,fld_osVersion,fld_browserName,fld_browserVersion,fld_navigatorUserAgent,fld_navigatorAppVersion,fld_navigatorPlatform,fld_navigatorVendor,fld_latitube,fld_longitude,fld_dateTime) values('"+firstName+"', '"+lastName+"', '"+personalIDnumber+"', '"+osName+ "', '" + osVersion + "', '" + browserName + "', '" + browserVersion + "', '" + navigatorUserAgent + "', '" + navigatorAppVersion + "', '" + navigatorPlatform + "', '" + navigatorVendor + "', '" + latitude + "', '" + longitude+"', '"+ System.DateTime.Now.AddHours(2) + "'); ", connection);
            com.ExecuteScalar();

            com = new SqlCommand(" DELETE FROM tbl_ClockIn WHERE fld_firstName = '';", connection);
            com.ExecuteScalar();

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

