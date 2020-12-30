using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_HoaDon
    {
        DAL_HoaDon HoaDon = new DAL_HoaDon();

        public DataTable getHoaDon()
        {
            return HoaDon.getHoaDon();
        }

        public bool insertHoaDon(DTO_HoaDon hd)
        {
            return HoaDon.insertHoaDon(hd);
        }
        public void CapNhatTiecCuoi(string MaTC)
        {
            HoaDon.CapNhatTiecCuoi(MaTC);
        }
        public DataTable searchHoaDon(string tenchure, string tencodau)
        {
            return HoaDon.searchHoaDon(tenchure, tencodau);
        }

        public DataTable searchHoaDon(string mtc)
        {
            return HoaDon.searchHoaDon(mtc);
        }

        public DataTable searchHoaDon_NgayTT(string ngaytt)
        {
            return HoaDon.searchHoaDon_NgayTT(ngaytt);
        }

        public double TongTienBan(string MaTiecCuoi)
        {
            return HoaDon.TongTienBan(MaTiecCuoi);
        }

        public double TongTienDichVu(string MaTiecCuoi)
        {
            return HoaDon.TongTienDichVu(MaTiecCuoi);
        }


        public int getSoLuongBan(string MaTiecCuoi)
        {
            return HoaDon.getSoLuongBan(MaTiecCuoi);
        }

        public double getTienDatCoc(string MaTiecCuoi)
        {
            return HoaDon.getTienDatCoc(MaTiecCuoi);
        }

        public DataTable getChiTietDichVu(string mtc)
        {
            return HoaDon.getChiTietDichVu(mtc);
        }
        public string getNgayDaiTiec(string mtc)
        {
            return HoaDon.getNgayDaiTiec(mtc);
        }
    }
}
