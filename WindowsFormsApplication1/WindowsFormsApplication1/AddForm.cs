﻿using System;
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
    public partial class AddForm : Form
    {
        private LogicLayer Business;
        public AddForm()
        {
            InitializeComponent();
            this.Business = new LogicLayer();
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
            var nameuser = this.txtNameuser.Text;
            var topic = this.txtTopic.Text;
            var type = this.txtType.Text;
            this.Business.AddBook(namebook, author, nameuser, topic, type);
            MessageBox.Show("Create book successfully");
            this.Close();
        }

        
    }
}
