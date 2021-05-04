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
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Context context = new Context();
        public MainWindow()
        {
            InitializeComponent();
            UpdateInfo();

        }

        private void UpdateInfo()
        {
            flatGrid.ItemsSource = (from item in context.Songs
                                    select new { item.Id, item.Author, item.Name }).ToList();
            AuthorGrid.ItemsSource = (from item in context.Authors
                                      select new { item.Author_Name, item.Age }).ToList();

            var authors = (from item in context.Authors
                           select new { item.Author_Name }).ToList();
            List<string> items = new List<string>();
            foreach (var item in authors)
                items.Add(item.Author_Name);
            AuthorNameComboBox.ItemsSource = items;

            var songs = (from item in context.Songs
                         select new { item.Id, item.Author, item.Name }).ToList();
            List<string> songsCombo = new List<string>();
            foreach (var item in songs)
                songsCombo.Add(item.Id.ToString());
            IdSongComboBox.ItemsSource = songsCombo;
        }


        private void MoveToPrev(object sender, RoutedEventArgs e)
        {
            if (flatGrid.SelectedItem != null)
            {
                if (flatGrid.SelectedIndex == 0)
                    return;
                flatGrid.SelectedIndex = flatGrid.SelectedIndex - 1;
            }
            if (AuthorGrid.SelectedItem != null)
            {
                if (AuthorGrid.SelectedIndex == 0)
                    return;
                AuthorGrid.SelectedIndex = AuthorGrid.SelectedIndex - 1;
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
            if (AuthorGrid.SelectedItem != null)
            {
                if (AuthorGrid.SelectedIndex == AuthorGrid.Items.Count)
                    return;
                AuthorGrid.SelectedIndex = AuthorGrid.SelectedIndex + 1;
            }
        }

        private void Transaction(object sender, RoutedEventArgs e)
        {
            using (Context db = new Context())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Database.ExecuteSqlCommand(@"update Authors set Age = 56 where Author_Name = 'ABC'");

                        db.Authors.Add(new Author { Author_Name = "new author", Age = 55 });

                        db.SaveChanges();

                        transaction.Commit();
                        MessageBox.Show("Транзация выполнена успешно!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            UpdateInfo();
        }


        private void Create(object sender, RoutedEventArgs e)
        {
            WindowAdd window = new WindowAdd();
            window.Show();
            Hide();
        }


        private void DeleteSong_Click(object sender, RoutedEventArgs e)
        {
            using(Context db = new Context())
            {
                db.Database.ExecuteSqlCommand($@"delete from Songs where Id = {IdSongComboBox.Text}");
            }
            UpdateInfo();
        }

        private void DeleteAuthor_Click(object sender, RoutedEventArgs e)
        {
            using (Context db = new Context())
            {
                db.Database.ExecuteSqlCommand($@"delete from Songs where Author = '{AuthorNameComboBox.Text}'");
                db.Database.ExecuteSqlCommand($@"delete from Authors where Author_Name = '{AuthorNameComboBox.Text}'");
            }
            UpdateInfo();
        }

        private void UpdateSong_Click(object sender, RoutedEventArgs e)
        {
            if (IdSongComboBox.SelectedItem != null)
            {
                EditSong window = new EditSong(Int32.Parse(IdSongComboBox.Text));
                window.Show();
            }
            else MessageBox.Show("Выберите Id песни!");
        }

        private void UpdateInfo(object sender, RoutedEventArgs e)
        {
            UpdateInfo();
        }

        private void UpdateAuthor_Click(object sender, RoutedEventArgs e)
        {
            EditAuthor window = new EditAuthor(AuthorNameComboBox.Text);
            window.Show();
        }
    }

    [Table("Songs")]
    public class Song
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
    }
    [Table("Authors")]
    public class Author
    {
        [Key]
        public string Author_Name { get; set; }
        public int Age { get; set; }
    }

    public class Context : DbContext
    {
        public Context() : base("connectionDB") { }

        public DbSet<Song> Songs { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
