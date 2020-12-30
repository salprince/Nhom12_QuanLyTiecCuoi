using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using DTO;

namespace DAL
{
    public class DAL_YC6 : DBConnect
    {
        // Get data (table)
        public DataTable getSanh()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM SANH", getConnection());
            DataTable dsSanh = new DataTable();
            da.Fill(dsSanh);
            return dsSanh;
        }

        public DataTable getLoaiSanh()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM LOAISANH", getConnection());
            DataTable dsLoaiSanh = new DataTable();
            da.Fill(dsLoaiSanh);
            return dsLoaiSanh;
        }

        public DataTable getCa()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM CA", getConnection());
            DataTable dsCa = new DataTable();
            da.Fill(dsCa);
            return dsCa;
        }

        public DataTable getDichVu()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM DichVu", getConnection());
            DataTable dsDichVu = new DataTable();
            da.Fill(dsDichVu);
            return dsDichVu;
        }

        public DataTable getMonAn()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM MonAn", getConnection());
            DataTable dsMonAn = new DataTable();
            da.Fill(dsMonAn);
            return dsMonAn;
        }

        public DataTable getThamSo()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM ThamSo", getConnection());
            DataTable dsThamSo = new DataTable();
            da.Fill(dsThamSo);
            return dsThamSo;
        }

        // Insert data
        public bool insertSanh(DTO_Sanh sanh)
        {
            // Ket noi
            SQLiteConnection connect = getConnection();
            connect.Open();

            try
            {
                // Query string
                string SQL = string.Format("INSERT INTO SANH(MASANH, TENSANH, MALOAISANH, SOLUONGBANTOIDA, GHICHU) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", sanh.MaSanh, sanh.TenSanh, sanh.MaLoaiSanh, sanh.SoLuongBanToiDa, sanh.GhiChu);

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

        public bool insertDichVu(DTO_DichVu dvu)
        {
            // Ket noi
            SQLiteConnection connect = getConnection();
            connect.Open();

            try
            {
                // Query string
                string SQL = string.Format("INSERT INTO DICHVU(MADICHVU, TENDICHVU, MOTA, DONGIA, GHICHU) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", dvu.MaDichVu, dvu.TenDichVu, dvu.MoTa, dvu.DonGia, dvu.GhiChu);

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

        public bool insertMonAn(DTO_MonAn man)
        {
            // Ket noi
            SQLiteConnection connect = getConnection();
            connect.Open();

            try
            {
                // Query string
                string SQL = string.Format("INSERT INTO MONAN(MAMONAN, TENMONAN, MOTA, DONGIA, GHICHU) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", man.MaMonAn, man.TenMonAn, man.MoTa, man.DonGia, man.GhiChu);

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


        // Edit data
        public bool editSanh(DTO_Sanh sanh)
        {
            // Ket noi
            SQLiteConnection connect = getConnection();
            connect.Open();

            try
            {
                // Query string
                string SQL = string.Format("UPDATE SANH SET TENSANH = '{0}', MALOAISANH = '{1}', SOLUONGBANTOIDA = '{2}', GHICHU = '{3}' WHERE MASANH = '{4}';", sanh.TenSanh, sanh.MaLoaiSanh, sanh.SoLuongBanToiDa, sanh.GhiChu, sanh.MaSanh);

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

        public bool editDichVu(DTO_DichVu dvu)
        {
            // Ket noi
            SQLiteConnection connect = getConnection();
            connect.Open();

            try
            {
                // Query string
                string SQL = string.Format("UPDATE DICHVU SET TENDICHVU = '{0}', MOTA = '{1}', DONGIA = '{2}', GHICHU = '{3}' WHERE MADICHVU = '{4}'", dvu.TenDichVu, dvu.MoTa, dvu.DonGia, dvu.GhiChu, dvu.MaDichVu);

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

        public bool editMonAn(DTO_MonAn man)
        {
            // Ket noi
            SQLiteConnection connect = getConnection();
            connect.Open();

            try
            {
                // Query string
                string SQL = string.Format("UPDATE MONAN SET TENMONAN = '{0}', MOTA = '{1}', DONGIA = '{2}', GHICHU = '{3}' WHERE MAMONAN = '{4}';", man.TenMonAn, man.MoTa, man.DonGia, man.GhiChu, man.MaMonAn);

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

        public bool editThamSoPhat(int check)
        {
            // Ket noi
            SQLiteConnection connect = getConnection();
            connect.Open();

            try
            {
                // Query string
                string SQL = string.Format("UPDATE THAMSO SET GIATRI = '{0}' WHERE TENTHAMSO = 'ApDungQDPhat';", check);


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

        public bool editTiLePhat(double tile)
        {
            // Ket noi
            SQLiteConnection connect = getConnection();
            connect.Open();

            try
            {
                // Query string
                string SQL = string.Format("UPDATE THAMSO SET GIATRI = '{0}' WHERE TENTHAMSO = 'TiLePhat';", tile);

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

        // Delete data
        public bool deleteSanh(string id)
        {
            // Ket noi
            SQLiteConnection connect = getConnection();
            connect.Open();

            try
            {
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM SANH WHERE MASANH = '{0}';", id);

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

        public bool deleteLoaiSanh(string id)
        {
            // Ket noi
            SQLiteConnection connect = getConnection();
            connect.Open();

            try
            {
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM LOAISANH WHERE MALOAISANH = '{0}';", id);

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

        public bool deleteDichVu(string id)
        {
            // Ket noi
            SQLiteConnection connect = getConnection();
            connect.Open();

            try
            {
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM DICHVU WHERE MADICHVU = '{0}';", id);
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

        public bool deleteMonAn(string id)
        {
            // Ket noi
            SQLiteConnection connect = getConnection();
            connect.Open();

            try
            {
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần ID là đủ
                string SQL = string.Format("DELETE FROM MONAN WHERE MAMONAN = '{0}';", id);

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


        // Search data
        public DataTable searchSanh(string tensanh)
        {
            string sql = "SELECT * FROM SANH WHERE TENSANH LIKE '%" + tensanh + "%';";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, getConnection());
            DataTable dsSanh = new DataTable();
            da.Fill(dsSanh);
            return dsSanh;
        }

        public DataTable searchLoaiSanh(string tenlsanh)
        {
            string sql = "SELECT * FROM LOAISANH WHERE TENLOAISANH LIKE '%" + tenlsanh + "%';";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, getConnection());
            DataTable dsLSanh = new DataTable();
            da.Fill(dsLSanh);
            return dsLSanh;
        }

        public DataTable searchCa(string tenca)
        {
            string sql = "SELECT * FROM CA WHERE TENCA LIKE '%" + tenca + "%';";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, getConnection());
            DataTable dsCa = new DataTable();
            da.Fill(dsCa);
            return dsCa;
        }

        public DataTable searchDichVu(string key)
        {
            string sql = "SELECT * FROM DICHVU WHERE TENDICHVU LIKE '%" + key + "%' OR MOTA LIKE '%" + key + "%' OR GHICHU LIKE '%" + key + "%';";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, getConnection());
            DataTable dsDVu = new DataTable();
            da.Fill(dsDVu);
            return dsDVu;
        }

        public DataTable searchMonAn(string key)
        {
            string sql = "SELECT * FROM MONAN WHERE TENMONAN LIKE '%" + key + "%' OR MOTA LIKE '%" + key + "%' OR GHICHU LIKE '%" + key + "%';";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, getConnection());
            DataTable dsMAn = new DataTable();
            da.Fill(dsMAn);
            return dsMAn;
        }
        public DataTable searchMA(string key)
        {
            string sql = "SELECT * FROM CT_Phieudanban WHERE TENMONAN LIKE '%" + key + "%' OR MOTA LIKE '%" + key + "%' OR GHICHU LIKE '%" + key + "%';";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, getConnection());
            DataTable dsMAn = new DataTable();
            da.Fill(dsMAn);
            return dsMAn;
        }
        public DataTable searchDV(string key)
        {
            string sql = String.Format("SELECT * FROM PHIEUDATDICHVU WHERE MADICHVU LIKE '{0}'", key);
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, getConnection());
            DataTable dsDVu = new DataTable();
            da.Fill(dsDVu);
            return dsDVu;
        }
        public DataTable searchSANH(string masanh)
        {
            string sql = "SELECT * FROM TIECCUOI WHERE MaSANH LIKE '%" + masanh + "%';";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, getConnection());
            DataTable dsSanh = new DataTable();
            da.Fill(dsSanh);
            return dsSanh;
        }

        public DataTable searchLOAISANH(string maLS)
        {
            string sql = "SELECT * FROM SANH WHERE MALOAISANH LIKE '%" + maLS + "%';";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, getConnection());
            DataTable dsLSanh = new DataTable();
            da.Fill(dsLSanh);
            return dsLSanh;
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
