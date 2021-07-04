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

namespace pm2.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        List<Книги> mainBooks = Classes.Base.ent.Книги.ToList();
        List<Книги> secondBooks = new List<Книги>(); //отрисовка

        int i = -1;
        public Page1()
        {
            InitializeComponent();
            secondBooks = mainBooks;
            DGBooks.ItemsSource = secondBooks;
        }

        

        private void MediaElement_Initialized(object sender, EventArgs e)
        {
            i++;
            if (i < secondBooks.Count)
            {
                
                MediaElement ME = (MediaElement)sender;
                Книги B = secondBooks[i];
                Uri U = new Uri(B.Обложка, UriKind.RelativeOrAbsolute);
                ME.Source = U;
            }
        }

        private void StackPanel_Initialized(object sender, EventArgs e)
        {
            if (i < secondBooks.Count)
            {

                StackPanel SP = (StackPanel)sender;
                Книги B = secondBooks[i];
            }
        }

        private void nameBook_Initialized(object sender, EventArgs e)
        {
            if (i < secondBooks.Count)
            {
                TextBlock TB = (TextBlock)sender;
                Книги B = secondBooks[i];
                TB.Text = "Название: " + B.Название;

            }
        }

        private void autorBook_Initialized(object sender, EventArgs e)
        {
            if (i < secondBooks.Count)
            {
                TextBlock TB = (TextBlock)sender;
                Книги B = secondBooks[i];
                TB.Text = "Автор: " + Convert.ToString(B.Авторы.Автор);

            }
        }

        private void priceBook_Initialized(object sender, EventArgs e)
        {
            if (i < secondBooks.Count)
            {
                TextBlock TB = (TextBlock)sender;
                Книги B = secondBooks[i];
                TB.Text = "Цена: " + Convert.ToString(B.Цена) + "руб.";

            }
        }

        private void marketBook_Initialized(object sender, EventArgs e)
        {
            if (i < secondBooks.Count)
            {
                TextBlock TB = (TextBlock)sender;
                Книги B = secondBooks[i];
                TB.Text = "Наличие в магазине: " + Convert.ToString(B.Количество_магазин);

            }
        }

        private void depotBook_Initialized(object sender, EventArgs e)
        {
            if (i < secondBooks.Count)
            {
                TextBlock TB = (TextBlock)sender;
                Книги B = secondBooks[i];
                TB.Text = "Наличие на складе: " + Convert.ToString(B.Количество_склад);
                if (B.Количество_склад > 5)
                {
                    TB.Text = "много";
                }

            }
        }

    }
}
