using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate void showmsgdelegate(string message);
    class DelegateMethodDemo
    {
        public void showMessage1(string msg)
        {
            System.Windows.MessageBox.Show("THIS IS METHOD 1: " + Environment.NewLine + msg);
        }

        public void showMessage2(string msg)
        {
            System.Windows.MessageBox.Show("THIS IS METHOD 2: " + Environment.NewLine + msg);
        }
        /// <summary>
        /// this method returns a method hiddden behind the delegate showmsgdelegate
        /// </summary>
        /// <param name="methodtype">1 for showMessage1 and 2 for showMessage2</param>
        /// <returns></returns>
        public showmsgdelegate getMethod(string methodtype)
        {
            if(methodtype.Equals("1"))
            {
                return this.showMessage1;
            }
            else if(methodtype.Equals("2"))
            {
                return this.showMessage2;
            }
            else
            {
                throw new Exception("Invalid method type passed.");
            }
        }
    }
}
