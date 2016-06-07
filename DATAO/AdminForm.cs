using System;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Linq;
using MaterialSkin.Animations;
using MaterialSkin;
using System.Collections.Generic;
using Organization;

namespace DATAO
{
    public partial class AdminForm : MaterialForm
    {

        public AdminForm()
        {
            InitializeComponent();
            personalListBox.ScrollAlwaysVisible = true;

            Text = Enterprise.About.Name;
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
            if ((Enterprise.PriceList.Count / 4) + 1 >= currentPage)
            {
                if (Enterprise.PriceList.Count < 5)
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
                        current4Service.Add(Enterprise.PriceList[(currentPage * 4) - i]);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        break;
                    }
                }

                if (current4Service != null)
                {
                    if (current4Service.Count >= 1)
                    {
                        serviceBox.Visible = true;
                        nameServiceLabel.Text = current4Service[0].About.Name;
                        costService.Text = $"{current4Service[0].Cost.ToString()} рублей";
                        switch(current4Service[0].Duration.ToString().Substring(0, 5))
                        {
                            case "00:30":
                                timeService.Text = newTimeServiceComboBox.Items[0].ToString();
                                break;
                            case "01:00":
                                timeService.Text = newTimeServiceComboBox.Items[1].ToString();
                                break;
                            case "01:30":
                                timeService.Text = newTimeServiceComboBox.Items[2].ToString();
                                break;
                            case "02:00":
                                timeService.Text = newTimeServiceComboBox.Items[3].ToString();
                                break;                               
                        }
                        serviceBox1.Visible = false;
                        serviceBox2.Visible = false;
                        serviceBox3.Visible = false;
                    }
                    if (current4Service.Count >= 2)
                    {
                        serviceBox1.Visible = true;
                        nameServiceLabel1.Text = current4Service[1].About.Name;
                        costService1.Text = $"{current4Service[1].Cost.ToString()} рублей";
                        switch (current4Service[1].Duration.ToString().Substring(0, 5))
                        {
                            case "00:30":
                                timeService1.Text = newTimeServiceComboBox.Items[0].ToString();
                                break;
                            case "01:00":
                                timeService1.Text = newTimeServiceComboBox.Items[1].ToString();
                                break;
                            case "01:30":
                                timeService1.Text = newTimeServiceComboBox.Items[2].ToString();
                                break;
                            case "02:00":
                                timeService1.Text = newTimeServiceComboBox.Items[3].ToString();
                                break;
                        }
                    }
                    if (current4Service.Count >= 3)
                    {
                        serviceBox2.Visible = true;
                        nameServiceLabel2.Text = current4Service[2].About.Name;
                        costService2.Text = $"{current4Service[2].Cost.ToString()} рублей";
                        switch (current4Service[2].Duration.ToString().Substring(0, 5))
                        {
                            case "00:30":
                                timeService2.Text = newTimeServiceComboBox.Items[0].ToString();
                                break;
                            case "01:00":
                                timeService2.Text = newTimeServiceComboBox.Items[1].ToString();
                                break;
                            case "01:30":
                                timeService2.Text = newTimeServiceComboBox.Items[2].ToString();
                                break;
                            case "02:00":
                                timeService2.Text = newTimeServiceComboBox.Items[3].ToString();
                                break;
                        }
                    }
                    if (current4Service.Count == 4)
                    {
                        serviceBox3.Visible = true;
                        nameServiceLabel3.Text = current4Service[3].About.Name;
                        costService3.Text = $"{current4Service[3].Cost.ToString()} рублей";
                        switch (current4Service[3].Duration.ToString().Substring(0, 5))
                        {
                            case "00:30":
                                timeService3.Text = newTimeServiceComboBox.Items[0].ToString();
                                break;
                            case "01:00":
                                timeService3.Text = newTimeServiceComboBox.Items[1].ToString();
                                break;
                            case "01:30":
                                timeService3.Text = newTimeServiceComboBox.Items[2].ToString();
                                break;
                            case "02:00":
                                timeService3.Text = newTimeServiceComboBox.Items[3].ToString();
                                break;
                        }
                    }
                }
            }
        }

        private void LoadPersonal()
        {
            personalListBox.Items.Clear();
            foreach (Worker worker in Enterprise.Personal)
            {
                personalListBox.Items.Add($"{worker.About.Name}");
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
            List<Worker> todayWorker = Enterprise.Personal.FindAll(date => date.TimeTable.Data.ContainsKey(monthCalendar.SelectionStart));

            ScheduleGrid.ColumnsCount = todayWorker.Count + 1;
            ScheduleGrid[0, 0] = new SourceGrid.Cells.ColumnHeader(string.Empty);
            for (int i = 1; i <= todayWorker.Count; i++)
            {
                ScheduleGrid[0, i] = new SourceGrid.Cells.ColumnHeader($"{todayWorker[i - 1].About.Name}");
            }
            ScheduleGrid.FixedRows = 1;

            int j = 1;
            try
            {
                for (TimeSpan i = Enterprise.TimeTable[(Days)IndexDay() + 1][0];
                    i < Enterprise.TimeTable[(Days)IndexDay() + 1][1];
                    i = i + DateTime.Parse("00:30:00").TimeOfDay)
                {
                    ScheduleGrid.Rows.Insert(j);
                    ScheduleGrid[j, 0] = new SourceGrid.Cells.RowHeader($"{i} - {(i + DateTime.Parse("00:30:00").TimeOfDay)}");
                    for (int k = 1; k < ScheduleGrid.ColumnsCount; k++)
                    {
                        if (todayWorker[k - 1].TimeTable.Data[monthCalendar.SelectionStart.Date].End <= i)
                        {
                            ScheduleGrid[j, k] = new SourceGrid.Cells.Cell("Не работает", typeof(string));
                        }
                        else {
                            ScheduleGrid[j, k] = new SourceGrid.Cells.Cell(string.Empty, typeof(string));
                        }
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
            List<Worker> todayWorker = Enterprise.Personal.FindAll(date => date.TimeTable.Data.ContainsKey(monthCalendar.SelectionStart));
            foreach (Worker w in todayWorker)
            {
                foreach (Event ev in w.Events.FindAll(ev1 =>ev1.RecordDate.Date == monthCalendar.SelectionStart.Date))
                {
                    for (int rowIndex = 1; rowIndex < ScheduleGrid.RowsCount; rowIndex++)
                    {
                        if (ev.RecordDate.TimeOfDay == ParseTimeFromCells(ScheduleGrid[rowIndex, 0].Value.ToString(), true))
                        {
                            int count = 0;
                            for (TimeSpan t = DateTime.Parse("00:30:00").TimeOfDay; t <= ev.Service.Duration; t += DateTime.Parse("00:30:00").TimeOfDay)
                            {
                                if (ev.isComplete == true)
                                {
                                    ScheduleGrid[rowIndex + count, todayWorker.IndexOf(w) + 1].Value = "Исполнено";
                                }
                                else
                                {
                                    ScheduleGrid[rowIndex + count, todayWorker.IndexOf(w) + 1].Value = "Занято";
                                }
                                count++;
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

        private void LoadSkladGrid()
        {
            skladGrid.BorderStyle = BorderStyle.FixedSingle;
            skladGrid.ColumnsCount = 5;
            skladGrid.FixedRows = 1;
            skladGrid.Rows.Insert(0);

            string[] names = { "Артикул", "Наименование", "Поставщик", "Стоимость", "Остаток на складе" };
            for (int i = 0; i < names.Length; i++)
            {
                skladGrid[0, i] = new SourceGrid.Cells.ColumnHeader(names[i]);
            }
            int rowIndex = 1;
            foreach (KeyValuePair<Goods, uint> good in Enterprise.GoodsAvailability)
            {
                skladGrid.Rows.Insert(1);
                skladGrid[rowIndex, 0] = new SourceGrid.Cells.ColumnHeader(good.Key.About.ID);
                skladGrid[rowIndex, 1] = new SourceGrid.Cells.ColumnHeader(good.Key.About.Name);
                skladGrid[rowIndex, 2] = new SourceGrid.Cells.ColumnHeader(good.Key.Provider);
                skladGrid[rowIndex, 3] = new SourceGrid.Cells.ColumnHeader(good.Key.Cost);
                skladGrid[rowIndex, 4] = new SourceGrid.Cells.ColumnHeader(good.Value);
                rowIndex++;
            }
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
                ////как то нужно задавать ему расписание
                //bool[] schedulePersonal =
                //{
                //bool.Parse(schedulePersonalGrid[1,0].Value.ToString()),
                //bool.Parse(schedulePersonalGrid[1,1].Value.ToString()),
                //bool.Parse(schedulePersonalGrid[1,2].Value.ToString()),
                //bool.Parse(schedulePersonalGrid[1,3].Value.ToString()),
                //bool.Parse(schedulePersonalGrid[1,4].Value.ToString()),
                //bool.Parse(schedulePersonalGrid[1,5].Value.ToString()),
                //bool.Parse(schedulePersonalGrid[1,6].Value.ToString())
                //};
                Worker _worker = new Worker();
                _worker.About.Name = nameTextBox.Text;
                _worker.About.Fields.Add("Телефон", phonePersonalTextBox.Text);
                _worker.About.Fields.Add("Адрес", addressTextBox.Text);
                _worker.About.Fields.Add("Ставка", rateTextBox.Text);
                _worker.About.Fields.Add("Статус", statusTextBox.Text);
                _worker.About.Fields.Add("Отработанные часы", "0");

                Enterprise.Personal.Add(_worker);

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
            foreach (SourceGrid.GridRow row in skladGrid.Rows)
            {
                if (skladGrid.Selection.IsSelectedRow(row.Index))
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
                saveChangePersonalButton.Visible = true;
                nameTextBox.ReadOnly = false;
                phonePersonalTextBox.ReadOnly = false;
                addressTextBox.ReadOnly = false;
                rateTextBox.ReadOnly = false;
                statusTextBox.ReadOnly = false;
                startPersonalDay.ReadOnly = false;
                endPersonalDay.ReadOnly = false;
                schedulePersonalGrid.Visible = true;
            }
            if (editPersonalCheckBox.Checked == false)
            {
                saveChangePersonalButton.Visible = false;
                nameTextBox.ReadOnly = true;
                phonePersonalTextBox.ReadOnly = true;
                addressTextBox.ReadOnly = true;
                rateTextBox.ReadOnly = true;
                statusTextBox.ReadOnly = true;
                startPersonalDay.ReadOnly = true;
                endPersonalDay.ReadOnly = true;
                schedulePersonalGrid.Visible = false;
            }
        }

        private void doneEventButton_Click(object sender, EventArgs e)
        {
            //находим выдленное событие и исКомплит  = тру
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
            if (Enterprise.Personal.Find(w => w.About.Name == nameWorker).Events.Find(
                ev => ((ev.RecordDate == monthCalendar.SelectionStart.Date + start) && (ev.Service.Duration == end - start))).isComplete == true)
            {
                Enterprise.Personal.Find(w => w.About.Name == nameWorker).Events.Find(
                ev => ((ev.RecordDate == monthCalendar.SelectionStart.Date + start) && (ev.Service.Duration == end - start))).isComplete = false;
            }
            else
            {
                Enterprise.Personal.Find(w => w.About.Name == nameWorker).Events.Find(
                ev => ((ev.RecordDate == monthCalendar.SelectionStart.Date + start) && (ev.Service.Duration == end - start))).isComplete = true;
            }
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateSchedule();
        }

        private void AdminForm_FormClosing(object sender, EventArgs e)
        {
            //
        }

        private void personalListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameTextBox.Text = Enterprise.Personal[personalListBox.SelectedIndex].About.Name;
            phonePersonalTextBox.Text = Enterprise.Personal[personalListBox.SelectedIndex].About.Fields["Телефон"];
            addressTextBox.Text = Enterprise.Personal[personalListBox.SelectedIndex].About.Fields["Адрес"];
            rateTextBox.Text = Enterprise.Personal[personalListBox.SelectedIndex].About.Fields["Ставка"];
            statusTextBox.Text = Enterprise.Personal[personalListBox.SelectedIndex].About.Fields["Статус"];
            if (Enterprise.Personal[personalListBox.SelectedIndex].TimeTable.Data.ContainsKey(monthCalendarPersonal.SelectionStart.Date))
            {
                startPersonalDay.Text = Enterprise.Personal[personalListBox.SelectedIndex].TimeTable.Data
                    [monthCalendarPersonal.SelectionStart.Date].Start.ToString();
                endPersonalDay.Text = Enterprise.Personal[personalListBox.SelectedIndex].TimeTable.Data
                    [monthCalendarPersonal.SelectionStart.Date].End.ToString();
            }
        }

        private void deletePersonalButton_Click(object sender, EventArgs e)
        {
            //
        }

        private void deleteEventButton_Click(object sender, EventArgs e)
        {
            TimeSpan RecordTime = DateTime.Now.TimeOfDay;
            //uint? id = null;
            for (int c = 1; c <= ScheduleGrid.ColumnsCount; c++)
            {
                for (int i = 1; i <= ScheduleGrid.RowsCount; i++)
                {
                    if (ScheduleGrid.Selection.IsSelectedCell(new SourceGrid.Position(i, c)))
                    {
                        RecordTime = ParseTimeFromCells(ScheduleGrid[i, 0].Value.ToString(), true);
                        string name = ScheduleGrid[0, c].Value.ToString();

                        Enterprise.Personal.First(worker => (worker.About.Name == name)).Events.RemoveAll(
                            ev => (ev.RecordDate.TimeOfDay == RecordTime && ev.RecordDate.Date == monthCalendar.SelectionStart.Date));
                    }
                }
            }
        }

        private void newServiceButton_Click(object sender, EventArgs e)
        {
            newServiceBox.Visible = true;
            saveServiceButton.Visible = true;
            newNameServiceTextBox.Text = string.Empty;
            newCostServiceTextBox.Text = string.Empty;
            newTimeServiceComboBox.Text = string.Empty;
        }

        private void saveServiceButton_Click(object sender, EventArgs e)
        {
            try {
                Service newService = new Service();
                newService.About.Name = newNameServiceTextBox.Text;

                switch (newTimeServiceComboBox.SelectedIndex)
                {
                    case 0:
                        newService.Duration = DateTime.Parse("00:30:00").TimeOfDay;
                        break;
                    case 1:
                        newService.Duration = DateTime.Parse("01:00:00").TimeOfDay;
                        break;
                    case 2:
                        newService.Duration = DateTime.Parse("01:30:00").TimeOfDay;
                        break;
                    case 3:
                        newService.Duration = DateTime.Parse("02:00:00").TimeOfDay;
                        break;
                    default:
                        newService.Duration = DateTime.Parse("00:30:00").TimeOfDay;
                        break;
                }

                newService.Cost = uint.Parse(newCostServiceTextBox.Text);

                Enterprise.PriceList.Add(newService);
                newServiceBox.Visible = false;
                saveServiceButton.Visible = false;
                LoadService(1);
            }
            catch(Exception) { MessageBox.Show("Проверьте все поля"); }
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(numberPageLabel.Text) > 1)
            {
                LoadService(int.Parse(numberPageLabel.Text) - 1);
            }
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            LoadService(int.Parse(numberPageLabel.Text) + 1);
        }

        private void deleteServicePicture_Click(object sender, EventArgs e)
        {
            //возможно и тут удалять не надо
            Enterprise.PriceList.RemoveAt((int.Parse(numberPageLabel.Text) * 4) - 4);
            LoadService(1);
        }

        private void deleteServicePicture1_Click(object sender, EventArgs e)
        {
            //возможно и тут удалять не надо
            Enterprise.PriceList.RemoveAt((int.Parse(numberPageLabel.Text) * 4) - 3);
            LoadService(1);
        }

        private void deleteServicePicture2_Click(object sender, EventArgs e)
        {
            //возможно и тут удалять не надо
            Enterprise.PriceList.RemoveAt((int.Parse(numberPageLabel.Text) * 4) - 2);
            LoadService(1);
        }

        private void deleteServicePicture3_Click(object sender, EventArgs e)
        {
            //возможно и тут удалять не надо
            Enterprise.PriceList.RemoveAt((int.Parse(numberPageLabel.Text) * 4) - 1);
            LoadService(1);
        }

        private void saveChangePersonalButton_Click(object sender, EventArgs e)
        {
            try {
                Enterprise.Personal[personalListBox.SelectedIndex].About.Name = nameTextBox.Text;
                Enterprise.Personal[personalListBox.SelectedIndex].About.Fields["Телефон"] = phonePersonalTextBox.Text;
                Enterprise.Personal[personalListBox.SelectedIndex].About.Fields["Адрес"] = addressTextBox.Text;
                Enterprise.Personal[personalListBox.SelectedIndex].About.Fields["Статус"] = statusTextBox.Text;
                if (Enterprise.Personal[personalListBox.SelectedIndex].TimeTable.Data.ContainsKey(monthCalendarPersonal.SelectionStart.Date))
                {
                    Enterprise.Personal[personalListBox.SelectedIndex].TimeTable.Data
                        [monthCalendarPersonal.SelectionStart.Date].Start = TimeSpan.Parse(startPersonalDay.Text);
                    Enterprise.Personal[personalListBox.SelectedIndex].TimeTable.Data
                        [monthCalendarPersonal.SelectionStart.Date].End = TimeSpan.Parse(endPersonalDay.Text);
                }
                else
                {
                    Enterprise.Personal[personalListBox.SelectedIndex].TimeTable.Data.Add(monthCalendarPersonal.SelectionStart.Date,
                        new WorkDay (startPersonalDay.Text+"-"+ endPersonalDay.Text));
                }
                editPersonalCheckBox.CheckState = CheckState.Unchecked;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выберете рабочего");
            }
        }

        private void syncSkladButton_Click(object sender, EventArgs e)
        {
            SyncSklad();
        }

        public void SyncSklad()
        {
            //for(int rowIndex = 1; rowIndex < skladGrid.RowsCount;rowIndex++)
            //{
            //    for(int colIndex = 0; colIndex < skladGrid.ColumnsCount; colIndex ++)
            //    {
            //        //можно ли создавать новый дикшинари?
            //        Enterprise.GoodsAvailability = new
            //    }
            //}
        }

        private void monthCalendarPersonal_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                if(editPersonalCheckBox.Checked == false)
                {
                    startPersonalDay.Text = Enterprise.Personal[personalListBox.SelectedIndex].
                        TimeTable.Data[monthCalendarPersonal.SelectionStart.Date].Start.ToString();
                    endPersonalDay.Text = Enterprise.Personal[personalListBox.SelectedIndex].
                        TimeTable.Data[monthCalendarPersonal.SelectionStart.Date].End.ToString();
                }
            }
            catch(Exception)
            {
                startPersonalDay.Text = String.Empty;
                endPersonalDay.Text = String.Empty;
            }
        }

        private void reportRaisedButton1_Click(object sender, EventArgs e)
        {
            //вызываю метод формирования отчета 
        }
    }
}
