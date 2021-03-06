/*
 *   This file is part of Serial-Comm-Tester source code.  All Rights Reserved.
 *
 *  Serial-Comm-Tetster is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2 of the License.
 *
 *  This software is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this software; if not, write to the Free Software
 *  Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307,
 *  USA.
 */


/*
 *     Author: Philip Murray
 *     Project Homepage: https://github.com/PhilipMur/Serial-Comm-Tester
 */

using System;
using System.Windows.Forms;

namespace Serial_Comm_Tester
{
    public partial class HexChart : Form
    {
        public static string StartupPath { get; }
        public HexChart()
        {
            InitializeComponent();
        }

        private  void btnHexChart_Click(object sender, EventArgs e)
        {
              richTextBox1.Text = "";
            // const string app =  Application.StartupPath();

            //  using (StreamReader sr = new StreamReader(Application.StartupPath + "\\" + "HEX_to_ASCII.txt"))

            try
            {
                richTextBox1.Text = Properties.Resources.HEX_to_ASCII;

              
            }
            catch 
            {

                MessageBox.Show( "File missing or wrong directory" , "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

          

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private  void btnUnicodeChart_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
           
            try
            {
                richTextBox1.Text = Properties.Resources.Unicode_characters;

            }
            catch 
            {
                MessageBox.Show("File missing or wrong directory", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
          
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
          
           
        }

        private void copySelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == "" && richTextBox1.Text != "")
            {
                Clipboard.SetText(richTextBox1.Text);
            }
           
            if (richTextBox1.SelectedText != "")
            {
                Clipboard.SetText(richTextBox1.SelectedText);
            }

        }

        private void checkBoxBringToFront_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxBringToFront.Checked == true)
            {
                TopMost = true;
            }
            if (checkBoxBringToFront.Checked == false)
            {
                TopMost = false;
            }
        }
    }
}
