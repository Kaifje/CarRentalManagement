using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class View
    {
        [Parameter] public int id { get; set; }
        Booking booking = new Booking();

        protected async override Task OnParametersSetAsync()
        {
            booking = await _client.GetFromJsonAsync<Booking>($"{Endpoints.BookingsEndpoint}/{id}");
        }

    }
}
