﻿using System;

namespace EmployeApp
{
    public class Class2
    {
        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        public Class2(string employeeID, string firstName, string lastName, string position)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
        }
    }
}
