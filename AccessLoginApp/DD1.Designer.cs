namespace AccessLoginApp
{
    partial class DD1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DD1));
            this.serial = new System.Windows.Forms.Label();
            this.LetterRefNo = new System.Windows.Forms.Label();
            this.LetterDate = new System.Windows.Forms.Label();
            this.LetterSubject = new System.Windows.Forms.Label();
            this.DGM = new System.Windows.Forms.Label();
            this.cc = new System.Windows.Forms.Label();
            this.attachment = new System.Windows.Forms.Label();
            this.attach_date = new System.Windows.Forms.Label();
            this.AGMCSL = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_serial = new System.Windows.Forms.TextBox();
            this.txt_letterRef = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_letterdate = new System.Windows.Forms.DateTimePicker();
            this.txt_letterSub = new System.Windows.Forms.TextBox();
            this.txt_DGM = new System.Windows.Forms.TextBox();
            this.txt_attach = new System.Windows.Forms.TextBox();
            this.date_attach = new System.Windows.Forms.DateTimePicker();
            this.txt_AGMCSL = new System.Windows.Forms.TextBox();
            this.date_AGMCSL = new System.Windows.Forms.DateTimePicker();
            this.date_cc = new System.Windows.Forms.DateTimePicker();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_chart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // serial
            // 
            this.serial.AutoSize = true;
            this.serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serial.Location = new System.Drawing.Point(12, 19);
            this.serial.Name = "serial";
            this.serial.Size = new System.Drawing.Size(99, 18);
            this.serial.TabIndex = 0;
            this.serial.Text = "Serial number";
            // 
            // LetterRefNo
            // 
            this.LetterRefNo.AutoSize = true;
            this.LetterRefNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LetterRefNo.Location = new System.Drawing.Point(11, 60);
            this.LetterRefNo.Name = "LetterRefNo";
            this.LetterRefNo.Size = new System.Drawing.Size(88, 18);
            this.LetterRefNo.TabIndex = 1;
            this.LetterRefNo.Text = "LetterRefNo";
            // 
            // LetterDate
            // 
            this.LetterDate.AutoSize = true;
            this.LetterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LetterDate.Location = new System.Drawing.Point(11, 109);
            this.LetterDate.Name = "LetterDate";
            this.LetterDate.Size = new System.Drawing.Size(76, 18);
            this.LetterDate.TabIndex = 2;
            this.LetterDate.Text = "LetterDate";
            // 
            // LetterSubject
            // 
            this.LetterSubject.AutoSize = true;
            this.LetterSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LetterSubject.Location = new System.Drawing.Point(11, 149);
            this.LetterSubject.Name = "LetterSubject";
            this.LetterSubject.Size = new System.Drawing.Size(94, 18);
            this.LetterSubject.TabIndex = 3;
            this.LetterSubject.Text = "LetterSubject";
            // 
            // DGM
            // 
            this.DGM.AutoSize = true;
            this.DGM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGM.Location = new System.Drawing.Point(11, 213);
            this.DGM.Name = "DGM";
            this.DGM.Size = new System.Drawing.Size(155, 18);
            this.DGM.TabIndex = 4;
            this.DGM.Text = "DGM (c&C) letter ref no";
            this.DGM.Click += new System.EventHandler(this.label5_Click);
            // 
            // cc
            // 
            this.cc.AutoSize = true;
            this.cc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cc.Location = new System.Drawing.Point(11, 262);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(98, 18);
            this.cc.TabIndex = 5;
            this.cc.Text = "C&C letter date";
            // 
            // attachment
            // 
            this.attachment.AutoSize = true;
            this.attachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachment.Location = new System.Drawing.Point(7, 308);
            this.attachment.Name = "attachment";
            this.attachment.Size = new System.Drawing.Size(157, 18);
            this.attachment.TabIndex = 6;
            this.attachment.Text = "AttachmentletterRefNo";
            // 
            // attach_date
            // 
            this.attach_date.AutoSize = true;
            this.attach_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attach_date.Location = new System.Drawing.Point(7, 352);
            this.attach_date.Name = "attach_date";
            this.attach_date.Size = new System.Drawing.Size(154, 18);
            this.attach_date.TabIndex = 7;
            this.attach_date.Text = "Attachment LetterDate";
            this.attach_date.Click += new System.EventHandler(this.attach_date_Click);
            // 
            // AGMCSL
            // 
            this.AGMCSL.AutoSize = true;
            this.AGMCSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AGMCSL.Location = new System.Drawing.Point(7, 395);
            this.AGMCSL.Name = "AGMCSL";
            this.AGMCSL.Size = new System.Drawing.Size(145, 18);
            this.AGMCSL.TabIndex = 8;
            this.AGMCSL.Text = "AGMCSLetterREfNo";
            this.AGMCSL.Click += new System.EventHandler(this.AGMCSL_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "AGMCSLetterDate";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_serial
            // 
            this.txt_serial.Location = new System.Drawing.Point(177, 19);
            this.txt_serial.Name = "txt_serial";
            this.txt_serial.Size = new System.Drawing.Size(268, 22);
            this.txt_serial.TabIndex = 10;
            // 
            // txt_letterRef
            // 
            this.txt_letterRef.Location = new System.Drawing.Point(177, 60);
            this.txt_letterRef.Name = "txt_letterRef";
            this.txt_letterRef.Size = new System.Drawing.Size(268, 22);
            this.txt_letterRef.TabIndex = 11;
            this.txt_letterRef.TextChanged += new System.EventHandler(this.txt_letterRef_TextChanged);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Silver;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(10, 517);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(85, 37);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_letterdate
            // 
            this.txt_letterdate.Location = new System.Drawing.Point(177, 105);
            this.txt_letterdate.Name = "txt_letterdate";
            this.txt_letterdate.Size = new System.Drawing.Size(268, 22);
            this.txt_letterdate.TabIndex = 13;
            // 
            // txt_letterSub
            // 
            this.txt_letterSub.Location = new System.Drawing.Point(177, 149);
            this.txt_letterSub.Multiline = true;
            this.txt_letterSub.Name = "txt_letterSub";
            this.txt_letterSub.Size = new System.Drawing.Size(268, 39);
            this.txt_letterSub.TabIndex = 14;
            this.txt_letterSub.TextChanged += new System.EventHandler(this.txt_letterSub_TextChanged);
            // 
            // txt_DGM
            // 
            this.txt_DGM.Location = new System.Drawing.Point(177, 213);
            this.txt_DGM.Name = "txt_DGM";
            this.txt_DGM.Size = new System.Drawing.Size(268, 22);
            this.txt_DGM.TabIndex = 15;
            // 
            // txt_attach
            // 
            this.txt_attach.Location = new System.Drawing.Point(177, 308);
            this.txt_attach.Name = "txt_attach";
            this.txt_attach.Size = new System.Drawing.Size(268, 22);
            this.txt_attach.TabIndex = 17;
            this.txt_attach.TextChanged += new System.EventHandler(this.txt_attach_TextChanged);
            // 
            // date_attach
            // 
            this.date_attach.CustomFormat = "";
            this.date_attach.Location = new System.Drawing.Point(177, 352);
            this.date_attach.Name = "date_attach";
            this.date_attach.Size = new System.Drawing.Size(268, 22);
            this.date_attach.TabIndex = 18;
            // 
            // txt_AGMCSL
            // 
            this.txt_AGMCSL.Location = new System.Drawing.Point(177, 391);
            this.txt_AGMCSL.Name = "txt_AGMCSL";
            this.txt_AGMCSL.Size = new System.Drawing.Size(268, 22);
            this.txt_AGMCSL.TabIndex = 19;
            // 
            // date_AGMCSL
            // 
            this.date_AGMCSL.Location = new System.Drawing.Point(177, 435);
            this.date_AGMCSL.Name = "date_AGMCSL";
            this.date_AGMCSL.Size = new System.Drawing.Size(268, 22);
            this.date_AGMCSL.TabIndex = 20;
            // 
            // date_cc
            // 
            this.date_cc.Location = new System.Drawing.Point(177, 262);
            this.date_cc.Name = "date_cc";
            this.date_cc.Size = new System.Drawing.Size(268, 22);
            this.date_cc.TabIndex = 21;
            this.date_cc.ValueChanged += new System.EventHandler(this.date_cc_ValueChanged);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Silver;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(101, 517);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(96, 37);
            this.btn_edit.TabIndex = 22;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Silver;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(203, 517);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(92, 37);
            this.btn_delete.TabIndex = 23;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(655, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(571, 24);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "X axis";
            chartArea2.Name = "Y (value) axis";
            chartArea3.Name = "Secondary X axis";
            chartArea4.Name = "Secondary Y (value) axis";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.ChartAreas.Add(chartArea4);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(627, 174);
            this.chart1.Name = "chart1";
            series1.ChartArea = "X axis";
            series1.Legend = "Legend1";
            series1.Name = "LETTER DATE";
            series1.XValueMember = "Serial number";
            series1.YValueMembers = "LetterDate";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(599, 357);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "chart1";
            // 
            // btn_chart
            // 
            this.btn_chart.BackColor = System.Drawing.Color.Silver;
            this.btn_chart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chart.Location = new System.Drawing.Point(301, 517);
            this.btn_chart.Name = "btn_chart";
            this.btn_chart.Size = new System.Drawing.Size(106, 37);
            this.btn_chart.TabIndex = 26;
            this.btn_chart.Text = "Load Chart";
            this.btn_chart.UseVisualStyleBackColor = false;
            this.btn_chart.Click += new System.EventHandler(this.btn_chart_Click);
            // 
            // DD1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1249, 566);
            this.Controls.Add(this.btn_chart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.date_cc);
            this.Controls.Add(this.date_AGMCSL);
            this.Controls.Add(this.txt_AGMCSL);
            this.Controls.Add(this.date_attach);
            this.Controls.Add(this.txt_attach);
            this.Controls.Add(this.txt_DGM);
            this.Controls.Add(this.txt_letterSub);
            this.Controls.Add(this.txt_letterdate);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_letterRef);
            this.Controls.Add(this.txt_serial);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AGMCSL);
            this.Controls.Add(this.attach_date);
            this.Controls.Add(this.attachment);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.DGM);
            this.Controls.Add(this.LetterSubject);
            this.Controls.Add(this.LetterDate);
            this.Controls.Add(this.LetterRefNo);
            this.Controls.Add(this.serial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DD1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DD1";
            this.Load += new System.EventHandler(this.DD1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serial;
        private System.Windows.Forms.Label LetterRefNo;
        private System.Windows.Forms.Label LetterDate;
        private System.Windows.Forms.Label LetterSubject;
        private System.Windows.Forms.Label DGM;
        private System.Windows.Forms.Label cc;
        private System.Windows.Forms.Label attachment;
        private System.Windows.Forms.Label attach_date;
        private System.Windows.Forms.Label AGMCSL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_serial;
        private System.Windows.Forms.TextBox txt_letterRef;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DateTimePicker txt_letterdate;
        private System.Windows.Forms.TextBox txt_letterSub;
        private System.Windows.Forms.TextBox txt_DGM;
        private System.Windows.Forms.TextBox txt_attach;
        private System.Windows.Forms.DateTimePicker date_attach;
        private System.Windows.Forms.TextBox txt_AGMCSL;
        private System.Windows.Forms.DateTimePicker date_AGMCSL;
        private System.Windows.Forms.DateTimePicker date_cc;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_chart;
    }
}