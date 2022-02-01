using System;
using System.Collections.Generic;
using System.Text;

namespace prjFinalProjectPartI
{
    public class clsCollectionOfHouses
    {
        private Dictionary<string, clsHouse> myCollection;

        public Dictionary<string, clsHouse>.ValueCollection Elements
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

        public bool Add()
        {
            throw new System.NotImplementedException();
        }

        public bool Delete()
        {
            throw new System.NotImplementedException();
        }

        public string Display()
        {
            throw new System.NotImplementedException();
        }

        public clsHouse Find()
        {
            throw new System.NotImplementedException();
        }

        public void Edit()
        {
            throw new System.NotImplementedException();
        }
    }
}