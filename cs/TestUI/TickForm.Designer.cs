﻿namespace TestUI
{
    partial class TickForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExportCsv = new System.Windows.Forms.Button();
            this.checkBoxUseTody = new System.Windows.Forms.CheckBox();
            this.buttonShowChart = new System.Windows.Forms.Button();
            this.btnGetTick = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.editCode = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.trendChart1 = new TestUI.TrendChart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonPrev);
            this.panel1.Controls.Add(this.buttonExportCsv);
            this.panel1.Controls.Add(this.checkBoxUseTody);
            this.panel1.Controls.Add(this.buttonShowChart);
            this.panel1.Controls.Add(this.btnGetTick);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.editCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 37);
            this.panel1.TabIndex = 0;
            // 
            // buttonExportCsv
            // 
            this.buttonExportCsv.Location = new System.Drawing.Point(555, 9);
            this.buttonExportCsv.Name = "buttonExportCsv";
            this.buttonExportCsv.Size = new System.Drawing.Size(75, 23);
            this.buttonExportCsv.TabIndex = 5;
            this.buttonExportCsv.Text = "导入Excel";
            this.buttonExportCsv.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseTody
            // 
            this.checkBoxUseTody.AutoSize = true;
            this.checkBoxUseTody.Location = new System.Drawing.Point(309, 16);
            this.checkBoxUseTody.Name = "checkBoxUseTody";
            this.checkBoxUseTody.Size = new System.Drawing.Size(48, 16);
            this.checkBoxUseTody.TabIndex = 4;
            this.checkBoxUseTody.Text = "当日";
            this.checkBoxUseTody.UseVisualStyleBackColor = true;
            this.checkBoxUseTody.CheckedChanged += new System.EventHandler(this.checkBoxUseTody_CheckedChanged);
            // 
            // buttonShowChart
            // 
            this.buttonShowChart.Location = new System.Drawing.Point(474, 9);
            this.buttonShowChart.Name = "buttonShowChart";
            this.buttonShowChart.Size = new System.Drawing.Size(75, 23);
            this.buttonShowChart.TabIndex = 3;
            this.buttonShowChart.Text = "走势图";
            this.buttonShowChart.UseVisualStyleBackColor = true;
            this.buttonShowChart.Click += new System.EventHandler(this.buttonShowChart_Click);
            // 
            // btnGetTick
            // 
            this.btnGetTick.Location = new System.Drawing.Point(393, 10);
            this.btnGetTick.Name = "btnGetTick";
            this.btnGetTick.Size = new System.Drawing.Size(75, 23);
            this.btnGetTick.TabIndex = 2;
            this.btnGetTick.Text = "提取 Tick";
            this.btnGetTick.UseVisualStyleBackColor = true;
            this.btnGetTick.Click += new System.EventHandler(this.btnGetTick_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(169, 12);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(133, 21);
            this.dtpDate.TabIndex = 1;
            // 
            // editCode
            // 
            this.editCode.Location = new System.Drawing.Point(11, 13);
            this.editCode.Name = "editCode";
            this.editCode.Size = new System.Drawing.Size(139, 21);
            this.editCode.TabIndex = 0;
            this.editCode.Text = "000001.SH";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 37);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trendChart1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(1066, 587);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1066, 333);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(636, 8);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 6;
            this.buttonPrev.Text = "上一日";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(717, 8);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 7;
            this.buttonNext.Text = "下一日";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // trendChart1
            // 
            this.trendChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trendChart1.Location = new System.Drawing.Point(0, 0);
            this.trendChart1.Name = "trendChart1";
            this.trendChart1.Size = new System.Drawing.Size(1066, 250);
            this.trendChart1.TabIndex = 0;
            this.trendChart1.Load += new System.EventHandler(this.trendChart1_Load);
            // 
            // TickForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 624);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "TickForm";
            this.Text = "TickForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGetTick;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox editCode;
        private System.Windows.Forms.Button buttonShowChart;
        private System.Windows.Forms.CheckBox checkBoxUseTody;
        private System.Windows.Forms.Button buttonExportCsv;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private TrendChart trendChart1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
    }
}