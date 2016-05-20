using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using ExcelManager;

namespace DATAO
{
    public partial class EventForm : MaterialForm
    {
        DateTime data;
        TimeSpan startTime;
        TimeSpan endTime;
        string nameWorker;
        AdminForm ad;
        public EventForm(AdminForm adF, DateTime data1, TimeSpan startTime1, TimeSpan endTime1, string nameWorker1)
        {
            InitializeComponent();
            ad = adF;
            data = data1;
            startTime = startTime1;
            endTime = endTime1;
            nameWorker = nameWorker1;
            selectWorker.Text = nameWorker1;
            selectTimeStart.Text = startTime1.ToString();
            selectTimeEnd.Text = endTime1.ToString();
            foreach (Service s in Table.Services.ServiceList)
            {
                if ((endTime1 - startTime1) >= s.Duration)
                {
                    selectService.Items.Add(s.Name);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(data.ToString()+" "+startTime.ToString()+" "+endTime.ToString()+" "+nameWorker);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (data != null && startTime != null && endTime != null && nameWorker != null && clientName.Text != "")
            {
                uint idWorker = 0;
                uint idService = Table.Services.ServiceList.Find(x => x.Name == selectService.Text).ID;
                foreach(Human w in Table.PersonalList.Workers)
                {
                    if (w.Name + " " + w.Surname == nameWorker)
                    {
                        idWorker = w.ID;
                        break;
                    }
                }
                //MessageBox.Show(idWorker.ToString());
                if (idWorker == 0 && idService == 0) { MessageBox.Show("нет услуги или рабочего"); Hide(); }
                else {
                    Event currentEvent = new Event(data,
                        startTime, endTime, clientName.Text, idWorker,
                        idService
                        );
                    Table.WorkList.AddEventToCalendar(currentEvent);
                    ad.UpdateSchedule();
                    Hide();
                }
            }
        }

        private void selectService_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
