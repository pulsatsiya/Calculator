using System;

namespace Calculator
{
    interface ICalculator
    {
        public double Act(double a, double b);
    }
    class Calculator
    {
        public ICalculator Result { get; set; }


        public double Action(double a, double b)
        {
            Console.WriteLine("Результат: \n");
            return Result.Act(a, b);


        }

    }
    class Plus : ICalculator
    {
        public double Act(double a, double b)
        {
            return a + b;
        }
    }
    class Minus : ICalculator
    {
        public double Act(double a, double b)
        {
            return a - b;
        }
    }
    class Mult : ICalculator
    {
        public double Act(double a, double b)
        {
            return a * b;
        }
    }
    class Div : ICalculator
    {
        
        public double Act(double a, double b)
        {

            if (a == 0)
            {
                Console.WriteLine("Нельзя делить на ноль... Сделаем вид, что ничего не было");
                return 0;
            }
            else
                return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string yes;
            Console.WriteLine("Привет! это калькулятор для операции между двумя целыми числами (пока что...) \n ");
            do
            {
                Calculator calculator = new Calculator();
                Console.WriteLine("Введи первое число:  ");
                int a, b, c;
                while (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Введите правильные данные");
                }
                Console.WriteLine("А теперь второе: ");
                while (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Введите правильные данные");
                }
                Console.WriteLine("Какую хочешь провести операцию? \n 1 - сложение \n 2 - вычитание\n 3 - умножение \n 4 - деление ");

                while(!int.TryParse(Console.ReadLine(), out c)||c<1||c>4)
                {
                    Console.WriteLine("Введите правильные данные");
                }

                switch (c)
                {
                    case 1:
                        calculator.Result = new Plus();
                        Console.WriteLine(calculator.Action(a, b));
                        break;
                    case 2:
                        calculator.Result = new Minus();
                        Console.WriteLine(calculator.Action(a, b));
                        break;

                    case 3:
                        calculator.Result = new Mult();
                        Console.WriteLine(calculator.Action(a, b));
                        break;
                    case 4:
                        calculator.Result = new Div();
                        Console.WriteLine(calculator.Action(a, b));
                        break;
                    default:
                        Console.WriteLine("Дурак...Пока");
                        break;

                }


                
                Console.WriteLine("Посчитать еще? Если да, то напиши да");
                yes = Convert.ToString(Console.ReadLine());
            } while (yes == "да" || yes == "Да");

            Console.WriteLine("Пока!");
            Environment.Exit(0);

            
        } 
    }
}