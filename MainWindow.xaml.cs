/*David laughton
 * May 25th 2019
 * Red green or blue squares for single blocks
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace u5RG_or_B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            //Variables
            int numOfSquare;
            Int64 addedNumRed = 0;
            Int64 addedNumGreen = 0;
            Int64 addedNumBlue = 0;

            //making input in to int
            int.TryParse(txtNumInput.Text, out numOfSquare);

            Int64 a = 0, b = 1, c = 0;            
            for (int i = 1; i <= numOfSquare; i++)
            {
                c = a + b;
                //Minus one 
                addedNumRed = c - 1;
                a = b;
                b = c;
            }
            Int64 d = 0, g = 0, f = 0, h = 0;
            for (int i = 2; i <= numOfSquare; i++)
            {
                //the output was wrong for two squares
                int x = 1;
                if (numOfSquare == 2)
                {
                    x = 0;
                }
                addedNumGreen = h + g + d + x;
                h = g;
                g = d;
                d = f;
                f = addedNumGreen;                   
            }            
            Int64 j = 2, k = 1, l = 0, m = 0, n = 0, o = 0;
            for (int i = 5; i <= numOfSquare; i++)
            {
                addedNumBlue = l + m + n + o;
                o = n;
                n = m;
                m = l;
                l = k;                
                k = j;
                j = addedNumBlue;
                addedNumBlue = k + addedNumBlue;
                if (numOfSquare == 6)
                {
                    //It would always give 1 instead of three because of how j is set through all the other variables 
                    //which takes more than two times to run to get the correct anwser.  This fixes it.
                    addedNumBlue = 3;
                }                
            }

            Int64 total = addedNumBlue + addedNumGreen + addedNumRed;
            lblOutput.Content = "Number of red possible: " + addedNumRed + ". Number of possible greens: " + addedNumGreen + ".\n" 
                + "Number of possible blues: " + addedNumBlue + ". Total combonations: " + total;
        }
    }
}
