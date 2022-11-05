namespace BiometricsTest.Controls
{
    partial class FingerPrintControl
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
            this.lblDeviceStatus = new System.Windows.Forms.Label();
            this.btnInit = new System.Windows.Forms.Button();
            this.lblFingerPrintCount = new System.Windows.Forms.Label();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.cmbIdx = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.picFPImg = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFree = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFPImg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeviceStatus
            // 
            this.lblDeviceStatus.AutoEllipsis = true;
            this.lblDeviceStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDeviceStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(204)))), ((int)(((byte)(240)))));
            this.lblDeviceStatus.Location = new System.Drawing.Point(358, 183);
            this.lblDeviceStatus.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDeviceStatus.Name = "lblDeviceStatus";
            this.lblDeviceStatus.Padding = new System.Windows.Forms.Padding(0, 4, 5, 0);
            this.lblDeviceStatus.Size = new System.Drawing.Size(298, 36);
            this.lblDeviceStatus.TabIndex = 792;
            this.lblDeviceStatus.Text = "Disconnected";
            // 
            // btnInit
            // 
            this.btnInit.BackColor = System.Drawing.Color.White;
            this.btnInit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInit.ForeColor = System.Drawing.Color.Black;
            this.btnInit.Location = new System.Drawing.Point(6, 19);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(125, 37);
            this.btnInit.TabIndex = 1;
            this.btnInit.Text = "Initialize Device";
            this.btnInit.UseVisualStyleBackColor = false;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // lblFingerPrintCount
            // 
            this.lblFingerPrintCount.AutoSize = true;
            this.lblFingerPrintCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblFingerPrintCount.Location = new System.Drawing.Point(679, 380);
            this.lblFingerPrintCount.Name = "lblFingerPrintCount";
            this.lblFingerPrintCount.Size = new System.Drawing.Size(42, 46);
            this.lblFingerPrintCount.TabIndex = 793;
            this.lblFingerPrintCount.Text = "3";
            // 
            // btnEnroll
            // 
            this.btnEnroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(204)))), ((int)(((byte)(240)))));
            this.btnEnroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnroll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(204)))), ((int)(((byte)(240)))));
            this.btnEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnroll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEnroll.ForeColor = System.Drawing.Color.White;
            this.btnEnroll.Location = new System.Drawing.Point(267, 20);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(138, 36);
            this.btnEnroll.TabIndex = 767;
            this.btnEnroll.Text = "Click To Enroll";
            this.btnEnroll.UseVisualStyleBackColor = false;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // cmbIdx
            // 
            this.cmbIdx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdx.FormattingEnabled = true;
            this.cmbIdx.Location = new System.Drawing.Point(492, 310);
            this.cmbIdx.Name = "cmbIdx";
            this.cmbIdx.Size = new System.Drawing.Size(40, 21);
            this.cmbIdx.TabIndex = 787;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.label43.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label43.Location = new System.Drawing.Point(358, 312);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(112, 15);
            this.label43.TabIndex = 788;
            this.label43.Text = "Available Devices :";
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.White;
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVerify.ForeColor = System.Drawing.Color.Black;
            this.btnVerify.Location = new System.Drawing.Point(492, 371);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(138, 34);
            this.btnVerify.TabIndex = 789;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            // 
            // btnIdentify
            // 
            this.btnIdentify.BackColor = System.Drawing.Color.White;
            this.btnIdentify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIdentify.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnIdentify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdentify.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIdentify.ForeColor = System.Drawing.Color.Black;
            this.btnIdentify.Location = new System.Drawing.Point(662, 192);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(98, 34);
            this.btnIdentify.TabIndex = 790;
            this.btnIdentify.Text = "Identify User";
            this.btnIdentify.UseVisualStyleBackColor = false;
            this.btnIdentify.Visible = false;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            // 
            // picFPImg
            // 
            this.picFPImg.BackColor = System.Drawing.Color.Transparent;
            this.picFPImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFPImg.Location = new System.Drawing.Point(361, 340);
            this.picFPImg.Name = "picFPImg";
            this.picFPImg.Size = new System.Drawing.Size(125, 129);
            this.picFPImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFPImg.TabIndex = 791;
            this.picFPImg.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(112)))), ((int)(((byte)(134)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(112)))), ((int)(((byte)(134)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(137, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 36);
            this.btnClose.TabIndex = 777;
            this.btnClose.Text = "Disconnect Device";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFree
            // 
            this.btnFree.BackColor = System.Drawing.Color.White;
            this.btnFree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFree.Enabled = false;
            this.btnFree.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnFree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFree.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFree.ForeColor = System.Drawing.Color.Black;
            this.btnFree.Location = new System.Drawing.Point(492, 411);
            this.btnFree.Name = "btnFree";
            this.btnFree.Size = new System.Drawing.Size(138, 34);
            this.btnFree.TabIndex = 795;
            this.btnFree.Text = "Free Resources";
            this.btnFree.UseVisualStyleBackColor = false;
            this.btnFree.Click += new System.EventHandler(this.btnFree_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInit);
            this.groupBox1.Controls.Add(this.btnEnroll);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(355, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 66);
            this.groupBox1.TabIndex = 794;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // FingerPrintControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDeviceStatus);
            this.Controls.Add(this.lblFingerPrintCount);
            this.Controls.Add(this.cmbIdx);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnIdentify);
            this.Controls.Add(this.picFPImg);
            this.Controls.Add(this.btnFree);
            this.Controls.Add(this.groupBox1);
            this.Name = "FingerPrintControl";
            this.Size = new System.Drawing.Size(1128, 652);
            ((System.ComponentModel.ISupportInitialize)(this.picFPImg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeviceStatus;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Label lblFingerPrintCount;
        private System.Windows.Forms.Button btnEnroll;
        public System.Windows.Forms.ComboBox cmbIdx;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.PictureBox picFPImg;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFree;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
