﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using LibrarySystemBackEnd;

namespace LIBRARY
{
    public partial class BookHistoryInfoForm : DMSkin.Main
    {
        private int index;
        public BookHistoryInfoForm(int i)
        {
            InitializeComponent();
            index = i;
        }
        private void SheetLoad()
        {
            int i = 0;
            for (i = 0; i < ClassBackEnd.Bookhis.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = CreditRecordSheet.Rows.Add(row);
                CreditRecordSheet.Rows[i].Cells[0].Value = (i + 1).ToString();
               // CreditRecordSheet.Rows[i].Cells[1].Value = ;
                CreditRecordSheet.Rows[index].Height = 48;
            }
            while (i < 11)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = CreditRecordSheet.Rows.Add(row);
                CreditRecordSheet.Rows[i].Cells[0].Value = "";
                CreditRecordSheet.Rows[i].Cells[1].Value = "";
                CreditRecordSheet.Rows[index].Height = 48;
                i++;
            }
            CreditRecordSheet.ClearSelection();
            CreditRecordSheet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void BookHistoryInfoForm_Load(object sender, EventArgs e)
        {
            ClassBackEnd.GetBookHistory(index);
            SheetLoad();

        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}