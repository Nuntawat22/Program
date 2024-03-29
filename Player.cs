﻿using System;
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
        public string Name { get => name; }
        public string LastName { get => lastname; }
        public string Major { get => major; }
        public string Displayname { get => displayname; }
        public string Studentid { get => studentid; }
        public string Mail { get => mail; }
        public string Phone { get => phone; }
        public int Age { get => age; }
    }
}
