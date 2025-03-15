namespace Avia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            buttonGetSeatInfo = new Button();
            dataGridView2 = new DataGridView();
            labelPassengerName = new Label();
            labelTicketNumber = new Label();
            label1 = new Label();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 75);
            dataGridView1.TabIndex = 0;
            // 
            // buttonGetSeatInfo
            // 
            buttonGetSeatInfo.Font = new Font("Segoe UI", 12F);
            buttonGetSeatInfo.Location = new Point(171, 266);
            buttonGetSeatInfo.Name = "buttonGetSeatInfo";
            buttonGetSeatInfo.Size = new Size(408, 42);
            buttonGetSeatInfo.TabIndex = 1;
            buttonGetSeatInfo.Text = "Нажмите для поиска места в самолете";
            buttonGetSeatInfo.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(195, 314);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(384, 70);
            dataGridView2.TabIndex = 2;
            // 
            // labelPassengerName
            // 
            labelPassengerName.AutoSize = true;
            labelPassengerName.BackColor = SystemColors.GradientInactiveCaption;
            labelPassengerName.Font = new Font("Segoe UI", 12F);
            labelPassengerName.Location = new Point(63, 172);
            labelPassengerName.Name = "labelPassengerName";
            labelPassengerName.Size = new Size(52, 21);
            labelPassengerName.TabIndex = 3;
            labelPassengerName.Text = "label1";
            // 
            // labelTicketNumber
            // 
            labelTicketNumber.AutoSize = true;
            labelTicketNumber.BackColor = SystemColors.GradientInactiveCaption;
            labelTicketNumber.Font = new Font("Segoe UI", 12F);
            labelTicketNumber.Location = new Point(63, 215);
            labelTicketNumber.Name = "labelTicketNumber";
            labelTicketNumber.Size = new Size(52, 21);
            labelTicketNumber.TabIndex = 4;
            labelTicketNumber.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(48, 33);
            label1.Name = "label1";
            label1.Size = new Size(345, 45);
            label1.TabIndex = 5;
            label1.Text = "Информация о рейсе:";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(693, 404);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(95, 34);
            exitButton.TabIndex = 6;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(label1);
            Controls.Add(labelTicketNumber);
            Controls.Add(labelPassengerName);
            Controls.Add(dataGridView2);
            Controls.Add(buttonGetSeatInfo);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonGetSeatInfo;
        private DataGridView dataGridView2;
        private Label labelPassengerName;
        private Label labelTicketNumber;
        private Label label1;
        private Button exitButton;
    }
}
