//Exercises: Control Flow & Collections

//TODO: Write your code for Array Practice below:
//Console.WriteLine("Hello, Arrays!");

double[] nums = new double[] { 1, 1, 2, 3, 5, 8 };

Console.WriteLine("Loop through the array and print out each value.");
foreach (double num in nums)
{
    Console.WriteLine(num);
}

Console.WriteLine("Loop through the array and print out odd values.");

foreach (double num in nums)
{
    if (num%2 > 0)
    {
        Console.WriteLine(num);

    }
}
