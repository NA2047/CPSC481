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

namespace CPSC_481_Trailexplorers
{
    /// <summary>
    /// Interaction logic for CircleGrow.xaml
    /// </summary>
    public partial class CircleGrow : UserControl
    {
        public CircleGrow()
        {
            InitializeComponent();
        }

        public double ProgressValue
        {
            get { return (double)GetValue(ProgressValueProperty); }
            set {
                System.Diagnostics.Debug.WriteLine(value);
                if (value >= 100.00)
                {

                    underBarCirle.Stroke = Brushes.Red;
                    underBarCirle.StrokeThickness = 2.5;

                }
                else
                {
                    underBarCirle.Stroke = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF89CE25"));
                    underBarCirle.StrokeThickness = 2.5;
                }
                SetValue(ProgressValueProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for ProgressValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressValueProperty =
            DependencyProperty.Register("ProgressValue", typeof(double), typeof(CircleGrow), new PropertyMetadata(0.0, OnProgressValueChanged));

        private  static void OnProgressValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //throw new NotImplementedException();

           
                CircleGrow circularProgressBar = d as CircleGrow;
            if (circularProgressBar != null)
            {
                double r = 19;
                double x0 = 20;
                double y0 = 20;
                circularProgressBar.myArc.Size = new Size(19, 19);
                double angle = 90 - (double)e.NewValue / 100 * 360;
                double radAngle = angle * (Math.PI / 180);
                double x = x0 + r * Math.Cos(radAngle);
                double y = y0 - r * Math.Sin(radAngle);

                System.Diagnostics.Debug.WriteLine(r);
                System.Diagnostics.Debug.WriteLine(x0);
                System.Diagnostics.Debug.WriteLine(y0);
                System.Diagnostics.Debug.WriteLine(circularProgressBar.myArc.Size);
                System.Diagnostics.Debug.WriteLine(angle);
                System.Diagnostics.Debug.WriteLine(radAngle);
                System.Diagnostics.Debug.WriteLine(x);
                System.Diagnostics.Debug.WriteLine(y);
                System.Diagnostics.Debug.WriteLine("new bdd");
                System.Diagnostics.Debug.WriteLine("new");




                if (circularProgressBar.myArc != null)
                {
                    circularProgressBar.myArc.IsLargeArc = ((double)e.NewValue >= 50);
                    circularProgressBar.myArc.Point = new Point(x, y);
                }
            }
        }
    }
}
