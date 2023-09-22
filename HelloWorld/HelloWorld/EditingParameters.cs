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
    public class EditingParameters : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;

            FilteredElementCollector collector = new FilteredElementCollector(doc);
            ElementCategoryFilter filter = new ElementCategoryFilter(BuiltInCategory.OST_Windows);

            //Get the elements
            IList<Element> window = collector.WherePasses(filter).WhereElementIsNotElementType().ToElements(); 

            foreach(Element ele in window)
            {
                Parameter para = ele.LookupParameter("Head Height");
                string storage = para.StorageType.ToString();
                double value = para.AsDouble();

                double newValue = UnitUtils.ConvertFromInternalUnits(value, UnitTypeId.Millimeters);
                double setvalue = UnitUtils.ConvertToInternalUnits(2100, UnitTypeId.Millimeters);

                //TaskDialog.Show("Parameters", "Parameters is a " +storage+ "with value"+ newValue);

                using (Transaction trans = new Transaction(doc,"Set Parameter"))
                {
                    trans.Start();
                    para.Set(setvalue);
                    trans.Commit();
                }
            }



            return Result.Succeeded;
        } 
    }
}
