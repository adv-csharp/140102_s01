using Session01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01.DataSource;

public static class InMemeoryDb
{
    
    //Array -> size fix ❌
    //List 

    public static List<User> Users = new List<User>
    {
        new User{Id= 1, FirstName = "Enciyeh", LastName = "Rajabi", Email = "Nadarim", Tel = "11"},
        new User{Id= 2, FirstName = "Faras", LastName = "Jafari", Email = "Nadarim", Tel = "11"},
        new User{Id= 3, FirstName = "Mohammad", LastName = "Abdollahzadeh", Email = "Nadarim", Tel = "11"},
        new User{Id= 4, FirstName = "Sareh", LastName = "Bitarafan", Email = "Nadarim", Tel = "11"},
        new User{Id= 5, FirstName = "Sina", LastName = "Afsharmanesh", Email = "Nadarim", Tel = "11"},
    };




}
