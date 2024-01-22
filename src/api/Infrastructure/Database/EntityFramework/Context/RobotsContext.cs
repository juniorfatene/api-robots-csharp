using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Infrastructure.Database.EntityFramework.Context
{
    public class RobotsContext: DbContext
    {
        public RobotsContext(DbContextOptions<RobotsContext> options):base(options){

        }

        public DbSet<Robot> Robots { get; set; }

    }
}