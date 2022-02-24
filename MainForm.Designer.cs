
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
            this.CurrentTailNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newTailNumber = new System.Windows.Forms.TextBox();
            this.SetTailNumberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentTailNumber
            // 
            this.CurrentTailNumber.AutoSize = true;
            this.CurrentTailNumber.Location = new System.Drawing.Point(122, 15);
            this.CurrentTailNumber.Name = "CurrentTailNumber";
            this.CurrentTailNumber.Size = new System.Drawing.Size(0, 13);
            this.CurrentTailNumber.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Tail Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Tail Number:";
            // 
            // newTailNumber
            // 
            this.newTailNumber.Enabled = false;
            this.newTailNumber.Location = new System.Drawing.Point(125, 53);
            this.newTailNumber.MaxLength = 12;
            this.newTailNumber.Name = "newTailNumber";
            this.newTailNumber.Size = new System.Drawing.Size(264, 20);
            this.newTailNumber.TabIndex = 0;
            // 
            // SetTailNumberButton
            // 
            this.SetTailNumberButton.Enabled = false;
            this.SetTailNumberButton.Location = new System.Drawing.Point(395, 51);
            this.SetTailNumberButton.Name = "SetTailNumberButton";
            this.SetTailNumberButton.Size = new System.Drawing.Size(75, 23);
            this.SetTailNumberButton.TabIndex = 1;
            this.SetTailNumberButton.Text = "Update";
            this.SetTailNumberButton.UseVisualStyleBackColor = true;
            this.SetTailNumberButton.Click += new System.EventHandler(this.SetTailNumberButton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.SetTailNumberButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 91);
            this.Controls.Add(this.SetTailNumberButton);
            this.Controls.Add(this.newTailNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentTailNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MSFS Tail Number Utility - FSUIPC";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentTailNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newTailNumber;
        private System.Windows.Forms.Button SetTailNumberButton;
    }
}

