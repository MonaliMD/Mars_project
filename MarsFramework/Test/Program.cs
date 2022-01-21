using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace MarsFramework
{
    public class Program
    {

        
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {
            

            [Test]
            public void Test1()
            {
            
             
               
                SignIn signInObj = new SignIn();
                signInObj.LoginSteps();
            }

            [Test]
            public void Test2()
            {
                ShareSkill shareSkillObj = new ShareSkill();
                shareSkillObj.EnterShareSkill();
            }



        }

    
    }

    
}