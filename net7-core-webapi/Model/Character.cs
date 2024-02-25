using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using net7_core_webapi.Enum;

namespace net7_core_webapi.Model
{
    public class Character
    {
        public long ID {get;set;}
        public string? Name {get;set;}
        public DateOnly BirthDay {get;set;}
        public int Age {get;set;}
        public string? Born {get;set;}
        public Gender Gender{get;set;} = Gender.Nam;

        public Character(long ID, string Name, string BirthDay, string Born){
            this.ID = ID;
            this.Name = Name;
            this.BirthDay = DateOnly.ParseExact(BirthDay, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            this.Born = Born;
            this.Age = this.Calculator_Age(this.BirthDay);
        }

        private int Calculator_Age(DateOnly Date){
            int age = DateTime.Now.Year - Date.Year;
            if(DateTime.Now.Month < Date.Month) 
                return age - 1;
            if(Date.Month == DateTime.Now.Month && DateTime.Now.Day < Date.Day)
                return age - 1;

            return age;
        }
    }
}