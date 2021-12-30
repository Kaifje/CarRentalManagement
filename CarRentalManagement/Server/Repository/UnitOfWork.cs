using CarRentalManagement.Server.Data;
using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Server.Models;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Make> _makes;
        private IGenericRepository<Model> _models;
        private IGenericRepository<Color> _Colors;
        private IGenericRepository<Booking> _bookings;
        private IGenericRepository<Customer> _customers;
        private IGenericRepository<Vehicle> _vehicles;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        // private readonly DbSet<T> _dbSet;

        public IGenericRepository<Make> Makes => _makes ??= new GenericRepository<Make>(_context);
        public IGenericRepository<Model> Models => _models ??= new GenericRepository<Model>(_context);
        public IGenericRepository<Color> Colors => _Colors ??= new GenericRepository<Color>(_context);
        public IGenericRepository<Vehicle> Vehicles => _vehicles ??= new GenericRepository<Vehicle>(_context);
        public IGenericRepository<Booking> Bookings => _bookings ??= new GenericRepository<Booking>(_context);
        public IGenericRepository<Customer> Customers => _customers ??= new GenericRepository<Customer>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }


        public async Task Save(HttpContext httpContext)
        {
            // var user = httpContext.User.Identity.Name;
            var userId = httpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await _userManager.FindByIdAsync(userId);


            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified || q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                string name = $"{user.FirstName} {user.LastName}";

                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = name;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = name;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
