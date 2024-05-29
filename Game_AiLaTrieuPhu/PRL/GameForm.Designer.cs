namespace Game_AiLaTrieuPhu.PRL
{
    partial class GameForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            grb_CauHoi = new GroupBox();
            btn_D = new Button();
            btn_C = new Button();
            btn_B = new Button();
            btn_A = new Button();
            tbt_Question = new TextBox();
            grb_Moc = new GroupBox();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_4 = new Button();
            btn_5 = new Button();
            btn_6 = new Button();
            btn_7 = new Button();
            btn_8 = new Button();
            btn_9 = new Button();
            btn_10 = new Button();
            btn_11 = new Button();
            btn_12 = new Button();
            btn_13 = new Button();
            btn_14 = new Button();
            btn_15 = new Button();
            btn_Start = new Button();
            groupBox3 = new GroupBox();
            lb_Money = new Label();
            lb_Time = new Label();
            ptb_Change = new PictureBox();
            ptb_Pro = new PictureBox();
            ptb_Viewer = new PictureBox();
            ptb_5050 = new PictureBox();
            time_limit = new System.Windows.Forms.Timer(components);
            grb_CauHoi.SuspendLayout();
            grb_Moc.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Change).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Pro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Viewer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_5050).BeginInit();
            SuspendLayout();
            // 
            // grb_CauHoi
            // 
            grb_CauHoi.BackColor = SystemColors.MenuHighlight;
            grb_CauHoi.Controls.Add(btn_D);
            grb_CauHoi.Controls.Add(btn_C);
            grb_CauHoi.Controls.Add(btn_B);
            grb_CauHoi.Controls.Add(btn_A);
            grb_CauHoi.Controls.Add(tbt_Question);
            grb_CauHoi.Location = new Point(8, 353);
            grb_CauHoi.Name = "grb_CauHoi";
            grb_CauHoi.Size = new Size(743, 365);
            grb_CauHoi.TabIndex = 0;
            grb_CauHoi.TabStop = false;
            grb_CauHoi.Text = "Câu hỏi - và các đáp án";
            // 
            // btn_D
            // 
            btn_D.BackColor = Color.FromArgb(255, 255, 192);
            btn_D.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_D.ForeColor = Color.SlateGray;
            btn_D.Location = new Point(392, 269);
            btn_D.Name = "btn_D";
            btn_D.Size = new Size(329, 79);
            btn_D.TabIndex = 4;
            btn_D.Text = "D";
            btn_D.UseVisualStyleBackColor = false;
            btn_D.Click += btn_E_Click;
            // 
            // btn_C
            // 
            btn_C.BackColor = Color.FromArgb(255, 255, 192);
            btn_C.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_C.ForeColor = Color.SlateGray;
            btn_C.Location = new Point(17, 257);
            btn_C.Name = "btn_C";
            btn_C.Size = new Size(329, 79);
            btn_C.TabIndex = 3;
            btn_C.Text = "C";
            btn_C.UseVisualStyleBackColor = false;
            btn_C.Click += btn_C_Click;
            // 
            // btn_B
            // 
            btn_B.BackColor = Color.FromArgb(255, 255, 192);
            btn_B.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_B.ForeColor = Color.SlateGray;
            btn_B.Location = new Point(392, 172);
            btn_B.Name = "btn_B";
            btn_B.Size = new Size(329, 79);
            btn_B.TabIndex = 2;
            btn_B.Text = "B";
            btn_B.UseVisualStyleBackColor = false;
            btn_B.Click += bt_B_Click;
            // 
            // btn_A
            // 
            btn_A.BackColor = Color.FromArgb(255, 255, 192);
            btn_A.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_A.ForeColor = Color.SlateGray;
            btn_A.Location = new Point(17, 172);
            btn_A.Name = "btn_A";
            btn_A.Size = new Size(329, 79);
            btn_A.TabIndex = 1;
            btn_A.Text = "A";
            btn_A.UseVisualStyleBackColor = false;
            btn_A.Click += btn_A_Click;
            // 
            // tbt_Question
            // 
            tbt_Question.BackColor = Color.SpringGreen;
            tbt_Question.Enabled = false;
            tbt_Question.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbt_Question.HideSelection = false;
            tbt_Question.Location = new Point(17, 41);
            tbt_Question.Multiline = true;
            tbt_Question.Name = "tbt_Question";
            tbt_Question.ReadOnly = true;
            tbt_Question.Size = new Size(704, 102);
            tbt_Question.TabIndex = 0;
            // 
            // grb_Moc
            // 
            grb_Moc.BackColor = Color.MediumBlue;
            grb_Moc.Controls.Add(btn_1);
            grb_Moc.Controls.Add(btn_2);
            grb_Moc.Controls.Add(btn_3);
            grb_Moc.Controls.Add(btn_4);
            grb_Moc.Controls.Add(btn_5);
            grb_Moc.Controls.Add(btn_6);
            grb_Moc.Controls.Add(btn_7);
            grb_Moc.Controls.Add(btn_8);
            grb_Moc.Controls.Add(btn_9);
            grb_Moc.Controls.Add(btn_10);
            grb_Moc.Controls.Add(btn_11);
            grb_Moc.Controls.Add(btn_12);
            grb_Moc.Controls.Add(btn_13);
            grb_Moc.Controls.Add(btn_14);
            grb_Moc.Controls.Add(btn_15);
            grb_Moc.Location = new Point(771, 14);
            grb_Moc.Name = "grb_Moc";
            grb_Moc.Size = new Size(329, 729);
            grb_Moc.TabIndex = 1;
            grb_Moc.TabStop = false;
            grb_Moc.Text = "Danh sách 15 câu hỏi và các mức thưởng";
            // 
            // btn_1
            // 
            btn_1.BackColor = Color.FromArgb(255, 255, 192);
            btn_1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_1.Location = new Point(41, 680);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(261, 40);
            btn_1.TabIndex = 19;
            btn_1.Text = "1: 1.000.000";
            btn_1.UseVisualStyleBackColor = false;
            // 
            // btn_2
            // 
            btn_2.BackColor = Color.FromArgb(255, 255, 192);
            btn_2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_2.Location = new Point(41, 634);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(261, 40);
            btn_2.TabIndex = 18;
            btn_2.Text = "2: 2.000.000";
            btn_2.UseVisualStyleBackColor = false;
            // 
            // btn_3
            // 
            btn_3.BackColor = Color.FromArgb(255, 255, 192);
            btn_3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_3.Location = new Point(41, 588);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(261, 40);
            btn_3.TabIndex = 17;
            btn_3.Text = "3: 3.000.000";
            btn_3.UseVisualStyleBackColor = false;
            // 
            // btn_4
            // 
            btn_4.BackColor = Color.FromArgb(255, 255, 192);
            btn_4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_4.Location = new Point(41, 542);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(261, 40);
            btn_4.TabIndex = 16;
            btn_4.Text = "4: 5.000.000";
            btn_4.UseVisualStyleBackColor = false;
            // 
            // btn_5
            // 
            btn_5.BackColor = Color.FromArgb(255, 255, 192);
            btn_5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_5.ForeColor = Color.Red;
            btn_5.Location = new Point(41, 496);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(261, 40);
            btn_5.TabIndex = 15;
            btn_5.Text = "5: 10.000.000";
            btn_5.UseVisualStyleBackColor = false;
            // 
            // btn_6
            // 
            btn_6.BackColor = Color.FromArgb(255, 255, 192);
            btn_6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_6.Location = new Point(41, 450);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(261, 40);
            btn_6.TabIndex = 14;
            btn_6.Text = "6: 15.000.000";
            btn_6.UseVisualStyleBackColor = false;
            // 
            // btn_7
            // 
            btn_7.BackColor = Color.FromArgb(255, 255, 192);
            btn_7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_7.Location = new Point(41, 404);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(261, 40);
            btn_7.TabIndex = 13;
            btn_7.Text = "7: 23.000.000";
            btn_7.UseVisualStyleBackColor = false;
            // 
            // btn_8
            // 
            btn_8.BackColor = Color.FromArgb(255, 255, 192);
            btn_8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_8.Location = new Point(41, 358);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(261, 40);
            btn_8.TabIndex = 12;
            btn_8.Text = "8: 40.000.000";
            btn_8.UseVisualStyleBackColor = false;
            // 
            // btn_9
            // 
            btn_9.BackColor = Color.FromArgb(255, 255, 192);
            btn_9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_9.Location = new Point(41, 312);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(261, 40);
            btn_9.TabIndex = 11;
            btn_9.Text = "9: 60.000.000";
            btn_9.UseVisualStyleBackColor = false;
            // 
            // btn_10
            // 
            btn_10.BackColor = Color.FromArgb(255, 255, 192);
            btn_10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_10.ForeColor = Color.Red;
            btn_10.Location = new Point(41, 266);
            btn_10.Name = "btn_10";
            btn_10.Size = new Size(261, 40);
            btn_10.TabIndex = 10;
            btn_10.Text = "10: 100.000.000";
            btn_10.UseVisualStyleBackColor = false;
            // 
            // btn_11
            // 
            btn_11.BackColor = Color.FromArgb(255, 255, 192);
            btn_11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_11.Location = new Point(41, 220);
            btn_11.Name = "btn_11";
            btn_11.Size = new Size(261, 40);
            btn_11.TabIndex = 9;
            btn_11.Text = "11: 150.000.000";
            btn_11.UseVisualStyleBackColor = false;
            // 
            // btn_12
            // 
            btn_12.BackColor = Color.FromArgb(255, 255, 192);
            btn_12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_12.Location = new Point(41, 174);
            btn_12.Name = "btn_12";
            btn_12.Size = new Size(261, 40);
            btn_12.TabIndex = 8;
            btn_12.Text = "12: 250.000.000";
            btn_12.UseVisualStyleBackColor = false;
            // 
            // btn_13
            // 
            btn_13.BackColor = Color.FromArgb(255, 255, 192);
            btn_13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_13.Location = new Point(41, 128);
            btn_13.Name = "btn_13";
            btn_13.Size = new Size(261, 40);
            btn_13.TabIndex = 7;
            btn_13.Text = "13: 400.000.000";
            btn_13.UseVisualStyleBackColor = false;
            // 
            // btn_14
            // 
            btn_14.BackColor = Color.FromArgb(255, 255, 192);
            btn_14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_14.Location = new Point(41, 82);
            btn_14.Name = "btn_14";
            btn_14.Size = new Size(261, 40);
            btn_14.TabIndex = 6;
            btn_14.Text = "14: 600.000.000";
            btn_14.UseVisualStyleBackColor = false;
            // 
            // btn_15
            // 
            btn_15.BackColor = Color.FromArgb(255, 255, 192);
            btn_15.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_15.ForeColor = Color.Red;
            btn_15.Location = new Point(41, 36);
            btn_15.Name = "btn_15";
            btn_15.Size = new Size(261, 40);
            btn_15.TabIndex = 5;
            btn_15.Text = "15: 900.000.000";
            btn_15.UseVisualStyleBackColor = false;
            // 
            // btn_Start
            // 
            btn_Start.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Start.Location = new Point(522, 106);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(194, 114);
            btn_Start.TabIndex = 20;
            btn_Start.Text = "Bắt đầu chơi";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.MenuHighlight;
            groupBox3.Controls.Add(btn_Start);
            groupBox3.Controls.Add(lb_Money);
            groupBox3.Controls.Add(lb_Time);
            groupBox3.Controls.Add(ptb_Change);
            groupBox3.Controls.Add(ptb_Pro);
            groupBox3.Controls.Add(ptb_Viewer);
            groupBox3.Controls.Add(ptb_5050);
            groupBox3.Location = new Point(8, 14);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(747, 295);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thời gian và quyền trợ giúp, tiền thưởng đang có";
            // 
            // lb_Money
            // 
            lb_Money.AutoSize = true;
            lb_Money.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Money.ForeColor = Color.Navy;
            lb_Money.Location = new Point(355, 54);
            lb_Money.Name = "lb_Money";
            lb_Money.Size = new Size(128, 45);
            lb_Money.TabIndex = 5;
            lb_Money.Text = "000000";
            // 
            // lb_Time
            // 
            lb_Time.AutoSize = true;
            lb_Time.BackColor = SystemColors.Menu;
            lb_Time.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Time.Location = new Point(381, 212);
            lb_Time.Name = "lb_Time";
            lb_Time.Size = new Size(56, 45);
            lb_Time.TabIndex = 4;
            lb_Time.Text = "45";
            // 
            // ptb_Change
            // 
            ptb_Change.Image = (Image)resources.GetObject("ptb_Change.Image");
            ptb_Change.Location = new Point(185, 179);
            ptb_Change.Name = "ptb_Change";
            ptb_Change.Size = new Size(105, 100);
            ptb_Change.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Change.TabIndex = 3;
            ptb_Change.TabStop = false;
            ptb_Change.Click += ptb_Change_Click;
            // 
            // ptb_Pro
            // 
            ptb_Pro.Image = (Image)resources.GetObject("ptb_Pro.Image");
            ptb_Pro.Location = new Point(25, 157);
            ptb_Pro.Name = "ptb_Pro";
            ptb_Pro.Size = new Size(105, 100);
            ptb_Pro.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Pro.TabIndex = 2;
            ptb_Pro.TabStop = false;
            ptb_Pro.Click += ptb_Pro_Click;
            // 
            // ptb_Viewer
            // 
            ptb_Viewer.Image = (Image)resources.GetObject("ptb_Viewer.Image");
            ptb_Viewer.Location = new Point(185, 44);
            ptb_Viewer.Name = "ptb_Viewer";
            ptb_Viewer.Size = new Size(105, 100);
            ptb_Viewer.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Viewer.TabIndex = 1;
            ptb_Viewer.TabStop = false;
            ptb_Viewer.Click += ptb_Viewer_Click;
            // 
            // ptb_5050
            // 
            ptb_5050.Image = (Image)resources.GetObject("ptb_5050.Image");
            ptb_5050.Location = new Point(25, 44);
            ptb_5050.Name = "ptb_5050";
            ptb_5050.Size = new Size(105, 100);
            ptb_5050.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_5050.TabIndex = 0;
            ptb_5050.TabStop = false;
            ptb_5050.Click += ptb_5050_Click;
            // 
            // time_limit
            // 
            time_limit.Tick += time_limit_Tick;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumBlue;
            ClientSize = new Size(1112, 755);
            Controls.Add(groupBox3);
            Controls.Add(grb_Moc);
            Controls.Add(grb_CauHoi);
            Name = "GameForm";
            Text = "GameForm";
            grb_CauHoi.ResumeLayout(false);
            grb_CauHoi.PerformLayout();
            grb_Moc.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Change).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Pro).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_Viewer).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_5050).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_CauHoi;
        private TextBox tbt_Question;
        private GroupBox grb_Moc;
        private GroupBox groupBox3;
        private Button btn_D;
        private Button btn_C;
        private Button btn_B;
        private Button btn_A;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_7;
        private Button btn_8;
        private Button btn_9;
        private Button btn_10;
        private Button btn_11;
        private Button btn_12;
        private Button btn_13;
        private Button btn_14;
        private Button btn_15;
        private Label lb_Money;
        private Label lb_Time;
        private PictureBox ptb_Change;
        private PictureBox ptb_Pro;
        private PictureBox ptb_Viewer;
        private PictureBox ptb_5050;
        private Button btn_Start;
        private System.Windows.Forms.Timer time_limit;
    }
}