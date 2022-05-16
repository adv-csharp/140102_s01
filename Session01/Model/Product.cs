using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01.Model;

public class Product
{
    //Filed
    private int tag;

    
    //Property
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }


    //private string picture;
    //public string Picture
    //{
    //    get { return picture; }
    //    set { picture = value; }
    //}


    //Construcrtor
    public Product()
    {
        Id = new Random().Next();
    }

    public Product(int Id)
    {
        this.Id = Id;
    }

    public Product(string Name, int Price) : this()
    {        
        //Id = new Random().Next();
        this.Name = Name;
        this.Price = Price;
    }

    public Product(int Id, string Name, int Price) : this(Name, Price)
    {
        this.Id = Id;
    }


}
