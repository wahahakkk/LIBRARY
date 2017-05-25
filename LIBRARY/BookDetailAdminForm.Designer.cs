﻿namespace LIBRARY
{
    partial class BookDetailAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDetailAdminForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.BookPictureBox = new System.Windows.Forms.PictureBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.BookIDLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.LabelLabel = new System.Windows.Forms.Label();
            this.BookInfoTextbox = new System.Windows.Forms.TextBox();
            this.BookImageButton = new DMSkin.Controls.DM.DMButtonImage();
            this.ResultDataSheet = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorText = new System.Windows.Forms.Label();
            this.BookIDText = new System.Windows.Forms.Label();
            this.PublisherText = new System.Windows.Forms.Label();
            this.AmountText = new System.Windows.Forms.Label();
            this.Label1Text = new System.Windows.Forms.Label();
            this.BookPreserveButton = new DMSkin.Controls.DM.DMButtonImage();
            this.BookInfoButton = new DMSkin.Controls.DM.DMButtonImage();
            this.Label2Text = new System.Windows.Forms.Label();
            this.Label3Text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.BookNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookNameLabel.Font = new System.Drawing.Font("微软雅黑", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookNameLabel.Location = new System.Drawing.Point(64, 35);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(245, 57);
            this.BookNameLabel.TabIndex = 0;
            this.BookNameLabel.Text = "人民的名义";
            // 
            // BookPictureBox
            // 
            this.BookPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BookPictureBox.BackgroundImage = global::LIBRARY.Properties.Resources.BookNullImage;
            this.BookPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BookPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookPictureBox.Location = new System.Drawing.Point(70, 141);
            this.BookPictureBox.Name = "BookPictureBox";
            this.BookPictureBox.Size = new System.Drawing.Size(170, 240);
            this.BookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookPictureBox.TabIndex = 1;
            this.BookPictureBox.TabStop = false;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.BackColor = System.Drawing.Color.Transparent;
            this.authorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.authorLabel.Location = new System.Drawing.Point(268, 141);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(92, 27);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "作　者：";
            // 
            // PublisherLabel
            // 
            this.PublisherLabel.AutoSize = true;
            this.PublisherLabel.BackColor = System.Drawing.Color.Transparent;
            this.PublisherLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PublisherLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PublisherLabel.Location = new System.Drawing.Point(268, 203);
            this.PublisherLabel.Name = "PublisherLabel";
            this.PublisherLabel.Size = new System.Drawing.Size(92, 27);
            this.PublisherLabel.TabIndex = 3;
            this.PublisherLabel.Text = "出版社：";
            // 
            // BookIDLabel
            // 
            this.BookIDLabel.AutoSize = true;
            this.BookIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.BookIDLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookIDLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookIDLabel.Location = new System.Drawing.Point(268, 172);
            this.BookIDLabel.Name = "BookIDLabel";
            this.BookIDLabel.Size = new System.Drawing.Size(92, 27);
            this.BookIDLabel.TabIndex = 4;
            this.BookIDLabel.Text = "书　号：";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.AmountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AmountLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AmountLabel.Location = new System.Drawing.Point(268, 234);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(92, 27);
            this.AmountLabel.TabIndex = 5;
            this.AmountLabel.Text = "总　数：";
            // 
            // LabelLabel
            // 
            this.LabelLabel.AutoSize = true;
            this.LabelLabel.BackColor = System.Drawing.Color.Transparent;
            this.LabelLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelLabel.Location = new System.Drawing.Point(268, 265);
            this.LabelLabel.Name = "LabelLabel";
            this.LabelLabel.Size = new System.Drawing.Size(92, 27);
            this.LabelLabel.TabIndex = 6;
            this.LabelLabel.Text = "标　签：";
            // 
            // BookInfoTextbox
            // 
            this.BookInfoTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BookInfoTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookInfoTextbox.CausesValidation = false;
            this.BookInfoTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BookInfoTextbox.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookInfoTextbox.HideSelection = false;
            this.BookInfoTextbox.Location = new System.Drawing.Point(76, 423);
            this.BookInfoTextbox.Multiline = true;
            this.BookInfoTextbox.Name = "BookInfoTextbox";
            this.BookInfoTextbox.ReadOnly = true;
            this.BookInfoTextbox.ShortcutsEnabled = false;
            this.BookInfoTextbox.Size = new System.Drawing.Size(397, 201);
            this.BookInfoTextbox.TabIndex = 3;
            this.BookInfoTextbox.TabStop = false;
            this.BookInfoTextbox.Text = "烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤" +
    "烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫烫汤烫汤……";
            // 
            // BookImageButton
            // 
            this.BookImageButton.BackColor = System.Drawing.Color.Transparent;
            this.BookImageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BookImageButton.BackgroundImage")));
            this.BookImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BookImageButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("BookImageButton.DM_DownImage")));
            this.BookImageButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("BookImageButton.DM_HoverImage")));
            this.BookImageButton.DM_Mode = false;
            this.BookImageButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("BookImageButton.DM_NolImage")));
            this.BookImageButton.Location = new System.Drawing.Point(543, 454);
            this.BookImageButton.Name = "BookImageButton";
            this.BookImageButton.Size = new System.Drawing.Size(96, 96);
            this.BookImageButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.BookImageButton.TabIndex = 16;
            this.BookImageButton.Click += new System.EventHandler(this.BookImageButton_Click);
            // 
            // ResultDataSheet
            // 
            this.ResultDataSheet.AllowUserToAddRows = false;
            this.ResultDataSheet.AllowUserToDeleteRows = false;
            this.ResultDataSheet.AllowUserToResizeColumns = false;
            this.ResultDataSheet.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.ResultDataSheet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.ResultDataSheet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ResultDataSheet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultDataSheet.CausesValidation = false;
            this.ResultDataSheet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultDataSheet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ResultDataSheet.ColumnHeadersHeight = 40;
            this.ResultDataSheet.ColumnHeadersVisible = false;
            this.ResultDataSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookState});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultDataSheet.DefaultCellStyle = dataGridViewCellStyle8;
            this.ResultDataSheet.Location = new System.Drawing.Point(525, 141);
            this.ResultDataSheet.MultiSelect = false;
            this.ResultDataSheet.Name = "ResultDataSheet";
            this.ResultDataSheet.ReadOnly = true;
            this.ResultDataSheet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultDataSheet.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.ResultDataSheet.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultDataSheet.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ResultDataSheet.RowTemplate.Height = 40;
            this.ResultDataSheet.RowTemplate.ReadOnly = true;
            this.ResultDataSheet.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultDataSheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResultDataSheet.ShowEditingIcon = false;
            this.ResultDataSheet.Size = new System.Drawing.Size(425, 204);
            this.ResultDataSheet.StandardTab = true;
            this.ResultDataSheet.TabIndex = 17;
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
            // AuthorText
            // 
            this.AuthorText.AutoSize = true;
            this.AuthorText.BackColor = System.Drawing.Color.Transparent;
            this.AuthorText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AuthorText.Location = new System.Drawing.Point(351, 141);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.Size = new System.Drawing.Size(92, 27);
            this.AuthorText.TabIndex = 18;
            this.AuthorText.Text = "测试作者";
            // 
            // BookIDText
            // 
            this.BookIDText.AutoSize = true;
            this.BookIDText.BackColor = System.Drawing.Color.Transparent;
            this.BookIDText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookIDText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookIDText.Location = new System.Drawing.Point(351, 172);
            this.BookIDText.Name = "BookIDText";
            this.BookIDText.Size = new System.Drawing.Size(108, 27);
            this.BookIDText.TabIndex = 19;
            this.BookIDText.Text = "12345678";
            // 
            // PublisherText
            // 
            this.PublisherText.AutoSize = true;
            this.PublisherText.BackColor = System.Drawing.Color.Transparent;
            this.PublisherText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PublisherText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PublisherText.Location = new System.Drawing.Point(351, 203);
            this.PublisherText.Name = "PublisherText";
            this.PublisherText.Size = new System.Drawing.Size(112, 27);
            this.PublisherText.TabIndex = 20;
            this.PublisherText.Text = "测试出版社";
            // 
            // AmountText
            // 
            this.AmountText.AutoSize = true;
            this.AmountText.BackColor = System.Drawing.Color.Transparent;
            this.AmountText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AmountText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AmountText.Location = new System.Drawing.Point(351, 234);
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(36, 27);
            this.AmountText.TabIndex = 21;
            this.AmountText.Text = "12";
            // 
            // Label1Text
            // 
            this.Label1Text.AutoSize = true;
            this.Label1Text.BackColor = System.Drawing.Color.Transparent;
            this.Label1Text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label1Text.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1Text.Location = new System.Drawing.Point(351, 265);
            this.Label1Text.Name = "Label1Text";
            this.Label1Text.Size = new System.Drawing.Size(67, 27);
            this.Label1Text.TabIndex = 22;
            this.Label1Text.Text = "文学>";
            // 
            // BookPreserveButton
            // 
            this.BookPreserveButton.BackColor = System.Drawing.Color.Transparent;
            this.BookPreserveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BookPreserveButton.BackgroundImage")));
            this.BookPreserveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BookPreserveButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("BookPreserveButton.DM_DownImage")));
            this.BookPreserveButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("BookPreserveButton.DM_HoverImage")));
            this.BookPreserveButton.DM_Mode = false;
            this.BookPreserveButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("BookPreserveButton.DM_NolImage")));
            this.BookPreserveButton.Location = new System.Drawing.Point(817, 454);
            this.BookPreserveButton.Name = "BookPreserveButton";
            this.BookPreserveButton.Size = new System.Drawing.Size(96, 96);
            this.BookPreserveButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.BookPreserveButton.TabIndex = 23;
            this.BookPreserveButton.Click += new System.EventHandler(this.BookPreserveButton_Click);
            // 
            // BookInfoButton
            // 
            this.BookInfoButton.BackColor = System.Drawing.Color.Transparent;
            this.BookInfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BookInfoButton.BackgroundImage")));
            this.BookInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BookInfoButton.DM_DownImage = ((System.Drawing.Image)(resources.GetObject("BookInfoButton.DM_DownImage")));
            this.BookInfoButton.DM_HoverImage = ((System.Drawing.Image)(resources.GetObject("BookInfoButton.DM_HoverImage")));
            this.BookInfoButton.DM_Mode = false;
            this.BookInfoButton.DM_NolImage = ((System.Drawing.Image)(resources.GetObject("BookInfoButton.DM_NolImage")));
            this.BookInfoButton.Location = new System.Drawing.Point(680, 454);
            this.BookInfoButton.Name = "BookInfoButton";
            this.BookInfoButton.Size = new System.Drawing.Size(96, 96);
            this.BookInfoButton.State = DMSkin.Controls.DM.DMButtonImage.BtnState.Nol;
            this.BookInfoButton.TabIndex = 24;
            this.BookInfoButton.Click += new System.EventHandler(this.BookInfoButton_Click);
            // 
            // Label2Text
            // 
            this.Label2Text.AutoSize = true;
            this.Label2Text.BackColor = System.Drawing.Color.Transparent;
            this.Label2Text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label2Text.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2Text.Location = new System.Drawing.Point(351, 296);
            this.Label2Text.Name = "Label2Text";
            this.Label2Text.Size = new System.Drawing.Size(107, 27);
            this.Label2Text.TabIndex = 25;
            this.Label2Text.Text = "中国文学>";
            // 
            // Label3Text
            // 
            this.Label3Text.AutoSize = true;
            this.Label3Text.BackColor = System.Drawing.Color.Transparent;
            this.Label3Text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label3Text.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3Text.Location = new System.Drawing.Point(351, 327);
            this.Label3Text.Name = "Label3Text";
            this.Label3Text.Size = new System.Drawing.Size(132, 27);
            this.Label3Text.TabIndex = 26;
            this.Label3Text.Text = "中国古典文学";
            // 
            // BookDetailAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 705);
            this.Controls.Add(this.Label3Text);
            this.Controls.Add(this.Label2Text);
            this.Controls.Add(this.BookInfoButton);
            this.Controls.Add(this.BookPreserveButton);
            this.Controls.Add(this.Label1Text);
            this.Controls.Add(this.AmountText);
            this.Controls.Add(this.PublisherText);
            this.Controls.Add(this.BookIDText);
            this.Controls.Add(this.AuthorText);
            this.Controls.Add(this.ResultDataSheet);
            this.Controls.Add(this.BookImageButton);
            this.Controls.Add(this.BookInfoTextbox);
            this.Controls.Add(this.LabelLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.BookIDLabel);
            this.Controls.Add(this.PublisherLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.BookPictureBox);
            this.Controls.Add(this.BookNameLabel);
            this.DM_CanMove = false;
            this.DM_CanResize = false;
            this.DM_howBorder = false;
            this.DM_Mobile = DMSkin.MobileStyle.None;
            this.DM_Shadow = false;
            this.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookDetailAdminForm";
            this.Text = "BookDetailForm";
            this.Load += new System.EventHandler(this.BookDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataSheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.PictureBox BookPictureBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label PublisherLabel;
        private System.Windows.Forms.Label BookIDLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label LabelLabel;
        private System.Windows.Forms.TextBox BookInfoTextbox;
        private DMSkin.Controls.DM.DMButtonImage BookImageButton;
        public System.Windows.Forms.DataGridView ResultDataSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookState;
        private System.Windows.Forms.Label AuthorText;
        private System.Windows.Forms.Label BookIDText;
        private System.Windows.Forms.Label PublisherText;
        private System.Windows.Forms.Label AmountText;
        private System.Windows.Forms.Label Label1Text;
        private DMSkin.Controls.DM.DMButtonImage BookPreserveButton;
        private DMSkin.Controls.DM.DMButtonImage BookInfoButton;
        private System.Windows.Forms.Label Label2Text;
        private System.Windows.Forms.Label Label3Text;
    }
}