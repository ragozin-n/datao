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
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.Calendar = new System.Windows.Forms.TabPage();
            this.Personal = new System.Windows.Forms.TabPage();
            this.Uslugi = new System.Windows.Forms.TabPage();
            this.Sklad = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Calendar);
            this.tabControl.Controls.Add(this.Personal);
            this.tabControl.Controls.Add(this.Uslugi);
            this.tabControl.Controls.Add(this.Sklad);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(12, 131);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1256, 577);
            this.tabControl.TabIndex = 2;
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
            this.materialTabSelector1.BaseTabControl = this.tabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(12, 75);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1256, 50);
            this.materialTabSelector1.TabIndex = 3;
            this.materialTabSelector1.Text = "tabSelector";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.BackgroundImage = global::DATAO.Properties.Resources.bigstock_Abstract_White_Digital_D_Chao_75094717;
            this.backgroundPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPictureBox.InitialImage = null;
            this.backgroundPictureBox.Location = new System.Drawing.Point(0, 64);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(1283, 720);
            this.backgroundPictureBox.TabIndex = 1;
            this.backgroundPictureBox.TabStop = false;
            this.backgroundPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.backgroundPictureBox);
            this.Name = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backgroundPictureBox;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage Calendar;
        private System.Windows.Forms.TabPage Personal;
        private System.Windows.Forms.TabPage Uslugi;
        private System.Windows.Forms.TabPage Sklad;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
    }
}