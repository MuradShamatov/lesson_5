
void Find_sum_column (int [,] matr){
    for (int j = 0; j< matr.GetLength(1); j++)
    {
        int sum = 0;
        for(int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i,j]; 
        }
        Console.WriteLine($"Nashli summu {j}: {sum}");
    } 
}

int [,] matrix = {
    {4, 335, 632, 44},
    {5, 46, 2, 77},
    {849, 55, 34, 1}
};


Find_sum_column(matrix);