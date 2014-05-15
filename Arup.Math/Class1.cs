using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arup.Exception;

namespace Arup.Math
{
    public class Divide
    {

        public static Double divide(Double number)
        {
            Double result = 0;
            try
            {
                result = number / 0;
                throw new DivideByZeroException ();
            }
            catch (Arup.Exception.Custom arupex)
            {
                throw new Exception.Custom("custom arup error" + arupex.Message, arupex);                
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
