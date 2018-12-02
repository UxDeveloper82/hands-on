using System;
using System.Text;

namespace StringsNullablesConversionsDecisions
{
    class Program
    {
        static void Main()
        {
            // Use a StringBuilder to efficiently change an original string containing
            // the text "Cat" to a result that has one character changed to produce the
            string originalString = "Cat";
            Console.WriteLine(originalString);
            System.Text.StringBuilder sb =
            new System.Text.StringBuilder(originalString); // copy to StringBuilder
            sb[0] = 'R';                                       // efficiently manipulate in situ
            string resultingString = sb.ToString();            // get new string back out
            System.Console.WriteLine(resultingString);  
            // result "Rat". Then display that result in the console window.


            // Declare a nullable int named x, initialize it to null, and then

            int? x = null;
            Console.WriteLine(x);
            Console.WriteLine(x.HasValue);

            // display it in console output. Then display the boolean value that
            // indicates whether x has a value or not. After that, assign 42 to it
            x = 42;
            Console.WriteLine(x);
            Console.WriteLine(x.HasValue); 

            // and display it again and then display the boolean value again that
            // indicates whether x has a value or not.


            // Declare a DateTime variable named aDateTime, and assign it to the result of
            // converting the string "4 July 1776" to a DateTime object. Then display the result.
             DateTime dt =Convert.ToDateTime("4 July 1776");
                       Console.WriteLine(dt);
           //string dateTime = "07/04/1776 12:00:00 AM";  
            //DateTime dt = Convert.ToDateTime(dateTime);  
            //Console.WriteLine("{0}/{1}/{2} Hour: {0}, Minute: {4}, Second: {5}, AM: {6}",  
                              //dt.Month,dt.Day,dt.Year,dt.Hour, dt.Minute, dt.Second, dt.Millisecond);  
            
           // DateTime dt=DateTime.ParseExact("07/04/1776", "dd/MM/yyyy"); 
            //Console.WriteLine(dt);

            // Declare a variable of type char named ch and initialize it with the value '7'.
            var ch = '7';
            if(Char.IsLetter(ch)){
                Console.WriteLine( ch + " is character");
            }else{
                Console.WriteLine(ch + "is not a character");
            }
            Console.ReadKey();

            // Then test it in an if statement to see if it is a letter or a
            // non-letter character. Display output on the console that indicates
            // whether it is a letter or a non-letter.


        }
    }
}