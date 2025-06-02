Console.WriteLine("Bianary Search");
Console.WriteLine("");
Console.WriteLine("Divide and conquer for sorted array/list - Halves the number of elements it has to search in each step.");
Console.WriteLine("If target is found the index of the element is returned");
Console.WriteLine("If no target is found a negative number will be returned");
Console.WriteLine("");
Console.WriteLine("Time Complexity: O(log n)");
Console.WriteLine("Generally suitable for real-time applications as logarithimic growth means that as the size of input data increases the time taken to process the data increases at much slower rate");

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine("");
DisplayArray(numbers);

Console.WriteLine("");
Console.WriteLine("1st: Built in BinarySearch().");

static void DisplayArray(int[] arr) => Console.WriteLine(string.Join(" ", arr));
int numberInArray = Array.BinarySearch(numbers, 5);
int numberNotInArray = Array.BinarySearch(numbers, 12);

Console.WriteLine("");
Console.WriteLine($"The number 5 is at index {numberInArray}.");
Console.WriteLine($"The number 12 is at index {numberNotInArray}.");

Console.WriteLine("");
Console.WriteLine("2nd: Custom Implementation");

static int BinarySearch(int[] arrary, int number)
{
    if (arrary?.Any() != true) return -1;

    int min = 0;
    int max = arrary.Length - 1;

    while (min <= max)
    {
        int mid = (min + max) / 2;

        if (arrary[mid] == number)
        {
            return mid;
        }
        else if (number < arrary[mid])
        {
            max = mid - 1;
        }
        else
        {
            min = mid + 1;
        }
    }
    return -1;
}

Console.WriteLine($"Custom Binary Search for 4: {BinarySearch(numbers, 4)}");
Console.WriteLine($"Custom Binary Search for 14: {BinarySearch(numbers, 14)}");

