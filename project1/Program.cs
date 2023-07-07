using System.Text.Json.Serialization;
using System.Transactions;

//int i, j;

//int[,] arr1 = new int[3,3];
//int[,] arr2 = new int[3,3];

//Console.WriteLine("Matrix 1");
//for (i = 0; i < 3; i++)
//{
//    for (j = 0; j < 3; j++)
//    {
//        Console.Write("Enter Value in matrix : ");
//        arr1[i,j]=Convert.ToInt32(Console.ReadLine());
//    }
//}

////printing matrix

//Console.WriteLine("Matrix 3X3");
//for (i = 0; i < 3; i++)
//{
//    for (j = 0; j < 3; j++)
//    {
//        Console.Write(arr1[i,j]+", "); ;
//    }
//    Console.WriteLine();
//}


//Console.WriteLine();
////printing square of matrix
//Console.WriteLine("Square of Matrix-1 3X3");
//for (i = 0; i < 3; i++)
//{
//    for (j = 0; j < 3; j++)
//    {
//        Console.Write(arr1[i, j] * arr1[i,j] + ", ");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine();
//Console.Write("Matrix-2");
//for (i = 0; i < 3; i++)
//{
//    for (j = 0; j < 3; j++)
//    {
//        Console.Write("Enter Value in matrix 2: ");
//        arr2[i, j] = Convert.ToInt32(Console.ReadLine());
//    }
//}

//Console.WriteLine("Matrix-2 3X3");
//for (i = 0; i < 3; i++)
//{
//    for (j = 0; j < 3; j++)
//    {
//        Console.Write(arr1[i, j] + arr2[i,j] + ", ");
//    }
//    Console.WriteLine();
//}


int[][] j_arr1 = new int[3][];
int[][] j_arr2 = new int[2][];

j_arr1[0] = new int[1] {1};
j_arr1[1] = new int[2] {1,2};
j_arr1[2] = new int[3] {1,2,3};

j_arr2[0] = new int[2];
j_arr2[1] = new int[1];


for (int i = 0; i < j_arr1.Length; i++)
{
    for (int j = 0; j < j_arr1[i].Length; j++)
    {
        Console.Write(j_arr1[i][j]);
    }
    for (int k = 0;  k < j_arr2[i].Length; k++)
    {
        Console.Write(j_arr2[i][k]);
    }
    Console.WriteLine();
}