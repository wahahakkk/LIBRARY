﻿namespace LIBRARY
{
    partial class UserBookDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBookDetailForm));
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.ResultDataSheet = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookInfoTextbox = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.authorLabel = new System.Windows.Forms.Label();
            this.AuthorText = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.PublisherText = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BookIDLabel = new System.Windows.Forms.Label();
            this.BookIDText = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountText = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LabelLabel = new System.Windows.Forms.Label();
            this.Label3Text = new System.Windows.Forms.Label();
            this.Label1Text = new System.Windows.Forms.Label();
            this.Label2Text = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.CommentSubmitBtn = new System.Windows.Forms.Button();
            this.NextPageButton = new System.Windows.Forms.Button();
            this.LastPageButton = new System.Windows.Forms.Button();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BookImageRequest = new System.ComponentModel.BackgroundWorker();
            this.BookCommentRequest = new System.ComponentModel.BackgroundWorker();
            this.WaitingThread = new System.ComponentModel.BackgroundWorker();
            this.BookListRequest = new System.ComponentModel.BackgroundWorker();
            this.BookListRequestWaiting = new System.ComponentModel.BackgroundWorker();
            this.BookPictureBox = new System.Windows.Forms.PictureBox();
            this.BookOrderButton = new DMSkin.Controls.DM.DMButtonImage();
            this.BookBorrowButton = new DMSkin.Controls.DM.DMButtonImage();
            this.NoUseButton = new DMSkin.Controls.DM.DMButtonImage();
            this.LoadGIFBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataSheet)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadGIFBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.BookNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookNameLabel.Font = new System.Drawing.Font("微软雅黑", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookNameLabel.Location = new System.Drawing.Point(66, 37);
            this.BookNameLabel.Margin = new System.Windows.Forms.Padding(64, 35, 64, 0);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(245, 57);
            this.BookNameLabel.TabIndex = 0;
            this.BookNameLabel.Text = "人民的名义";
            // 
            // ResultDataSheet
            // 
            this.ResultDataSheet.AllowUserToAddRows = false;
            this.ResultDataSheet.AllowUserToDeleteRows = false;
            this.ResultDataSheet.AllowUserToResizeColumns = false;
            this.ResultDataSheet.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.ResultDataSheet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ResultDataSheet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ResultDataSheet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultDataSheet.CausesValidation = false;
            this.ResultDataSheet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultDataSheet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ResultDataSheet.ColumnHeadersHeight = 40;
            this.ResultDataSheet.ColumnHeadersVisible = false;
            this.ResultDataSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookState});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultDataSheet.DefaultCellStyle = dataGridViewCellStyle3;
            this.ResultDataSheet.Location = new System.Drawing.Point(521, 11);
            this.ResultDataSheet.Margin = new System.Windows.Forms.Padding(37, 11, 0, 0);
            this.ResultDataSheet.MultiSelect = false;
            this.ResultDataSheet.Name = "ResultDataSheet";
            this.ResultDataSheet.ReadOnly = true;
            this.ResultDataSheet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultDataSheet.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ResultDataSheet.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultDataSheet.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ResultDataSheet.RowTemplate.Height = 40;
            this.ResultDataSheet.RowTemplate.ReadOnly = true;
            this.ResultDataSheet.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultDataSheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResultDataSheet.ShowEditingIcon = false;
            this.ResultDataSheet.Size = new System.Drawing.Size(425, 212);
            this.ResultDataSheet.StandardTab = true;
            this.ResultDataSheet.TabIndex = 17;
            this.ResultDataSheet.TabStop = false;
            // 
            // BookID
            // 
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Width = 285;
            // 
            // BookState
            // 
            this.BookState.HeaderText = "BookState";
            this.BookState.Name = "BookState";
            this.BookState.ReadOnly = true;
            this.BookState.Width = 120;
            // 
            // BookInfoTextbox
            // 
            this.BookInfoTextbox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.BookInfoTextbox, 2);
            this.BookInfoTextbox.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.BookInfoTextbox.Location = new System.Drawing.Point(64, 282);
            this.BookInfoTextbox.Margin = new System.Windows.Forms.Padding(64, 16, 0, 0);
            this.BookInfoTextbox.Name = "BookInfoTextbox";
            this.BookInfoTextbox.Size = new System.Drawing.Size(50, 20);
            this.BookInfoTextbox.TabIndex = 33;
            this.BookInfoTextbox.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.BookNameLabel);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.LoadGIFBox);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(992, 697);
            this.flowLayoutPanel1.TabIndex = 35;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BookPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BookInfoTextbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ResultDataSheet, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 126);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(971, 372);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.BookOrderButton);
            this.panel2.Controls.Add(this.BookBorrowButton);
            this.panel2.Controls.Add(this.NoUseButton);
            this.panel2.Location = new System.Drawing.Point(487, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 100);
            this.panel2.TabIndex = 18;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Controls.Add(this.panel5);
            this.flowLayoutPanel2.Controls.Add(this.panel6);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(245, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(211, 260);
            this.flowLayoutPanel2.TabIndex = 34;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.authorLabel);
            this.panel1.Controls.Add(this.AuthorText);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 60);
            this.panel1.TabIndex = 45;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.BackColor = System.Drawing.Color.Transparent;
            this.authorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.authorLabel.Location = new System.Drawing.Point(3, 0);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(65, 20);
            this.authorLabel.TabIndex = 33;
            this.authorLabel.Text = "作　者：";
            // 
            // AuthorText
            // 
            this.AuthorText.AutoSize = true;
            this.AuthorText.BackColor = System.Drawing.Color.Transparent;
            this.AuthorText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorText.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.AuthorText.Location = new System.Drawing.Point(65, 0);
            this.AuthorText.MaximumSize = new System.Drawing.Size(140, 0);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.Size = new System.Drawing.Size(135, 60);
            this.AuthorText.TabIndex = 36;
            this.AuthorText.Text = "测试作者测试作者测试作者测试作者测试作者测试作者";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.PublisherLabel);
            this.panel3.Controls.Add(this.PublisherText);
            this.panel3.Location = new System.Drawing.Point(8, 76);
            this.panel3.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.panel3.MaximumSize = new System.Drawing.Size(220, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 20);
            this.panel3.TabIndex = 46;
            // 
            // PublisherLabel
            // 
            this.PublisherLabel.AutoSize = true;
            this.PublisherLabel.BackColor = System.Drawing.Color.Transparent;
            this.PublisherLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PublisherLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.PublisherLabel.Location = new System.Drawing.Point(3, 0);
            this.PublisherLabel.Name = "PublisherLabel";
            this.PublisherLabel.Size = new System.Drawing.Size(65, 20);
            this.PublisherLabel.TabIndex = 34;
            this.PublisherLabel.Text = "出版社：";
            // 
            // PublisherText
            // 
            this.PublisherText.AutoSize = true;
            this.PublisherText.BackColor = System.Drawing.Color.Transparent;
            this.PublisherText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PublisherText.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.PublisherText.Location = new System.Drawing.Point(65, 0);
            this.PublisherText.MaximumSize = new System.Drawing.Size(140, 0);
            this.PublisherText.Name = "PublisherText";
            this.PublisherText.Size = new System.Drawing.Size(79, 20);
            this.PublisherText.TabIndex = 38;
            this.PublisherText.Text = "测试出版社";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.BookIDLabel);
            this.panel4.Controls.Add(this.BookIDText);
            this.panel4.Location = new System.Drawing.Point(8, 104);
            this.panel4.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.panel4.MaximumSize = new System.Drawing.Size(220, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(138, 20);
            this.panel4.TabIndex = 47;
            // 
            // BookIDLabel
            // 
            this.BookIDLabel.AutoSize = true;
            this.BookIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.BookIDLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookIDLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.BookIDLabel.Location = new System.Drawing.Point(3, 0);
            this.BookIDLabel.Name = "BookIDLabel";
            this.BookIDLabel.Size = new System.Drawing.Size(65, 20);
            this.BookIDLabel.TabIndex = 35;
            this.BookIDLabel.Text = "书　号：";
            // 
            // BookIDText
            // 
            this.BookIDText.AutoSize = true;
            this.BookIDText.BackColor = System.Drawing.Color.Transparent;
            this.BookIDText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookIDText.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.BookIDText.Location = new System.Drawing.Point(65, 0);
            this.BookIDText.Margin = new System.Windows.Forms.Padding(0);
            this.BookIDText.MaximumSize = new System.Drawing.Size(140, 0);
            this.BookIDText.Name = "BookIDText";
            this.BookIDText.Size = new System.Drawing.Size(73, 20);
            this.BookIDText.TabIndex = 37;
            this.BookIDText.Text = "12345678";
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.AmountLabel);
            this.panel5.Controls.Add(this.AmountText);
            this.panel5.Location = new System.Drawing.Point(8, 132);
            this.panel5.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.panel5.MaximumSize = new System.Drawing.Size(220, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(93, 20);
            this.panel5.TabIndex = 48;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.AmountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AmountLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.AmountLabel.Location = new System.Drawing.Point(3, 0);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(65, 20);
            this.AmountLabel.TabIndex = 39;
            this.AmountLabel.Text = "总　数：";
            // 
            // AmountText
            // 
            this.AmountText.AutoSize = true;
            this.AmountText.BackColor = System.Drawing.Color.Transparent;
            this.AmountText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AmountText.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.AmountText.Location = new System.Drawing.Point(65, 0);
            this.AmountText.MaximumSize = new System.Drawing.Size(140, 0);
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(25, 20);
            this.AmountText.TabIndex = 41;
            this.AmountText.Text = "12";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.LabelLabel);
            this.panel6.Controls.Add(this.Label3Text);
            this.panel6.Controls.Add(this.Label1Text);
            this.panel6.Controls.Add(this.Label2Text);
            this.panel6.Location = new System.Drawing.Point(8, 160);
            this.panel6.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 49;
            // 
            // LabelLabel
            // 
            this.LabelLabel.AutoSize = true;
            this.LabelLabel.BackColor = System.Drawing.Color.Transparent;
            this.LabelLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.LabelLabel.Location = new System.Drawing.Point(3, 0);
            this.LabelLabel.Name = "LabelLabel";
            this.LabelLabel.Size = new System.Drawing.Size(65, 20);
            this.LabelLabel.TabIndex = 40;
            this.LabelLabel.Text = "标　签：";
            // 
            // Label3Text
            // 
            this.Label3Text.AutoSize = true;
            this.Label3Text.BackColor = System.Drawing.Color.Transparent;
            this.Label3Text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label3Text.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Label3Text.Location = new System.Drawing.Point(65, 40);
            this.Label3Text.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.Label3Text.MaximumSize = new System.Drawing.Size(140, 0);
            this.Label3Text.Name = "Label3Text";
            this.Label3Text.Size = new System.Drawing.Size(93, 20);
            this.Label3Text.TabIndex = 44;
            this.Label3Text.Text = "中国古典文学";
            // 
            // Label1Text
            // 
            this.Label1Text.AutoSize = true;
            this.Label1Text.BackColor = System.Drawing.Color.Transparent;
            this.Label1Text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label1Text.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Label1Text.Location = new System.Drawing.Point(65, 0);
            this.Label1Text.MaximumSize = new System.Drawing.Size(140, 0);
            this.Label1Text.Name = "Label1Text";
            this.Label1Text.Size = new System.Drawing.Size(47, 20);
            this.Label1Text.TabIndex = 42;
            this.Label1Text.Text = "文学>";
            // 
            // Label2Text
            // 
            this.Label2Text.AutoSize = true;
            this.Label2Text.BackColor = System.Drawing.Color.Transparent;
            this.Label2Text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label2Text.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Label2Text.Location = new System.Drawing.Point(65, 20);
            this.Label2Text.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.Label2Text.MaximumSize = new System.Drawing.Size(140, 0);
            this.Label2Text.Name = "Label2Text";
            this.Label2Text.Size = new System.Drawing.Size(75, 20);
            this.Label2Text.TabIndex = 43;
            this.Label2Text.Text = "中国文学>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 22F);
            this.label2.Location = new System.Drawing.Point(50, 530);
            this.label2.Margin = new System.Windows.Forms.Padding(48, 32, 3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "评论：";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.CommentSubmitBtn);
            this.panel7.Controls.Add(this.NextPageButton);
            this.panel7.Controls.Add(this.LastPageButton);
            this.panel7.Controls.Add(this.commentTextBox);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(2, 641);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(969, 306);
            this.panel7.TabIndex = 39;
            // 
            // CommentSubmitBtn
            // 
            this.CommentSubmitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.CommentSubmitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.CommentSubmitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(126)))), ((int)(((byte)(110)))));
            this.CommentSubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommentSubmitBtn.Font = new System.Drawing.Font("黑体", 10F);
            this.CommentSubmitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.CommentSubmitBtn.Location = new System.Drawing.Point(812, 247);
            this.CommentSubmitBtn.Name = "CommentSubmitBtn";
            this.CommentSubmitBtn.Size = new System.Drawing.Size(96, 30);
            this.CommentSubmitBtn.TabIndex = 46;
            this.CommentSubmitBtn.TabStop = false;
            this.CommentSubmitBtn.Text = "发表评论";
            this.CommentSubmitBtn.UseVisualStyleBackColor = false;
            this.CommentSubmitBtn.Click += new System.EventHandler(this.CommentSubmitBtn_Click);
            // 
            // NextPageButton
            // 
            this.NextPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.NextPageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.NextPageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(126)))), ((int)(((byte)(110)))));
            this.NextPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPageButton.ForeColor = System.Drawing.SystemColors.Control;
            this.NextPageButton.Location = new System.Drawing.Point(858, 15);
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.Size = new System.Drawing.Size(50, 30);
            this.NextPageButton.TabIndex = 45;
            this.NextPageButton.TabStop = false;
            this.NextPageButton.Text = "下页";
            this.NextPageButton.UseVisualStyleBackColor = false;
            this.NextPageButton.Click += new System.EventHandler(this.NextPageButton_Click);
            // 
            // LastPageButton
            // 
            this.LastPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.LastPageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(148)))), ((int)(((byte)(129)))));
            this.LastPageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(126)))), ((int)(((byte)(110)))));
            this.LastPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastPageButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LastPageButton.Location = new System.Drawing.Point(789, 15);
            this.LastPageButton.Name = "LastPageButton";
            this.LastPageButton.Size = new System.Drawing.Size(50, 30);
            this.LastPageButton.TabIndex = 44;
            this.LastPageButton.TabStop = false;
            this.LastPageButton.Text = "上页";
            this.LastPageButton.UseVisualStyleBackColor = false;
            this.LastPageButton.Click += new System.EventHandler(this.LastPageButton_Click);
            // 
            // commentTextBox
            // 
            this.commentTextBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.commentTextBox.Location = new System.Drawing.Point(68, 98);
            this.commentTextBox.MaxLength = 200;
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(840, 137);
            this.commentTextBox.TabIndex = 39;
            this.commentTextBox.TabStop = false;
            this.commentTextBox.Text = "我是评论输入区域\r\n有啥想说的么\r\n没有\r\n再见\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.label3.Location = new System.Drawing.Point(63, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(64, 16, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 30);
            this.label3.TabIndex = 42;
            this.label3.Text = "添加评论：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(7, 704);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = "label1";
            // 
            // BookImageRequest
            // 
            this.BookImageRequest.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BookImageRequest_DoWork);
            this.BookImageRequest.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BookImageRequest_RunWorkerCompleted);
            // 
            // BookCommentRequest
            // 
            this.BookCommentRequest.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BookCommentRequest_DoWork);
            this.BookCommentRequest.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BookCommentRequest_RunWorkerCompleted);
            // 
            // WaitingThread
            // 
            this.WaitingThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WaitingThread_DoWork);
            this.WaitingThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WaitingThread_RunWorkerCompleted);
            // 
            // BookListRequest
            // 
            this.BookListRequest.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BookListRequest_DoWork);
            this.BookListRequest.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BookListRequest_RunWorkerCompleted);
            // 
            // BookListRequestWaiting
            // 
            this.BookListRequestWaiting.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BookListRequestWaiting_DoWork);
            this.BookListRequestWaiting.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BookListRequestWaiting_RunWorkerCompleted);
            // 
            // BookPictureBox
            // 
            this.BookPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BookPictureBox.BackgroundImage = global::LIBRARY.Properties.Resources.BookNullImage;
            this.BookPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BookPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookPictureBox.Location = new System.Drawing.Point(64, 11);
            this.BookPictureBox.Margin = new System.Windows.Forms.Padding(64, 11, 3, 3);
            this.BookPictureBox.Name = "BookPictureBox";
            this.BookPictureBox.Size = new System.Drawing.Size(170, 240);
            this.BookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookPictureBox.TabIndex = 1;
            this.BookPictureBox.TabStop = false;
            // 
            // BookOrderButton
            // 
            this.BookOrderButton.BackColor = System.Drawing.Color.Transparent;
            this.BookOrderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BookOrderButton.BackgroundImage")));
            this.BookOrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BookOrderButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("BookOrderButton.DM_DownImage")));
            this.BookOrderButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("BookOrderButton.DM_HoverImage")));
            this.BookOrderButton.DM_Mode = false;
            this.BookOrderButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("BookOrderButton.DM_NolImage")));
            this.BookOrderButton.Location = new System.Drawing.Point(196, 3);
            this.BookOrderButton.Name = "BookOrderButton";
            this.BookOrderButton.Size = new System.Drawing.Size(96, 96);
            this.BookOrderButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.BookOrderButton.TabIndex = 16;
            this.BookOrderButton.TabStop = false;
            this.BookOrderButton.Click += new System.EventHandler(this.BookOrderButton_Click);
            this.BookOrderButton.MouseLeave += new System.EventHandler(this.BookOrderButton_MouseLeave);
            this.BookOrderButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BookOrderButton_MouseMove);
            // 
            // BookBorrowButton
            // 
            this.BookBorrowButton.BackColor = System.Drawing.Color.Transparent;
            this.BookBorrowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BookBorrowButton.BackgroundImage")));
            this.BookBorrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BookBorrowButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("BookBorrowButton.DM_DownImage")));
            this.BookBorrowButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("BookBorrowButton.DM_HoverImage")));
            this.BookBorrowButton.DM_Mode = false;
            this.BookBorrowButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("BookBorrowButton.DM_NolImage")));
            this.BookBorrowButton.Location = new System.Drawing.Point(196, 3);
            this.BookBorrowButton.Name = "BookBorrowButton";
            this.BookBorrowButton.Size = new System.Drawing.Size(96, 96);
            this.BookBorrowButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.BookBorrowButton.TabIndex = 15;
            this.BookBorrowButton.TabStop = false;
            this.BookBorrowButton.Click += new System.EventHandler(this.BookBorrowButton_Click);
            this.BookBorrowButton.MouseLeave += new System.EventHandler(this.BookBorrowButton_MouseLeave);
            this.BookBorrowButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BookBorrowButton_MouseMove);
            // 
            // NoUseButton
            // 
            this.NoUseButton.BackColor = System.Drawing.Color.Transparent;
            this.NoUseButton.BackgroundImage = global::LIBRARY.Properties.Resources.不可预约;
            this.NoUseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NoUseButton.DM_DownImage = global::LIBRARY.Properties.Resources.不可预约;
            this.NoUseButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("NoUseButton.DM_HoverImage")));
            this.NoUseButton.DM_Mode = false;
            this.NoUseButton.DM_NolImage = global::LIBRARY.Properties.Resources.不可预约;
            this.NoUseButton.Location = new System.Drawing.Point(196, 4);
            this.NoUseButton.Name = "NoUseButton";
            this.NoUseButton.Size = new System.Drawing.Size(96, 96);
            this.NoUseButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.NoUseButton.TabIndex = 23;
            this.NoUseButton.Visible = false;
            this.NoUseButton.Click += new System.EventHandler(this.NoUseButton_Click);
            // 
            // LoadGIFBox
            // 
            this.LoadGIFBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadGIFBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.LoadGIFBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoadGIFBox.Image = ((System.Drawing.Image)(resources.GetObject("LoadGIFBox.Image")));
            this.LoadGIFBox.Location = new System.Drawing.Point(5, 588);
            this.LoadGIFBox.Name = "LoadGIFBox";
            this.LoadGIFBox.Size = new System.Drawing.Size(965, 50);
            this.LoadGIFBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadGIFBox.TabIndex = 40;
            this.LoadGIFBox.TabStop = false;
            this.LoadGIFBox.Visible = false;
            // 
            // UserBookDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1000, 705);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DM_CanMove = false;
            this.DM_CanResize = false;
            this.DM_howBorder = false;
            this.DM_Mobile = DMSkin.MobileStyle.None;
            this.DM_Shadow = false;
            this.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserBookDetailForm";
            this.Text = "BookDetailForm";
            this.Load += new System.EventHandler(this.BookDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataSheet)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadGIFBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.PictureBox BookPictureBox;
        private DMSkin.Controls.DM.DMButtonImage BookBorrowButton;
        private DMSkin.Controls.DM.DMButtonImage BookOrderButton;
        public System.Windows.Forms.DataGridView ResultDataSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookState;
        private DMSkin.Controls.DM.DMButtonImage NoUseButton;
        private System.Windows.Forms.Label BookInfoTextbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label AuthorText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label PublisherLabel;
        private System.Windows.Forms.Label PublisherText;
        private System.Windows.Forms.Label Label3Text;
        private System.Windows.Forms.Label BookIDLabel;
        private System.Windows.Forms.Label Label2Text;
        private System.Windows.Forms.Label Label1Text;
        private System.Windows.Forms.Label BookIDText;
        private System.Windows.Forms.Label AmountText;
        private System.Windows.Forms.Label LabelLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CommentSubmitBtn;
        private System.Windows.Forms.Button NextPageButton;
        private System.Windows.Forms.Button LastPageButton;
        private System.ComponentModel.BackgroundWorker BookImageRequest;
        private System.ComponentModel.BackgroundWorker BookCommentRequest;
        private System.Windows.Forms.PictureBox LoadGIFBox;
        private System.ComponentModel.BackgroundWorker WaitingThread;
        private System.ComponentModel.BackgroundWorker BookListRequest;
        private System.ComponentModel.BackgroundWorker BookListRequestWaiting;
    }
}