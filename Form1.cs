using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ClipBoardApplication
{
    public partial class Form1 : Form
    {

        string connection = "Data Source=tcp:s26.winhost.com;Initial Catalog=DB_155712_2023db;User ID=DB_155712_2023db_user;Password=wayne8888;Integrated Security=False;";

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);
        private const int WM_DRAWCLIPBOARD = 0x0308;  // WM_DRAWCLIPBOARD message
        private IntPtr _clipboardViewerNext;     // Our variable that will hold the value to identify the next window in the clipboard viewer chain

        public Form1()
        {
            InitializeComponent();
            _clipboardViewerNext = SetClipboardViewer(this.Handle);  // Adds our form to the chain of clipboard viewers.
        }
        //ClipBoard clipboard;
        


        private void Form1_Load(object sender, EventArgs e)
        {
            
            //dgvImage.BringToFront();

            using (SqlConnection sqlCon = new SqlConnection(connection))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID, Device, ClipBoardImage FROM Table_4 WHERE ClipBoardImage IS NOT NULL", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvImage.DataSource = dtbl;
            }

        }








        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);    // Process the message 

            if (m.Msg == WM_DRAWCLIPBOARD)
            {
                IDataObject iData = Clipboard.GetDataObject();      // Clipboard's data

                if (iData.GetDataPresent(DataFormats.Text))
                {
                    string text = (string)iData.GetData(DataFormats.Text);
                    //pictureBox1.Visible = false;
                    richTextBox1.Visible = true;
                    richTextBox1.Text = text;

                    try
                    {
                        String connectionString = connection;
                        using (SqlConnection connection = new(connectionString))
                        {
                            connection.Open();
                            String sql = "INSERT INTO Table_4 (Device, ClipBoardText) VALUES ('Studio-PC', @text)";
                            //label2.Text = "hi";
                            using (SqlCommand command = new(sql, connection))
                            {
                                command.Parameters.AddWithValue("@text", text);
                                // command.Parameters.AddWithValue("@age", memberInfo.Age);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        label2.Text = ex.Message;
                        return;
                    }
                }
                else if (iData.GetDataPresent(DataFormats.Bitmap))
                {
                    //richTextBox1.Visible = false;
                    Bitmap image = (Bitmap)iData.GetData(DataFormats.Bitmap);
                    pictureBox1.Visible = true;
                    pictureBox1.Image = image;

                    try
                    {
                        String connectionString = connection;
                        using (SqlConnection connection = new(connectionString))
                        {
                            connection.Open();
                            String sql = "INSERT INTO Table_4 (Device, ClipBoardImage) VALUES ('Studio-PC', @bmimage)";
                            //label2.Text = "hey";
                            using (SqlCommand command = new(sql, connection))
                            {
                                MemoryStream stream = new();
                                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                                byte[] pic = stream.ToArray();
                                command.Parameters.AddWithValue("@bmimage", pic);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        label2.Text = ex.Message;
                        return;
                    }
                }
            }
        }

        //  Buttons Below


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connection);
            SqlCommand command = new SqlCommand("SELECT ClipBoardImage FROM Table_4 WHERE ID=7", connect);

            SqlDataAdapter dp = new(command);
            DataSet ds = new("MyImages");

            byte[] MyData = new byte[0];

            dp.Fill(ds, "MyImages");
            DataRow myRow;
            myRow = ds.Tables["MyImages"].Rows[0];

            MyData = (byte[])myRow["ClipBoardImage"];

            MemoryStream stream = new(MyData);
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromStream(stream);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvText.BringToFront();

            using (SqlConnection sqlCon = new SqlConnection(connection))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID, Device, ClipBoardText FROM Table_4 WHERE ClipBoardText IS NOT NULL", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvText.DataSource = dtbl;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvImage.Visible = true;
            dgvImage.BringToFront();

            //using (SqlConnection sqlCon = new SqlConnection(connection))
            //{
            //    sqlCon.Open();
            //    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID, Device, ClipBoardImage FROM Table_4 WHERE ClipBoardImage IS NOT NULL", sqlCon);
            //    DataTable dtbl = new DataTable();
            //    sqlDa.Fill(dtbl);
            //    dgvImage.DataSource = dtbl;
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                String connectionString = connection;
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();
                    String sql = "WITH cte AS ( SELECT CAST(ClipBoardText AS NVARCHAR(100)) ClipBoardText, ROW_NUMBER() OVER( PARTITION BY CAST(ClipBoardText AS NVARCHAR(100)), CAST(ClipBoardImage AS NVARCHAR(100)) ORDER BY CAST(ClipBoardText AS NVARCHAR(100))) row_num FROM Table_4) DELETE FROM cte WHERE row_num > 1;";
                    label4.Text = "Duplicate Records Deleted";
                    using (SqlCommand command = new(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
                return;
            }
        }


        // Below is code for mimizing to the system tray

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Boolean MousePointerNotOnTaskBar = Screen.GetWorkingArea(this).Contains(Cursor.Position);
            if (this.WindowState == FormWindowState.Minimized && MousePointerNotOnTaskBar)
            {
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "KlipBoard Kitty is monitoring your Clipboard";
                notifyIcon1.ShowBalloonTip(1000);
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            if (this.WindowState == FormWindowState.Normal)
            {
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChangeClipboardChain(this.Handle, _clipboardViewerNext);
        }

    }


}
