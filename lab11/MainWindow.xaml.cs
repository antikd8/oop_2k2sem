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
            using (Context db = new Context())
            {

                // создаем объекты Song
            //    Author temp1 = new Author { Author_Name = "t1st", Age = 34 };


                // добавляем объекты Song в контекст данных

       //         db.Authors.Add(temp1);

         //       db.SaveChanges();

         //       Song temp = new Song { Id = 1, Name = "nice song", Author = temp1.Author_Name };

         //       db.Songs.Add(temp);

                // сохраняем контекст данных в базу данных
        //        db.SaveChanges();
            }
            flatGrid.ItemsSource = (from item in context.Songs
                                    select new { item.Id, item.Author, item.Name }).ToList();
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

    class Context : DbContext
    {
        public Context() : base("connectionDB") { }

        public DbSet<Song> Songs { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
