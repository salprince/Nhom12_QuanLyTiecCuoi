using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using DTO;
namespace DAL
{
    public class DAL_HoaDon
    {
        DBConnect Db = new DBConnect();
        public DataTable getHoaDon()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM HOADON", Db.getConnection());
            DataTable dsHoaDon = new DataTable();
            da.Fill(dsHoaDon);
            return dsHoaDon;
        }

        public bool insertHoaDon(DTO_HoaDon hd)
        {
            SQLiteConnection connect = Db.getConnection();
            connect.Open();

            try
            {
                string SQL = string.Format("INSERT INTO HOADON VALUES ('{0}', '{1}', {2}, {3}, {4}, {5}, '{6}', '{7}')", hd.SoHoaDon, hd.MaTiecCuoi,  hd.TongTienBan, hd.TongTienDichVu, hd.TongTienHoaDon, hd.ConLai, hd.NgayThanhToan, hd.TrangThaiThanhToan );
                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e) { }
            finally
            {
                connect.Close();
            }

            return false;
        }

        public DataTable searchHoaDon(string tenchure, string tencodau)
        {
            string sql = string.Format("SELECT * FROM HOADON WHERE MaTiecCuoi IN(SELECT MaTiecCuoi FROM TIECCUOI WHERE TenChuRe LIKE '%{0}%' OR TenCoDau LIKE '%{1}%')", tenchure, tencodau);
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, Db.getConnection());
            DataTable dsHoaDon = new DataTable();
            da.Fill(dsHoaDon);
            return dsHoaDon;
        }

        public DataTable searchHoaDon(string mtc)
        {
            string sql = string.Format("SELECT * FROM HOADON WHERE MaTiecCuoi = '{0}'", mtc);
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, Db.getConnection());
            DataTable dsHoaDon = new DataTable();
            da.Fill(dsHoaDon);
            return dsHoaDon;
        }

        public DataTable searchHoaDon_NgayTT(string ngaytt)
        {
            string sql = string.Format("SELECT * FROM HOADON WHERE NgayThanhToan = '{0}'", ngaytt);
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, Db.getConnection());
            DataTable dsHoaDon = new DataTable();
            da.Fill(dsHoaDon);
            return dsHoaDon;
        }

        public double TongTienBan(string MaTiecCuoi)
        {
            SQLiteConnection connect = Db.getConnection();
            connect.Open();
            double kq = 10;
            try
            {
                string sql = string.Format("select sum(SoLuongBan*DonGia) as TongTien from (select TIECCUOI.soluongban, monan.dongia from PhieuDatBan, TIECCUOI, monan WHERE PhieuDatBan.matieccuoi='{0}' and PhieuDatBan.mamonan=monan.mamonan and TIECCUOI.matieccuoi='{0}')", MaTiecCuoi);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connect);
                DataTable result = new DataTable();
                da.Fill(result);
                if (result != null)
                {
                    DataRow row = result.Rows[0];
                    kq = Double.Parse(row["TongTien"].ToString());
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            connect.Close();
            return kq;
        }

        public double TongTienDichVu(string MaTiecCuoi)
        {
            SQLiteConnection connect = Db.getConnection();
            connect.Open();
            double kq = 0;
            try
            {
                string sql = string.Format("SELECT SUM(SoLuong*DonGia) AS TongTien FROM (select soluong, dongia from PHIEUDATDICHVU, dichvu WHERE MaTiecCuoi ='{0}' and phieudatdichvu.madichvu = dichvu.madichvu)", MaTiecCuoi);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connect);
                DataTable result = new DataTable();
                da.Fill(result);
                if (result != null)
                {
                    DataRow row = result.Rows[0];
                    kq = Double.Parse(row["TongTien"].ToString());
                }
            }
            catch (Exception e) { }

            connect.Close();
            return kq;
        }

        public int getSoLuongBan(string MaTiecCuoi)
        {
            SQLiteConnection connect = Db.getConnection();
            connect.Open();
            int kq = 0;
            try
            {
                string sql = string.Format("SELECT SoLuongBan FROM TiecCuoi WHERE MaTiecCuoi ='{0}'", MaTiecCuoi);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connect);
                DataTable result = new DataTable();
                da.Fill(result);

                if (result != null)
                {
                    DataRow row = result.Rows[0];
                    kq = int.Parse(row["SoLuongBan"].ToString());
                }
            }
            catch (Exception e) { }

            connect.Close();
            return kq;
        }

        public double getTienDatCoc(string MaTiecCuoi)
        {
            SQLiteConnection connect = Db.getConnection();
            connect.Open();
            double kq = 0;
            try
            {
                string sql = string.Format("SELECT TienDatCoc FROM TIECCUOI WHERE MaTiecCuoi ='{0}'", MaTiecCuoi);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connect);
                DataTable result = new DataTable();
                da.Fill(result);

                if (result != null)
                {
                    DataRow row = result.Rows[0];
                    kq = double.Parse(row["TienDatCoc"].ToString());
                }
            }
            catch (Exception e) { }

            connect.Close();
            return kq;
        }


        public DataTable getChiTietDichVu(string MaTiecCuoi)
        {
            string sql = string.Format("SELECT TenDichVu, PhieuDatDichVu.SoLuong, DICHVU.DonGia FROM PHIEUDATDICHVU JOIN DICHVU ON PHIEUDATDICHVU.MaDichVu = DICHVU.MaDichVu WHERE MaTiecCuoi = '{0}'", MaTiecCuoi);
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, Db.getConnection());
            DataTable dsCTDV = new DataTable();
            da.Fill(dsCTDV);
            return dsCTDV;
        }
        public bool CapNhatThanhToan(String matc)
        {
            SQLiteConnection Conn = Db.getConnection();
            Conn.Open();
            try
            {
                string SQL = string.Format("Update hoadon set trangthaithanhtoan = '{0}' where matieccuoi = '{1}'", 1, matc);
                SQLiteCommand cmd = new SQLiteCommand(SQL, Conn);
                if (cmd.ExecuteNonQuery()>0)
                {
                    Conn.Close();
                    return true;
                }    

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Conn.Close();
            }
            return false;
        }
        public string getNgayDaiTiec(string MaTiecCuoi)
        {
            SQLiteConnection connect = Db.getConnection();
            connect.Open();
            string kq = "";
            try
            {
                string sql = string.Format("SELECT NgayDaiTiec FROM TiecCuoi WHERE MaTiecCuoi ='{0}'", MaTiecCuoi);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connect);
                DataTable result = new DataTable();
                da.Fill(result);
                if (result != null)
                {
                    DataRow row = result.Rows[0];
                    kq = row["NgayDaiTiec"].ToString();
                }
            }
            catch (Exception e) { }

            connect.Close();
            return kq;
        }
        public void CapNhatTiecCuoi(String matc)
        {
            SQLiteConnection Conn = Db.getConnection();
            Conn.Open();
            try
            {
                string SQL = string.Format("Update tieccuoi set tiendo = 100 where matieccuoi = '{1}'", 1, matc);
                SQLiteCommand cmd = new SQLiteCommand(SQL, Conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Conn.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
