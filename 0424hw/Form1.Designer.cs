namespace _0424hw
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
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.comboBoxDisks = new System.Windows.Forms.ComboBox();
            this.textBoxFindByWordOrPhrase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewFiles
            // 
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.Location = new System.Drawing.Point(12, 92);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(950, 550);
            this.listViewFiles.TabIndex = 17;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 193;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Путь";
            this.columnHeader2.Width = 506;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Кол-во вхождений слова";
            this.columnHeader3.Width = 246;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Диски";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Слово в файле";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(490, 53);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(100, 21);
            this.buttonFind.TabIndex = 14;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // comboBoxDisks
            // 
            this.comboBoxDisks.FormattingEnabled = true;
            this.comboBoxDisks.Location = new System.Drawing.Point(370, 53);
            this.comboBoxDisks.Name = "comboBoxDisks";
            this.comboBoxDisks.Size = new System.Drawing.Size(114, 21);
            this.comboBoxDisks.TabIndex = 13;
            // 
            // textBoxFindByWordOrPhrase
            // 
            this.textBoxFindByWordOrPhrase.Location = new System.Drawing.Point(12, 54);
            this.textBoxFindByWordOrPhrase.Name = "textBoxFindByWordOrPhrase";
            this.textBoxFindByWordOrPhrase.Size = new System.Drawing.Size(352, 20);
            this.textBoxFindByWordOrPhrase.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 660);
            this.Controls.Add(this.listViewFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.comboBoxDisks);
            this.Controls.Add(this.textBoxFindByWordOrPhrase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.ComboBox comboBoxDisks;
        private System.Windows.Forms.TextBox textBoxFindByWordOrPhrase;
    }
}

