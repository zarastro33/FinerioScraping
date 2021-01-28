using Entidades;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace NetScrapingNapstar
{
    class Program
    {
        static HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            llenarGenero();
        }
        static async void CreateGeneroAsync(Genero genero)
        {

                HttpResponseMessage response = await client.PostAsJsonAsync(
             "api/Genero", genero);
                response.EnsureSuccessStatusCode();

        }
        static async Task<List<Genero>> GetGeneroAsync(string path)
        {
            List<Genero> genero = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                genero = await response.Content.ReadAsAsync<List<Genero>>();
            }
            return genero;
        }
        static async Task RunAsync(Genero genero)
        {
            // Update port # in the following line.
            List<Genero> generow = null;
            client.BaseAddress = new Uri("https://localhost:44379/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {

                generow = await GetGeneroAsync("https://localhost:44379/api/Genero");
                CreateGeneroAsync(genero);


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        static void llenarGenero()
        {
            IWebDriver driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            driver.Navigate().GoToUrl("https://us.napster.com/music");
            var inputSearch = driver.FindElements(By.XPath("//div[@class='column genre-item']"));
            Genero genero = new Genero();
            genero.subgeneros = new List<Subgenero>();
            foreach (var item in inputSearch)
            {
                genero.NombreGenero = item.Text;
                
                RunAsync(genero).GetAwaiter().GetResult();

                Console.WriteLine(item.Text);
                var s = item.FindElement(By.TagName("a"));
                llenarSubgenero(s.GetAttribute("href"));
            }
        }

        static void llenarSubgenero(string Url)
        {
            IWebDriver driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            driver.Navigate().GoToUrl(Url);
            var inputSearch = driver.FindElements(By.XPath("//li[@class='genre-item']"));
            foreach (var item in inputSearch)
            {
                string otro = item.Text;
                var s = item.FindElement(By.TagName("a"));
                llenarArtista(s.GetAttribute("href"));
            }
        }

        static void llenarArtista(string Url)
        {
            IWebDriver driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            driver.Navigate().GoToUrl(Url);
            var inputSearch = driver.FindElements(By.XPath("//div[@class='column artist-item']"));

            foreach (var item in inputSearch)
            {
                string ss = item.Text;
                var s = item.FindElement(By.TagName("a"));
                string urls = s.GetAttribute("href");
            }
        }

        static void llenarAlbum()
        {

        }

        static void llenarCancion()
        {

        }
    }
}
