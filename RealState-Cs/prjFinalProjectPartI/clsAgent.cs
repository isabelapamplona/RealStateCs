using System;
using System.Collections.Generic;
using System.Text;

namespace prjFinalProjectPartI
{
    public class clsAgent : clsEmployee
    {
        public clsAgent() : base ()
        {

        }

        public clsAgent (string empDepartment, string empName, int empNumber, string empPosition, string pin) : base (empDepartment, empName,empNumber, empPosition, pin)
        {
            this.EmpDepartment = empDepartment;
            this.EmpName = empName;
            this.EmpNumber = empNumber;
            this.EmpPosition = empPosition;
            this.Pin = pin;
        }
        public string Display()
        {
            throw new System.NotImplementedException();
        }

        public void Register()
        {
            throw new System.NotImplementedException();
        }
    }
}