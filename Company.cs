using System;
using System.Collections.Generic;
using System.Globalization;

namespace Business
{
  public class Company
  {

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; }
    public DateTime CreatedOn { get; }

    // Create a public property for holding a list of current employees
    public List<Employee> EmployeeList = new List<Employee>();

    public void ListEmployees()
    {
      foreach (Employee item in EmployeeList)
      {
        Console.WriteLine($"{item.FirstName} has been employed with {Name} as {item.Title} since {item.StartDate.ToString("d", CultureInfo.CreateSpecificCulture("en-US"))}.");
      }
    }
    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
    public Company(string name, DateTime date)
    {
        this.Name = name;
        this.CreatedOn = date;
    }

  }
}

