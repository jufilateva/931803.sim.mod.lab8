namespace MagicBall_YesNo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_yesno = new System.Windows.Forms.Button();
            this.l_ans = new System.Windows.Forms.Label();
            this.b_ball = new System.Windows.Forms.Button();
            this.l_magicans = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_a = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_yesno
            // 
            this.b_yesno.Location = new System.Drawing.Point(98, 245);
            this.b_yesno.Name = "b_yesno";
            this.b_yesno.Size = new System.Drawing.Size(268, 51);
            this.b_yesno.TabIndex = 0;
            this.b_yesno.Text = "Узнать ответ (yes/no)";
            this.b_yesno.UseVisualStyleBackColor = true;
            this.b_yesno.Click += new System.EventHandler(this.b_yesno_Click);
            // 
            // l_ans
            // 
            this.l_ans.AutoSize = true;
            this.l_ans.Location = new System.Drawing.Point(158, 328);
            this.l_ans.Name = "l_ans";
            this.l_ans.Size = new System.Drawing.Size(117, 17);
            this.l_ans.TabIndex = 1;
            this.l_ans.Text = "Щас будет ответ";
            // 
            // b_ball
            // 
            this.b_ball.Location = new System.Drawing.Point(98, 446);
            this.b_ball.Name = "b_ball";
            this.b_ball.Size = new System.Drawing.Size(268, 56);
            this.b_ball.TabIndex = 2;
            this.b_ball.Text = "Узнать ответ (волшебный шар)";
            this.b_ball.UseVisualStyleBackColor = true;
            this.b_ball.Click += new System.EventHandler(this.b_ball_Click);
            // 
            // l_magicans
            // 
            this.l_magicans.AutoSize = true;
            this.l_magicans.Location = new System.Drawing.Point(136, 529);
            this.l_magicans.Name = "l_magicans";
            this.l_magicans.Size = new System.Drawing.Size(197, 17);
            this.l_magicans.TabIndex = 3;
            this.l_magicans.Text = "Щас будет волшебный овтет";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(620, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите вопрос:";
            // 
            // lab_a
            // 
            this.lab_a.AutoSize = true;
            this.lab_a.Location = new System.Drawing.Point(679, 363);
            this.lab_a.Name = "lab_a";
            this.lab_a.Size = new System.Drawing.Size(46, 17);
            this.lab_a.TabIndex = 6;
            this.lab_a.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 641);
            this.Controls.Add(this.lab_a);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.l_magicans);
            this.Controls.Add(this.b_ball);
            this.Controls.Add(this.l_ans);
            this.Controls.Add(this.b_yesno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_yesno;
        private System.Windows.Forms.Label l_ans;
        private System.Windows.Forms.Button b_ball;
        private System.Windows.Forms.Label l_magicans;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_a;
    }
}

