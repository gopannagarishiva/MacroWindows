using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            send_page_id.Hide();
            scan_page_id.Hide();
            recieve_page_id.Hide();
            settings_page_id.Hide();
            home_page_id.Show();
            home_page_id.BringToFront();
        }

        private void home_button_click(object sender, EventArgs e)
        {
            // navigating home page
            send_page_id.Hide();
            scan_page_id.Hide();
            recieve_page_id.Hide();
            settings_page_id.Hide();
            home_page_id.Show();
            home_page_id.BringToFront();

            //slide panel on send
            slide_panel_id.Left = home_button_id.Left;
            slide_panel_id.Width = home_button_id.Width;
        }

        private void send_button_click(object sender, EventArgs e)
        {
            // navigating send page
            home_page_id.Hide();
            scan_page_id.Hide();
            recieve_page_id.Hide();
            settings_page_id.Hide();
            send_page_id.Show();
            send_page_id.BringToFront();

            //slide panel on send
            slide_panel_id.Left = send_button_id.Left;
            slide_panel_id.Width = send_button_id.Width;
        }

        private void scan_button_click(object sender, EventArgs e)
        {
            // navigating scan page
            home_page_id.Hide();
            send_page_id.Hide();
            recieve_page_id.Hide();
            settings_page_id.Hide();
            scan_page_id.Show();
            scan_page_id.BringToFront();

            //slide panel on scan
            slide_panel_id.Left = scan_button_id.Left;
            slide_panel_id.Width = scan_button_id.Width;
        }

        private void recieve_button_click(object sender, EventArgs e)
        {
            // navigating recieve page
            home_page_id.Hide();
            scan_page_id.Hide();
            send_page_id.Hide();
            settings_page_id.Hide();
            recieve_page_id.Show();
            recieve_page_id.BringToFront();

            //slide panel on recieve
            slide_panel_id.Left = recieve_button_id.Left;
            slide_panel_id.Width = recieve_button_id.Width;
        }

        private void settings_button_click(object sender, EventArgs e)
        {
            // navigating settings page
            home_page_id.Hide();
            scan_page_id.Hide();
            recieve_page_id.Hide();
            send_page_id.Hide();
            settings_page_id.Show();
            settings_page_id.BringToFront();

            //slide panel on serrings
            slide_panel_id.Left = settings_button_id.Left;
            slide_panel_id.Width = settings_button_id.Width;
        }

        private void Macro_Click(object sender, EventArgs e)
        {

        }
    }
}
