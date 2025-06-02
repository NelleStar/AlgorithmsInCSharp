Console.WriteLine("Linear Search");
Console.WriteLine("");
Console.WriteLine("Also known as sequential search, this simple algorithm is used to find a specific value in an array.");
Console.WriteLine("If target is found the index of the element is returned");
Console.WriteLine("If no target is found -1 will be returned");
Console.WriteLine("");
Console.WriteLine("Time Complexity: O(n)");
Console.WriteLine("This makes it inefficient and not suitable for real-time applications");

// custom implmentation
static int LinearSearch(int[] numbers, int target)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == target) return i;
    }
    return -1;
}

int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 
static void DisplayArray(int[] arr) => Console.WriteLine(string.Join(" ", arr));
int numberInArray = LinearSearch(numbers, 6);
int numberNotInArray = LinearSearch(numbers, 12);

Console.WriteLine("");
DisplayArray(numbers);
Console.WriteLine($"The number 6 is at index {numberInArray}.");
Console.WriteLine($"The number 12 is at index {numberNotInArray}.");