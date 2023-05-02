using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ClipBoardApplication
{  
    public partial class Form1 : Form
    {
        // Private conn As MySqlConnection = New MySqlConnection("SERVER=my01.winhost.com; database=mysql_155712_chrisdb; uid=daddy; pwd=wayne999")

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

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);    // Process the message 

            if (m.Msg == WM_DRAWCLIPBOARD)
            {
                IDataObject iData = Clipboard.GetDataObject();      // Clipboard's data

                if (iData.GetDataPresent(DataFormats.Text))
                {
                    string text = (string)iData.GetData(DataFormats.Text);     
                    pictureBox1.Visible = false;
                    richTextBox1.Visible = true;                    
                    richTextBox1.Text = text;


                    try
                    {

                        String connectionString = "Data Source=tcp:s26.winhost.com;Initial Catalog=DB_155712_2023db;User ID=DB_155712_2023db_user;Password=wayne8888;Integrated Security=False;";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            String sql = "INSERT INTO Table_4 (Device, ClipBoardText) VALUES ('Laptop', @text)";
                            label2.Text = "hi";
                            using (SqlCommand command = new SqlCommand(sql, connection))
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
                    richTextBox1.Visible = false;
                    Bitmap image = (Bitmap)iData.GetData(DataFormats.Bitmap);  
                    pictureBox1.Visible = true;
                    pictureBox1.Image = image;


                    try
                    {

                        String connectionString = "Data Source=tcp:s26.winhost.com;Initial Catalog=DB_155712_2023db;User ID=DB_155712_2023db_user;Password=wayne8888;Integrated Security=False;";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            String sql = "INSERT INTO Table_4 (Device, ClipBoardImage) VALUES ('Laptop', @bmimage)";
                            label2.Text = "hey";
                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                // image = (Bitmap)Clipboard.GetImage();

                                MemoryStream stream = new MemoryStream();
                                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                                byte[] pic = stream.ToArray();

                                

                                //byte[] imageData = File.ReadAllBytes(image);

                                command.Parameters.AddWithValue("@bmimage", pic);
                                command.ExecuteNonQuery();

                                //command.Parameters.AddWithValue("@image", image);
                                // command.Parameters.AddWithValue("@age", memberInfo.Age);
                                //command.ExecuteNonQuery();

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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChangeClipboardChain(this.Handle, _clipboardViewerNext);     
        }        

        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
