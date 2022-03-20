using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Makes
{
    public partial class Create
    {
        Make make = new Make();

        private async Task CreateMake()
        {
            await _client.PostAsJsonAsync(Endpoints.MakesEndpoint, make);
            _navManager.NavigateTo("/makes/");
        }

    }
}
