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
    }
}
