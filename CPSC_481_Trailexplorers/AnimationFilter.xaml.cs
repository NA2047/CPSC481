using System;
using System.Collections.Generic;
using System.Drawing;
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
using System.Xaml;


namespace CPSC_481_Trailexplorers
{
    /// <summary>
    /// Interaction logic for AnimationFilter.xaml
    /// </summary>
    public partial class AnimationFilter : UserControl
    {
        private String time = DateTime.Now.ToString("HH:mm:ss");
        public int timeInt = 0;
        private double slope = 0.0;
        
        public AnimationFilter()
        {
            InitializeComponent();
            //System.Diagnostics.Debug.WriteLine(time);
            int h2 = DateTime.Parse(time).Hour;
            timeInt = h2;
            double pas = h2 / 24.0;
            //darken.Opacity = pas;
            System.Diagnostics.Debug.WriteLine(pas);
            // Create image.
           


            //elevationAnimationFill.fi
        }
        public double MountainValue
        {
            get { return (double)GetValue(ProgressValueProperty); }
            set
            {
                SetValue(ProgressValueProperty, value);
                ChangeLine();
            }
        }

        public double MountainValueElevation
        {
            get { return (double)GetValue(eProgressValueProperty); }
            set
            {
                SetValue(eProgressValueProperty, value);
                ChangeLine();
            }
        }

        public double DarkenUporDownP
        {
            get { return (double)GetValue(DarkenUporDown); }
            set
            {
                SetValue(DarkenUporDown, value);
                ChangeLine();
            }
        }

        // Using a DependencyProperty as the backing store for ProgressValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressValueProperty =
            DependencyProperty.Register("MountainValue", typeof(double), typeof(AnimationFilter), new PropertyMetadata(0.0, OnProgressValueChanged));
        // Using a DependencyProperty as the backing store for ProgressValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DarkenUporDown =
            DependencyProperty.Register("DarkenUporDownP", typeof(double), typeof(AnimationFilter), new PropertyMetadata(0.0, OnDarkenUporDown));

        public static readonly DependencyProperty eProgressValueProperty =
            DependencyProperty.Register("1MountainValue", typeof(double), typeof(AnimationFilter), new PropertyMetadata(0.0, EOnProgressValueChanged));



        private static void OnDarkenUporDown(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //AnimationFilter pathGrow = d as AnimationFilter;a
            
           

        }
        private static void EOnProgressValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            AnimationFilter pathGrow = d as AnimationFilter;
            //Y = MX+B
            double slope = (pathGrow.mountain.Points[1].Y - pathGrow.mountain.Points[0].Y)/(pathGrow.mountain.Points[1].X- pathGrow.mountain.Points[0].X);
            if (slope < 0)
            {
                slope *= -1;
            }

            double temp = 150 - (slope * (double)e.NewValue);
            //System.Diagnostics.Debug.WriteLine(e.NewValue.ToString());
            //System.Diagnostics.Debug.WriteLine(temp);
            pathGrow.mountain1.Points[0] = new System.Windows.Point((double)e.NewValue, temp);
            pathGrow.mountain1.Points[1] = new System.Windows.Point(pathGrow.mountain.Points[1].X, pathGrow.mountain.Points[1].Y);
            pathGrow.mountain1.Points[2] = new System.Windows.Point(130 -(double)e.NewValue, temp);
            pathGrow.path.Height = pathGrow.mountain.Points[1].Y;
            pathGrow.mountain1.Opacity = 1.0;
            pathGrow.path.Opacity = 1.0;
            pathGrow.path.Height = 150 - pathGrow.mountain.Points[1].Y;
            pathGrow.path.SetValue(Canvas.TopProperty, pathGrow.mountain.Points[1].Y);
            System.Diagnostics.Debug.WriteLine((double)e.NewValue);
            //System.Diagnostics.Debug.WriteLine(pathGrow.path.Height);
            //pathGrow.mountain1.Points[2] = new Point(0, (double)e.NewValue);

        }

        private static void OnProgressValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //throw new NotImplementedException();


            AnimationFilter pathGrow = d as AnimationFilter;
            //double Y = poop.mountain.Points[1].Y;
            //double X = poop.mountain.Points[1].X;



            //System.Diagnostics.Debug.WriteLine(Slider1.Value);
            //System.Diagnostics.Debug.WriteLine(poop.mountain.Points[1].Y);
            //double slope = (pathGrow.mountain.Points[1].Y - pathGrow.mountain.Points[0].Y) / (pathGrow.mountain.Points[1].X - pathGrow.mountain.Points[0].X);
            //if (slope < 0)
            //{
            //    slope *= -1;
            //}

            pathGrow.mountain1.Opacity = 0.0;
            pathGrow.path.Opacity = 0.0;
            //double XOffset0 = pathGrow.mountain1.Points[0].Y / slope;
            //double XOffset2 = pathGrow.mountain1.Points[2].Y / slope;
            //System.Diagnostics.Debug.WriteLine(XOffset0);
            //System.Diagnostics.Debug.WriteLine(XOffset2);
            //System.Diagnostics.Debug.WriteLine("dadadad");
            //double temp = 150 - (slope * pathGrow.mountain1.Points[1].Y);
            pathGrow.mountain.Points[1] =  new System.Windows.Point(65, (double)e.NewValue);
            pathGrow.mountain1.Points[1] = new System.Windows.Point(65, (double)e.NewValue);
            //pathGrow.mountain1.Points[0] = new System.Windows.Point(XOffset0, pathGrow.mountain1.Points[0].Y);
            //pathGrow.mountain1.Points[2] = new System.Windows.Point(XOffset2, pathGrow.mountain1.Points[2].Y);
            ChangeLine();


            //pathGrow.mountain1.Points[2] = new System.Windows.Point(130 - (double)e.NewValue, temp);





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


        public  static void ChangeLine()
        {
           





        }

        private void Darken_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine(darken.Opacity);
        }
    }
}
