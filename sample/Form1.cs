using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public partial class Form1 : Form
    {
        sampleService service = new sampleService();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = service.getData();
        }
    }
}
