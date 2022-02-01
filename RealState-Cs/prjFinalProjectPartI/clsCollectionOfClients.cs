using System;
using System.Collections.Generic;
using System.Text;

namespace prjFinalProjectPartI
{
    public class clsCollectionOfClients
    {
        private Dictionary<string, clsClient> myCollection;

        public Dictionary<string, clsClient>.ValueCollection Elements
        {
            get => myCollection.Values;
            //set
            //{
            //}
        }

        public int NumberOf
        {
            get => myCollection.Count;
            //set
            //{
            //}
        }

        public string Display()
        {
            throw new System.NotImplementedException();
        }

        public bool Add()
        {
            throw new System.NotImplementedException();
        }

        public bool Delete()
        {
            throw new System.NotImplementedException();
        }

        public void Edit()
        {
            throw new System.NotImplementedException();
        }

        public clsClient Find()
        {
            throw new System.NotImplementedException();
        }
    }
}