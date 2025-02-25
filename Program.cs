namespace Variables_Mangum_Stephen
{
    internal class Program
    {
        static void Main()
        {
            // Define an integer variable named "favoriteNumber"
            int favoriteNumber;

            // Initialize two boolean variables "isJumping" and "isRunning" to false on the same line
            bool isJumping = false, isRunning = false;

            // Define a floating-point variable (I'm naming it "myFloatNumber")
            float myFloatNumber;

            // Assign "favoriteNumber" to my favorite number, which is 950
            favoriteNumber = 950;  // 950 is my favorite number. 950!!!

            // Assign the floating-point variable a floating-point number (why must my data be floating)
            myFloatNumber = 3.14f;  // Example value I chose...I don't really understand floating

            // Initialize a double constant named "finalGrade" that cannot be changed
            const double finalGrade = 95;  // Example grade I chose, you're too bad for a 100 as a finalGrade...whatever that means

            // Print all variables on their own line
            Console.WriteLine("Favorite Number: " + favoriteNumber);
            Console.WriteLine("Is Jumping: " + isJumping);
            Console.WriteLine("Is Running: " + isRunning);
            Console.WriteLine("Floating Point Number: " + myFloatNumber);
            Console.WriteLine("Final Grade: " + finalGrade);
        }
    }
}