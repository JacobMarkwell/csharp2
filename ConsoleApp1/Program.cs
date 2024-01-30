using System;

class MainClass {
  public static void Main (string[] args) {

    string A = "A";
    string B = "B";
    string  C = "C";
    string  D = "D";
    string  F = "F";
    Console.WriteLine("Please input a  Capital letter grade");
    string grade = Console.ReadLine();
     if(grade == A) {
        Console.WriteLine("4");
     }  
     else if(grade == B){
        Console.WriteLine("3");
     }
     else if(grade == C){
        Console.WriteLine("2");
    }
    else if(grade == D){
        Console.WriteLine("1");
    }
    else if(grade == F){
        Console.WriteLine("0");
    }
  }

    }
