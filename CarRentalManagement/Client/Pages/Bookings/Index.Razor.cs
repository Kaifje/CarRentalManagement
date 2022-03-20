using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class Index
    {
        private List<Booking> Bookings;

        protected async override Task OnInitializedAsync()
        {
            Bookings = await _client.GetFromJsonAsync<List<Booking>>($"{Endpoints.BookingsEndpoint}");
        }

        async Task Delete(int bookingsId)
        {
            var booking = Bookings.First(q => q.Id == bookingsId);
            var name = $"{booking.Customer.FirstName} {booking.Customer.LastName}";

            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {name}?");
            if (confirm)
            {
                await _client.DeleteAsync($"{Endpoints.BookingsEndpoint}/{bookingsId}");
                await OnInitializedAsync();
            }

        }

    }
}
