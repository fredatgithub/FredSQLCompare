using System.Collections.Generic;

namespace FredSQLCompare.Utile
{
  public static class Utility
  {
    public static Dictionary<string, string> GetSqlObjectTypes()
    {
      var result = new Dictionary<string, string>
      {
        { "Table", "Table" },
        { "StoredProcedure", "Stored Procedure" },
        { "Function", "Function" },
        { "User", "User" },
        { "Role", "Role" },
        { "Schema", "Schema" },
        { "Queue", "Queue" },
        { "Service", "Service" },
        { "View", "View" },
        { "Assembly", "Assembly" },
        { "AsymetricKey", "Asymetric Key" },
        { "Certificate", "Certificate" },
        { "Contrat", "Contrat" },
        { "DDLTrigger", "DDL Trigger" },
        { "Default", "Default" },
        { "EventNotification", "Event Notification" },
        { "ExtendedProperty", "Extended Property" },
        { "FullTextCatalog", "Full Text Catalog" },
        { "FullTextStopList", "Full Text Stop List" },
        { "MessageType", "Message Type" },
        { "PartitionFunction", "Partition Function" },
        { "PartitionScheme", "Partition Scheme" },
        { "Route", "Route" },
        { "Rule", "Rule" },
        { "SearchPropertyList", "Search Property List" },
        { "SecurityPolicy", "Security Policy" },
        { "Sequence", "Sequence" },
        { "ServiceBinding", "Service Binding" },
        { "SymetricKey", "Symetric Key" },
        { "Synonym", "Synonym" },
        { "UserDefinedType", "User Defined Type" },
        { "XMLSchemaCollection", "XML Schema Collection" }
      };

      return result;
    }

    public static Dictionary<string, string> GetFilterOperators()
    {
      var result = new Dictionary<string, string>
      {
        { "BeginsWith", "Begins With" },
        { "EndsWith", "Ends With" },
        { "Contains", "Contains" },
        { "Equals", "Equals" },
        { "DoesNotBeginWith", "Does Not Begin With" },
        { "DoesNotEndWith", "Does Not End With" },
        { "DoesNotContain", "Does Not Contain" },
        { "DoesNotEqual", "Does Not Equal" },
        { "Like", "Like" },
        { "NotLike", "Not Like" }
      };
      return result;
    }

    public static Dictionary<string, string> GetAuthenticationTypes()
    {
      var result = new Dictionary<string, string>
      {
        { "WindowsAuthenticationOnPrem", "Windows Authentication (On-Prem)" },
        { "SQLServerAuthentication", "SQL Server Authentication" },
        { "ActiveDirectoryIntegratedAuthenticationAzure", "Active Directory Integrated Authentication Azure" },
        { "ActiveDirectoryInteractiveAuthenticationAzure", "Active Directory Interactive Authentication Azure" },
        { "ActiveDirectoryPasswordAuthenticationAzure", "Active Directory Password Authentication Azure" }
      };

      return result;
    }
  }
}
