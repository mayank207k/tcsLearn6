using System;

namespace tcsLearn6
{

    class Class1
    {
        int firstnumber;
        int secondnumber;
        public Class1()
        {
            firstnumber=0;
            secondnumber=0;
        }
        void add()
        {
            Console.WriteLine("Enter the first number ");
            firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number ");
            secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result of Addition is {0} ", firstnumber + secondnumber);
            Console.WriteLine("Enter '5' if you want to continue or '9' to exit Addition");
            var counter = Convert.ToInt32(Console.ReadLine());
            if (counter == 5)
            {
                add();
            }
        }
        void subtract()
        {
            var sub = 0;
            Console.WriteLine("Enter the first number A:");
            firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number B:");
            secondnumber = Convert.ToInt32(Console.ReadLine());
            if (firstnumber > secondnumber)
                sub = firstnumber - secondnumber;
            else
                sub = secondnumber - firstnumber;
            Console.WriteLine("Result of Addition is {0} ", sub);
            Console.WriteLine("Enter '5' if you want to continue or '9' to exit subtraction");
            var counter = Convert.ToInt32(Console.ReadLine());
            if (counter == 5)
            {
                subtract();
            }
        }

        void multiply()
        {
            Console.WriteLine("Enter the first number A:");
            var firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number B:");
            var secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result of Addition is {0} ", firstnumber * secondnumber);
            Console.WriteLine("Enter '5' if you want to continue or '9' to exit Multiplication");
            var counter = Convert.ToInt32(Console.ReadLine());
            if (counter == 5)
            {
                multiply();
            }
        }

        void divide()
        {
            Console.WriteLine("Enter the first number A:");
            var firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number B:");
            var secondnumber = Convert.ToInt32(Console.ReadLine());
            if (secondnumber == 0)
            {
                Console.WriteLine("Divisor cannnot be 0 \nPLease Enter the valid input");
                divide();
            }
            else
            {
                Console.WriteLine("Result of division is {0} ", firstnumber / secondnumber);
                Console.WriteLine("Enter '5' if you want to continue or '9' to exit Divison");
                var counter = Convert.ToInt32(Console.ReadLine());
                if (counter == 5)
                {
                    divide();
                }
            }
        }
        static void Main(string[] args)
        {
            try
            {
                //Creation of Class Object
                Class1 obj = new Class1();

                //Entering Choices for Calculator
                Console.WriteLine("Basic Calculator");
                Console.WriteLine("Main Menu : \n 0 - Exit \n 1 - Add \n 2 - Subtract \n 3 - Multiply \n 4 - Divide");
                Console.WriteLine("Enter your choice from 1-4 to perform action");
                var ch = Console.ReadLine();
                var choice = Convert.ToInt16(ch);

                do
                {
                    switch (choice)
                    {
                        case 1:
                            obj.add();
                            break;

                        case 2:
                            obj.subtract();
                            break;

                        case 3:
                            obj.multiply();
                            break;

                        case 4:
                            obj.divide();
                            break;

                        default:
                            Console.WriteLine("Please Enter valid input");
                            break;
                    }
                    Console.WriteLine("Enter Your choice as below");
                    Console.WriteLine("Main Menu : \n 0 - Exit \n 1 - Add \n 2 - Subtract \n 3 - Multiply \n 4 - Divide");
                    ch = Console.ReadLine();
                    choice = Convert.ToInt16(ch);
                } while (choice != 0);
                Console.WriteLine("Thank for using Calculator");
            }
            catch (Exception)
            {
                Console.WriteLine(" Sorry Something went wrong, Please try again later");
            }
        }
    }
}