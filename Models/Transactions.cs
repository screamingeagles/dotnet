using System;
using System.IO;
using System.Linq;
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

    public PersonBase GetEmployeeFromDb(string EmployeeID)
    {
        string[] ids = EmployeeID.Split('-');
        if (ids.Length > 1)
        {
            int id = Convert.ToInt32(ids[1]);
            List<PersonBase> data = GetEmployeesFromDb();
            PersonBase result = data.Where( x => x.ID == id).FirstOrDefault();
            return result;
        }
        else{
            return null;
        }        
    }


    public void UpdateEmployeeToDb(EmployeeDetails data)
    {
        int id =0;
        string[] ids = data.EmployeeID.Split('-');
            
        if (ids.Length > 1) { id = Convert.ToInt32(ids[1]); }
        
        List<PersonBase> hold = GetEmployeesFromDb();
        foreach (PersonBase p in hold)
        {
            if (p.ID == id)
            {
                p.ID = id;
                p.Name = data.EmployeeName;
                p.Designation = data.EmployeeDesignation;
                p.Department = data.EmployeeDepartment;
            }
        }

        string json = JsonSerializer.Serialize(hold);
        File.WriteAllText("./Models/EmployeeDb.json",json);
    }
}
