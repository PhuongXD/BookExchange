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
    public partial class UpdateBookForm : Form
    {
        private int BookId;
        private LogicLayer Business;
        public UpdateBookForm(int id)
        {
            InitializeComponent();
            this.BookId = id;
            this.Business = new LogicLayer();
            this.Load += UpdateBookForm_Load;
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var namebook = this.txtNamebook.Text;
            var author = this.txtAuthor.Text;
            var topic = this.txtTopic.Text;
            var type = this.txtType.Text;
            this.Business.UpdateBook(this.BookId, namebook, author, topic, type);
            MessageBox.Show("Update student successfuly");
            this.Close();

        }

        void UpdateBookForm_Load(object sender, EventArgs e)
        {
            var book = this.Business.GetBook(this.BookId);
            this.txtNamebook.Text = book.NameBook;
            this.txtAuthor.Text = book.Author;
            this.txtTopic.Text = book.Topic;
            this.txtType.Text = book.TypeExchange;
            
        }
        

       
    }
}
