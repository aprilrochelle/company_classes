using System;
using System.Collections.Generic;

namespace Business
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create an instance of a company. Name it whatever you like.
      Company GraffitiNailBar = new Company("Graffiti Nail Bar", new DateTime(2011, 6, 1));

      // Create three employees
      Employee LaurenBoyd = new Employee() {
        FirstName = "Lauren",
        LastName = "Boyd",
        Title = "Owner",
        StartDate = new DateTime(2011, 6, 1)
      };

      Employee ErinMcGluen = new Employee() {
        FirstName = "Erin",
        LastName = "McGluen",
        Title = "Nail Technician",
        StartDate = new DateTime(2016, 5, 15)
      };

      Employee KimeliWade = new Employee() {
        FirstName = "Kimeli",
        LastName = "Wade",
        Title = "Soap Maker",
        StartDate = new DateTime(2017, 3, 13)
      };
      // Assign the employees to the company
      GraffitiNailBar.EmployeeList.Add(LaurenBoyd);
      GraffitiNailBar.EmployeeList.Add(ErinMcGluen);
      GraffitiNailBar.EmployeeList.Add(KimeliWade);
      /*
          Iterate the company's employee list and generate the
          simple report shown above
      */

      GraffitiNailBar.ListEmployees();
    }
  }
}


