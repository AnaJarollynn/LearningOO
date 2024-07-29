using TestProject4.Entities;

var acc = new Account(1001, "Alex", 500.0);
Account bacc = new SavingsAccount(1002, "Maria", 500.0, 0.01);

acc.Withdraw(10);
bacc.Withdraw(10);

Console.WriteLine(acc.Balance);
Console.WriteLine(bacc.Balance);

Console.WriteLine();