﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT
{
    public class recipe
    {
        string name;
        string type;
        string desc;
        List<string> ing = new List<string>();


        public recipe(string name, List<string> ing, string type, string desc)
        {
            this.name = name;
            this.ing = ing;
            this.type = type;
            this.desc = desc;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public void setDesc(string desc)
        {
            this.desc = desc;
        }
        public string getName()
        {
            return this.name;
        }

        public List<string> getIng()
        {
            return this.ing;
        }

        public void addIng(string y)
        {
            this.ing.Add(y);
        }

        public int length()
        {
            return this.ing.Count;
        }

    }
}
