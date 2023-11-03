int[] arr = {-12, -29, -33, -56, -70, -84};
int[] result = line(ref arr);

foreach (int i in result)
{
    Console.Write(i + " "); 
}

int [] line (ref int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
       arr[i]*=(-1);
    }
return arr;
}

