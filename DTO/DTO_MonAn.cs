using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_MonAn
    {
        private string _MaMonAn;
        private string _TenMonAn;
        private string _MoTa;
        private int _DonGia;
        private string _GhiChu;

        public string MaMonAn
        {
            get { return this._MaMonAn; }
            set { this._MaMonAn = value; }
        }
        public string TenMonAn
        {
            get { return this._TenMonAn; }
            set { this._TenMonAn = value; }
        }
        public int DonGia
        {
            get { return this._DonGia; }
            set { this._DonGia = value; }
        }
        public string MoTa
        {
            get { return this._MoTa; }
            set { this._MoTa = value; }
        }
        public string GhiChu
        {
            get { return this._GhiChu; }
            set { this._GhiChu = value; }
        }
        public DTO_MonAn(string a, string b, string c, int d, string e)
        {
            this.MaMonAn = a;
            this.TenMonAn = b;
            this.MoTa = c;
            this.DonGia = d;
            this.GhiChu = e;
        }
    }
}
