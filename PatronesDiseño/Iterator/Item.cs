﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class Item

    {
        private string _name;

        // Constructor

        public Item(string name)
        {
            this._name = name;
        }

        // Gets name

        public string Name
        {
            get { return _name; }
        }
    }

    /// <summary>

    /// The 'Aggregate' interface

    /// </summary>

    interface IAbstractCollection

    {
        Iterator CreateIterator();
    }
}
