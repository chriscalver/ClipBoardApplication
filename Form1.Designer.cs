
namespace ClipBoardApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            checkBox1 = new System.Windows.Forms.CheckBox();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            label3 = new System.Windows.Forms.Label();
            ViewSavedImage = new System.Windows.Forms.Button();
            ViewTextEntries = new System.Windows.Forms.Button();
            dgvText = new System.Windows.Forms.DataGridView();
            ViewImageEntries = new System.Windows.Forms.Button();
            dgvImage = new System.Windows.Forms.DataGridView();
            DeleteDuplicateRecords = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvImage).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pictureBox1.Location = new System.Drawing.Point(21, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(646, 374);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            richTextBox1.Location = new System.Drawing.Point(20, 151);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(646, 374);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(100, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(311, 54);
            label1.TabIndex = 2;
            label1.Text = "KlipBoard Kitty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(112, 75);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(231, 20);
            label2.TabIndex = 5;
            label2.Text = "Prrrfect Clipboard Management";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(21, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(88, 75);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Prrrrrrr";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseClick += notifyIcon1_MouseClick;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            checkBox1.Location = new System.Drawing.Point(30, 107);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(110, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Monitoring";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(394, -2);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(32, 31);
            label3.TabIndex = 9;
            label3.Text = "...";
            toolTip1.SetToolTip(label3, "Options");
            label3.Click += label3_Click;
            // 
            // ViewSavedImage
            // 
            ViewSavedImage.Location = new System.Drawing.Point(511, 560);
            ViewSavedImage.Name = "ViewSavedImage";
            ViewSavedImage.Size = new System.Drawing.Size(155, 29);
            ViewSavedImage.TabIndex = 10;
            ViewSavedImage.Text = "View Saved Pic";
            ViewSavedImage.UseVisualStyleBackColor = true;
            ViewSavedImage.Click += button1_Click;
            // 
            // ViewTextEntries
            // 
            ViewTextEntries.Location = new System.Drawing.Point(21, 560);
            ViewTextEntries.Name = "ViewTextEntries";
            ViewTextEntries.Size = new System.Drawing.Size(155, 29);
            ViewTextEntries.TabIndex = 11;
            ViewTextEntries.Text = "View Text Data";
            ViewTextEntries.UseVisualStyleBackColor = true;
            ViewTextEntries.Click += button2_Click;
            // 
            // dgvText
            // 
            dgvText.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvText.BackgroundColor = System.Drawing.Color.White;
            dgvText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvText.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvText.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvText.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvText.Location = new System.Drawing.Point(21, 151);
            dgvText.Name = "dgvText";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvText.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvText.RowHeadersWidth = 51;
            dgvText.RowTemplate.Height = 29;
            dgvText.Size = new System.Drawing.Size(646, 374);
            dgvText.TabIndex = 12;
            // 
            // ViewImageEntries
            // 
            ViewImageEntries.Location = new System.Drawing.Point(185, 560);
            ViewImageEntries.Name = "ViewImageEntries";
            ViewImageEntries.Size = new System.Drawing.Size(155, 29);
            ViewImageEntries.TabIndex = 13;
            ViewImageEntries.Text = "View Image Data";
            ViewImageEntries.UseVisualStyleBackColor = true;
            ViewImageEntries.Click += button3_Click;
            // 
            // dgvImage
            // 
            dgvImage.BackgroundColor = System.Drawing.Color.White;
            dgvImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvImage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dgvImage.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvImage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvImage.ColumnHeadersHeight = 29;
            dgvImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvImage.DefaultCellStyle = dataGridViewCellStyle4;
            dgvImage.Location = new System.Drawing.Point(21, 151);
            dgvImage.Name = "dgvImage";
            dgvImage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvImage.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvImage.RowHeadersWidth = 51;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvImage.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvImage.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dgvImage.RowTemplate.Height = 100;
            dgvImage.Size = new System.Drawing.Size(646, 374);
            dgvImage.TabIndex = 17;
            dgvImage.CellClick += dgvImage_CellClick;
            // 
            // DeleteDuplicateRecords
            // 
            DeleteDuplicateRecords.Location = new System.Drawing.Point(348, 560);
            DeleteDuplicateRecords.Name = "DeleteDuplicateRecords";
            DeleteDuplicateRecords.Size = new System.Drawing.Size(155, 29);
            DeleteDuplicateRecords.TabIndex = 15;
            DeleteDuplicateRecords.Text = "Delete Duplicates";
            DeleteDuplicateRecords.UseVisualStyleBackColor = true;
            DeleteDuplicateRecords.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(21, 528);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(82, 17);
            label4.TabIndex = 18;
            label4.Text = "Debug Label";
            label4.Click += label4_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(692, 604);
            Controls.Add(label4);
            Controls.Add(DeleteDuplicateRecords);
            Controls.Add(ViewImageEntries);
            Controls.Add(ViewTextEntries);
            Controls.Add(ViewSavedImage);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(dgvImage);
            Controls.Add(pictureBox1);
            Controls.Add(dgvText);
            ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Meow";
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvText).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ViewSavedImage;
        private System.Windows.Forms.Button ViewTextEntries;
        private System.Windows.Forms.DataGridView dgvText;
        private System.Windows.Forms.Button ViewImageEntries;
        private System.Windows.Forms.DataGridView dgvImage;
        private System.Windows.Forms.Button DeleteDuplicateRecords;
        private System.Windows.Forms.Label label4;
    }
}

