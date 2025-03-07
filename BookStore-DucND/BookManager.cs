﻿using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore_DucND
{
    public partial class frmBookManager : Form
    {
        private BookService _service = new BookService();
        public frmBookManager()
        {
            InitializeComponent();
        }

        private void BookManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmBookManager_Load(object sender, EventArgs e)
        {
            var result = _service.GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
            dgvBookList.Columns["BookCategory"].Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
