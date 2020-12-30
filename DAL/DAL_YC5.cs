using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

using System.Linq;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Security.Cryptography;
using System.Data.Common;
using System.Linq.Expressions;
using System.Numerics;

namespace DAL
{
    public class DAL_YC5
    {
        DBConnect db;
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteConnection conn = new SQLiteConnection();
        public DAL_YC5()
        {
            db = new DBConnect();
        }

        public DataTable checkThang(string thang, string nam)//Lay du lieu thong ke tiec cuoi trong thang 
        {
            conn = db.getConnection();
            conn.Open();
            string Thang = "%/%" + thang + "/" + nam;
            DataTable dtTN = new DataTable();
            string sql = String.Format("SELECT Ngaythanhtoan, count(MaTiecCuoi) as SoLuongTiecCuoi, sum(TongTienHoaDon) as TongDoanhThu  FROM hoadon WHERE ngaythanhtoan like '{0}' group by ngaythanhtoan", Thang);
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dtTN);
            conn.Close();
            return dtTN;
        }
        public string SoHD(string thang, string nam)
        {
            string rs = "";
            conn = db.getConnection();
            conn.Open();
            try
            {
                string Thang = "%/%" + thang + "/" + nam;
                string sql = String.Format("Select sohoadon from hoadon where ngaythanhtoan like '{0}'", Thang);
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader rd = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (rd.HasRows)
                {
                    if (rd.Read())
                        rs = Convert.ToString(rd["SOHOADON"]);
                }
            }
            catch (Exception e)
            {

            }
            conn.Close();
            return rs;
        }
        public int TongDoanhThu(string thang, string nam)//Tinh tong doanh thu
        {
            int rs = 0;
            conn = db.getConnection();
            conn.Open();
            try
            {
                string Thang = "%/%" + thang + "/" + nam;
                string sql = String.Format("Select sum(tongtienhoadon) as TongDoanhThuThang from hoadon where ngaythanhtoan like '{0}'", Thang);
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader rd = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (rd.HasRows)
                {
                    if (rd.Read())
                        rs = Int32.Parse(Convert.ToString(rd["TongDoanhThuThang"]));
                }
            }
            catch (Exception e)
            {

            }
            conn.Close();
            return rs;
        }
        public int getMaBaoCaoThang()
        {
            conn = db.getConnection();
            conn.Open();
            string rs = "";
            int maBC = 0;
            try
            {
                string sql = String.Format("select max(maBCT) as MaBaoCao from BaoCaoThang");
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader rd = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (rd.HasRows)
                {
                    if (rd.Read())
                        rs = Convert.ToString(rd["MaBaoCao"]);
                }    
            }
            catch (Exception e)
            {

            }
            conn.Close();
            try
            {
                maBC = Int32.Parse(rs);
            }
            catch (Exception e)
            {

            }
            maBC++;
            return maBC;
        }
       
    }
}
