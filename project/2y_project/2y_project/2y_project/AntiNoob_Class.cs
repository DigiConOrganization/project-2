using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classbuilds
{
    class AntiNoob_Class
    {
        private string sText;
        private int iNumber;
        private double dDesimal;        //Still gotta do this Ref: AntiDesimal
        

        private bool AntiInt(string givenData)                  //Check for numbers in string.
        {

            for (int i = 0; i < 10; i++)
            {
                if (givenData.Contains(i.ToString()))
                {
                    MessageBox.Show(" You can not have numbers in a text only field.");
                    return true;

                }
            }

            return false;
            

            
        }
        private bool AntiText(string givenData)         //Steck for letters in ints.
        {
            try        // Checks without crashing the the program.
            {
                iNumber = int.Parse(givenData); 
            }
            catch (Exception)
            {
                MessageBox.Show(" You can not have leters in a number only field.");
                return true;
                
                
            }
            
            return false;
            
        }
    }
}
