using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace FredSQLCompare.DAL
{
  public static class DALHelper
  {
    public static string GetConnexionString(string databaseName = "master", string sqlServerName = ".")
    {
      return $"Data Source={sqlServerName};Initial Catalog={databaseName};Integrated Security=True";
    }

    public static string ExecuteSqlQueryOneResult(string sqlQuery, string databaseName, string sqlServerName)
    {
      string result = string.Empty;
      string connectionString = GetConnexionString(databaseName, sqlServerName);
      // query = "SELECT TOP(1) Date FROM tableName order by date DESC";
      string query = sqlQuery;

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        SqlCommand command = new SqlCommand(query, connection);
        try
        {
          connection.Open();
          var queryResult = command.ExecuteScalar();
          if (queryResult == null)
          {
            result = string.Empty;
          }
          else
          {
            result = queryResult.ToString();
          }
        }
        catch (Exception exception)
        {
          Console.WriteLine(exception.Message);
        }
        finally
        {
          connection.Close();
        }
      }

      if (result == null)
      {
        result = string.Empty;
      }

      return result;
    }

    public static SqlDataReader ExecuteSqlQueryManyResults(string sqlQuery, string databaseName, string sqlServerName)
    {
      SqlDataReader result = null;
      string connectionString = GetConnexionString(databaseName, sqlServerName);
      // query = "SELECT * FROM tableName";
      string query = sqlQuery;

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        SqlCommand command = new SqlCommand(query, connection);
        try
        {
          connection.Open();
          SqlDataReader queryResult = command.ExecuteReader();
          if (queryResult == null)
          {
            result = null;
          }
          else
          {
            result = queryResult;
          }
        }
        catch (Exception)
        {
          //MessageBox.show(exception.Message);
        }
        finally
        {
          connection.Close();
        }
      }

      return result;
    }

    public static bool WriteToDatabase(string sqlQuery, DateTime requestDate, double euro, double dollar)
    {
      bool result = false;
      using (SqlConnection connection = new SqlConnection(GetConnexionString()))
      {
        //string query = "INSERT INTO [dbo].[BitCoin] ([Date], [RateEuros], [RateDollar]) VALUES(@theDate, @rateEuro, @ratedollar)";
        string query = sqlQuery;

        using (SqlCommand command = new SqlCommand(query, connection))
        {
          command.Parameters.AddWithValue("@theDate", requestDate);
          command.Parameters.AddWithValue("@rateEuro", euro);
          command.Parameters.AddWithValue("@ratedollar", dollar);

          connection.Open();
          var QueryResult = command.ExecuteNonQuery();

          // Check Error
          if (QueryResult < 0)
          {
            result = false;
          }
          else
          {
            result = true;
          }
        }
      }

      return result;
    }

    public static List<T> DataReaderMapToList<T>(IDataReader dr)
    {
      List<T> list = new List<T>();
      T obj = default(T);
      while (dr.Read())
      {
        obj = Activator.CreateInstance<T>();
        foreach (PropertyInfo prop in obj.GetType().GetProperties())
        {
          if (!object.Equals(dr[prop.Name], DBNull.Value))
          {
            prop.SetValue(obj, dr[prop.Name], null);
          }
        }

        list.Add(obj);
      }

      return list;
    }

    public static IEnumerable<string> GetData(string filter, Func<IDataRecord, string> factory, string databaseName, string sqlServerName, string sqlQuery)
    {
      //string sql = "SELECT * FROM [SomeTable] WHERE SomeColumn= @Filter";

      using (SqlConnection cn = new SqlConnection(GetConnexionString(databaseName, sqlServerName)))
      using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
      {
        cmd.Parameters.Add("@Filter", SqlDbType.NVarChar, 255).Value = filter;
        cn.Open();

        using (IDataReader rdr = cmd.ExecuteReader())
        {
          while (rdr.Read())
          {
            yield return factory(rdr);
          }

          rdr.Close();
        }
      }
    }
  }
}
