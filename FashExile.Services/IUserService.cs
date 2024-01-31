using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashExile.Services
{
    public interface IUserService
    {
        void Create(string username, string password, string FirstName, string LastName);
        void Create(string username, string password, string FirstName, string LastName, string country, string city, string postalCode, string address);
        void Create(string username, string password, string FirstName, string LastName, string phone);
        void Create(string username, string password, string FirstName, string LastName, string phone, string country, string city, string postalCode, string address);
        void Delete(string username);
        void Update(string username);
    }
}
