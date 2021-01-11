﻿using System;
using System.Text;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public virtual int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Invalid age!");
                }

                this.age = value;
            } 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {this.Name}, Age: {this.Age}");
            
            return sb.ToString().TrimEnd();
        }
    }
}
