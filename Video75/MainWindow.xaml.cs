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

namespace Video75
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Grid grid = new Grid();
            //this.Content = grid;
            //Button miBoton = new Button();
            //WrapPanel miWrap = new WrapPanel();
            //TextBlock txt1 = new TextBlock();
            //txt1.Text = "Click";
            //txt1.Foreground = Brushes.Blue;
            //miWrap.Children.Add(txt1);

            //TextBlock txt2 = new TextBlock();
            //txt2.Text = "Enviar";
            //txt2.Background = Brushes.White;
            //txt2.Foreground = Brushes.Red;
            //miWrap.Children.Add(txt2);

            //TextBlock txt3 = new TextBlock();
            //txt3.Text = "DaleDale";
            //txt3.Foreground = Brushes.Yellow;
            //miWrap.Children.Add(txt3);

            //miBoton.Content = miWrap;
            //miBoton.Height = 50;
            //miBoton.Width = 120;
            //miBoton.Background = Brushes.Black;




            //void Onclick(object sender,RoutedEventArgs e)
            //{
            //    miBoton.Background = Brushes.Pink;
            //}



            //grid.Children.Add(miBoton);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Le has dado Click al boton 2");
        }

       /* private void Panel_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Le has dado Click al panel");
        }
       */
        private void Panel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Le has dado al panel");
        }
    }
}
