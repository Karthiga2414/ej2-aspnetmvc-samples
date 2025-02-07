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
        // GET: Selection
        public ActionResult Selection()
        {
            List<SelectionChartData> chartData = new List<SelectionChartData>
            {
                new SelectionChartData { xValue = "CHN", yValue = 17, yValue1 = 54, yValue2 = 9  },
                new SelectionChartData { xValue = "USA", yValue = 19, yValue1 = 67, yValue2 = 14 },
                new SelectionChartData { xValue = "IDN", yValue = 29, yValue1 = 65, yValue2 = 6  },
                new SelectionChartData { xValue = "JAP", yValue = 13, yValue1 = 61, yValue2 = 26 },
                new SelectionChartData { xValue = "BRZ", yValue = 24, yValue1 = 68, yValue2 = 8  }
            };
            ViewBag.dataSource = chartData;
            ViewBag.data = new string[] { "Point", "Series", "Cluster"};
            ViewBag.datapattern = new string[] { "None", "Turquoise", "Chessboard", "Triangle", "Box", "Bubble" };
            return View();
        }
        public class SelectionChartData
        {
            public string xValue;
            public double yValue;
            public double yValue1;
            public double yValue2;
        }
    }
}