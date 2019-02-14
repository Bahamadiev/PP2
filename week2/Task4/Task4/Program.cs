using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "POP.txt"; // имя файла который я хочу создать
            string PathString = @"C:\Users\acer aspire\Desktop"; // и где я его хочу создать
            PathString = Path.Combine(PathString, fileName); // нужно скомбинировать их пути
            FileStream fs = File.Create(PathString); // и создаем файл
            fs.Close(); // нужно чтобы прекратил работу

            string PathString2 = @"C:\Users\acer aspire\Desktop\pp2"; // путь куда я должен  скопировать

            string destFile = System.IO.Path.Combine(PathString2, fileName); // скомбинируем путь
            File.Copy(PathString, destFile, true); // копируем туда

            File.Delete(PathString); // и удаляем оригинал
        }
    }
}
