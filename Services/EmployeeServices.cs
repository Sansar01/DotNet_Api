using Apiemployee.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace Apiemployee.Services
{
    public class EmployeeServices:IEmployeeServices
    {
        private readonly IMongoCollection<Employee> _employee;
        public EmployeeServices(IEmployeeStoreDatabaseSetting setting, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(setting.DatabaseName);
            _employee = database.GetCollection<Employee>(setting.EmployeeDetailCollectionName);

        }
        public Employee Create(Employee employee)
        {
            _employee.InsertOne(employee);
            return employee;
        }

        public List<Employee> Get()
        {
            return _employee.Find(employee => true).ToList();
        }

        public Employee Get(string id)
        {
            return _employee.Find(employee => employee.empId == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _employee.DeleteOne(employee => employee.empId == id);
        }

        public void Update(string id, Employee employee)
        {
            _employee.ReplaceOne(employee => employee.empId == id, employee);
        }
    }
}
