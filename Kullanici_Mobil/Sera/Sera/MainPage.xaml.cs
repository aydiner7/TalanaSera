using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sera
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           // _client = new HttpClient();
        }
        private bool kullanicidogrula(string kod, string sifre)
        {
            try
            {
                WebClient webClient = new WebClient();
                string gelen = webClient.DownloadString("http://192.168.0.10:44444/api/KullaniciGiris/?kod=" + kod + "&sifre=" + sifre);
                JObject jObject1 = JObject.Parse(gelen);
                return true;
            }
            catch (Exception ex)
            {

                string hata = ex.Message;
                return false;
            }

        }
        private async void Button_Clicked(object sender, EventArgs e)
        {

            try
            {
                WebClient veriCek = new WebClient();
                String url = "http://192.168.0.10:44444/api/Baglanti/?Kadi=Talana&Sifre=Talana";
                string gelen = veriCek.DownloadString(url);
                if (gelen == "true")
                {
                    if (kullanicidogrula("123", sifrEntry.Text))
                    {

                        Application.Current.MainPage = new Anasayfa();

                    }
                    else
                    {
                        await DisplayAlert("Uyari","Şifre Hatalı", "Tamam");
                    }
                }
                else
                    await DisplayAlert("Uyari","Sunucu Ayarlarınızı Kontrol Ediniz", "Tamam");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Uyari","Sunucuya Bağlanılamadı.\nHata :" + ex.Message,"Tamam");
            }   
            
            /*
            cerceve.IsVisible = true;
            anim.Play();
            User user = new User();
            user.id = 1;
            user.sifre = sifrEntry.Text;

            Sera sera = new Sera();
           /* sera.id =;
            sera.ad =;
            sera.durum =;
            sera.tarih =; 
            await Gonder(user,true);
            await Goster(sera, true);*/

        }
      /*  HttpClient _client;
        public async Task Gonder(User item, bool isNewItem = false)
        {
            var uri = new Uri(string.Format("http://127.0.0.1:44455/api/Giris/GirisKontrol", string.Empty));

         
            var json = JsonConvert.SerializeObject(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = null;
            if (isNewItem)
            {
                response = await _client.PostAsync(uri, content);
            }
            

            if (response.IsSuccessStatusCode)
            {
                string gelen = await response.Content.ReadAsStringAsync();
                if (gelen == "true")
                    Application.Current.MainPage = new Anasayfa();
                else
                {
                    cerceve.IsVisible = false;
                    anim.Pause();
                    await DisplayAlert("UYARI", "Şifre Hatalı", "Tamam");
                }
                
                  
            }
           
}*/


    }
}
