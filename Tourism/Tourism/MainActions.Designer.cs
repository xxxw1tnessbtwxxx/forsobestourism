namespace Tourism
{
    partial class MainActions
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
            this.tabcontrol_admin = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_updateuserlist = new System.Windows.Forms.Button();
            this.cb_userlist = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_delete_actions_all = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_add_action = new System.Windows.Forms.Button();
            this.tabcontrol_admin.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcontrol_admin
            // 
            this.tabcontrol_admin.Controls.Add(this.tabPage2);
            this.tabcontrol_admin.Controls.Add(this.tabPage3);
            this.tabcontrol_admin.Location = new System.Drawing.Point(2, 3);
            this.tabcontrol_admin.Name = "tabcontrol_admin";
            this.tabcontrol_admin.SelectedIndex = 0;
            this.tabcontrol_admin.Size = new System.Drawing.Size(829, 503);
            this.tabcontrol_admin.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_updateuserlist);
            this.tabPage2.Controls.Add(this.cb_userlist);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(821, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btn_updateuserlist
            // 
            this.btn_updateuserlist.Location = new System.Drawing.Point(230, 29);
            this.btn_updateuserlist.Name = "btn_updateuserlist";
            this.btn_updateuserlist.Size = new System.Drawing.Size(75, 23);
            this.btn_updateuserlist.TabIndex = 2;
            this.btn_updateuserlist.Text = "Update";
            this.btn_updateuserlist.UseVisualStyleBackColor = true;
            this.btn_updateuserlist.Click += new System.EventHandler(this.btn_updateuserlist_Click);
            // 
            // cb_userlist
            // 
            this.cb_userlist.FormattingEnabled = true;
            this.cb_userlist.Location = new System.Drawing.Point(48, 29);
            this.cb_userlist.Name = "cb_userlist";
            this.cb_userlist.Size = new System.Drawing.Size(134, 21);
            this.cb_userlist.TabIndex = 1;
            this.cb_userlist.SelectedIndexChanged += new System.EventHandler(this.cb_userlist_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 78);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(815, 393);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_delete_actions_all);
            this.tabPage3.Controls.Add(this.btn_update);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.btn_add_action);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(821, 477);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Actions List";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_delete_actions_all
            // 
            this.btn_delete_actions_all.Location = new System.Drawing.Point(571, 435);
            this.btn_delete_actions_all.Name = "btn_delete_actions_all";
            this.btn_delete_actions_all.Size = new System.Drawing.Size(104, 23);
            this.btn_delete_actions_all.TabIndex = 6;
            this.btn_delete_actions_all.Text = "Удалить все";
            this.btn_delete_actions_all.UseVisualStyleBackColor = true;
            this.btn_delete_actions_all.Click += new System.EventHandler(this.btn_delete_actions_all_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(712, 435);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Обновить";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 90;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(814, 426);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_add_action
            // 
            this.btn_add_action.Location = new System.Drawing.Point(479, 435);
            this.btn_add_action.Name = "btn_add_action";
            this.btn_add_action.Size = new System.Drawing.Size(75, 23);
            this.btn_add_action.TabIndex = 1;
            this.btn_add_action.Text = "Добавить";
            this.btn_add_action.UseVisualStyleBackColor = true;
            this.btn_add_action.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 505);
            this.Controls.Add(this.tabcontrol_admin);
            this.Name = "MainActions";
            this.Text = "MainActions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainActions_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabcontrol_admin.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol_admin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_add_action;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete_actions_all;
        private System.Windows.Forms.ComboBox cb_userlist;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_updateuserlist;
    }
}

