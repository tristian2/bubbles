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
            catch (System.DivideByZeroException dex)
            {
                throw new DivideByZeroException("division by zero exception" + dex.Message, dex);
                throw new Arup.Exception.Custom();  //this line will never be reached!
            }
            catch (Arup.Exception.Custom arupex)
            {
                throw new Exception.Custom("custom arup error" + arupex.Message, arupex);                
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new System.Exception("Arup generic exception division by zero", ex);
            }
            return result;
        }
    }
}
