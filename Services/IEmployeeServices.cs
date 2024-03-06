using Apiemployee.Models;

namespace Apiemployee.Services
{
    public interface IEmployeeServices
    {
        List<Employee> Get();

        Employee Get(string id);

        Employee Create(Employee employee);

        void Update(string id, Employee employee);

        void Remove(string id);
    }
}
