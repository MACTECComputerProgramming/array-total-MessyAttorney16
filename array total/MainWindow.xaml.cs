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

namespace array_total
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //make array
            int[] grades = new int[5];
            grades[0] = Convert.ToInt32(textGrade1.Text);
            grades[1] = Convert.ToInt32(textGrade2.Text);
            grades[2] = Convert.ToInt32(textGrade3.Text);
            grades[3] = Convert.ToInt32(textGrade4.Text);
            grades[4] = Convert.ToInt32(textGrade5.Text);

            //get total
            int totalGrade;
            totalGrade = (grades[0] + grades[1] + grades[2] + grades[3] + grades[4]);

            //get average
            int averageGrade = totalGrade / 5;

            //show answers
            totalGradeLabel.Content = totalGrade;
            averageGradeLabel.Content = averageGrade;
        }
    }
}
