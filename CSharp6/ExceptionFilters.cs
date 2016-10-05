using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_7.CSharp6
{
    public class ExceptionFilters
    {
        public void Process()
        {
            try
            {
                CalculateHealth();
            }
            //catch(HealthException ex) when ex.HealthExceptionId==10)
            //{
            //    //
            //}
            catch (Exception ex) when (Log(ex, "An error occurred"))
            {
                // never reached, but exception logged without an unwind.
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                System.Diagnostics.Debugger.Break();
            }

        }

        private void CalculateHealth()
        {
            int health = 100;
            int heatIndex = 0;

            health = health / heatIndex;
        }

        static bool Log(Exception ex, string message, params object[] args)
        {
            Console.WriteLine(message + ex.ToString(), args);
            return false;
        }
    }
}

