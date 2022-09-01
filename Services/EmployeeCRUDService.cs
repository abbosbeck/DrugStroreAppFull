using DataAccess;
using DataAccess.Entities;
using DrugStroreAppFull.Models;

namespace DrugStroreAppFull.Services
{
    public class EmployeeCRUDService : IGenericCRUDService<EmployeeModel>
    {
        private readonly IGenericRepository<Employee> _employeeRepository;
        public EmployeeCRUDService(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<EmployeeModel> Create(EmployeeModel model)
        {
            var employee = new Employee
            {
                Id = model.Id,
                Name = model.Name,
                Email = model.Email,
                Experinece = model.Experinece,
                Region = model.Region,
                Sex = model.Sex
            };
            var createdEmployee = await _employeeRepository.Create(employee);
            var result = new EmployeeModel
            {
                Id = employee.Id,
                Name = employee.Name,
                Email = employee.Email,
                Experinece = employee.Experinece,
                Region = employee.Region,
                Sex = employee.Sex
            };
            return result;
        }

        public async Task<bool> Delete(int id)
        {
            return await _employeeRepository.Delete(id);
        }

        public async Task<IEnumerable<EmployeeModel>> GetAll()
        {
            var employees =await  _employeeRepository.GetAll();
            var result = new List<EmployeeModel>();
            foreach (var employee in employees)
            {
                var model = new EmployeeModel
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Email = employee.Email,
                    Experinece = employee.Experinece,
                    Region = employee.Region,
                    Sex = employee.Sex
                };
                result.Add(model);
            }
            return result;
        }

        public async Task<EmployeeModel> GetById(int id)
        {
            var employee =  await _employeeRepository.GetById(id);
            var result = new EmployeeModel
            {
                Id = employee.Id,
                Name = employee.Name,
                Email = employee.Email,
                Experinece = employee.Experinece,
                Region = employee.Region,
                Sex = employee.Sex
            };
            return result;
        }

        public async Task<EmployeeModel> Update(int id, EmployeeModel model)
        {
            var employee = new Employee
            {
                Id = model.Id,
                Name = model.Name,
                Email = model.Email,
                Experinece = model.Experinece,
                Region = model.Region,
                Sex = model.Sex
            };
            var updatedEmployee = await _employeeRepository.Update(id, employee);
            var result = new EmployeeModel
            {
                Id = updatedEmployee.Id,
                Name = updatedEmployee.Name,
                Email = updatedEmployee.Email,
                Experinece = updatedEmployee.Experinece,
                Region = updatedEmployee.Region,
                Sex = updatedEmployee.Sex
            };
            return result;

        }
    }
}
