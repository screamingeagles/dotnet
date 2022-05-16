public class WorkerFactory
{
    public IWorker GetEmployee(string EmployeeType)
    {

        if (EmployeeType.Equals("Permanent"))
        {
            return new PermanentEmployee();
        }
        else if (EmployeeType.Equals("Temporary"))
        {
            return new TemporaryEmployee();
        }
        else
        {
            return new ContractEmployee();
        }

    }
}
