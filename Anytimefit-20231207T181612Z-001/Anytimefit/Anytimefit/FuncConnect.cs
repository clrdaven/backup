using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Anytimefit
{
    class FuncConnect // function that all can connect to dis form
    {
        private MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root; database=gymbrosfitness ; password=");
        public MySqlConnection GetCon()
        {
            return con;

        }
        public void OpenCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void CloseCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }


        }


    }
}
