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
            this.fuelRequirementLable = new System.Windows.Forms.Label();
            this.CountFuelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MassSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ModulesListBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fuelRequirementLable, 1, 1);
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
            this.ModulesListBox.Location = new System.Drawing.Point(403, 3);
            this.ModulesListBox.Name = "ModulesListBox";
            this.ModulesListBox.Size = new System.Drawing.Size(394, 399);
            this.ModulesListBox.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.MassSelector);
            this.flowLayoutPanel1.Controls.Add(this.AddModuleButton);
            this.flowLayoutPanel1.Controls.Add(this.CountFuelButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 408);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(394, 39);
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
            this.MassSelector.Size = new System.Drawing.Size(120, 20);
            this.MassSelector.TabIndex = 0;
            // 
            // AddModuleButton
            // 
            this.AddModuleButton.Location = new System.Drawing.Point(129, 3);
            this.AddModuleButton.Name = "AddModuleButton";
            this.AddModuleButton.Size = new System.Drawing.Size(75, 23);
            this.AddModuleButton.TabIndex = 1;
            this.AddModuleButton.Text = "Add Module";
            this.AddModuleButton.UseVisualStyleBackColor = true;
            this.AddModuleButton.Click += new System.EventHandler(this.AddModuleButton_Click);
            // 
            // fuelRequirementLable
            // 
            this.fuelRequirementLable.AutoSize = true;
            this.fuelRequirementLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuelRequirementLable.Location = new System.Drawing.Point(403, 405);
            this.fuelRequirementLable.Name = "fuelRequirementLable";
            this.fuelRequirementLable.Size = new System.Drawing.Size(394, 45);
            this.fuelRequirementLable.TabIndex = 2;
            this.fuelRequirementLable.Text = "Fuel Requirement: ";
            // 
            // CountFuelButton
            // 
            this.CountFuelButton.Location = new System.Drawing.Point(210, 3);
            this.CountFuelButton.Name = "CountFuelButton";
            this.CountFuelButton.Size = new System.Drawing.Size(75, 23);
            this.CountFuelButton.TabIndex = 2;
            this.CountFuelButton.Text = "Count Fuel";
            this.CountFuelButton.UseVisualStyleBackColor = true;
            this.CountFuelButton.Click += new System.EventHandler(this.CountFuelButton_Click);
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
    }
}

