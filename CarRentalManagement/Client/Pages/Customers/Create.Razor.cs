using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Create
    {
        Customer customer = new Customer();

        private async Task CreateCustomer()
        {
            await _client.PostAsJsonAsync(Endpoints.CustomersEndpoint, customer);
            _navManager.NavigateTo("/customers/");
        }

    }
}
