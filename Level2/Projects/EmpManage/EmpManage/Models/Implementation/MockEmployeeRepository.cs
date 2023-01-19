using EmpManage.Models.Interfaces;

namespace EmpManage.Models.Implementation
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        // create employees list
        private List<Employee> _employees;

        // constructor
        public MockEmployeeRepository()
        {
            _employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name = "Bahaa",
                    Email = "baha@gmail.com",
                    Department = "IT",
                },
                new Employee()
                {
                    Id = 2,
                    Name = "Ali",
                    Email = "ali@gmail.com",
                    Department = "Accounting",
                },
                new Employee()
                {
                    Id = 3,
                    Name = "Ahmad",
                    Email = "ahmad@gmail.com",
                    Department = "IT",
                },
                new Employee()
                {
                    Id = 4,
                    Name = "Sahal",
                    Email = "sahal@gmail.com",
                    Department = "IT",
                },
                new Employee()
                {
                    Id = 5,
                    Name = "Malek",
                    Email = "malek@gmail.com",
                    Department = "IT",
                }

            };
        }

        public Employee GetEmployee(int id)
        {
            // using LINQ to retrieve data 
            return _employees.FirstOrDefault(e => e.Id == id); //
        }
    }
}
