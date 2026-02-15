using Microsoft.Win32; 
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace ProfessionalSurveyPro
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string answer = txtAnswer.Text.Trim();

            
            if (answer.Length < 5)
            {
                MessageBox.Show("Відповідь занадто коротка. Напишіть хоча б кілька слів.",
                                "Увага", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = $"Survey_{DateTime.Now:yyyyMMdd_HHmm}.txt",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    
                    string report = $"=== ЗВІТ ОПИТУВАННЯ ===\n" +
                                    $"Час: {DateTime.Now}\n" +
                                    $"Користувач: {Environment.UserName}\n" +
                                    $"Відповідь:\n{answer}\n" +
                                    $"=======================\n";

                   
                    await Task.Run(() => File.AppendAllText(saveFileDialog.FileName, report));

                    MessageBox.Show("Дані успішно експортовані!", "Успіх",
                                    MessageBoxButton.OK, MessageBoxImage.Information);
                    txtAnswer.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка доступу до файлу: {ex.Message}",
                                    "Критична помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}