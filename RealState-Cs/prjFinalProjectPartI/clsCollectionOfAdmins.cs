using System;
using System.Collections.Generic;
using System.Text;

namespace prjFinalProjectPartI
{
    public class clsCollectionOfAdmins
    {
        private Dictionary<string, clsAdmin> myCollection;

        public Dictionary<string, clsAdmin>.ValueCollection Elements
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

        public clsAdmin Find()
        {
            throw new System.NotImplementedException();
        }

        public void Edit()
        {
            throw new System.NotImplementedException();
        }
    }

    
}