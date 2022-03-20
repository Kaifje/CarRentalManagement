using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class Create
    {
        Model model = new Model();

        private async Task CreateModel()
        {
            await _client.PostAsJsonAsync(Endpoints.ModelsEndpoint, model);
            _navManager.NavigateTo("/models/");
        }

    }
}
