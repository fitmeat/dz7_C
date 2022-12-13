void CreateMatrix(int[,] matrix)
{
    for(int i = 0; i<matrix.GetLength(0); i++){
        for(int j = 0; j<matrix.GetLength(1); j++){
            matrix[i,j] = new Random().Next(-10,11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void FindElement(int[,] matrix, int mElement, int nElement)
{
    int count = 0;
    for(int i = 0; i<matrix.GetLength(0); i++){
         for(int j = 0; j<matrix.GetLength(1); j++){
            if(i == mElement && j == nElement){
                Console.WriteLine($"Элемент на вашей позиции: {matrix[i,j]}");
                count++;
            } 
         }
    }
    if(count == 0) Console.WriteLine("Такой позиции нет");
}

Console.Clear();
Console.WriteLine("Введите m (количество строк): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n (количество столбцов): ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m,n];
CreateMatrix(arr);
Console.WriteLine("Введите позицию элемента! ");
Console.WriteLine("m: ");
int mElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("n: ");
int nElement = Convert.ToInt32(Console.ReadLine());
FindElement(arr, mElement, nElement);