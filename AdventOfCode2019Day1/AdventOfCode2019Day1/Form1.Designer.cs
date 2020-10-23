namespace AdventOfCode2019Day1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ModulesListBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MassSelector = new System.Windows.Forms.NumericUpDown();
            this.AddModuleButton = new System.Windows.Forms.Button();
            this.CountFuelButton = new System.Windows.Forms.Button();
            this.countFuelTextBoxButton = new System.Windows.Forms.Button();
            this.fuelRequirementLable = new System.Windows.Forms.Label();
            this.inputModuleTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MassSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.25F));
            this.tableLayoutPanel1.Controls.Add(this.ModulesListBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fuelRequirementLable, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputModuleTextBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // ModulesListBox
            // 
            this.ModulesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModulesListBox.FormattingEnabled = true;
            this.ModulesListBox.Location = new System.Drawing.Point(393, 3);
            this.ModulesListBox.Name = "ModulesListBox";
            this.ModulesListBox.Size = new System.Drawing.Size(404, 399);
            this.ModulesListBox.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.MassSelector);
            this.flowLayoutPanel1.Controls.Add(this.AddModuleButton);
            this.flowLayoutPanel1.Controls.Add(this.CountFuelButton);
            this.flowLayoutPanel1.Controls.Add(this.countFuelTextBoxButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 408);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(384, 39);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // MassSelector
            // 
            this.MassSelector.Location = new System.Drawing.Point(3, 3);
            this.MassSelector.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.MassSelector.Name = "MassSelector";
            this.MassSelector.Size = new System.Drawing.Size(94, 20);
            this.MassSelector.TabIndex = 0;
            // 
            // AddModuleButton
            // 
            this.AddModuleButton.Location = new System.Drawing.Point(103, 3);
            this.AddModuleButton.Name = "AddModuleButton";
            this.AddModuleButton.Size = new System.Drawing.Size(75, 23);
            this.AddModuleButton.TabIndex = 1;
            this.AddModuleButton.Text = "Add Module";
            this.AddModuleButton.UseVisualStyleBackColor = true;
            this.AddModuleButton.Click += new System.EventHandler(this.AddModuleButton_Click);
            // 
            // CountFuelButton
            // 
            this.CountFuelButton.Location = new System.Drawing.Point(184, 3);
            this.CountFuelButton.Name = "CountFuelButton";
            this.CountFuelButton.Size = new System.Drawing.Size(75, 23);
            this.CountFuelButton.TabIndex = 2;
            this.CountFuelButton.Text = "Count Fuel";
            this.CountFuelButton.UseVisualStyleBackColor = true;
            this.CountFuelButton.Click += new System.EventHandler(this.CountFuelButton_Click);
            // 
            // countFuelTextBoxButton
            // 
            this.countFuelTextBoxButton.AutoSize = true;
            this.countFuelTextBoxButton.Location = new System.Drawing.Point(265, 3);
            this.countFuelTextBoxButton.Name = "countFuelTextBoxButton";
            this.countFuelTextBoxButton.Size = new System.Drawing.Size(113, 23);
            this.countFuelTextBoxButton.TabIndex = 3;
            this.countFuelTextBoxButton.Text = "Count Fuel Text Box";
            this.countFuelTextBoxButton.UseVisualStyleBackColor = true;
            this.countFuelTextBoxButton.Click += new System.EventHandler(this.CountFuelTextBoxButton_Click);
            // 
            // fuelRequirementLable
            // 
            this.fuelRequirementLable.AutoSize = true;
            this.fuelRequirementLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuelRequirementLable.Location = new System.Drawing.Point(393, 405);
            this.fuelRequirementLable.Name = "fuelRequirementLable";
            this.fuelRequirementLable.Size = new System.Drawing.Size(404, 45);
            this.fuelRequirementLable.TabIndex = 2;
            this.fuelRequirementLable.Text = "Fuel Requirement: ";
            // 
            // inputModuleTextBox
            // 
            this.inputModuleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputModuleTextBox.Location = new System.Drawing.Point(3, 3);
            this.inputModuleTextBox.Multiline = true;
            this.inputModuleTextBox.Name = "inputModuleTextBox";
            this.inputModuleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputModuleTextBox.Size = new System.Drawing.Size(384, 399);
            this.inputModuleTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MassSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox ModulesListBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown MassSelector;
        private System.Windows.Forms.Button AddModuleButton;
        private System.Windows.Forms.Label fuelRequirementLable;
        private System.Windows.Forms.Button CountFuelButton;
        private System.Windows.Forms.TextBox inputModuleTextBox;
        private System.Windows.Forms.Button countFuelTextBoxButton;
    }
}

