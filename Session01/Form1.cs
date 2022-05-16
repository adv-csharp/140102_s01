using Session01.Model;
using Session01.UI;

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

    private void btnAddName_Click(object sender, EventArgs e)
    {
        if (!listBoxNames.Items.Contains(txtName.Text))
        {
            listBoxNames.Items.Add(txtName.Text);
        }

        
    }

    

    private void btnCalcAdd_Click(object sender, EventArgs e)
    {
        //txtCalcResult.Text = calc(txtA.Text, txtB.Text, "+").ToString();
        txtCalcResult.Text = calc(txtA.Text, txtB.Text, CalcOpEnum.Add).ToString();
    }

    private void btnCalcSub_Click(object sender, EventArgs e)
    {
        //txtCalcResult.Text = calc(txtA.Text, txtB.Text, "-").ToString();
        txtCalcResult.Text = calc(txtA.Text, txtB.Text, CalcOpEnum.Sub).ToString();
    }

    private void btnCalcMul_Click(object sender, EventArgs e)
    {
        //txtCalcResult.Text = calc(txtA.Text, txtB.Text, "*").ToString();
        txtCalcResult.Text = calc(txtA.Text, txtB.Text, CalcOpEnum.Mul).ToString();
    }

    private void btnCalcDiv_Click(object sender, EventArgs e)
    {
        //txtCalcResult.Text = calc(txtA.Text, txtB.Text, "/").ToString();
        txtCalcResult.Text = calc(txtA.Text, txtB.Text, CalcOpEnum.Div).ToString();
    }

    //Overload kardan method
    private double calc(string txtA, string txtB, string op)
    {
        var a = Convert.ToDouble(txtA);
        var b = Convert.ToDouble(txtB);

        switch (op)
        {
            case "+":
                return a + b;
            case "-":
                return a - b;
            case "*":
                return a * b;
            case "/":
                return a / b;
            default:
                throw new ArgumentException("op not defined");
        }
    }


    private double calcPattern(string txtA, string txtB, CalcOpEnum op)
    {
        var a = Convert.ToDouble(txtA);
        var b = Convert.ToDouble(txtB);

        /*
         * Refactoring
         * بهنیه کردن ساختار بدون تغییر در رفتار کد
         */


        //Pattern Maching

        return op switch
        {
            CalcOpEnum.Add => a + b,
            CalcOpEnum.Sub => a - b,
            CalcOpEnum.Mul => a * b,
            CalcOpEnum.Div => a / b,
            _ => throw new ArgumentException("op not defined"),
        };
    }
    private double calc(string txtA, string txtB, CalcOpEnum op)
    {
        var a = Convert.ToDouble(txtA);
        var b = Convert.ToDouble(txtB);

        switch (op)
        {
            case CalcOpEnum.Add:
                return a + b;
            case CalcOpEnum.Sub:
                return a - b;
            case CalcOpEnum.Mul:
                return a * b;
            case CalcOpEnum.Div:
                return a / b;
            default:
                throw new ArgumentException("op not defined");
        }
    }

    private double calcBreak(string txtA, string txtB, string op)
    {
        var a = Convert.ToDouble(txtA);
        var b = Convert.ToDouble(txtB);
        double result;

        switch (op)
        {
            case "+":
                result =  a + b;
                break;
            case "-":
                result = a - b;
                break;
            case "*":
                result =  a * b;
                break;
            case "/":
                result = a * b;
                break;

            case "!":
            case "%":
                result = 0;
                break;
            default:
                throw new ArgumentException("op not defined");
        }

        return result;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnManageUsers_Click(object sender, EventArgs e)
    {
        var frm = new FormUsers();
        //frm.Show();
        frm.ShowDialog();
    }
}
