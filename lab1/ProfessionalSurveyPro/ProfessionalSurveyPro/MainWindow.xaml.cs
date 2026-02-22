using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

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
            // 1. Валідація
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Будь ласка, введіть ім'я!", "Увага", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            try
            {
                // 2. Збір даних
                string name = txtName.Text;
                double difficulty = sldDifficulty.Value;
                string level = (cmbLevel.SelectedItem as ComboBoxItem)?.Content.ToString();

                // Отримання обраного RadioButton
                string rating = panelRating.Children.OfType<RadioButton>()
                                .FirstOrDefault(r => r.IsChecked == true)?.Content.ToString();

                // Отримання обраних CheckBox
                var modules = panelModules.Children.OfType<CheckBox>()
                              .Where(c => c.IsChecked == true).Select(c => c.Content.ToString());
                string selectedModules = modules.Any() ? string.Join(", ", modules) : "Не обрано";

                string comments = txtComments.Text;

                // 3. Формування звіту
                string report = $"[WPF PREMIUM REPORT - {DateTime.Now}]\n" +
                                $"Користувач: {name}\n" +
                                $"Складність: {difficulty}/10\n" +
                                $"Рівень: {level}\n" +
                                $"Оцінка лекцій: {rating}\n" +
                                $"Модулі: {selectedModules}\n" +
                                $"Відгук: {comments}\n" +
                                $"------------------------------------------\n";

                // 4. Асинхронний запис у файл (щоб UI не фрізився)
                await Task.Run(() => File.AppendAllText("survey_wpf.txt", report));

                MessageBox.Show("Дані успішно збережено у файл survey_wpf.txt", "Успіх", MessageBoxButton.OK, MessageBoxImage.Information);

                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Критична помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ResetForm()
        {
            txtName.Clear();
            sldDifficulty.Value = 5;
            cmbLevel.SelectedIndex = 0;
            txtComments.Clear();
            foreach (var cb in panelModules.Children.OfType<CheckBox>()) cb.IsChecked = false;
        }
    }
}