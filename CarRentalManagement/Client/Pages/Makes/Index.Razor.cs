using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Makes
{
    public partial class Index
    {
        private List<Make> Makes;

        protected async override Task OnInitializedAsync()
        {
            Makes = await _client.GetFromJsonAsync<List<Make>>($"{Endpoints.MakesEndpoint}");
        }

        private async Task Delete(int makeid)
        {
            var make = Makes.First(x => x.Id == makeid);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Vil du slette {make.Name}?");
            if (confirm)
            {
                await _client.DeleteAsync($"{Endpoints.MakesEndpoint}/{makeid}");
                await OnInitializedAsync();
            }

        }

    }
}
