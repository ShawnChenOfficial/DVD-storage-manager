using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_Lib
{
    public class DBOperation
    {

        private static MySqlConnection conn;

        private static String conString = "Server=127.0.0.1;Database=dvds;Uid=root;Pwd=;";


        private static void ConnectDB()
        {
            try
            {
                conn = new MySqlConnection(conString);
            }
            catch (MySqlException sqlE)
            {
                throw sqlE;
            }

        }

        public static List<DVD> GetDVD()
        {
            List<DVD> LoadAllDVDs = new List<DVD>();

            ConnectDB();
            conn.Open();

            string sql_loadAll = "SELECT ID, Name, Category, Quantity_In_Stock FROM dvd_collection";

            MySqlCommand cmd = new MySqlCommand(sql_loadAll, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                LoadAllDVDs.Add(new DVD(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));
            }
            conn.Close();

            return LoadAllDVDs;
        }

        public static void AddDVD(string name, string category, int quantity_in_stock)
        {
            int id = GetId();

            conn.Open();

            string sql = "INSERT INTO dvd_collection (ID, Name, Category, Quantity_In_Stock) VALUES(@ID,@Name,@Category,@Quantity_In_Stock)";
            
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("ID", id);
            cmd.Parameters.AddWithValue("Name", name);
            cmd.Parameters.AddWithValue("Category", category);
            cmd.Parameters.AddWithValue("Quantity_In_Stock", quantity_in_stock);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void UpdateDVD(int id, string name, string category, int quantity_in_stock)
        {
            conn.Open();

            //UPDATE `dvd_collection` SET `Name` = 'Black Hawk Down1', `Category` = 'War1', `Quantity_In_Stock` = '12' WHERE `dvd_collection`.`ID` = 1

            string sql = string.Format("UPDATE dvd_collection SET Name = '{1}', Category = '{2}', Quantity_In_Stock = {3} WHERE ID = {0}", id, name, category, quantity_in_stock);

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void DeleteDVD(int id, string name, string category, int quantity_in_stock)
        {
            conn.Open();

            string sql = string.Format("DELETE FROM dvd_collection where ID = {0} AND Name = '{1}' AND Category = '{2}' AND Quantity_In_Stock = {3}", id, name, category, quantity_in_stock);

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private static int GetId()
        {
            conn.Open();

            int id = 0;

            string sql = "SELECT * FROM dvd_collection ORDER BY ID DESC";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                id = reader.GetInt32(0);
            }

            conn.Close();

            return (id + 1);
        }

    }
}
