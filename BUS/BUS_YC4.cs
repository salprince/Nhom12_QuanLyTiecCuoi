using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Text;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_YC4
    {
        DAL_YC4 dalYC4 = new DAL_YC4();

        public DataTable getHoaDon()
        {
            return dalYC4.getHoaDon();
        }

        public bool insertHoaDon(DTO_HoaDon hd)
        {
            bool kt = dalYC4.xoaTiecCuoi(hd.MaTiecCuoi);
            return dalYC4.insertHoaDon(hd);
            
        }

        public DataTable searchHoaDon(string tenchure, string tencodau)
        {
            return dalYC4.searchHoaDon(tenchure, tencodau);
        }

        public DataTable searchHoaDon(string mtc)
        {
            return dalYC4.searchHoaDon(mtc);
        }

        public DataTable searchHoaDon_NgayTT(string ngaytt)
        {
            return dalYC4.searchHoaDon_NgayTT(ngaytt);
        }

        public double TongTienBan(string MaTiecCuoi)
        {
            return dalYC4.TongTienBan(MaTiecCuoi);
        }

        public double TongTienDichVu(string MaTiecCuoi)
        {
            return dalYC4.TongTienDichVu(MaTiecCuoi);
        }

        public string getNgayDaiTiec(string MaTiecCuoi)
        {
            return dalYC4.getNgayDaiTiec(MaTiecCuoi);
        }

        public int getSoLuongBan(string MaTiecCuoi)
        {
            return dalYC4.getSoLuongBan(MaTiecCuoi);
        }

        public double getTienDatCoc(string MaTiecCuoi)
        {
            return dalYC4.getTienDatCoc(MaTiecCuoi);
        }

        public double TinhTienPhat(string MaTiecCuoi, int ngaytt, int thangtt, int namtt)
        {
            return dalYC4.TinhTienPhat(MaTiecCuoi, ngaytt, thangtt, namtt);
        }

        public DataTable getChiTietDichVu(string mtc)
        {
            return dalYC4.getChiTietDichVu(mtc);
        }

        public bool KTNhuan(int year)
        {
            return dalYC4.KTNhuan(year);
        }

        public bool KTNgay(int ngay, int thang, int nam)
        {
            return dalYC4.KTNgay(ngay, thang, nam);
        }

        public int DayMonthYear_to_Day(int day, int month, int year)
        {
            return dalYC4.DayMonthYear_to_Day(day, month, year);
        }
        public bool xoaTiecCuoi(string ID)
        {
            return dalYC4.xoaTiecCuoi(ID);
        }
            }
}
