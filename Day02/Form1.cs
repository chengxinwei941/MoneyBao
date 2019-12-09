using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DateModel;

namespace Day02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrmBll<UserInfo> ormBll = new OrmBll<UserInfo>();
            UserInfo model = new UserInfo();
            List<UserInfo> list = ormBll.Select(model);
            dataGridView1.DataSource = list;
            
        }
    }
}
