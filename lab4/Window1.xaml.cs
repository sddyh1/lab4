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

namespace lab4
{

    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var currentTextBox = sender as TextBox;
            var parentPanel = currentTextBox?.Parent as StackPanel;



            // Сбрасываем все TextBox в колонке к маленькому стилю
            foreach (TextBox child in parentPanel.Children.OfType<TextBox>())
            {
                child.Style = (Style)Resources["SmallTextBoxStyle"];
            }

            // Устанавливаем большому TextBox соответствующий стиль
            currentTextBox.Style = (Style)Resources["LargeTextBoxStyle"];
        }
    }
}
