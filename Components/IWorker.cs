using System;

public interface IWorker
{
    EmployeeDetails GetEmployeeDetails(PersonBase p);
}


public class PermanentEmployee : IWorker
{
    public EmployeeDetails GetEmployeeDetails(PersonBase p)
    {

        PermanentEmployeeWage pew = new PermanentEmployeeWage();
        int days = pew.getWorkingDays();
        float amount = pew.CalculatePayableAmount(days);

        EmployeeDetails prm = new EmployeeDetails()
        {
            EmployeeID = "EMP-" + p.ID.ToString(),
            EmployeeName = p.Name,
            EmployeeDesignation = p.Designation,
            EmployeeDepartment = p.Department,
            IssueDate = p.StartDate,
            ExpiryDate = Convert.ToDateTime(p.StartDate).AddYears(2).ToString("dd-MMM-yyyy")
        };
        return prm;
    }
}


public class TemporaryEmployee : IWorker
{
    public EmployeeDetails GetEmployeeDetails(PersonBase p)
    {
        TemporaryEmployeeWage tew = new TemporaryEmployeeWage();
        int days = tew.getWorkingDays();
        float amount = tew.CalculatePayableAmount(days);

        EmployeeDetails tmp = new EmployeeDetails()
        {
            EmployeeID = "TMP-" + p.ID.ToString(),
            EmployeeName = p.Name,
            EmployeeDesignation = p.Designation,
            EmployeeDepartment = p.Department,
            IssueDate = p.StartDate,
            ExpiryDate = Convert.ToDateTime(p.StartDate).AddYears(1).ToString("dd-MMM-yyyy")
        };
        return tmp;
    }

}



public class ContractEmployee : IWorker
{
    public EmployeeDetails GetEmployeeDetails(PersonBase p)
    {
        ContractualEmployeeWage cew = new ContractualEmployeeWage();
        float amount = cew.CalculatePayableAmount(0);

        EmployeeDetails tmp = new EmployeeDetails()
        {
            EmployeeID = "CTR-" + p.ID.ToString(),
            EmployeeName = p.Name,
            EmployeeDesignation = p.Designation,
            EmployeeDepartment = "PROJECT NAME: ABC",
            IssueDate = p.StartDate,
            ExpiryDate = Convert.ToDateTime(p.StartDate).AddMonths(3).ToString("dd-MMM-yyyy")
        };
        return tmp;
    }

}

