namespace FredSQLCompare.Utile
{
  public class Enumerations
  {
    public enum SqlObjectTypeSimpleList
    {
      Table,
      StoredProcedure,
      Function,
      User,
      Role,
      Schema,
      Queue,
      Service,
      View
    }

    public enum SqlObjectTypeFullList
    {
      Table,
      StoredProcedure,
      Function,
      User,
      Role,
      Schema,
      Queue,
      Service,
      View,
      Assembly, // full enum
      AsymetricKey,
      Certificate,
      contrat,
      DDLTrigger,
      Default,
      EventNotification,
      ExtendedProperty,
      FullTextCatalog,
      FullTextStopList,
      MessageType,
      PartitionFunction,
      PartitionScheme,
      Route,
      Rule,
      SearchPropertyList,
      SecurityPolicy,
      Sequence,
      ServiceBinding,
      SymetricKey,
      Synonym,
      UserDefinedType,
      XMLSchemacollection
    }

    public enum FilterOperators
    {
      BeginsWith,
      EndsWith,
      Contains,
      Equals,
      DoesNotBeginWith,
      DoesNotEndWith,
      DoesNotContain,
      DoesNotEqual,
      Like,
      NotLike
    }
  }
}
