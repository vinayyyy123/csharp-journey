//Console Basic
using System;
using System.Reflection;
using System.Security.Cryptography;
using System.Xml.Linq;
namespace PascalCase
{
    class Program
    {
        static void Main(string[] args)
        {

            // ====================
            // Day 1 Console WriteLine
            // ====================

            //Exercise 1 - Introduction

            Console.WriteLine("Hello World");
            Console.WriteLine();

            Console.WriteLine("My Name is Vinay");
            Console.WriteLine();

            Console.WriteLine("I am Learning C#");
            Console.WriteLine();


            //OutPut:

            //Hello World

            //My Name is Vinay

            //I am Learning C#



            //Exercise 2 - Personal Card

            Console.WriteLine("============================");
            Console.WriteLine();

            Console.WriteLine("Name: Vinay Lodhi");
            Console.WriteLine();

            Console.WriteLine("City: Mumbai");
            Console.WriteLine();

            Console.WriteLine("Role: Web Devloper");
            Console.WriteLine();

            Console.WriteLine("============================");
            Console.WriteLine();

            //OutPut:

            //====================

            //NAME : VINAY LODHI

            //CITY: VADODARA

            //ROLE : SOFTWARE DEVELOPER

            //====================


            //Exercise 3 - Learning Goals

            Console.WriteLine("MY LEARNING GOALS ");
            Console.WriteLine();

            Console.WriteLine("1.Learn C#");
            Console.WriteLine("2.Learn OOP");
            Console.WriteLine("3.Learn ASP.NET Core");
            Console.WriteLine("4.Build Projests");
            Console.WriteLine("5.Become Better Developer");
            Console.WriteLine("============================");
            Console.WriteLine();

            //OutPut:

            // MY LEARNING GOALS

            //1.Learn C#
            //2.Learn OOP
            //3.Learn ASP.NET Core
            //4.Build Projects
            //5.Become Better Developer

            //Exercise 4 - Favorite Things
            Console.WriteLine("MY FAVORITES");
            Console.WriteLine();

            Console.WriteLine("Food: Pizza");
            Console.WriteLine("Color : Orange");
            Console.WriteLine("City  : Vadodara");
            Console.WriteLine("Sport : Cricket");
            Console.WriteLine("============================");
            Console.WriteLine();

            //OutPut:

            //MY FAVORITES

            //Food: Pizza
            //Color : Orange
            //City  : Vadodara
            //Sport : Cricket


            //Exercise 5 - C# Journey Banner
            Console.WriteLine("*************************");
            Console.WriteLine();

            Console.WriteLine("C# JOURNEY");
            Console.WriteLine();

            Console.WriteLine("*************************");
            Console.WriteLine();

            Console.WriteLine("Day : 1");
            Console.WriteLine();

            Console.WriteLine("Topic Covered");
            Console.WriteLine();

            Console.WriteLine("- Console Application");
            Console.WriteLine("- Program.cs");
            Console.WriteLine("- Namespace");
            Console.WriteLine("- Class");
            Console.WriteLine("- Main Method");
            Console.WriteLine("- Statement");
            Console.WriteLine();

            Console.WriteLine("*************************");
            Console.WriteLine();

            //OutPut

            //********************************

            //C# JOURNEY

            //* *******************************

            //Day : 1

            //Topic Covered

            //- Console Application
            //- Program.cs
            //- Namespace
            //- Class
            //- Main Method
            //- Statement

            //* *******************************

            //Exercise 6 - Dream Company

            Console.WriteLine("MY DERAMS");
            Console.WriteLine();

            Console.WriteLine("I want to beacome a skilled C# Developer.");
            Console.WriteLine();

            Console.WriteLine("I want to build real world applications.");
            Console.WriteLine();

            Console.WriteLine("I want to master ASP.NET Core.");
            Console.WriteLine();

            Console.WriteLine("I will practice every day");
            Console.WriteLine("============================");
            Console.WriteLine();

            //OutPut

            //MY DREAMS

            //I want to become a skilled C# Developer.

            //I want to build real world applications.

            //I want to master ASP.NET Core.

            //I will practice every day.



            //Excercise Bonus Challenge ⭐

            Console.WriteLine("================================================");
            Console.WriteLine();

            Console.WriteLine("MY PROFILE");
            Console.WriteLine();

            Console.WriteLine("=================================================");
            Console.WriteLine();


            Console.WriteLine("Name     : Vinay Lodhi");
            Console.WriteLine();

            Console.WriteLine("City     : Vadodara");
            Console.WriteLine();

            Console.WriteLine("Language : C#");
            Console.WriteLine();

            Console.WriteLine("Goal     : Become ASP.NET Core Developer");
            Console.WriteLine();

            Console.WriteLine("================================================");



            //OutPut

            //================================================

            //MY PROFILE

            //================================================

            //Name     : Vinay Lodhi

            //City     : Vadodara

            //Language : C#

            //Goal     : Become ASP.NET Core Developer

            //================================================


            // ====================
            // Day 2 - Variables
            // ====================

            //Exercise 1 - Personal Information

            //Create Variables For

            //Name
            //Age
            //City
            //Profession

            string name = "Vinay";
            int age = 24;
            string city= "Vadodara";
            string Profession = "Software Developer";

            Console.WriteLine("MY INFORMATION");
            Console.WriteLine();

            Console.WriteLine("Name : " + name);
            Console.WriteLine();

            Console.WriteLine("Age : " + age);
            Console.WriteLine();

            Console.WriteLine("City : " + city);
            Console.WriteLine();

            Console.WriteLine("Profession : " + Profession);
            Console.WriteLine("============================");
            Console.WriteLine();
            //OutPut

            //MY INFORMATION

            //Name: Vinay

            //Age : 25

            //City: Vadodara

            //Profession : Software Developer


            //Exercise 2 - Student Profile

            //Create Variables For

            //Student Name
            //Roll Number
            //Course
            //College


            string name1 = "Rahul";
            int Roll_No = 101;
            string course = "MCA";
            string collage = "CNC COllage";

            Console.WriteLine("STUDENT PROFILE");
            Console.WriteLine();

            Console.WriteLine("Name : " + name1);
            Console.WriteLine();

            Console.WriteLine("Roll No : " + Roll_No);
            Console.WriteLine();

            Console.WriteLine("Course : " + course);
            Console.WriteLine();

            Console.WriteLine("Collage : " + collage);
            Console.WriteLine("============================");
            Console.WriteLine();

            //OutPut

            //STUDENT PROFILE

            //Name: Rahul

            //Roll No: 101

            //Course: MCA

            //College : XYZ College


            //Exercise 3 - Movie Details

            //Create Variables For

            //Movie Name
            //Hero Name
            //Release Year
            //Rating


            string movie = "Pushpa";
            string hero = "Allu Arjun";
            int year = 2024;
            int rating = 9;

            Console.WriteLine("MOVIE DETAILS");
            Console.WriteLine();
            Console.WriteLine("Movie : " + movie);
            Console.WriteLine();

            Console.WriteLine("Hero : " + hero);
            Console.WriteLine();

            Console.WriteLine("Year : " + year);
            Console.WriteLine();

            Console.WriteLine("Rating : " + rating); ;
            Console.WriteLine("============================");
            Console.WriteLine();

            //Output

            //MOVIE DETAILS

            //Movie : Pushpa

            //Hero : Allu Arjun

            //Year: 2024

            //Rating: 9


            //Exercise 4 - Mobile Information

            //Create Variables For

            //Brand
            //Model
            //Price
            //Storage

            string brand = "Samsung";
            string model = "S24";
            int price = 70000;
            string storage = "256GB";


            Console.WriteLine("MOBILE DETAILS");
            Console.WriteLine();

            Console.WriteLine("Brand : " + brand);
            Console.WriteLine();

            Console.WriteLine("Model : " + model);
            Console.WriteLine();

            Console.WriteLine("Price : " + price);
            Console.WriteLine();

            Console.WriteLine("Storage : " + storage);
            Console.WriteLine("============================");
            Console.WriteLine();

            //OutPut

            //MOBILE DETAILS

            //Brand: Samsung

            //Model : S24

            //Price : 70000

            //Storage: 256GB



            //Exercise 5 - Company Profile

            //Create Variables For

            //Company Name
            //Location
            //Employee Count
            //Industry

            string name2 = "L&T Energy Hydrocarbon";
            string location = "Mumbai";
            int employees = 500;
            string industry = "IT";

            Console.WriteLine("COMPANY PROFILE");
            Console.WriteLine();

            Console.WriteLine("Company : " + name2);
            Console.WriteLine();

            Console.WriteLine("Location : " + location);
            Console.WriteLine();

            Console.WriteLine("Employees : " + employees);
            Console.WriteLine();

            Console.WriteLine("Industry : " + industry);
            Console.WriteLine("============================");
            Console.WriteLine();

            //OutPut

            //COMPANY PROFILE

            //Company: ABC Ltd

            //Location: Mumbai

            //Employees : 500

            //Industry: IT



            //Exercise 6 - My Learning Journey

            //Create Variables For

            //Name
            //Language
            //DayNumber
            //Goal

            string name3 = "Vinay";
            string language = "C#";
            int day = 2;
            string goal = "ASP.NET Core Developer";

            Console.WriteLine("MY LEARNING JOURNEY");
            Console.WriteLine();

            Console.WriteLine("Name : " + name3);
            Console.WriteLine();

            Console.WriteLine("Language : " + language);
            Console.WriteLine();

            Console.WriteLine("Day : " + day);
            Console.WriteLine();

            Console.WriteLine("Goal : " + goal);
            Console.WriteLine("============================");
            Console.WriteLine();

            //OutPut

            //MY LEARNING JOURNEY

            //Name : Vinay

            //Language : C#

            //Day : 2

            //Goal: ASP.NET Core Developer




            //Challenge ⭐

            //Create variables for:

            //Favorite Food
            //Favorite Color
            //Favorite Sport
            //Favorite City
            //Favorite Actor


            string food = "Daal Chawal";
            string color = "Blue";
            string sport = "Cricket";
            string city2 = "Mumbai";
            string actor = "Hritik Roshan";


            Console.WriteLine("MY Favorite");
            Console.WriteLine();

            Console.WriteLine("Favorite Food : " + food);
            Console.WriteLine();

            Console.WriteLine("Favorite Color : " + color);
            Console.WriteLine();

            Console.WriteLine("Favorite Sport : " + sport);
            Console.WriteLine();

            Console.WriteLine("Favorite City : " + city2);
            Console.WriteLine();

            Console.WriteLine("Favorite Actor : " + actor);
            Console.WriteLine("============================");
            Console.WriteLine();


            // Day 3
            // Exercise 1 - Student Result

            // Create variables for:
            // Student Name
            // Age
            // Percentage
            // Grade
            // Pass Status

            string studentName = "Vinay";
            int studentAge = 24;
            double percentage = 85.5;
            char studentGrade = 'A';
            bool isPassed = true;

            Console.WriteLine("STUDENT RESULT\n");
            Console.WriteLine($"Name        : {studentName}\n");
            Console.WriteLine($"Age         : {studentAge}\n");
            Console.WriteLine($"Percentage  : {percentage}\n");
            Console.WriteLine($"Grade       : {studentGrade}\n");
            Console.WriteLine($"Pass Status : {isPassed}\n");

            // OutPut

            // STUDENT RESULT

            // Name : Rahul
            // Age : 21
            // Percentage : 85.5
            // Grade : A
            // Passed : True


            // Exercise 2 - Employee Details

            // Create variables for:
            // Name
            // Age
            // Salary
            // Grade
            // IsActive

            string employeeName = "Vinay Lodhi";
            int employeeAge = 24;
            decimal salary = 25000.20m; // 'decimal' is best practice for currency
            char employeeGrade = 'A';
            bool isActive = true;

            Console.WriteLine("======================");
            Console.WriteLine("Employee Details\n");
            Console.WriteLine($"Name     : {employeeName}\n");
            Console.WriteLine($"Age      : {employeeAge}\n");
            Console.WriteLine($"Salary   : {salary}\n");
            Console.WriteLine($"Grade    : {employeeGrade}\n");
            Console.WriteLine($"IsActive : {isActive}\n");

            // OutPut

            // ======================

            // Employee Details

            // Name : Vinay Lodhi

            // Age : 24

            // Salary : 25000.2

            // Grade : A

            // IsActive : True


            // Exercise 3 - Product Information

            // Create variables for:
            // Product Name
            // Quantity
            // Price
            // Category Code
            // Available

            string productName = "Donut";
            int quantity = 20;
            decimal productPrice = 200.25m;
            char categoryCode = 'A';
            bool isAvailable = true;

            Console.WriteLine("====================");
            Console.WriteLine("Product Information\n");
            Console.WriteLine($"Product Name  : {productName}\n");
            Console.WriteLine($"Quantity      : {quantity}\n");
            Console.WriteLine($"Price         : {productPrice}\n");
            Console.WriteLine($"Category Code : {categoryCode}\n");
            Console.WriteLine($"Available     : {isAvailable}\n");

            // OutPut

            // ====================
            // Product Information

            // Product Name : Donut

            // Quantity : 20

            // Price : 200.25

            // Category Code : A

            // Available : True


            // Exercise 4 - Cricket Player

            // Create variables for:
            // Player Name
            // Age
            // Batting Average
            // Team Initial
            // Is Captain

            string playerName = "Virat";
            int playerAge = 37;
            double battingAverage = 140.57;
            char teamInitial = 'A';
            bool isCaptain = false;

            Console.WriteLine("==================\n");
            Console.WriteLine("Player Information\n");
            Console.WriteLine($"Player Name     : {playerName}\n");
            Console.WriteLine($"Age             : {playerAge}\n");
            Console.WriteLine($"Batting Average : {battingAverage}\n");
            Console.WriteLine($"Team Initial    : {teamInitial}\n");
            Console.WriteLine($"Is Captain      : {isCaptain}\n");

            // OutPut

            // Player Information

            // Player Name : Virat

            // Age : 37

            // Batting Average : 140.57

            // Team Initial : A

            // IS Captain : False


            // Exercise 5 - Yourself

            // Create variables for:
            // Name
            // Age
            // Height
            // First Letter Of Name
            // Working

            string myName = "Vinay";
            int myAge = 24;
            double height = 5.8;
            char firstLetter = 'V';
            bool isWorking = true;

            Console.WriteLine("===================\n");
            Console.WriteLine("MY DETAILS\n");
            Console.WriteLine($"Name         : {myName}\n");
            Console.WriteLine($"Age          : {myAge}\n");
            Console.WriteLine($"Height       : {height}\n");
            Console.WriteLine($"First Letter : {firstLetter}\n");
            Console.WriteLine($"Working      : {isWorking}\n");

            // OutPut

            // MY DETAILS

            // Name : Vinay
            // Age : 24
            // Height : 5.8
            // First Letter : V
            // Working : True


            // Day 3 Memory Sheet
            // string -> Text

            // int -> Whole Number

            // double -> Decimal Number
            // decimal -> Financial / Money Values

            // char -> Single Character

            // bool -> True/False

            // Practice Rule

            // Is this text?
            // -> string

            // Is this whole number?
            // -> int

            // Is this decimal?
            // -> double (or decimal for money)

            // Is this one letter?
            // -> char

            // Is this Yes/No?
            // -> bool


        }
    }
}
