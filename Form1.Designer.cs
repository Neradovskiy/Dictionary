
namespace task8
{
    partial class Form1
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
            this.langSelectLeft = new System.Windows.Forms.ComboBox();
            this.translateTo = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.translate = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LeftTextBox
            // 
            this.LeftTextBox.Location = new System.Drawing.Point(17, 79);
            this.LeftTextBox.Name = "LeftTextBox";
            this.LeftTextBox.Size = new System.Drawing.Size(345, 89);
            this.LeftTextBox.TabIndex = 2;
            this.LeftTextBox.Text = "";
            // 
            // RightTextBox
            // 
            this.RightTextBox.Location = new System.Drawing.Point(399, 79);
            this.RightTextBox.Name = "RightTextBox";
            this.RightTextBox.Size = new System.Drawing.Size(389, 89);
            this.RightTextBox.TabIndex = 3;
            this.RightTextBox.Text = "";
            // 
            // langSelectLeft
            // 
            this.langSelectLeft.FormattingEnabled = true;
            this.langSelectLeft.Location = new System.Drawing.Point(17, 49);
            this.langSelectLeft.Name = "langSelectLeft";
            this.langSelectLeft.Size = new System.Drawing.Size(121, 24);
            this.langSelectLeft.TabIndex = 4;
            // 
            // translateTo
            // 
            this.translateTo.FormattingEnabled = true;
            this.translateTo.Location = new System.Drawing.Point(399, 49);
            this.translateTo.Name = "translateTo";
            this.translateTo.Size = new System.Drawing.Size(121, 24);
            this.translateTo.TabIndex = 5;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(644, 201);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(144, 81);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add new word";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // translate
            // 
            this.translate.Location = new System.Drawing.Point(17, 183);
            this.translate.Name = "translate";
            this.translate.Size = new System.Drawing.Size(345, 99);
            this.translate.TabIndex = 7;
            this.translate.Text = "Translate";
            this.translate.UseVisualStyleBackColor = true;
            this.translate.Click += new System.EventHandler(this.translate_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(17, 391);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(136, 47);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete word";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.translate);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.translateTo);
            this.Controls.Add(this.langSelectLeft);
            this.Controls.Add(this.RightTextBox);
            this.Controls.Add(this.LeftTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox LeftTextBox;
        private System.Windows.Forms.RichTextBox RightTextBox;
        private System.Windows.Forms.ComboBox langSelectLeft;
        private System.Windows.Forms.ComboBox translateTo;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button translate;
        private System.Windows.Forms.Button Delete;
    }
}

