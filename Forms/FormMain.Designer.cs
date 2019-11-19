namespace MS_Lab2
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelAboutTime = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queue1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queue2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countSection1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countSection2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isEquipmentFree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countNbr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxAboutTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAvgSpeed = new System.Windows.Forms.TextBox();
            this.textBoxConeyorIdle = new System.Windows.Forms.TextBox();
            this.textBoxAvgSpeedQueue1 = new System.Windows.Forms.TextBox();
            this.textBoxMaxTimeIdleQueue1 = new System.Windows.Forms.TextBox();
            this.textBoxMinTimeIdleQueue1 = new System.Windows.Forms.TextBox();
            this.textBoxAvgSpeedQueue2 = new System.Windows.Forms.TextBox();
            this.textBoxMaxTimeIdleQueue2 = new System.Windows.Forms.TextBox();
            this.textBoxMinTimeIdleQueue2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxT1 = new System.Windows.Forms.TextBox();
            this.textBoxT2 = new System.Windows.Forms.TextBox();
            this.textBoxT3 = new System.Windows.Forms.TextBox();
            this.textBoxN3 = new System.Windows.Forms.TextBox();
            this.textBoxN2 = new System.Windows.Forms.TextBox();
            this.textBoxN1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonRandomValues = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxNbrFromSection1 = new System.Windows.Forms.TextBox();
            this.textBoxNbrFromSection2 = new System.Windows.Forms.TextBox();
            this.textBoxNbr = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvReportT1 = new System.Windows.Forms.DataGridView();
            this.ColumnT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReportT2 = new System.Windows.Forms.DataGridView();
            this.ColumnT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportT2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            resources.ApplyResources(this.buttonStart, "buttonStart");
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // labelAboutTime
            // 
            resources.ApplyResources(this.labelAboutTime, "labelAboutTime");
            this.labelAboutTime.Name = "labelAboutTime";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.queue1,
            this.queue2,
            this.countSection1,
            this.countSection2,
            this.isEquipmentFree,
            this.equipment,
            this.countNbr});
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            resources.ApplyResources(this.dgv, "dgv");
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.time, "time");
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // queue1
            // 
            this.queue1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.queue1, "queue1");
            this.queue1.Name = "queue1";
            this.queue1.ReadOnly = true;
            // 
            // queue2
            // 
            this.queue2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.queue2, "queue2");
            this.queue2.Name = "queue2";
            this.queue2.ReadOnly = true;
            // 
            // countSection1
            // 
            this.countSection1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.countSection1, "countSection1");
            this.countSection1.Name = "countSection1";
            this.countSection1.ReadOnly = true;
            // 
            // countSection2
            // 
            this.countSection2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.countSection2, "countSection2");
            this.countSection2.Name = "countSection2";
            this.countSection2.ReadOnly = true;
            // 
            // isEquipmentFree
            // 
            this.isEquipmentFree.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.isEquipmentFree, "isEquipmentFree");
            this.isEquipmentFree.Name = "isEquipmentFree";
            this.isEquipmentFree.ReadOnly = true;
            // 
            // equipment
            // 
            this.equipment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            resources.ApplyResources(this.equipment, "equipment");
            this.equipment.Name = "equipment";
            this.equipment.ReadOnly = true;
            // 
            // countNbr
            // 
            this.countNbr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.countNbr, "countNbr");
            this.countNbr.Name = "countNbr";
            this.countNbr.ReadOnly = true;
            // 
            // textBoxTime
            // 
            resources.ApplyResources(this.textBoxTime, "textBoxTime");
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            // 
            // buttonHelp
            // 
            resources.ApplyResources(this.buttonHelp, "buttonHelp");
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // buttonExit
            // 
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // textBoxAboutTask
            // 
            resources.ApplyResources(this.textBoxAboutTask, "textBoxAboutTask");
            this.textBoxAboutTask.Name = "textBoxAboutTask";
            this.textBoxAboutTask.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // textBoxAvgSpeed
            // 
            resources.ApplyResources(this.textBoxAvgSpeed, "textBoxAvgSpeed");
            this.textBoxAvgSpeed.Name = "textBoxAvgSpeed";
            this.textBoxAvgSpeed.ReadOnly = true;
            // 
            // textBoxConeyorIdle
            // 
            resources.ApplyResources(this.textBoxConeyorIdle, "textBoxConeyorIdle");
            this.textBoxConeyorIdle.Name = "textBoxConeyorIdle";
            this.textBoxConeyorIdle.ReadOnly = true;
            // 
            // textBoxAvgSpeedQueue1
            // 
            resources.ApplyResources(this.textBoxAvgSpeedQueue1, "textBoxAvgSpeedQueue1");
            this.textBoxAvgSpeedQueue1.Name = "textBoxAvgSpeedQueue1";
            this.textBoxAvgSpeedQueue1.ReadOnly = true;
            // 
            // textBoxMaxTimeIdleQueue1
            // 
            resources.ApplyResources(this.textBoxMaxTimeIdleQueue1, "textBoxMaxTimeIdleQueue1");
            this.textBoxMaxTimeIdleQueue1.Name = "textBoxMaxTimeIdleQueue1";
            this.textBoxMaxTimeIdleQueue1.ReadOnly = true;
            // 
            // textBoxMinTimeIdleQueue1
            // 
            resources.ApplyResources(this.textBoxMinTimeIdleQueue1, "textBoxMinTimeIdleQueue1");
            this.textBoxMinTimeIdleQueue1.Name = "textBoxMinTimeIdleQueue1";
            this.textBoxMinTimeIdleQueue1.ReadOnly = true;
            // 
            // textBoxAvgSpeedQueue2
            // 
            resources.ApplyResources(this.textBoxAvgSpeedQueue2, "textBoxAvgSpeedQueue2");
            this.textBoxAvgSpeedQueue2.Name = "textBoxAvgSpeedQueue2";
            this.textBoxAvgSpeedQueue2.ReadOnly = true;
            // 
            // textBoxMaxTimeIdleQueue2
            // 
            resources.ApplyResources(this.textBoxMaxTimeIdleQueue2, "textBoxMaxTimeIdleQueue2");
            this.textBoxMaxTimeIdleQueue2.Name = "textBoxMaxTimeIdleQueue2";
            this.textBoxMaxTimeIdleQueue2.ReadOnly = true;
            // 
            // textBoxMinTimeIdleQueue2
            // 
            resources.ApplyResources(this.textBoxMinTimeIdleQueue2, "textBoxMinTimeIdleQueue2");
            this.textBoxMinTimeIdleQueue2.Name = "textBoxMinTimeIdleQueue2";
            this.textBoxMinTimeIdleQueue2.ReadOnly = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // textBoxT1
            // 
            resources.ApplyResources(this.textBoxT1, "textBoxT1");
            this.textBoxT1.Name = "textBoxT1";
            this.textBoxT1.ReadOnly = true;
            // 
            // textBoxT2
            // 
            resources.ApplyResources(this.textBoxT2, "textBoxT2");
            this.textBoxT2.Name = "textBoxT2";
            this.textBoxT2.ReadOnly = true;
            // 
            // textBoxT3
            // 
            resources.ApplyResources(this.textBoxT3, "textBoxT3");
            this.textBoxT3.Name = "textBoxT3";
            this.textBoxT3.ReadOnly = true;
            // 
            // textBoxN3
            // 
            resources.ApplyResources(this.textBoxN3, "textBoxN3");
            this.textBoxN3.Name = "textBoxN3";
            this.textBoxN3.ReadOnly = true;
            // 
            // textBoxN2
            // 
            resources.ApplyResources(this.textBoxN2, "textBoxN2");
            this.textBoxN2.Name = "textBoxN2";
            this.textBoxN2.ReadOnly = true;
            // 
            // textBoxN1
            // 
            resources.ApplyResources(this.textBoxN1, "textBoxN1");
            this.textBoxN1.Name = "textBoxN1";
            this.textBoxN1.ReadOnly = true;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // buttonRandomValues
            // 
            resources.ApplyResources(this.buttonRandomValues, "buttonRandomValues");
            this.buttonRandomValues.Name = "buttonRandomValues";
            this.buttonRandomValues.UseVisualStyleBackColor = true;
            this.buttonRandomValues.Click += new System.EventHandler(this.buttonRandomValues_Click);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // textBoxNbrFromSection1
            // 
            resources.ApplyResources(this.textBoxNbrFromSection1, "textBoxNbrFromSection1");
            this.textBoxNbrFromSection1.Name = "textBoxNbrFromSection1";
            this.textBoxNbrFromSection1.ReadOnly = true;
            // 
            // textBoxNbrFromSection2
            // 
            resources.ApplyResources(this.textBoxNbrFromSection2, "textBoxNbrFromSection2");
            this.textBoxNbrFromSection2.Name = "textBoxNbrFromSection2";
            this.textBoxNbrFromSection2.ReadOnly = true;
            // 
            // textBoxNbr
            // 
            resources.ApplyResources(this.textBoxNbr, "textBoxNbr");
            this.textBoxNbr.Name = "textBoxNbr";
            this.textBoxNbr.ReadOnly = true;
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // dgvReportT1
            // 
            this.dgvReportT1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportT1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnT1});
            resources.ApplyResources(this.dgvReportT1, "dgvReportT1");
            this.dgvReportT1.Name = "dgvReportT1";
            // 
            // ColumnT1
            // 
            this.ColumnT1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.ColumnT1, "ColumnT1");
            this.ColumnT1.Name = "ColumnT1";
            // 
            // dgvReportT2
            // 
            this.dgvReportT2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportT2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnT2});
            resources.ApplyResources(this.dgvReportT2, "dgvReportT2");
            this.dgvReportT2.Name = "dgvReportT2";
            // 
            // ColumnT2
            // 
            this.ColumnT2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.ColumnT2, "ColumnT2");
            this.ColumnT2.Name = "ColumnT2";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvReportT2);
            this.Controls.Add(this.dgvReportT1);
            this.Controls.Add(this.textBoxNbr);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxNbrFromSection2);
            this.Controls.Add(this.textBoxNbrFromSection1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.buttonRandomValues);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBoxN3);
            this.Controls.Add(this.textBoxN2);
            this.Controls.Add(this.textBoxN1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxT3);
            this.Controls.Add(this.textBoxT2);
            this.Controls.Add(this.textBoxT1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxMinTimeIdleQueue2);
            this.Controls.Add(this.textBoxMaxTimeIdleQueue2);
            this.Controls.Add(this.textBoxAvgSpeedQueue2);
            this.Controls.Add(this.textBoxMinTimeIdleQueue1);
            this.Controls.Add(this.textBoxMaxTimeIdleQueue1);
            this.Controls.Add(this.textBoxAvgSpeedQueue1);
            this.Controls.Add(this.textBoxConeyorIdle);
            this.Controls.Add(this.textBoxAvgSpeed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.labelAboutTime);
            this.Controls.Add(this.textBoxAboutTask);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportT2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelAboutTime;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxAboutTask;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAvgSpeed;
        private System.Windows.Forms.TextBox textBoxConeyorIdle;
        private System.Windows.Forms.TextBox textBoxAvgSpeedQueue1;
        private System.Windows.Forms.TextBox textBoxMaxTimeIdleQueue1;
        private System.Windows.Forms.TextBox textBoxMinTimeIdleQueue1;
        private System.Windows.Forms.TextBox textBoxAvgSpeedQueue2;
        private System.Windows.Forms.TextBox textBoxMaxTimeIdleQueue2;
        private System.Windows.Forms.TextBox textBoxMinTimeIdleQueue2;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn queue1;
        private System.Windows.Forms.DataGridViewTextBoxColumn queue2;
        private System.Windows.Forms.DataGridViewTextBoxColumn countSection1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countSection2;
        private System.Windows.Forms.DataGridViewTextBoxColumn isEquipmentFree;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn countNbr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxT1;
        private System.Windows.Forms.TextBox textBoxT2;
        private System.Windows.Forms.TextBox textBoxT3;
        private System.Windows.Forms.TextBox textBoxN3;
        private System.Windows.Forms.TextBox textBoxN2;
        private System.Windows.Forms.TextBox textBoxN1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonRandomValues;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxNbrFromSection1;
        private System.Windows.Forms.TextBox textBoxNbrFromSection2;
        private System.Windows.Forms.TextBox textBoxNbr;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvReportT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnT1;
        private System.Windows.Forms.DataGridView dgvReportT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnT2;
    }
}

