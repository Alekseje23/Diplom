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

namespace Diplomm
{
    /// <summary>
    /// Логика взаимодействия для Clients.xaml
    /// </summary>
    public partial class Clients : Window
    {
        public Clients()
        {
            InitializeComponent();
        }

        public void Update()
        {
            var ListRead = App.DB.Readers.ToList();
            ListView.ItemsSource = ListRead;


            if (Poisk != null)
            {
                var search = Poisk.Text;
                ListRead = App.DB.Readers.Where(a => a.FirstName.StartsWith(search)).ToList();
            }

        }



        //Добавление книги
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Readers read = new Readers
            {
                FirstName = Firstbox.Text,
                LastName = LastBox.Text,
                Email = EmailBox.Text,
                Phone = PhoneBox.Text
            };
            App.DB.Readers.Add(read);
            App.DB.SaveChanges();
            Update();
        }

        //Удаление книги
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var Delete = (Button)sender;
            var read1 = (Readers)Delete.DataContext;

            App.DB.Readers.Remove(read1);
            App.DB.SaveChanges();
            Update();
            MessageBox.Show($"Запись о книге {read1.FirstName} {read1.LastName} удалена.");
        }

        //Изменения о книге
        private void ChangeButton(object sender, RoutedEventArgs e)
        {
            var Delete = (Button)sender;
            var read1 = (Readers)Delete.DataContext;

            Firstbox.Text = read1.FirstName;
            LastBox.Text = read1.LastName;
            EmailBox.Text = read1.Email;
            PhoneBox.Text = read1.Phone;

            App.change_rd = read1;
        }

        private void Saves(object sender, RoutedEventArgs e)
        {
            var chan_read = App.DB.Readers.Where(a => a.ReaderId == App.change_rd.ReaderId).FirstOrDefault();
            chan_read.FirstName = Firstbox.Text;
            chan_read.LastName = LastBox.Text;
            chan_read.Email = EmailBox.Text;
            chan_read.Phone = PhoneBox.Text;

            App.DB.SaveChanges();
            Update();

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();

        }

        private void Poisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }




    }
}
