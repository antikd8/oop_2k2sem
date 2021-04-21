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
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Configuration;

namespace lab10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string connectionString;
        SqlDataAdapter adapter;
        DataTable dataTable;
        public MainWindow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;
        }

        private void win_Loaded(object sender, RoutedEventArgs e)
        {
            string sql = "select * from flat";
            dataTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(dataTable);
                flatGrid.ItemsSource = dataTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

        }

        private void Update(object sender, RoutedEventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            adapter.Update(dataTable);
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (flatGrid.SelectedItems != null)
            {
                for (int i = 0; i < flatGrid.SelectedItems.Count; i++)
                {
                    DataRowView datarowView = flatGrid.SelectedItems[i] as DataRowView;
                    if (datarowView != null)
                    {
                        DataRow dataRow = (DataRow)datarowView.Row;
                        dataRow.Delete();
                    }
                }
            }
            Update(sender,e);
        }

        private void MoveToPrev(object sender, RoutedEventArgs e)
        {
            if (flatGrid.SelectedItem != null)
            {
                if (flatGrid.SelectedIndex == 0)
                    return;
                flatGrid.SelectedIndex = flatGrid.SelectedIndex - 1;
            }
        }

        private void MoveToNext(object sender, RoutedEventArgs e)
        {
            if (flatGrid.SelectedItem != null)
            {
                if (flatGrid.SelectedIndex == flatGrid.Items.Count)
                    return;
                flatGrid.SelectedIndex = flatGrid.SelectedIndex + 1;
            }
        }

        private void Click_Transact(object sender, RoutedEventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;

                try
                {
                    command.CommandText = "update flat set footage += 5";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert into flat values (10,10,1,'1990-04-05','Плиты','Бирули,8а',null)";
                    command.ExecuteNonQuery();

                    // подтверждаем транзакцию
                    transaction.Commit();
                    MessageBox.Show("Данные добавлены в базу данных");
                    win_Loaded(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
            }
        }
    }
}
