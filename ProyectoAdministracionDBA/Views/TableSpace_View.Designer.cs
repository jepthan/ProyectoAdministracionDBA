﻿using System.Windows.Forms;
using System.Xml;

namespace ProyectoAdministracionDBA.Views
{
    partial class TableSpace_View
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
            tableLayoutPanel1 = new TableLayoutPanel();
            NameLabel = new Label();
            FileDirLabel = new Label();
            AutoExtendCheck = new CheckBox();
            TamannoIncrementoTextBox = new TextBox();
            MaxSizeTextBox = new TextBox();
            BtnUpdate = new Button();
            SizeTextBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.0315189F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5616055F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.237823F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.9142857F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableLayoutPanel1.Controls.Add(NameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(FileDirLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(TamannoIncrementoTextBox, 4, 0);
            tableLayoutPanel1.Controls.Add(MaxSizeTextBox, 5, 0);
            tableLayoutPanel1.Controls.Add(BtnUpdate, 6, 0);
            tableLayoutPanel1.Controls.Add(SizeTextBox, 3, 0);
            tableLayoutPanel1.Controls.Add(AutoExtendCheck, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1396, 50);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(3, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(50, 20);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "label1";
            // 
            // FileDirLabel
            // 
            FileDirLabel.Location = new Point(157, 0);
            FileDirLabel.Name = "FileDirLabel";
            FileDirLabel.Size = new Size(295, 50);
            FileDirLabel.TabIndex = 1;
            // 
            // AutoExtendCheck
            // 
            AutoExtendCheck.Dock = DockStyle.Fill;
            AutoExtendCheck.Location = new Point(458, 3);
            AutoExtendCheck.Name = "AutoExtendCheck";
            AutoExtendCheck.Size = new Size(109, 44);
            AutoExtendCheck.TabIndex = 2;
            AutoExtendCheck.Text = "AutoExtend";
            // 
            // TamannoIncrementoTextBox
            // 
            TamannoIncrementoTextBox.Location = new Point(809, 3);
            TamannoIncrementoTextBox.Name = "TamannoIncrementoTextBox";
            TamannoIncrementoTextBox.Size = new Size(117, 27);
            TamannoIncrementoTextBox.TabIndex = 3;
            // 
            // MaxSizeTextBox
            // 
            MaxSizeTextBox.Location = new Point(1004, 3);
            MaxSizeTextBox.Name = "MaxSizeTextBox";
            MaxSizeTextBox.Size = new Size(117, 27);
            MaxSizeTextBox.TabIndex = 4;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(1199, 3);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(119, 38);
            BtnUpdate.TabIndex = 2;
            BtnUpdate.Text = "Actualizar";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += button1_Click;
            // 
            // SizeTextBox
            // 
            SizeTextBox.Location = new Point(573, 3);
            SizeTextBox.Name = "SizeTextBox";
            SizeTextBox.Size = new Size(142, 27);
            SizeTextBox.TabIndex = 1;
            SizeTextBox.TextChanged += textBox1_TextChanged;
            // 
            // TableSpace_View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "TableSpace_View";
            Size = new Size(1396, 50);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label NameLabel;
        private Label FileDirLabel;
        private TextBox SizeTextBox;
        private CheckBox AutoExtendCheck;
        private TextBox TamannoIncrementoTextBox;
        private TextBox MaxSizeTextBox;

        private Button BtnUpdate;
    }
}
