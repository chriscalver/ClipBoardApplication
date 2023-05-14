using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Module = System.Windows.Forms;


namespace ClipBoardApplication
{


    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            // opener = parentForm;


            var menu = new Module.ContextMenuStrip();

            {
                var submenu = new Module.ToolStripMenuItem();

                submenu.Text = "Sub-menu 1";

                var item = new Module.ToolStripMenuItem();

                item.Text = "Sub-item 1";
                item.MouseUp += (object sender, MouseEventArgs e) =>
                {
                    // Todo
                };
                submenu.DropDownItems.Add(item);

                item = new Module.ToolStripMenuItem();
                item.Text = "Sub-item 2";
                submenu.DropDownItems.Add(item);

                menu.Items.Add(submenu);
            }

            pictureBox1.ContextMenuStrip = menu;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.Location = new Point(
            (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2) + 600,
            (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2) - 250);


            label1.Text = Form1.passer;


            SqlConnection connect = new SqlConnection(Form1.connection2);
            SqlCommand command = new SqlCommand("SELECT ClipBoardImage FROM Table_4 WHERE ID='" + Form1.passer + "'", connect);

            SqlDataAdapter dp = new(command);
            DataSet ds = new("MyImages");

            byte[] MyData = new byte[0];

            dp.Fill(ds, "MyImages");
            DataRow myRow;
            myRow = ds.Tables["MyImages"].Rows[0];

            MyData = (byte[])myRow["ClipBoardImage"];

            MemoryStream stream = new(MyData);
            //pictureBox1.Visible = true;
            //pictureBox1.BringToFront();

            pictureBox1.Image = Image.FromStream(stream);
        }
    }
}
