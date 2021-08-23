using System;

/*
 * 
 */
namespace Mod1Lab
{
    
    /*
     * Class that contains the needed methods in addition to the main
     * method running on console running. Contains 2 methods for Lab A
     * and Lab B that get user parameters, convert them to correct data type
     * used for math used below that methods calculate.
     */
    class Program
    {


        /*
         * LabB runs math on a recipe based on input number that
         * will dictate how the ratios will be by have pre-made ratios
         *
         * @return null
         */
        public string LabB()
        {

            /*
            * assigning variables
            */
            double cupcakes = 8;
            double eggs = 4 / cupcakes;
            double sugar = 1 / cupcakes;
            double cheese = 3 / cupcakes;
            double vanilla = 1 / cupcakes;
            
            
            /*
             * get console input and convert to double for math
             */
            Console.WriteLine("Enter Number Cupcakes:");
            string numCupcakes = Console.ReadLine();
            double numCakes = Convert.ToDouble(numCupcakes);

            

            /*
             * assigning variables and validating input
             */
            double n0 = numCakes * 1 / 2;
            double n1 = numCakes * 1 /  8;
            double n2 = numCakes * 3 / 8;
            double n4 = numCakes * 1 / 8;
            double numEggs = numCupcakes != null ?  numCakes * 1 / 2 : numCakes = 0;
            double numSugar = numCupcakes != null ?  numCakes * 1 / 8 : numCakes = 0;
            double numCheese = numCupcakes != null ?  numCakes * 3 / 8 : numCakes = 0;
            double numVanilla = numCupcakes != null ?  numCakes * 1 / 8 : numCakes = 0;

   
            /*
             * output the variables assigned from ratio math
             */
             Console.Write(numEggs);
             Console.WriteLine(" eggs");
             Console.Write(numSugar);
             Console.WriteLine(" cups sugar");
             Console.Write(numCheese);
             Console.WriteLine(" packages of cream cheese");
             Console.Write(numVanilla);
             Console.WriteLine(" teaspoon vanilla");
       
             
             /*
             * return null just run and print
             */
             return null;
        }
        
        /*
         * Lab A runs the math done on the input values
         * Takes 2 input numbers and finds product, sum, diff
         *
         * @return null
         */
        public string LabA()
        {
         
            /*
             * Getting console input of 2 variables used below
             */
            Console.Write("Input first number>");
            string numOne = Console.ReadLine();
            Console.Write("Input second number>");
            string numTwo = Console.ReadLine();


            /*
            * validating input and writeing the math output
            */
            if ((numOne != null) && numTwo != null)
            {
             
                /*
                * assigning variables and converting for math below
                */
                int numOneInt = Convert.ToInt32(numOne);
                int numTwoInt = Convert.ToInt32(numTwo);

                int sum = numOneInt + numTwoInt;
                int diff = numOneInt - numTwoInt;
                int prod = numOneInt * numTwoInt;
                
                Console.Write(numOne + " + " + numTwo + " = ");
                Console.Write( numOneInt + numTwoInt);
                Console.WriteLine(" sum");
                Console.Write(numOne + " - " + numTwo + " = ");
                Console.Write(numOneInt - numTwoInt);
                Console.WriteLine(" difference");
                Console.Write(numOne + " * " + numTwo + " = ");
                Console.Write(numOneInt * numTwoInt);
                Console.WriteLine(" product");
                
                Console.Write("Input height>");
                string height1 = Console.ReadLine();
                Console.Write("Input width>");
                string width1 = Console.ReadLine();
                
                int height = Convert.ToInt32(height1);
                int width = Convert.ToInt32(width1);
                int area = height * width;
                Console.WriteLine("Area: " + area);
            }
            
            
            /*
             * return null just run and print
             */
            return null;
        }
        /*
         * main console method that instantiates a new Program class
         * and runs LabA and LabB methods that will use console.writeline
         * to output the labs required parameters and functions.
         */
        static void Main(string[] args)
        {
            /*
             * create new class and run both methods
             */
            Program A = new Program();
            A.LabA();
            A.LabB();
        }
    }
}