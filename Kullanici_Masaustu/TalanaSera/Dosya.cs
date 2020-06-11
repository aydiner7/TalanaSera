using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalanaSera
{
    public class Dosya
    {
        Sifre sifre = new Sifre();
        public void dosyayaYaz(string server, string kadi, string pass,string kod)
        {
            string dosya_yolu = @"C:\Talana\config.txt";
            if (File.Exists(dosya_yolu))
            {
                File.Delete(dosya_yolu);
            }
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(sifre.Encrypt(server));
            sw.WriteLine(sifre.Encrypt(kadi));
            sw.WriteLine(sifre.Encrypt(pass));
            sw.WriteLine(sifre.Encrypt(kod));


            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public List<string> dosyadanOku()
        {
            string dosya_yolu = @"C:\Talana\config.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosyanın açılacağını,
            //3.parametre dosyaya erişimin veri okumak için olacağını gösterir.
            StreamReader sw = new StreamReader(fs);
            //Okuma işlemi için bir StreamReader nesnesi oluşturduk.
            string yazi = sw.ReadLine();
            List<string> geriDeger = new List<string>();
            while (yazi != null)
            {
                geriDeger.Add(sifre.Decrypt(yazi));
                yazi = sw.ReadLine();
            }
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
            return geriDeger;
        }
    }
}
