using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task8
{
    partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            language = new Languages();
            langSelectLeft.Items.Add(language.Rus);
            langSelectLeft.Items.Add(language.Eng);
            langSelectLeft.SelectedItem = language.Rus;

            translateTo.Items.Add(language.Rus);
            translateTo.Items.Add(language.Eng);
            translateTo.SelectedItem = language.Eng;

            _dictionary = new Dictionary(language.Rus + language.Eng);
            //_dictionary.Add(new Word("Привет", "Hello"));
            //_dictionary.Save();
        }

        Dictionary _dictionary;
        Languages language;

        private void Add_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            if (_dictionary.Add(form2.word))
                _dictionary.Save();
            else
                MessageBox.Show("Word not added");
        }

        private void translate_Click(object sender, EventArgs e)
        {
            List<string> translate = new List<string>();
            if (langSelectLeft.SelectedItem.ToString() == language.Rus && !string.IsNullOrEmpty(LeftTextBox.Text)
                && translateTo.SelectedItem.ToString() == language.Eng)
            {
                _dictionary.Load(language.Rus + language.Eng);
                translate = _dictionary.Translate(LeftTextBox.Text.ToLower());
            }

            if (langSelectLeft.SelectedItem.ToString() == language.Eng && !string.IsNullOrEmpty(LeftTextBox.Text)
               && translateTo.SelectedItem.ToString() == language.Rus)
            {
                _dictionary.Load(language.Eng + language.Rus);
                translate = _dictionary.Translate(LeftTextBox.Text.ToLower());
            }
            RightTextBox.Clear();
            if (translate != null)
            {
                foreach (string i in translate)
                    RightTextBox.Text += i + "\n";

            }
            else
                RightTextBox.Text = LeftTextBox.Text;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string confim = "Are you shure?";
            DialogResult result = MessageBox.Show(confim, "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _dictionary.Remove(LeftTextBox.Text.ToLower());
                LeftTextBox.Clear();
                RightTextBox.Clear();
                _dictionary.Save();
            }

        }

        private void toString_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hello world!!!");
            Console.WriteLine(_dictionary.ToString());
        }
    }
}
