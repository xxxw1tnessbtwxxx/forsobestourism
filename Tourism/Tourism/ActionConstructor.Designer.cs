namespace Tourism
{
    partial class ActionConstructor
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
            this.rb_silver = new System.Windows.Forms.RadioButton();
            this.rb_gold = new System.Windows.Forms.RadioButton();
            this.rb_platinum = new System.Windows.Forms.RadioButton();
            this.btn_create_action = new System.Windows.Forms.Button();
            this.tb_action_desc = new System.Windows.Forms.TextBox();
            this.lb_action_description = new System.Windows.Forms.Label();
            this.tb_action_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_action_size = new System.Windows.Forms.TextBox();
            this.lb_action_size = new System.Windows.Forms.Label();
            this.cb_action_summary = new System.Windows.Forms.CheckBox();
            this.combobox_action_type = new System.Windows.Forms.ComboBox();
            this.lb_actiontype = new System.Windows.Forms.Label();
            this.lb_categories = new System.Windows.Forms.Label();
            this.cb_action_date = new System.Windows.Forms.CheckBox();
            this.cb_cities = new System.Windows.Forms.CheckedListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rb_silver
            // 
            this.rb_silver.AutoSize = true;
            this.rb_silver.Location = new System.Drawing.Point(616, 74);
            this.rb_silver.Name = "rb_silver";
            this.rb_silver.Size = new System.Drawing.Size(51, 17);
            this.rb_silver.TabIndex = 50;
            this.rb_silver.TabStop = true;
            this.rb_silver.Text = "Silver";
            this.rb_silver.UseVisualStyleBackColor = true;
            // 
            // rb_gold
            // 
            this.rb_gold.AutoSize = true;
            this.rb_gold.Location = new System.Drawing.Point(563, 74);
            this.rb_gold.Name = "rb_gold";
            this.rb_gold.Size = new System.Drawing.Size(47, 17);
            this.rb_gold.TabIndex = 49;
            this.rb_gold.TabStop = true;
            this.rb_gold.Text = "Gold";
            this.rb_gold.UseVisualStyleBackColor = true;
            // 
            // rb_platinum
            // 
            this.rb_platinum.AutoSize = true;
            this.rb_platinum.Location = new System.Drawing.Point(492, 74);
            this.rb_platinum.Name = "rb_platinum";
            this.rb_platinum.Size = new System.Drawing.Size(65, 17);
            this.rb_platinum.TabIndex = 48;
            this.rb_platinum.TabStop = true;
            this.rb_platinum.Text = "Platinum";
            this.rb_platinum.UseVisualStyleBackColor = true;
            this.rb_platinum.CheckedChanged += new System.EventHandler(this.rb_platinum_CheckedChanged);
            // 
            // btn_create_action
            // 
            this.btn_create_action.Location = new System.Drawing.Point(687, 397);
            this.btn_create_action.Name = "btn_create_action";
            this.btn_create_action.Size = new System.Drawing.Size(75, 23);
            this.btn_create_action.TabIndex = 47;
            this.btn_create_action.Text = "Добавить";
            this.btn_create_action.UseVisualStyleBackColor = true;
            this.btn_create_action.Click += new System.EventHandler(this.btn_create_action_Click);
            // 
            // tb_action_desc
            // 
            this.tb_action_desc.Location = new System.Drawing.Point(379, 272);
            this.tb_action_desc.Multiline = true;
            this.tb_action_desc.Name = "tb_action_desc";
            this.tb_action_desc.Size = new System.Drawing.Size(411, 119);
            this.tb_action_desc.TabIndex = 46;
            // 
            // lb_action_description
            // 
            this.lb_action_description.AutoSize = true;
            this.lb_action_description.Location = new System.Drawing.Point(375, 255);
            this.lb_action_description.Name = "lb_action_description";
            this.lb_action_description.Size = new System.Drawing.Size(57, 13);
            this.lb_action_description.TabIndex = 45;
            this.lb_action_description.Text = "Описание";
            // 
            // tb_action_name
            // 
            this.tb_action_name.Location = new System.Drawing.Point(477, 229);
            this.tb_action_name.Name = "tb_action_name";
            this.tb_action_name.Size = new System.Drawing.Size(121, 20);
            this.tb_action_name.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Назание акции";
            // 
            // tb_action_size
            // 
            this.tb_action_size.Location = new System.Drawing.Point(477, 166);
            this.tb_action_size.Name = "tb_action_size";
            this.tb_action_size.Size = new System.Drawing.Size(121, 20);
            this.tb_action_size.TabIndex = 42;
            // 
            // lb_action_size
            // 
            this.lb_action_size.AutoSize = true;
            this.lb_action_size.Location = new System.Drawing.Point(376, 166);
            this.lb_action_size.Name = "lb_action_size";
            this.lb_action_size.Size = new System.Drawing.Size(85, 13);
            this.lb_action_size.TabIndex = 41;
            this.lb_action_size.Text = "Размер скидки";
            // 
            // cb_action_summary
            // 
            this.cb_action_summary.AutoSize = true;
            this.cb_action_summary.Location = new System.Drawing.Point(379, 192);
            this.cb_action_summary.Name = "cb_action_summary";
            this.cb_action_summary.Size = new System.Drawing.Size(316, 17);
            this.cb_action_summary.TabIndex = 40;
            this.cb_action_summary.Text = "Скидка может быть просумиирована с другими акциями";
            this.cb_action_summary.UseVisualStyleBackColor = true;
            // 
            // combobox_action_type
            // 
            this.combobox_action_type.FormattingEnabled = true;
            this.combobox_action_type.Items.AddRange(new object[] {
            "Фиксированная"});
            this.combobox_action_type.Location = new System.Drawing.Point(477, 126);
            this.combobox_action_type.Name = "combobox_action_type";
            this.combobox_action_type.Size = new System.Drawing.Size(121, 21);
            this.combobox_action_type.TabIndex = 39;
            this.combobox_action_type.SelectedIndexChanged += new System.EventHandler(this.combobox_action_type_SelectedIndexChanged);
            // 
            // lb_actiontype
            // 
            this.lb_actiontype.AutoSize = true;
            this.lb_actiontype.Location = new System.Drawing.Point(376, 129);
            this.lb_actiontype.Name = "lb_actiontype";
            this.lb_actiontype.Size = new System.Drawing.Size(65, 13);
            this.lb_actiontype.TabIndex = 38;
            this.lb_actiontype.Text = "Тип скидки";
            // 
            // lb_categories
            // 
            this.lb_categories.AutoSize = true;
            this.lb_categories.Location = new System.Drawing.Point(376, 74);
            this.lb_categories.Name = "lb_categories";
            this.lb_categories.Size = new System.Drawing.Size(110, 13);
            this.lb_categories.TabIndex = 37;
            this.lb_categories.Text = "Категория клиентов";
            // 
            // cb_action_date
            // 
            this.cb_action_date.AutoSize = true;
            this.cb_action_date.Location = new System.Drawing.Point(379, 30);
            this.cb_action_date.Name = "cb_action_date";
            this.cb_action_date.Size = new System.Drawing.Size(106, 17);
            this.cb_action_date.TabIndex = 36;
            this.cb_action_date.Text = "Скидки на даты";
            this.cb_action_date.UseVisualStyleBackColor = true;
            this.cb_action_date.CheckedChanged += new System.EventHandler(this.cb_action_date_CheckedChanged);
            // 
            // cb_cities
            // 
            this.cb_cities.FormattingEnabled = true;
            this.cb_cities.Location = new System.Drawing.Point(11, 86);
            this.cb_cities.Name = "cb_cities";
            this.cb_cities.Size = new System.Drawing.Size(291, 334);
            this.cb_cities.TabIndex = 35;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(498, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 51;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(616, 27);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 52;
            this.textBox3.Visible = false;
            // 
            // ActionConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.rb_silver);
            this.Controls.Add(this.rb_gold);
            this.Controls.Add(this.rb_platinum);
            this.Controls.Add(this.btn_create_action);
            this.Controls.Add(this.tb_action_desc);
            this.Controls.Add(this.lb_action_description);
            this.Controls.Add(this.tb_action_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_action_size);
            this.Controls.Add(this.lb_action_size);
            this.Controls.Add(this.cb_action_summary);
            this.Controls.Add(this.combobox_action_type);
            this.Controls.Add(this.lb_actiontype);
            this.Controls.Add(this.lb_categories);
            this.Controls.Add(this.cb_action_date);
            this.Controls.Add(this.cb_cities);
            this.Name = "ActionConstructor";
            this.Text = "ActionConstructor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActionConstructor_FormClosed);
            this.Load += new System.EventHandler(this.ActionConstructor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_silver;
        private System.Windows.Forms.RadioButton rb_gold;
        private System.Windows.Forms.RadioButton rb_platinum;
        private System.Windows.Forms.Button btn_create_action;
        private System.Windows.Forms.TextBox tb_action_desc;
        private System.Windows.Forms.Label lb_action_description;
        private System.Windows.Forms.TextBox tb_action_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_action_size;
        private System.Windows.Forms.Label lb_action_size;
        private System.Windows.Forms.CheckBox cb_action_summary;
        private System.Windows.Forms.ComboBox combobox_action_type;
        private System.Windows.Forms.Label lb_actiontype;
        private System.Windows.Forms.Label lb_categories;
        private System.Windows.Forms.CheckBox cb_action_date;
        private System.Windows.Forms.CheckedListBox cb_cities;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}