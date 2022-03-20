using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Index
    {
        private List<Vehicle> Vehicles;

        protected async override Task OnInitializedAsync()
        {
            Vehicles = await _client.GetFromJsonAsync<List<Vehicle>>($"{Endpoints.VehiclesEndpoint}");
        }

        private async Task Delete(int id)
        {
            var vehicle = Vehicles.First(x => x.Id == id);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Vil du slette {vehicle.Model.Name}?");
            if (confirm)
            {
                await _client.DeleteAsync($"{Endpoints.VehiclesEndpoint}/{id}");
                await OnInitializedAsync();
            }

        }

    }
}
