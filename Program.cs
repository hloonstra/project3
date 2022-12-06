// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Runtime.InteropServices;
Console.OutputEncoding = System.Text.Encoding.UTF8;


//List<FlowerBox> FlowerBoxes = new List<FlowerBox>();
List<Customer> Customeres = new List<Customer>();
List<HomeAdress> Adresses= new List<HomeAdress>();
FlowerBox bak;
Customer klant;
HomeAdress adres;

int klantnummer = 1;
bool loop = true;

while (loop)
{
    int userInput;
    Console.WriteLine(Menu.menu());
    string input = Console.ReadLine();

    if (int.TryParse(input, out userInput))
    {
        switch (userInput)
        {
        case 1:

                Console.Clear();
                try
                {
                    klant = new Customer();
                    adres = new HomeAdress();
                    Console.WriteLine("Wat is de voornaam:");
                    klant.Firstname = Console.ReadLine();
                    Console.WriteLine("Wat is de laatstenaam:");
                    klant.Lastname = Console.ReadLine();
                    Console.WriteLine("Wat is de Invoeging:");
                    klant.Insertion = Console.ReadLine();
                    Console.WriteLine("Wat is de adres:");
                    adres.Address = Console.ReadLine();
                    Console.WriteLine("Wat is de stad:");
                    adres.City = Console.ReadLine();
                    Console.WriteLine("Wat is de postcode:");
                    adres.Postalcode = Console.ReadLine();
                    Customeres.Add(klant);
                    Adresses.Add(adres);
                    klant.Adress = adres;
                    Console.Clear();


                    Console.WriteLine(@"Welke vorm wilt u gebruiken:
1- Balk.
2- Kubus.
3- Cilinder.");
                    int vormInput = int.Parse(Console.ReadLine());
                    switch (vormInput)
                    {
                        case 1:

                            Console.WriteLine("Wat is de lengte van de product?");
                            int length = int.Parse(Console.ReadLine());
                            Console.WriteLine("Wat is de breedte van de product?");
                            int width = int.Parse(Console.ReadLine());
                            Console.WriteLine("Wat is de hoogte van de product?");
                            int height = int.Parse(Console.ReadLine());
                            bak = new FlowerBox(length, width, width);
                            Order.FlowerBoxList.Add(bak);
                            klantnummer++;
                            Console.Clear();
                            break;

                        case 2:

                            Console.WriteLine("Wat is de zijde van de product?");
                            int flank = int.Parse(Console.ReadLine());
                            bak = new FlowerBox(flank);
                            Order.FlowerBoxList.Add(bak);
                            klantnummer++;
                            Console.Clear();
                            break;

                        case 3:

                            Console.WriteLine("Wat is de diameter van de product?");
                            int diameter = int.Parse(Console.ReadLine());
                            Console.WriteLine("Wat is de hoogte van de product?");
                            height = int.Parse(Console.ReadLine());
                            bak = new FlowerBox(diameter, height);
                            Order.FlowerBoxList.Add(bak);
                            klantnummer++;
                            Console.Clear();
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Kies graag tussen (1(Balk), 2(Kubus), 3(Cilinder))");
                            Console.WriteLine("druk op enter om terug naar het menu.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }

                }
                catch (ArgumentException ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("druk op enter om terug naar het menu.");
                    Console.ReadKey();
                    Console.Clear();
                }

                break;

            case 2:
                Console.Clear();
                for (int i = 1; i < klantnummer; i++)
                {
                    Console.WriteLine($"De gegevens van klant {Customeres[i -1].Firstname} {Customeres[i - 1].Lastname}");
                    Console.WriteLine(Customeres[i - 1].PrintCustomer());
                    Console.WriteLine($"De afmetingen zijn:");
                    Console.WriteLine(FlowerBoxes[i - 1].PrintFlowerBox());
                }

                Console.WriteLine("druk op enter om terug naar het menu.");
                Console.ReadKey();
                Console.Clear();
                break;

            case 3:
                Console.Clear();
                Console.WriteLine("Wilt u graag de prijs met potgrond of zonder kies (j/n)");
                string antwoord = Console.ReadLine();
                Console.Clear();
                for (int y = 0; y < FlowerBoxes.Count(); y++)
                {
                    if (antwoord.ToLower() == "j")
                    {
                        Console.WriteLine($"De prijzen van klant {y + 1}");
                        Console.WriteLine($@"prijs Met potgrond : {FlowerBoxes[y].Price(true).ToString("c")}");
                    }
                    else if (antwoord.ToLower() == "n")
                    {
                        Console.WriteLine($"De prijzen van klant {y + 1}");
                        Console.WriteLine($@"Prijs zonder potgrond: {FlowerBoxes[y].Price(false).ToString("c")}");
                    }
                    else
                    {
                        Console.WriteLine("Kies graag tussen j voor ja of n voor nee.");
                        break;
                    }

                }
                Console.WriteLine("druk op enter om terug naar het menu.");
                Console.ReadKey();
                Console.Clear();
                break;

            case 4:
                Console.Clear();
                for (int i = 1; i < klantnummer; i++)
                {
                    Console.WriteLine($"De inhoud van de plantenbak voor klant {i}");
                    Console.WriteLine($"{FlowerBoxes[i - 1].Volume()} cm3");
                }

                Console.WriteLine("druk op enter om terug naar het menu.");
                Console.ReadKey();
                Console.Clear();
                break;

            case 5:
                Console.Clear();
                for (int i = 1; i < klantnummer; i++)
                {
                    Console.WriteLine($"De opervlakte van de plantenbak voor klant {i}");
                    Console.WriteLine($"{FlowerBoxes[i - 1].Surface()} cm2");
                }

                Console.WriteLine("druk op enter om terug naar het menu.");
                Console.ReadKey();
                Console.Clear();
                break;

            case 6:
            case 7:
                loop = false;
                break;
            default:
                Console.Clear();
                Console.WriteLine("Kies graag van het menu alleen.");
                Console.WriteLine("druk op enter om terug naar het menu.");
                Console.ReadKey();
                Console.Clear();
                break;

        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Gebruik graag geen letter allen cijfers.");
        Console.WriteLine("druk op enter om terug naar het menu.");
        Console.ReadKey();
        Console.Clear();
    }



}
