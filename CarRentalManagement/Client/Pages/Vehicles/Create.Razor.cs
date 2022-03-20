using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Create
    {
        Vehicle vehicle = new Vehicle();
        private IList<Make> Makes;
        private IList<Model> Models;
        private IList<Color> Colors;

        protected async override Task OnInitializedAsync()
        {
            Makes = await _client.GetFromJsonAsync<List<Make>>($"{Endpoints.MakesEndpoint}");
            Models = await _client.GetFromJsonAsync<List<Model>>($"{Endpoints.ModelsEndpoint}");
            Colors = await _client.GetFromJsonAsync<List<Color>>($"{Endpoints.ColorsEndpoint}");
        }


        private async Task CreateVechicle()
        {
            await _client.PostAsJsonAsync(Endpoints.VehiclesEndpoint, vehicle);
            _navManager.NavigateTo("/vehicles/");
        }

    }
}
