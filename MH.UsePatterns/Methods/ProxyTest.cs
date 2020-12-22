using MH.Proxy;
using System;

namespace MH.UsePatterns.Methods
{
    public static class ProxyTest
    {
        public static void Run()
        {
            Console.WriteLine("=-=-=-=Proxy=-=-=-=");
            Console.WriteLine("Create Lab Door");
            SecuredDoor labDoor = new SecuredDoor(new LabDoor());

            Console.WriteLine("Open with wrong password:");
            labDoor.Open("wrong pass");
            Console.WriteLine();

            Console.WriteLine("Open with right password:");
            labDoor.Open("Password");
            Console.WriteLine();

            Console.WriteLine("Close door:");
            labDoor.Close();

            Console.WriteLine("----------------------------------" + Environment.NewLine);
        }
    }
}