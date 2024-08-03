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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpGame();

        }

        private void SetUpGame()
        {
            List<string> AnimalEmoji = new List<string>()
            {
                "🐷","🐷",
                "🐶","🐶",
                "💩","💩",
                "🦒","🦒",
                "👻","👻",
                "🐔","🐔",
                "🐸"," 🐸",
                "🦄","🦄",
            };
            
            Random rnd = new Random();

            foreach (TextBlock TextBlock in MainGrid.Children.OfType<TextBlock>())
            {
                int index = rnd.Next(AnimalEmoji.Count);
                string NextEmoji = AnimalEmoji[index];
                TextBlock.Text = NextEmoji;
                AnimalEmoji.RemoveAt(index);
            }
        }
    }
}
