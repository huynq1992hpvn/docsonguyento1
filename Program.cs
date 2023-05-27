using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("nhập một số nguyên tố không âm có tối đa 3 chữ số");
        int songuyento = int.Parse(Console.ReadLine());
        if (songuyento < 0 || songuyento > 999)
        {
            Console.WriteLine("nhập sai giá trị");
            return;
        }
        string[] hangdonvi = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        string[] hangchuc = { "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
        string[] hangtram = { "một trăm", "hai trăm", "ba trăm", "bốn trăm", "năm trăm", "sáu trăm", "bảy trăm", "tám trăm", "chín trăm" };
        int donvi = songuyento % 10;
        int chuc = (songuyento / 10) % 10;
        int tram = (songuyento / 100) % 10;
        Console.WriteLine("số nguyên tố bạn vừa nhập là : {0}", songuyento);
        if (tram > 0)
        {
            Console.Write(hangtram[tram - 1] + " ");
        }
        if (chuc == 0 && donvi > 0)
        {
            Console.WriteLine(" lẻ " + hangdonvi[donvi]);
        }
        else if (chuc == 1)
        {
            Console.WriteLine(hangchuc[chuc - 1] + " " + hangdonvi[donvi]);
        }
        else if (tram == 0 && chuc == 0)
        {
            Console.WriteLine(hangdonvi[donvi]);
        }
        else if (chuc > 1 && donvi == 0)
        {
            Console.WriteLine(hangchuc[chuc - 1]);
        }
        else
        {
            Console.WriteLine(hangchuc[chuc - 1] + " " + hangdonvi[donvi]);
        }
        Console.ReadKey();
        
    }
}


