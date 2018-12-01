using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp
{
  
    public class Note
    {
        public  int id { get; set; }
        public string lastName { get; set; }
        public string name { get; set; }
        public string fname { get; set; }
        public string phone { get; set; }
        public string country { get; set; }
        public DateTime birthDate { get; set; }
        public string organization { get; set; }
        public string post { get; set; }
        public string notice { get; set; }

        public Note(string lastName, string name, string phone, string country)
        {
            this.lastName = lastName;
            this.name = name;
            this.phone = phone;
            this.country = country;  
        }
        public string ShowSmallNote()
        {

            return "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n№ " + this.id +
                "\nLast Name: " + this.lastName + "\nName: " + this.name +
                "\nPhone: " + this.phone + "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
        }
        public override string ToString()
        {
            return "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n№ " + this.id + 
                "\nLast Name: " + this.lastName + "\nName: " + this.name + 
                "\nPhone: " + this.phone + "\nCountry: " + this.country +"\nBirth Day: " 
                + this.birthDate.ToString("dd.MM.yyyy") 
                + "\nOrganization: "+ this.organization + "\nPost: " + this.post +
                "\nNotice: " + this.notice +"\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
        }
    }
}
