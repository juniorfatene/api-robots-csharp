using System.Collections.Generic;
using Api.Domain.Entities;


namespace Api.Infrastructure.Database.Repositories.Robots
{
    public interface IRobotRepository
    {
        bool SaveChanges();

        IEnumerable<Robot> GetAllRobots();
        
        Robot GetRobotById(int id);

        void AddRobot(Robot robot);
        
    }
}