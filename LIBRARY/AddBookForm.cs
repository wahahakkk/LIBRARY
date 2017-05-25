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
    public partial class AddBookForm : DMSkin.Main
    {
        string SavePath = "";
        public AddBookForm()
        {
            InitializeComponent();
        }
        private void AddBookForm_Load(object sender, EventArgs e)
        {

            AddImageButton.BackColor = Color.Transparent;
            AddImageButton.Parent = BookImagePictureBox;
            AddImageButton.Location = new Point(40, 77);
            AddImageButton.BringToFront();

            IDTextBox.Text = ClassTime.getNextIsbn();//max 99 books per day


        }

        private void ShutDownButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Animate
        private void BookNameCueText_Click(object sender, EventArgs e)
        {
            if (BookNameTextBox.Text == "")
            {
                BookNameCueText.Hide();
                BookNameTextBox.Focus();
            }
        }

        private void PublisherCueText_Click(object sender, EventArgs e)
        {
            if (PublisherTextBox.Text == "")
            {
                PublisherCueText.Hide();
                PublisherTextBox.Focus();
            }
        }

        private void BookAmountCueText_Click(object sender, EventArgs e)
        {
            if (BookAmountTextBox.Text == "")
            {
                BookAmountCueText.Hide();
                BookAmountTextBox.Focus();
            }
        }

        private void BookInfoCueText_Click(object sender, EventArgs e)
        {
            if (BookInfoTextBox.Text == "")
            {
                BookInfoCueText.Hide();
                BookInfoTextBox.Focus();
            }
        }

        private void Label1CueText_Click(object sender, EventArgs e)
        {
            if(Label1TextBox.Text=="")
            {
                Label1CueText.Hide();
                Label1TextBox.Focus();
            }
        }

        private void Label2CueText_Click(object sender, EventArgs e)
        {
            if (Label2TextBox.Text == "")
            {
                Label2CueText.Hide();
                Label2TextBox.Focus();
            }
        }

        private void Label3CueText_Click(object sender, EventArgs e)
        {
            if (Label3TextBox.Text == "")
            {
                Label3CueText.Hide();
                Label3TextBox.Focus();
            }
        }

        private void Label1TextBox_Enter(object sender, EventArgs e)
        {
            if (Label1TextBox.Text == "")
            {
                Label1CueText.Hide();
            }
        }

        private void Label1TextBox_Leave(object sender, EventArgs e)
        {
            if (Label1TextBox.Text == "")
            {
                Label1CueText.Show();
            }
        }

        private void Label2TextBox_Enter(object sender, EventArgs e)
        {
            if (Label2TextBox.Text == "")
            {
                Label2CueText.Hide();
            }
        }

        private void Label2TextBox_Leave(object sender, EventArgs e)
        {
            if (Label2TextBox.Text == "")
            {
                Label2CueText.Show();
            }
        }

        private void Label3TextBox_Enter(object sender, EventArgs e)
        {
            if (Label3TextBox.Text == "")
            {
                Label3CueText.Hide();
            }
        }

        private void Label3TextBox_Leave(object sender, EventArgs e)
        {
            if (Label3TextBox.Text == "")
            {
                Label3CueText.Show();
            }

        }

        private void BookNameTextBox_Enter(object sender, EventArgs e)
        {
            if (BookNameTextBox.Text == "")
            {
                BookNameCueText.Hide();
            }
        }

        private void BookNameTextBox_Leave(object sender, EventArgs e)
        {
            if (BookNameTextBox.Text == "")
            {
                BookNameCueText.Show();
            }
        }

        private void AuthorTextBox_Enter(object sender, EventArgs e)
        {
            if (AuthorTextBox.Text == "")
            {
                AuthorCueText.Hide();
            }
        }

        private void AuthorTextBox_Leave(object sender, EventArgs e)
        {
            if (AuthorTextBox.Text == "")
            {
                AuthorCueText.Show();
            }
        }

        private void PublisherTextBox_Enter(object sender, EventArgs e)
        {
            if (PublisherTextBox.Text == "")
            {
                PublisherCueText.Hide();
            }
        }

        private void PublisherTextBox_Leave(object sender, EventArgs e)
        {
            if (PublisherTextBox.Text == "")
            {
                PublisherCueText.Show();
            }
        }

        private void BookAmountTextBox_Enter(object sender, EventArgs e)
        {
            if (BookAmountTextBox.Text == "")
            {
                BookAmountCueText.Hide();
            }
        }

        private void BookAmountTextBox_Leave(object sender, EventArgs e)
        {
            if (BookAmountTextBox.Text == "")
            {
                BookAmountCueText.Show();
            }
        }

        private void BookInfoTextBox_Enter(object sender, EventArgs e)
        {
            if (BookInfoTextBox.Text == "")
            {
                BookInfoCueText.Hide();
            }
        }

        private void BookInfoTextBox_Leave(object sender, EventArgs e)
        {
            if (BookInfoTextBox.Text == "")
            {
                BookInfoCueText.Show();
            }
        }

        private void AddImageButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddImageButton.BackgroundImage = AddImageButton.DM_HoverImage;
        }

        private void AddImageButton_MouseLeave(object sender, EventArgs e)
        {
            AddImageButton.BackgroundImage = AddImageButton.DM_NolImage;
        }

        private void OKButton_MouseMove(object sender, MouseEventArgs e)
        {
            OKButton.BackgroundImage = OKButton.DM_HoverImage;
        }

        private void OKButton_MouseLeave(object sender, EventArgs e)
        {
            OKButton.BackgroundImage = OKButton.DM_NolImage;
        }

        #endregion

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            DialogResult result = OpenImage.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = OpenImage.FileName;
                System.IO.File.Copy(path, @"data\book\pic\" + OpenImage.SafeFileName, true);
                SavePath = @"data\book\pic\" + OpenImage.SafeFileName;
                BookImagePictureBox.Image = Image.FromFile(path);
                OpenImage.InitialDirectory = path.Substring(0, path.Length - OpenImage.SafeFileName.Length);
            }
        }
        private bool CheckInput()
        {
            try
            {
                var amount = Convert.ToInt32(BookAmountTextBox.Text);
            }
            catch
            {
                InfoBox infoBox = new InfoBox(13);
                infoBox.ShowDialog();
                infoBox.Dispose();
                BookAmountTextBox.Focus();
                return false;
            }
            return true;
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            //to do check true
            if (CheckInput())
                ClassBackEnd.AddBook(IDTextBox.Text, BookNameTextBox.Text, PublisherTextBox.Text, AuthorTextBox.Text, Convert.ToInt32(BookAmountTextBox.Text),Label1TextBox.Text,Label2TextBox.Text,Label3TextBox.Text, SavePath, BookInfoTextBox.Text);
            Close();
        }

       
    }
}
