namespace Rextester
{
    public class FixMultiplication
    {
         public void FindDigit(String equation)
    {
        int l=equation.Length;
        int que=equation.IndexOf('?');
        int eq=equation.IndexOf('=');
        int mul=equation.IndexOf('*');
             Console.WriteLine(que+" "+eq+" "+mul);
        string first=equation.Substring(0,mul);
        string second=equation.Substring(mul+1,eq-mul-1);
        string third=equation.Substring(eq+1);
         Console.WriteLine(first+" "+second+" "+third);
             if(que>eq)
             {
                 int n1=int.Parse(first);
                 int n2=int.Parse(second);
                 int n3=n1*n2;
                 string res=n3.ToString();
                 char c=res[third.IndexOf('?')];
                 string ne=third.Replace('?',c);
                 if(ne.CompareTo(res)==0)
                 Console.WriteLine(c);
                 else
                  Console.WriteLine("-1");   
             }
             if(que>mul&&que<eq)
             {
                 int n1=int.Parse(first);
                 int n2=int.Parse(third);
                 int n3=n2/n1;
                 if(n2%n1!=0)
                     Console.WriteLine("-1");
                 else{
                 string res=n3.ToString();
                 char c=res[second.IndexOf('?')];
                 string ne=second.Replace('?',c);
                 if(ne.CompareTo(res)==0)
                 Console.WriteLine(c);
                 else
                  Console.WriteLine("-1");           
                 }}
              if(que<mul)
             {
                 int n1=int.Parse(second);
                 int n2=int.Parse(third);
                 int n3=n2/n1;
                  if(n2%n1!=0)
                     Console.WriteLine("-1");
                  else{
                 string res=n3.ToString();
                 char c=res[first.IndexOf('?')];
                 string ne=first.Replace('?',c);
                 if(ne.CompareTo(res)==0)
                 Console.WriteLine(c);
                 else
                  Console.WriteLine("-1");           
                  }}
         }
             
                          
        public static void Main(string[] args)
        {
            //Your code goes here
            Program fm=new Program();
            fm.FindDigit("2*12?=247");
            Console.WriteLine("Hello, world!");
        }
    }
}









//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class FixMultiplication
    {
         public int FindDigit(String equation)
    {
        int l=equation.Length;
        int que=equation.IndexOf('?');
        int eq=equation.IndexOf('=');
        int mul=equation.IndexOf('*');
             Console.WriteLine(que+" "+eq+" "+mul);
        string first=equation.Substring(0,mul);
        string second=equation.Substring(mul+1,eq-mul-1);
        string third=equation.Substring(eq+1);
         Console.WriteLine(first+" "+second+" "+third);
             if(que>eq)
             {
                 int n1=int.Parse(first);
                 int n2=int.Parse(second);
                 int n3=n1*n2;
                 string res=n3.ToString();
                 char c=res[third.IndexOf('?')];
                 string ne=third.Replace('?',c);
                 if(ne.CompareTo(res)==0)
                 return c-'0';
                 else
                  return -1;   
             }
             if(que>mul&&que<eq)
             {
                 int n1=int.Parse(first);
                 int n2=int.Parse(third);
                 int n3=n2/n1;
                 if(n2%n1!=0)
                     return -1;
                 else{
                 string res=n3.ToString();
                 char c=res[second.IndexOf('?')];
                 string ne=second.Replace('?',c);
                 if(ne.CompareTo(res)==0)
                 return c-'0';
                 else
                  return -1;   
                 }}
              if(que<mul)
             {
                 int n1=int.Parse(second);
                 int n2=int.Parse(third);
                 int n3=n2/n1;
                  if(n2%n1!=0)
                     return -1;
                  else{
                 string res=n3.ToString();
                 char c=res[first.IndexOf('?')];
                 string ne=first.Replace('?',c);
                 if(ne.CompareTo(res)==0)
                 return c-'0';
                 else
                 return -1;          
                  }}
             return -1;
         }
             
                          
        public static void Main(string[] args)
        {
            //Your code goes here
           FixMultiplication fm=new FixMultiplication();
            Console.WriteLine(fm.FindDigit("42*?7=1974"));
        }
    }
}