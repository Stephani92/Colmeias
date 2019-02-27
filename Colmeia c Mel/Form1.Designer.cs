namespace Colmeia_c_Mel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CoBoxtarefas = new System.Windows.Forms.ComboBox();
            this.NumberShift = new System.Windows.Forms.NumericUpDown();
            this.BntAssing = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BntWork = new System.Windows.Forms.Button();
            this.TxReport = new System.Windows.Forms.TextBox();
            this.texBTotalMel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberShift)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CoBoxtarefas);
            this.groupBox1.Controls.Add(this.NumberShift);
            this.groupBox1.Controls.Add(this.BntAssing);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // CoBoxtarefas
            // 
            this.CoBoxtarefas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBoxtarefas.FormattingEnabled = true;
            this.CoBoxtarefas.Items.AddRange(new object[] {
            "Nectar collector",
            "Egg care",
            "Hive maintenance",
            "Baby bee tutoring",
            "Honey manufacturing",
            "Sting patrol"});
            this.CoBoxtarefas.Location = new System.Drawing.Point(11, 42);
            this.CoBoxtarefas.Name = "CoBoxtarefas";
            this.CoBoxtarefas.Size = new System.Drawing.Size(180, 24);
            this.CoBoxtarefas.TabIndex = 4;
            // 
            // NumberShift
            // 
            this.NumberShift.Location = new System.Drawing.Point(197, 42);
            this.NumberShift.Name = "NumberShift";
            this.NumberShift.Size = new System.Drawing.Size(120, 22);
            this.NumberShift.TabIndex = 3;
            // 
            // BntAssing
            // 
            this.BntAssing.Location = new System.Drawing.Point(10, 72);
            this.BntAssing.Name = "BntAssing";
            this.BntAssing.Size = new System.Drawing.Size(307, 32);
            this.BntAssing.TabIndex = 2;
            this.BntAssing.Text = "Assing this job to a bee";
            this.BntAssing.UseVisualStyleBackColor = true;
            this.BntAssing.Click += new System.EventHandler(this.BntAssing_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Worker bee job";
            // 
            // BntWork
            // 
            this.BntWork.Location = new System.Drawing.Point(342, 13);
            this.BntWork.Name = "BntWork";
            this.BntWork.Size = new System.Drawing.Size(75, 119);
            this.BntWork.TabIndex = 1;
            this.BntWork.Text = "Work the next shift";
            this.BntWork.UseVisualStyleBackColor = true;
            this.BntWork.Click += new System.EventHandler(this.BntWork_Click);
            // 
            // TxReport
            // 
            this.TxReport.Location = new System.Drawing.Point(2, 138);
            this.TxReport.Multiline = true;
            this.TxReport.Name = "TxReport";
            this.TxReport.Size = new System.Drawing.Size(415, 203);
            this.TxReport.TabIndex = 2;
            // 
            // texBTotalMel
            // 
            this.texBTotalMel.Location = new System.Drawing.Point(447, 126);
            this.texBTotalMel.Name = "texBTotalMel";
            this.texBTotalMel.Size = new System.Drawing.Size(100, 22);
            this.texBTotalMel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mel consumido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texBTotalMel);
            this.Controls.Add(this.TxReport);
            this.Controls.Add(this.BntWork);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CoBoxtarefas;
        private System.Windows.Forms.NumericUpDown NumberShift;
        private System.Windows.Forms.Button BntAssing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BntWork;
        private System.Windows.Forms.TextBox TxReport;
        private System.Windows.Forms.TextBox texBTotalMel;
        private System.Windows.Forms.Label label2;
    }
}

