using BatteryCharge.Properties;
using System.Data.SQLite;
using System.Collections.Generic;
using System;
using System.IO;

namespace BatteryCharge
{
    class SqlDB
    {
        string databaseName = Directory.GetCurrentDirectory() + @"\batterydata.db";
        public void Create() {
            if (!File.Exists(databaseName))
            {
                SQLiteConnection.CreateFile(databaseName);
                SQLiteConnection connect = new SQLiteConnection(String.Format("Data Source={0};", databaseName));
                SQLiteCommand command = new SQLiteCommand("CREATE TABLE main (current TEXT, percent REAL," +
                    " bstatus TEXT, pstatus TEXT);", connect);
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
            }
        }

        //вставка данных в БД
        public void Insert(DateTime current, float batteryPercent, string batteryStatus, string powerStatus)
        {
            SQLiteConnection connect = new SQLiteConnection(String.Format("Data Source={0};", databaseName));
            string comm = "INSERT INTO " + Resources.tableName + " VALUES ('" + current.ToString("yyyy-MM-dd H:mm:ss") + "', " +
                batteryPercent.ToString("0.00").Replace(',','.') + ", '" + batteryStatus + "', '" + powerStatus + "');";
            SQLiteCommand command = new SQLiteCommand(comm, connect);
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }

        //извлечение всех данных из БД
        public List<DataTableType> Select()
        {
            string comm = "SELECT * FROM " + Resources.tableName + ";";
            SQLiteConnection connect = new SQLiteConnection(String.Format("Data Source={0};", databaseName));
            connect.Open();

            SQLiteCommand command = new SQLiteCommand(comm, connect);
            SQLiteDataReader sqlRead = command.ExecuteReader();

            List<DataTableType> listTable = new List<DataTableType>();
            while (sqlRead.Read())
            {
                listTable.Add(
                    new DataTableType(
                        Convert.ToDateTime(sqlRead[0]),
                        Convert.ToSingle(sqlRead[1]),
                        Convert.ToString(sqlRead[2]),
                        Convert.ToString(sqlRead[3])
                    ));
            }
            sqlRead.Close();
            connect.Close();
            return listTable;
        }

        //извлечение данных, попадающих в промежуток времени
        public List<DataTableType> Select(DateTime begin, DateTime end)
        {
            string comm = "SELECT * FROM " + Resources.tableName + 
                " WHERE (current >= '" + begin.ToString("yyyy-MM-dd H:mm:ss") + 
                "' AND current <= '" + end.ToString("yyyy-MM-dd H:mm:ss") + "');";
            SQLiteConnection connect = new SQLiteConnection(String.Format("Data Source={0};", databaseName));
            connect.Open();

            SQLiteCommand command = new SQLiteCommand(comm, connect);
            SQLiteDataReader sqlRead = command.ExecuteReader();

            List<DataTableType> listTable = new List<DataTableType>();
            while (sqlRead.Read())
            {
                listTable.Add(new DataTableType(
                        Convert.ToDateTime(sqlRead[0]),
                        Convert.ToSingle(sqlRead[1]),
                        Convert.ToString(sqlRead[2]),
                        Convert.ToString(sqlRead[3])
                    ));
            }
            sqlRead.Close();
            connect.Close();
            return listTable;
        }
    }
}
