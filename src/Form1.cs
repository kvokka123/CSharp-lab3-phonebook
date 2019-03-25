using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Web;

namespace Lab3
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();
        public Form1()
        {
            InitializeComponent();

        }
        public class Person
        {
            public string FirstName { get; set; }
            public string Note { get; set; }
            public DateTime Birthday { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public string Additional { get; set; }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.FirstName = textBox1.Text;
            p.Address = textBox3.Text;
            p.Email = textBox2.Text;
            p.Note = textBox4.Text;
            p.Birthday = dateTimePicker1.Value;
            people.Add(p);
            listView1.Items.Add(p.FirstName);
            textBox1.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox4.Text = String.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0)
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
            }
            else
            {
                textBox1.Text = people[listView1.SelectedItems[0].Index].FirstName;
                textBox2.Text = people[listView1.SelectedItems[0].Index].Email;
                textBox3.Text = people[listView1.SelectedItems[0].Index].Address;
                textBox4.Text = people[listView1.SelectedItems[0].Index].Note;
                dateTimePicker1.Value = people[listView1.SelectedItems[0].Index].Birthday;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveContact();
        }
        void RemoveContact()
        {
            try
            {
                people.RemoveAt(listView1.SelectedItems[0].Index);
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            catch { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                people[listView1.SelectedItems[0].Index].FirstName = textBox1.Text;
                people[listView1.SelectedItems[0].Index].Email = textBox2.Text;
                people[listView1.SelectedItems[0].Index].Address = textBox3.Text;
                people[listView1.SelectedItems[0].Index].Note = textBox4.Text;
                people[listView1.SelectedItems[0].Index].Birthday = dateTimePicker1.Value;
                listView1.SelectedItems[0].Text = textBox1.Text;

            }

        }
    }
}