namespace OptionQuiz
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.question1Picture = new System.Windows.Forms.PictureBox();
            this.question2Picture = new System.Windows.Forms.PictureBox();
            this.question3Picture = new System.Windows.Forms.PictureBox();
            this.groupBoxQuestion1 = new System.Windows.Forms.GroupBox();
            this.question1Option1 = new System.Windows.Forms.RadioButton();
            this.question1Option2 = new System.Windows.Forms.RadioButton();
            this.question1Option3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxQuestion2 = new System.Windows.Forms.GroupBox();
            this.question2Option1 = new System.Windows.Forms.RadioButton();
            this.question2Option2 = new System.Windows.Forms.RadioButton();
            this.question2Option3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxQuestion3 = new System.Windows.Forms.GroupBox();
            this.question3Option1 = new System.Windows.Forms.RadioButton();
            this.question3Option2 = new System.Windows.Forms.RadioButton();
            this.question3Option3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.startButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.timerWindow = new System.Windows.Forms.Label();
            this.question1Feedback = new System.Windows.Forms.Label();
            this.question2Feedback = new System.Windows.Forms.Label();
            this.question3Feedback = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.question1Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.question2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.question3Picture)).BeginInit();
            this.groupBoxQuestion1.SuspendLayout();
            this.groupBoxQuestion2.SuspendLayout();
            this.groupBoxQuestion3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.question1Picture, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.question2Picture, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.question3Picture, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxQuestion1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxQuestion2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxQuestion3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.timerWindow, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.question1Feedback, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.question2Feedback, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.question3Feedback, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 586);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // question1Picture
            // 
            this.question1Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.question1Picture.Image = global::OptionQuiz.Properties.Resources._5794_george_clooney;
            this.question1Picture.Location = new System.Drawing.Point(3, 76);
            this.question1Picture.Name = "question1Picture";
            this.question1Picture.Size = new System.Drawing.Size(150, 140);
            this.question1Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.question1Picture.TabIndex = 0;
            this.question1Picture.TabStop = false;
            // 
            // question2Picture
            // 
            this.question2Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.question2Picture.Image = global::OptionQuiz.Properties.Resources.Chris_Evans;
            this.question2Picture.Location = new System.Drawing.Point(3, 222);
            this.question2Picture.Name = "question2Picture";
            this.question2Picture.Size = new System.Drawing.Size(150, 140);
            this.question2Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.question2Picture.TabIndex = 1;
            this.question2Picture.TabStop = false;
            // 
            // question3Picture
            // 
            this.question3Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.question3Picture.Image = global::OptionQuiz.Properties.Resources.ryan_reynolds;
            this.question3Picture.Location = new System.Drawing.Point(3, 368);
            this.question3Picture.Name = "question3Picture";
            this.question3Picture.Size = new System.Drawing.Size(150, 140);
            this.question3Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.question3Picture.TabIndex = 2;
            this.question3Picture.TabStop = false;
            // 
            // groupBoxQuestion1
            // 
            this.groupBoxQuestion1.Controls.Add(this.question1Option1);
            this.groupBoxQuestion1.Controls.Add(this.question1Option2);
            this.groupBoxQuestion1.Controls.Add(this.question1Option3);
            this.groupBoxQuestion1.Controls.Add(this.label1);
            this.groupBoxQuestion1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxQuestion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxQuestion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxQuestion1.Location = new System.Drawing.Point(159, 76);
            this.groupBoxQuestion1.Name = "groupBoxQuestion1";
            this.groupBoxQuestion1.Size = new System.Drawing.Size(307, 140);
            this.groupBoxQuestion1.TabIndex = 3;
            this.groupBoxQuestion1.TabStop = false;
            // 
            // question1Option1
            // 
            this.question1Option1.AutoSize = true;
            this.question1Option1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question1Option1.Location = new System.Drawing.Point(47, 71);
            this.question1Option1.Name = "question1Option1";
            this.question1Option1.Size = new System.Drawing.Size(88, 21);
            this.question1Option1.TabIndex = 3;
            this.question1Option1.TabStop = true;
            this.question1Option1.Text = "Superman";
            this.question1Option1.UseVisualStyleBackColor = true;
            this.question1Option1.CheckedChanged += new System.EventHandler(this.question1Option1_CheckedChanged);
            // 
            // question1Option2
            // 
            this.question1Option2.AutoSize = true;
            this.question1Option2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question1Option2.Location = new System.Drawing.Point(47, 94);
            this.question1Option2.Name = "question1Option2";
            this.question1Option2.Size = new System.Drawing.Size(73, 21);
            this.question1Option2.TabIndex = 2;
            this.question1Option2.TabStop = true;
            this.question1Option2.Text = "Batman";
            this.question1Option2.UseVisualStyleBackColor = true;
            this.question1Option2.CheckedChanged += new System.EventHandler(this.question1Option2_CheckedChanged);
            // 
            // question1Option3
            // 
            this.question1Option3.AutoSize = true;
            this.question1Option3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question1Option3.Location = new System.Drawing.Point(47, 117);
            this.question1Option3.Name = "question1Option3";
            this.question1Option3.Size = new System.Drawing.Size(85, 21);
            this.question1Option3.TabIndex = 1;
            this.question1Option3.TabStop = true;
            this.question1Option3.Text = "Aquaman";
            this.question1Option3.UseVisualStyleBackColor = true;
            this.question1Option3.CheckedChanged += new System.EventHandler(this.question1Option3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "What famous Superhero did George Clooney play?";
            // 
            // groupBoxQuestion2
            // 
            this.groupBoxQuestion2.Controls.Add(this.question2Option1);
            this.groupBoxQuestion2.Controls.Add(this.question2Option2);
            this.groupBoxQuestion2.Controls.Add(this.question2Option3);
            this.groupBoxQuestion2.Controls.Add(this.label2);
            this.groupBoxQuestion2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxQuestion2.Location = new System.Drawing.Point(159, 222);
            this.groupBoxQuestion2.Name = "groupBoxQuestion2";
            this.groupBoxQuestion2.Size = new System.Drawing.Size(307, 140);
            this.groupBoxQuestion2.TabIndex = 4;
            this.groupBoxQuestion2.TabStop = false;
            // 
            // question2Option1
            // 
            this.question2Option1.AutoSize = true;
            this.question2Option1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question2Option1.Location = new System.Drawing.Point(47, 71);
            this.question2Option1.Name = "question2Option1";
            this.question2Option1.Size = new System.Drawing.Size(105, 21);
            this.question2Option1.TabIndex = 3;
            this.question2Option1.TabStop = true;
            this.question2Option1.Text = "Black Widow";
            this.question2Option1.UseVisualStyleBackColor = true;
            this.question2Option1.CheckedChanged += new System.EventHandler(this.question2Option1_CheckedChanged);
            // 
            // question2Option2
            // 
            this.question2Option2.AutoSize = true;
            this.question2Option2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question2Option2.Location = new System.Drawing.Point(47, 94);
            this.question2Option2.Name = "question2Option2";
            this.question2Option2.Size = new System.Drawing.Size(55, 21);
            this.question2Option2.TabIndex = 2;
            this.question2Option2.TabStop = true;
            this.question2Option2.Text = "Thor";
            this.question2Option2.UseVisualStyleBackColor = true;
            this.question2Option2.CheckedChanged += new System.EventHandler(this.question2Option2_CheckedChanged);
            // 
            // question2Option3
            // 
            this.question2Option3.AutoSize = true;
            this.question2Option3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question2Option3.Location = new System.Drawing.Point(47, 117);
            this.question2Option3.Name = "question2Option3";
            this.question2Option3.Size = new System.Drawing.Size(127, 21);
            this.question2Option3.TabIndex = 1;
            this.question2Option3.TabStop = true;
            this.question2Option3.Text = "Captain America";
            this.question2Option3.UseVisualStyleBackColor = true;
            this.question2Option3.CheckedChanged += new System.EventHandler(this.question2Option3_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "What famous superhero did Chris Evans play?";
            // 
            // groupBoxQuestion3
            // 
            this.groupBoxQuestion3.Controls.Add(this.question3Option1);
            this.groupBoxQuestion3.Controls.Add(this.question3Option2);
            this.groupBoxQuestion3.Controls.Add(this.question3Option3);
            this.groupBoxQuestion3.Controls.Add(this.label3);
            this.groupBoxQuestion3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxQuestion3.Location = new System.Drawing.Point(159, 368);
            this.groupBoxQuestion3.Name = "groupBoxQuestion3";
            this.groupBoxQuestion3.Size = new System.Drawing.Size(307, 140);
            this.groupBoxQuestion3.TabIndex = 5;
            this.groupBoxQuestion3.TabStop = false;
            // 
            // question3Option1
            // 
            this.question3Option1.AutoSize = true;
            this.question3Option1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question3Option1.Location = new System.Drawing.Point(47, 76);
            this.question3Option1.Name = "question3Option1";
            this.question3Option1.Size = new System.Drawing.Size(86, 21);
            this.question3Option1.TabIndex = 3;
            this.question3Option1.TabStop = true;
            this.question3Option1.Text = "Deadpool";
            this.question3Option1.UseVisualStyleBackColor = true;
            this.question3Option1.CheckedChanged += new System.EventHandler(this.question3Option1_CheckedChanged);
            // 
            // question3Option2
            // 
            this.question3Option2.AutoSize = true;
            this.question3Option2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question3Option2.Location = new System.Drawing.Point(47, 99);
            this.question3Option2.Name = "question3Option2";
            this.question3Option2.Size = new System.Drawing.Size(93, 21);
            this.question3Option2.TabIndex = 2;
            this.question3Option2.TabStop = true;
            this.question3Option2.Text = "Aliveocean";
            this.question3Option2.UseVisualStyleBackColor = true;
            this.question3Option2.CheckedChanged += new System.EventHandler(this.question3Option2_CheckedChanged);
            // 
            // question3Option3
            // 
            this.question3Option3.AutoSize = true;
            this.question3Option3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question3Option3.Location = new System.Drawing.Point(47, 122);
            this.question3Option3.Name = "question3Option3";
            this.question3Option3.Size = new System.Drawing.Size(78, 21);
            this.question3Option3.TabIndex = 1;
            this.question3Option3.TabStop = true;
            this.question3Option3.Text = "Lazylake";
            this.question3Option3.UseVisualStyleBackColor = true;
            this.question3Option3.CheckedChanged += new System.EventHandler(this.question3Option3_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "What famous superhero  did Ryan Reynolds play?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 73);
            this.label4.TabIndex = 6;
            this.label4.Text = "Timer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.startButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.closeButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(159, 514);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(307, 69);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startButton.Location = new System.Drawing.Point(3, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(147, 63);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeButton.Location = new System.Drawing.Point(156, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(148, 63);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // timerWindow
            // 
            this.timerWindow.AutoSize = true;
            this.timerWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timerWindow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerWindow.Location = new System.Drawing.Point(472, 0);
            this.timerWindow.Name = "timerWindow";
            this.timerWindow.Size = new System.Drawing.Size(151, 73);
            this.timerWindow.TabIndex = 8;
            this.timerWindow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // question1Feedback
            // 
            this.question1Feedback.AutoSize = true;
            this.question1Feedback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.question1Feedback.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question1Feedback.Location = new System.Drawing.Point(472, 73);
            this.question1Feedback.Name = "question1Feedback";
            this.question1Feedback.Size = new System.Drawing.Size(151, 146);
            this.question1Feedback.TabIndex = 9;
            this.question1Feedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // question2Feedback
            // 
            this.question2Feedback.AutoSize = true;
            this.question2Feedback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.question2Feedback.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question2Feedback.Location = new System.Drawing.Point(472, 219);
            this.question2Feedback.Name = "question2Feedback";
            this.question2Feedback.Size = new System.Drawing.Size(151, 146);
            this.question2Feedback.TabIndex = 10;
            this.question2Feedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // question3Feedback
            // 
            this.question3Feedback.AutoSize = true;
            this.question3Feedback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.question3Feedback.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question3Feedback.Location = new System.Drawing.Point(472, 365);
            this.question3Feedback.Name = "question3Feedback";
            this.question3Feedback.Size = new System.Drawing.Size(151, 146);
            this.question3Feedback.TabIndex = 11;
            this.question3Feedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 586);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Superhero Celebrity Quiz";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.question1Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.question2Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.question3Picture)).EndInit();
            this.groupBoxQuestion1.ResumeLayout(false);
            this.groupBoxQuestion1.PerformLayout();
            this.groupBoxQuestion2.ResumeLayout(false);
            this.groupBoxQuestion2.PerformLayout();
            this.groupBoxQuestion3.ResumeLayout(false);
            this.groupBoxQuestion3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox question1Picture;
        private System.Windows.Forms.PictureBox question2Picture;
        private System.Windows.Forms.PictureBox question3Picture;
        private System.Windows.Forms.RadioButton question1Option1;
        private System.Windows.Forms.RadioButton question1Option2;
        private System.Windows.Forms.RadioButton question1Option3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxQuestion2;
        private System.Windows.Forms.RadioButton question2Option1;
        private System.Windows.Forms.RadioButton question2Option2;
        private System.Windows.Forms.RadioButton question2Option3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxQuestion3;
        private System.Windows.Forms.RadioButton question3Option1;
        private System.Windows.Forms.RadioButton question3Option2;
        private System.Windows.Forms.RadioButton question3Option3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label timerWindow;
        private System.Windows.Forms.Label question1Feedback;
        private System.Windows.Forms.Label question2Feedback;
        private System.Windows.Forms.Label question3Feedback;
        private System.Windows.Forms.GroupBox groupBoxQuestion1;
        private System.Windows.Forms.Timer timer1;
    }
}

