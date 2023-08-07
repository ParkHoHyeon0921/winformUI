using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.MainPage;
using WindowsFormsApp1.Sales_Status;
using WindowsFormsApp1.T_indicators_of_change;

namespace MainFrame
{
    public partial class MainFrameABC : Form
    {
        public MainFrameABC()
        {
            InitializeComponent();
            Home();
        }
        /// <summary>
        /// HomePage Move Setting
        /// </summary>
        public void Home()
        {
            panel1.Controls.Clear();
            this.page_home = new MainPageABC();
            panel1.Controls.Add(this.page_home);
            this.page_home.Show();
            button1.Visible = false;
            this.page_home.ranking1.button1.Click += SubPageMove;
            PageSwitch = 0;
        }
        MainPageABC page_home;
        int PageSwitch = 0;

        /// <summary>
        /// SubPage Move Setting
        /// </summary>
        public void SubPage()
        {
            panel1.Controls.Clear();
            this.page_sub_1 = new Sales_StatusABC();
            panel1.Controls.Add(this.page_sub_1);
            this.page_sub_1.Show();
            button1.Visible = true;
            PageSwitch = 1;
        }
        Sales_StatusABC page_sub_1;
        public void LastPage()
        {
            panel1.Controls.Clear();
            this.page_last = new UserControl1();
            panel1.Controls.Add(this.page_sub_1);
            this.page_last.Show();
            button1.Visible = true;
            PageSwitch = 2;
        }
        UserControl1 page_last;
        
       
        
        /// <summary>
        /// MainPage "매물보기"btn click event => SubPageMove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubPageMove(object sender, EventArgs e)
        {
            SubPage();
        }
        /// <summary>
        /// PrevPageBtn Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (PageSwitch == 1 || PageSwitch == 2)
            {
                Home();
            }
            else if (PageSwitch == 0) 
            {
                SubPage();
            }
        }
        //public void comboBox1_Changed(object sender, EventArgs e)
        //{

        //}
    }
}
