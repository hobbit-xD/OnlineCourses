using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> getAllCommands()
        {
            var commands = new List<Command>{
                new Command{Id=0,HowTo="Ciao",Line="ciao2",Platform="Linux"},
                new Command{Id=1,HowTo="Ciao",Line="ciao2",Platform="Linux"},
                new Command{Id=2,HowTo="Ciao",Line="ciao2",Platform="Linux"},
            };

            return commands;
        }

        public Command getCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Ciao", Line = "ciao2", Platform = "Linux" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }

}