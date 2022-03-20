using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Index
    {
        private List<Customer> Customers;

        protected async override Task OnInitializedAsync()
        {
            Customers = await _client.GetFromJsonAsync<List<Customer>>($"{Endpoints.CustomersEndpoint}");
        }

        private async Task Delete(int Customerid)
        {
            var Customer = Customers.First(x => x.Id == Customerid);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Vil du slette {Customer.ContactNumber}?");
            if (confirm)
            {
                await _client.DeleteAsync($"{Endpoints.CustomersEndpoint}/{Customerid}");
                await OnInitializedAsync();
            }

        }
    }
}
