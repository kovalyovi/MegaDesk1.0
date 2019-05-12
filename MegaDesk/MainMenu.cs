﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddNewQuote_Click(object sender, EventArgs e)
        {
            AddQuote frmAddQuote = new AddQuote(this);
            frmAddQuote.Show();
            Hide();
        }

        private void BtnViewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes frmViewAllQuotes = new ViewAllQuotes(this);
            frmViewAllQuotes.Show();
            Hide();
        }

        private void BtnSearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes frmSearchQuotes = new SearchQuotes(this);
            frmSearchQuotes.Show();
            Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
