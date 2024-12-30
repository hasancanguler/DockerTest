
using static RestAssured.Dsl;

namespace FirstDockerTest
{
    public class FirstControllerTests
    {

        [Test]
        public void GetShouldReturnTestOk()
        {
            Given()
                .When()
                .Get("http://localhost:8080/Test")
                .Then()
                .StatusCode(200)
                .And()
                .Body(NHamcrest.Is.EqualTo("Test Ok"));
        }
    }
}