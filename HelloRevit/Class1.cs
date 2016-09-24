using System;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
namespace HelloRevit
{[Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Class1:IExternalCommand
    {public Autodesk.Revit.UI.Result Execute(ExternalCommandData revit,ref string message,ElementSet elements)
        { TaskDialog.Show("Revit", "Hello Revit");
            return Autodesk.Revit.UI.Result.Succeeded;
        }
    }
}
