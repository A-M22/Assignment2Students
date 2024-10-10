using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Students
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            NameBox.Items.Add(NameText1.Text);
            NumberBox.Items.Add(NumberText1.Text);
            AddressBox.Items.Add(AddressText1.Text);
            PhoneBox.Items.Add(PhoneText1.Text);
        }

        private void EditStudent_Click(object sender, EventArgs e)
        {
            int select = NameBox.SelectedIndex;
            NameBox.Items[select]   = NameText1.Text ;
            NumberBox.Items[select] =NumberText1.Text ;
            AddressBox.Items[select]=AddressText1.Text ;
            PhoneBox.Items[select]  =PhoneText1.Text ;
        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            int select = NameBox.SelectedIndex;
            NameBox.Items.RemoveAt(select);
            NumberBox.Items.RemoveAt(select);
            AddressBox.Items.RemoveAt(select);
            PhoneBox.Items.RemoveAt(select);

        }

        private void ClearLIsts_Click(object sender, EventArgs e)
        {
            NameBox.Items.Clear();
            NumberBox.Items.Clear();
            AddressBox.Items.Clear();
            PhoneBox.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReportText.Text=NameBox.Items.Count.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NameText1.Text = "";
            NumberText1.Text = "";
            AddressText1.Text = "";
            PhoneText1.Text = "";
        }
    }
}
