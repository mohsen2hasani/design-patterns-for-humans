using System;

namespace MH.Proxy
{
    public class SecuredDoor
    {
        protected IDoor Door { get; set; }

        public SecuredDoor(LabDoor door)
        {
            Door = door;
        }
        public bool Authenticate(string password)
        {
            return password == "Password";
        }

        public void Open(string password)
        {
            if (Authenticate(password))
                Door.Open();
            else
                Console.WriteLine("Wrong Password !");
        }

        public void Close()
        {
            Door.Close();
        }
    }
}