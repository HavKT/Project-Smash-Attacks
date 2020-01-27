using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmashAttacks
{
    public partial class PSA_Flag_Properties : Form
    {
        public PSA_Flag_Properties()
        {
            InitializeComponent();
        }

        public string GetHexVal = "00000000";
        public string NewHexVal = "00000000";
        public bool IsSpecialFlags = false;

        private void PSA_Flag_Properties_Load(object sender, EventArgs e)
        {
            SetFlagValues();
        }

        private void PSA_Flag_Properties_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void okb_Click(object sender, EventArgs e)
        {
            NewHexVal = newHexValue.Text;
            DialogResult = DialogResult.OK;
        }

        private void cnclb_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SetFlagValues()
        {
            ReadFlagValues();
            newHexValue.Text = oldHexValue.Text = GetHexVal;
            if (!IsSpecialFlags)
            {

            }
            else
            {

            }
        }


        private void ReadFlagValues()
        {
            char[] l = GetHexVal.ToCharArray();

            /*First Character on the Value*/
            if (l[0].ToString() == "3") { directCB.Checked = true; luc2.Checked = true; }
            if (l[0].ToString() == "2") { directCB.Checked = true;}
            if (l[0].ToString() == "1") { luc2.Checked = true; }
            /*Second Character on the Value*/


            //char[] b = new char[GetHexVal.Length];

            //using (StringReader sr = new StringReader(GetHexVal))
            //{
            //    sr.Read(b, 1, 3);
            //    MessageBox.Show(String.Format("Character read from: {0}", b));
            //}
        }
    }
}
