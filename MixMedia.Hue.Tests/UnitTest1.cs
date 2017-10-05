using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MixMedia.Hue.Local;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MixMedia.Hue.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private string Username => "2hIkJgIgFyUirh29TtmOeudr3dxxe-W3H1SUImfL";
        public async Task CreateUserTest()
        {

            var controller = new Configuration(new HttpClient());
            var result = await controller.CreateUser("Tests", "Unit");


            Assert.IsNotNull(result, result.First().ToString());
        }
    }
}
