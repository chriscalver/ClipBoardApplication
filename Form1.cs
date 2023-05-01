using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ClipBoardApplication
{

   // [DefaultEvent("ClipboardChanged")]




    public partial class Form1 : Form
    {


        // Private conn As MySqlConnection = New MySqlConnection("SERVER=my01.winhost.com; database=mysql_155712_chrisdb; uid=daddy; pwd=wayne999")



        public Form1()
        {
            InitializeComponent();
        }


        //ClipBoard clipboard;



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                pictureBox1.Image = Clipboard.GetImage();
            }

            if (Clipboard.ContainsText())
            {
                richTextBox1.Text = Clipboard.GetText();
            }

            if (Clipboard.ContainsAudio())
            {
                richTextBox1.Text = "Audio";

            }

            if (Clipboard.ContainsFileDropList())
            {
                richTextBox1.Text = "Audio";
            }            

        }

        private void button1_Click(object sender, EventArgs e)
        {     
            if (Clipboard.ContainsText())
            {
               // button1.Visible = false;
                label2.Text = "Here's your latest text:";
                label2.Visible = true;
                //this.Height = 290;

                //pictureBox1.Visible = false;

                richTextBox1.Visible = true;
                //richTextBox1.Text = texttest;
            }

            if (Clipboard.ContainsImage())
            {
                //button1.Visible = false;
                label2.Text = "Here's your latest image:";
                label2.Visible = true;
                //this.Height = 400;
                pictureBox1.Visible = true;               

            }
        }

        
    }
}
