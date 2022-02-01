using System;
using System.Collections.Generic;
using System.Text;

namespace prjFinalProjectPartI
{
    public class clsCollectionOfAgents
    {
        private Dictionary<string, clsAgent> myCollection;

        public int NumberOf
        {
            get => myCollection.Count;
            //set
            //{
            //}
        }

        public Dictionary<string, clsAgent>.ValueCollection Elements
        {
            get => myCollection.Values;
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

        public void Edit()
        {
            throw new System.NotImplementedException();
        }

        public clsAgent Find()
        {
            throw new System.NotImplementedException();
        }
    }
}