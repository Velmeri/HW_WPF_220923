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

namespace HW_WPF_220923
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		SolidColorBrush greenBrush = new SolidColorBrush(Colors.Green);
		SolidColorBrush blackBrush = new SolidColorBrush(Colors.Black);

		public MainWindow()
		{
			InitializeComponent();
		}
		private void NumClick(object sender, RoutedEventArgs e)
		{
			if(Output.Text != "ОТКРЫТО")
				Output.Text += ((Button)sender).Content;
		}

		private void ClearClick(object sender, RoutedEventArgs e)
		{
			if(Output.Foreground == greenBrush)
				Output.Foreground = blackBrush;
			Output.Text = null;
		}

		private void OpenClick(object sender, RoutedEventArgs e)
		{
			Output.Foreground = greenBrush;
			Output.Text = "ОТКРЫТО";
		}
	}
}
