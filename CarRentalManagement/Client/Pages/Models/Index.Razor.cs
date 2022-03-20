using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class Index
    {
        private List<Model> Models;

        protected async override Task OnInitializedAsync()
        {
            Models = await _client.GetFromJsonAsync<List<Model>>($"{Endpoints.ModelsEndpoint}");
        }

        private async Task Delete(int id)
        {
            var model = Models.First(x => x.Id == id);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Vil du slette {model.Name}?");
            if (confirm)
            {
                await _client.DeleteAsync($"{Endpoints.ModelsEndpoint}/{id}");
                await OnInitializedAsync();
            }

        }

    }
}
