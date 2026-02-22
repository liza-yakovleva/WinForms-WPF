namespace SurveyApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelName = new Label();
            txtName = new TextBox();
            labelAge = new Label();
            numAge = new NumericUpDown();
            labelSource = new Label();
            cmbSource = new ComboBox();
            groupTopics = new GroupBox();
            cbNet = new CheckBox();
            cbDB = new CheckBox();
            cbCSharp = new CheckBox();
            panelRating = new Panel();
            labelRating = new Label();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            groupTopics.SuspendLayout();
            panelRating.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.DarkSlateBlue;
            labelTitle.Location = new Point(30, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(338, 35);
            labelTitle.TabIndex = 9;
            labelTitle.Text = "Професійне опитування";
            // 
            // labelName
            // 
            labelName.Location = new Point(35, 75);
            labelName.Name = "labelName";
            labelName.Size = new Size(200, 25);
            labelName.TabIndex = 8;
            labelName.Text = "1. Ваше ім'я:";
            // 
            // txtName
            // 
            txtName.Location = new Point(35, 105);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 34);
            txtName.TabIndex = 7;
            // 
            // labelAge
            // 
            labelAge.Location = new Point(35, 155);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(200, 25);
            labelAge.TabIndex = 6;
            labelAge.Text = "2. Ваш вік:";
            // 
            // numAge
            // 
            numAge.Location = new Point(35, 185);
            numAge.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
            numAge.Name = "numAge";
            numAge.Size = new Size(120, 34);
            numAge.TabIndex = 5;
            numAge.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // labelSource
            // 
            labelSource.Location = new Point(35, 235);
            labelSource.Name = "labelSource";
            labelSource.Size = new Size(300, 25);
            labelSource.TabIndex = 4;
            labelSource.Text = "3. Звідки дізналися про нас?";
            // 
            // cmbSource
            // 
            cmbSource.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSource.Location = new Point(35, 265);
            cmbSource.Name = "cmbSource";
            cmbSource.Size = new Size(250, 34);
            cmbSource.TabIndex = 3;
            // 
            // groupTopics
            // 
            groupTopics.Controls.Add(cbNet);
            groupTopics.Controls.Add(cbDB);
            groupTopics.Controls.Add(cbCSharp);
            groupTopics.Location = new Point(35, 320);
            groupTopics.Name = "groupTopics";
            groupTopics.Size = new Size(282, 160);
            groupTopics.TabIndex = 2;
            groupTopics.TabStop = false;
            groupTopics.Text = "4. Цікаві теми";
            // 
            // cbNet
            // 
            cbNet.Location = new Point(15, 115);
            cbNet.Name = "cbNet";
            cbNet.Size = new Size(247, 39);
            cbNet.TabIndex = 0;
            cbNet.Text = "Комп'ютерні мережі";
            // 
            // cbDB
            // 
            cbDB.Location = new Point(15, 75);
            cbDB.Name = "cbDB";
            cbDB.Size = new Size(213, 34);
            cbDB.TabIndex = 1;
            cbDB.Text = "Бази даних";
            // 
            // cbCSharp
            // 
            cbCSharp.Location = new Point(15, 35);
            cbCSharp.Name = "cbCSharp";
            cbCSharp.Size = new Size(104, 24);
            cbCSharp.TabIndex = 2;
            cbCSharp.Text = "C# Програмування";
            // 
            // panelRating
            // 
            panelRating.BorderStyle = BorderStyle.FixedSingle;
            panelRating.Controls.Add(labelRating);
            panelRating.Controls.Add(radioButton5);
            panelRating.Controls.Add(radioButton4);
            panelRating.Controls.Add(radioButton3);
            panelRating.Controls.Add(radioButton2);
            panelRating.Controls.Add(radioButton1);
            panelRating.Location = new Point(380, 105);
            panelRating.Name = "panelRating";
            panelRating.Size = new Size(280, 280);
            panelRating.TabIndex = 1;
            // 
            // labelRating
            // 
            labelRating.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            labelRating.Location = new Point(10, 10);
            labelRating.Name = "labelRating";
            labelRating.Size = new Size(250, 30);
            labelRating.TabIndex = 0;
            labelRating.Text = "5. Оцінка навчання (1-5)";
            // 
            // radioButton5
            // 
            radioButton5.Location = new Point(20, 210);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(162, 31);
            radioButton5.TabIndex = 1;
            radioButton5.Text = "5 - Відмінно";
            // 
            // radioButton4
            // 
            radioButton4.Location = new Point(20, 170);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(147, 34);
            radioButton4.TabIndex = 2;
            radioButton4.Text = "4 - Дуже добре";
            // 
            // radioButton3
            // 
            radioButton3.Location = new Point(20, 130);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(199, 34);
            radioButton3.TabIndex = 3;
            radioButton3.Text = "3 - Добре";
            // 
            // radioButton2
            // 
            radioButton2.Location = new Point(20, 90);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(186, 34);
            radioButton2.TabIndex = 4;
            radioButton2.Text = "2 - Достатньо";
            // 
            // radioButton1
            // 
            radioButton1.Location = new Point(20, 50);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(199, 34);
            radioButton1.TabIndex = 5;
            radioButton1.Text = "1 - Незадовільно";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SlateBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(380, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(280, 65);
            btnSave.TabIndex = 0;
            btnSave.Text = "ЗБЕРЕГТИ АНКЕТУ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(710, 520);
            Controls.Add(btnSave);
            Controls.Add(panelRating);
            Controls.Add(groupTopics);
            Controls.Add(cmbSource);
            Controls.Add(labelSource);
            Controls.Add(numAge);
            Controls.Add(labelAge);
            Controls.Add(txtName);
            Controls.Add(labelName);
            Controls.Add(labelTitle);
            Font = new Font("Times New Roman", 13.8F);
            Name = "Form1";
            Text = "Система Опитування v2.0";
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            groupTopics.ResumeLayout(false);
            panelRating.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelName;
        private TextBox txtName;
        private Label labelAge;
        private NumericUpDown numAge;
        private Label labelSource;
        private ComboBox cmbSource;
        private GroupBox groupTopics;
        private CheckBox cbNet;
        private CheckBox cbDB;
        private CheckBox cbCSharp;
        private Panel panelRating;
        private Label labelRating;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button btnSave;
    }
}