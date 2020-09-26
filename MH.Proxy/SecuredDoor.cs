using System;

namespace MH.Proxy
{
    public class SecuredDoor
    {
        protected LabDoor _door { get; set; }

        public SecuredDoor(LabDoor door)
        {
            _door = door;
        }
        public bool Authenticate(string password)
        {
            return password == "Password";
        }

        public void Open(string password)
        {
            if (Authenticate(password))
                _door.Open();
            else
                Console.WriteLine("Wrong Password !");
        }

        public void Close()
        {
            _door.Close();
        }
    }
}