using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_DichVu
    {
        DAL_YC2 dalTiecCuoi = new DAL_YC2();
        public bool checkSoLuongBanToiDa(string masanh, int slb)
        {
            return dalTiecCuoi.checkSoLuongBanToiDa(masanh, slb);
        }

        public DataTable getTiecCuoi()
        {
            return dalTiecCuoi.getTiecCuoi();
        }

        public DataTable getDichvu()
        {
            return dalTiecCuoi.getDichvu();
        }
        public DataTable getThucdon()
        {
            return dalTiecCuoi.getThucdon();
        }


        public bool themTiecCuoi(DTO_TiecCuoi tc)
        {
            return dalTiecCuoi.themTiecCuoi(tc);
        }

        public bool suaTiecCuoi(DTO_TiecCuoi tc)
        {
            return dalTiecCuoi.suaTiecCuoi(tc);
        }
        public bool xoaTiecCuoi(string ID)
        {
            return dalTiecCuoi.xoaTiecCuoi(ID);
        }

        public bool KTNhuan(int y)
        {
            return dalTiecCuoi.KTNhuan(y);
        }

        public bool KTNgay(int d, int m, int y)
        {
            return dalTiecCuoi.KTNgay(d, m, y);
        }

        public int DayMonthYear_to_Day(int d, int m, int y)
        {
            return dalTiecCuoi.DayMonthYear_to_Day(d, m, y);
        }

        public string GopNgay(int d, int m, int y)
        {
            return dalTiecCuoi.GopNgay(d, m, y);
        }

        public DataTable searchMonAn(string key)
        {
            return dalTiecCuoi.searchMonAn(key);
        }
        public DataTable getMonAn()
        {
            return dalTiecCuoi.getMonAn();
        }
        public DataTable getMonAnDaDat(String maTC)
        {
            return dalTiecCuoi.getMonAnDaDat(maTC);
        }
        public DataTable getDichVuDaDat(String maTC)
        {
            return dalTiecCuoi.getDichVuDaDat(maTC);
        }

        public DataTable getPhieuDatBan()
        {
            return dalTiecCuoi.getPhieuDatBan();
        }

        public DataTable getPhieuDatBan(string mtc)
        {
            return dalTiecCuoi.getPhieuDatBan(mtc);
        }

        public bool themPhieuDatBan(DTO_PhieuDatBan pdb)
        {
            return dalTiecCuoi.themPhieuDatBan(pdb);
        }

        public DataTable getLoaiSanh(string masanh)
        {
            return dalTiecCuoi.getLoaiSanh(masanh);
        }

        public bool themCT_PhieuDatBan(DTO_CT_PhieuDatBan ct_pdb)
        {
            return dalTiecCuoi.themCT_PhieuDatBan(ct_pdb);
        }

        public bool updatePhieuDatBan(int dongia, string mapdb)
        {
            return dalTiecCuoi.updatePhieuDatBan(dongia, mapdb);
        }

        public bool xoaCT_PhieuDatBan(string mapdb,int type=1)
        {
            return dalTiecCuoi.xoaCT_PhieuDatBan(mapdb,type);
        }

        public bool checkSanh_Ca(string ngaydai, string masanh, string maca)
        {
            return dalTiecCuoi.checkSanh_Ca(ngaydai, masanh, maca);
        }

        public bool themPhieuDatDV(DTO_PhieuDatDichVu pddv)
        {
            return dalTiecCuoi.themPhieuDatDV(pddv);
        }

        public DataTable getPhieuDatDV(string mtc)
        {
            return dalTiecCuoi.getPhieuDatDV(mtc);
        }
        public DataTable getCT_PhieuDatBan(string mtc)
        {
            return dalTiecCuoi.getCT_PhieuDatBan(mtc);
        }
        public DataTable TimKiemDichVu(string dv)
        {
            return dalTiecCuoi.TimKiemDichVu(dv);
        }
        public DataTable TimKiemMonAn(string ma)
        {
            return dalTiecCuoi.TimKiemMonAn(ma);
        }
    }
}
