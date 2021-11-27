
namespace task8
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LeftTextBox = new System.Windows.Forms.RichTextBox();
            this.RightTextBox = new System.Windows.Forms.RichTextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Translate = new System.Windows.Forms.ComboBox();
            this.LangSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LeftTextBox
            // 
            this.LeftTextBox.Location = new System.Drawing.Point(0, 30);
            this.LeftTextBox.Name = "LeftTextBox";
            this.LeftTextBox.Size = new System.Drawing.Size(210, 96);
            this.LeftTextBox.TabIndex = 2;
            this.LeftTextBox.Text = "";
            // 
            // RightTextBox
            // 
            this.RightTextBox.Location = new System.Drawing.Point(240, 30);
            this.RightTextBox.Name = "RightTextBox";
            this.RightTextBox.Size = new System.Drawing.Size(210, 96);
            this.RightTextBox.TabIndex = 3;
            this.RightTextBox.Text = "";
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(0, 132);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(210, 77);
            this.Ok.TabIndex = 4;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(240, 132);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(210, 77);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Translate
            // 
            this.Translate.FormattingEnabled = true;
            this.Translate.Location = new System.Drawing.Point(240, 0);
            this.Translate.Name = "Translate";
            this.Translate.Size = new System.Drawing.Size(121, 24);
            this.Translate.TabIndex = 1;
            // 
            // LangSelect
            // 
            this.LangSelect.FormattingEnabled = true;
            this.LangSelect.Location = new System.Drawing.Point(0, 0);
            this.LangSelect.Name = "LangSelect";
            this.LangSelect.Size = new System.Drawing.Size(121, 24);
            this.LangSelect.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 209);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.RightTextBox);
            this.Controls.Add(this.LeftTextBox);
            this.Controls.Add(this.Translate);
            this.Controls.Add(this.LangSelect);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox LeftTextBox;
        private System.Windows.Forms.RichTextBox RightTextBox;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox Translate;
        private System.Windows.Forms.ComboBox LangSelect;
    }
}