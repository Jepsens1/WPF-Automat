using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_wpf.Class
{
    class Dalmanager
    {

        private const string connstring = @"Server=ZBC-E-RO-23242;Initial Catalog=Automat; Integrated Security=SSPI";
        private SqlConnection connection = new SqlConnection(connstring);
        public void Insert(Item item)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("InsertIntoAutomat", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", item.Name);
            cmd.Parameters.AddWithValue("@amount", item.Amount);
            cmd.Parameters.AddWithValue("@catagory", item.Catagory);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public List<Item> Refill()
        {
            List<Item> items = new List<Item>();
            connection.Open();
            SqlCommand cmd = new SqlCommand("SelectAllFromAutomat", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    Item item = new Item(rdr[0].ToString(), (int)rdr[1]);
                    item.Catagory = rdr[2].ToString();
                    items.Add(item);
                }
                return items;

            }
            connection.Close();
            return null;
        }

    }
}

