using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmitFile
{   

    public class dbConnect
    {
        public static string strCon = "Data Source=svn.3asoft.vn;Initial Catalog=AppDataQLCT;User ID=quangpham;Password=quangpham;Database = AppDataQLCT";
        public static SqlConnection cnn;
        private static dbConnect dbCon = null;
        public static dbConnect GetConnect()
        {
            if (dbCon == null)
            {
                dbCon = new dbConnect();
                cnn = new SqlConnection(strCon);
                cnn.Open();
            }
            return dbCon;
        }


        public static DataTable GetDataTableBySql(string sql)
        {
            //SqlCommand 
            SqlDataAdapter sqlA = new SqlDataAdapter(sql, cnn);
            //SqlCommand sqlCom = new SqlCommand(sql, cnn);
            DataTable db = new DataTable();
            try
            {
                sqlA.Fill(db);
            }
            catch
            {
                
            }

            return db;
        }

        public static string GetStringBySql(string sql)
        {
            SqlDataAdapter sqlA = new SqlDataAdapter(sql, cnn);
            //SqlCommand sqlCom = new SqlCommand(sql, cnn);
            DataTable db = new DataTable();
            try
            {
                sqlA.Fill(db);
                if (db.Rows.Count == 0)
                    return "";
                else
                    return db.Rows[0][0].ToString();
            }
            catch
            {

            }

            return "";
        }

        public static void UpdateTableBySql(string sql)
        {
            //SqlDataAdapter sqlA = new SqlDataAdapter(sql, cnn);
            SqlCommand sqlCom = new SqlCommand(sql, cnn);
            //DataTable db = new DataTable();
            try
            {
                //sqlCom.Connection;
                sqlCom.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                var error = ex.Source;
            }
        }

    }
}
