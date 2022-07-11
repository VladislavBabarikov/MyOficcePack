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

namespace MyOficcePack
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int FileNumber = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateNewFile_Click(object sender, RoutedEventArgs e)
        {
            CreateFile();
        }

        private void CreateFile()
        {
            string NewName = "NewItem" + FileNumber;
            FileNumber++;
            MainTab.Items.Add(new TabItem
            {
                Header = "Новый файл",
                Name = NewName
            });
        }
    }
}
