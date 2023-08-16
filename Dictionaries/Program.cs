//Exercises: Control Flow & Collections

//TODO: Write your code for Dictionary Practice below:

//Console.WriteLine("Hello, Dictionary!");

Dictionary<string, int> students = new Dictionary<string, int>();
string newStudent;

Console.WriteLine("Enter your students and their ID numbers(or ENTER to finish):");

do
{
    Console.WriteLine("Student: ");
    string input = Console.ReadLine();
    newStudent = input;

    if (!Equals(newStudent, ""))
    {
        Console.WriteLine("ID: ");
        input = Console.ReadLine();
        int newID = int.Parse(input);
        students.Add(newStudent, newID);

        // Read in the newline before looping back
        Console.ReadLine();
    }

} while (!Equals(newStudent, ""));

// Print class roster
Console.WriteLine("\nClass roster:");

foreach (KeyValuePair<string, int> student in students)
{
    Console.WriteLine(student.Key + "'s ID: " + student.Value);
}

Console.WriteLine("Number of Students: " + students.Count);