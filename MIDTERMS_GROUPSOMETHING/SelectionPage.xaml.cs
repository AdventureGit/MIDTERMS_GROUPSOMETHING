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

namespace MIDTERMS_GROUPSOMETHING
{
    /// <summary>
    /// Interaction logic for SelectionPage.xaml
    /// </summary>
    public partial class SelectionPage : Window
    {
        public SelectionPage()
        {
            InitializeComponent();
        }

        private void AddItemButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            AddItem addItem = new AddItem();
            addItem.Show();
        }

        private void SearchEditButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            SearchEdit searchEdit = new SearchEdit();
            searchEdit.Show();
        }

        private void LogsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Logs logs = new Logs();
            logs.Show();
        }
    }
}
