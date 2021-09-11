using Entities.CustomExcepetion;
using Entities.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Clases
{
    public class Operations
    {
        public static void DivideZero(decimal value)
        {
            try
            {
                value.DivideByZero();
            }
            catch(DivideByZeroException)
            {
                throw new DivideByZeroException();
            }
        }

        public static double DivideOperation(string a , string b)
        {
            try
            {
                if (ValidateInput(b) == 0)
                {
                    throw new DivideByZeroException();
                }

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
                return result;
            }
            else
            {
                throw new CustomException("NO INGRESO NADA O INGRESO LETRAS");
            }
        }

        public static void SystemException()
        {
            throw new DirectoryNotFoundException();
        }

        public static void CustomException()
        {
            throw new CustomException("TODO LO QUE TENIA QUE FALLAR HA FALLADO");
        }
    }
}
