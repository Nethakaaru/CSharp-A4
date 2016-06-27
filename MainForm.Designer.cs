namespace Assignment4
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatafileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDatafileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxPrio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxToDo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTipDate = new System.Windows.Forms.ToolTip(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCtrlNToolStripMenuItem,
            this.openDatafileToolStripMenuItem,
            this.saveDatafileToolStripMenuItem,
            this.exitAltToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCtrlNToolStripMenuItem
            // 
            this.newCtrlNToolStripMenuItem.Name = "newCtrlNToolStripMenuItem";
            this.newCtrlNToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newCtrlNToolStripMenuItem.Text = "New   Ctrl+N";
            this.newCtrlNToolStripMenuItem.Click += new System.EventHandler(this.newCtrlNToolStripMenuItem_Click);
            // 
            // openDatafileToolStripMenuItem
            // 
            this.openDatafileToolStripMenuItem.Name = "openDatafileToolStripMenuItem";
            this.openDatafileToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.openDatafileToolStripMenuItem.Text = "Open datafile";
            this.openDatafileToolStripMenuItem.Click += new System.EventHandler(this.openDatafileToolStripMenuItem_Click);
            // 
            // saveDatafileToolStripMenuItem
            // 
            this.saveDatafileToolStripMenuItem.Name = "saveDatafileToolStripMenuItem";
            this.saveDatafileToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.saveDatafileToolStripMenuItem.Text = "Save datafile";
            this.saveDatafileToolStripMenuItem.Click += new System.EventHandler(this.saveDatafileToolStripMenuItem_Click);
            // 
            // exitAltToolStripMenuItem
            // 
            this.exitAltToolStripMenuItem.Name = "exitAltToolStripMenuItem";
            this.exitAltToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exitAltToolStripMenuItem.Text = "Exit   Alt+F4";
            this.exitAltToolStripMenuItem.Click += new System.EventHandler(this.exitAltToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AboutToolStripMenuItem.Text = "About...";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.omToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date and time";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(95, 44);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(257, 20);
            this.datePicker.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Priority";
            // 
            // cBoxPrio
            // 
            this.cBoxPrio.FormattingEnabled = true;
            this.cBoxPrio.Location = new System.Drawing.Point(422, 43);
            this.cBoxPrio.Name = "cBoxPrio";
            this.cBoxPrio.Size = new System.Drawing.Size(121, 21);
            this.cBoxPrio.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "To do";
            // 
            // txtBoxToDo
            // 
            this.txtBoxToDo.Location = new System.Drawing.Point(84, 74);
            this.txtBoxToDo.Name = "txtBoxToDo";
            this.txtBoxToDo.Size = new System.Drawing.Size(459, 20);
            this.txtBoxToDo.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(128, 113);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(264, 113);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(394, 113);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 183);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "To Do";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(9, 45);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(518, 121);
            this.listBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(375, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Priority";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(553, 366);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 391);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxToDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBoxPrio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "To Do Reminder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCtrlNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDatafileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDatafileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitAltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxPrio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxToDo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTipDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}

