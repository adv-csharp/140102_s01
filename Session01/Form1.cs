﻿using Session01.Model;

namespace Session01;

// Accessibility Level
//  class level: public, internal
public partial class Form1 : Form
{
    //Method, Property Level
    //  public, private, protectd, internal

    public Form1()
    {
        InitializeComponent();

        // Variable
        // <type> <variable_name> = <initial_alue>;

        // types :
        //      stack:  int, float, structure
        //      heap:   object (new)
        //  string?
        //      heap (by ref) -> by value

        /*
         * var p1 = new Product("pc", 1000);
         * 
         * var p2 = p1;
         * 
         * p1.price = 1500;
         * 
         * p2.price ? 1500
         */

        /*
         * <variable_name>
         *  case:
         *      PascalCase  function va class
         *      camelCase   variable va function private
         *      train_case  ❌
         *      kebal-case  ❌
         */


        /*
         * explicit صریح
         */
        int a = 1;


        /*
         * implicit ضمنی
         */
        var b = 1;

        //var c; 🐞

        /*
         * Boxing va Unboxing
         */

        var name = "test";
        object objName = name;


        var newName = Convert.ToString(objName);
        /*
         * Performance
         * RunTime Error
         * Readibility 
         * 
         * Bejash => Genrics ✨
         */



    }

    private void btnNewProduct_Click(object sender, EventArgs e)
    {
        var product1 = new Product("pc", 1000);

        var product2 = new Product();
        product2.Name = "monitor";
        product1.Price = 2000;


        //Object Initializer
        var product3 = new Product
        {
            Name = "mouse",
            Price = 500,
            Id  = 10
        };





    }
}
