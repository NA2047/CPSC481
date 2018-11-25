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
    /// Interaction logic for AnimationFilter.xaml
    /// </summary>
    public partial class AnimationFilter : UserControl
    {
        private enum Daytm: DateTime { 12 };

        public AnimationFilter()
        {
            InitializeComponent();
            //elevationAnimationFill.fi
        }
        public double MountainValue
        {
            get { return (double)GetValue(ProgressValueProperty); }
            set
            {
                SetValue(ProgressValueProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for ProgressValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressValueProperty =
            DependencyProperty.Register("MountainValue", typeof(double), typeof(AnimationFilter), new PropertyMetadata(0.0, OnProgressValueChanged));

         
    

        private static void OnProgressValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //throw new NotImplementedException();


            AnimationFilter pathGrow = d as AnimationFilter;
            //double Y = poop.mountain.Points[1].Y;
            //double X = poop.mountain.Points[1].X;



            //System.Diagnostics.Debug.WriteLine(Slider1.Value);
            //System.Diagnostics.Debug.WriteLine(poop.mountain.Points[1].Y);


            pathGrow.mountain.Points[1] =  new Point(65, (double)e.NewValue);
         
          
           

            //if(Slider1.Value == 0)
            //{
            //    poop.mountain.Points[1] = new Point(65, 150);
            //}
          


            //var x = pathGrow.trailOne.X1;
            //var y = pathGrow.trailOne.Y1;




        }

        private void PlaceSun()
        {
            var time = DateTime.Now.TimeOfDay;

        }
    }
}
