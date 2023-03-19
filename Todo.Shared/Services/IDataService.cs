using System;

namespace Todo.Shared.Services
{
    public interface IDataService
    {
        Task<List<string>> GetData();
    }
}
