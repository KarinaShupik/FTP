namespace FTP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.FadList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFile1 = new System.Windows.Forms.TextBox();
            this.txtDir1 = new System.Windows.Forms.TextBox();
            this.txtDir2 = new System.Windows.Forms.TextBox();
            this.txtFile2 = new System.Windows.Forms.TextBox();
            this.txtDir3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.appe = new System.Windows.Forms.Button();
            this.dele = new System.Windows.Forms.Button();
            this.retr = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.mdt = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.Button();
            this.nlist = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.Button();
            this.mkd = new System.Windows.Forms.Button();
            this.pwd = new System.Windows.Forms.Button();
            this.rmd = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Button();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.stor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.stou = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Хост";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ім\'я користувача";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(181, 27);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(215, 22);
            this.txtHost.TabIndex = 3;
            this.txtHost.Text = "ftp";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(181, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(181, 94);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(215, 22);
            this.txtPassword.TabIndex = 5;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(403, 27);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(122, 89);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Підключитися та отримати список каталогів та файлів";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // FadList
            // 
            this.FadList.FormattingEnabled = true;
            this.FadList.ItemHeight = 16;
            this.FadList.Location = new System.Drawing.Point(619, 24);
            this.FadList.Name = "FadList";
            this.FadList.Size = new System.Drawing.Size(306, 324);
            this.FadList.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Операції з FTP";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Розмір файлу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Файл";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Каталог";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Каталог";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Файл";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Каталог";
            // 
            // txtFile1
            // 
            this.txtFile1.Location = new System.Drawing.Point(299, 163);
            this.txtFile1.Name = "txtFile1";
            this.txtFile1.Size = new System.Drawing.Size(226, 22);
            this.txtFile1.TabIndex = 20;
            // 
            // txtDir1
            // 
            this.txtDir1.Location = new System.Drawing.Point(299, 191);
            this.txtDir1.Name = "txtDir1";
            this.txtDir1.Size = new System.Drawing.Size(226, 22);
            this.txtDir1.TabIndex = 21;
            // 
            // txtDir2
            // 
            this.txtDir2.Location = new System.Drawing.Point(299, 221);
            this.txtDir2.Name = "txtDir2";
            this.txtDir2.Size = new System.Drawing.Size(226, 22);
            this.txtDir2.TabIndex = 22;
            // 
            // txtFile2
            // 
            this.txtFile2.Location = new System.Drawing.Point(299, 249);
            this.txtFile2.Name = "txtFile2";
            this.txtFile2.Size = new System.Drawing.Size(226, 22);
            this.txtFile2.TabIndex = 23;
            // 
            // txtDir3
            // 
            this.txtDir3.Location = new System.Drawing.Point(299, 280);
            this.txtDir3.Name = "txtDir3";
            this.txtDir3.Size = new System.Drawing.Size(226, 22);
            this.txtDir3.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Шлях";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 329);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 22);
            this.textBox1.TabIndex = 26;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(532, 162);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 27;
            this.button6.Text = "Browse";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(532, 248);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 29;
            this.button8.Text = "Browse";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(532, 219);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 30;
            this.button9.Text = "Browse";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(532, 190);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 31;
            this.button10.Text = "Browse";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(531, 282);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 32;
            this.button11.Text = "Browse";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // appe
            // 
            this.appe.Location = new System.Drawing.Point(932, 19);
            this.appe.Name = "appe";
            this.appe.Size = new System.Drawing.Size(182, 23);
            this.appe.TabIndex = 33;
            this.appe.Text = "Append files";
            this.appe.UseVisualStyleBackColor = true;
            this.appe.Click += new System.EventHandler(this.appe_Click);
            // 
            // dele
            // 
            this.dele.Location = new System.Drawing.Point(932, 49);
            this.dele.Name = "dele";
            this.dele.Size = new System.Drawing.Size(182, 23);
            this.dele.TabIndex = 34;
            this.dele.Text = "Delete files";
            this.dele.UseVisualStyleBackColor = true;
            this.dele.Click += new System.EventHandler(this.dele_Click);
            // 
            // retr
            // 
            this.retr.Location = new System.Drawing.Point(932, 79);
            this.retr.Name = "retr";
            this.retr.Size = new System.Drawing.Size(182, 23);
            this.retr.TabIndex = 35;
            this.retr.Text = "Download file";
            this.retr.UseVisualStyleBackColor = true;
            this.retr.Click += new System.EventHandler(this.retr_Click);
            // 
            // mdt
            // 
            this.mdt.Location = new System.Drawing.Point(932, 110);
            this.mdt.Name = "mdt";
            this.mdt.Size = new System.Drawing.Size(182, 23);
            this.mdt.TabIndex = 36;
            this.mdt.Text = "Get Date Timestamp";
            this.mdt.UseVisualStyleBackColor = true;
            this.mdt.Click += new System.EventHandler(this.mdt_Click);
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(932, 140);
            this.size.Name = "size";
            this.size.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.size.Size = new System.Drawing.Size(182, 23);
            this.size.TabIndex = 37;
            this.size.Text = "Get File Size";
            this.size.UseVisualStyleBackColor = true;
            this.size.Click += new System.EventHandler(this.size_Click);
            // 
            // nlist
            // 
            this.nlist.Location = new System.Drawing.Point(932, 170);
            this.nlist.Name = "nlist";
            this.nlist.Size = new System.Drawing.Size(182, 23);
            this.nlist.TabIndex = 38;
            this.nlist.Text = "List Directory\t";
            this.nlist.UseVisualStyleBackColor = true;
            this.nlist.Click += new System.EventHandler(this.nlist_Click);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(932, 200);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(182, 23);
            this.list.TabIndex = 39;
            this.list.Text = "List Directory Details\t";
            this.list.UseVisualStyleBackColor = true;
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // mkd
            // 
            this.mkd.Location = new System.Drawing.Point(932, 230);
            this.mkd.Name = "mkd";
            this.mkd.Size = new System.Drawing.Size(182, 23);
            this.mkd.TabIndex = 40;
            this.mkd.Text = "Make Directory";
            this.mkd.UseVisualStyleBackColor = true;
            this.mkd.Click += new System.EventHandler(this.mkd_Click);
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(932, 257);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(183, 23);
            this.pwd.TabIndex = 41;
            this.pwd.Text = "Print Working Directory\t";
            this.pwd.UseVisualStyleBackColor = true;
            // 
            // rmd
            // 
            this.rmd.Location = new System.Drawing.Point(932, 287);
            this.rmd.Name = "rmd";
            this.rmd.Size = new System.Drawing.Size(183, 23);
            this.rmd.TabIndex = 42;
            this.rmd.Text = "Remove Directory\t";
            this.rmd.UseVisualStyleBackColor = true;
            this.rmd.Click += new System.EventHandler(this.rmd_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(932, 317);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(75, 23);
            this.name.TabIndex = 43;
            this.name.Text = "Rename\t";
            this.name.UseVisualStyleBackColor = true;
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(1014, 317);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(100, 22);
            this.txtNewName.TabIndex = 44;
            // 
            // stor
            // 
            this.stor.Location = new System.Drawing.Point(1121, 18);
            this.stor.Name = "stor";
            this.stor.Size = new System.Drawing.Size(207, 23);
            this.stor.TabIndex = 45;
            this.stor.Text = "Upload File";
            this.stor.UseVisualStyleBackColor = true;
            this.stor.Click += new System.EventHandler(this.stor_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Створити каталог";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(34, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Видалити каталог";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(34, 250);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Видалити файл";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(34, 279);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Завантажити на FTP";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // stou
            // 
            this.stou.Location = new System.Drawing.Point(1121, 49);
            this.stou.Name = "stou";
            this.stou.Size = new System.Drawing.Size(207, 23);
            this.stou.TabIndex = 46;
            this.stou.Text = "Upload File With Unique Name";
            this.stou.UseVisualStyleBackColor = true;
            this.stou.Click += new System.EventHandler(this.stou_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(1121, 85);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(207, 255);
            this.treeView1.TabIndex = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 368);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.stou);
            this.Controls.Add(this.stor);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.rmd);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.mkd);
            this.Controls.Add(this.list);
            this.Controls.Add(this.nlist);
            this.Controls.Add(this.size);
            this.Controls.Add(this.mdt);
            this.Controls.Add(this.retr);
            this.Controls.Add(this.dele);
            this.Controls.Add(this.appe);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDir3);
            this.Controls.Add(this.txtFile2);
            this.Controls.Add(this.txtDir2);
            this.Controls.Add(this.txtDir1);
            this.Controls.Add(this.txtFile1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FadList);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox FadList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFile1;
        private System.Windows.Forms.TextBox txtDir1;
        private System.Windows.Forms.TextBox txtDir2;
        private System.Windows.Forms.TextBox txtFile2;
        private System.Windows.Forms.TextBox txtDir3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button appe;
        private System.Windows.Forms.Button dele;
        private System.Windows.Forms.Button retr;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button mdt;
        private System.Windows.Forms.Button size;
        private System.Windows.Forms.Button nlist;
        private System.Windows.Forms.Button list;
        private System.Windows.Forms.Button mkd;
        private System.Windows.Forms.Button pwd;
        private System.Windows.Forms.Button rmd;
        private System.Windows.Forms.Button name;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Button stor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button stou;
        private System.Windows.Forms.TreeView treeView1;
    }
}

