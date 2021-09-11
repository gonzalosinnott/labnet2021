using Entities.Exceptions;
using Entities.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Clases
{
    public class Logic
    {

        public static double DivideOperation(string a , string b)
        {
            try
            {
               return ValidateInput(a).DivideBy(ValidateInput(b));

            }catch(DivideByZeroException ex)
            {
                throw (ex);
            }
        }

        public static double ValidateInput(string input)
        {
            if(double.TryParse(input, out double result))
            {
                if(result == 0)
                {
                    throw new InputException("SOLO CHUCK NORRIS PUEDE DIVIDIR POR 0!");

                }
                return result;
            }
            else
            {
                throw new InputException("No ingreso nada o ingreso letras");
            }
        }
    }
}
