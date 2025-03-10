namespace CS_Tik_Tak_Toe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            Exitbtn = new Button();
            NewGameBtn = new Button();
            Restartbtn = new Button();
            panel4 = new Panel();
            scrPlayerO = new Label();
            lblPlayerO = new Label();
            scrPlayerX = new Label();
            lblPlayerX = new Label();
            panel3 = new Panel();
            button9 = new Button();
            button6 = new Button();
            button3 = new Button();
            button8 = new Button();
            button5 = new Button();
            button2 = new Button();
            button7 = new Button();
            button4 = new Button();
            button1 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(21, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1337, 118);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(440, 9);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(410, 86);
            label1.TabIndex = 0;
            label1.Text = "TIK TAC TOE";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(21, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(1337, 560);
            panel2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(Exitbtn);
            panel5.Controls.Add(NewGameBtn);
            panel5.Controls.Add(Restartbtn);
            panel5.Location = new Point(660, 278);
            panel5.Name = "panel5";
            panel5.Size = new Size(651, 249);
            panel5.TabIndex = 0;
            // 
            // Exitbtn
            // 
            Exitbtn.BackColor = Color.Turquoise;
            Exitbtn.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exitbtn.Location = new Point(323, 128);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(321, 114);
            Exitbtn.TabIndex = 0;
            Exitbtn.Text = "Exit";
            Exitbtn.UseVisualStyleBackColor = false;
            Exitbtn.Click += Exitbtn_Click;
            // 
            // NewGameBtn
            // 
            NewGameBtn.BackColor = Color.Turquoise;
            NewGameBtn.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewGameBtn.Location = new Point(3, 8);
            NewGameBtn.Name = "NewGameBtn";
            NewGameBtn.Size = new Size(641, 114);
            NewGameBtn.TabIndex = 0;
            NewGameBtn.Text = "New Game";
            NewGameBtn.UseVisualStyleBackColor = false;
            NewGameBtn.Click += NewGameBtn_Click;
            // 
            // Restartbtn
            // 
            Restartbtn.BackColor = Color.Turquoise;
            Restartbtn.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Restartbtn.Location = new Point(3, 128);
            Restartbtn.Name = "Restartbtn";
            Restartbtn.Size = new Size(314, 114);
            Restartbtn.TabIndex = 0;
            Restartbtn.Text = "Restart";
            Restartbtn.UseVisualStyleBackColor = false;
            Restartbtn.Click += Restartbtn_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(scrPlayerO);
            panel4.Controls.Add(lblPlayerO);
            panel4.Controls.Add(scrPlayerX);
            panel4.Controls.Add(lblPlayerX);
            panel4.Location = new Point(660, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(651, 249);
            panel4.TabIndex = 0;
            // 
            // scrPlayerO
            // 
            scrPlayerO.BackColor = Color.White;
            scrPlayerO.BorderStyle = BorderStyle.Fixed3D;
            scrPlayerO.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scrPlayerO.Location = new Point(328, 122);
            scrPlayerO.Margin = new Padding(1, 0, 1, 0);
            scrPlayerO.Name = "scrPlayerO";
            scrPlayerO.Size = new Size(291, 86);
            scrPlayerO.TabIndex = 0;
            scrPlayerO.Text = "0";
            scrPlayerO.TextAlign = ContentAlignment.MiddleCenter;
            scrPlayerO.Click += label1_Click;
            // 
            // lblPlayerO
            // 
            lblPlayerO.AutoSize = true;
            lblPlayerO.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerO.Location = new Point(3, 122);
            lblPlayerO.Margin = new Padding(1, 0, 1, 0);
            lblPlayerO.Name = "lblPlayerO";
            lblPlayerO.Size = new Size(323, 86);
            lblPlayerO.TabIndex = 0;
            lblPlayerO.Text = "Player O :";
            lblPlayerO.Click += label1_Click;
            // 
            // scrPlayerX
            // 
            scrPlayerX.BackColor = Color.White;
            scrPlayerX.BorderStyle = BorderStyle.Fixed3D;
            scrPlayerX.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scrPlayerX.Location = new Point(328, 3);
            scrPlayerX.Margin = new Padding(1, 0, 1, 0);
            scrPlayerX.Name = "scrPlayerX";
            scrPlayerX.Size = new Size(291, 86);
            scrPlayerX.TabIndex = 0;
            scrPlayerX.Text = "0";
            scrPlayerX.TextAlign = ContentAlignment.MiddleCenter;
            scrPlayerX.Click += label1_Click;
            // 
            // lblPlayerX
            // 
            lblPlayerX.AutoSize = true;
            lblPlayerX.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerX.Location = new Point(3, 3);
            lblPlayerX.Margin = new Padding(1, 0, 1, 0);
            lblPlayerX.Name = "lblPlayerX";
            lblPlayerX.Size = new Size(316, 86);
            lblPlayerX.TabIndex = 0;
            lblPlayerX.Text = "Player X :";
            lblPlayerX.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(13, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(626, 515);
            panel3.TabIndex = 0;
            // 
            // button9
            // 
            button9.BackColor = Color.SpringGreen;
            button9.Font = new Font("Segoe UI", 96F, FontStyle.Bold);
            button9.Location = new Point(415, 331);
            button9.Name = "button9";
            button9.Size = new Size(200, 158);
            button9.TabIndex = 0;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.SpringGreen;
            button6.Font = new Font("Segoe UI", 96F, FontStyle.Bold);
            button6.Location = new Point(415, 167);
            button6.Name = "button6";
            button6.Size = new Size(200, 158);
            button6.TabIndex = 0;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SpringGreen;
            button3.Font = new Font("Segoe UI", 96F, FontStyle.Bold);
            button3.Location = new Point(415, 3);
            button3.Name = "button3";
            button3.Size = new Size(200, 158);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.SpringGreen;
            button8.Font = new Font("Segoe UI", 96F, FontStyle.Bold);
            button8.Location = new Point(209, 331);
            button8.Name = "button8";
            button8.Size = new Size(200, 158);
            button8.TabIndex = 0;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.SpringGreen;
            button5.Font = new Font("Segoe UI", 96F, FontStyle.Bold);
            button5.Location = new Point(209, 167);
            button5.Name = "button5";
            button5.Size = new Size(200, 158);
            button5.TabIndex = 0;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SpringGreen;
            button2.Font = new Font("Segoe UI", 96F, FontStyle.Bold);
            button2.Location = new Point(209, 3);
            button2.Name = "button2";
            button2.Size = new Size(200, 158);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.SpringGreen;
            button7.Font = new Font("Segoe UI", 96F, FontStyle.Bold);
            button7.Location = new Point(3, 331);
            button7.Name = "button7";
            button7.Size = new Size(200, 158);
            button7.TabIndex = 0;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SpringGreen;
            button4.Font = new Font("Segoe UI", 96F, FontStyle.Bold);
            button4.Location = new Point(3, 167);
            button4.Name = "button4";
            button4.Size = new Size(200, 158);
            button4.TabIndex = 0;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Segoe UI", 96F, FontStyle.Bold);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(200, 158);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 725);
            label2.Name = "label2";
            label2.Size = new Size(162, 15);
            label2.TabIndex = 1;
            label2.Text = "By MHD Hadi Said Alkaddour";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1370, 749);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Tic Tac Toe";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Button button1;
        private Button button9;
        private Button button6;
        private Button button3;
        private Button button8;
        private Button button5;
        private Button button2;
        private Button button7;
        private Button button4;
        private Button Exitbtn;
        private Button NewGameBtn;
        private Button Restartbtn;
        private Label lblPlayerO;
        private Label lblPlayerX;
        private Label scrPlayerO;
        private Label scrPlayerX;
        private Label label2;
    }
}
