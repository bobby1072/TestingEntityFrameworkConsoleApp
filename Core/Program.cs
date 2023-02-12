using Core;
using Microsoft.EntityFrameworkCore;
using System.Reflection.PortableExecutable;
using Microsoft.EntityFrameworkCore;
static class Program
{
    public static void Main()
    {
        using (var db = new BlogDbContext())
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add account \n2. Deposit \n3. Withdraw \n\n");
                var option = Console.ReadLine();
                int choice;
                if (!string.IsNullOrEmpty(option) && int.TryParse(option, out choice))
                {
                    Console.Clear();
                    Console.WriteLine("Enter your name please: \n\n");
                    var accountName = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Enter Amount: \n\n");
                    var balance = Console.ReadLine();
                    float floatBala;
                    if (!string.IsNullOrEmpty(accountName) && !string.IsNullOrEmpty(balance) && float.TryParse(balance, out floatBala))
                    {
                        if (choice == 1)
                        {
                            var account = new Account(accountName, floatBala);
                            db.accounts.Add(new DbAccount { account_name = account.Name, balance = account.Balance });
                            db.SaveChanges();
                            Console.WriteLine("Account Added");
                        }
                        else if (choice == 2)
                        {

                            var dbAccount = db.accounts.Where(a => a.account_name == accountName).FirstOrDefault();
                            dbAccount.balance += floatBala;
                            db.SaveChanges();
                        }
                        else if (choice == 3)
                        {
                            var dbAccount = db.accounts.Where(a => a.account_name == accountName).FirstOrDefault();
                            dbAccount.balance -= floatBala;
                            db.SaveChanges();
                        }
                        Thread.Sleep(3000);
                    }
                }
            }
        }
    }
}