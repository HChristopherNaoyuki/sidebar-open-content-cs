using System.Windows;

namespace sidebar_open_content_cs
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HideAllPages()
        {
            ChatsPage.Visibility = Visibility.Collapsed;
            RemindersPage.Visibility = Visibility.Collapsed;
            QuizPage.Visibility = Visibility.Collapsed;
            ActivityPage.Visibility = Visibility.Collapsed;
        }

        private void Chats_Click(object sender, RoutedEventArgs e)
        {
            HideAllPages();
            ChatsPage.Visibility = Visibility.Visible;
        }

        private void Reminders_Click(object sender, RoutedEventArgs e)
        {
            HideAllPages();
            RemindersPage.Visibility = Visibility.Visible;
        }

        private void Quiz_Click(object sender, RoutedEventArgs e)
        {
            HideAllPages();
            QuizPage.Visibility = Visibility.Visible;
        }

        private void Activity_Click(object sender, RoutedEventArgs e)
        {
            HideAllPages();
            ActivityPage.Visibility = Visibility.Visible;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}