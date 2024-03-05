using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing.Test
{
    public class WorldsDumbestFunctionTest
    {
        //Naming Convention - ClassName_MethodName_ExceptionResult
        public static void WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnString()
        {
            try
            {
                //Arrange-Get whatever u need(variables,classes,methods)and put it in here
                int num = 0;
                WorldsDumbestFunction worldsDumbest = new WorldsDumbestFunction();

                //Act Execute this function
                string result = worldsDumbest.ReturnsPikachuIfZero(num);

                //Assert - whatever is returned,is what we want
                if (result == "PIKACHU")
                {
                    Console.WriteLine("PASSED: WorldsDumbestFunction.ReturnsPikachuIfZero_ReturnsString");
                }
                else
                {
                    Console.WriteLine("FAILED: WorldsDumbestFunction.ReturnsPikachuIfZero_ReturnsString");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }
        }
    }
}
