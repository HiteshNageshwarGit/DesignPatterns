using DesignPatterns.Employee_Manager;

namespace DesignPatterns.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int employeeTypeID)
        {
            IEmployeeManager employeeManager = null;
            if (employeeTypeID == 1)
            {
                employeeManager = new PermanentEmployeeManager();
            }
            else if (employeeTypeID == 2)
            {
                employeeManager = new ContractEmployeeManager();
            }
            return employeeManager;
        }
    }
}