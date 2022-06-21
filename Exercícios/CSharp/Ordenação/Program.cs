class PassingRefByVal
{
    static void Change(int[] pArray)
    {
        pArray[0] = 888;  // Mudar o primeiro elemento do array
    }

    static void Main()
    {
        int[] arr = {1, 4, 5};
        Console.WriteLine("primeiro numero antes: "+arr[0]);
        Change(arr);
        Console.WriteLine("primeiro numero depois: {0}", arr [0]);
    }
}