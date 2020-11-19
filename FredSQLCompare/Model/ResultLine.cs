using System;
using static FredSQLCompare.Utile.Enumerations;

namespace FredSQLCompare.Model
{
  public class ResultLine
  {
    public SqlObjectTypeSimpleList SourceSqlObjectType { get; set; }

    public DateTime SourceLastModified { get; set; }
    public string SourceSqlObjectName { get; set; }
    public bool SqlObjectSelected { get; set; }
    public string TargetSqlObjectName { get; set; }
    public DateTime TargetLastModified { get; set; }

    public ResultLine()
    {

    }

    public ResultLine(SqlObjectTypeSimpleList sqlType, DateTime sourceLastModified, string sourceSqlObjectName, bool sqlObjectSelected, string targetSqlObjectName, DateTime targetLastModified)
    {
      SourceSqlObjectType = sqlType;
      SourceLastModified = sourceLastModified;
      SourceSqlObjectName = sourceSqlObjectName;
      SqlObjectSelected = sqlObjectSelected;
      TargetSqlObjectName = targetSqlObjectName;
      TargetLastModified = targetLastModified;
    }
  }
}
