namespace DATAO
{
    partial class EventForm
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
            this.SelectWorker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectWork = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectTime = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectWorker
            // 
            this.SelectWorker.FormattingEnabled = true;
            this.SelectWorker.Location = new System.Drawing.Point(51, 161);
            this.SelectWorker.Name = "SelectWorker";
            this.SelectWorker.Size = new System.Drawing.Size(199, 21);
            this.SelectWorker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите мастера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите услугу";
            // 
            // selectWork
            // 
            this.selectWork.FormattingEnabled = true;
            this.selectWork.Location = new System.Drawing.Point(51, 98);
            this.selectWork.Name = "selectWork";
            this.selectWork.Size = new System.Drawing.Size(199, 21);
            this.selectWork.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Выберите время";
            // 
            // selectTime
            // 
            this.selectTime.FormattingEnabled = true;
            this.selectTime.Location = new System.Drawing.Point(51, 225);
            this.selectTime.Name = "selectTime";
            this.selectTime.Size = new System.Drawing.Size(196, 21);
            this.selectTime.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 346);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectWork);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectWorker);
            this.Name = "EventForm";
            this.Text = "Редактор события";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectWork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectTime;
        private System.Windows.Forms.Button button1;
    }
}