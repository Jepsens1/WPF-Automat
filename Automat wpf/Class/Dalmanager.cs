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
        
      private string connstring = @"Server=ZBC-E-RO-23242;Initial Catalog=Automat; Integrated Security=SSPI";

        public void Insert(Item item)
        {
           
            string InsertReciep = "INSERT INTO Reciep(item) VALUES(@item)";
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(InsertReciep, connection);
                cmd.Parameters.AddWithValue("@item", item.Name);
                cmd.ExecuteNonQuery();
            }
            
        }
    }
}
