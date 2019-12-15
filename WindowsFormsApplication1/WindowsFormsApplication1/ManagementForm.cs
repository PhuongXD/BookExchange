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
    public partial class ManagementForm : Form
    {
        private LogicLayer Business;
        public ManagementForm()
        {
            this.Business = new LogicLayer();
            InitializeComponent();
            this.Load +=ManagementForm_Load;
            this.btnCreate.Click += btnCreate_Click;
            this.btnDel.Click += btnDel_Click;
            this.grdManagement.DoubleClick += grdManagement_DoubleClick;
        }

        void grdManagement_DoubleClick(object sender, EventArgs e)
        {
            var book = (Book)this.grdManagement.SelectedRows[0].DataBoundItem;
            var updateForm = new UpdateBookForm(book.id);
            updateForm.ShowDialog();
            this.LoadAllBook();
        }

        void btnDel_Click(object sender, EventArgs e)
        {
            if (this.grdManagement.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete this?", "Confirm",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var book = (Book)this.grdManagement.SelectedRows[0].DataBoundItem;
                    this.Business.DeleteBook(book.id);
                    MessageBox.Show("Delete successfuly");
                    this.LoadAllBook();
                }
            }
        
        }

        void btnCreate_Click(object sender, EventArgs e)
        {
            var createForm = new AddForm();
            createForm.ShowDialog();
            this.LoadAllBook();
        }

        void ManagementForm_Load(object sender, EventArgs e)
        {
            this.LoadAllBook();
        }
        private void LoadAllBook()
        {
            var mana = this.Business.GetBooks();
            this.grdManagement.DataSource = mana;
        }


    }
}
