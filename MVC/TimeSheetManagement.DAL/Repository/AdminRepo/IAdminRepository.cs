using System;
using System.Collections.Generic;
using System.Text;
using TimeSheetManagement.Entity.Models;

namespace TimeSheetManagement.DAL.Repository.AdminRepo
{
    public interface IAdminRepository
    {
        #region Employee

        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int EmpID);
        Employee GetEmployeeByID(int EmpID);
        IEnumerable<Employee> GetEmployees();
        #endregion

       // #region Manager
        //void AddManager(Manager manager);
       // void UpdateManager(Manager manager);
        //void DeleteManager();
       // Manager GetManagerByID(int MgrID);
       // IEnumerable<Manager> GetManagers();
       // #endregion

    }
}
