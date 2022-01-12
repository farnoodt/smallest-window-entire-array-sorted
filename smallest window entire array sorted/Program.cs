// See https://aka.ms/new-console-template for more information
int[] A = { 1, 3, 2, 7, 5, 6, 4, 8 };
findSubarray(A);


static void findSubarray(int[] A)
{
    int left = -1;
    int right = -1;
    int SoFar = int.MinValue;

    for (int i = 0; i < A.Length; i++)
    {
        if (A[i] > SoFar)
            SoFar = A[i];

        if (A[i] < SoFar)
            right = i;
    }

    SoFar = int.MaxValue;
    for (int i = A.Length-1; i >= 0; i--)
    {
        if (SoFar > A[i])
            SoFar = A[i];

        if (SoFar < A[i])
            left = i;
    }

    if(left ==-1)
        Console.WriteLine("Sorted");

    Console.WriteLine(left+ " " + right) ;

}