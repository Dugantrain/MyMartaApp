using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMartaApp.Common.Apis;
using NUnit.Framework;

namespace MyMartaApp.UITests
{
    [TestFixture]
    public class ApiTests
    {

        [Test]
        public void CanHitApiAndGetBackRailArrivals()
        {
            var railApi = new RailApi();
            var railArrivals = railApi.GetRailArrivals("362dd1ee-88fc-4f7b-80e3-1beb910b5ce1");
        }
    }
}
