using System;
using System.Collections.Generic;
using System.Data.OleDb;
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

namespace ClassWork6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        OleDbConnection cn;

        public MainWindow()
        {
            InitializeComponent();
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ClassWork6.accdb");


        }

        //Reads Through the Assets Table
        private void SeeAssets_Click(object sender, RoutedEventArgs e)
        {
            string query = "select * from Assets";
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            string data = "";
            while (read.Read())
            {
                data += read[0].ToString() + " " + read[1].ToString() + " " + read[2].ToString() + "\n";

            }
            data = "All data from Assets Table: \n"+ data;
            TextBox.Text = data;

            cn.Close();
            
        }

        //Text Box 
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        { 

        }

        //Reads Through the Employees Table
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string query = "select * from Employees";
            OleDbCommand cmd = new OleDbCommand(query, cn);
            cn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            string data = "";
            while (read.Read())
            {
                data += read[0].ToString() + " " + read[1].ToString() + " " + read[2].ToString() + "\n";

            }
            data = "All data from Employees Table: \n" + data;
            TextBox.Text = data;

            cn.Close();
        }
    }
}
