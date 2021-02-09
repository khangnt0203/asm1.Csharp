using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ASM1_SE14028
{
    class SinhVien
    {
        private string mMaSV;
        private string HoTen;
        private DateTime NgaySinh;
        private string DiaChi;
        private string DienThoai;

        public SinhVien()
        {
            mMaSV = null;
            HoTen = null;
            NgaySinh = DateTime.Now;
            DiaChi = null;
            DienThoai = null;
        }

        public SinhVien(string mMaSV, string HoTen, DateTime NgaySinh,
            string DiaChi, string DienThoa)
        {
            this.mMaSV = mMaSV;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.DiaChi = DiaChi;
            this.DienThoai = DienThoa;
        }

        public string MaSV
        {
            get => mMaSV;
            set => mMaSV = value;
        }
        public string Name
        {
            get => HoTen;
            set => HoTen = value;
        }
        public DateTime DoB
        {
            get => NgaySinh;
            set => NgaySinh = value;
        }
        public string Address
        {
            get => DiaChi;
            set => DiaChi = value;
        }
        public string PhoneNo
        {
            get => DienThoai;
            set => DienThoai = value;
        }

        public SinhVien NhapThongTin()
        {
            Write("Enter ID: ");
            mMaSV = Validation.CheckEmpty();
            Write("Enter Name: ");
            HoTen = Validation.CheckEmpty();
            Write("Enter Date of Birth: ");
            NgaySinh = Validation.CheckDate();
            Write("Enter Address: ");
            DiaChi = Validation.CheckEmpty();
            Write("Enter PhoneNum: ");
            DienThoai = Validation.CheckEmpty();
            SinhVien sv = new SinhVien(mMaSV, HoTen, NgaySinh, DiaChi, DienThoai);
            return sv;
        }

        public string XuatThongTin()
        {
            return "Ma SV : " + MaSV + "\nHo ten : " + Name
                + "\nNgay Sinh : " + DoB + "\nDia Chi : " + Address
                + "\nSo Dien Thoai : " + PhoneNo;
        }
    }
}
