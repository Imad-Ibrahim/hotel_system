
namespace WindowsClient
{
    partial class CleanerForm
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
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCreateReport = new System.Windows.Forms.Button();
            this.listViewDamageReport = new System.Windows.Forms.ListView();
            this.columnHeaderDamagedRoomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderReportedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateOfReport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxDamagedRoomType = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxDamagedRoomDescription = new System.Windows.Forms.Label();
            this.textBoxDamagedRoomFloor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewDamagedRooms = new System.Windows.Forms.ListView();
            this.columnHeaderRoomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRoomType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRoomFloor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabLogout = new System.Windows.Forms.TabPage();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabAdmin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabPage1);
            this.tabAdmin.Controls.Add(this.tabLogout);
            this.tabAdmin.Location = new System.Drawing.Point(-1, 0);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(996, 579);
            this.tabAdmin.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.buttonEdit);
            this.tabPage1.Controls.Add(this.buttonDelete);
            this.tabPage1.Controls.Add(this.buttonCreateReport);
            this.tabPage1.Controls.Add(this.listViewDamageReport);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.textBoxDamagedRoomType);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBoxDamagedRoomDescription);
            this.tabPage1.Controls.Add(this.textBoxDamagedRoomFloor);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listViewDamagedRooms);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(988, 553);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Damage Report";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(412, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Maroon;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(382, 355);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(124, 41);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Maroon;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(513, 355);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(124, 41);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.BackColor = System.Drawing.Color.Maroon;
            this.buttonCreateReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateReport.ForeColor = System.Drawing.Color.White;
            this.buttonCreateReport.Location = new System.Drawing.Point(382, 404);
            this.buttonCreateReport.Name = "buttonCreateReport";
            this.buttonCreateReport.Size = new System.Drawing.Size(255, 41);
            this.buttonCreateReport.TabIndex = 11;
            this.buttonCreateReport.Text = "Create";
            this.buttonCreateReport.UseVisualStyleBackColor = false;
            // 
            // listViewDamageReport
            // 
            this.listViewDamageReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDamagedRoomNumber,
            this.columnHeaderReportedBy,
            this.columnHeaderDateOfReport,
            this.columnHeaderCost});
            this.listViewDamageReport.GridLines = true;
            this.listViewDamageReport.HideSelection = false;
            this.listViewDamageReport.Location = new System.Drawing.Point(740, 1);
            this.listViewDamageReport.Name = "listViewDamageReport";
            this.listViewDamageReport.Size = new System.Drawing.Size(246, 549);
            this.listViewDamageReport.TabIndex = 10;
            this.listViewDamageReport.UseCompatibleStateImageBehavior = false;
            this.listViewDamageReport.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDamagedRoomNumber
            // 
            this.columnHeaderDamagedRoomNumber.Text = "Room Number";
            this.columnHeaderDamagedRoomNumber.Width = 90;
            // 
            // columnHeaderReportedBy
            // 
            this.columnHeaderReportedBy.Text = "Reported By";
            this.columnHeaderReportedBy.Width = 90;
            // 
            // columnHeaderDateOfReport
            // 
            this.columnHeaderDateOfReport.Text = "Date";
            // 
            // columnHeaderCost
            // 
            this.columnHeaderCost.Text = "Cost";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(382, 203);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(255, 129);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // textBoxDamagedRoomType
            // 
            this.textBoxDamagedRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDamagedRoomType.Location = new System.Drawing.Point(412, 101);
            this.textBoxDamagedRoomType.Name = "textBoxDamagedRoomType";
            this.textBoxDamagedRoomType.ReadOnly = true;
            this.textBoxDamagedRoomType.Size = new System.Drawing.Size(199, 24);
            this.textBoxDamagedRoomType.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(412, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(199, 24);
            this.textBox3.TabIndex = 7;
            // 
            // textBoxDamagedRoomDescription
            // 
            this.textBoxDamagedRoomDescription.AutoSize = true;
            this.textBoxDamagedRoomDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDamagedRoomDescription.Location = new System.Drawing.Point(470, 182);
            this.textBoxDamagedRoomDescription.Name = "textBoxDamagedRoomDescription";
            this.textBoxDamagedRoomDescription.Size = new System.Drawing.Size(83, 18);
            this.textBoxDamagedRoomDescription.TabIndex = 4;
            this.textBoxDamagedRoomDescription.Text = "Description";
            // 
            // textBoxDamagedRoomFloor
            // 
            this.textBoxDamagedRoomFloor.AutoSize = true;
            this.textBoxDamagedRoomFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDamagedRoomFloor.Location = new System.Drawing.Point(470, 128);
            this.textBoxDamagedRoomFloor.Name = "textBoxDamagedRoomFloor";
            this.textBoxDamagedRoomFloor.Size = new System.Drawing.Size(89, 18);
            this.textBoxDamagedRoomFloor.TabIndex = 3;
            this.textBoxDamagedRoomFloor.Text = "Room Floor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room Number";
            // 
            // listViewDamagedRooms
            // 
            this.listViewDamagedRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderRoomNumber,
            this.columnHeaderRoomType,
            this.columnHeaderRoomFloor});
            this.listViewDamagedRooms.GridLines = true;
            this.listViewDamagedRooms.HideSelection = false;
            this.listViewDamagedRooms.Location = new System.Drawing.Point(0, -1);
            this.listViewDamagedRooms.Name = "listViewDamagedRooms";
            this.listViewDamagedRooms.Size = new System.Drawing.Size(275, 554);
            this.listViewDamagedRooms.TabIndex = 0;
            this.listViewDamagedRooms.UseCompatibleStateImageBehavior = false;
            this.listViewDamagedRooms.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderRoomNumber
            // 
            this.columnHeaderRoomNumber.Text = "Room Number";
            this.columnHeaderRoomNumber.Width = 90;
            // 
            // columnHeaderRoomType
            // 
            this.columnHeaderRoomType.Text = "Room Type";
            this.columnHeaderRoomType.Width = 90;
            // 
            // columnHeaderRoomFloor
            // 
            this.columnHeaderRoomFloor.Text = "Room Floor";
            this.columnHeaderRoomFloor.Width = 90;
            // 
            // tabLogout
            // 
            this.tabLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabLogout.Controls.Add(this.btnLock);
            this.tabLogout.Controls.Add(this.btnLogout);
            this.tabLogout.Location = new System.Drawing.Point(4, 22);
            this.tabLogout.Name = "tabLogout";
            this.tabLogout.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogout.Size = new System.Drawing.Size(988, 553);
            this.tabLogout.TabIndex = 1;
            this.tabLogout.Text = "Logout";
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.Color.Maroon;
            this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLock.ForeColor = System.Drawing.Color.White;
            this.btnLock.Location = new System.Drawing.Point(537, 211);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(256, 140);
            this.btnLock.TabIndex = 3;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = false;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Maroon;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(237, 211);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(256, 140);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // CleanerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 575);
            this.ControlBox = false;
            this.Controls.Add(this.tabAdmin);
            this.DoubleBuffered = true;
            this.Name = "CleanerForm";
            this.tabAdmin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabLogout;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCreateReport;
        private System.Windows.Forms.ListView listViewDamageReport;
        private System.Windows.Forms.ColumnHeader columnHeaderDamagedRoomNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderReportedBy;
        private System.Windows.Forms.ColumnHeader columnHeaderDateOfReport;
        private System.Windows.Forms.ColumnHeader columnHeaderCost;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxDamagedRoomType;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label textBoxDamagedRoomDescription;
        private System.Windows.Forms.Label textBoxDamagedRoomFloor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewDamagedRooms;
        private System.Windows.Forms.ColumnHeader columnHeaderRoomNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderRoomType;
        private System.Windows.Forms.ColumnHeader columnHeaderRoomFloor;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}