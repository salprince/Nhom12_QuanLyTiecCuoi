using System;
using System.Data;
using System.Data.SQLite;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_TiecCuoi
    {
        DAL_TiecCuoi dalTiecCuoi = new DAL_TiecCuoi();

        public DataTable getTiecCuoi()
        {
            return dalTiecCuoi.getTiecCuoi();
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
        public bool xoaPhieuDatBan(string ID)
        {
            return dalTiecCuoi.xoaPhieuDatMonAn(ID);
        }
        public DataTable SearchTiecCuoi(string MatiecCuoi)
        {
            return dalTiecCuoi.SearchTiecCuoi(MatiecCuoi);
        }

        public DataTable XemTiecCuoi()
        {
            return dalTiecCuoi.XemTiecCuoi();

        }
        public bool HuyTiecCuoi(string MatiecCuoi)
        {
            return dalTiecCuoi.huyTiecCuoi(MatiecCuoi);

        }
        public double CapNhatHuyTiec(string ID)
        {
            dalTiecCuoi.CapNhatHuy(ID);
            return GetTiecCoc(ID) * ((100 - getTienDo(ID)) / 100);
        }
        public double GetTiecCoc(string ID)
        {
            return dalTiecCuoi.getTienDatCoc(ID);
        }
        public double getTienDo(string ID)
        {
            return dalTiecCuoi.getTienDo(ID);
        }
        public double TongTienBan(string MaTiecCuoi)
        {
            return dalTiecCuoi.TongTienBan(MaTiecCuoi);
        }

        public double TongTienDichVu(string MaTiecCuoi)
        {
            return dalTiecCuoi.TongTienDichVu(MaTiecCuoi);
        }
        public bool capnhatTienCoc(double TiecCoc, string MaTC)
        {
            return dalTiecCuoi.capnhatTienCoc(TiecCoc, MaTC);
        }
        public DataTable getTiecCuoi(String id)
        {
            return dalTiecCuoi.getTiecCuoi(id);
        }
    }


}
