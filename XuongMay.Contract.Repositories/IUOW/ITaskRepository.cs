using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XuongMay.Contract.Repositories.Entity;
using XuongMay.Contract.Repositories.Interface;

namespace XuongMay.Contract.Repositories.IUOW
{
    public interface ITaskRepository : IGenericRepository<Task>
    {
        Task<IEnumerable<Task>> GetAllCategoriesAsync();
        public Task<Task> GetTaskByIdAsync(int id);
        public Task<Task> CreateTaskAsync(Task model);
        Task<Task> UpdateTaskAsync(Task model);
        Task<Task> DeleteTaskAsync(int id);
    }
}
