using System;
using System.Collections.Generic;
using System.Text;

namespace prjFinalProjectPartI
{
    public class clsClient
    {
        private string vClientName;
        private int vClientNumber;
        private string vClientType;
        private clsCollectionOfHouses vHouses;
        private string vPin;
        private int vRefAgent;

        public clsClient()
        {
            vClientName = "";
            vClientNumber= 000;
            vClientType= "";
            vHouses = new clsCollectionOfHouses();
            vPin = "";
            vRefAgent = 000;
        }
        public clsClient(string clientName, int clientNumber, string clientType, string pin, int refAgent)
        {
            this.ClientName = clientName;
            this.ClientNumber = clientNumber;
            this.ClientType = clientType;
            this.Pin = pin;
            this.RefAgent = refAgent;
        }
        public clsClient(string clientName, int clientNumber, string clientType, string pin, int refAgent, clsCollectionOfHouses myHouses)
        {
            this.ClientName = clientName;
            this.ClientNumber = clientNumber;
            this.ClientType = clientType;
            this.Pin = pin;
            this.Houses = myHouses;
            this.RefAgent = refAgent;
        }
        public clsCollectionOfHouses Houses
        {
            get => vHouses;
            set
            {
                vHouses = value;
            }
        }

        public string ClientName
        {
            get => vClientName;
            set
            {
                vClientName = value;
            }
        }

        public int ClientNumber
        {
            get => vClientNumber;
            set
            {
                vClientNumber = value;
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

        public string ClientType
        {
            get => vClientType;
            set
            {
                vClientType = value;
            }
        }

        public int RefAgent
        {
            get => vRefAgent;
            set
            {
                vRefAgent = value;
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