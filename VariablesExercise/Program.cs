namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "David";
            int age = 18;
            char years = '9';
            bool value = false;
            double num = 40.00;
            decimal num2 = 60.0m;
            Console.WriteLine($"There is a guy named {name}, \n{name} was {age} when he joined the US Navy, \nHe was in the Navy for {years} years and 7 months so let's round up to 10. \nWas it always fun? {value}. \nAbout {num} percent of the time was full of craziness, \nbut {num2} percent was awesome sauce as {name} enjoyed some traveling and visiting other countries.");
        }
    }
}
