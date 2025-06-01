namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4; //inferred variable is int
            var response = answer < 9 ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
            //ternary operator is the value of the inferred string variable "response"

            Console.WriteLine(response);
        }
    }
}
