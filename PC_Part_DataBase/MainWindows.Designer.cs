
namespace PC_Part_DataBase
{
    partial class MainWindows
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
            this.PC_Parts_DataGrid = new System.Windows.Forms.DataGridView();
            this.Confirm = new System.Windows.Forms.Button();
            this.Label_1 = new System.Windows.Forms.Label();
            this.Components = new System.Windows.Forms.Label();
            this.Manufacturer = new System.Windows.Forms.Label();
            this.Subvendor = new System.Windows.Forms.Label();
            this.Parts_title = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Parts_cost = new System.Windows.Forms.Label();
            this.Components_Listbox = new System.Windows.Forms.ListBox();
            this.Manufacturers_Listbox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PC_Parts_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PC_Parts_DataGrid
            // 
            this.PC_Parts_DataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.PC_Parts_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PC_Parts_DataGrid.Location = new System.Drawing.Point(106, 34);
            this.PC_Parts_DataGrid.Name = "PC_Parts_DataGrid";
            this.PC_Parts_DataGrid.RowTemplate.Height = 25;
            this.PC_Parts_DataGrid.Size = new System.Drawing.Size(706, 176);
            this.PC_Parts_DataGrid.TabIndex = 0;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(627, 401);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 1;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Label_1
            // 
            this.Label_1.AutoSize = true;
            this.Label_1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Label_1.Location = new System.Drawing.Point(121, 223);
            this.Label_1.Name = "Label_1";
            this.Label_1.Size = new System.Drawing.Size(92, 20);
            this.Label_1.TabIndex = 2;
            this.Label_1.Text = "Add new row";
            // 
            // Components
            // 
            this.Components.AutoSize = true;
            this.Components.Location = new System.Drawing.Point(206, 248);
            this.Components.Name = "Components";
            this.Components.Size = new System.Drawing.Size(76, 15);
            this.Components.TabIndex = 3;
            this.Components.Text = "Components";
            // 
            // Manufacturer
            // 
            this.Manufacturer.AutoSize = true;
            this.Manufacturer.Location = new System.Drawing.Point(206, 283);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(79, 15);
            this.Manufacturer.TabIndex = 4;
            this.Manufacturer.Text = "Manufacturer";
            // 
            // Subvendor
            // 
            this.Subvendor.AutoSize = true;
            this.Subvendor.Location = new System.Drawing.Point(206, 320);
            this.Subvendor.Name = "Subvendor";
            this.Subvendor.Size = new System.Drawing.Size(64, 15);
            this.Subvendor.TabIndex = 5;
            this.Subvendor.Text = "Subvendor";
            // 
            // Parts_title
            // 
            this.Parts_title.AutoSize = true;
            this.Parts_title.Location = new System.Drawing.Point(206, 355);
            this.Parts_title.Name = "Parts_title";
            this.Parts_title.Size = new System.Drawing.Size(59, 15);
            this.Parts_title.TabIndex = 6;
            this.Parts_title.Text = "Part\'s title";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(294, 385);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(294, 352);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(294, 317);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 10;
            // 
            // Parts_cost
            // 
            this.Parts_cost.AutoSize = true;
            this.Parts_cost.Location = new System.Drawing.Point(206, 388);
            this.Parts_cost.Name = "Parts_cost";
            this.Parts_cost.Size = new System.Drawing.Size(61, 15);
            this.Parts_cost.TabIndex = 12;
            this.Parts_cost.Text = "Part\'s cost";
            // 
            // Components_Listbox
            // 
            this.Components_Listbox.FormattingEnabled = true;
            this.Components_Listbox.ItemHeight = 15;
            this.Components_Listbox.Items.AddRange(new object[] {
            "Case",
            "CPU",
            "CPU_Cooler",
            "GPU",
            "Mainboard",
            "RAM",
            "PSU",
            "Storage"});
            this.Components_Listbox.Location = new System.Drawing.Point(294, 248);
            this.Components_Listbox.Name = "Components_Listbox";
            this.Components_Listbox.Size = new System.Drawing.Size(100, 19);
            this.Components_Listbox.TabIndex = 13;
            this.Components_Listbox.SelectedIndexChanged += new System.EventHandler(this.Components_Listbox_SelectedIndexChanged);
            // 
            // Manufacturers_Listbox
            // 
            this.Manufacturers_Listbox.FormattingEnabled = true;
            this.Manufacturers_Listbox.ItemHeight = 15;
            this.Manufacturers_Listbox.Location = new System.Drawing.Point(292, 283);
            this.Manufacturers_Listbox.Name = "Manufacturers_Listbox";
            this.Manufacturers_Listbox.Size = new System.Drawing.Size(102, 19);
            this.Manufacturers_Listbox.TabIndex = 14;
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(886, 480);
            this.Controls.Add(this.Manufacturers_Listbox);
            this.Controls.Add(this.Components_Listbox);
            this.Controls.Add(this.Parts_cost);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Parts_title);
            this.Controls.Add(this.Subvendor);
            this.Controls.Add(this.Manufacturer);
            this.Controls.Add(this.Components);
            this.Controls.Add(this.Label_1);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.PC_Parts_DataGrid);
            this.Name = "MainWindows";
            this.Text = "PC_DataBase";
            this.Load += new System.EventHandler(this.MainWindows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PC_Parts_DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PC_Parts_DataGrid;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label Label_1;
        private System.Windows.Forms.Label Part_Name;
        private System.Windows.Forms.Label Manufacturer;
        private System.Windows.Forms.Label Subvendor;
        private System.Windows.Forms.Label Parts_title;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Parts_cost;
        private System.Windows.Forms.Label Components;
        private System.Windows.Forms.ListBox Components_Listbox;
        private System.Windows.Forms.ListBox Manufacturers_Listbox;
    }
}

