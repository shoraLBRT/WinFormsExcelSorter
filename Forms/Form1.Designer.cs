namespace FinConnectWinFormsTest
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
            SortButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // SortButton
            // 
            SortButton.Location = new Point(38, 74);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(275, 50);
            SortButton.TabIndex = 0;
            SortButton.Text = "Отсортировать таблицу";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Excel Files|*.xlsx;*.xls";
            openFileDialog1.Title = "Выберите файл Excel для сортировки";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 207);
            Controls.Add(SortButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button SortButton;
        private OpenFileDialog openFileDialog1;
    }
}
