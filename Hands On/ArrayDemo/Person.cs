using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ArrayDemo
{
    class Person
    {
        public string name;
        public int age;
        public string ToString(string name, int age)
        {
            this.name = name;
            this.age = age;
            string details = name + "-" + age;
            return details;
        }


        

    }
}
