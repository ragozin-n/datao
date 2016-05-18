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
            this.deleteEventButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ScheduleGrid = new SourceGrid.Grid();
            this.doneEventButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AddEventButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.Personal = new System.Windows.Forms.TabPage();
            this.editPersonalCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.deletePersonalButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.newPersonalButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.okPicture7 = new System.Windows.Forms.PictureBox();
            this.okPicture6 = new System.Windows.Forms.PictureBox();
            this.okPicture5 = new System.Windows.Forms.PictureBox();
            this.okPicture4 = new System.Windows.Forms.PictureBox();
            this.okPicture3 = new System.Windows.Forms.PictureBox();
            this.personalListBox = new System.Windows.Forms.ListBox();
            this.groupBoxPersonal = new System.Windows.Forms.GroupBox();
            this.schedulePersonalGrid = new SourceGrid.Grid();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phonePersonalTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.okPicture2 = new System.Windows.Forms.PictureBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.okPicture1 = new System.Windows.Forms.PictureBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.schedulePersonalPicture = new System.Windows.Forms.PictureBox();
            this.Uslugi = new System.Windows.Forms.TabPage();
            this.Sklad = new System.Windows.Forms.TabPage();
            this.deleteFromSkladPictureBox = new System.Windows.Forms.PictureBox();
            this.addToSkladPictureBox = new System.Windows.Forms.PictureBox();
            this.skladGrid = new SourceGrid.Grid();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.settingButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabControl.SuspendLayout();
            this.Calendar.SuspendLayout();
            this.Personal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.okPicture7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPicture6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPicture5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPicture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPicture3)).BeginInit();
            this.groupBoxPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.okPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulePersonalPicture)).BeginInit();
            this.Sklad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteFromSkladPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToSkladPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Calendar);
            this.tabControl.Controls.Add(this.Personal);
            this.tabControl.Controls.Add(this.Uslugi);
            this.tabControl.Controls.Add(this.Sklad);
            this.tabControl.Depth = 0;
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.Location = new System.Drawing.Point(-1, 121);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1281, 600);
            this.tabControl.TabIndex = 2;
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Calendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Calendar.Controls.Add(this.deleteEventButton);
            this.Calendar.Controls.Add(this.ScheduleGrid);
            this.Calendar.Controls.Add(this.doneEventButton);
            this.Calendar.Controls.Add(this.AddEventButton);
            this.Calendar.Controls.Add(this.monthCalendar);
            this.Calendar.Location = new System.Drawing.Point(4, 22);
            this.Calendar.Name = "Calendar";
            this.Calendar.Padding = new System.Windows.Forms.Padding(3);
            this.Calendar.Size = new System.Drawing.Size(1273, 574);
            this.Calendar.TabIndex = 0;
            this.Calendar.Text = "Календарь";
            // 
            // deleteEventButton
            // 
            this.deleteEventButton.Depth = 0;
            this.deleteEventButton.Location = new System.Drawing.Point(25, 335);
            this.deleteEventButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteEventButton.Name = "deleteEventButton";
            this.deleteEventButton.Primary = true;
            this.deleteEventButton.Size = new System.Drawing.Size(164, 39);
            this.deleteEventButton.TabIndex = 5;
            this.deleteEventButton.Text = "Удалить";
            this.deleteEventButton.UseVisualStyleBackColor = true;
            this.deleteEventButton.Click += new System.EventHandler(this.deleteEventButton_Click);
            // 
            // ScheduleGrid
            // 
            this.ScheduleGrid.AutoSize = true;
            this.ScheduleGrid.AutoStretchColumnsToFitWidth = true;
            this.ScheduleGrid.AutoStretchRowsToFitHeight = true;
            this.ScheduleGrid.EnableSort = true;
            this.ScheduleGrid.Location = new System.Drawing.Point(220, 27);
            this.ScheduleGrid.Name = "ScheduleGrid";
            this.ScheduleGrid.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.ScheduleGrid.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.ScheduleGrid.Size = new System.Drawing.Size(1027, 507);
            this.ScheduleGrid.TabIndex = 4;
            this.ScheduleGrid.TabStop = true;
            this.ScheduleGrid.ToolTipText = "";
            // 
            // doneEventButton
            // 
            this.doneEventButton.Depth = 0;
            this.doneEventButton.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneEventButton.Location = new System.Drawing.Point(25, 280);
            this.doneEventButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.doneEventButton.Name = "doneEventButton";
            this.doneEventButton.Primary = true;
            this.doneEventButton.Size = new System.Drawing.Size(164, 38);
            this.doneEventButton.TabIndex = 3;
            this.doneEventButton.Text = "Исполнено/Неисполнено";
            this.doneEventButton.UseVisualStyleBackColor = true;
            this.doneEventButton.Click += new System.EventHandler(this.doneEventButton_Click);
            // 
            // AddEventButton
            // 
            this.AddEventButton.Depth = 0;
            this.AddEventButton.Location = new System.Drawing.Point(25, 219);
            this.AddEventButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Primary = true;
            this.AddEventButton.Size = new System.Drawing.Size(164, 39);
            this.AddEventButton.TabIndex = 2;
            this.AddEventButton.Text = "Настройка визита";
            this.AddEventButton.UseVisualStyleBackColor = true;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(25, 27);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // Personal
            // 
            this.Personal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Personal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Personal.Controls.Add(this.editPersonalCheckBox);
            this.Personal.Controls.Add(this.deletePersonalButton);
            this.Personal.Controls.Add(this.newPersonalButton);
            this.Personal.Controls.Add(this.okPicture7);
            this.Personal.Controls.Add(this.okPicture6);
            this.Personal.Controls.Add(this.okPicture5);
            this.Personal.Controls.Add(this.okPicture4);
            this.Personal.Controls.Add(this.okPicture3);
            this.Personal.Controls.Add(this.personalListBox);
            this.Personal.Controls.Add(this.groupBoxPersonal);
            this.Personal.Location = new System.Drawing.Point(4, 22);
            this.Personal.Name = "Personal";
            this.Personal.Padding = new System.Windows.Forms.Padding(3);
            this.Personal.Size = new System.Drawing.Size(1273, 574);
            this.Personal.TabIndex = 1;
            this.Personal.Text = "Персонал";
            // 
            // editPersonalCheckBox
            // 
            this.editPersonalCheckBox.AutoSize = true;
            this.editPersonalCheckBox.Depth = 0;
            this.editPersonalCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.editPersonalCheckBox.ForeColor = System.Drawing.Color.Transparent;
            this.editPersonalCheckBox.Location = new System.Drawing.Point(1064, 0);
            this.editPersonalCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.editPersonalCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.editPersonalCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.editPersonalCheckBox.Name = "editPersonalCheckBox";
            this.editPersonalCheckBox.Ripple = true;
            this.editPersonalCheckBox.Size = new System.Drawing.Size(186, 30);
            this.editPersonalCheckBox.TabIndex = 20;
            this.editPersonalCheckBox.Text = "Режим редактирования";
            this.editPersonalCheckBox.UseVisualStyleBackColor = true;
            this.editPersonalCheckBox.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // deletePersonalButton
            // 
            this.deletePersonalButton.Depth = 0;
            this.deletePersonalButton.Location = new System.Drawing.Point(136, 496);
            this.deletePersonalButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deletePersonalButton.Name = "deletePersonalButton";
            this.deletePersonalButton.Primary = true;
            this.deletePersonalButton.Size = new System.Drawing.Size(110, 54);
            this.deletePersonalButton.TabIndex = 4;
            this.deletePersonalButton.Text = "Удалить рабочего";
            this.deletePersonalButton.UseVisualStyleBackColor = true;
            this.deletePersonalButton.Click += new System.EventHandler(this.deletePersonalButton_Click);
            // 
            // newPersonalButton
            // 
            this.newPersonalButton.Depth = 0;
            this.newPersonalButton.Location = new System.Drawing.Point(20, 496);
            this.newPersonalButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.newPersonalButton.Name = "newPersonalButton";
            this.newPersonalButton.Primary = true;
            this.newPersonalButton.Size = new System.Drawing.Size(109, 54);
            this.newPersonalButton.TabIndex = 3;
            this.newPersonalButton.Text = "Добавить рабочего";
            this.newPersonalButton.UseVisualStyleBackColor = true;
            this.newPersonalButton.Click += new System.EventHandler(this.newPersonalButton_Click);
            // 
            // okPicture7
            // 
            this.okPicture7.BackgroundImage = global::DATAO.Properties.Resources.grafik1;
            this.okPicture7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.okPicture7.Location = new System.Drawing.Point(1154, 144);
            this.okPicture7.Name = "okPicture7";
            this.okPicture7.Size = new System.Drawing.Size(77, 87);
            this.okPicture7.TabIndex = 19;
            this.okPicture7.TabStop = false;
            this.okPicture7.Visible = false;
            // 
            // okPicture6
            // 
            this.okPicture6.BackgroundImage = global::DATAO.Properties.Resources.grafik1;
            this.okPicture6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.okPicture6.Location = new System.Drawing.Point(1071, 144);
            this.okPicture6.Name = "okPicture6";
            this.okPicture6.Size = new System.Drawing.Size(77, 87);
            this.okPicture6.TabIndex = 18;
            this.okPicture6.TabStop = false;
            // 
            // okPicture5
            // 
            this.okPicture5.BackgroundImage = global::DATAO.Properties.Resources.grafik1;
            this.okPicture5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.okPicture5.Location = new System.Drawing.Point(988, 144);
            this.okPicture5.Name = "okPicture5";
            this.okPicture5.Size = new System.Drawing.Size(77, 87);
            this.okPicture5.TabIndex = 17;
            this.okPicture5.TabStop = false;
            // 
            // okPicture4
            // 
            this.okPicture4.BackgroundImage = global::DATAO.Properties.Resources.grafik1;
            this.okPicture4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.okPicture4.Location = new System.Drawing.Point(907, 144);
            this.okPicture4.Name = "okPicture4";
            this.okPicture4.Size = new System.Drawing.Size(77, 87);
            this.okPicture4.TabIndex = 16;
            this.okPicture4.TabStop = false;
            this.okPicture4.Visible = false;
            // 
            // okPicture3
            // 
            this.okPicture3.BackgroundImage = global::DATAO.Properties.Resources.grafik1;
            this.okPicture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.okPicture3.Location = new System.Drawing.Point(833, 144);
            this.okPicture3.Name = "okPicture3";
            this.okPicture3.Size = new System.Drawing.Size(77, 87);
            this.okPicture3.TabIndex = 15;
            this.okPicture3.TabStop = false;
            // 
            // personalListBox
            // 
            this.personalListBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.personalListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.personalListBox.FormattingEnabled = true;
            this.personalListBox.ItemHeight = 24;
            this.personalListBox.Location = new System.Drawing.Point(20, 25);
            this.personalListBox.Name = "personalListBox";
            this.personalListBox.Size = new System.Drawing.Size(226, 460);
            this.personalListBox.TabIndex = 1;
            this.personalListBox.SelectedIndexChanged += new System.EventHandler(this.personalListBox_SelectedIndexChanged);
            // 
            // groupBoxPersonal
            // 
            this.groupBoxPersonal.Controls.Add(this.schedulePersonalGrid);
            this.groupBoxPersonal.Controls.Add(this.statusTextBox);
            this.groupBoxPersonal.Controls.Add(this.rateTextBox);
            this.groupBoxPersonal.Controls.Add(this.addressTextBox);
            this.groupBoxPersonal.Controls.Add(this.phonePersonalTextBox);
            this.groupBoxPersonal.Controls.Add(this.patronymicTextBox);
            this.groupBoxPersonal.Controls.Add(this.surnameTextBox);
            this.groupBoxPersonal.Controls.Add(this.nameTextBox);
            this.groupBoxPersonal.Controls.Add(this.materialLabel7);
            this.groupBoxPersonal.Controls.Add(this.okPicture2);
            this.groupBoxPersonal.Controls.Add(this.materialLabel6);
            this.groupBoxPersonal.Controls.Add(this.okPicture1);
            this.groupBoxPersonal.Controls.Add(this.materialLabel5);
            this.groupBoxPersonal.Controls.Add(this.materialLabel4);
            this.groupBoxPersonal.Controls.Add(this.materialLabel3);
            this.groupBoxPersonal.Controls.Add(this.materialLabel2);
            this.groupBoxPersonal.Controls.Add(this.materialLabel1);
            this.groupBoxPersonal.Controls.Add(this.schedulePersonalPicture);
            this.groupBoxPersonal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxPersonal.Location = new System.Drawing.Point(281, 25);
            this.groupBoxPersonal.Name = "groupBoxPersonal";
            this.groupBoxPersonal.Size = new System.Drawing.Size(969, 285);
            this.groupBoxPersonal.TabIndex = 11;
            this.groupBoxPersonal.TabStop = false;
            this.groupBoxPersonal.Text = "Информация";
            // 
            // schedulePersonalGrid
            // 
            this.schedulePersonalGrid.EnableSort = true;
            this.schedulePersonalGrid.Location = new System.Drawing.Point(333, 31);
            this.schedulePersonalGrid.Name = "schedulePersonalGrid";
            this.schedulePersonalGrid.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.schedulePersonalGrid.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.schedulePersonalGrid.Size = new System.Drawing.Size(434, 38);
            this.schedulePersonalGrid.TabIndex = 15;
            this.schedulePersonalGrid.TabStop = true;
            this.schedulePersonalGrid.ToolTipText = "";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(109, 238);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(182, 20);
            this.statusTextBox.TabIndex = 14;
            // 
            // rateTextBox
            // 
            this.rateTextBox.Location = new System.Drawing.Point(109, 205);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.ReadOnly = true;
            this.rateTextBox.Size = new System.Drawing.Size(182, 20);
            this.rateTextBox.TabIndex = 13;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(109, 171);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(182, 20);
            this.addressTextBox.TabIndex = 12;
            // 
            // phonePersonalTextBox
            // 
            this.phonePersonalTextBox.Location = new System.Drawing.Point(109, 135);
            this.phonePersonalTextBox.Name = "phonePersonalTextBox";
            this.phonePersonalTextBox.ReadOnly = true;
            this.phonePersonalTextBox.Size = new System.Drawing.Size(182, 20);
            this.phonePersonalTextBox.TabIndex = 11;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(109, 99);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.ReadOnly = true;
            this.patronymicTextBox.Size = new System.Drawing.Size(182, 20);
            this.patronymicTextBox.TabIndex = 10;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(109, 65);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.ReadOnly = true;
            this.surnameTextBox.Size = new System.Drawing.Size(182, 20);
            this.surnameTextBox.TabIndex = 9;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(109, 31);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(182, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(19, 237);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(56, 19);
            this.materialLabel7.TabIndex = 7;
            this.materialLabel7.Text = "Статус";
            // 
            // okPicture2
            // 
            this.okPicture2.BackgroundImage = global::DATAO.Properties.Resources.grafik1;
            this.okPicture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.okPicture2.Location = new System.Drawing.Point(452, 119);
            this.okPicture2.Name = "okPicture2";
            this.okPicture2.Size = new System.Drawing.Size(77, 87);
            this.okPicture2.TabIndex = 14;
            this.okPicture2.TabStop = false;
            this.okPicture2.Visible = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(19, 204);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(59, 19);
            this.materialLabel6.TabIndex = 6;
            this.materialLabel6.Text = "Ставка";
            // 
            // okPicture1
            // 
            this.okPicture1.BackgroundImage = global::DATAO.Properties.Resources.grafik1;
            this.okPicture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.okPicture1.Location = new System.Drawing.Point(357, 119);
            this.okPicture1.Name = "okPicture1";
            this.okPicture1.Size = new System.Drawing.Size(77, 87);
            this.okPicture1.TabIndex = 13;
            this.okPicture1.TabStop = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(19, 169);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(52, 19);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "Адрес";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(19, 135);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(72, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Телефон";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(17, 101);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(75, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Отчество";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(19, 33);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(39, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Имя";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(17, 67);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Фамилия";
            // 
            // schedulePersonalPicture
            // 
            this.schedulePersonalPicture.BackgroundImage = global::DATAO.Properties.Resources.grafik;
            this.schedulePersonalPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.schedulePersonalPicture.Location = new System.Drawing.Point(333, 65);
            this.schedulePersonalPicture.Name = "schedulePersonalPicture";
            this.schedulePersonalPicture.Size = new System.Drawing.Size(630, 157);
            this.schedulePersonalPicture.TabIndex = 12;
            this.schedulePersonalPicture.TabStop = false;
            // 
            // Uslugi
            // 
            this.Uslugi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Uslugi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Uslugi.Location = new System.Drawing.Point(4, 22);
            this.Uslugi.Name = "Uslugi";
            this.Uslugi.Size = new System.Drawing.Size(1273, 574);
            this.Uslugi.TabIndex = 2;
            this.Uslugi.Text = "Услуги";
            // 
            // Sklad
            // 
            this.Sklad.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Sklad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sklad.Controls.Add(this.deleteFromSkladPictureBox);
            this.Sklad.Controls.Add(this.addToSkladPictureBox);
            this.Sklad.Controls.Add(this.skladGrid);
            this.Sklad.Controls.Add(this.textBox5);
            this.Sklad.Controls.Add(this.groupBox1);
            this.Sklad.Controls.Add(this.groupBox2);
            this.Sklad.Location = new System.Drawing.Point(4, 22);
            this.Sklad.Name = "Sklad";
            this.Sklad.Size = new System.Drawing.Size(1273, 574);
            this.Sklad.TabIndex = 3;
            this.Sklad.Text = "Склад";
            // 
            // deleteFromSkladPictureBox
            // 
            this.deleteFromSkladPictureBox.BackgroundImage = global::DATAO.Properties.Resources._;
            this.deleteFromSkladPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteFromSkladPictureBox.Location = new System.Drawing.Point(365, 90);
            this.deleteFromSkladPictureBox.Name = "deleteFromSkladPictureBox";
            this.deleteFromSkladPictureBox.Size = new System.Drawing.Size(56, 45);
            this.deleteFromSkladPictureBox.TabIndex = 10;
            this.deleteFromSkladPictureBox.TabStop = false;
            this.deleteFromSkladPictureBox.Click += new System.EventHandler(this.deleteFromSkladPictureBox_Click);
            // 
            // addToSkladPictureBox
            // 
            this.addToSkladPictureBox.BackgroundImage = global::DATAO.Properties.Resources.__;
            this.addToSkladPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addToSkladPictureBox.Location = new System.Drawing.Point(365, 35);
            this.addToSkladPictureBox.Name = "addToSkladPictureBox";
            this.addToSkladPictureBox.Size = new System.Drawing.Size(56, 48);
            this.addToSkladPictureBox.TabIndex = 9;
            this.addToSkladPictureBox.TabStop = false;
            this.addToSkladPictureBox.Click += new System.EventHandler(this.addToSkladPictureBox_Click);
            // 
            // skladGrid
            // 
            this.skladGrid.AutoStretchColumnsToFitWidth = true;
            this.skladGrid.EnableSort = true;
            this.skladGrid.Location = new System.Drawing.Point(427, 33);
            this.skladGrid.Name = "skladGrid";
            this.skladGrid.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.skladGrid.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.skladGrid.Size = new System.Drawing.Size(793, 514);
            this.skladGrid.SpecialKeys = SourceGrid.GridSpecialKeys.Shift;
            this.skladGrid.TabIndex = 8;
            this.skladGrid.TabStop = true;
            this.skladGrid.ToolTipText = "";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(58, 135);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(230, 20);
            this.textBox5.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(35, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 295);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статистика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Месяц";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.comboBox2.Location = new System.Drawing.Point(73, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ушло единиц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Пришло единиц";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(23, 230);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(230, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(23, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(230, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Расход";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(35, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 173);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Критерий";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Артикул",
            "Наименование",
            "Поставщик",
            "Остаток",
            "Стоимость"});
            this.comboBox1.Location = new System.Drawing.Point(23, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Значение";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 63);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1281, 62);
            this.materialTabSelector1.TabIndex = 4;
            this.materialTabSelector1.Text = "tabSelector";
            // 
            // settingButton
            // 
            this.settingButton.Depth = 0;
            this.settingButton.Location = new System.Drawing.Point(1160, 34);
            this.settingButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingButton.Name = "settingButton";
            this.settingButton.Primary = true;
            this.settingButton.Size = new System.Drawing.Size(108, 39);
            this.settingButton.TabIndex = 5;
            this.settingButton.Text = "Настройки";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabControl);
            this.Name = "AdminForm";
            this.Text = "\"Название салона\"";
            this.Load += new System.EventHandler(this.AdminForm_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.Calendar.ResumeLayout(false);
            this.Calendar.PerformLayout();
            this.Personal.ResumeLayout(false);
            this.Personal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.okPicture7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPicture6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPicture5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPicture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPicture3)).EndInit();
            this.groupBoxPersonal.ResumeLayout(false);
            this.groupBoxPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.okPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulePersonalPicture)).EndInit();
            this.Sklad.ResumeLayout(false);
            this.Sklad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteFromSkladPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToSkladPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage Calendar;
        private System.Windows.Forms.TabPage Uslugi;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private MaterialSkin.Controls.MaterialRaisedButton AddEventButton;
        private MaterialSkin.Controls.MaterialRaisedButton doneEventButton;
        private System.Windows.Forms.TabPage Personal;
        private System.Windows.Forms.TabPage Sklad;
        private System.Windows.Forms.ListBox personalListBox;
        private MaterialSkin.Controls.MaterialRaisedButton newPersonalButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private MaterialSkin.Controls.MaterialRaisedButton deletePersonalButton;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxPersonal;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phonePersonalTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox schedulePersonalPicture;
        private System.Windows.Forms.PictureBox okPicture1;
        private System.Windows.Forms.PictureBox okPicture7;
        private System.Windows.Forms.PictureBox okPicture6;
        private System.Windows.Forms.PictureBox okPicture5;
        private System.Windows.Forms.PictureBox okPicture4;
        private System.Windows.Forms.PictureBox okPicture3;
        private System.Windows.Forms.PictureBox okPicture2;
        private MaterialSkin.Controls.MaterialCheckBox editPersonalCheckBox;
        private SourceGrid.Grid skladGrid;
        private System.Windows.Forms.PictureBox addToSkladPictureBox;
        private MaterialSkin.Controls.MaterialRaisedButton settingButton;
        private System.Windows.Forms.PictureBox deleteFromSkladPictureBox;
        private SourceGrid.Grid schedulePersonalGrid;
        private SourceGrid.Grid ScheduleGrid;
        private MaterialSkin.Controls.MaterialRaisedButton deleteEventButton;
    }
}