using Microsoft.AspNetCore.Mvc;

namespace TestCoreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SimpleMathController : Controller
    {
        [HttpGet(Name = "simpleMath")]
        public int simpleMath(int operandOne, int operandTwo, char operation)
        {
            int result;

            //Method 1 - switch statement
            switch (operation)
            {
                case 'S':
                case 's':
                    result = operandOne - operandTwo;
                    break;
                case 'M':
                case 'm':
                    result = operandOne * operandTwo;
                    break;
                default:
                    result = operandOne + operandTwo;
                    break;
            }

            /*
            //Method 2 - if...else statement
            if ((operation == 'S') || (operation == 's'))
            {
                result = operandOne - operandTwo;
            }
            else if ((operation == 'M') || (operation == 'm'))
            {
                result = operandOne * operandTwo;
            }
            else
            {
                result = operandOne + operandTwo;
            }
            */
            return result;
        }
    }
}