// See https://aka.ms/new-console-template for more information


int[] array = { 3, 12, 20, 25, 30, 41, 48, 55, 66, 78 };
int[] evenArray = GetEvenNumbers(array);
int[] oddArray = GetOddNumbers(array);

Console.WriteLine("ARRAY MED 10 ELEMENT:");
PrintArray(array);

Console.WriteLine();
Console.WriteLine("Talserien i jämna arrayen array 1: ");
PrintEvenNumbers(evenArray);

Console.WriteLine();
Console.WriteLine("Talserien i udda arrayen array 2: ");
PrintOddNumbers(oddArray);

Console.WriteLine();
Console.WriteLine("Vilken array som har lägsta värde: ");
PrintLowestValue(evenArray, oddArray);

Console.WriteLine();
Console.WriteLine("Vilken array som har högsta värde: ");
PrintHighestValue(evenArray, oddArray);

Console.WriteLine();
Console.WriteLine("Vilken array har störst medelvärde: ");
PrintHighestAverageArray(evenArray, oddArray);



        static int[] AddItemToArray(int[] oldArray, int item)
{
    int size = oldArray.Length + 1;
    int[] newArray = new int[size];
    for (int i = 0; i < oldArray.Length; i++)
    {
        newArray[i] = oldArray[i];

    }
    newArray[^1] = item;
    return newArray;
}

static int[] GetEvenNumbers(int[] array)
{

    int[] evenArray = new int[0];
    foreach (var item in array)
    {
        if (item % 2 == 0)
        {
            evenArray = AddItemToArray(evenArray, item);
        }
    }
    return evenArray;
}

static int[] GetOddNumbers(int[] array)
{
    int[] oddArray = new int[0];
    foreach (var item in array)
    {
        if (item % 2 != 0)
        {
            oddArray = AddItemToArray(oddArray, item);
        }
    }
    return oddArray;
}

static void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(" ", array));
}

static void PrintEvenNumbers(int[] array)
{
    Console.WriteLine(string.Join(" ", array));

}

static void PrintOddNumbers(int[] array)
{
    Console.WriteLine(string.Join(" ", array));

}

static void PrintLowestValue(int[] evenArray, int[] oddArray)
{
    var lowestEvenValue = LowestValueFromAnArray(evenArray);

    var lowestOddValue = LowestValueFromAnArray(oddArray);

    if (lowestEvenValue < lowestOddValue)
    {
        Console.WriteLine("Even Array har lägsta värde: " + lowestEvenValue);
    }
    else
    {
        Console.WriteLine("Odd Array har lägsta värde: " + lowestOddValue);
    }

}

static int LowestValueFromAnArray(int[] array)
{
    int lowest = int.MaxValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < lowest)
        {
            lowest = array[i];

        }
    }
    return lowest;

}

static void PrintHighestValue(int[] evenArray, int[] oddArray)
{
    var highestEvenValue = HighestValueFromAnArray(evenArray);
    var highestOddValue = HighestValueFromAnArray(oddArray);

    if (highestEvenValue > highestOddValue)
    {
        Console.WriteLine("Even Array har högsta värde: " + highestEvenValue);
    }
    else
    {
        Console.WriteLine("Odd Array har högsta värde: " + highestOddValue);
    }

}

static int HighestValueFromAnArray(int[] array)
{
    int highest = int.MinValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > highest)
        {
            highest = array[i];
        }
    }

    return highest;
}

static void PrintHighestAverageArray(int[] evenArray, int[] oddArray)
{
    var averageValueInEvenArray = HighestAverageValueFromArray(evenArray);
    var averageValueFromOddArray = HighestAverageValueFromArray(oddArray);

    if (averageValueInEvenArray > averageValueFromOddArray)
    {
        Console.WriteLine("Even Array har högsta medelvärde: " + averageValueInEvenArray);
    }
    else
    {
        Console.WriteLine("Odd Array har högsta medelvärde: " + averageValueFromOddArray);
    }



}

static int HighestAverageValueFromArray(int[] array)
{
    int total = 0;
    foreach (var item in array)
    {
        total += item;
    }

    int average = total / array.Length;

    return average;
}
