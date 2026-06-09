// See https://aka.ms/new-console-template for more information
// conditional based calculator
int[,] twoDimensional = {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
// sum of every row
for (int i = 0; i < twoDimensional.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < twoDimensional.GetLength(1); j++)
    {
        sum += twoDimensional[i, j];
    }
    Console.WriteLine($"Sum of row {i} is: {sum}");
}