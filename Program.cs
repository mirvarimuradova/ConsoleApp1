string code = "1234";
decimal balance = 5;
//Girishde kos istesin
//  kod duzdurse balansi ekranda goster
// balansa baxmaq istese baxsin, artira ve ya azalda bilsin;
// 1.nagdlasdirma
// 2.medaxil
Label1:
Console.Write("Include your password: ");
string getpassword = Console.ReadLine();

if(code== getpassword)
{
    Console.WriteLine("Your Amount Is: " + balance);

    Console.WriteLine("Choose your currency: \n " +
        "1.AZN \n" +
       " 2.USD ");
    decimal azn = 1M;
    decimal usd = 1.7M;
    string choicecurrency = Console.ReadLine();
 if (choicecurrency == "1")
    {

        Console.WriteLine("Decrease y/n : ");
        string confirm = Console.ReadLine();
        if (confirm == "y")
        {
        Label2:
            Console.Write("Meblegi qeyd edin: ");
            decimal cash1 = decimal.Parse(Console.ReadLine());
            if (cash1 > balance)
            {

                Console.WriteLine("The amount is not true, please include true amount: ");
                goto Label2;

            }
            else
            {
                balance -= (cash1 * azn);
                Console.WriteLine("Your amount is decreased :" + balance);
                Console.ReadLine();
            }

        }

        else if (confirm == "n")
        {
            Console.Write("Do you want to increase the balance? (y/n): ");
            string increaseConfirm = Console.ReadLine();
            if (increaseConfirm == "y")
            {
                Console.Write("Enter the amount to increase: ");
                decimal cash = decimal.Parse(Console.ReadLine());
                balance += cash *azn;
                Console.WriteLine("Your new balance is: " + balance);
                Console.ReadLine();
            }
        }
      
    }
    else if (choicecurrency == "2")
    {
        Console.WriteLine("Decrease y/n : ");
        string confirm = Console.ReadLine();
        if (confirm == "y")
        {
        Label2:
            Console.Write("Meblegi qeyd edin: ");
            decimal cash1 = decimal.Parse(Console.ReadLine());
            if (cash1 > balance)
            {

                Console.WriteLine("The amount is not true, please include true amount: ");
                goto Label2;

            }
            else
            {
                balance -= (cash1 * usd);
                Console.WriteLine("Your amount is decreased :" + balance);
                Console.ReadLine();
            }

        }

        else if (confirm == "n")
        {
            Console.Write("Do you want to increase the balance? (y/n): ");
            string increaseConfirm = Console.ReadLine();
            if (increaseConfirm == "y")
            {
                Console.Write("Enter the amount to increase: ");
                decimal cash = decimal.Parse(Console.ReadLine());
                balance += (cash *usd);
                Console.WriteLine("Your new balance is: " + balance);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Emeliyyat tamamlandi : ");
                    Console.ReadLine();
            }
        }
    }
}

else
{
    Console.WriteLine(" Pin code is wrong!");
    goto Label1;
}


