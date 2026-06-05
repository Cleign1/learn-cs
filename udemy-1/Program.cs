// See https://aka.ms/new-console-template for more information
string[] names;

names = ["Ibnu", "Kevin", "Cleign", "Yata", "Yudha", "Reza"];

Random.Shared.Shuffle(names);

for (int i = 0; i < names.Length; i++)
{
  Console.WriteLine(names[i]);
}