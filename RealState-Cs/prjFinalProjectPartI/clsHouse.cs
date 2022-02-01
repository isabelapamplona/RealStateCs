using System;
using System.Collections.Generic;
using System.Text;

namespace prjFinalProjectPartI
{
    public class clsHouse
    {
        private string vAddress;
        private DateTime vDateOfAd;
        private float vPrice;
        private int vRefHouse;
        private string vStatus;

        public clsHouse()
        {
            vAddress = "";
            vDateOfAd = DateTime.Now;
            vPrice = 000;
            vRefHouse = 000;
            vStatus = "";
        }
        public clsHouse(string address, DateTime dateOfAd, float price, int refHouse, string status)
        {
            this.Address = address;
            vDateOfAd = dateOfAd;
            this.Price = price;
            this.RefHouse = refHouse;
            this.Status = status;
        }

        public clsHouse(string address, int Day, int Month, int Year, float price, int refHouse, string status)
        {
            
            this.Address = address;
            vDateOfAd = new DateTime(Day, Month, Year);
            this.Price = price;
            this.RefHouse = refHouse;
            this.Status = status;
        }

        public string Address
        {
            get => vAddress;
            set
            {
                vAddress = value;
            }
        }

        public int RefHouse
        {
            get => vRefHouse;
            set
            {
                vRefHouse = value;
            }
        }

        public float Price
        {
            get => vPrice;
            set
            {
                vPrice = value;
            }
        }

        public DateTime DateOfAd
        {
            get => vDateOfAd;
            //set
            //{
            //    vDateOfAd = value;
            //}
        }

        public string Status
        {
            get => vStatus;
            set
            {
                vStatus = value;
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