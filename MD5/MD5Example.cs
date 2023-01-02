using System;
using System.Text;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

public class HashCode{

    static void Main(string[] args){

        MainDisplay();

    }

    static void MainDisplay(){

        int Options = -1;

        Console.WriteLine("HashCode.NET");
        Console.WriteLine("------------");
        Console.WriteLine("1: MD5");
        Console.WriteLine("Option: ");

        try {
            Options = Int32.Parse(Console.ReadLine());
        } catch(Exception e){
            Console.WriteLine("Error converting the char to int due to my error.  Please try again");
            MainDisplay();
        }

        switch(Options){
            case 1:
                    MD5Display();
                    break;
            default:
                    MainDisplay();
                    break;
        }
    }

    static void MD5Display(){

        Console.WriteLine("Text: ");
        string PlainText = Console.ReadLine();

        try{
            MD5 MD5Instance = MD5.Create();
            byte[] MD5ByteArray = MD5Instance.ComputeHash(Encoding.ASCII.GetBytes(PlainText));
            SoapHexBinary Hex = new SoapHexBinary(MD5ByteArray);
            Console.WriteLine("MD5: " + Hex.ToString());
            Environment.Exit(0);

        }
        catch(Exception e){
            Console.WriteLine("Exception@MD5Display: " + e.Message);
        }
    }
}
