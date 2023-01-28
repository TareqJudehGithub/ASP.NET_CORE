namespace EmpManage.Models.Interfaces
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);

        // IEnumerable
        IEnumerable<Employee> GetAllEmployees();
    }
}
