using System;
using System.Collections.Generic;
using System.Text;

namespace prjFinalProjectPartI
{
    public class clsAdmin : clsEmployee
    {
        private clsCollectionOfAgents vAgents;

        public clsAdmin() : base ()
        {
            vAgents = new clsCollectionOfAgents();
        }
         public clsAdmin(string empDepartment, string empName, int empNumber, string empPosition, string pin) : base(empDepartment, empName, empNumber, empPosition, pin)
        {
            this.EmpDepartment = empDepartment;
            this.EmpName = empName;
            this.EmpNumber = empNumber;
            this.EmpPosition = empPosition;
            
        }
        public clsAdmin(string empDepartment, string empName, int empNumber, string empPosition, string pin, clsCollectionOfAgents myagents) : base(empDepartment, empName, empNumber, empPosition, pin)
        {
            this.EmpDepartment = empDepartment;
            this.EmpName = empName;
            this.EmpNumber = empNumber;
            this.EmpPosition = empPosition;
            this.vAgents = myagents;
        }

        public clsCollectionOfAgents Agents
        {
            get => vAgents;
            set
            {
                vAgents = value;
            }
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