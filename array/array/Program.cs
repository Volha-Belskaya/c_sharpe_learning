
        Console.WriteLine("enter the number of array elements");
        int elementsCount = int.Parse(Console.ReadLine());
        int[] array = new int[elementsCount];
       Random rand = new();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next()%1000;
        }
        for (int a=0; a<elementsCount; a++)
{
  Console.WriteLine("output elements of array " + array[a]);
}
      

for (int i = 0; i < array.Length; i++)
{
    //Console.WriteLine("My current i: " + array[i]);
    for (int j = i + 1; j < array.Length; j++)
        if (array[i] > array[j])
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
}

for (int a = 0; a < elementsCount; a++)
{
    Console.WriteLine("output sorting elements " + array[a]);
}

