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

namespace Diplomm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UPDATE();
        }


        public void UPDATE()
        {
            var ListBook = App.DB.Books.ToList();
            ListView.ItemsSource = ListBook;


            if (Poisk != null)
            {
                var search = Poisk.Text;
                ListBook = App.DB.Books.Where(a => a.Title.StartsWith(search)).ToList();
            }


        }

        //Добавление книги
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Books book1 = new Books
            {
                Title = Titlebox.Text,
                Author = AuthorBox.Text,
                Year = Convert.ToInt32(YearBox.Text),
                Genre = GenreBox.Text
            };
            App.DB.Books.Add(book1);
            App.DB.SaveChanges();
            UPDATE();
        }

        //Удаление книги
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var Delete = (Button)sender;
            var book1 = (Books)Delete.DataContext;

            App.DB.Books.Remove(book1);
            App.DB.SaveChanges();
            UPDATE();
            MessageBox.Show($"Запись о книге {book1.Title} удалена.");
        }

        //Изменения о книге
        private void ChangeButton(object sender, RoutedEventArgs e)
        {
            var Delete = (Button)sender;
            var book1 = (Books)Delete.DataContext;

            Titlebox.Text = book1.Title;
            AuthorBox.Text = book1.Author;
            YearBox.Text = book1.Year.ToString();
            GenreBox.Text = book1.Genre;

            App.change_bk = book1;
        }

        private void Saves(object sender, RoutedEventArgs e)
        {
            var chan_book = App.DB.Books.Where(a => a.AuthorId == App.change_bk.AuthorId).FirstOrDefault();
            chan_book.Title = Titlebox.Text;
            chan_book.Author = AuthorBox.Text;
            chan_book.Year = Convert.ToInt32(YearBox.Text);
            chan_book.Genre = GenreBox.Text;

            App.DB.SaveChanges();
            UPDATE();

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UPDATE();

        }

        private void Poisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            UPDATE();
        }
    }
}
