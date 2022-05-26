namespace Crossword_Igra
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
            this.label1 = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Button();
            this.Rules = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.ВыборУровня = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 40F);
            this.label1.Location = new System.Drawing.Point(183, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word of wonders";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Font = new System.Drawing.Font("Lucida Handwriting", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.Color.Red;
            this.play.Location = new System.Drawing.Point(350, 300);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(200, 50);
            this.play.TabIndex = 1;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // Rules
            // 
            this.Rules.BackColor = System.Drawing.Color.Transparent;
            this.Rules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rules.Font = new System.Drawing.Font("Lucida Handwriting", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rules.ForeColor = System.Drawing.Color.Green;
            this.Rules.Location = new System.Drawing.Point(350, 412);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(200, 50);
            this.Rules.TabIndex = 2;
            this.Rules.Text = "Rules";
            this.Rules.UseVisualStyleBackColor = false;
            this.Rules.Click += new System.EventHandler(this.Rules_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Lucida Handwriting", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.exit.Location = new System.Drawing.Point(350, 468);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(200, 50);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ВыборУровня
            // 
            this.ВыборУровня.BackColor = System.Drawing.Color.Transparent;
            this.ВыборУровня.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ВыборУровня.Font = new System.Drawing.Font("Lucida Handwriting", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ВыборУровня.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ВыборУровня.Location = new System.Drawing.Point(350, 356);
            this.ВыборУровня.Name = "ВыборУровня";
            this.ВыборУровня.Size = new System.Drawing.Size(200, 50);
            this.ВыборУровня.TabIndex = 4;
            this.ВыборУровня.Text = "Level";
            this.ВыборУровня.UseVisualStyleBackColor = false;
            this.ВыборУровня.Click += new System.EventHandler(this.ВыборУровня_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Crossword_Igra.Properties.Resources.zamok1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.ВыборУровня);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.play);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crossword";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button Rules;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button ВыборУровня;
    }
}

