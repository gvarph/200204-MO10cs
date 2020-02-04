using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MO10
{//Datum a čas (Console nebo WFA)
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(DayOfWeek)))
            {
                cbDayOfWeek.Items.Add(item);
            }
            for (int i = 1; i <= 31; i++)
            {
                cbDay.Items.Add(i);
            }
        }

        private void ButPersonalIdentificationNumber_Click(object sender, EventArgs e)
        {
            rtbOut.Text = Date.CreationPersonalIdentificationNumber(dtpBirthdate.Value, rgGirl.Checked);
        }

        private void DtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            rtbOut.Text = Date.VypišDn(dtpBirthdate.Value);
        }

        private void CbDayOfWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            Date.Dvt = (DayOfWeek)cbDayOfWeek.SelectedItem;
            rtbOut.Text = Date.RollBirthdate(dtpBirthdate.Value.Year);
        }

        private void CbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            Date.Den = (int)cbDay.SelectedItem;
            rtbOut.Text = Date.RollBirthdate(dtpBirthdate.Value.Year);
        }

        private void TimDeduction_Tick(object sender, EventArgs e)
        {
            labDeduction.Text = Date.Deduction;
        }
    }
}
