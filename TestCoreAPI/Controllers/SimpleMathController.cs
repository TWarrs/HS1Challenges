using Microsoft.AspNetCore.Mvc;

namespace TestCoreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SimpleMathController : Controller
    {
        [HttpGet(Name = "simpleMath")]
        public float simpleMath(float operandOne, float operandTwo, char operation)
        {
            float result;

            //Method 1 - switch statement
            switch (operation)
            {
                case 'S':
                case 's':
                case '-':
                    result = operandOne - operandTwo;
                    break;
                case 'M':
                case 'm':
                case '*':
                    result = operandOne * operandTwo;
                    break;
                case 'D':
                case 'd':
                case '/':
                    result = operandOne / operandTwo;
                    break;
                case 'R':
                case 'r':
                case '%':
                    result = operandOne % operandTwo;
                    break;
                default:
                    result = operandOne + operandTwo;
                    break;
            }

            /*
            //Method 2 - if...else statement
            if ((operation == 'S') || (operation == 's') || (operation == '-'))
            {
                result = operandOne - operandTwo;
            }
            else if ((operation == 'M') || (operation == 'm') || (operation == '*'))
            {
                result = operandOne * operandTwo;
            }
            else if ((operation == 'D') || (operation == 'd' || (operation == '/')))
            {
                result = operandOne / operandTwo;
            }
            else if ((operation == 'R') || (operation == 'r' || (operation == '%')))
            {
                result = operandOne % operandTwo;
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