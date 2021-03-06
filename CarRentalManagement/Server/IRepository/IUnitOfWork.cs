using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.IRepository
{
    public interface IUnitOfWork: IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Make> Makes { get;}
        IGenericRepository<Model> Models { get; }
        IGenericRepository<Vehicle> Vehicles { get;}
        IGenericRepository<Customer> Customers { get;}
        IGenericRepository<Color> Colors { get;}
        IGenericRepository<Booking> Bookings { get;}

    }
}
