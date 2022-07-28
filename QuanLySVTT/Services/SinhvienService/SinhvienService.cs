using Microsoft.AspNetCore.Components;
using QuanLySVTT.Models;
using QuanLySVTT.Data;
namespace QuanLySVTT.Services.SinhvienService
{
    public class SinhvienService : ISinhvienService
    {
        public readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;
        public List<Sinhvien> Sinhvienservices { get; set; } = new List<Sinhvien>();
        public SinhvienService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
            _http.BaseAddress = new Uri(_navigationManager.BaseUri);
        }
        public async Task GetSinhvienDetail()
        {
            var resutl = await _http.GetFromJsonAsync<List<Sinhvien>>("api/sinhvien");
            if (resutl != null)
            {
                Sinhvienservices = resutl;
            }
        }
        private async Task SetSinhvien(HttpResponseMessage result)
        {
            Console.WriteLine(result.StatusCode);
            _navigationManager.NavigateTo("vidoweb");
        }
    }
}
