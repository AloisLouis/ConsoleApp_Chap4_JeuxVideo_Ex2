namespace ConsoleApp_Chap4_JeuxVideo_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel est votre niveau?");
            int niveau = int.Parse(Console.ReadLine());

            Console.WriteLine("Quel est votre classe?");
            Console.WriteLine("G - Guerrier");
            Console.WriteLine("M - Mage");
            Console.WriteLine("R - Rogue");
            string classe = Console.ReadLine();

            Console.WriteLine("Combien de quêtes héroïques avez-vous accomplies?");
            int quetes = int.Parse(Console.ReadLine());

            if (classe == "G" || classe == "M" || classe == "R")
            {
                if (niveau < 10)
                {
                    Console.WriteLine("Novice");
                }

                else if (niveau >= 10 && niveau <= 20)
                {
                    if (quetes >= 5)
                    {
                        Console.WriteLine("Adepte");
                    }
                    else
                        Console.WriteLine("Apprenti assermenté");
                }
                else if (niveau > 20 && niveau < 30)
                {
                    if (classe == "G" || classe == "R")
                    {
                        Console.WriteLine("Vétéran");
                    }
                    else if (classe == "M" && niveau >= 25)
                    {
                        Console.WriteLine("Vétéran");
                    }
                    else
                    {
                        Console.WriteLine("Adepte");
                    }
                }
                else if (niveau >= 30 && quetes > 20)
                {
                    if (classe == "G" || classe == "M")
                    {
                        Console.WriteLine("Maître de Guilde");
                    }
                    else if (classe == "R")
                    {
                        Console.WriteLine("Vous devez passer un examen spécial pour devenir Maître de Guilde");
                    }
                    else
                    {
                        Console.WriteLine("Vétéran");
                    }
                }
                else
                {
                    Console.WriteLine("Statut Indéterminé");
                }
            }
            else
            {
                Console.WriteLine("Hors-la-loi");
            }
        }
    }
}
