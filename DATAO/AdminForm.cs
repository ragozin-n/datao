﻿using System;
using MaterialSkin.Controls;
using System.Windows.Forms;
using ExcelManager;
using MaterialSkin.Animations;
using MaterialSkin;


namespace DATAO
{
    public partial class AdminForm : MaterialForm
    {
        //В той форме label'ы нужно сделать из MaterialSkin
        private EventForm eventform = new EventForm();

        public AdminForm()
        {
            InitializeComponent();
            loadname();
            personalListBox.ScrollAlwaysVisible = true;
            LoadSchedule();
            LoadPersonal();
            LoadSkladGrid();
            schedulePersonalGrid.Visible = false;
            schedulePersonalGrid.BorderStyle = BorderStyle.None;
            schedulePersonalGrid.ColumnsCount = 7;
            schedulePersonalGrid.FixedRows = 1;
            schedulePersonalGrid.Rows.Insert(0);
            schedulePersonalGrid[0, 0] = new SourceGrid.Cells.ColumnHeader("Понедельник");
            schedulePersonalGrid[0, 1] = new SourceGrid.Cells.ColumnHeader("Вторник");
            schedulePersonalGrid[0, 2] = new SourceGrid.Cells.ColumnHeader("Среда");
            schedulePersonalGrid[0, 3] = new SourceGrid.Cells.ColumnHeader("Четверг");
            schedulePersonalGrid[0, 4] = new SourceGrid.Cells.ColumnHeader("Пятница");
            schedulePersonalGrid[0, 5] = new SourceGrid.Cells.ColumnHeader("Суббота");
            schedulePersonalGrid[0, 6] = new SourceGrid.Cells.ColumnHeader("Воскресенье");
            schedulePersonalGrid.Rows.Insert(1);
            for (int i = 0; i < 7; i++)
            {
                schedulePersonalGrid[1, i] = new SourceGrid.Cells.CheckBox("",false);
            }
            schedulePersonalGrid.AutoSizeCells();
        }

        private void LoadPersonal()
        {
            personalListBox.Items.Clear();
            foreach (Human worker in Table.PersonalList.Workers)
            {
                personalListBox.Items.Add(worker.Name+" "+worker.Surname);
            }
        }

        private int IndexDay()
        {
            DateTime dt = monthCalendar.SelectionStart;
            if (dt.DayOfWeek == DayOfWeek.Monday) return 1;
            if (dt.DayOfWeek == DayOfWeek.Tuesday) return 2;
            if (dt.DayOfWeek == DayOfWeek.Wednesday) return 3;
            if (dt.DayOfWeek == DayOfWeek.Thursday) return 4;
            if (dt.DayOfWeek == DayOfWeek.Friday) return 5;
            if (dt.DayOfWeek == DayOfWeek.Saturday) return 6;
            if (dt.DayOfWeek == DayOfWeek.Sunday) return 7;
            else return -1;
        }

