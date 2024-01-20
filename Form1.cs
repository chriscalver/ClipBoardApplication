using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace ClipBoardApplication
{

    public partial class Form1 : Form
    {
        public static string favText = "chriscalver@hotmail.com";
        public static string passer = "";
        public static string deviceName = Environment.MachineName;
        string currentformsize = "";
        public static string connection2 = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;

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
            label5.Hide();
            label4.Text = deviceName;
            currentformsize = "small";
            dgvImage.Visible = true;
            this.Size = new Size(460, 188);
            this.TopMost = true;
            this.Location = new Point(
            (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
            (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2) - 200);




            //GRABS ROWS THAT CONTAIN iMAGES From table4
            //PUTS THE id'S into an array

            //using (SqlConnection sqlCon = new SqlConnection(connection2))  // SELECT ID, Device, ClipBoardImage FROM Table_4 WHERE ID IN (2, 118, 145, 202, 234, 248, 255, 291, 296)
            //{

            //    var valuesList = new ArrayList(); // recommended 
            //    sqlCon.Open();
            //    SqlCommand command = new SqlCommand("SELECT ID FROM Table_4", sqlCon);
            //    SqlDataReader dataReader = command.ExecuteReader();
            //    while (dataReader.Read())
            //    {
            //        valuesList.Add(Convert.ToInt32(dataReader[0].ToString()));
            //    }
            //    //label4.Text = valuesList[4].ToString();                
            //}
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
                    text = text.Replace("\r", string.Empty);
                    text = text.Replace("\n", string.Empty);

                    if (text == favText)
                    {

                    }
                    else
                    {
                        //label4.Text = "The above text has been saved";
                        richTextBox1.BringToFront();
                        richTextBox1.Visible = true;
                        richTextBox1.Text = text;


                        if (string.IsNullOrWhiteSpace(text))
                        {
                            //label5.Text = "empty";

                            timer1.Enabled = true;
                            timer1.Start();
                            label5.Text = text + " " + "Has been added";
                            timer1.Tick += new EventHandler(timer1_Tick);
                            // True.
                            //Console.WriteLine("Null or empty");
                        }
                        else
                        {
                            //label5.Text = "not empty";
                            try
                            {
                                String connectionString = connection2;
                                using (SqlConnection connection = new(connectionString))
                                {
                                    connection.Open();
                                    String sql = "INSERT INTO Table_5 (Device, ClipBoardText) VALUES (@deviceName, @text)";

                                    using (SqlCommand command = new(sql, connection))
                                    {
                                        command.Parameters.AddWithValue("@text", text);
                                        command.Parameters.AddWithValue("@deviceName", deviceName);
                                        command.ExecuteNonQuery();
                                        label5.Text = "Latest Text";
                                        richTextBox1.BringToFront();

                                        timer1.Enabled = true;
                                        timer1.Start();
                                        label5.Text = text + " " + "Has been added";
                                        timer1.Tick += new EventHandler(timer1_Tick);

                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                label5.Text = ex.Message;
                                return;
                            }

                            //Console.WriteLine("Not null and not empty");
                        }

                    }
                }
                else if (iData.GetDataPresent(DataFormats.Bitmap))
                {
                    //label4.Text = "The above image has been saved";
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
                            String sql = "INSERT INTO Table_4 (Device, ClipBoardImage) VALUES (@deviceName, @bmimage)";
                            //label4.Text = "";
                            using (SqlCommand command = new(sql, connection))
                            {
                                MemoryStream stream = new();
                                image.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                                byte[] pic = stream.ToArray();
                                command.Parameters.AddWithValue("@bmimage", pic);
                                command.Parameters.AddWithValue("@deviceName", deviceName);
                                command.ExecuteNonQuery();

                                label5.Text = "Image has been added";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        label5.Text = ex.Message;
                        return;
                    }
                }
            }
            else
            {
                timer1.Enabled = true;
                timer1.Start();
                //label5.Text = " " + "Has been added";
                timer1.Tick += new EventHandler(timer1_Tick);
            }




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = "Favorite text loaded into Clipboard";
            System.Windows.Forms.Clipboard.SetText(favText);
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
            pictureBox1.BringToFront();
            pictureBox1.Image = System.Drawing.Image.FromStream(stream);
            label5.Text = "Current Favourite Image";
        }








        //Pulls up Tetxt Data 
        //Displays in DataGridView

        private void button2_Click(object sender, EventArgs e)
        {
            dgvText.BringToFront();
            using (SqlConnection sqlCon = new SqlConnection(connection2))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID, Device, ClipBoardText FROM Table_5 ORDER BY ID DESC;", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvText.DataSource = dtbl;
                label5.Text = "Clipboard Text History";
            }
        }









        //Pulls up dIamage Data
        //Displays in DataGridView

        private void button3_Click(object sender, EventArgs e)
        {
            dgvImage.BringToFront();
            dgvImage.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvImage.RowHeadersVisible = false;
            using (SqlConnection sqlCon = new SqlConnection(connection2))  // SELECT ID, Device, ClipBoardImage FROM Table_4 WHERE ID IN (2, 118, 145, 202, 234, 248, 255, 291, 296)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID, Device, ClipBoardImage FROM Table_4  ORDER BY ID DESC", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvImage.DataSource = dtbl;
            }
            dgvImage.Columns[0].Width = 40;
            dgvImage.Columns[1].Width = 80;
            dgvImage.Columns[2].Width = 500;
            dgvImage.Visible = true;

            label5.Text = "Clipboard Image History";
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
                    label5.Text = "Litterbox Cleaned";
                }
            }
            catch (Exception ex)
            {
                label5.Text = ex.Message;
                return;
            }
        }


        //Favorite Text 

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(favText);
            richTextBox1.BringToFront();
            label5.Text = "Current Favourite Text";
            richTextBox1.Text = favText;

            //label5.Text = "Current Favourite Text is set to" + " " + favText;
        }


        // Below is code for mimizing to the system tray
        // 

        private void Form1_SizeChanged(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipText = "KlipBoard Kitty is monitoring your Clipboard";
                notifyIcon1.ShowBalloonTip(1000);
            }
        }
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
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
                this.Size = new Size(705, 655);
                this.Location = new Point(
                (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
                (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2));
                label3.Location = new Point(605, -2);
                label3.Text = "[Less...]";
                currentformsize = "large";
                label5.Show();
            }
            else
            {
                this.Size = new Size(460, 188);
                this.Location = new Point(
                (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
                (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2) - 200);
                label3.Text = "[More...]";
                label3.Location = new Point(365, 1);
                currentformsize = "small";
                label5.Hide();


            }
        }

        private void dgvImage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvImage.Rows[e.RowIndex].Cells["ID"].FormattedValue);
            label4.Text = id.ToString();
            passer = id.ToString();
            Form2 frm2 = new Form2();
            frm2.Show();

        }
        private void label4_Click_1(object sender, EventArgs e)
        {
            //Clipboard.SetText("Bitch");
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                _clipboardViewerNext = SetClipboardViewer(this.Handle);
                checkBox1.Text = "Monitoring On";
            }
            else
            {
                ChangeClipboardChain(this.Handle, _clipboardViewerNext);
                checkBox1.Text = "Monitoring Off";
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
