using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class Calculator
    {
        private string currentValue;
        public string CurrentValue
        {
            get
            {
                return this.currentValue;
            }
            set
            {
                this.currentValue = value;
            }  
        }
        private string operand1;
        public string Operand1
        {
            get
            {
                return operand1;
            }
            set
            {
                operand1 = value;
            }
        }
        private string operand2;
        public string Operand2
        {
            get
            {
                return operand2;
            }
            set
            {
                operand2 = value;
            }
        }
        
       
         public enum Operator { Add, Subtract, Multiply, Divide, None};
        
        private Operator op;
        public Operator Op
        {
            get
            {
                return this.op;
            }
            
            set
            {
                if (value == Operator.Add)
                {
                    this.op = Operator.Add;
                }
                
                else if (value == Operator.Divide)
                {
                    this.op = Operator.Divide;
                }

                else if (value == Operator.Subtract)
                {
                    this.op = Operator.Subtract;
                }

                else if (value == Operator.Multiply)
                {
                    this.op = Operator.Multiply;
                }

                else if (value == Operator.None)
                {
                    this.op = Operator.None;
                }

            }
        }
        // op - an operator type storing the member of the operator enumeration
        // operator - an enumeration with "add, subtract, multiply, divide, and none

        // - creates a calculator constructor
        public Calculator()
        {
            currentValue = "";
        }
        // CurrentValue
        // add(displayValue)
       

        public void Add(string op1)
        {
           
            this.op = Operator.Add;
            this.Operand1 = op1;
            
            
        }

        // Subract(displayValue)
        public void Subtract(string op1)
        {
            this.op = Operator.Subtract;
            this.Operand1 = op1;
            
        }

        
      


        
        //multiply(displayValue)

        public void Multiply(string op1)
        {
            this.op = Operator.Multiply;
            this.operand1 = op1;
           
        }
        
       

        //Divide(displayValue)
        public void Divide(string op1)
        {
            this.op = Operator.Divide;
            this.operand1 = op1;
            
        }   

       
        //toDecimal
        public void ToDecimal(int op1)
        {
            Decimal val = Convert.ToDecimal(op1);
            currentValue = val.ToString();
            
        }
        //Equals()
        public void Equals()
        {
            int val;
            decimal val2;
            
            Operand2 = this.currentValue;
            if (op == Operator.Add)
            {
                if (int.TryParse(Operand1, out val)){

                    if (int.TryParse(Operand2, out val))
                    {
                        int a = Convert.ToInt32(Operand1);
                        int b = Convert.ToInt32(Operand2);
                        int result = a + b;
                        this.currentValue = result.ToString();
                    }
                    else if (Decimal.TryParse(Operand2, out val2))
                    {
                        int a = Convert.ToInt32(Operand1);
                        decimal b = Convert.ToDecimal(Operand2);
                        decimal result = a + b;
                        this.currentValue = result.ToString();
                    }

                } 
                else if ( Decimal.TryParse(Operand1, out val2))
                {
                    decimal a = Convert.ToDecimal(Operand1);
                    decimal b = Convert.ToDecimal(Operand2);
                    decimal result = a + b;
                    this.currentValue = result.ToString();
                }

                
               
            }

            else if (op == Operator.Divide)
            {
                if (int.TryParse(Operand1, out val))
                {
                    if (int.TryParse(Operand2, out val))
                    {
                       
                        int a = Convert.ToInt32(Operand1);
                        int b = Convert.ToInt32(Operand2);
                        if (a > b)
                        {


                            try
                            {
                                int result = a / b;
                                this.currentValue = result.ToString();
                            }
                            catch (DivideByZeroException)
                            {
                                this.CurrentValue = ("Cannot Divide By Zero");
                            }
                        }
                        else if (a < b)
                        {
                            try
                            {
                               Decimal result =  Decimal.Divide(a, b);
                                
                                this.currentValue = result.ToString();
                            }
                            catch (DivideByZeroException)
                            {
                                this.CurrentValue = ("Cannot Divide By Zero");
                            }
                        }
                    }
                    else if (Decimal.TryParse(Operand2, out val2))
                    {
                        int a = Convert.ToInt32(Operand1);
                        decimal b = Convert.ToDecimal(Operand2);
                        try
                        {
                            decimal result = a / b;
                            this.currentValue = result.ToString();
                        }
                        catch (DivideByZeroException)
                        {
                            this.CurrentValue = ("Cannot Divide By Zero");
                        }
                    }
                   
                }
                else if (Decimal.TryParse(Operand1, out val2))
                {
                    decimal a = Convert.ToDecimal(Operand1);
                    decimal b = Convert.ToDecimal(Operand2);
                    try
                    {
                        decimal result = a / b;
                        this.currentValue = result.ToString();
                    }
                    catch (DivideByZeroException)
                    {
                        this.CurrentValue = "Cannot Divide By Zero";
                    }
                }


            }

            else if (op == Operator.Multiply)
            {
                if (int.TryParse(Operand1, out val))
                {
                    if (int.TryParse(Operand2, out val))
                    {

                        int a = Convert.ToInt32(Operand1);
                        int b = Convert.ToInt32(Operand2);
                        int result = a * b;
                        this.currentValue = result.ToString();
                    }
                    else if (Decimal.TryParse(Operand2, out val2))
                    {
                        int a = Convert.ToInt32(Operand1);
                        decimal b = Convert.ToDecimal(Operand2);
                        decimal result = a * b;
                        this.currentValue = result.ToString();
                    }
                }
                else if (Decimal.TryParse(Operand1, out val2))
                {
                    decimal a = Convert.ToDecimal(Operand1);
                    decimal b = Convert.ToDecimal(Operand2);
                    decimal result = a * b;
                    this.currentValue = result.ToString();
                }
            }

            else if (op == Operator.Subtract)
            {
                if (int.TryParse(Operand1, out val))
                {
                    if (int.TryParse(Operand2, out val))
                    {
                        int a = Convert.ToInt32(Operand1);
                        int b = Convert.ToInt32(Operand2);
                        int result = a - b;
                        this.currentValue = result.ToString();
                    }
                    else if (Decimal.TryParse(Operand2, out val2))
                    {
                        int a = Convert.ToInt32(Operand1);
                        decimal b = Convert.ToDecimal(Operand2);
                        decimal result = a - b;
                    }
                }
                else if (Decimal.TryParse(Operand1, out val2))
                {
                    decimal a = Convert.ToDecimal(Operand1);
                    decimal b = Convert.ToDecimal(Operand2);
                    decimal result = a * b;
                    this.currentValue = result.ToString();
                }
            }
            else if (op == Operator.None)
            {
                this.currentValue = this.Operand1;
            }
           // this.Operand1 = this.currentValue;
            this.Operand2 = "";
            this.op = Operator.None;
            


        }

        public void Clear()
        {
            this.currentValue = "";
            this.Operand1 = "";
            this.Operand2 = "";
            this.Op = Operator.None;
            
        }
    }
   
        //Equals (displayValue)
        //Clear()

   
}
