using CarRentalManagement.Shared.Domain;
using System;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.IRepository
{
    public interface IUnitOfWork: IDisposable
    {
        Task Save();

        IGenericRepository<Make> MakesRepo { get;}
        //IGenericRepository<Model> ModelRepo { get; }
        //IGenericRepository<Vehicle> VehicleRepo { get;}
        //IGenericRepository<Customer> CustomerRepo { get;}
        //IGenericRepository<Colour> ColourRepo { get;}
        //IGenericRepository<Booking> BookingRepo { get;}

    }
}
