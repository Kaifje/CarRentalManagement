using CarRentalManagement.Client.Static;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class Index
    {
        private List<CarRentalManagement.Shared.Domain.Color> Colors;

        protected async override Task OnInitializedAsync()
        {
            Colors = await _client.GetFromJsonAsync<List<CarRentalManagement.Shared.Domain.Color>>($"{Endpoints.ColorsEndpoint}");
        }

        private async Task Delete(int colorid)
        {
            var color = Colors.First(x => x.Id == colorid);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Vil du slette {color.Name}?");
            if (confirm)
            {
                await _client.DeleteAsync($"{Endpoints.ColorsEndpoint}/{colorid}");
                await OnInitializedAsync();
            }
        }

    }
}
