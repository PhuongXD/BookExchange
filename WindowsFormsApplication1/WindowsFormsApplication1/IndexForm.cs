using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class IndexForm : Form
    {
        private LogicLayer Business;
        public IndexForm()
        {
            InitializeComponent();
            this.Business=new LogicLayer();
            this.Load+=IndexForm_Load;
            this.btnManagement.Click += btnManagement_Click;
            this.btnSearch.Click += btnSearch_Click;
        }

        void btnSearch_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnManagement_Click(object sender, EventArgs e)
        {
            var managementForm = new ManagementForm();
            managementForm.ShowDialog();
            this.LoadAllBook();

        }

        void IndexForm_Load(object sender, EventArgs e)
        {
            this.LoadAllBook();         
        }
        private void LoadAllBook()
        {
            var book = this.Business.GetBooks();
            this.grdBook.DataSource = book;

        }
    }
}
