using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsFramework.Pages;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace MarsFramework
{
    [TestFixture]
    [Category("Sprint1")]

  
public class Program : Global.Base
    {
       
        [Test]
        public void UserAccount()
        {
            // Creates a toggle for the given test, adds all log events under it    
            test = extent.StartTest("Search for a Property");

            // Create an class and object to call the method
            Profile obj = new Profile();
            obj.EditProfile();

          
        }
       
    }

}