Console.WriteLine("Bubble Sort");
Console.WriteLine("");
Console.WriteLine("Iterates through from first index to last, compares with adjacent elements and swaps if they appear in wrong order.");
Console.WriteLine("");
Console.WriteLine("Time Complexity: O(n^2) in worst case scenario");
Console.WriteLine("Complexity increases quadratically as N gets bigger - can use with any type of collection");

int outsideLoop = 0;
int insideLoop = 0;
int[] intArray = [72, 8, 113, 1, 45];

Console.WriteLine("");
Console.WriteLine($"Array before Bubble Sort: ");
DisplayArray(intArray);

for (int i = 0; i < intArray.Length; i++)
{
    outsideLoop += 1;
    for (int j = i + 1; j < intArray.Length; j++)
    {
        insideLoop += 1;
        if (intArray[j] < intArray[i])
        {
            var temp = intArray[i];
            intArray[i] = intArray[j];
            intArray[j] = temp;
        }
    }
}

static void DisplayArray(int[] arr) => Console.WriteLine(string.Join(" ", arr));

Console.WriteLine("");
Console.WriteLine($"Array after Bubble Sort: ");
DisplayArray(intArray);

Console.WriteLine("");
Console.WriteLine($"The outside loop interated {outsideLoop} times.");
Console.WriteLine($"The inside loop interated {insideLoop} times.");