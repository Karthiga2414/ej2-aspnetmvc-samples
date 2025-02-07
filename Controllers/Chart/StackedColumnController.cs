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
        // GET: StackedColumn
        public ActionResult StackedColumn()
        {
            List<StackedColumnChartData> chartData = new List<StackedColumnChartData>
            {
                    new StackedColumnChartData { x= "2014", y= 111.1 },
                    new StackedColumnChartData { x= "2015", y= 127.3 },
                    new StackedColumnChartData { x= "2016", y= 143.4 },
                    new StackedColumnChartData { x= "2017", y= 159.9 }
            };
            ViewBag.dataSource = chartData;
            List<StackedColumnChartData> chartData1 = new List<StackedColumnChartData>
            {
                    new StackedColumnChartData { x= "2014", y= 76.9 },
                    new StackedColumnChartData { x= "2015", y= 99.5 },
                    new StackedColumnChartData { x= "2016", y= 121.7 },
                    new StackedColumnChartData { x= "2017", y= 142.5 }
            };
            ViewBag.dataSource1 = chartData1;
            List<StackedColumnChartData> chartData2 = new List<StackedColumnChartData>
            {
                    new StackedColumnChartData { x= "2014", y= 66.1 },
                    new StackedColumnChartData { x= "2015", y= 79.3 },
                    new StackedColumnChartData { x= "2016", y= 91.3 },
                    new StackedColumnChartData { x= "2017", y= 102.4 }
            };
            ViewBag.dataSource2 = chartData2;
            List<StackedColumnChartData> chartData3 = new List<StackedColumnChartData>
            {
                    new StackedColumnChartData { x= "2014", y= 34.1 },
                    new StackedColumnChartData { x= "2015", y= 38.2 },
                    new StackedColumnChartData { x= "2016", y= 44.0 },
                    new StackedColumnChartData { x= "2017", y= 51.6 }
            };
            ViewBag.dataSource3 = chartData3;
            return View();
        }
        public class StackedColumnChartData
        {
            public string x;
            public double y;
        }
    }
}