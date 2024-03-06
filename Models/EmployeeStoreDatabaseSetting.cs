namespace Apiemployee.Models
{
    public class EmployeeStoreDatabaseSetting :IEmployeeStoreDatabaseSetting
    {
        public string EmployeeDetailCollectionName { get; set; }

        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
    }
}
