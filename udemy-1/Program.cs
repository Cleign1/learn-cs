// See https://aka.ms/new-console-template for more information
int MultiplyTwoValues(int a, int b)
{
    int result = a * b;
    return result;
}
Console.WriteLine("Masukkan nilai pertama: , Saya akan menggandakannya");
int value1 = int.Parse(Console.ReadLine() ?? "0");
int multiplicationResult = MultiplyTwoValues(value1, 2);
Console.WriteLine($"Hasil penggandaan: {multiplicationResult}");