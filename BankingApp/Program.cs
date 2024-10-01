﻿/*
 * Classname : BankingApp
 * Inforamtion : Logical operators demo 
 * Version 1
 * Author : Dr Eliza Ann Benoy
 * Date : October 2024
 */

// Call Th w Banking App method to begin application
BuildBankingApp();

void BuildBankingApp()
     

{
    int choice;
    double depositAmount;
    double withdrawalAmount;
    double accountBalance = 1000.00;

    // Display the main menu screen 
    Console.WriteLine("Please choose an option");
    Console.WriteLine("=======================");
    Console.WriteLine("1- deposit or withdraw funds");
    Console.WriteLine("2- View current account information");
    Console.WriteLine("Please choose an option(1-2)");



     choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1 || choice == 2)
    {
        Console.WriteLine("Please choose an option");
        Console.WriteLine("1- Deposit funds ");
        Console.WriteLine("2- Withdraw funds");
        Console.WriteLine("Please choose an option (1-2)");

        choice = Convert.ToInt32(Console.ReadLine());

    }
    if (choice ==1)
    {
        Console.WriteLine("How much do you want to deposit?");
        Console.WriteLine("Enter amount including pence using a decimal point");
        

        depositAmount = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("The original balance was {0}", accountBalance);

        accountBalance += depositAmount;
        Console.WriteLine("The new balance is now {0}", accountBalance);


    }
    if (choice == 2)
    {

    
        Console.WriteLine("How much do you want to withdraw from account?");
        Console.WriteLine("Enter amount including pencepence usind a decimal point ");
        withdrawalAmount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The original balance was {0}", accountBalance);

        accountBalance -= withdrawalAmount;
        Console.WriteLine("the new balance for account is {0}",accountBalance);

    }
    else
    {
        Console.WriteLine("Please choose a valid menu option between 1-2 ");
    }
}
