class Task3
{
    static void Main(string[] args)
    {
        int[] numbers = { 3, 7, 12, 19, 21, 25, 30 };
        System.Console.WriteLine("Enter a number: ");
        int numberToSearch = int.Parse(Console.ReadLine());
        // System.Console.WriteLine(1+numberToSearch);
        int index = 0;
        bool found = false;
        foreach (var number in numbers)
        {
            if (number == numberToSearch)
            {
                System.Console.WriteLine( $"Number found at position {index}!" );
                found = true;
                break;
            }
            index++;
        }
        if (!found)
        {
            System.Console.WriteLine( "Number not found in the list." );
        }
    }
}