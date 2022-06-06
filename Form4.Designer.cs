namespace Crossword_Igra
{
    partial class Form4
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
            this.Menu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvl1 = new System.Windows.Forms.Button();
            this.lvl2 = new System.Windows.Forms.Button();
            this.level3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Transparent;
            this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu.Font = new System.Drawing.Font("Lucida Handwriting", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Menu.Location = new System.Drawing.Point(500, 500);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(400, 100);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 65.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 112);
            this.label1.TabIndex = 1;
            this.label1.Text = "Level";
            // 
            // lvl1
            // 
            this.lvl1.BackColor = System.Drawing.Color.Transparent;
            this.lvl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lvl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lvl1.ForeColor = System.Drawing.Color.Yellow;
            this.lvl1.Location = new System.Drawing.Point(50, 150);
            this.lvl1.Name = "lvl1";
            this.lvl1.Size = new System.Drawing.Size(100, 100);
            this.lvl1.TabIndex = 2;
            this.lvl1.Text = "level 1";
            this.lvl1.UseVisualStyleBackColor = false;
            this.lvl1.Click += new System.EventHandler(this.lvl1_Click);
            // 
            // lvl2
            // 
            this.lvl2.BackColor = System.Drawing.Color.Transparent;
            this.lvl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lvl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lvl2.ForeColor = System.Drawing.Color.Yellow;
            this.lvl2.Location = new System.Drawing.Point(160, 150);
            this.lvl2.Name = "lvl2";
            this.lvl2.Size = new System.Drawing.Size(100, 100);
            this.lvl2.TabIndex = 3;
            this.lvl2.Text = "level 2";
            this.lvl2.UseVisualStyleBackColor = false;
            this.lvl2.Click += new System.EventHandler(this.lvl2_Click);
            // 
            // level3
            // 
            this.level3.BackColor = System.Drawing.Color.Transparent;
            this.level3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.level3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.level3.ForeColor = System.Drawing.Color.Yellow;
            this.level3.Location = new System.Drawing.Point(266, 150);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(100, 100);
            this.level3.TabIndex = 4;
            this.level3.Text = "level3";
            this.level3.UseVisualStyleBackColor = false;
            this.level3.Click += new System.EventHandler(this.level3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Crossword_Igra.Properties.Resources.СказочныйЗамок1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.level3);
            this.Controls.Add(this.lvl2);
            this.Controls.Add(this.lvl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lvl1;
        private System.Windows.Forms.Button lvl2;
        private System.Windows.Forms.Button level3;
    }
}