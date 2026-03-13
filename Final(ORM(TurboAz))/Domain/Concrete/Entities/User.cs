using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Final_ORM_TurboAz__.Domain.Concrete.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                if(value.Length == 0)
                {
                    throw new ArgumentException("Enter valid password");
                }
                password = Encrypt(value) ?? value;
            }
        }
        private string? Encrypt(string password) 
        {
            string encrypted = BCrypt.Net.BCrypt.HashPassword(password);
            return encrypted;
        }
        public bool CheckPassword(string password) 
        {
            if (BCrypt.Net.BCrypt.Verify(password, Password))
            {
                return true;
            }
            return false;
        }
        public int PostId { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; }
    }
}

