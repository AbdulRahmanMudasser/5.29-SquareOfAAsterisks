class AsterisksSquare
{
    static void Main(string[] args)
    {
        // decalring variables
        int size;

        // taking size from user
        Console.Write("Enter Size For Square Of Asterisks: ");
        size = Convert.ToInt32(Console.ReadLine());

        // check if the input is less than 1
        if (size < 1)
        {
            size = 1;
        }

        else if (size > 20)
        {
            size = 20;
        }

        // displaying square
        for (int row = 1; row <= size; row++) 
        {
            for (int col = 1; col <= size; col++) 
            {
                if (row == 1 || row == size || col == 1 || col == size) 
                {
                    Console.Write("*");
                }

                else
                {
                    Console.Write(" ");
                }
            }
            // end of inner loop

            Console.WriteLine();    // for new line
        }
        // end of outer loop
    }
}
