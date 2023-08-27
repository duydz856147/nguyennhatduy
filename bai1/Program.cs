using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap ten toa do: ");
            string name = Console.ReadLine();
            a.SetName(name);
            toado a = new toado();
            Console.Write("nhap gia tri x: ");
            int x = int.Parse(Console.ReadLine());
            a.SetX(x);
            Console.Write("nhap gia tri y y: ");
            int y = int.Parse(Console.ReadLine());
            a.SetY(y);
            Console.WriteLine(a.ToString());
        }
    }
}
