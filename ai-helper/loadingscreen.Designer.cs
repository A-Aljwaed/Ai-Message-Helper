namespace ai_helper
{
    partial class loadingscreen
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
            button5 = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button5.Location = new Point(21, 35);
            button5.Name = "button5";
            button5.Size = new Size(217, 132);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(423, 300);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(636, 23);
            textBox2.TabIndex = 5;
            // 
            // loadingscreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1093, 450);
            Controls.Add(textBox2);
            Controls.Add(button5);
            Name = "loadingscreen";
            Text = "loading";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private TextBox textBox2;
    }
}
