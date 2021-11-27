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
    partial class Form2 : Form

    {
        Languages language = new Languages();
        public Word word { get; set; }
        public Form2()
        {
            InitializeComponent();

            LangSelect.Items.Add(language.Eng);
            LangSelect.Items.Add(language.Rus);
            LangSelect.SelectedItem = language.Rus;

            Translate.Items.Add(language.Eng);
            Translate.Items.Add(language.Rus);
            Translate.SelectedItem = language.Eng;
        }
        private void Ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.LeftTextBox.Text))
                DialogResult = DialogResult.Cancel;
            word = new Word (this.LeftTextBox.Text.ToLower(), this.RightTextBox.Text.ToLower());
            DialogResult = DialogResult.OK;
            //_parent     TODO доделать добавление слова в словарь родителя
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
