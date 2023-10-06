namespace StoreManagement
{
    partial class FindSupplier
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
            label5 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 67);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 25;
            label5.Text = "Supplier Name:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(108, 64);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(232, 23);
            textBox5.TabIndex = 20;
            // 
            // button1
            // 
            button1.Location = new Point(265, 93);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 26;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(387, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 366);
            panel1.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 216);
            label4.Name = "label4";
            label4.Size = new Size(153, 15);
            label4.TabIndex = 31;
            label4.Text = "Phone:         (859) 622 - 0000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 165);
            label3.Name = "label3";
            label3.Size = new Size(229, 15);
            label3.TabIndex = 30;
            label3.Text = "Email:        contact@abcpizzasupplies.com";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 114);
            label2.Name = "label2";
            label2.Size = new Size(284, 15);
            label2.TabIndex = 29;
            label2.Text = "Address:       521 Lancaster Ave., Richmond, KY 40475";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 67);
            label1.Name = "label1";
            label1.Size = new Size(168, 15);
            label1.TabIndex = 28;
            label1.Text = "Name:         ABC Pizza Supplies";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Name = "Form4";
            Text = "Find Supplier";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox textBox5;
        private Button button1;
        private Panel panel1;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}