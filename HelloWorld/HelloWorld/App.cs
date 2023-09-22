using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.DB.Architecture;
using System.Reflection;

namespace ShowDialog
{
     class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            string tabname = "GuoZhu_Solution";
            string panelname = "tutorial";

            //Creating the tab
            var panel = application.CreateRibbonPanel(tabname, panelname);
            var button1 = new PushButtonData("", "", "", "");

            return Result.Succeeded;
        }


        public Result OnStartup(UIControlledApplication application)
        {

            return Result.Succeeded;
        }

    }
}
