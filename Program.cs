// See https://aka.ms/new-console-template for more information
string[] cibipreferiti = { "pizza, ", "carbonara, " , "sushi, ", "polpette e ","bistecca " };
Console.WriteLine(cibipreferiti.Length);
Console.WriteLine("Questi sono i miei 5 cibi preferiti!");
for (int i = 0; i < cibipreferiti.Length; i++)
{
    Console.Write(cibipreferiti[i]);
}
Console.WriteLine("questo è il mio cibo primo in preferito");
Console.Write(cibipreferiti[0]);
Console.WriteLine("questo è il mio cibo preferito ultimo in classifica");
Console.Write(cibipreferiti[4]);