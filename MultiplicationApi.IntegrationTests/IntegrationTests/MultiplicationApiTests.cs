using System.Threading.Tasks;
using Alba;
using CalculatorApi;
using NUnit.Framework;

namespace ApiTests
{
    public class MultiplicationApiTests
    {

        [Test]
        public async Task shouldGetRandomFactors()
        {
             using (var system = SystemUnderTest.ForStartup<Startup>())
             {
               await system.Scenario(_ =>
                {
                     _.Get.Url("/api/multiplication/random");
                     _.StatusCodeShouldBeOk();
                 });
             }
        }
    }
}
