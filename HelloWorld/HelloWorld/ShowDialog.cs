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


namespace HelloWorld
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    public class ShowDialog: IExternalCommand
    {
        public Result Execute(ExternalCommandData revit, ref string message, ElementSet elements)
            {
            TaskDialog.Show("Revit", "Hl to next World");
            return Result.Succeeded;
        }
    }
}
