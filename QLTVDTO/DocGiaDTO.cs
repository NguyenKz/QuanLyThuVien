using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVDTO
{
    public class DocGiaDTO
    {
        private String iMaDocGia;

        public String Ma
        {
            get { return iMaDocGia; }
            set { iMaDocGia = value; }
        }
        private string sHovaTen;

        public string HovaTen
        {
            get { return sHovaTen; }
            set { sHovaTen = value; }
        }
        private DateTime dtNgaySinh;

        public DateTime NgaySinh
        {
            get { return dtNgaySinh; }
            set { dtNgaySinh = value; }
        }

        private string sEmail;

        public string Email
        {
            get { return sEmail; }
            set { sEmail = value; }
        }

        private string sDiaChi;

        public string DiaChi
        {
            get { return sDiaChi; }
            set { sDiaChi = value; }
        }

        private string sLoaiDocGia;

        public string maLoaiDocGia
        {
            get { return sLoaiDocGia; }
            set { sLoaiDocGia = value; }
        }
        public string stenLoaiDocGia;
        public string TenLoaiDocGia
        {
            get { return stenLoaiDocGia; }
            set { stenLoaiDocGia = value; }
        }


        private DateTime dtNgayLapThe;

        public DateTime NgayLapThe
        {
            get { return dtNgayLapThe; }
            set { dtNgayLapThe = value; }
        }

        private int dtHanSuDung;

        public int HanSuDung
        {
            get { return dtHanSuDung; }
            set { dtHanSuDung = value; }
        }

        //public int Ma { get => ma; set => ma = value; }
        //public string Ten { get => ten; set => ten = value; }
        //public string Mota { get => mota; set => mota = value; }
    }
    }
