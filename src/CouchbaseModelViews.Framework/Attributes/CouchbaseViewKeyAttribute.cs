﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CouchbaseModelViews.Framework.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple=true)]
    public class CouchbaseViewKeyAttribute : Attribute
    {
        public int Order { get; set; }

        public string ViewName { get; set; }

        public string PropertyName { get; set; }

        public CouchbaseViewKeyAttribute(string viewName, string propertyName = "", int order = 0)
        {            
            PropertyName = propertyName;
            ViewName = viewName;
            Order = order;
        }        
    }
}
