using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using DTO;
using System.Data;

namespace DAL
{
    public class DAL_YC2
    {
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteConnection conn = new SQLiteConnection();
        DBConnect db;
        public DAL_YC2()
        {
            db = new DBConnect();
        }
        public DataTable getTiecCuoi()
        {
            conn = db.getConnection();
            conn.Open();
            SQLiteDataAdapter sql = new SQLiteDataAdapter("Select * from TIECCUOI ORDER BY MaTiecCuoi ASC", conn);
            DataTable dt = new DataTable();
            sql.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable getDichvu()
        {
            conn = db.getConnection();
            conn.Open();
            SQLiteDataAdapter sql = new SQLiteDataAdapter("Select * from DICHVU ORDER BY MADICHVU ASC", conn);
            DataTable dt = new DataTable();
            sql.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable getThucdon()
        {
            conn = db.getConnection();
            conn.Open();
            SQLiteDataAdapter sql = new SQLiteDataAdapter("Select * from MONAN ORDER BY MAMONAN ASC", conn);
            DataTable dt = new DataTable();
            sql.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable getLoaiSanh(string masanh)
        {
            conn = db.getConnection();
            conn.Open();
            string SQL = string.Format("Select LOAISANH.* FROM SANH JOIN LOAISANH ON SANH.MaLoaiSanh = LOAISANH.MaLoaiSanh WHERE MaSanh = '{0}'", masanh);
            SQLiteDataAdapter sql = new SQLiteDataAdapter(SQL, conn);
            DataTable dt = new DataTable();
            sql.Fill(dt);
            conn.Close();
            return dt;
        }

        /// thêm tiệc cưới
        public bool themTiecCuoi(DTO_TiecCuoi tc)
        {
            //ket noi
            SQLiteConnection connect = db.getConnection();
            connect.Open();

            try
            {
                // query string
                string SQL = string.Format("INSERT INTO TIECCUOI(MATIECCUOI, TENCHURE, TENCODAU, DIENTHOAI, NGAYDATTIEC, NGAYDAITIEC, MACA, MASANH, TIENDATCOC, GHICHU) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", tc.MaTiecCuoi, tc.TenChuRe, tc.TenCoDau, tc.DienThoai, tc.NgayDatTiec, tc.NgayDaiTiec, tc.MaCa, tc.MaSanh, tc.TienDatCoc, tc.GhiChu);
                // command mặc định là command type = text
                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);

                //query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                //dong ket noi
                connect.Close();
            }
            return false;
        }

        ///sửa thành viên
        public bool suaTiecCuoi(DTO_TiecCuoi tc)
        {
            //ket noi
            SQLiteConnection connect = db.getConnection();
            connect.Open();

            try
            {
                // query string
                string SQL = string.Format("UPDATE TIECCUOI SET TENCHURE = '{0}', TENCODAU = '{1}', DIENTHOAI = '{2}', NGAYDATTIEC = '{3}', NGAYDAITIEC = '{4}', MACA = '{5}', MASANH = '{6}', TIENDATCOC = '{7}', GHICHU ='{8}' WHERE MATIECCUOI = '{9}'", tc.TenChuRe, tc.TenCoDau, tc.DienThoai, tc.NgayDatTiec, tc.NgayDaiTiec, tc.MaCa, tc.MaSanh, tc.TienDatCoc, tc.GhiChu, tc.MaTiecCuoi);

                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);

                //query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                //dong ket noi
                connect.Close();
            }
            return false;
        }
        /// xoá thành viên
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

        // Kiểm tra năm nhuận
        public bool KTNhuan(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)) return true;
            return false;
        }

        // Kiểm tra ngày tháng năm nhập vào có hợp lệ không
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

        public string GopNgay(int day, int month, int year)
        {
            string kq = "";
            if (day < 10)
            {
                kq += "0" + day.ToString() + "/";
            }
            else
            {
                kq += day.ToString() + "/";
            }

            if (month < 10)
            {
                kq += "0" + month.ToString() + "/";
            }
            else
            {
                kq += month.ToString() + "/";
            }
            kq += year.ToString();
            return kq;
        }

