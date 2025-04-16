using System.Reflection.Metadata.Ecma335;
using webapp.Module;

namespace WebTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int i = 1;

            bool result = true;

            if (i == 1) result = true;

            Assert.True(result, "Value should be equal to 1");
        }

        [Fact]
        public void CheckAddFun()
        {
            Function fun = new Function();
            int y = fun.Add(3, 2);
            bool result = false;
            if (y == 5) result = true;
            Assert.True(result, "Value should be equal to 5");
        }
    }
}