using System;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;
namespace HelloRevit
{[Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Automatic)]
    public class Class1:IExternalCommand
    {public Autodesk.Revit.UI.Result Execute(ExternalCommandData revit,ref string message,ElementSet elements)
        {
            try
            {
                //在执行该插件之前，先选择一些元素。本例中选择了四面墙，一条模型线，一条网格线，一个房间，一个房间标签。
                //取到当前文档。
                UIDocument uidoc = revit.Application.ActiveUIDocument;
                //取到当前文档的选择集
                Selection selection = uidoc.Selection;
                ElementSet collection = selection.Elements;

                if(0==collection.Size)
                {
                    //如果在执行该例子之前没有选择任何元素，则会弹出提示。
                    TaskDialog.Show("Revit", "你没有选任何元素.");
                }
                else
                {
                    string info = "所选元素类型为：";
                    foreach(Element elem in collection)
                    {
                        info += "\n\t" + elem.GetType( ).ToString( );
                    }

                    TaskDialog.Show("Revit", info);
                }
            }
        }
        { TaskDialog.Show("Revit", "Hello Revit");
            return Autodesk.Revit.UI.Result.Succeeded;
        }
    }
}
