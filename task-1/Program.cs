
void Show_big (int [,] matr){
    for (int i = 0; i< matr.GetLength(0); i++)
    {
        int max = matr[i,0];
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            if(matr[i,j] > max)
            {
                max = matr[i,j];
            }
            

        }
        Console.WriteLine($"Nashli max znachv  stroke {i}: {max}");
    } 


}

int [,] matrix = {
    {4, 335, 632, 44},
    {5, 46, 2, 77},
    {849, 55, 34, 1}
};


Show_big(matrix);