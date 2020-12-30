using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_HoaDon
    {
        private string _SoHoaDon;
        private string _MaTiecCuoi;
        private string _NgayThanhToan;
        private int _TongTienBan;
        private int _TongTienDichVu;
        private int _TongTienHoaDon;
        private int _ConLai;
        private int _TrangThaiThanhToan;
        public string SoHoaDon
        {
            get { return this._SoHoaDon; }
            set { this._SoHoaDon = value; }
        }
        public string MaTiecCuoi
        {
            get { return this._MaTiecCuoi; }
            set { this._MaTiecCuoi = value; }
        }
        public string NgayThanhToan
        {
            get { return this._NgayThanhToan; }
            set { this._NgayThanhToan = value; }
        }
        public int TongTienBan
        {
            get { return this._TongTienBan; }
            set { this._TongTienBan= value; }
        }
        public int TongTienDichVu
        {
            get { return this._TongTienDichVu; }
            set { this._TongTienDichVu= value; }
        }
        public int TongTienHoaDon
        {
            get { return this._TongTienHoaDon; }
            set { this._TongTienHoaDon = value; }
        }
        public int ConLai
        {
            get { return this._ConLai; }
            set { this._ConLai = value; }
        }
        public int TrangThaiThanhToan
        {
            get { return this._TrangThaiThanhToan; }
            set { this._TrangThaiThanhToan = value; }
        }

        public DTO_HoaDon(string a, string b, string c, int d, int e, int f, int g, int h)
        {
            this.SoHoaDon = a;
            this.MaTiecCuoi = b;
            this.NgayThanhToan = c;
            this.TongTienBan = d;
            this.TongTienDichVu = e;
            this.TongTienHoaDon = f;
            this.ConLai = g;
            this.TrangThaiThanhToan = h;
        }
    }
}
