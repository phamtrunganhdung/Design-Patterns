using System;
using System.Collections.Generic;
using System.Text;

namespace exPrototype
{
    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfor IdInfor;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.IdInfor = new IdInfor(IdInfor.IdNumber);
            clone.Name = String.Copy(Name);
            return clone;
        }
    }
}
