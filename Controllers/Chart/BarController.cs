#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: Bar
        public ActionResult Bar()
        {
            List<BarChartData> chartData = new List<BarChartData>
            {
                new BarChartData { x= "Egg", y= 2.2 },
                new BarChartData { x= "Fish", y= 2.4 },
                new BarChartData { x= "Misc", y= 3 },
                new BarChartData { x= "Tea", y= 3.1 }
            };
            ViewBag.dataSource = chartData;
            List<BarChartData> chartData1 = new List<BarChartData>
            {
                    new BarChartData { x= "Egg", y= 1.2 },
                    new BarChartData { x= "Fish", y= 1.3 },
                    new BarChartData { x= "Misc", y= 1.5 },
                    new BarChartData { x= "Tea", y= 2.2 }
            };
            ViewBag.dataSource1 = chartData1;
            ViewBag.font = new { fontWeight = "600", color = "#ffffff" };
            return View();
        }
        public class BarChartData
        {
            public string x;
            public double y;
        }
    }
}