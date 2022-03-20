using CarRentalManagement.Client.Static;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class Create
    {
        CarRentalManagement.Shared.Domain.Color color = new CarRentalManagement.Shared.Domain.Color();

        private async Task CreateColor()
        {
            await _client.PostAsJsonAsync(Endpoints.ColorsEndpoint, color);
            _navManager.NavigateTo("/colors/");
        }

    }
}
