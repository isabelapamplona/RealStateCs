using System;
using System.Collections.Generic;
using System.Text;

namespace prjFinalProjectPartI
{
    public abstract class clsEmployee
    {
        private string vEmpDepartment;
        private string vEmpName;
        private int vEmpNumber;
        private string vEmpPosition;
        private string vPin;
        private clsCollectionOfClients vClients;
        private clsCollectionOfHouses vHouses;

        public clsEmployee ()
            {
            vEmpDepartment = "";
            vEmpName = "";
            vEmpNumber = 000;
            vEmpPosition = "";
            vPin = "";
            vClients = new clsCollectionOfClients();
            vHouses = new clsCollectionOfHouses();
            }

        public clsEmployee(string empDepartment, string empName, int empNumber, string empPosition, string pin)
        {
            this.EmpDepartment = empDepartment;
            this.EmpName = empName;
            this.EmpNumber = empNumber;
            this.EmpPosition = empPosition;
            this.Pin = pin;
        }

        public clsEmployee(string empDepartment, string empName, int empNumber, string empPosition, string pin, clsCollectionOfClients myClients, clsCollectionOfHouses myHouses)
        {
            this.EmpDepartment = empDepartment;
            this.EmpName = empName;
            this.EmpNumber = empNumber;
            this.EmpPosition = empPosition;
            this.Pin = pin;
            this.Clients = myClients;
            this.Houses = myHouses;
        }
        public clsCollectionOfClients Clients
        {
            get => vClients;
            set
            {
                vClients = value;
            }
        }

        public string EmpDepartment
        {
            get => vEmpDepartment;
            set
            {
                vEmpDepartment = value;
            }
        }

        public string EmpName
        {
            get => vEmpName;
            set
            {
                vEmpName = value;
            }
        }

        public string EmpPosition
        {
            get => vEmpPosition;
            set
            {
                vEmpPosition = value;
            }
        }

        public clsCollectionOfHouses Houses
        {
            get => vHouses;
            set
            {
                vHouses = value;
            }
        }

        public int EmpNumber
        {
            get => vEmpNumber;
            set
            {
                vEmpNumber = value;
            }
        }

        public string Pin
        {
            get => vPin;
            set
            {
                 vPin = value;
            }
        }
    }
}