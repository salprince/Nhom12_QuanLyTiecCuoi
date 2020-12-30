using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_YC5
    {
        DAL_YC5 dal = new DAL_YC5();
        public DataTable checkThang(string thang, string nam)
        {
            return dal.checkThang(thang, nam);
        }
        public string SoHD(string thang, string nam)
        {
            return dal.SoHD(thang, nam);
        }
        public int TongDoanhThu(string thang, string nam)
        {
            return dal.TongDoanhThu(thang, nam);
        }
        
        public int getMaBaoCaoThang()
        {
            return dal.getMaBaoCaoThang();
        }
    }
}
