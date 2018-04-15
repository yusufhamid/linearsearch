using System;

public class LinearSearchTest
{
    static void Main(string[] args)
    {

        var generator = new Random();
        var data = new int[10];

        for (var i = 0; i < data.Length; ++i)
        {
            data[i] = generator.Next(10, 100);
        }

        //display array
        Console.WriteLine(string.Join(" ", data) + "\n");

        Console.WriteLine("Enter an integer value: ");
        var searchInt = int.Parse(Console.ReadLine());


        // repeatedly input an integer; -1 terminates the app
        while (searchInt != -1)
        {
            // perform linear search
            int position = LinearSearch(data, searchInt);

            if (position != -1) // integer was found
                Console.WriteLine(
                "The integer {0} was found in position {1}.\n",
                searchInt, position);
            else // integer was not found
                Console.WriteLine("The integer {0} was not found.\n",
                searchInt);

            // input next int from user
            Console.Write("Please enter an integer value (-1 to quit): ");
            searchInt = int.Parse(Console.ReadLine());
        } // end while
    } // end Main

    public static int LinearSearch(int[] values, int searchKey)
    {
        for (var index = 0; index < values.Length; ++index)
        {
            if (values[index] == searchKey)
            {
                return index;
            }
        }
        return -1;
    }
}