        public void LoadSchedule()
        {
            ScheduleGrid.BorderStyle = BorderStyle.None;
            ScheduleGrid.ColumnsCount = Table.PersonalList.Workers.Count + 1;
            ScheduleGrid.Rows.Insert(0);
            ScheduleGrid[0,0]= new SourceGrid.Cells.ColumnHeader("");
            for (int e=1;e<ScheduleGrid.ColumnsCount;e++)
            {
                ScheduleGrid[0, e] = new SourceGrid.Cells.ColumnHeader(Table.PersonalList.Workers[e-1].Name +" "+ Table.PersonalList.Workers[e - 1].Surname);
            }
            ScheduleGrid.FixedRows = 1;
            int j = 1;
            try
            {
                for (TimeSpan i = Table.Salon.Schedule[IndexDay() - 1].Start; i < Table.Salon.Schedule[IndexDay() - 1].End; i = i + DateTime.Parse("00:30:00").TimeOfDay)
                {
                    ScheduleGrid.Rows.Insert(j);
                    ScheduleGrid[j, 0] = new SourceGrid.Cells.RowHeader(i + "-" + (i + DateTime.Parse("00:30:00").TimeOfDay));
                    for (int k = 1; k < ScheduleGrid.ColumnsCount; k++)
                    {
                        //тут грузить из таблицы
                        ScheduleGrid[j, k] = new SourceGrid.Cells.Cell("", typeof(string));
                    }
                    j++;
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                ScheduleGrid.Rows.RemoveRange(0, ScheduleGrid.Rows.Count);
            }
            ScheduleGrid.AutoSizeCells();
        }
        public void loadname()
        {
            Text = Table.Salon.SalonName;
        }
        private void LoadSkladGrid()
        {
            skladGrid.BorderStyle = BorderStyle.FixedSingle;
            skladGrid.ColumnsCount = 6;
            skladGrid.FixedRows = 1;
            skladGrid.Rows.Insert(0);
            skladGrid[0, 0] = new SourceGrid.Cells.ColumnHeader("Наименование");
            skladGrid[0, 1] = new SourceGrid.Cells.ColumnHeader("Артикул");
            skladGrid[0, 2] = new SourceGrid.Cells.ColumnHeader("Поставщик");
            skladGrid[0, 3] = new SourceGrid.Cells.ColumnHeader("Стоимость (руб.)");
            skladGrid[0, 4] = new SourceGrid.Cells.ColumnHeader("Категория");
            skladGrid[0, 5] = new SourceGrid.Cells.ColumnHeader("Остаток ед.");
            //пример
            //буду подгружать из таблицы циклом {
            skladGrid.Rows.Insert(1);
            skladGrid[1, 0] = new SourceGrid.Cells.Cell("nivea for man", typeof(string));
            skladGrid[1, 1] = new SourceGrid.Cells.Cell(5684123413, typeof(int));
            skladGrid[1, 2] = new SourceGrid.Cells.Cell("ооо шампунькин", typeof(string));
            skladGrid[1, 3] = new SourceGrid.Cells.Cell(256, typeof(int));
            skladGrid[1, 4] = new SourceGrid.Cells.Cell("шампуни", typeof(CheckBox));
            skladGrid[1, 5] = new SourceGrid.Cells.Cell(12, typeof(int));
            //}
            skladGrid.AutoSizeCells();
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            eventform.Show();
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            SetForm set = new SetForm(this);
            set.Show();
        }

        private void newPersonalButton_Click(object sender, EventArgs e)
        {
            if (editPersonalCheckBox.Checked)
            {
                personalListBox.Update();
                uint id = (uint)GetHashCode();
                bool[] schedulePersonal =
                {
                Boolean.Parse(schedulePersonalGrid[1,0].Value.ToString()),
                Boolean.Parse(schedulePersonalGrid[1,1].Value.ToString()),
                Boolean.Parse(schedulePersonalGrid[1,2].Value.ToString()),
                Boolean.Parse(schedulePersonalGrid[1,3].Value.ToString()),
                Boolean.Parse(schedulePersonalGrid[1,4].Value.ToString()),
                Boolean.Parse(schedulePersonalGrid[1,5].Value.ToString()),
                Boolean.Parse(schedulePersonalGrid[1,6].Value.ToString())
                };
                Table.PersonalList.AddWorker(new Human(id, nameTextBox.Text, surnameTextBox.Text, patronymicTextBox.Text,
                    statusTextBox.Text, 0, rateTextBox.Text, phonePersonalTextBox.Text, addressTextBox.Text
                    , schedulePersonal));
                editPersonalCheckBox.CheckState = CheckState.Unchecked;
                LoadPersonal();
                personalListBox.EndUpdate();
            }
            else { MessageBox.Show("Активируйте режим редактирования"); }
        }

        private void addToSkladPictureBox_Click(object sender, EventArgs e)
        {
            skladGrid.Rows.Insert(1);
            skladGrid[1, 0] = new SourceGrid.Cells.Cell("", typeof(string));
            skladGrid[1, 1] = new SourceGrid.Cells.Cell(0, typeof(int));
            skladGrid[1, 2] = new SourceGrid.Cells.Cell("", typeof(string));
            skladGrid[1, 3] = new SourceGrid.Cells.Cell(0, typeof(int));
            skladGrid[1, 4] = new SourceGrid.Cells.Cell("", typeof(string));
            skladGrid[1, 5] = new SourceGrid.Cells.Cell(0, typeof(int));
            skladGrid.AutoSizeCells();
        }

        private void deleteFromSkladPictureBox_Click(object sender, EventArgs e)
        {
            foreach(SourceGrid.GridRow row in skladGrid.Rows )
            {
                if(skladGrid.Selection.IsSelectedRow(row.Index))
                {
                    skladGrid.Rows.Remove(row.Index);
                    break;
                }
            }
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (editPersonalCheckBox.Checked == true)
            {
                nameTextBox.ReadOnly = false;
                surnameTextBox.ReadOnly = false;
                patronymicTextBox.ReadOnly = false;
                phonePersonalTextBox.ReadOnly = false;
                addressTextBox.ReadOnly = false;
                rateTextBox.ReadOnly = false;
                statusTextBox.ReadOnly = false;
                schedulePersonalGrid.Visible = true;
            }
            if (editPersonalCheckBox.Checked == false)
            {
                nameTextBox.ReadOnly = true;
                surnameTextBox.ReadOnly = true;
                patronymicTextBox.ReadOnly = true;
                phonePersonalTextBox.ReadOnly = true;
                addressTextBox.ReadOnly = true;
                rateTextBox.ReadOnly = true;
                statusTextBox.ReadOnly = true;
                schedulePersonalGrid.Visible = false;

            }
        }

        private void doneEventButton_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (ScheduleGrid.Rows.Count != 0)
            {
                ScheduleGrid.Rows.RemoveRange(0, ScheduleGrid.Rows.Count);
            }
            LoadSchedule();
        }

