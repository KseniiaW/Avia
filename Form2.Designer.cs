namespace Avia
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSearch = new Button();
            phoneNumberTextBox = new TextBox();
            passengerNameTextBox = new TextBox();
            label2 = new Label();
            labelticketNumber = new Label();
            label1 = new Label();
            label3 = new Label();
            exitButton = new Button();
            SuspendLayout();
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(311, 323);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(179, 56);
            buttonSearch.TabIndex = 0;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(350, 150);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(100, 23);
            phoneNumberTextBox.TabIndex = 1;
            // 
            // passengerNameTextBox
            // 
            passengerNameTextBox.Location = new Point(350, 256);
            passengerNameTextBox.Name = "passengerNameTextBox";
            passengerNameTextBox.Size = new Size(100, 23);
            passengerNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(283, 187);
            label2.Name = "label2";
            label2.Size = new Size(246, 28);
            label2.TabIndex = 4;
            label2.Text = "Введите Фамилию и Имя ";
            // 
            // labelticketNumber
            // 
            labelticketNumber.AutoSize = true;
            labelticketNumber.BackColor = SystemColors.GradientInactiveCaption;
            labelticketNumber.Font = new Font("Segoe UI", 15F);
            labelticketNumber.Location = new Point(283, 83);
            labelticketNumber.Name = "labelticketNumber";
            labelticketNumber.Size = new Size(242, 28);
            labelticketNumber.TabIndex = 3;
            labelticketNumber.Text = "Введите номер телефона";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Location = new Point(323, 111);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 5;
            label1.Text = " (например +70875110463)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Location = new Point(311, 215);
            label3.Name = "label3";
            label3.Size = new Size(184, 15);
            label3.TabIndex = 6;
            label3.Text = "(например TATYANA ANDREEVA)";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(657, 388);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(95, 34);
            exitButton.TabIndex = 7;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(labelticketNumber);
            Controls.Add(passengerNameTextBox);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(buttonSearch);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSearch;
        private TextBox phoneNumberTextBox;
        private TextBox passengerNameTextBox;
        private Label label2;
        private Label labelticketNumber;
        private Label label1;
        private Label label3;
        private Button exitButton;
    }
}