using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyUnitTests.Tests
{
    // static because will have to bring this into the program file when done testing
    public static class DummyFunctionTests
    {
        // Naming Convention: ClassName_MethodName_ExpectedBehavior
        public static void DummyFunction_ReturnsHelloWorldIfZero_ReturnString()
        {
            try
            {
                //Arrange
                int num = 0;
                DummyFunction dummyFunction = new DummyFunction();

                //Act
                string result = dummyFunction.ReturnsHelloWorldIfZero(num);

                //Assert
                if (result != "Hello, World!")
                {
                    throw new Exception($"TEST FAILED. Expected 'Hello, World!', but got '{result}'");
                }
                else
                {
                    Console.WriteLine("TEST PASSED");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"TEST FAILED: {ex.Message}");
            }
        }
    }
}
