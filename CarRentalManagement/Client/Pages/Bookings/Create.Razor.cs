using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class Create
    {
        Booking booking = new Booking
        {
            DateOut = DateTime.Now.Date
        };


        private async Task CreateBooking()
        {
            await _client.PostAsJsonAsync(Endpoints.BookingsEndpoint, booking);
            _navManager.NavigateTo("/bookings/");
        }

    }
}
