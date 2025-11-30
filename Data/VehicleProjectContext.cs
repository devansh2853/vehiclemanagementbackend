using Microsoft.EntityFrameworkCore;
using VehicleProject.Models;

namespace VehicleProject.Data;

public class VehicleProjectContext : DbContext
{
    public VehicleProjectContext(DbContextOptions<VehicleProjectContext> options) : base(options) {
        
    }
    public DbSet<Car> Cars {get; set;}

}