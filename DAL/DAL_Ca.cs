using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

using DTO;
namespace DAL
{
    public class DAL_Ca: DBConnect
    {
        public DataTable getCa()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM CA", getConnection());
            DataTable dsCa = new DataTable();
            da.Fill(dsCa);
            return dsCa;
        }
        public bool insertCa(DTO_Ca ca)
        {
            // Ket noi
            SQLiteConnection connect = getConnection();
            connect.Open();

            try
            {
                // Query string
                string SQL = string.Format("INSERT INTO CA(MACA, TENCA) VALUES ('{0}', '{1}')", ca.MaCa, ca.TenCa);

                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e) { }
            finally
            {
                // Dong ket noi
                connect.Close();
            }

            return false;
        }
        public bool editCa(DTO_Ca ca)
        {
            // Ket noi
            SQLiteConnection connect = getConnection();
            connect.Open();

            try
            {
                // Query string
                string SQL = string.Format("UPDATE CA SET TENCA = '{0}' WHERE MACA = '{1}';", ca.TenCa, ca.MaCa);

                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e) { }
            finally
            {
                // Dong ket noi
                connect.Close();
            }

            return false;
        }
        public bool deleteCa(string id)
        {
            // Ket noi
            SQLiteConnection connect = getConnection();
            connect.Open();

            try
            {
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 ID là đủ
                string SQL = string.Format("DELETE FROM CA WHERE MACA = '{0}';", id);
                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e) { }
            finally
            {
                // Dong ket noi
                connect.Close();
            }

            return false;
        }
        public DataTable searchCa(string tenca)
        {
            string sql = "SELECT * FROM CA WHERE TENCA LIKE '%" + tenca + "%';";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, getConnection());
            DataTable dsCa = new DataTable();
            da.Fill(dsCa);
            return dsCa;
        }
        public DataTable searchCA(string maca)
        {
            string sql = "SELECT * FROM TiecCUoi WHERE maCA LIKE '%" + maca + "%';";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, getConnection());
            DataTable dsCa = new DataTable();
            da.Fill(dsCa);
            return dsCa;
        }
    }
}
