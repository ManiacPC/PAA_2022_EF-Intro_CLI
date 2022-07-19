using PAA_2022_EF_Intro.Models;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using (EFContext db = new EFContext())
{
    db.Canciones.ToList().ForEach(c => Console.WriteLine(c.Titulo));
}