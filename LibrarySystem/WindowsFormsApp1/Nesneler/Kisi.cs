using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Nesneler
{
    public class Kisi
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime createdDate { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string authority { get; set; }
        public int salary { get; set; }

        public Kisi()
        {
            
        }

        public Kisi(int id, string name, string surname, DateTime createdDate, string userName, string password, string authority, int salary)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.createdDate = createdDate;
            this.userName = userName;
            this.password = password;
            this.authority = authority;
            this.salary = salary;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        
        public int getId()
        {
            return this.id;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public string getSurname()
        {
            return this.surname;
        }

        public void setCreatedDate(DateTime createdDate)
        {
            this.createdDate = createdDate;
        }

        public DateTime getCreatedDate()
        {
            return this.createdDate;
        }

        public void setUserName(string userName)
        {
            this.userName = userName;
        }

        public string getUserName()
        {
            return this.userName;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setAuthority(string authority)
        {
            this.authority = authority;
        }

        public string getAuthority()
        {
            return this.authority;
        }

        public void setSalary()
        {
            this.salary = salary;
        }
        
        public int getSalary()
        {
            return this.salary;
        }

        public override string ToString()
        {
            return "İsim - Soyisim: " + this.name + " " + this.surname;
        }
    }
}
