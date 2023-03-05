using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Player
    {
        private string name, lastname, studentid, major, displayname, mail, phone;
        private int age = 0;
        public Player(string name, string lastname, string studentid, string major, string displayname, string mail, string phone, int age)
        {
            this.name = name;
            this.lastname = lastname;
            this.studentid = studentid;
            this.major = major;
            this.displayname = displayname;
            this.mail = mail;
            this.phone = phone;
            this.age = age;
        }
        public string Name()
        {
            return name;
        }
        public string LastName()
        {
            return lastname;
        }
        public string ID()
        {
            return studentid;
        }
        public string Major()
        {
            return major;
        }
        public string Displaygame()
        {
            return displayname;
        }
        public string Mail()
        {
            return mail;
        }
        public string Phone()
        {
            return phone;
        }
        public int Age()
        {
            return age;
        }
    }
}
