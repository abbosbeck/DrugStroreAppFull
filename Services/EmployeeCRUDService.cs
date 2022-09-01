using DataAccess;
using DrugStroreAppFull.Models;

namespace DrugStroreAppFull.Services
{
    public class EmployeeCRUDService : IGenericCRUDService<EmployeeModel>
    {
        private readonly EmployeeRepository _employeeRepository;
        public EmployeeCRUDService(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Task<EmployeeModel> Create(EmployeeModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeModel> Update(int id, EmployeeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
