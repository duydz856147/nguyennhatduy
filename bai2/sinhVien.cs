using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    public class sinhVien
    {
        private int maSinhVien;
        private string hoTen;
        private double diemLT;
        private double diemTH;
        public sinhVien()
        {
            maSinhVien = 0;
            hoTen = "";
            diemLT = 0.0;
            diemTH = 0.0;
        }
        public sinhVien(int maSinhVien, string hoTen, double diemLT, double diemTH)
        {
            this.maSinhVien = maSinhVien;
            this.hoTen = hoTen;
            this.diemLT = diemLT;
            this.diemTH = diemTH;
        }

        public int GetMaSinhVien()
        {
            return maSinhVien;
        }

        public void SetMaSinhVien(int maSinhVien)
        {
            if (maSinhVien > 0)
            {
                this.maSinhVien = maSinhVien;
            }
        }

        public string GetHoTen()
        {
            return hoTen;
        }

        public void SetHoTen(string hoTen)
        {
            if (!string.IsNullOrEmpty(hoTen))
            {
                this.hoTen = hoTen;
            }
        }

        public double GetDiemLT()
        {
            return diemLT;
        }

        public void SetDiemLT(double diemLT)
        {
            if (diemLT >= 0.0 && diemLT <= 10.0)
            {
                this.diemLT = diemLT;
            }
        }

        public double GetDiemTH()
        {
            return diemTH;
        }

        public void SetDiemTH(double diemTH)
        {
            if (diemTH >= 0.0 && diemTH <= 10.0)
            {
                this.diemTH = diemTH;
            }
        }
        public double TinhDiemTrungBinh()
        {
            return (diemLT + diemTH) / 2;
        }
        public override string ToString()
        {
            return string.Format("{0,-10}{1,-20}{2,-10}{3,-10}{4,-10}",
                maSinhVien, hoTen, diemLT.ToString("F2"), diemTH.ToString("F2"), TinhDiemTrungBinh().ToString("F2"));
        }
    }
}