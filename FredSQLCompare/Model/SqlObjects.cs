using System.Collections.Generic;

namespace FredSQLCompare.Model
{
  public class SqlObjects
  {
    public List<string> ListOfTables { get; set; }
    public List<string> ListOfStoredProcedures { get; set; }
    public List<string> ListOfViews { get; set; }
    public List<string> ListOfConstraints { get; set; }

    public SqlObjects()
    {
      ListOfTables = new List<string>();
      ListOfStoredProcedures = new List<string>();
      ListOfViews = new List<string>();
      ListOfConstraints = new List<string>();
    }
  }
}
