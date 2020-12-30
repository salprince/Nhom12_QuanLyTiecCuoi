using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_BaoCao
    {
        private string _MaBaoCao;
        private int _Quy;
        private int _Nam;
        private int _TongThu;
        private int _TongSoTiecCuoi;
        private float _TyLeThanhCong;
        private float _TyLeHuy;
        public string MaBaoCao
        {
            get { return this._MaBaoCao; }
            set { this._MaBaoCao = value; }
        }
        public int Quy
        {
            get { return this._Quy; }
            set { this._Quy = value; }
        }
        public int Nam
        {
            get { return this._Nam; }
            set { this._Nam = value; }
        }
        public int TongThu
        {
            get { return this._TongThu; }
            set { this._TongThu = value; }
        }
        public int TongSoTiecCuoi
        {
            get { return this._TongSoTiecCuoi; }
            set { this._TongSoTiecCuoi = value; }
        }
        public float TyLeThanhCong
        {
            get { return this._TyLeThanhCong; }
            set { this._TyLeThanhCong = value; }
        }
        public float TyLeHuy       {
            get { return this._TyLeHuy; }
            set { this._TyLeHuy = value; }
        }
        public DTO_BaoCao(string a, int b, int c, int d,int e, float f, float g)
        {
            this.MaBaoCao = a;
            this.Quy = b;
            this.Nam = c;
            this.TongThu = d;
            this.TongSoTiecCuoi = e;
            this.TyLeThanhCong = f;
            this.TyLeHuy = g;
        }
    }
}
