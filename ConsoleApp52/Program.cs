//int[,] king = new int[3, 3]
//{
//    {3,5,7 },
//    {1,9,2 },
//    {4,8,0 }
//};
//int sum = 0;
//for ( int i = 0; i < king.GetLength(0); i++)
//{
//    for ( int l = 0; l < king.GetLength(1); l++)
//    { 
//        if (i > l)
//        {
//            Console.WriteLine(king[i, l]);
//            sum += king[i, l];
//        }

//    }
//}
//    Console.WriteLine(sum);


int[,] gold = new int[3, 2]
{
    {2,5 },
    {9,0 },
    {3,6 }
};
int sum = 0;
int newArray = 1;
{
    for (int f = 0; f < gold.GetLength(0); f++)
    {
        for (int h = f + 1; h < gold.GetLength(1); h++)
        {
            if (h == 0)
            {
                sum += gold[f, 0];
                sum = newArray;
            }
        }
    }
              
}


//int[,] coin = new int[5, 5]
//{
//    {1,2,3,4,5 },
//    {5,4,3,2,1 },
//    {6,7,8,9,0 },
//    {0,9,8,7,6 },
//    {5,6,7,4,8 }
//};
//int zero = 0;
//for ( int k = 0; k < coin.GetLength(0); k++)
//{
//    for ( int j = 0; j < coin.GetLength(1); j++)
//    {
//     if (k > j)
//        {
//            coin[k, j] = zero;
//            Console.WriteLine(zero);
//        }
//    }
//}