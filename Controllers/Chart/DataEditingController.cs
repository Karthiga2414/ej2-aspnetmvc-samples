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
        public ActionResult DataEditing()
        {
            List<DataEditingData> chartData = new List<DataEditingData>
            {
                new DataEditingData { xValue = "2005", y = 21, y1= 21},
                new DataEditingData { xValue = "2006", y = 60, y1= 22},
                new DataEditingData { xValue = "2007", y = 45, y1= 36 },
                new DataEditingData { xValue = "2008", y = 50, y1= 34},
                new DataEditingData { xValue = "2009", y = 74, y1= 54 },
                new DataEditingData { xValue = "2010", y = 65, y1= 55},
                new DataEditingData { xValue = "2011", y = 85, y1= 60}
             };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class DataEditingData
        {
            public string xValue;
            public double y;
            public double y1;
        }
    }
}