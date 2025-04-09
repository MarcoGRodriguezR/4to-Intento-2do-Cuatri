using System.Data.SQLite;
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;

namespace Integradora;
internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MasterMind());


    }
}

/// <summary>
/// The one that hold everything SQLite related
/// </summary>
public static class DataBaseManager
{
    public const string DB_Path = "ServiKino.sqlite";
    public static readonly string ConnectionString = $"Data Source={DB_Path};Version=3;";

    #region Generic Query
    public static void ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
    {
        using (SQLiteConnection connection = new(ConnectionString))
        {
            connection.Open();
            using (SQLiteCommand command = new(query, connection))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                command.ExecuteNonQuery();
            }
        }
    }
    #endregion

    #region Specialized Query
    public static void InsertInto(string tableName, Dictionary<string, object> values)
    {
        string columns = string.Join(", ", values.Keys);
        string placeholders = string.Join(", @", values.Keys);
        string query = $"INSERT INTO {tableName} ({columns}) VALUES (@{placeholders})";
        ExecuteNonQuery(query, values);
    }

    public static List<Dictionary<string, object>> SelectFrom(string tableName, string columns, string whereCondition = null, Dictionary<string, object> parameters = null)
    {
        var results = new List<Dictionary<string, object>>();
        string query = $"SELECT {columns} FROM {tableName}";
        
        if (!string.IsNullOrEmpty(whereCondition))
        {
            query += $" WHERE {whereCondition}";
        }

        using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                // Agregar parámetros al comando si se proporcionan
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var row = new Dictionary<string, object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[reader.GetName(i)] = reader.GetValue(i);
                        }
                        results.Add(row);
                    }
                }
            }
        }

        return results;
    }

    #endregion

}