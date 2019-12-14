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
        }

        void IndexForm_Load(object sender, EventArgs e)
        {
            this.LoadAllBook();         
        }
        public void LoadAllBook()
        {
            var book = this.Business.GetBooks();
            this.grdBook.DataSource = book;
        }
    }
}
