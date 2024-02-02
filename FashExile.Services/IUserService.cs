using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashExile.Services
{
    public interface IUserService
    {
        void Register(string username, string password, string firstName, string lastName);
        void Register(string username, string password, string firstName, string lastName, string country, string city, string postalCode, string address);
        void Register(string username, string password, string firstName, string lastName, string phone);
        void Register(string username, string password, string firstName, string lastName, string phone, string country, string city, string postalCode, string address);
        bool Login(string username, string password);
        void UpdatePassword(string username, string oldPassword, string newPassword);
        void Delete(string username);
    }
}
