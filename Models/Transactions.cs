using System.IO;
using System.Text.Json;
using System.Collections.Generic;


public class Transactions
{
    public List<PersonBase> GetEmployeesFromDb()
    {
        List<PersonBase> data = new List<PersonBase>();

        // here we are getting data from file....
        // but this could be any sql server database
        using (StreamReader r = new StreamReader("./Models/EmployeeDb.json")) //"./Models/EmployeeDb.json"
        {
            string json = r.ReadToEnd();
            data = JsonSerializer.Deserialize<List<PersonBase>>(json);
        }

        return data;
    }
}
