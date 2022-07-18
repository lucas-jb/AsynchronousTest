namespace AsynchronousTest
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Sync1 = new System.Windows.Forms.TextBox();
            this.Sync2 = new System.Windows.Forms.TextBox();
            this.Sync3 = new System.Windows.Forms.TextBox();
            this.Async3 = new System.Windows.Forms.TextBox();
            this.Async2 = new System.Windows.Forms.TextBox();
            this.Async1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sync";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Async";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sync1
            // 
            this.Sync1.Location = new System.Drawing.Point(28, 71);
            this.Sync1.Name = "Sync1";
            this.Sync1.ReadOnly = true;
            this.Sync1.Size = new System.Drawing.Size(100, 23);
            this.Sync1.TabIndex = 2;
            // 
            // Sync2
            // 
            this.Sync2.Location = new System.Drawing.Point(28, 100);
            this.Sync2.Name = "Sync2";
            this.Sync2.ReadOnly = true;
            this.Sync2.Size = new System.Drawing.Size(100, 23);
            this.Sync2.TabIndex = 3;
            // 
            // Sync3
            // 
            this.Sync3.Location = new System.Drawing.Point(28, 129);
            this.Sync3.Name = "Sync3";
            this.Sync3.ReadOnly = true;
            this.Sync3.Size = new System.Drawing.Size(100, 23);
            this.Sync3.TabIndex = 4;
            // 
            // Async3
            // 
            this.Async3.Location = new System.Drawing.Point(144, 129);
            this.Async3.Name = "Async3";
            this.Async3.ReadOnly = true;
            this.Async3.Size = new System.Drawing.Size(100, 23);
            this.Async3.TabIndex = 7;
            // 
            // Async2
            // 
            this.Async2.Location = new System.Drawing.Point(144, 100);
            this.Async2.Name = "Async2";
            this.Async2.ReadOnly = true;
            this.Async2.Size = new System.Drawing.Size(100, 23);
            this.Async2.TabIndex = 6;
            // 
            // Async1
            // 
            this.Async1.Location = new System.Drawing.Point(144, 71);
            this.Async1.Name = "Async1";
            this.Async1.ReadOnly = true;
            this.Async1.Size = new System.Drawing.Size(100, 23);
            this.Async1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(82, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Clean";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 216);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Async3);
            this.Controls.Add(this.Async2);
            this.Controls.Add(this.Async1);
            this.Controls.Add(this.Sync3);
            this.Controls.Add(this.Sync2);
            this.Controls.Add(this.Sync1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox Sync1;
        private TextBox Sync2;
        private TextBox Sync3;
        private TextBox Async3;
        private TextBox Async2;
        private TextBox Async1;
        private Button button3;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}