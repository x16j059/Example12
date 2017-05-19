using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            int month = int.Parse(tbxMonth.Text);

            if (month >= 1 && month <= 12)
            {
                if (month == 1 || month == 3 || month == 5 ||
                    month == 7 || month == 8 || month == 10 || month == 12)
                    LbLResult.Text = "大の月";
                else
                    LbLResult.Text = "小の月";

            }
            else
                LbLResult.Text = "入力エラー";
        }
    }
}
