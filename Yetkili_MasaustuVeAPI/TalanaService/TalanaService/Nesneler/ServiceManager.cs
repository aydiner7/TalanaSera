using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TalanaService.Models;

namespace TalanaService.Nesneler
{
    class ServiceManager
    {
        private string url = "http://localhost:44444/api/";
        private async Task<HttpClient> GetClient()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            return httpClient;
        }

      /*  public async Task<Kullanici> KullaniciEkle(Kullanici kullanici)
        {

        }*/
    }
}
