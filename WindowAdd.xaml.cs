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
    /// Логика взаимодействия для WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        Context context = new Context();
        public WindowAdd()
        {
            InitializeComponent();
            var authors = (from item in context.Authors
                           select new { item.Author_Name }).ToList();
            List<string> items = new List<string>();
            foreach(var item in authors)
            {
                items.Add(item.Author_Name);
            }
            items.Add("Добавить нового автора");
            AuthorSong.ItemsSource = items;
        }

        private void addAuthor(object sender, RoutedEventArgs e)
        {
            using (Context db = new Context())
            {
                Author author = new Author();
                author.Author_Name = AuthorName.Text;
                author.Age =  Int32.Parse(Age.Text);
                db.Authors.Add(author);
                db.SaveChanges();
                MessageBox.Show($"Информация об авторе {author.Author_Name} была добавлена в БД");
            }
            var authors = (from item in context.Authors
                           select new { item.Author_Name }).ToList();
            List<string> items = new List<string>();
            foreach (var item in authors)
            {
                items.Add(item.Author_Name);
            }
            items.Add("Добавить нового автора");
            AuthorSong.ItemsSource = items;
        }

        private void AddSong(object sender, RoutedEventArgs e)
        {
            using (Context db = new Context())
            {
                try
                {
                    Song song = new Song();
                    song.Author = AuthorSong.Text;
                    song.Name = SongName.Text;
                    db.Songs.Add(song);
                    db.SaveChanges();
                    MessageBox.Show($"Информация о песне {song.Name} была добавлена в БД!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
            }
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            Hide();
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AuthorSong.SelectedItem.ToString() == "Добавить нового автора")
            {
                AuthorName.Focus();
            }
        }
    }
}
