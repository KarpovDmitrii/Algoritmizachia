using System;
using System.Collections;
public class Program
{
    public static void Main()
    {
       bool t= true;
       string str=Console.ReadLine();
        Stack a = new Stack();
        foreach (char i in str)
        {
           if (i=='{' || i=='[' || i=='('){
               a.Push(i);
           }
           if ((i=='}' || i==']' || i==')') && a.Count>0 )
           {
               char per=Convert.ToChar(a.Pop());
               if (i==')' && per=='('){
                  continue;
               }
               if (i==']' && per=='['){
                  continue;
               }
               if (i=='}' && per=='{'){
                  continue;
               }
               else{
                  t=false;
                  break;
               }
           }
           else if ((i=='}' || i==']' || i==')') && a.Count==0 )
           {
               t=false;
           }
        }
        if (t==true){
           Console.WriteLine("скобки стоят правильно");
        }
        if (t==false){
           Console.WriteLine("скобки стоят неправильно");
        }
    }
}