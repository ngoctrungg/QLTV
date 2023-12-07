using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_QLThuVien
{
    internal class DataProvider
    {
        public static string ChuoiKetNoi
        {
            get { return "Server=DESKTOP-1OVGN83\\SQLSERVER2022; Database=QLTHUVIEN; Integrated Security=True"; }
        }

        /// <summary>
        /// Excute query (Insert, Update, Delete)
        /// </summary>
        /// <param name="sql">sql Query</param>
        /// <returns></returns>
        public static bool TruyVan_XuLy(string sql)
        {
            try
            {
                SqlConnection con = new SqlConnection(ChuoiKetNoi);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataTable TruyVan_LayDuLieu(string sql)
        {
            SqlConnection con = new SqlConnection(ChuoiKetNoi);
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable kq = new DataTable();
            da.Fill(kq);
            return kq;
        }

        public static void ExcuteNonQuery(string sql, CommandType type, SqlParameter[] paras)
        {
            /*
             * type = CommandType.Text thì sql là lệnh INSERT, UPDATE, DELETE
             * type = CommandType.StoreProcedure thì sql là tên của strote procedure
             * type = CommandType.TableDirect thì sql là tên table
             */
            SqlConnection sqlcon = new SqlConnection(ChuoiKetNoi);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlcon;
            cmd.CommandText = sql;
            cmd.CommandType = type;
            if (paras != null)//có tham số
                cmd.Parameters.AddRange(paras);

            cmd.ExecuteNonQuery();

            sqlcon.Close();
        }

        public static DataTable SelectData(string sql, CommandType type, SqlParameter[] paras)
        {
            DataTable kq = new DataTable();
            SqlConnection sqlcon = new SqlConnection(ChuoiKetNoi);
            sqlcon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlcon;
            cmd.CommandText = sql;
            cmd.CommandType = type;

            if (paras != null)
                cmd.Parameters.AddRange(paras);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(kq);

            sqlcon.Close();
            return kq;
        }
        public static DataSet SelectMultiData(string sql)
        {
            DataSet kq = new DataSet();
            SqlConnection sqlcon = new SqlConnection(ChuoiKetNoi);
            sqlcon.Open();

            SqlDataAdapter da = new SqlDataAdapter(sql, sqlcon);
            da.Fill(kq);

            sqlcon.Close();
            return kq;
        }
    }
}
