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
            this.btnAdd.Click += btnAdd_Click;
            this.btnDelete.Click += btnDelete_Click;
            this.grdBook.DoubleClick += grdBook_DoubleClick;
            this.btnSearch.Click += btnSearch_Click;
            this.btnBack.Click += btnBack_Click;
        }

        void btnBack_Click(object sender, EventArgs e)
        {
            this.LoadAllBook();
        }

        void grdBook_DoubleClick(object sender,EventArgs e)
        {
            var book = (Book)this.grdBook.SelectedRows[0].DataBoundItem;
            var updateForm = new UpdateBookForm(book.id);
            updateForm.ShowDialog();
            this.LoadAllBook();
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.grdBook.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete this?", "Confirm",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var book = (Book)this.grdBook.SelectedRows[0].DataBoundItem;
                    this.Business.DeleteBook(book.id);
                    MessageBox.Show("Delete successfuly");
                    this.LoadAllBook();
                }
            }
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var createForm = new AddForm();
            createForm.ShowDialog();
            this.LoadAllBook();
        }

        void btnSearch_Click(object sender, EventArgs e)
        {
            var AllBooks = this.Business.GetBooks();
            var results = new List<Book>();
            foreach (var b in AllBooks)
            {
                if (b.NameBook.ToLower().Contains(this.txtSearch.Text))
                {
                    results.Add(b);
                }
            }
            this.grdBook.DataSource = null;
            this.grdBook.DataSource = results;
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
