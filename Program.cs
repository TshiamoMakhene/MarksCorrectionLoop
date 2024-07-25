namespace MarksCorrectionLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students do you want to enter marks for?: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int counter = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine( $"Enter the marks for students {i+1}: " ); // increaments to the student you want 
                int marks = Convert.ToInt32(Console.ReadLine());

                sum +=marks; //basically marks plus marks to give total for marks and give an avarage 

                counter++;  // counter to count the students marks entered
                Console.WriteLine(  ); // gives space before the total 
            }
            if (counter > 0)
            {
                double avarage = (double)sum / counter; // calculate the avarage of the studnets using counter to keep track of the studnets 
                Console.WriteLine($"Avarage marks for {counter} students: {avarage}%"); // outputs the average

            }
            else
            {
                Console.WriteLine("No marks were entered for any student.");// handle in case there is no marks entered 
            }
            Console.ReadKey();
        }
    }
}
