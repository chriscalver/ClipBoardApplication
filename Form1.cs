using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ClipBoardApplication
{
    public partial class Form1 : Form
    {

        string currentformsize = "";

        string connection2 = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;

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

            //connection2 = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
            //label4.Text = connection2;
            currentformsize = "small";
            dgvImage.Visible = true;

            this.Size = new Size(460, 200);


            this.Location = new Point(
            (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
            (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2));
            //label3.Location = new Point(404, -2);
            //currentformsize = "small";




            //GRABS ROWS THAT CONTAIN iMAGES From table4
            //PUTS THE id'S into an array

            using (SqlConnection sqlCon = new SqlConnection(connection2))  // SELECT ID, Device, ClipBoardImage FROM Table_4 WHERE ID IN (2, 118, 145, 202, 234, 248, 255, 291, 296)
            {

                var valuesList = new ArrayList(); // recommended 
                sqlCon.Open();

                SqlCommand command = new SqlCommand("SELECT ID FROM Table_4", sqlCon);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    valuesList.Add(Convert.ToInt32(dataReader[0].ToString()));
                }

                //label4.Text = valuesList[4].ToString();

            }

        }



        //This function monitors the clipboard for changesd
        //Divides Images and Texts and uploads to DB

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);    // Process the message 

            if (m.Msg == WM_DRAWCLIPBOARD)
            {
                IDataObject iData = Clipboard.GetDataObject();      // Clipboard's data

                if (iData.GetDataPresent(DataFormats.Text))
                {
                    string text = (string)iData.GetData(DataFormats.Text);
                    label4.Text = "The above text has been saved";
                    richTextBox1.BringToFront();
                    richTextBox1.Visible = true;
                    richTextBox1.Text = text;

                    try
                    {
                        String connectionString = connection2;
                        using (SqlConnection connection = new(connectionString))
                        {
                            connection.Open();
                            String sql = "INSERT INTO Table_5 (Device, ClipBoardText) VALUES ('Laptop', @text)";

                            using (SqlCommand command = new(sql, connection))
                            {
                                command.Parameters.AddWithValue("@text", text);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        label4.Text = ex.Message;
                        return;
                    }
                }
                else if (iData.GetDataPresent(DataFormats.Bitmap))
                {
                    label4.Text = "The above image has been saved";
                    pictureBox1.BringToFront();
                    Bitmap image = (Bitmap)iData.GetData(DataFormats.Bitmap);
                    pictureBox1.Visible = true;
                    pictureBox1.Image = image;
                    try
                    {
                        String connectionString = connection2;
                        using (SqlConnection connection = new(connectionString))
                        {
                            connection.Open();
                            String sql = "INSERT INTO Table_4 (Device, ClipBoardImage) VALUES ('Laptop', @bmimage)";
                            //label4.Text = "";
                            using (SqlCommand command = new(sql, connection))
                            {
                                MemoryStream stream = new();
                                image.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                                byte[] pic = stream.ToArray();
                                command.Parameters.AddWithValue("@bmimage", pic);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        label4.Text = ex.Message;
                        return;
                    }
                }
            }
        }




        //  Buttons Below


        //Views FAvorite Image
        //Displays in picturebox1

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connection2);
            SqlCommand command = new SqlCommand("SELECT ClipBoardImage FROM Table_4 WHERE ID=471", connect);

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


        //Pulls up Tetxt Data 
        //Displays in DataGridView


        private void button2_Click(object sender, EventArgs e)
        {
            dgvText.BringToFront();

            using (SqlConnection sqlCon = new SqlConnection(connection2))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID, Device, ClipBoardText FROM Table_5", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvText.DataSource = dtbl;
            }
        }




        //Pulls up dIamage Data
        //Displays in DataGridView

        private void button3_Click(object sender, EventArgs e)
        {
            dgvImage.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvImage.RowHeadersVisible = false;


            using (SqlConnection sqlCon = new SqlConnection(connection2))  // SELECT ID, Device, ClipBoardImage FROM Table_4 WHERE ID IN (2, 118, 145, 202, 234, 248, 255, 291, 296)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID, Device, ClipBoardImage FROM Table_4", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvImage.DataSource = dtbl;

            }

            //dgvImage.Columns[0].Width = 40;
            //dgvImage.Columns[1].Width = 80;
            dgvImage.Columns[2].Width = 380;
            //dgvImage.RowTemplate.Height = 500;
            dgvImage.Visible = true;
            dgvImage.BringToFront();
        }









        //Deletes duplicate record in DB


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                String connectionString = connection2;
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();
                    //String sql = "WITH cte AS ( SELECT CAST(ClipBoardText AS NVARCHAR(100)) ClipBoardText, ROW_NUMBER() OVER( PARTITION BY CAST(ClipBoardText AS NVARCHAR(100)), CAST(ClipBoardImage AS NVARCHAR(100)) ORDER BY CAST(ClipBoardText AS NVARCHAR(100))) row_num FROM Table_4) DELETE FROM cte WHERE row_num > 1;";
                    String sql = "WITH cte AS ( SELECT CAST(ClipBoardImage AS NVARCHAR(100)) ClipBoardImage, ROW_NUMBER() OVER( PARTITION BY CAST(ClipBoardImage AS NVARCHAR(100)), CAST(ClipBoardImage AS NVARCHAR(100)) ORDER BY CAST(ClipBoardImage AS NVARCHAR(100))) row_num FROM Table_4) DELETE FROM cte WHERE row_num > 1;";
                    String sql2 = "WITH cte AS ( SELECT CAST(ClipBoardText AS NVARCHAR(100)) ClipBoardText, ROW_NUMBER() OVER( PARTITION BY CAST(ClipBoardText AS NVARCHAR(100)), CAST(ClipBoardText AS NVARCHAR(100)) ORDER BY CAST(ClipBoardText AS NVARCHAR(100))) row_num FROM Table_5) DELETE FROM cte WHERE row_num > 1;";

                        
                    using (SqlCommand command = new(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new(sql2, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    label4.Text = "Duplicate Records Deleted";
                }
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
                return;
            }

        }



        //



        private void label4_Click(object sender, EventArgs e)
        {

        }

        // Below is code for mimizing to the system tray
        // 


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

        //Cleans up connection from monitoring clipboard

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChangeClipboardChain(this.Handle, _clipboardViewerNext);
        }




        //Shows or hides larger form


        private void label3_Click(object sender, EventArgs e)
        {

            if (currentformsize == "small")
            {
                this.Size = new Size(705, 730);

                this.Location = new Point(
                (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
                (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2));
                label3.Location = new Point(630, -2);
                currentformsize = "large";

            }
            else
            {

                this.Size = new Size(460, 200);
                this.Location = new Point(
                (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
                (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2));
                label3.Location = new Point(404, -2);
                currentformsize = "small";

            }

        }
    }


}
