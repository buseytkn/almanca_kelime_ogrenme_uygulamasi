﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelime_Ogren
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        private void FrmIstatitsik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'almancaSozlukDataSet.TBLOYUNCULAR' table. You can move, or remove it, as needed.
            this.tBLOYUNCULARTableAdapter.Fill(this.almancaSozlukDataSet.TBLOYUNCULAR);

        }
    }
}
