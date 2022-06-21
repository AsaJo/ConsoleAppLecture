namespace ConsoleAppLecture;

internal class Program
{

    static void Main(string[] args)
    {

        //Console.WriteLine("Hello, World!");

        //Console.Write("");        //Writes to the console	

        //Console.WriteLine(""); 	//Writes a line to the console, adding a line break

        //Console.ReadLine(); 	    //Reads text input from console

        //Console.ReadKey();	    //Reads a keypress from user	


        //********************************** Data Literales Variables *****************************************************


        //string message = "Happy Coding!";
        //Console.WriteLine(message);
        //Console.ReadKey();

        //*********************************** Data Variables **************************************************************

        //int numA;                                 // Declaration
        //numA = 64;                                // Assingment
        //Console.WriteLine(numA);
        //// Both at once (Initialization)

        //string message = "Hello, World ";
        //Console.WriteLine(message);
        //Console.ReadKey();

        //*********************************** Data – Evaluation Order*****************************************************


        //int numA;                                 // Declaration
        //int numB = (numA=64)* 3;
        //// this sets numA to 64 and numB to numA * 3, in on line
        //Console.WriteLine(numA);
        //Console.WriteLine(numB);
        //Console.ReadKey();



        //************************************ Control Flow Statements - Selections ***************************************

        //int numA = 2;
        //int numB = 2;
        //bool isEqual = numA == numB;
        //Console.WriteLine(isEqual);
        //Console.ReadKey();

        //************************************ Selections – if-statements *************************************************

        //bool Condition=false;
        //bool otherCondition=false;

        //if (Condition) {
        //    Console.WriteLine("Happy Hacker!");
        //    // if Condition is true
        //}
        //else if (otherCondition) {

        //    Console.WriteLine("Nice Hacker!");
        //    // if Condition is false
        //    // and if otherCondition is true

        //}
        //else {
        //    // if neither Conditions is true
        //    Console.WriteLine("Just Hacking");

        //}


        //********************************* Selections – switch-statements **************************************************
        //int number = Convert.ToInt32(Console.ReadLine());


        //switch (number)
        //{
        //    case 1:
        //        Console.WriteLine("number is equal to 1 ");
        //        break;
        //    case 2:
        //    case 3:
        //        Console.WriteLine("number is equal to 2 and 3 ");
        //        break;
        //    case 4:
        //        Console.WriteLine("number is equal to 4 ");
        //        break;

        //    default:
        //        Console.WriteLine("Hello fellow hackers");
        //        break;
        //}Console.ReadKey();


        //********************************** Selections – ternary operator *****************************************************
        //int number = Convert.ToInt32(Console.ReadLine());

        //int number = 6;

        //string response = (number > 5) ? "Value is above 5"
        //                               : "Value is not above 5";



        //********************************** Flow Chart - Iterative Statements do while-loops  *********************************


        //int number = Convert.ToInt32(Console.ReadLine());
        ////int number = 6;
        ////"Flow Chart" Iterative Statements

        //while (number > 0)
        //{
        //    Console.WriteLine(number);
        //    number--;
        //}
        //do
        //{
        //    Console.WriteLine(number);
        //    number--;

        //} while (number > 0);

        //Console.WriteLine("Value is now 0");


        //********************************** Flow Chart - Iterative Statements for-loops ******************************************

        //for(int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine("this will be written 10 times- this is #"+ i);   
        //}

        //********************************** Methods - Definition *****************************************************************
        GetStringFromUser();
        GetStringFromUser(bool);

        //static string? GetStringFromUser()
        //{
        //    string? userString = Console.ReadLine();
        //    return userString;
        //}

        static string? GetStringFromUser()
        {
            string? userString = Console.ReadLine();
            return userString;
        }
        static string GetStringFromUser(bool upperCase)
        {
            string? userString = Console.ReadLine();
            if (upperCase)
            {
                userString = userString.ToUpperUpper();
            }
        }
        return userString;
    }

}