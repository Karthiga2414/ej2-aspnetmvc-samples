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
        // GET: Waterfall
        public ActionResult Waterfall()
        {
            List<WaterfallChartData> chartData = new List<WaterfallChartData>
            {
                new WaterfallChartData { xValue = "Income", yValue = 4711 },
                new WaterfallChartData { xValue = "Sales", yValue = -1015 },
                new WaterfallChartData { xValue = "Development", yValue = -688 },
                new WaterfallChartData { xValue = "Revenue", yValue = 1030 },
                new WaterfallChartData { xValue = "Balance" },
                new WaterfallChartData { xValue = "Expense", yValue = -361 },
                new WaterfallChartData { xValue = "Tax", yValue = -695 },
                new WaterfallChartData { xValue = "Net Profit" },
            };
            ViewBag.dataSource = chartData;
            ViewBag.intermediateSumIndexes = new int[] {4};
            ViewBag.sumIndexes = new int[] {7};
            return View();
        }
        public class WaterfallChartData
        {
            public string xValue;
            public double yValue;
        }

    }
}