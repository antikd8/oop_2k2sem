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

namespace lab11
{
    /// <summary>
    /// Логика взаимодействия для EditAuthor.xaml
    /// </summary>
    public partial class EditAuthor : Window
    {
        string Name;
        public EditAuthor(string AuthorName)
        {
            InitializeComponent();
            Name = AuthorName;
            using (Context db = new Context())
            {
                Author author = db.Authors.Find(Name);
                AuthorNameTBox.Text = author.Author_Name;
                AgeTBox.Text = author.Age.ToString();
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            using (Context db = new Context())
            {
                try
                {
                    if (Name != AuthorNameTBox.Text)
                    {
                        Author authorUPD = new Author();
                        authorUPD.Author_Name = AuthorNameTBox.Text;
                        authorUPD.Age = Int32.Parse(AgeTBox.Text);

                        db.Authors.Add(authorUPD);
                        db.SaveChanges();

                        db.Database.ExecuteSqlCommand($@"update Songs set Author = '{authorUPD.Author_Name}' where Author = '{Name}'");

                        db.Database.ExecuteSqlCommand($@"delete Authors where Author_Name = '{Name}'");

                    }
                    else
                        db.Database.ExecuteSqlCommand($@"update Authors set Age={AgeTBox.Text} where Author_Name = '{Name}'");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show("Данные успешно обновлены!");
        }
    }
}
