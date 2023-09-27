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

namespace ribbon_and_tab
{
     class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            string tabname = "GuoZhu_Solution";
            string panelname = "tutorial";

            //Creating the tab
            application.CreateRibbonTab(tabname);
            //Creating the panel
            var panel = application.CreateRibbonPanel(tabname, panelname);
            //Creating the buttons
            var button1 = new PushButtonData("button1_internalName", "User_visibleName", Assembly.GetExecutingAssembly().Location, "HelloWorld.ShowDialog");

            button1.ToolTip = "Here for tooltip";
            button1.LongDescription = "This is a long version description";

            var btn1 = panel.AddItem(button1) as PushButton;


            return Result.Succeeded;
        }


        public Result OnShutdown(UIControlledApplication application)
        {

            return Result.Succeeded;
        }

    }
}
