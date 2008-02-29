using Rubicon.Utilities;

namespace Rubicon.Data.Linq.DataObjectModel
{
  public struct Column : IColumn, ICriterion
  {
    public readonly string Name;
    public readonly Table Table;

    public Column (Table table,string name)
    {
      ArgumentUtility.CheckNotNull ("name", name);
      ArgumentUtility.CheckNotNull ("table", table);
      Name = name;
      Table = table;
    }

    public override string ToString ()
    {
      return (Table != null ? Table.AliasString : "<null>") + "." + Name;
    }
  }
}