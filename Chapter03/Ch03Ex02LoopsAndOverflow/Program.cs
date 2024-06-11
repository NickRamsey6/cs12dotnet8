int max = 500;
// Adding the checked block around the existing code will throw the overflow exception when the max of i is exceeded
checked
{
    for (byte i = 0; i < max; i++)
    {
        Console.WriteLine(i);
    }
}
