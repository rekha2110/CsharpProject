using System;
using System.Collections.Generic;
using System.Text;
using TimeSheetManagement.DAL.Repository.AdminRepo;
using TimeSheetManagement.Entity.Models;

namespace TimeSheetManagement.BAL.Services
{
    public class AdminServices
    {
        IAdminRepository _adminRepository;
        public AdminServices(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;

        }
        public void AddEmployee(Employee employee)
        {
            _adminRepository.AddEmployee(employee);
        }
        public void UpdateEmployee(Employee employee)
        {
            _adminRepository.UpdateEmployee(employee);
        }
        public void DeleteEmployee(int EmpID)
        {
            _adminRepository.DeleteEmployee(EmpID);
        }
        public Employee GetEmployeeByID(int EmpID)
        {
            return _adminRepository.GetEmployeeByID(EmpID);

        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _adminRepository.GetEmployees();
        }

    }
}
