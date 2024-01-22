// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, foreach!");

List<string> listeChaines = new List<string>();
listeChaines.Add("Bonjour ");
listeChaines.Add("à ");
listeChaines.Add("tous");

for(int i = 0; i < listeChaines.Count; i++)
{
    Console.WriteLine(listeChaines[i]);
}

foreach(string chaine in listeChaines)
{
    Console.Write(chaine);
}