using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;



namespace DataAccessLayer
{
    public class DbInterfaceHelper
    {
        SortedList<string, string> S1 = new SortedList<string, string>();
        public SqlCommand cmd;
        public SqlConnection sqlcon;

        public SqlConnection GetConnection()
        {
            sqlcon = new SqlConnection("Data Source=LAPTOP-SRG4EAKH;Initial Catalog=OnlineFilmCastingPortal;Integrated Security=True");

            if (sqlcon.State == ConnectionState.Open)
            {
                sqlcon.Close();
            }
            sqlcon.Open();
            return sqlcon;
        }

        //For Admin Login
        public SortedList<string,string> ExeReader(string Query)
        {
            SqlDataReader sdr = null;
            try
            {
                cmd = new SqlCommand(Query, GetConnection());
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    S1.Add(sdr[0].ToString(), sdr[1].ToString());

                }
                return S1;
            }
            finally
            {
                if (GetConnection().State == ConnectionState.Open)
                {
                    GetConnection().Close();
                }
            }


        }

        //For Getting Table Data
        public DataTable GetTableData(string proc)
        {
      
                SqlCommand cmd = new SqlCommand(proc, GetConnection());
                SqlDataAdapter sda = new SqlDataAdapter();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
           
          
        }

        public DataTable GetTableData(string proc, SortedList list)
        {

            SqlCommand cmd = new SqlCommand(proc, GetConnection());
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.CommandType = CommandType.StoredProcedure;
            if (!(list.Count == 0))
            {
                string[] tKeys = new string[list.Count];
                list.Keys.CopyTo(tKeys, 0);
                for (int i = 0; i < list.Count; i++)
                {
                    cmd.Parameters.Add(new SqlParameter("@" + tKeys[i], list[tKeys[i]]));
                }

            }
            cmd.ExecuteNonQuery();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;


        }

        public DataTable GetTableDataByQuery(string query)
        {

            SqlCommand cmd = new SqlCommand(query, GetConnection());
            SqlDataAdapter sda = new SqlDataAdapter();
            
            cmd.ExecuteNonQuery();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;


        }

        public string ExecuteProcedure(string proc,SortedList list)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, GetConnection());
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                if (!(list.Count == 0))
                {
                    string[] tKeys = new string[list.Count];
                    list.Keys.CopyTo(tKeys, 0);
                    for(int i = 0; i < list.Count; i++)
                    {
                        cmd.Parameters.Add(new SqlParameter("@" + tKeys[i], list[tKeys[i]]));
                    }

                }
                string result=cmd.ExecuteScalar().ToString();
                return result;
            }
            catch(Exception ex)
            {
                return "-1";
            }
            finally
            {
                if (GetConnection().State == ConnectionState.Open)
                {
                    GetConnection().Close();
                }
            }
            
            

        }
        

        }
    }

