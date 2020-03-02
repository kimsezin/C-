using System;

class CoffeeMaker {
    public bool onState;
    public void StartCoffeeMaker() {
        if (onState==true)
            Console.WriteLine("The CoffeeMaker is already on.");
        else {
            onState=true;
            Console.WriteLine("The CoffeeMaker is now on.");
        }
    }
    public void Study_Array() {
        // int [] vector;
        // short[,] matrix;
        // long[][] arrayOfArray;
        // object[] myArray1, myArray2;

        // vector = new int[100];
        // matrix = new short[10, 100];
        // Console.WriteLine(""+vector.Length);
        // for (int i=0; i<vector.Length; i++)
        // {
        //     vector[i]=i;
            
        // }
        string s = "hello";
        s += "world";
        Console.WriteLine(s + "!");
    }
    
}
// class CoffeeMakerApp {
//     public static void Main() {
//         CoffeeMaker cm = new CoffeeMaker();
//         cm.onState = true;
//         cm.StartCoffeeMaker();
//     }
// }
class PropertyClass {
    private int privateValue;
    public int PrivateValue {
        get {return privateValue;}
        set { privateValue = value;}
    }
    public void PrintValue() {
        Console.WriteLine("Hidden Value = "+privateValue);
    }
}
class PropertyApp {
    public static void Main() { 
        int n;
        PropertyClass obj = new PropertyClass();
        obj.PrivateValue = 1000;
        obj.PrintValue();
        n = obj.PrivateValue;
        Console.WriteLine("       Value ="+n);
    }
}