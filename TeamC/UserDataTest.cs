﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TeamC
{
    [TestFixture]
    class UserDataTest
    {
        [Test]
        public void TestSetandGetPayinformation()
        {
            UserData user = new UserData();
            List<string> Payinformation=new List<string>();
            Payinformation.Add("12345678");
            user.SetPayinformation(Payinformation);
            Assert.That(Payinformation, Is.EqualTo(user.GetPayinformation()));
        }
        [Test]
        public void TestSetandGetPassword()
        {
            UserData user = new UserData();
            string passwd = "12345678";
            user.SetPassword(passwd);
            Assert.That(passwd, Is.EqualTo(user.GetPassword()));

        }
        [Test]
        public void TestSetandGetUsertype()
        {
            UserData user = new UserData();
            int UserType = 1;
            user.SetUserType(UserType);
            Assert.That(UserType, Is.EqualTo(user.GetUserType()));

        }
        [Test]
        public void TestSetGetOrderList()
        {
            UserData user = new UserData();
            Order ord=new Order();
            user.SetOrderList(ord);
            Assert.That(ord, Is.EqualTo(user.GetOrderList()));

        }
    }
}
