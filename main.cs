// Created by: Mark Palfi
// Created on: Mar 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        string firstName;
        int age;

        Console.WriteLine("This program gets a user's name and age.");
        Console.WriteLine("");

        Console.Write("Enter your first name: ");
        firstName = Console.ReadLine();
        Console.Write("Enter your age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Your info is: " + firstName + ", age " + age + ".");

        Console.WriteLine("\nDone.");
    }
}