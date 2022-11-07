using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kieudulieutudinhnghia
{
    struct Phanso
    {
        public int Tuso;
        public int Mauso;
    }

    class xulyphanso
    {
        public static Phanso NhapPhanSo()
        {
            Phanso kq;
            Console.WriteLine("Nhap tu so: ");
            kq.Tuso = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            kq.Mauso = int.Parse(Console.ReadLine());
            return kq;
        }

        public static Phanso TongPhanSo(Phanso a, Phanso b)
        {
            Phanso kq;
            kq.Tuso = a.Tuso * b.Mauso + a.Mauso * b.Tuso;
            kq.Mauso = a.Mauso * b.Mauso;
            return kq;
        }
    }
}