        public DataTable getMonAn()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT MAMONAN, TENMONAN, DONGIA, MOTA FROM MonAn", db.getConnection());
            DataTable dsMonAn = new DataTable();
            da.Fill(dsMonAn);
            return dsMonAn;
        }
        public DataTable getMonAnDaDat(String maTC)
        {
            Console.WriteLine($"matieccuoi = {maTC}");
            SQLiteDataAdapter da = new SQLiteDataAdapter($"SELECT MA.tenmonan FROM monan MA INNER JOIN phieudatban PDB on MA.mamonan= PDB.mamonan where PDB.matieccuoi='{maTC}'", db.getConnection());
            DataTable dsMonAn = new DataTable();
            da.Fill(dsMonAn);
            return dsMonAn;
        }
        public DataTable getDichVuDaDat(String maTC)
        {
            Console.WriteLine($"matieccuoi = {maTC}");
            SQLiteDataAdapter da = new SQLiteDataAdapter($"SELECT DV.tendichvu as [Tên dịch vụ] from DICHVU DV INNER JOIN phieudatdichvu PDDV on PDDV.madichvu= DV.madichvu where PDDV.matieccuoi='{maTC}'", db.getConnection());
            DataTable dsMonAn = new DataTable();
            da.Fill(dsMonAn);
            return dsMonAn;
        }

        public DataTable searchMonAn(string key)
        {
            string sql = "SELECT MAMONAN, TENMONAN, DONGIA, MOTA FROM MONAN WHERE TENMONAN LIKE '%" + key + "%' OR MOTA LIKE '%" + key + "%' OR GHICHU LIKE '%" + key + "%';";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, db.getConnection());
            DataTable dsMAn = new DataTable();
            da.Fill(dsMAn);
            return dsMAn;
        }

        public DataTable getPhieuDatBan()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM PHIEUDATBAN", db.getConnection());
            DataTable dsMonAn = new DataTable();
            da.Fill(dsMonAn);
            return dsMonAn;
        }

        public DataTable getPhieuDatBan(string mtc)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM PHIEUDATBAN WHERE MaTiecCuoi ='" + mtc + "'", db.getConnection());
            DataTable dsMonAn = new DataTable();
            da.Fill(dsMonAn);
            return dsMonAn;
        }

        public bool themPhieuDatBan(DTO_PhieuDatBan pdb)
        {
            //ket noi
            SQLiteConnection connect = db.getConnection();
            connect.Open();

            try
            {
                string SQL = string.Format("INSERT INTO PHIEUDATBAN(MAPHIEUDATBAN, MATIECCUOI, LOAIBAN, SOLUONG, SOLUONGDUTRU, DONGIABAN, GHICHU) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');", pdb.MaPhieuDatBan, pdb.MaTiecCuoi, pdb.LoaiBan, pdb.SoLuong, pdb.SoLuongDuTru, pdb.DonGiaBan, pdb.GhiChu);
                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                //dong ket noi
                connect.Close();
            }
            return false;
        }

        public bool themCT_PhieuDatBan(DTO_CT_PhieuDatBan ct_pdb)
        {
            //ket noi
            SQLiteConnection connect = db.getConnection();
            connect.Open();
            try
            {
                string SQL = string.Format("INSERT INTO PhieuDatBan(matieccuoi,mamonan,ghichu) VALUES('{0}', '{1}', '{2}');", ct_pdb.MaTiecCuoi, ct_pdb.MaMonAn, ct_pdb.GhiChu);
                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine($"THEM PHIEU DAT MON THANH CONG");
                    return true;
                }
                    
            }
            catch (Exception e)
            {

            }
            finally
            {
                //dong ket noi
                connect.Close();
            }
            return false;
        }
        public bool checkSoLuongBanToiDa(string masanh, int slb)
        {
            string SQL = string.Format("SELECT * FROM SANH WHERE MaSanh = '{0}'", masanh);
            SQLiteDataAdapter da = new SQLiteDataAdapter(SQL, db.getConnection());
            DataTable dsSanh = new DataTable();
            da.Fill(dsSanh);
            DataRow row = dsSanh.Rows[0];
            int temp = int.Parse(row["SoLuongBanToiDa"].ToString());
            if (slb > temp) return false;
            else return true;
        }
        public bool updatePhieuDatBan(int dongia, string mapdb)
        {
            SQLiteConnection connect = db.getConnection();
            connect.Open();

            try
            {
                string SQL = string.Format("UPDATE PHIEUDATBAN SET DonGiaBan = {0} WHERE MaPhieuDatBan = '{1}';", dongia, mapdb);
                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                //dong ket noi
                connect.Close();
            }
            return false;
        }

        public bool xoaCT_PhieuDatBan(string maTC,int type=1)
        {
            SQLiteConnection connect = db.getConnection();
            connect.Open();

            try
            {
                /*string SQL = string.Format($"DELETE FROM TiecCuoi WHERE matieccuoi = '{maTC}'");
                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);
                string SQL1 = string.Format($"DELETE FROM PHIEUDATBAN WHERE matieccuoi = '{maTC}'");
                SQLiteCommand cmd1 = new SQLiteCommand(SQL1, connect);
                string SQL2 = string.Format($"DELETE FROM PhieuDatDichVu WHERE matieccuoi = '{maTC}'");
                SQLiteCommand cmd2 = new SQLiteCommand(SQL2, connect);
                bool result0=false, result1 = false, result2 = false;
                if (cmd.ExecuteNonQuery() > 0)
                    result0 = true;
                if (cmd1.ExecuteNonQuery() > 0)
                    result1 = true;
                if (cmd2.ExecuteNonQuery() > 0)
                    result2 = true;
                if (result0 || result1 || result2)*/
                string SQL = string.Format($"update TIECCUOI set tiendo = 'Hủy' WHERE matieccuoi = '{maTC}'");
                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;                
            }
            catch (Exception e)
            {

            }
            finally
            {
                //dong ket noi
                connect.Close();
            }
            return false;
        }

        public bool checkSanh_Ca(string ngaydai, string masanh, string maca)
        {
            string SQL = string.Format("SELECT * FROM TIECCUOI WHERE NgayDaiTiec = '{0}' AND MaSanh = '{1}' AND MaCa = '{2}'", ngaydai, masanh, maca);
            SQLiteDataAdapter da = new SQLiteDataAdapter(SQL, db.getConnection());
            DataTable dsTC = new DataTable();
            da.Fill(dsTC);            
            int i = dsTC.Rows.Count;
            Console.WriteLine($" COUNT {i}");
            if (i > 0) return false;
            return true;
        }


        public bool themPhieuDatDV(DTO_PhieuDatDichVu pddv)
        {
            //ket noi
            SQLiteConnection connect = db.getConnection();
            connect.Open();

            try
            {
                Console.WriteLine($"{pddv.MaDichVu}");
                string SQL = string.Format("INSERT INTO phieudatdichvu(MaTiecCuoi, MaDichVu, SoLuong) VALUES('{0}', '{1}', '{2}');", pddv.MaTiecCuoi, pddv.MaDichVu, pddv.SoLuong);
                SQLiteCommand cmd = new SQLiteCommand(SQL, connect);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (SQLiteException e)
            {
                Console.WriteLine($"{e}");
            }
            finally
            {
                //dong ket noi
                connect.Close();
            }
            return false;
        }

        public DataTable getPhieuDatDV(string mtc)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT DV.tendichvu as [Tên dịch vụ], soluong as [Số lượng] FROM phieudatdichvu PDV inner join Dichvu DV ON DV.maDichVu = PDV.madichvu WHERE matieccuoi ='" + mtc + "'", db.getConnection());
            DataTable dsPDV = new DataTable();
            da.Fill(dsPDV);
            return dsPDV;
        }
        public DataTable getCT_PhieuDatBan(string mtc)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT matieccuoi, mamonan, ghichu FROM PhieuDatBan WHERE matieccuoi ='" + mtc + "'", db.getConnection());
            DataTable dsPDV = new DataTable();
            da.Fill(dsPDV);
            return dsPDV;
        }
        public DataTable TimKiemDichVu(string tendv)
        {
            string sql = "SELECT * FROM DICHVU WHERE TENDICHVU LIKE '%" + tendv + "%';";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, db.getConnection());
            DataTable dsdv = new DataTable();
            da.Fill(dsdv);
            return dsdv;
        }

        public DataTable TimKiemMonAn(string tenma)
        {
            string sql = "SELECT MAMONAN, TENMONAN, DONGIA, MOTA FROM MONAN WHERE TENMONAN LIKE '%" + tenma + "%';";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, db.getConnection());
            DataTable dsma = new DataTable();
            da.Fill(dsma);
            return dsma;
        }

        public List<DTO_CT_PhieuDatBan> LoadDuLieuMA()
        {
            List<DTO_CT_PhieuDatBan> listSDT = new List<DTO_CT_PhieuDatBan>();

            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM PhieuDatBan", db.getConnection());
            DataTable table = new DataTable();

            foreach (DataRow item in table.Rows)
            {
                DTO_CT_PhieuDatBan SDT = new DTO_CT_PhieuDatBan(item);
                listSDT.Add(SDT);

            }
            return listSDT;
        }

    }
}
