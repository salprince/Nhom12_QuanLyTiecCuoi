using System;
using System.Data;
using System.Data.SQLite;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalDA = new DAL_NhanVien();

        public DataTable getNhanVien()
        {
            return dalDA.getNhanVien();
        }
        public bool insertNV(DTO_NhanVien nv)
        {
            return dalDA.insertNV(nv);
        }
        public bool checkUser(String user, String pass)
        {
            return dalDA.checkUser(user, pass);
        }
    }
}
