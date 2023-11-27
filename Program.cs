// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int age = 35;
//age = "thirty five";// cant do this

string name = "michael";
//Console.WriteLine($"your name is  {name} and you're {age} years old");
try {
BankAccount newAccount = new BankAccount("Michael",100.99);

//newAccount.Balance = 100.99;
//newAccount.Balance = newAccount.Balance + 100;


Console.WriteLine($"{newAccount.OwnersName} balance is {newAccount.getBalance()}");
} catch (Exception err) {
    Console.WriteLine($" you got an error: {err.Message}");
}