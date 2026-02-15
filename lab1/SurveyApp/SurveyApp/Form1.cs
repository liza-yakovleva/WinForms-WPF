using System.IO;

namespace SurveyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            string answer = txtAnswer.Text;

            if (string.IsNullOrWhiteSpace(answer))
            {
                MessageBox.Show("Будь ласка, введіть відповідь!");
                return;
            }

           
            string dataToSave = $"Дата: {DateTime.Now}\nВідповідь: {answer}\n-------------------\n";

            try
            {
                
                File.AppendAllText("survey_results.txt", dataToSave);

                
                MessageBox.Show("Вашу відповідь збережено у файл survey_results.txt!");
                txtAnswer.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні: {ex.Message}");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
