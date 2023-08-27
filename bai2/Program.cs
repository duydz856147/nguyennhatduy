using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            sinhVien sv1 = new sinhVien(11111, "Nguyen Nhat Duy", 8.5, 9.0);
            sinhVien sv2 = new sinhVien(22222, "Nguyen Van B", 7.0, 7.5);
            sinhVien sv3 = new sinhVien();

            Console.WriteLine("nhap thong tin sinh vien 3:");
            Console.Write("ma sinh vien: ");
            int maSinhVien3 = int.Parse(Console.ReadLine());
            Console.Write("ho ten: ");
            string hoTen3 = Console.ReadLine();
            Console.Write("diem li thuyet: ");
            double diemLT3 = double.Parse(Console.ReadLine());
            Console.Write("diem thuc hanh: ");
            double diemTH3 = double.Parse(Console.ReadLine());

            sv3.SetMaSinhVien(maSinhVien3);
            sv3.SetHoTen(hoTen3);
            sv3.SetDiemLT(diemLT3);
            sv3.SetDiemTH(diemTH3);

            Console.WriteLine();
            Console.WriteLine("|{0,-10}|{1,-20}|{2,-10}|{3,-10}|{4,-10}|",
                "MSSV", "ho ten", "diem LT", "diem TH", "diem TB");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sv1.ToString());
            Console.WriteLine(sv2.ToString());
            Console.WriteLine(sv3.ToString());
        }
    }
}
