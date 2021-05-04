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
            cmd.Parameters.AddWithValue("@price", item.Price);
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
                    switch (rdr[2].ToString())
                    {
                        case "Soda":
                            Item soda = new Soda(rdr[0].ToString(), (int)Flavour.Cherry);
                            items.Add(soda);
                            break;
                        case "Chips":
                            Item chips = new Chip(rdr[0].ToString(), (int)rdr[3]);
                            items.Add(chips);
                            break;
                        case "Nuts":
                            Item nuts = new Nut(rdr[0].ToString(), (int)rdr[3], NutTypes.Cashew);
                            items.Add(nuts);
                            break;
                        case "Candy":
                            Item candy = new Candy(rdr[0].ToString(), (int)rdr[3], CandyTypes.MatadorMix);
                            items.Add(candy);
                            break;
                        case "Gum":
                            Item gum = new Gum(rdr[0].ToString(), (int)rdr[3]);
                            items.Add(gum);
                            break;
                        default:
                            break;
                    }
                }
                connection.Close();
                return items;

            }
            return null;
        }

    }
}

