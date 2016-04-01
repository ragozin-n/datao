namespace DATAO
{
    partial class AdminForm
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Calendar = new System.Windows.Forms.TabPage();
            this.Personal = new System.Windows.Forms.TabPage();
            this.Uslugi = new System.Windows.Forms.TabPage();
            this.Sklad = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Calendar);
            this.materialTabControl1.Controls.Add(this.Personal);
            this.materialTabControl1.Controls.Add(this.Uslugi);
            this.materialTabControl1.Controls.Add(this.Sklad);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 131);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1256, 577);
            this.materialTabControl1.TabIndex = 2;
            this.materialTabControl1.Visible = false;
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(4, 22);
            this.Calendar.Name = "Calendar";
            this.Calendar.Padding = new System.Windows.Forms.Padding(3);
            this.Calendar.Size = new System.Drawing.Size(1248, 551);
            this.Calendar.TabIndex = 0;
            this.Calendar.Text = "Календарь";
            this.Calendar.UseVisualStyleBackColor = true;
            this.Calendar.Click += new System.EventHandler(this.Calendar_Click);
            // 
            // Personal
            // 
            this.Personal.Location = new System.Drawing.Point(4, 22);
            this.Personal.Name = "Personal";
            this.Personal.Padding = new System.Windows.Forms.Padding(3);
            this.Personal.Size = new System.Drawing.Size(1248, 551);
            this.Personal.TabIndex = 1;
            this.Personal.Text = "Персонал";
            this.Personal.UseVisualStyleBackColor = true;
            // 
            // Uslugi
            // 
            this.Uslugi.Location = new System.Drawing.Point(4, 22);
            this.Uslugi.Name = "Uslugi";
            this.Uslugi.Size = new System.Drawing.Size(1248, 551);
            this.Uslugi.TabIndex = 2;
            this.Uslugi.Text = "Услуги";
            this.Uslugi.UseVisualStyleBackColor = true;
            // 
            // Sklad
            // 
            this.Sklad.Location = new System.Drawing.Point(4, 22);
            this.Sklad.Name = "Sklad";
            this.Sklad.Size = new System.Drawing.Size(1248, 551);
            this.Sklad.TabIndex = 3;
            this.Sklad.Text = "Склад";
            this.Sklad.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(12, 75);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1256, 50);
            this.materialTabSelector1.TabIndex = 3;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DATAO.Properties.Resources.bigstock_Abstract_White_Digital_D_Chao_75094717;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1283, 720);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GAuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GAuthForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Calendar;
        private System.Windows.Forms.TabPage Personal;
        private System.Windows.Forms.TabPage Uslugi;
        private System.Windows.Forms.TabPage Sklad;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
    }
}