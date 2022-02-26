
namespace MSFS_2020_Tail_Number_Fixer___FSUIPC
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
            this.CurrentTailNumberLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewTailNumber = new System.Windows.Forms.TextBox();
            this.SetTailNumberButton = new System.Windows.Forms.Button();
            this.HistoricGroupBox = new System.Windows.Forms.GroupBox();
            this.UseSelectedButton = new System.Windows.Forms.Button();
            this.HistoricList = new System.Windows.Forms.ListView();
            this.TailNumberHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AircraftModelLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HistoricListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoricGroupBox.SuspendLayout();
            this.HistoricListContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentTailNumberLabel
            // 
            this.CurrentTailNumberLabel.AutoSize = true;
            this.CurrentTailNumberLabel.Location = new System.Drawing.Point(122, 25);
            this.CurrentTailNumberLabel.Name = "CurrentTailNumberLabel";
            this.CurrentTailNumberLabel.Size = new System.Drawing.Size(0, 13);
            this.CurrentTailNumberLabel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Tail Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Tail Number:";
            // 
            // NewTailNumber
            // 
            this.NewTailNumber.Enabled = false;
            this.NewTailNumber.Location = new System.Drawing.Point(125, 49);
            this.NewTailNumber.MaxLength = 12;
            this.NewTailNumber.Name = "NewTailNumber";
            this.NewTailNumber.Size = new System.Drawing.Size(264, 20);
            this.NewTailNumber.TabIndex = 0;
            // 
            // SetTailNumberButton
            // 
            this.SetTailNumberButton.Enabled = false;
            this.SetTailNumberButton.Location = new System.Drawing.Point(395, 47);
            this.SetTailNumberButton.Name = "SetTailNumberButton";
            this.SetTailNumberButton.Size = new System.Drawing.Size(75, 23);
            this.SetTailNumberButton.TabIndex = 1;
            this.SetTailNumberButton.Text = "Update";
            this.SetTailNumberButton.UseVisualStyleBackColor = true;
            this.SetTailNumberButton.Click += new System.EventHandler(this.SetTailNumberButton_Click);
            // 
            // HistoricGroupBox
            // 
            this.HistoricGroupBox.Controls.Add(this.UseSelectedButton);
            this.HistoricGroupBox.Controls.Add(this.HistoricList);
            this.HistoricGroupBox.Location = new System.Drawing.Point(15, 86);
            this.HistoricGroupBox.Name = "HistoricGroupBox";
            this.HistoricGroupBox.Size = new System.Drawing.Size(455, 247);
            this.HistoricGroupBox.TabIndex = 4;
            this.HistoricGroupBox.TabStop = false;
            this.HistoricGroupBox.Text = "Past Tail Numbers";
            // 
            // UseSelectedButton
            // 
            this.UseSelectedButton.Enabled = false;
            this.UseSelectedButton.Location = new System.Drawing.Point(351, 218);
            this.UseSelectedButton.Name = "UseSelectedButton";
            this.UseSelectedButton.Size = new System.Drawing.Size(98, 23);
            this.UseSelectedButton.TabIndex = 4;
            this.UseSelectedButton.Text = "Use Selected";
            this.UseSelectedButton.UseVisualStyleBackColor = true;
            this.UseSelectedButton.Click += new System.EventHandler(this.UseSelectedButton_Click);
            // 
            // HistoricList
            // 
            this.HistoricList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TailNumberHeader});
            this.HistoricList.ContextMenuStrip = this.HistoricListContextMenu;
            this.HistoricList.FullRowSelect = true;
            this.HistoricList.HideSelection = false;
            this.HistoricList.Location = new System.Drawing.Point(12, 19);
            this.HistoricList.Name = "HistoricList";
            this.HistoricList.Size = new System.Drawing.Size(437, 193);
            this.HistoricList.TabIndex = 3;
            this.HistoricList.UseCompatibleStateImageBehavior = false;
            this.HistoricList.View = System.Windows.Forms.View.Details;
            // 
            // TailNumberHeader
            // 
            this.TailNumberHeader.Text = "Tail Number";
            this.TailNumberHeader.Width = 356;
            // 
            // AircraftModelLabel
            // 
            this.AircraftModelLabel.AutoSize = true;
            this.AircraftModelLabel.Location = new System.Drawing.Point(122, 12);
            this.AircraftModelLabel.Name = "AircraftModelLabel";
            this.AircraftModelLabel.Size = new System.Drawing.Size(0, 13);
            this.AircraftModelLabel.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Aircraft:";
            // 
            // HistoricListContextMenu
            // 
            this.HistoricListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.HistoricListContextMenu.Name = "HistoricListContextMenu";
            this.HistoricListContextMenu.Size = new System.Drawing.Size(181, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.SetTailNumberButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 343);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AircraftModelLabel);
            this.Controls.Add(this.HistoricGroupBox);
            this.Controls.Add(this.SetTailNumberButton);
            this.Controls.Add(this.NewTailNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentTailNumberLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MSFS Tail Number Utility - FSUIPC";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.HistoricGroupBox.ResumeLayout(false);
            this.HistoricListContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentTailNumberLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewTailNumber;
        private System.Windows.Forms.Button SetTailNumberButton;
        private System.Windows.Forms.GroupBox HistoricGroupBox;
        private System.Windows.Forms.Button UseSelectedButton;
        private System.Windows.Forms.Label AircraftModelLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView HistoricList;
        private System.Windows.Forms.ColumnHeader TailNumberHeader;
        private System.Windows.Forms.ContextMenuStrip HistoricListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

