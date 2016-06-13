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
using Organization;
using System.IO;

namespace DATAO
{
    public partial class ReportForm : MaterialForm
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            reportTypeComboBox1.SelectedIndex = 0;
        }

        private void saveReportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ваш отчет сохранен в папку -----");
        }

        private void repoerView(DateTime start, DateTime end, int type)
        {
            //расходы
            List<string> spendLine = new List<string>();
            double salary = 0;
            foreach (Worker worker in Enterprise.Personal)
            {
                 double oldSalary = salary; ;
                foreach (KeyValuePair<DateTime, WorkDay> kvp in worker.TimeTable.Data.Where(date => date.Key.Date >=start && date.Key.Date<=end))
                {
                    salary += (kvp.Value.End - kvp.Value.Start).Hours * worker.WageRate;
                }
                spendLine.Add(worker.About.Name.ToString() + "-" + (salary-oldSalary).ToString());
            }
            foreach (Income income in Enterprise.Earnings.Where(inc => (inc.Date.Date >= start && inc.Date.Date <= end.Date)))
            {
                salary += income.Cost;
                spendLine.Add(income.Date.Date.ToString() + "-" + income.Provider + "-" + income.Cost.ToString());
            }
            spendTextBox.Text = salary.ToString();

            //доходы
            double profit = 0;
            foreach(Worker worker in Enterprise.Personal)
            {
                foreach(Event ev in worker.Events.Where(_event => _event.isComplete == true && _event.RecordDate.Date>=start && _event.RecordDate.Date<=end.Date))
                {
                    profit += ev.Cost;
                }
            }
            spendLine.Add("Доход с услуг :" + profit.ToString());
            profitTextBox.Text = profit.ToString();
            if (type != 0)
            {
                //авансовый платеж
                double p = profit - salary;
                double pay = 0;
                if (p > 0)
                {
                    pay = p * 0.15;
                }
                payTextBox.Text = pay.ToString();
            }
            else
            {
                payTextBox.Text = string.Empty;
                StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\report.txt");
                foreach (var item in spendLine)
                {
                    sw.WriteLine(item);
                }
                sw.Close();
            }
        }

        private void reportTypeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(reportTypeComboBox1.SelectedIndex)
            {
                case 0:
                    repoerView(DateTime.Now.Date.AddMonths(-1), DateTime.Now.Date, 0);
                    break;
                case 1:
                    if (DateTime.Now.Day > 25)
                    {
                        MessageBox.Show("Налог уплачивается на следующий месяц идущий за последний месяц квартала с 1 по 25 число");
                    }
                    else {
                        //считается что текущий месяц, это месяц идущий за кварталом, в который надо уплатить налог
                        //(количество дней в предыдущем месяце, предыдущий месяц, текущий год) 
                        repoerView((DateTime.Parse(DateTime.DaysInMonth(DateTime.Now.Date.Year, DateTime.Now.Date.AddMonths(-1).Month)
                            + "/" + DateTime.Now.Date.AddMonths(-1).Month + "/" + DateTime.Now.Year).AddMonths(-3)),
                            (DateTime.Parse(01 + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year)), 1);
                    }
                    break;
                case 2:
                    //заполнить шаблон
                    repoerView(DateTime.Now.Date.AddMonths(-12), DateTime.Now.Date.AddMonths(-9), 1);
                    //теперь добавить из текстбоксов в ячейки 1 кв
                    repoerView(DateTime.Now.Date.AddMonths(-9), DateTime.Now.Date.AddMonths(-6), 1);
                    //теперь добавить из текстбоксов в ячейки 2 кв
                    repoerView(DateTime.Now.Date.AddMonths(-6), DateTime.Now.Date.AddMonths(-3), 1);
                    //теперь добавить из текстбоксов в ячейки 3 кв
                    repoerView(DateTime.Now.Date.AddMonths(-3), DateTime.Now.Date, 1);
                    //теперь добавить из текстбоксов в ячейки 4 кв
                    break;
            }
        }
    }
}
