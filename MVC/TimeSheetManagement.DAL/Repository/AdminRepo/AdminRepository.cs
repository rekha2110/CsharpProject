using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeSheetManagement.DAL.Data;
using TimeSheetManagement.Entity.Models;

namespace TimeSheetManagement.DAL.Repository.AdminRepo
{
    public class AdminRepository : IAdminRepository
    {
        TimeSheetDbContext _timeSheetDbContext;
        public AdminRepository(TimeSheetDbContext timeSheetDbContext)
        {
            _timeSheetDbContext = timeSheetDbContext;
        }

        public object[] EmpId { get; private set; }

        public void AddEmployee(Employee employee)
        {
            _timeSheetDbContext.employee.Add(employee);
            _timeSheetDbContext.SaveChanges();
        }

        public void DeleteEmployee(int EmpID)
        {
            var employee = _timeSheetDbContext.employee.Find(EmpId);
            _timeSheetDbContext.employee.Remove(employee);
            _timeSheetDbContext.SaveChanges();

        }

        public Employee GetEmployeeByID(int EmpID)
        {
            return _timeSheetDbContext.employee.Find(EmpId);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _timeSheetDbContext.employee.ToList();
        }

        public void UpdateEmployee(Employee employee)
        {
            _timeSheetDbContext.Entry(employee).State = EntityState.Modified;
            _timeSheetDbContext.SaveChanges();
        }
    }
}
