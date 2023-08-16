//Exercises: Control Flow & Collections

//TODO: Write your code for List Practice below:

//Console.WriteLine("Hello, Lists!");
//Write a static method to find the sum of all the even numbers in a List.

 static double listEvens(List<double> nums)
{
    // some code
    double total = 0;

    foreach (double num in nums)
    {
        if (num % 2 == 0)
        {
            total += num;
        }
    }
    return total;
}

List<double> nums = new List<double>();
nums.Add(0);
nums.Add(1);
nums.Add(2);
nums.Add(3);
nums.Add(4);
nums.Add(5);
nums.Add(6);
nums.Add(7);
nums.Add(8);
nums.Add(9);
Console.WriteLine(listEvens(nums));


//Write a static method to print out each word in a list that has exactly 5 letters.

static void  fiveLetters(List<string> words)
{
    foreach (string word in words)
    {
        if (word.Length == 5)
        {
           Console.WriteLine(word);
        }
    }
}

List<string> words = new List<string>();
words.Add("apple");
words.Add("banana");
words.Add("orange");
words.Add("grape");
words.Add("tomato");
words.Add("pineapple");
words.Add("strawberry");
words.Add("mango");
words.Add("kiwi");
words.Add("cherry");

fiveLetters(words);


//Modify your code to prompt the user to enter the word length for the search.

static void searchByInput(List<string> words)
{
    string searchNumber;
    Console.Write("Please enter a number: ");
    searchNumber = Console.ReadLine();
    double number = Double.Parse(searchNumber);

    foreach (string word in words)
    {
        if (word.Length == number)
        {
            Console.WriteLine(word);
        }
    }
}
searchByInput(words);