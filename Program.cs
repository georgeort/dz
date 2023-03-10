//1
void task1(int m, int n, int begin, int end){
    Random random = new Random();
    float[,] matrix = new float[m,n];
    for (int i = 0; i < m; i++){
        for(int i1 = 0; i1< n; i1++){
            float newElement = (float)random.NextDouble() * (end - begin) + begin;
            matrix[i,i1] = (float)Math.Round(newElement, 1);
            Console.Write($"{matrix[i,i1]} ");
        }
        Console.WriteLine();
    }
}
task1(3,4,-3,2);
//2
void task2(int m, int n, int begin, int end){
    Random random = new Random();
    float[,] matrix = new float[m,n];
    for (int i = 0; i < m; i++){
        for(int i1 = 0; i1< n; i1++){
            float newElement = (float)random.NextDouble() * (end - begin) + begin;
            matrix[i,i1] = (float)Math.Round(newElement, 1);
            Console.Write($"{matrix[i,i1]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Ведите строку ");
    int str = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" Ведите строку ");
    int col = Convert.ToInt32(Console.ReadLine());
    if (str > m || str <= 0 || col > n || col <= 0){
        Console.WriteLine("такого числа в массиве нет");
    }else{
        Console.WriteLine($"{matrix[str-1,col-1]}");
    }
}
task2(3,4,-3,2);
//3
void task3(int m, int n, int begin, int end){
    Random random = new Random();
    float[,] matrix = new float[m,n];
    float[] midle = new float[m];
    float midleCounter = 0;
    for (int i = 0; i < m; i++){
        for(int i1 = 0; i1< n; i1++){
            float newElement = (float)random.NextDouble() * (end - begin) + begin;
            matrix[i,i1] = (float)Math.Round(newElement, 1);
            Console.Write($"{matrix[i,i1]} ");
            midle[i]+=matrix[i,i1];
            midleCounter++;
        }
        midle[i] /= midleCounter;
        Console.WriteLine();
    }
    for (int i = 0; i < m; i++){
        Console.Write($"{midle[i]} ");}
    Console.WriteLine();
}
task3(1,2,-3,2);