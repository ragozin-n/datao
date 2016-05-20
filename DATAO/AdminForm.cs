using System;
using MaterialSkin.Controls;
using System.Windows.Forms;
using ExcelManager;
using System.Linq;
using MaterialSkin.Animations;
using MaterialSkin;
using System.Collections.Generic;

namespace DATAO
{
    public partial class AdminForm : MaterialForm
    {

        public AdminForm()
        {
            InitializeComponent();
            personalListBox.ScrollAlwaysVisible = true;

            loadname();
            LoadSchedule();
            LoadEvent();
            LoadPersonal();
            LoadSkladGrid();
            LoadService(1);
            schedulePersonalGrid.Visible = false;
            schedulePersonalGrid.BorderStyle = BorderStyle.None;
            schedulePersonalGrid.ColumnsCount = 7;
            schedulePersonalGrid.FixedRows = 1;
            schedulePersonalGrid.Rows.Insert(0);

            string[] week = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение" };
            for (int i = 0; i < week.Length; i++)
            {
                schedulePersonalGrid[0, i] = new SourceGrid.Cells.ColumnHeader(week[i]);
            }
            schedulePersonalGrid.Rows.Insert(1);

            for (int i = 0; i < 7; i++)
            {
                schedulePersonalGrid[1, i] = new SourceGrid.Cells.CheckBox(string.Empty, false);
            }
            schedulePersonalGrid.AutoSizeCells();
        }

        private void LoadService(int currentPage)
        {
            if ((Table.Services.ServiceList.Count / 4) + 1 >= currentPage)
            {
                if (Table.Services.ServiceList.Count < 5)
                {
                    numberPageLabel.Text = "1";
                }
                else {
                    numberPageLabel.Text = currentPage.ToString();
                }
                List<Service> current4Service = new List<Service>();
                for (int i = 4; i > 0; i--)
                {
                    try
                    {
                        current4Service.Add(Table.Services.ServiceList[(currentPage * 4) - i]);
                    }
                    catch(ArgumentOutOfRangeException)
                    {
                        break;
                    }
                }

                if (current4Service != null)
                {
                    if (current4Service.Count == 1)
                    {
                        serviceBox.Visible = true;
                        nameServiceLabel.Text = current4Service[0].Name;
                        costService.Text = $"{current4Service[0].Cost.ToString()} рублей";
                        timeService.Text = $"{current4Service[0].Duration.ToString().Substring(0, 5)} минут";
                        serviceBox1.Visible = false;
                        serviceBox2.Visible = false;
                        serviceBox3.Visible = false;
                    }
                    if (current4Service.Count == 2)
                    {
                        serviceBox.Visible = true;
                        nameServiceLabel.Text = current4Service[0].Name;
                        costService.Text = $"{current4Service[0].Cost.ToString()} рублей";
                        timeService.Text = $"{current4Service[0].Duration.ToString().Substring(0, 5)} минут";
                        serviceBox1.Visible = true;
                        nameServiceLabel1.Text = current4Service[1].Name;
                        costService1.Text = $"{current4Service[1].Cost.ToString()} рублей";
                        timeService1.Text = $"{current4Service[1].Duration.ToString().Substring(0, 5)} минут";
                        serviceBox2.Visible = false;
                        serviceBox3.Visible = false;
                    }
                    if (current4Service.Count == 3)
                    {
                        serviceBox.Visible = true;
                        nameServiceLabel.Text = current4Service[0].Name;
                        costService.Text = current4Service[0].Cost.ToString() + "рублей";
                        timeService.Text = current4Service[0].Duration.ToString().Substring(0, 5) + " минут";
                        serviceBox1.Visible = true;
                        nameServiceLabel1.Text = current4Service[1].Name;
                        costService1.Text = $"{current4Service[1].Cost.ToString()} рублей";
                        timeService1.Text = current4Service[1].Duration.ToString().Substring(0, 5) + " минут";
                        serviceBox2.Visible = true;
                        nameServiceLabel2.Text = current4Service[2].Name;
                        costService2.Text = $"{current4Service[2].Cost.ToString()} рублей";
                        timeService2.Text = current4Service[2].Duration.ToString().Substring(0, 5) + " минут";
                        serviceBox3.Visible = false;
                    }
                    if (current4Service.Count == 4)
                    {
                        serviceBox.Visible = true;
                        nameServiceLabel.Text = current4Service[0].Name;
                        costService.Text = current4Service[0].Cost.ToString() + "рублей";
                        timeService.Text = current4Service[0].Duration.ToString().Substring(0, 5) + " минут";
                        serviceBox1.Visible = true;
                        nameServiceLabel1.Text = current4Service[1].Name;
                        costService1.Text = $"{current4Service[1].Cost.ToString()} рублей";
                        timeService1.Text = current4Service[1].Duration.ToString().Substring(0, 5) + " минут";
                        serviceBox2.Visible = true;
                        nameServiceLabel2.Text = current4Service[2].Name;
                        costService2.Text = $"{current4Service[2].Cost.ToString()} рублей";
                        timeService2.Text = current4Service[2].Duration.ToString().Substring(0, 5) + " минут";
                        serviceBox3.Visible = true;
                        nameServiceLabel3.Text = current4Service[3].Name;
                        costService3.Text = $"{current4Service[3].Cost.ToString()} рублей";
                        timeService3.Text = current4Service[3].Duration.ToString().Substring(0, 5) + " минут";
                    }
                }
            }
        }

