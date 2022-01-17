using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace miniKatas;

public class MathFunctions
{
    public int Multiply(int a, int b)
    {
        return a * b;
    }

        //temporary fix
    public int Divide(int a, int b)
    {
        try
        {
        return a/b;
        }
        catch(DivideByZeroException)
        {
        return 0;    
        }
        
    }
}

public class ListFunctions
{
    public int Smallest(int[] inputArr)
    {
        return inputArr.Min(n => n);
    }

    public int[] Sort(int[] inputArr)
    {
        return Sort(inputArr);
    }
}

public class StringFunctions
{
    public string NoSpaces(string input)
    {
        var takeThis = Regex.Replace(input, @"[^0-9a-zA-Z]+", "").ToLower();
                
        return String.Join("",  takeThis.Split(" "));      
    }

    public string EmailMaker(string input)
    {
            
            try
            {
                //Regex str = new Regex("[^A-Za-z0-9]");
                    if(!input.Contains("/"))
                      {
                        if (input.Contains(" "))
                        {
                            return input.Replace(" ",".") + "@gmail.com";
                        } 
                    else
                        return input + "@gmail.com";
                        }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        
    }
}

//just a Git TryTest!