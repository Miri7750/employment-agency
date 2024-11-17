using WebApplication1.Controller;
using WebApplication1.DTO;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Get_checkId()
        {
            var controller = new EmployeeController();
            var result = controller.Get(1);
            Assert.IsType<Employee>(result);
        }
    }
}