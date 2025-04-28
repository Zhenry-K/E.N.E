namespace ENE
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
            button1 = new Button();
            Pass_block = new TextBox();
            Pass_Button = new Button();
            User_Button = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(111, 117);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(176, 52);
            button1.TabIndex = 0;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Pass_block
            // 
            Pass_block.BackColor = SystemColors.Window;
            Pass_block.BorderStyle = BorderStyle.FixedSingle;
            Pass_block.Font = new Font("Mojangles", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pass_block.Location = new Point(78, 325);
            Pass_block.Multiline = true;
            Pass_block.Name = "Pass_block";
            Pass_block.RightToLeft = RightToLeft.No;
            Pass_block.Size = new Size(239, 45);
            Pass_block.TabIndex = 1;
            Pass_block.TextAlign = HorizontalAlignment.Center;
            // 
            // Pass_Button
            // 
            Pass_Button.Enabled = false;
            Pass_Button.Location = new Point(78, 285);
            Pass_Button.Name = "Pass_Button";
            Pass_Button.Size = new Size(239, 34);
            Pass_Button.TabIndex = 2;
            Pass_Button.Text = "Contraseña";
            Pass_Button.UseVisualStyleBackColor = true;
            // 
            // User_Button
            // 
            User_Button.Enabled = false;
            User_Button.Location = new Point(78, 193);
            User_Button.Name = "User_Button";
            User_Button.Size = new Size(239, 34);
            User_Button.TabIndex = 4;
            User_Button.Text = "Usuario";
            User_Button.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Mojangles", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(78, 233);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(239, 45);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 414);
            Controls.Add(User_Button);
            Controls.Add(textBox1);
            Controls.Add(Pass_Button);
            Controls.Add(Pass_block);
            Controls.Add(button1);
            Font = new Font("Mojangles", 9F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Log-In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox Pass_block;
        private Button Pass_Button;
        private Button User_Button;
        private TextBox textBox1;
    }
}
