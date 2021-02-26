using System;
using System.Runtime.Serialization;

namespace BankApplication
{
    [Serializable]
    public class User : ISerializable
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }

        public User() { }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Role", Role);
            info.AddValue("Password", Password);
        }

        public User(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Role = (string)info.GetValue("Role", typeof(string));
            Password = (string)info.GetValue("Password", typeof(string));
        }
    }
}
