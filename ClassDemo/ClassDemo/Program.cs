﻿namespace ClassDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool Login(string username, string password)
        {
            if (username == "Inigo Montoya" && password == "goodpassword")
            {
                return true;
            }
            return false;
        }
    }
}
