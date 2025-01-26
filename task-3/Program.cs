void Show_matrix (int [,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.Write("\n");
    }
}

int [,] Revers_matrix (int [,] matrix)
{
    int row = matrix.GetLength(0);
    int colum = matrix.GetLength(1);
    int [,] new1_matrix = new int [colum, row];

    for(int i = 0; i< matrix.GetLength(0); i++)
    {
        for (int j = 0; j< matrix.GetLength(1); j++)
        {
            new1_matrix[j,i] = matrix[i, j];
        }
    }

    return new1_matrix;

}

int [,] matrix = {
    {4, 335, 632, 44},
    {5, 46, 2, 77},
    {849, 55, 34, 1}
};

int [,] new_matrix = Revers_matrix(matrix);

Show_matrix (new_matrix);
