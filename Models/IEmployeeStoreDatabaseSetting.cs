namespace Apiemployee.Models
{
    public interface IEmployeeStoreDatabaseSetting
    {
        public string EmployeeDetailCollectionName { get; set; }

        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
    }
}
