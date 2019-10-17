using System;
using Microsoft.Azure.WebJobs;

namespace FunctionApp3
{
    public class Function1
    {
        private readonly IGreeter _greeter;

        public Function1(IGreeter greeter)
        {
            _greeter = greeter;
        }

        [FunctionName("Function1")]
        public void Run([TimerTrigger("*/15 * * * * *")]TimerInfo myTimer)
        {
            Console.WriteLine("Hello Function");

            Console.WriteLine(_greeter.GreetMessage("abhimanyu"));
        }
    }
}