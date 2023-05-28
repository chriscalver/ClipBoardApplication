
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            button1 = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvImage).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pictureBox1.Location = new System.Drawing.Point(21, 155);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(646, 374);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            richTextBox1.Location = new System.Drawing.Point(20, 155);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(646, 374);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(100, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(311, 54);
            label1.TabIndex = 2;
            label1.Text = "KlipBoard Kitty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(112, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(231, 20);
            label2.TabIndex = 5;
            label2.Text = "Prrrfect Clipboard Management";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(21, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(88, 75);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipText = "Monitoring";
            notifyIcon1.BalloonTipTitle = "KlipBoardKitty";
            notifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Prrrrrrr";
            notifyIcon1.MouseClick += notifyIcon1_MouseClick;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            checkBox1.Location = new System.Drawing.Point(30, 103);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(134, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Monitoring On";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(365, 1);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 20);
            label3.TabIndex = 9;
            label3.Text = "[More...]";
            label3.Click += label3_Click;
            // 
            // ViewSavedImage
            // 
            ViewSavedImage.Location = new System.Drawing.Point(346, 564);
            ViewSavedImage.Name = "ViewSavedImage";
            ViewSavedImage.Size = new System.Drawing.Size(155, 29);
            ViewSavedImage.TabIndex = 10;
            ViewSavedImage.Text = "View Saved Pic";
            ViewSavedImage.UseVisualStyleBackColor = true;
            ViewSavedImage.Click += button1_Click;
            // 
            // ViewTextEntries
            // 
            ViewTextEntries.Location = new System.Drawing.Point(21, 564);
            ViewTextEntries.Name = "ViewTextEntries";
            ViewTextEntries.Size = new System.Drawing.Size(155, 29);
            ViewTextEntries.TabIndex = 11;
            ViewTextEntries.Text = "Text History";
            ViewTextEntries.UseVisualStyleBackColor = true;
            ViewTextEntries.Click += button2_Click;
            // 
            // dgvText
            // 
            dgvText.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvText.BackgroundColor = System.Drawing.Color.White;
            dgvText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvText.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvText.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvText.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvText.Location = new System.Drawing.Point(21, 155);
            dgvText.Name = "dgvText";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvText.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvText.RowHeadersWidth = 51;
            dgvText.RowTemplate.Height = 29;
            dgvText.Size = new System.Drawing.Size(646, 374);
            dgvText.TabIndex = 12;
            // 
            // ViewImageEntries
            // 
            ViewImageEntries.Location = new System.Drawing.Point(184, 564);
            ViewImageEntries.Name = "ViewImageEntries";
            ViewImageEntries.Size = new System.Drawing.Size(155, 29);
            ViewImageEntries.TabIndex = 13;
            ViewImageEntries.Text = "Image History";
            ViewImageEntries.UseVisualStyleBackColor = true;
            ViewImageEntries.Click += button3_Click;
            // 
            // dgvImage
            // 
            dgvImage.BackgroundColor = System.Drawing.Color.White;
            dgvImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvImage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dgvImage.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvImage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvImage.ColumnHeadersHeight = 29;
            dgvImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvImage.DefaultCellStyle = dataGridViewCellStyle10;
            dgvImage.Location = new System.Drawing.Point(21, 155);
            dgvImage.Name = "dgvImage";
            dgvImage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvImage.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvImage.RowHeadersWidth = 51;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvImage.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dgvImage.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dgvImage.RowTemplate.Height = 100;
            dgvImage.Size = new System.Drawing.Size(646, 374);
            dgvImage.TabIndex = 17;
            dgvImage.CellClick += dgvImage_CellClick;
            // 
            // DeleteDuplicateRecords
            // 
            DeleteDuplicateRecords.Location = new System.Drawing.Point(508, 100);
            DeleteDuplicateRecords.Name = "DeleteDuplicateRecords";
            DeleteDuplicateRecords.Size = new System.Drawing.Size(155, 29);
            DeleteDuplicateRecords.TabIndex = 15;
            DeleteDuplicateRecords.Text = "Clean Database";
            DeleteDuplicateRecords.UseVisualStyleBackColor = true;
            DeleteDuplicateRecords.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(21, 538);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(86, 17);
            label4.TabIndex = 18;
            label4.Text = "Debug Label";
            label4.Click += label4_Click_1;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(508, 564);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(155, 29);
            button1.TabIndex = 19;
            button1.Text = "View Saved Text";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(221, 106);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(0, 17);
            label5.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(692, 604);
            Controls.Add(label5);
            Controls.Add(button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Timer timer1;
    }
}

