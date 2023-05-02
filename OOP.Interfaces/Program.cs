using OOP.Interfaces;

var Saver = new ServerAccount();

Saver.PayIn(500);
Console.WriteLine(Saver);
Saver.Withdraw(600);