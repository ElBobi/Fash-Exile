using FashExile.Data;
using FashExile.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FashExile.Services
{
    public class UserService : IUserService
    {
        private ShoppingDbContext db;

        public UserService(ShoppingDbContext db)
        {
            this.db = db;
        }
        public void Delete(string username)
        {
            var userEntity = db.Users.FirstOrDefault(x => x.Username == username.Trim());
            db.Users.Remove(userEntity);
            db.SaveChanges();
        }

        public bool Login(string username, string password)
        {
            var userEntity = db.Users.FirstOrDefault(x => x.Username == username.Trim());
            if (userEntity.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Register(string username, string password, string firstName, string lastName)
        {
            var userEntity = BaseRegister(username, password, firstName, lastName);
            db.Users.Add(userEntity);
            db.SaveChanges();
        }

        public void Register(string username, string password, string firstName, string lastName, string country, string city, string postalCode, string address)
        {
            var userEntity = BaseRegister(username, password, firstName, lastName);
            var addressEntity = new Address
            {
                Country = country,
                City = city,
                PostalCode = postalCode,
                AddressOne = address
            };
            userEntity.Address = addressEntity;
            db.Users.Add(userEntity);
            db.SaveChanges();
        }

        public void Register(string username, string password, string firstName, string lastName, string phone)
        {
            var userEntity = BaseRegister(username, password, firstName, lastName);
            userEntity.Phone = phone;
            db.Users.Add(userEntity);
            db.SaveChanges();
        }

        public void Register(string username, string password, string firstName, string lastName, string phone, string country, string city, string postalCode, string address)
        {
            var userEntity = BaseRegisterWithAddress(username, password, firstName, lastName, country, city, postalCode, address);
            userEntity.Phone = phone;
            db.Users.Add(userEntity);
            db.SaveChanges();
        }

        private User BaseRegister(string username, string password, string firstName, string lastName)
        {
            if (db.Users.FirstOrDefault(x => x.Username == username.Trim()) == null)
            {
                var user = new User
                {
                    Username = username.Trim(),
                    Password = password.Trim(),
                    FirstName = firstName.Trim(),
                    LastName = lastName.Trim(),
                };
                return user;
            }
            else
            {
                throw new Exception("User with such username exists.");
            }
        }
        private User BaseRegisterWithAddress(string username, string password, string firstName, string lastName, string country, string city, string postalCode, string address)
        {
            if (db.Users.FirstOrDefault(x => x.Username == username.Trim()) == null)
            {
                var userEntity = BaseRegister(username, password, firstName, lastName);
                var addressEntity = new Address
                {
                    Country = country,
                    City = city,
                    PostalCode = postalCode,
                    AddressOne = address
                };
                userEntity.Address = addressEntity;
                return userEntity;
            }
            else
            {
                throw new Exception("User with such username exists.");
            }
        }
        public void UpdatePassword(string username, string oldPassword, string newPassword)
        {
            var userEntity = db.Users.FirstOrDefault(x => x.Username == username.Trim());
            if (userEntity != null)
            {
                throw new Exception("User already exists.");
            }
            else
            {
                if (userEntity.Password == oldPassword)
                {
                    userEntity.Password = newPassword;
                }
                else
                {
                    throw new Exception("Incorrect old password.");
                }
            }
        }
    }
}
