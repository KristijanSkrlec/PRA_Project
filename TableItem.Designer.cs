﻿namespace PRA_Project
{
    partial class TableItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            lbID = new Label();
            lbValue = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lbID);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lbValue);
            splitContainer1.Size = new Size(760, 71);
            splitContainer1.SplitterDistance = 126;
            splitContainer1.TabIndex = 0;
            // 
            // lbID
            // 
            lbID.Location = new Point(3, 23);
            lbID.Name = "lbID";
            lbID.Size = new Size(89, 25);
            lbID.TabIndex = 0;
            lbID.Text = "ID";
            lbID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbValue
            // 
            lbValue.Location = new Point(3, 23);
            lbValue.Name = "lbValue";
            lbValue.Size = new Size(627, 25);
            lbValue.TabIndex = 0;
            lbValue.Text = "Value";
            lbValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TableItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "TableItem";
            Size = new Size(760, 71);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        public Label lbID;
        public Label lbValue;
    }
}