        private void LoadPersonal()
        {
            personalListBox.Items.Clear();
            foreach (Human worker in Table.PersonalList.Workers)
            {
                personalListBox.Items.Add($"{worker.Name} {worker.Surname}");
            }
        }

        private int IndexDay()
        {
            return (int)monthCalendar.SelectionStart.DayOfWeek;
        }

        private void LoadSchedule()
        {
            ScheduleGrid.BorderStyle = BorderStyle.None;
            ScheduleGrid.Rows.Insert(0);

            List<Human> todayWorker = Table.PersonalList.Workers.FindAll(date => date.Schedule[IndexDay() - 1] == true);

            ScheduleGrid.ColumnsCount = todayWorker.Count+1;
            ScheduleGrid[0, 0] = new SourceGrid.Cells.ColumnHeader(string.Empty);
            for (int i = 1;i<=todayWorker.Count;i++)
            {
                ScheduleGrid[0,i] = new SourceGrid.Cells.ColumnHeader($"{todayWorker[i-1].Name} {todayWorker[i-1].Surname}");
            }
            ScheduleGrid.FixedRows = 1;

            int j = 1;
            try
            {
                for (TimeSpan i = Table.Salon.Schedule[IndexDay() - 1].Start; i < Table.Salon.Schedule[IndexDay() - 1].End; i = i + DateTime.Parse("00:30:00").TimeOfDay)
                {
                    ScheduleGrid.Rows.Insert(j);
                    ScheduleGrid[j, 0] = new SourceGrid.Cells.RowHeader($"{i} - {(i + DateTime.Parse("00:30:00").TimeOfDay)}");
                    for (int k = 1; k < ScheduleGrid.ColumnsCount; k++)
                    {
                        ScheduleGrid[j, k] = new SourceGrid.Cells.Cell(string.Empty, typeof(string));
                    }
                    j++;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                ScheduleGrid.Rows.RemoveRange(0, ScheduleGrid.Rows.Count);
            }
            finally
            {
                ScheduleGrid.AutoSizeCells();
            }
        }

        private void LoadEvent()
        {
            List<Event> todayEvent = Table.WorkList.Calendar.FindAll(date => date.Date == monthCalendar.SelectionStart);
            List<Human> todayWorker = Table.PersonalList.Workers.FindAll(date => date.Schedule[IndexDay() - 1] == true);
            foreach (Event ev in todayEvent)
            {
                foreach(Human w in todayWorker)
                {
                    if(ev.WorkerID==w.ID)
                    {
                        for(int rowIndex = 1; rowIndex < ScheduleGrid.RowsCount; rowIndex++)
                        {
                            if(ev.StartAt == ParseTimeFromCells(ScheduleGrid[rowIndex, 0].Value.ToString(), true))
                            {
                                if (ev.EndAt - ev.StartAt >= DateTime.Parse("00:30:00").TimeOfDay)
                                {
                                    int count = 0;
                                    for (TimeSpan t = ev.StartAt; t < ev.EndAt; t += DateTime.Parse("00:30:00").TimeOfDay)
                                    {
                                        ScheduleGrid[rowIndex + count, todayWorker.IndexOf(w) + 1].ToolTipText = ev.ClientName+"-"
                                            +Table.Services.ServiceList.Find(serv=>serv.ID==ev.ServiceID).Name;
                                        ScheduleGrid[rowIndex + count, todayWorker.IndexOf(w)+1].Value = "Занято";
                                        count++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void UpdateSchedule()
        {
            if (ScheduleGrid.RowsCount != 0)
            {
                ScheduleGrid.Rows.RemoveRange(0, ScheduleGrid.RowsCount);
            }
            LoadSchedule();
            LoadEvent();
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

            string[] names = {"Наименование", "Артикул", "Поставщик", "Стоимость (руб.)", "Категория", "Остаток ед." };
            for (int i = 0; i < names.Length; i++)
            {
                skladGrid[0, i] = new SourceGrid.Cells.ColumnHeader(names[i]);
            }
            
            //пример
            skladGrid.Rows.Insert(1);
            skladGrid[1, 0] = new SourceGrid.Cells.Cell("nivea for man", typeof(string));
            skladGrid[1, 1] = new SourceGrid.Cells.Cell(5684123413, typeof(int));
            skladGrid[1, 2] = new SourceGrid.Cells.Cell("ооо шампунькин", typeof(string));
            skladGrid[1, 3] = new SourceGrid.Cells.Cell(256, typeof(int));
            skladGrid[1, 4] = new SourceGrid.Cells.Cell("шампуни", typeof(CheckBox));
            skladGrid[1, 5] = new SourceGrid.Cells.Cell(12, typeof(int));
            skladGrid.AutoSizeCells();
        }

        private TimeSpan ParseTimeFromCells(string time, bool startTime, char separator = '-')
        {
            string[] timeInterval = new string[2];
            timeInterval = time.Split(separator);
            DateTime _start, _end;
            TimeSpan Start = DateTime.Parse("00:00:00").TimeOfDay;
            TimeSpan End = DateTime.Parse("00:00:00").TimeOfDay;

            if (DateTime.TryParse(timeInterval[0], out _start) && DateTime.TryParse(timeInterval[1], out _end))
            {
                Start = _start.TimeOfDay;
                End = _end.TimeOfDay;
            }

            return (startTime ? Start : End);
            //if (startTime == true)
            //{
            //    return Start;
            //}
            //else
            //{
            //    return End;
            //}
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            TimeSpan start = DateTime.Now.TimeOfDay;
            TimeSpan end = DateTime.Now.TimeOfDay;
            string nameWorker = string.Empty;

            for (int c = 1; c <= ScheduleGrid.ColumnsCount; c++)
            {
                int j = 0;
                for (int i = 1; i <= ScheduleGrid.RowsCount; i++)
                {
                    if (ScheduleGrid.Selection.IsSelectedCell(new SourceGrid.Position(i, c)))
                    {
                        if (j == 0)
                        {
                            start = ParseTimeFromCells(ScheduleGrid[i, 0].Value.ToString(), true);
                            end = ParseTimeFromCells(ScheduleGrid[i, 0].Value.ToString(), false);
                            j++;
                            nameWorker = ScheduleGrid[0, c].Value.ToString();
                        }
                        else
                        {
                            end = ParseTimeFromCells(ScheduleGrid[i, 0].Value.ToString(), false);
                        }
                    }
                }
            }

            EventForm eventform = new EventForm(this, monthCalendar.SelectionStart,       //день
                start,     //время начала
                end,       //время конца
                nameWorker  //персонал
                );
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
                bool[] schedulePersonal =
                {
                bool.Parse(schedulePersonalGrid[1,0].Value.ToString()),
                bool.Parse(schedulePersonalGrid[1,1].Value.ToString()),
                bool.Parse(schedulePersonalGrid[1,2].Value.ToString()),
                bool.Parse(schedulePersonalGrid[1,3].Value.ToString()),
                bool.Parse(schedulePersonalGrid[1,4].Value.ToString()),
                bool.Parse(schedulePersonalGrid[1,5].Value.ToString()),
                bool.Parse(schedulePersonalGrid[1,6].Value.ToString())
                };

                Table.PersonalList.AddWorker(new Human(nameTextBox.Text, surnameTextBox.Text, patronymicTextBox.Text,
                    statusTextBox.Text, 0, rateTextBox.Text, phonePersonalTextBox.Text, addressTextBox.Text
                    , schedulePersonal));

                editPersonalCheckBox.CheckState = CheckState.Unchecked;
                LoadPersonal();
                personalListBox.EndUpdate();
            }
            else
            {
                MessageBox.Show("Активируйте режим редактирования");
            }
        }

        private void addToSkladPictureBox_Click(object sender, EventArgs e)
        {
            skladGrid.Rows.Insert(1);
            skladGrid[1, 0] = new SourceGrid.Cells.Cell(string.Empty, typeof(string));
            skladGrid[1, 1] = new SourceGrid.Cells.Cell(0, typeof(int));
            skladGrid[1, 2] = new SourceGrid.Cells.Cell(string.Empty, typeof(string));
            skladGrid[1, 3] = new SourceGrid.Cells.Cell(0, typeof(int));
            skladGrid[1, 4] = new SourceGrid.Cells.Cell(string.Empty, typeof(string));
            skladGrid[1, 5] = new SourceGrid.Cells.Cell(0, typeof(int));
            skladGrid.AutoSizeCells();
        }

        private void deleteFromSkladPictureBox_Click(object sender, EventArgs e)
        {
            //linq
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
            //нужно найти какое это было событие (стрижка или маникюр, например)
            //и сделать +1 в статистике по этому событию
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateSchedule();
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
                Table.PersonalList.RemoveWorker(Table.PersonalList.Workers[personalListBox.SelectedIndex].ID);
                LoadPersonal();
                personalListBox.EndUpdate();
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбран рабочий!");
            }
            
        }

        private void deleteEventButton_Click(object sender, EventArgs e)
        {
            TimeSpan start = DateTime.Now.TimeOfDay;
            uint? id = null;
            for (int c = 1; c <= ScheduleGrid.ColumnsCount; c++)
            {
                for (int i = 1; i <= ScheduleGrid.RowsCount; i++)
                {
                    if (ScheduleGrid.Selection.IsSelectedCell(new SourceGrid.Position(i, c)))
                    {
                        start = ParseTimeFromCells(ScheduleGrid[i, 0].Value.ToString(), true);

                        string[] name = ScheduleGrid[0, c].Value.ToString().Split(' ');
                        id = Table.PersonalList.Workers.First(worker => (worker.Name == name[0] && worker.Surname == name[1])).ID;
                    }
                }
            }
            //MessageBox.Show($"{monthCalendar.SelectionStart.ToString()} {start.ToString()} {id}");
            if(id != null)
            {
                Table.WorkList.RemoveEventFromCalendar(monthCalendar.SelectionStart.Date, start, (uint)id);
                UpdateSchedule();
            }
        }

        private void newServiceButton_Click(object sender, EventArgs e)
        {
            newServiceBox.Visible = true;
            saveServiceButton.Visible = true;
            newNameServiceTextBox.Text = string.Empty;
            newCostServiceTextBox.Text = string.Empty;
            newTimeServiceTextBox.Text = string.Empty;
        }

        private void saveServiceButton_Click(object sender, EventArgs e)
        {
            Service newService = new Service(newNameServiceTextBox.Text,
                uint.Parse(newCostServiceTextBox.Text), DateTime.Parse(newTimeServiceTextBox.Text).TimeOfDay
                );

            Table.Services.AddNewService(newService);
            newServiceBox.Visible = false;
            saveServiceButton.Visible = false;
            LoadService(1);
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            if(int.Parse(numberPageLabel.Text) > 1)
            {
                LoadService(int.Parse(numberPageLabel.Text)-1);
            }
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            LoadService(int.Parse(numberPageLabel.Text) + 1);
        }

        private void deleteServicePicture_Click(object sender, EventArgs e)
        {
            Table.Services.RemoveService(Table.Services.ServiceList[(int.Parse(numberPageLabel.Text) * 4) - 4]);
            LoadService(1);
        }

        private void deleteServicePicture1_Click(object sender, EventArgs e)
        {
            Table.Services.RemoveService(Table.Services.ServiceList[(int.Parse(numberPageLabel.Text) * 4) - 3]);
            LoadService(1);
        }

        private void deleteServicePicture2_Click(object sender, EventArgs e)
        {
            Table.Services.RemoveService(Table.Services.ServiceList[(int.Parse(numberPageLabel.Text) * 4) - 2]);
            LoadService(1);
        }

        private void deleteServicePicture3_Click(object sender, EventArgs e)
        {
            Table.Services.RemoveService(Table.Services.ServiceList[(int.Parse(numberPageLabel.Text) * 4) - 1]);
            LoadService(1);
        }
    }
}
