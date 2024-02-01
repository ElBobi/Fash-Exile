using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashExile.Services
{
    public interface IUserService
    {
        void Register(string username, string password, string FirstName, string LastName);
        void Register(string username, string password, string FirstName, string LastName, string country, string city, string postalCode, string address);
        void Register(string username, string password, string FirstName, string LastName, string phone);
        void Register(string username, string password, string FirstName, string LastName, string phone, string country, string city, string postalCode, string address);
        void Login(string username, string password);
        void UpdatePassword(string username, string oldPassword, string newPassword);
        void Delete(string username);
    }
}
