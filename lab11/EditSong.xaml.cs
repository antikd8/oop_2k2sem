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
    /// Логика взаимодействия для EditSong.xaml
    /// </summary>
    public partial class EditSong : Window
    {
        Context context = new Context();
        int Id;
        public EditSong(int Id)
        {
            InitializeComponent();
            var authors = (from item in context.Authors
                           select new { item.Author_Name }).ToList();
            List<string> items = new List<string>();
            foreach (var item in authors)
            {
                items.Add(item.Author_Name);
            }
            AuthorNameCBox.ItemsSource = items;
            this.Id = Id;
            using (Context db = new Context())
            {
                Song song = db.Songs.Find(Id);
                SongNameTBox.Text = song.Name;
                AuthorNameCBox.Text = song.Author;
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            using (Context db = new Context())
            {
                db.Database.ExecuteSqlCommand($@"update Songs set Name = '{SongNameTBox.Text}' where Id = {Id}");
                db.Database.ExecuteSqlCommand($@"update Songs set Author = '{AuthorNameCBox.Text}' where Id  = {Id}");
                MessageBox.Show($"Информация обновлена!{Id}");
            }
        }
    }
}