        private void AdminForm_FormClosing(object sender, EventArgs e)
        {
            //Authorization.UploadDatao(ref _user);
        }

        private void personalListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameTextBox.Text = Table.PersonalList.Workers[personalListBox.SelectedIndex].Name;
            surnameTextBox.Text = Table.PersonalList.Workers[personalListBox.SelectedIndex].Surname;
            patronymicTextBox.Text = Table.PersonalList.Workers[personalListBox.SelectedIndex].Patronymic;
            phonePersonalTextBox.Text = Table.PersonalList.Workers[personalListBox.SelectedIndex].Tel;
            addressTextBox.Text = Table.PersonalList.Workers[personalListBox.SelectedIndex].Addres;
            rateTextBox.Text = Table.PersonalList.Workers[personalListBox.SelectedIndex].Rate;
            statusTextBox.Text = Table.PersonalList.Workers[personalListBox.SelectedIndex].Status;
            okPicture1.Visible = Table.PersonalList.Workers[personalListBox.SelectedIndex].Schedule[0];
            okPicture2.Visible = Table.PersonalList.Workers[personalListBox.SelectedIndex].Schedule[1];
            okPicture3.Visible = Table.PersonalList.Workers[personalListBox.SelectedIndex].Schedule[2];
            okPicture4.Visible = Table.PersonalList.Workers[personalListBox.SelectedIndex].Schedule[3];
            okPicture5.Visible = Table.PersonalList.Workers[personalListBox.SelectedIndex].Schedule[4];
            okPicture6.Visible = Table.PersonalList.Workers[personalListBox.SelectedIndex].Schedule[5];
            okPicture7.Visible = Table.PersonalList.Workers[personalListBox.SelectedIndex].Schedule[6];
        }

        private void deletePersonalButton_Click(object sender, EventArgs e)
        {
            try {
                personalListBox.Update();
                //int i = personalListBox.SelectedIndex;
                //personalListBox.Items.RemoveAt(i);
                Table.PersonalList.RemoveWorker(Table.PersonalList.Workers[personalListBox.SelectedIndex].ID);
                LoadPersonal();
                personalListBox.EndUpdate();
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбран рабочий!");
            }
            
        }
    }
}
