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

namespace pr7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, RoutedEventArgs e)
        {
            // Обработчик события нажатия на кнопку "Открыть"
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            // Обработчик события нажатия на кнопку "Очистить"
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            // Обработчик события нажатия на кнопку "Закрыть"
        }

        private void comboBoxStyle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Обработчик события изменения выбранного элемента в ComboBox
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Обработчик события изменения текста в любом из текстовых полей
        }
    }
}
