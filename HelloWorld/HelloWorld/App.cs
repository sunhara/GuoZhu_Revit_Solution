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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Drawing.Imaging;


namespace ribbon_and_tab
{
     class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            string tabname = "GuoZhu_Solution";
            string panelname = "tutorial";

            //Bitimages
            BitmapImage bt1image = new BitmapImage(new Uri("C:\\Users\\6321011\\Desktop\\icons8.png"));

            //Creating the tab
            application.CreateRibbonTab(tabname);
            //Creating the panel
            var panel = application.CreateRibbonPanel(tabname, panelname);
            //Creating the buttons
            var button1 = new PushButtonData("button1_internalName", "User_visibleName1", Assembly.GetExecutingAssembly().Location, "HelloWorld.ShowDialog");

            button1.ToolTip = "Here for tooltip";
            button1.LongDescription = "This is a long version description";
            button1.LargeImage = bt1image;

            panel.AddItem(button1);

            //The stacked buttons
            var button2 = new PushButtonData("button2_internalName", "User_visibleName2", Assembly.GetExecutingAssembly().Location, "HelloWorld.ShowDialog");
            button2.ToolTip = "Here for tooltip2";
            button2.LongDescription = "This is a long version description2";

            var button3 = new PushButtonData("button3_internalName", "User_visibleName3", Assembly.GetExecutingAssembly().Location, "HelloWorld.ShowDialog");
            button3.ToolTip = "Here for tooltip3";
            button3.LongDescription = "This is a long version description3";

            panel.AddStackedItems(button2, button3);

            return Result.Succeeded;
        }


        public Result OnShutdown(UIControlledApplication application)
        {

            return Result.Succeeded;
        }

    }
}
