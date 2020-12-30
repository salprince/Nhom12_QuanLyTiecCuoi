using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DTO
{
    public class DTO_PhieuDatBan
    {
        private string _MaPhieuDatBan;
        private string _MaTiecCuoi;
        private string _LoaiBan;
        private int _SoLuong;
        private int _SoLuongDuTru;
        private int _DonGiaBan;
        private string _GhiChu;

        public string MaPhieuDatBan
        {
            get { return this._MaPhieuDatBan; }
            set { this._MaPhieuDatBan = value; }
        }
        public string MaTiecCuoi
        {
            get { return this._MaTiecCuoi; }
            set { this._MaTiecCuoi = value; }
        }
        public string LoaiBan
        {
            get { return this._LoaiBan; }
            set { this._LoaiBan = value; }
        }
        public int SoLuong
        {
            get { return this._SoLuong; }
            set { this._SoLuong = value; }
        }
        public int SoLuongDuTru
        {
            get { return this._SoLuongDuTru; }
            set { this._SoLuongDuTru = value; }
        }
        public int DonGiaBan
        {
            get { return this._DonGiaBan; }
            set { this._DonGiaBan = value; }
        }
        public string GhiChu
        {
            get { return this._GhiChu; }
            set { this._GhiChu = value; }
        }

        public DTO_PhieuDatBan(string a, string b, string c, int d, int e, int f, string g)
        {
            this.MaPhieuDatBan = a;
            this.MaTiecCuoi = b;
            this.LoaiBan = c;
            this.SoLuong = d;
            this.SoLuongDuTru = e;
            this.DonGiaBan = f;
            this.GhiChu = g;
        }

    }
}
