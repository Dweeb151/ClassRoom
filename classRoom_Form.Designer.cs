namespace classRoom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.date_Text = new System.Windows.Forms.TextBox();
            this.date_Label = new System.Windows.Forms.Label();
            this.room_Text = new System.Windows.Forms.TextBox();
            this.room_Label = new System.Windows.Forms.Label();
            this.class_Text = new System.Windows.Forms.TextBox();
            this.class_Label = new System.Windows.Forms.Label();
            this.teacher_Text = new System.Windows.Forms.TextBox();
            this.teacher_Label = new System.Windows.Forms.Label();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.classRoom_DataGridView = new System.Windows.Forms.DataGridView();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.search_Text = new System.Windows.Forms.TextBox();
            this.search_Label = new System.Windows.Forms.Label();
            this.find_Button = new System.Windows.Forms.Button();
            this.saveRAF_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.sort_Button = new System.Windows.Forms.Button();
            this.saveChanges_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.open_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.save_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.headerPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classRoom_DataGridView)).BeginInit();
            this.footerPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.headerPanel.Controls.Add(this.date_Text);
            this.headerPanel.Controls.Add(this.date_Label);
            this.headerPanel.Controls.Add(this.room_Text);
            this.headerPanel.Controls.Add(this.room_Label);
            this.headerPanel.Controls.Add(this.class_Text);
            this.headerPanel.Controls.Add(this.class_Label);
            this.headerPanel.Controls.Add(this.teacher_Text);
            this.headerPanel.Controls.Add(this.teacher_Label);
            this.headerPanel.Location = new System.Drawing.Point(-2, 26);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(986, 45);
            this.headerPanel.TabIndex = 0;
            // 
            // date_Text
            // 
            this.date_Text.Location = new System.Drawing.Point(822, 14);
            this.date_Text.Name = "date_Text";
            this.date_Text.Size = new System.Drawing.Size(152, 23);
            this.date_Text.TabIndex = 8;
            // 
            // date_Label
            // 
            this.date_Label.AutoSize = true;
            this.date_Label.Location = new System.Drawing.Point(768, 17);
            this.date_Label.Name = "date_Label";
            this.date_Label.Size = new System.Drawing.Size(34, 15);
            this.date_Label.TabIndex = 7;
            this.date_Label.Text = "Date:";
            // 
            // room_Text
            // 
            this.room_Text.Location = new System.Drawing.Point(631, 14);
            this.room_Text.Name = "room_Text";
            this.room_Text.Size = new System.Drawing.Size(82, 23);
            this.room_Text.TabIndex = 6;
            // 
            // room_Label
            // 
            this.room_Label.AutoSize = true;
            this.room_Label.Location = new System.Drawing.Point(560, 17);
            this.room_Label.Name = "room_Label";
            this.room_Label.Size = new System.Drawing.Size(42, 15);
            this.room_Label.TabIndex = 5;
            this.room_Label.Text = "Room:";
            // 
            // class_Text
            // 
            this.class_Text.Location = new System.Drawing.Point(415, 14);
            this.class_Text.Name = "class_Text";
            this.class_Text.Size = new System.Drawing.Size(102, 23);
            this.class_Text.TabIndex = 4;
            // 
            // class_Label
            // 
            this.class_Label.AutoSize = true;
            this.class_Label.Location = new System.Drawing.Point(357, 17);
            this.class_Label.Name = "class_Label";
            this.class_Label.Size = new System.Drawing.Size(37, 15);
            this.class_Label.TabIndex = 2;
            this.class_Label.Text = "Class:";
            // 
            // teacher_Text
            // 
            this.teacher_Text.Location = new System.Drawing.Point(78, 11);
            this.teacher_Text.Name = "teacher_Text";
            this.teacher_Text.Size = new System.Drawing.Size(148, 23);
            this.teacher_Text.TabIndex = 1;
            // 
            // teacher_Label
            // 
            this.teacher_Label.AutoSize = true;
            this.teacher_Label.Location = new System.Drawing.Point(12, 14);
            this.teacher_Label.Name = "teacher_Label";
            this.teacher_Label.Size = new System.Drawing.Size(50, 15);
            this.teacher_Label.TabIndex = 0;
            this.teacher_Label.Text = "Teacher:";
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.classRoom_DataGridView);
            this.dataPanel.Location = new System.Drawing.Point(-2, 69);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(986, 441);
            this.dataPanel.TabIndex = 1;
            // 
            // classRoom_DataGridView
            // 
            this.classRoom_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classRoom_DataGridView.Location = new System.Drawing.Point(0, -3);
            this.classRoom_DataGridView.Name = "classRoom_DataGridView";
            this.classRoom_DataGridView.RowTemplate.Height = 25;
            this.classRoom_DataGridView.Size = new System.Drawing.Size(986, 444);
            this.classRoom_DataGridView.TabIndex = 0;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.footerPanel.Controls.Add(this.search_Text);
            this.footerPanel.Controls.Add(this.search_Label);
            this.footerPanel.Controls.Add(this.find_Button);
            this.footerPanel.Controls.Add(this.saveRAF_Button);
            this.footerPanel.Controls.Add(this.exit_Button);
            this.footerPanel.Controls.Add(this.sort_Button);
            this.footerPanel.Controls.Add(this.saveChanges_Button);
            this.footerPanel.Controls.Add(this.clear_Button);
            this.footerPanel.Location = new System.Drawing.Point(1, 513);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(983, 50);
            this.footerPanel.TabIndex = 2;
            // 
            // search_Text
            // 
            this.search_Text.Location = new System.Drawing.Point(402, 14);
            this.search_Text.Name = "search_Text";
            this.search_Text.Size = new System.Drawing.Size(140, 23);
            this.search_Text.TabIndex = 7;
            // 
            // search_Label
            // 
            this.search_Label.AutoSize = true;
            this.search_Label.Location = new System.Drawing.Point(450, 0);
            this.search_Label.Name = "search_Label";
            this.search_Label.Size = new System.Drawing.Size(42, 15);
            this.search_Label.TabIndex = 6;
            this.search_Label.Text = "Search";
            // 
            // find_Button
            // 
            this.find_Button.Location = new System.Drawing.Point(581, 12);
            this.find_Button.Name = "find_Button";
            this.find_Button.Size = new System.Drawing.Size(118, 23);
            this.find_Button.TabIndex = 5;
            this.find_Button.Text = "Find";
            this.find_Button.UseVisualStyleBackColor = true;
            this.find_Button.Click += new System.EventHandler(this.find_Button_Click);
            // 
            // saveRAF_Button
            // 
            this.saveRAF_Button.Location = new System.Drawing.Point(716, 13);
            this.saveRAF_Button.Name = "saveRAF_Button";
            this.saveRAF_Button.Size = new System.Drawing.Size(118, 23);
            this.saveRAF_Button.TabIndex = 4;
            this.saveRAF_Button.Text = "Save RAF";
            this.saveRAF_Button.UseVisualStyleBackColor = true;
            this.saveRAF_Button.Click += new System.EventHandler(this.saveRAF_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Location = new System.Drawing.Point(855, 13);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(116, 23);
            this.exit_Button.TabIndex = 3;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // sort_Button
            // 
            this.sort_Button.Location = new System.Drawing.Point(257, 14);
            this.sort_Button.Name = "sort_Button";
            this.sort_Button.Size = new System.Drawing.Size(108, 23);
            this.sort_Button.TabIndex = 2;
            this.sort_Button.Text = "Sort";
            this.sort_Button.UseVisualStyleBackColor = true;
            this.sort_Button.Click += new System.EventHandler(this.sort_Button_Click);
            // 
            // saveChanges_Button
            // 
            this.saveChanges_Button.Location = new System.Drawing.Point(131, 14);
            this.saveChanges_Button.Name = "saveChanges_Button";
            this.saveChanges_Button.Size = new System.Drawing.Size(110, 23);
            this.saveChanges_Button.TabIndex = 1;
            this.saveChanges_Button.Text = "Save Changes";
            this.saveChanges_Button.UseVisualStyleBackColor = true;
            this.saveChanges_Button.Click += new System.EventHandler(this.saveChanges_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Location = new System.Drawing.Point(14, 14);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(111, 23);
            this.clear_Button.TabIndex = 0;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_Menu,
            this.save_Menu,
            this.saveAs_Menu,
            this.exitMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // open_Menu
            // 
            this.open_Menu.AccessibleDescription = "open_Menu";
            this.open_Menu.Name = "open_Menu";
            this.open_Menu.Size = new System.Drawing.Size(180, 22);
            this.open_Menu.Text = "Open";
            this.open_Menu.Click += new System.EventHandler(this.open_Menu_Click);
            // 
            // save_Menu
            // 
            this.save_Menu.AccessibleName = "save_Menu";
            this.save_Menu.Name = "save_Menu";
            this.save_Menu.Size = new System.Drawing.Size(180, 22);
            this.save_Menu.Text = "Save";
            this.save_Menu.Click += new System.EventHandler(this.save_Menu_Click);
            // 
            // saveAs_Menu
            // 
            this.saveAs_Menu.AccessibleName = "saveAs_Menu";
            this.saveAs_Menu.Name = "saveAs_Menu";
            this.saveAs_Menu.Size = new System.Drawing.Size(180, 22);
            this.saveAs_Menu.Text = "Save As";
            this.saveAs_Menu.Click += new System.EventHandler(this.saveAs_Menu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.AccessibleName = "exit_Menu";
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(180, 22);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classRoom_DataGridView)).EndInit();
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel headerPanel;
        private Panel dataPanel;
        private Panel footerPanel;
        private Label class_Label;
        private TextBox teacher_Text;
        private Label teacher_Label;
        private TextBox date_Text;
        private Label date_Label;
        private TextBox room_Text;
        private Label room_Label;
        private TextBox class_Text;
        private TextBox search_Text;
        private Label search_Label;
        private Button find_Button;
        private Button saveRAF_Button;
        private Button exit_Button;
        private Button sort_Button;
        private Button saveChanges_Button;
        private Button clear_Button;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem open_Menu;
        private ToolStripMenuItem save_Menu;
        private ToolStripMenuItem saveAs_Menu;
        private ToolStripMenuItem exitMenu;
        private DataGridView classRoom_DataGridView;
    }
}