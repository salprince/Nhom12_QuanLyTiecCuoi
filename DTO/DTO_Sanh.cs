using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_Sanh
    {
        private string _MaSanh;
        private string _TenSanh;
        private string _MaLoaiSanh;
        private int _SoLuongBanToiDa;
        private int _SoLuongBanToiThieu;
        private int _DonGiaBanToiThieu;
        private string _GhiChu;


        public string MaSanh
        {
            get { return this._MaSanh; }
            set { this._MaSanh = value; }
        }
        public string TenSanh
        {
            get { return this._TenSanh; }
            set { this._TenSanh = value; }
        }
        public string MaLoaiSanh
        {
            get { return this._MaLoaiSanh; }
            set { this._MaLoaiSanh = value; }
        }
        public int SoLuongBanToiDa
        {
            get { return this._SoLuongBanToiDa; }
            set { this._SoLuongBanToiDa = value; }
        }
        public int SoLuongBanToiThieu
        {
            get { return this._SoLuongBanToiThieu; }
            set { this._SoLuongBanToiThieu = value; }
        }
        public int DonGiaBanToiThieu
        {
            get { return this._DonGiaBanToiThieu; }
            set { this._DonGiaBanToiThieu = value; }
        }
        public string GhiChu
        {
            get { return this._GhiChu; }
            set { this._GhiChu = value; }
        }
        public DTO_Sanh(string a, string b, int c, int d, int e, string f)
        {
            this.MaSanh = a;
            this.TenSanh = b;
            this.SoLuongBanToiDa = c;
            this.SoLuongBanToiThieu = d;
            this.DonGiaBanToiThieu = e;
            this.GhiChu = f;
        }
    }
}
