using System;
using System.Collections.Generic;
using System.Text;

namespace prjFinalProjectPartI
{
    public class clsRemax
    {
        private clsCollectionOfAdmins vAdmins;
        private clsCollectionOfAgents vAgents;

        public clsRemax()
        {
            vAdmins = new clsCollectionOfAdmins();
            vAgents = new clsCollectionOfAgents();
        }
        public clsRemax(clsCollectionOfAdmins admins)
        {
            this.Admins = admins;
        }
        public clsRemax(clsCollectionOfAgents agents)
        {
            this.Agents = agents;
        }
        public clsRemax(clsCollectionOfAgents agents, clsCollectionOfAdmins admins)
        {
            this.Agents = agents;
            this.Admins = admins;
        }
        public clsCollectionOfAgents Agents
        {
            get => vAgents;
            set
            {
                vAgents = value;
            }
        }

        public clsCollectionOfAdmins Admins
        {
            get => vAdmins;
            set
            {
                vAdmins = value;
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