using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Diplomm
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static LibraryDBEntities DB = new LibraryDBEntities();
        public static Books change_bk = new Books();
        public static Readers change_rd = new Readers();
    }
}
