using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_TiecCuoi
    {
        private string _MaTiecCuoi;
        private string _TenChuRe;
        private string _TenCoDau;
        private string _DienThoai;
        private string _NgayDatTiec;
        private string _NgayDaiTiec;
        private string _MaCa;
        private string _MaSanh;
        private int _TienDatCoc;
        private int _SoLuongKhach;
        private int _SoLuongBan;
        private string _TienDo;

        private string _GhiChu;
        public int SoLuongKhach
        {
            get { return this._SoLuongKhach; }
            set { this._SoLuongKhach = value; }
        }
        public int SoLuongBan
        {
            get { return this._SoLuongBan; }
            set { this._SoLuongBan = value; }
        }
        public string TienDo
        {
            get { return this._TienDo; }
            set { this._TienDo = value; }
        }
        public string MaTiecCuoi
        {
            get { return this._MaTiecCuoi; }
            set { this._MaTiecCuoi = value; }
        }
        public string TenChuRe
        {
            get { return this._TenChuRe; }
            set { this._TenChuRe = value; }
        }
        public string TenCoDau
        {
            get { return this._TenCoDau; }
            set { this._TenCoDau = value; }
        }
        public string DienThoai
        {
            get { return this._DienThoai; }
            set { this._DienThoai = value; }
        }
        public string NgayDatTiec
        {
            get { return this._NgayDatTiec; }
            set { this._NgayDatTiec = value; }
        }
        public string NgayDaiTiec
        {
            get { return this._NgayDaiTiec; }
            set { this._NgayDaiTiec = value; }
        }
        public string MaCa
        {
            get { return this._MaCa; }
            set { this._MaCa = value; }
        }
        public string MaSanh
        {
            get { return this._MaSanh; }
            set { this._MaSanh = value; }
        }
        public int TienDatCoc
        {
            get { return this._TienDatCoc; }
            set { this._TienDatCoc = value; }
        }
        public string GhiChu
        {
            get { return this._GhiChu; }
            set { this._GhiChu = value; }
        }

        public DTO_TiecCuoi(string ma, string tCoDau, string tChuRe, string dienThoai, string maCa, string maSanh, int tiendc, string ghichu, string ngaydattiec, string ngaydaitiec, int slBan, int slKhach, string tienDo)
        {
            this.MaTiecCuoi = ma;
            this.TenChuRe = tChuRe;
            this.TenCoDau = tCoDau;
            this.DienThoai = dienThoai;
            this.NgayDatTiec = ngaydattiec;
            this.NgayDaiTiec = ngaydaitiec;
            this.MaCa = maCa;
            this.MaSanh = maSanh;
            this.TienDatCoc = tiendc;
            this.GhiChu = ghichu;
            this.SoLuongBan = slBan;
            this.SoLuongKhach = slKhach;
            this.TienDo = tienDo;

        }
    }
}
