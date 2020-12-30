using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_PhieuDatDichVu
    {
        private string _MaTiecCuoi;
        private string _MaDichVu;
        private int _SoLuong;
        private int _DonGia;

        public string MaTiecCuoi
        {
            get { return this._MaTiecCuoi; }
            set { this._MaTiecCuoi = value; }
        }
        public string MaDichVu
        {
            get { return this._MaDichVu; }
            set { this._MaDichVu = value; }
        }
        
        public int SoLuong
        {
            get { return this._SoLuong; }
            set { this._SoLuong = value; }
        }
        public int DonGia
        {
            get { return this._DonGia; }
            set { this._DonGia = value; }
        }

        public DTO_PhieuDatDichVu(string a, string b, int c, int d)
        {
            this.MaTiecCuoi = a;
            this.MaDichVu = b;
            this.SoLuong = c;
            this.DonGia = d;
        }
    }
}
