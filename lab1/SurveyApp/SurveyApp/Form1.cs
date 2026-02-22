using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SurveyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Ініціалізація випадаючого списку
            cmbSource.Items.AddRange(new string[] { "Соцмережі", "Від друзів", "Реклама", "Інше" });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Валідація імені
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Вкажіть ваше ім'я!"); return;
                }

                // 2. Збір даних з різних компонентів
                string name = txtName.Text;
                decimal age = numAge.Value;
                string source = cmbSource.SelectedItem?.ToString() ?? "Не вказано";

                // Оцінка (вибір одного з RadioButtons)
                string rating = panelRating.Controls.OfType<RadioButton>()
                                .FirstOrDefault(r => r.Checked)?.Text ?? "Немає оцінки";

                // Улюблені теми (вибір декількох з CheckBoxes)
                var topics = groupTopics.Controls.OfType<CheckBox>()
                             .Where(c => c.Checked).Select(c => c.Text);
                string selectedTopics = topics.Any() ? string.Join(", ", topics) : "Нічого не обрано";

                // 3. Формування професійного звіту
                string report = $"=== АНКЕТА КОРИСТУВАЧА ({DateTime.Now}) ===\n" +
                                $"Ім'я: {name}\nВік: {age}\n" +
                                $"Джерело: {source}\nОцінка: {rating}\n" +
                                $"Цікаві теми: {selectedTopics}\n" +
                                $"------------------------------------------\n";

                // 4. Запис
                File.AppendAllText("survey_results.txt", report);
                MessageBox.Show("Анкету успішно збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            txtName.Clear();
            numAge.Value = 18;
            cmbSource.SelectedIndex = -1;
            foreach (var rb in panelRating.Controls.OfType<RadioButton>()) rb.Checked = false;
            foreach (var cb in groupTopics.Controls.OfType<CheckBox>()) cb.Checked = false;
        }
    }
}