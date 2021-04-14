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
using System.Windows.Shapes;

namespace TrigonometryApp
{
    /// <summary>
    /// Interaction logic for LawOfSine.xaml
    /// </summary>
    public partial class LawOfSine : Window
    {
        double angleA = 0;
        double angleB = 0;
        double angleC = 0;
        double sideA = 0;
        double sideB = 0;
        double sideC = 0;
        public LawOfSine()
        {
            InitializeComponent();
        }

        private void xCloseWindow_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        public void Calculate()
        {

            angleA = Convert.ToDouble(xAngleA.Text);
            angleB = Convert.ToDouble(xAngleB.Text);
            angleC = Convert.ToDouble(xAngleC.Text);
            sideA = Convert.ToDouble(xSideA.Text);
            sideB = Convert.ToDouble(xSideB.Text);
            sideC = Convert.ToDouble(xSideC.Text);

            if((angleA != 0 && sideB != 0 && angleC != 0) || (angleC != 0 && sideA != 0 && angleB != 0) || (angleB != 0 && sideC != 0 && angleA != 0))
            {
                calcASA();
            }
            
        }
        public void calcASA()
        {
            angleA = Convert.ToDouble(xAngleA.Text);
            angleB = Convert.ToDouble(xAngleB.Text);
            angleC = Convert.ToDouble(xAngleC.Text);
            sideA = Convert.ToDouble(xSideA.Text);
            sideB = Convert.ToDouble(xSideB.Text);
            sideC = Convert.ToDouble(xSideC.Text);

            if (angleA != 0 && sideB != 0 && angleC != 0)
            {

            }
        }
        public void calcSSA()
        {

        }
        public void calcAAA()
        {

        }
        public void calcSSS()
        {

        }
        public void calcABC()
        {

        }
    }
}
