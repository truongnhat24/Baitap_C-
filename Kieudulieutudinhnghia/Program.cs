using System;
namespace Kieudulieutudinhnghia
{
    class program
    {
        static void Main(string[] args)
        {
            Phanso a, b;
            a = xulyphanso.NhapPhanSo();
            b = xulyphanso.NhapPhanSo();

            Phanso s;
            s = xulyphanso.TongPhanSo(a, b);
            Console.WriteLine($"{s.Tuso}/{ s.Mauso}");
        }
    }
}