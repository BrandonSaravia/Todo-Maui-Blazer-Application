using System;

namespace Todo.Shared.Services
{
    public class DataService : IDataService
    {
        public DataService() 
        {
            
        }

        public Task<List<string>> GetData()
        {
            return Task.FromResult(new List<string>()
            {
                "Clean Room",
                "Eat Cat",
                "Burn Golf Culbs",
                "Defeat Batman"
            });
        }
    }
}
