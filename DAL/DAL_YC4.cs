using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

using System.Linq;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using DTO;
using System.Security.Cryptography;

namespace DAL
{
    public class DAL_YC4 : DBConnect
    {
        string machucvu;
        DBConnect db = new DBConnect();
        public DataTable getHoaDon()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM HOADON", getConnection());
            DataTable dsHoaDon = new DataTable();
            da.Fill(dsHoaDon);
            return dsHoaDon;
        }

        public bool insertHoaDon(DTO_HoaDon hd)
        {
            SQLiteConnection connect = getConnection();
            connect.Open();

            try
            {
                string SQL = string.Format("INSERT INTO HOADON(SoHoaDon, MaTiecCuoi, TongTienBan, TongTienDichVu, TongTienHoaDon, ConLai, NgayThanhToan) VALUES ('{0}', '{1}', {2}, {3}, {4}, {5}, '{6}')", hd.SoHoaDon, hd.MaTiecCuoi, hd.TongTienBan, hd.TongTienDichVu, hd.TongTienHoaDon, hd.ConLai, hd.NgayThanhToan);
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
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, getConnection());
            DataTable dsHoaDon = new DataTable();
            da.Fill(dsHoaDon);
            return dsHoaDon;
        }

        public DataTable searchHoaDon(string mtc)
        {
            string sql = string.Format("SELECT * FROM HOADON WHERE MaTiecCuoi = '{0}'", mtc);
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, getConnection());
            DataTable dsHoaDon = new DataTable();
            da.Fill(dsHoaDon);
            return dsHoaDon;
        }

        public DataTable searchHoaDon_NgayTT(string ngaytt)
        {
            string sql = string.Format("SELECT * FROM HOADON WHERE NgayThanhToan = '{0}'", ngaytt);
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, getConnection());
            DataTable dsHoaDon = new DataTable();
            da.Fill(dsHoaDon);
            return dsHoaDon;
        }

        public double TongTienBan(string MaTiecCuoi)
        {
            SQLiteConnection connect = getConnection();
            connect.Open();
            double kq = 0;
            try
            {
                string sql = string.Format("SELECT SUM((SoLuong + SoLuongDuTru)*DonGiaBan) AS TongTien FROM PHIEUDATBAN WHERE MaTiecCuoi ='{0}'", MaTiecCuoi);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connect);
                DataTable result = new DataTable();
                da.Fill(result);

                if (result != null)
                {
                    DataRow row = result.Rows[0];
                    kq = double.Parse(row["TongTien"].ToString());
                }
            }
            catch (Exception e) { }

            connect.Close();
            return kq;
        }

        public double TongTienDichVu(string MaTiecCuoi)
        {
            SQLiteConnection connect = getConnection();
            connect.Open();
            double kq = 0;
            try
            {
                string sql = string.Format("SELECT SUM(SoLuong*DonGia) AS TongTien FROM PHIEUDATDICHVU WHERE MaTiecCuoi ='{0}'", MaTiecCuoi);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connect);
                DataTable result = new DataTable();
                da.Fill(result);

                if (result != null)
                {
                    DataRow row = result.Rows[0];
                    kq = double.Parse(row["TongTien"].ToString());
                }
            }
            catch (Exception e) { }

            connect.Close();
            return kq;
        }

        public string getNgayDaiTiec(string MaTiecCuoi)
        {
            SQLiteConnection connect = getConnection();
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

        public int getSoLuongBan(string MaTiecCuoi)
        {
            SQLiteConnection connect = getConnection();
            connect.Open();
            int kq = 0;
            try
            {
                string sql = string.Format("SELECT SUM(SoLuong + SoLuongDuTru) AS TongBan FROM PHIEUDATBAN WHERE MaTiecCuoi ='{0}'", MaTiecCuoi);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connect);
                DataTable result = new DataTable();
                da.Fill(result);

                if (result != null)
                {
                    DataRow row = result.Rows[0];
                    kq = int.Parse(row["TongBan"].ToString());
                }
            }
            catch (Exception e) { }

            connect.Close();
            return kq;
        }

        public double getTienDatCoc(string MaTiecCuoi)
        {
            SQLiteConnection connect = getConnection();
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

        // Kiểm tra năm nhuận
        public bool KTNhuan(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)) return true;
            return false;
        }

        // KT ngày tháng nhập có hợp lệ hay không
        public bool KTNgay(int ngay, int thang, int nam)
        {
            if (ngay < 0 || ngay > 31 || thang < 0 || thang > 12 || nam < 0)
                return false;
            else
            {
                if (thang == 2)
                {
                    if (ngay > 29 || (KTNhuan(nam) == false && ngay == 29)) return false;
                    return true;
                }
                else if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
                {
                    if (ngay > 30) return false;
                    return true;
                }
                else return true;
            }
        }

        // Chuyển ngày tháng năm thành đơn vị ngày tính từ ngày 1/1/1
        public int DayMonthYear_to_Day(int day, int month, int year)
        {
            // t2 là ngày của tháng 2
            int t2, kq = 0;

            // KT năm nhuận
            if (KTNhuan(year) == true) t2 = 29;
            else t2 = 28;

            // List các tháng
            int[] m = { 31, t2, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Chuyển tháng thành ngày
            for (int i = 0; i < month - 1; i++)
                kq += m[i];
            // Cộng ngày hiện tại
            kq += day;

            // Chuyển năm thành ngày
            kq += (year - 1) * 365 + (((year - 1) / 4) - ((year - 1) / 100 - ((year - 1) / 100) / 4));

            return kq;
        }

        public DataTable getChiTietDichVu(string MaTiecCuoi)
        {
            string sql = string.Format("SELECT TenDichVu, SoLuong, PHIEUDATDICHVU.DonGia FROM PHIEUDATDICHVU JOIN DICHVU ON PHIEUDATDICHVU.MaDichVu = DICHVU.MaDichVu WHERE MaTiecCuoi = '{0}'", MaTiecCuoi);
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, getConnection());
            DataTable dsCTDV = new DataTable();
            da.Fill(dsCTDV);
            return dsCTDV;
        }

        public double TinhTienPhat(string MaTiecCuoi, int ngaytt, int thangtt, int namtt)
        {
            SQLiteConnection connect = getConnection();
            connect.Open();
            double kq = 0;
            try
            {
                string sql = string.Format("SELECT GiaTri FROM THAMSO");
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connect);
                DataTable result = new DataTable();
                da.Fill(result);
                DataRow row1 = result.Rows[0];
                DataRow row2 = result.Rows[1];
                double tile = double.Parse(row1["GiaTri"].ToString());
                string thamsophat = row2["GiaTri"].ToString();

                if (thamsophat == "1")
                {
                    // NgayDaiTiec < NgayThanhToan là phạt
                    bool check;
                    string[] NgayDaiTiec = getNgayDaiTiec(MaTiecCuoi).Split('/');
                    if (int.Parse(NgayDaiTiec[2]) < namtt)
                        check = true;
                    else if (int.Parse(NgayDaiTiec[1]) < thangtt)
                        check = true;
                    else if (int.Parse(NgayDaiTiec[0]) < ngaytt)
                        check = true;
                    else check = false;

                    if (check == true)
                    {
                        int songaytre = DayMonthYear_to_Day(ngaytt, thangtt, namtt) - DayMonthYear_to_Day(int.Parse(NgayDaiTiec[0]), int.Parse(NgayDaiTiec[1]), int.Parse(NgayDaiTiec[2]));
                        kq = ((TongTienBan(MaTiecCuoi) + TongTienDichVu(MaTiecCuoi)) * tile) * songaytre;
                    }
                    else kq = 0;
                }
                else
                {
                    kq = 0;
                }
            }
            catch (Exception e) { }

            connect.Close();
            return kq;
        }
        public bool xoaTiecCuoi(string ID)
        {
            // Ket noi
            SQLiteConnection connect = db.getConnection();
            connect.Open();
            try
            {

                string SQL = string.Format("DELETE FROM TIECCUOI WHERE MATIECCUOI = '{0}'", ID);

                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                connect.Close();

            }

            return false;
        }
    }
}
