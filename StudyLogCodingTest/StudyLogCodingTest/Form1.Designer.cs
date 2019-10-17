namespace StudyLogCodingTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sortingMethod_cb = new System.Windows.Forms.ComboBox();
            this.method_lbl = new System.Windows.Forms.Label();
            this.groups_lbl = new System.Windows.Forms.Label();
            this.animals_lbl = new System.Windows.Forms.Label();
            this.randomize_btn = new System.Windows.Forms.Button();
            this.groups_lst = new System.Windows.Forms.ListBox();
            this.animals_lst = new System.Windows.Forms.ListBox();
            this.message_lbl = new System.Windows.Forms.Label();
            this.results_lst = new System.Windows.Forms.ListView();
            this.Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // sortingMethod_cb
            // 
            this.sortingMethod_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortingMethod_cb.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortingMethod_cb.FormattingEnabled = true;
            this.sortingMethod_cb.Location = new System.Drawing.Point(78, 14);
            this.sortingMethod_cb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sortingMethod_cb.Name = "sortingMethod_cb";
            this.sortingMethod_cb.Size = new System.Drawing.Size(230, 27);
            this.sortingMethod_cb.TabIndex = 1;
            // 
            // method_lbl
            // 
            this.method_lbl.AutoSize = true;
            this.method_lbl.BackColor = System.Drawing.Color.Transparent;
            this.method_lbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.method_lbl.ForeColor = System.Drawing.Color.Black;
            this.method_lbl.Location = new System.Drawing.Point(9, 17);
            this.method_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.method_lbl.Name = "method_lbl";
            this.method_lbl.Size = new System.Drawing.Size(61, 20);
            this.method_lbl.TabIndex = 0;
            this.method_lbl.Text = "Method";
            // 
            // groups_lbl
            // 
            this.groups_lbl.AutoSize = true;
            this.groups_lbl.BackColor = System.Drawing.Color.Transparent;
            this.groups_lbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groups_lbl.ForeColor = System.Drawing.Color.Black;
            this.groups_lbl.Location = new System.Drawing.Point(14, 68);
            this.groups_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.groups_lbl.Name = "groups_lbl";
            this.groups_lbl.Size = new System.Drawing.Size(56, 20);
            this.groups_lbl.TabIndex = 2;
            this.groups_lbl.Text = "Groups";
            // 
            // animals_lbl
            // 
            this.animals_lbl.AutoSize = true;
            this.animals_lbl.BackColor = System.Drawing.Color.Transparent;
            this.animals_lbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animals_lbl.ForeColor = System.Drawing.Color.Black;
            this.animals_lbl.Location = new System.Drawing.Point(8, 134);
            this.animals_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.animals_lbl.Name = "animals_lbl";
            this.animals_lbl.Size = new System.Drawing.Size(62, 20);
            this.animals_lbl.TabIndex = 4;
            this.animals_lbl.Text = "Animals";
            // 
            // randomize_btn
            // 
            this.randomize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.randomize_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomize_btn.Location = new System.Drawing.Point(335, 69);
            this.randomize_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.randomize_btn.Name = "randomize_btn";
            this.randomize_btn.Size = new System.Drawing.Size(100, 41);
            this.randomize_btn.TabIndex = 6;
            this.randomize_btn.Text = "Randomize";
            this.randomize_btn.UseVisualStyleBackColor = true;
            this.randomize_btn.Click += new System.EventHandler(this.randomize_btn_Click);
            // 
            // groups_lst
            // 
            this.groups_lst.AllowDrop = true;
            this.groups_lst.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groups_lst.FormattingEnabled = true;
            this.groups_lst.ItemHeight = 19;
            this.groups_lst.Location = new System.Drawing.Point(78, 68);
            this.groups_lst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groups_lst.Name = "groups_lst";
            this.groups_lst.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.groups_lst.Size = new System.Drawing.Size(230, 42);
            this.groups_lst.Sorted = true;
            this.groups_lst.TabIndex = 3;
            // 
            // animals_lst
            // 
            this.animals_lst.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animals_lst.FormattingEnabled = true;
            this.animals_lst.ItemHeight = 19;
            this.animals_lst.Location = new System.Drawing.Point(78, 134);
            this.animals_lst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.animals_lst.Name = "animals_lst";
            this.animals_lst.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.animals_lst.Size = new System.Drawing.Size(229, 61);
            this.animals_lst.Sorted = true;
            this.animals_lst.TabIndex = 5;
            // 
            // message_lbl
            // 
            this.message_lbl.BackColor = System.Drawing.Color.Transparent;
            this.message_lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.message_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_lbl.Location = new System.Drawing.Point(0, 224);
            this.message_lbl.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.message_lbl.Name = "message_lbl";
            this.message_lbl.Size = new System.Drawing.Size(799, 51);
            this.message_lbl.TabIndex = 7;
            this.message_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // results_lst
            // 
            this.results_lst.AllowColumnReorder = true;
            this.results_lst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.results_lst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Group,
            this.nameTag,
            this.Weight});
            this.results_lst.FullRowSelect = true;
            this.results_lst.GridLines = true;
            this.results_lst.Location = new System.Drawing.Point(452, 14);
            this.results_lst.Name = "results_lst";
            this.results_lst.Size = new System.Drawing.Size(335, 207);
            this.results_lst.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.results_lst.TabIndex = 8;
            this.results_lst.UseCompatibleStateImageBehavior = false;
            this.results_lst.View = System.Windows.Forms.View.Details;
            // 
            // Group
            // 
            this.Group.Text = "Group #";
            this.Group.Width = 90;
            // 
            // nameTag
            // 
            this.nameTag.Text = "Name Tag";
            this.nameTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTag.Width = 137;
            // 
            // Weight
            // 
            this.Weight.Text = "Weight";
            this.Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Weight.Width = 99;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(799, 275);
            this.Controls.Add(this.results_lst);
            this.Controls.Add(this.message_lbl);
            this.Controls.Add(this.animals_lst);
            this.Controls.Add(this.groups_lst);
            this.Controls.Add(this.randomize_btn);
            this.Controls.Add(this.animals_lbl);
            this.Controls.Add(this.groups_lbl);
            this.Controls.Add(this.method_lbl);
            this.Controls.Add(this.sortingMethod_cb);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randomizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sortingMethod_cb;
        private System.Windows.Forms.Label method_lbl;
        private System.Windows.Forms.Label groups_lbl;
        private System.Windows.Forms.Label animals_lbl;
        private System.Windows.Forms.Button randomize_btn;
        private System.Windows.Forms.ListBox groups_lst;
        private System.Windows.Forms.ListBox animals_lst;
        private System.Windows.Forms.Label message_lbl;
        private System.Windows.Forms.ListView results_lst;
        private System.Windows.Forms.ColumnHeader Group;
        private System.Windows.Forms.ColumnHeader nameTag;
        private System.Windows.Forms.ColumnHeader Weight;
    }
}

