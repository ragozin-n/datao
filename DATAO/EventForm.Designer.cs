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
            this.selectWorker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectService = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectTime = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectWorker
            // 
            this.selectWorker.FormattingEnabled = true;
            this.selectWorker.Location = new System.Drawing.Point(51, 161);
            this.selectWorker.Name = "selectWorker";
            this.selectWorker.Size = new System.Drawing.Size(199, 21);
            this.selectWorker.TabIndex = 0;
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
            // selectService
            // 
            this.selectService.FormattingEnabled = true;
            this.selectService.Location = new System.Drawing.Point(51, 98);
            this.selectService.Name = "selectService";
            this.selectService.Size = new System.Drawing.Size(199, 21);
            this.selectService.TabIndex = 3;
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
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(51, 267);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(135, 35);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "Подтвердить";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 346);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.selectTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectWorker);
            this.Name = "EventForm";
            this.Text = "Редактор события";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectTime;
        private System.Windows.Forms.Button confirmButton;
    }
}