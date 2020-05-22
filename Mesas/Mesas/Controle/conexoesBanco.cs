using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Mesas.Controle
{
    class conexoesBanco
    {
        

            
            private static string connString = "SslMode = none; server = localhost; Database = quickorder; UId =  gabriel; Password= obri8453; integrated security =true;";
            
            private static MySqlConnection conn = null;
            public string resp;

            public MySqlConnection obterConexao()
            {
                conn = new MySqlConnection(connString);

                try
                {
                    conn.Open();
                    return conn;
                }
                catch (MySqlException sqle)
                {
                    
                    resp = sqle.Message;
                    return null;
                }
            }
            public void fecharConexao()
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
    }
