namespace IPCameraViever1._0
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdMinimize = new System.Windows.Forms.Button();
            this.cmdMaximize = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdWindow = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlIPInput = new System.Windows.Forms.FlowLayoutPanel();
            this.lblIPAdress = new System.Windows.Forms.Label();
            this.txtIPInput = new System.Windows.Forms.TextBox();
            this.imgOutput = new System.Windows.Forms.PictureBox();
            this.pnlDrag = new System.Windows.Forms.Panel();
            this.pnlControls.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlIPInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(3, 3);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(100, 45);
            this.cmdStart.TabIndex = 1;
            this.cmdStart.Text = "start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(3, 54);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(100, 45);
            this.cmdStop.TabIndex = 2;
            this.cmdStop.Text = "stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(3, 105);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(100, 45);
            this.cmdClose.TabIndex = 5;
            this.cmdClose.Text = "close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdMinimize
            // 
            this.cmdMinimize.Location = new System.Drawing.Point(3, 156);
            this.cmdMinimize.Name = "cmdMinimize";
            this.cmdMinimize.Size = new System.Drawing.Size(100, 45);
            this.cmdMinimize.TabIndex = 6;
            this.cmdMinimize.Text = "minimize";
            this.cmdMinimize.UseVisualStyleBackColor = true;
            this.cmdMinimize.Click += new System.EventHandler(this.cmdMinimize_Click);
            // 
            // cmdMaximize
            // 
            this.cmdMaximize.Location = new System.Drawing.Point(3, 207);
            this.cmdMaximize.Name = "cmdMaximize";
            this.cmdMaximize.Size = new System.Drawing.Size(100, 45);
            this.cmdMaximize.TabIndex = 7;
            this.cmdMaximize.Text = "maximize";
            this.cmdMaximize.UseVisualStyleBackColor = true;
            this.cmdMaximize.Click += new System.EventHandler(this.cmdMaximize_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.cmdStart);
            this.pnlControls.Controls.Add(this.cmdStop);
            this.pnlControls.Controls.Add(this.cmdClose);
            this.pnlControls.Controls.Add(this.cmdMinimize);
            this.pnlControls.Controls.Add(this.cmdMaximize);
            this.pnlControls.Controls.Add(this.cmdWindow);
            this.pnlControls.Controls.Add(this.pnlDrag);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControls.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlControls.Location = new System.Drawing.Point(772, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(106, 494);
            this.pnlControls.TabIndex = 8;
            // 
            // cmdWindow
            // 
            this.cmdWindow.Location = new System.Drawing.Point(3, 258);
            this.cmdWindow.Name = "cmdWindow";
            this.cmdWindow.Size = new System.Drawing.Size(100, 45);
            this.cmdWindow.TabIndex = 8;
            this.cmdWindow.Text = "window";
            this.cmdWindow.UseVisualStyleBackColor = true;
            this.cmdWindow.Click += new System.EventHandler(this.cmdWindow_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlIPInput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.imgOutput, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 494);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // pnlIPInput
            // 
            this.pnlIPInput.Controls.Add(this.lblIPAdress);
            this.pnlIPInput.Controls.Add(this.txtIPInput);
            this.pnlIPInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlIPInput.Location = new System.Drawing.Point(3, 457);
            this.pnlIPInput.Name = "pnlIPInput";
            this.pnlIPInput.Size = new System.Drawing.Size(766, 34);
            this.pnlIPInput.TabIndex = 13;
            // 
            // lblIPAdress
            // 
            this.lblIPAdress.AutoSize = true;
            this.lblIPAdress.Location = new System.Drawing.Point(3, 0);
            this.lblIPAdress.Name = "lblIPAdress";
            this.lblIPAdress.Size = new System.Drawing.Size(152, 20);
            this.lblIPAdress.TabIndex = 6;
            this.lblIPAdress.Text = "IP Adress (with port)";
            // 
            // txtIPInput
            // 
            this.txtIPInput.Location = new System.Drawing.Point(161, 3);
            this.txtIPInput.Name = "txtIPInput";
            this.txtIPInput.Size = new System.Drawing.Size(207, 26);
            this.txtIPInput.TabIndex = 5;
            // 
            // imgOutput
            // 
            this.imgOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgOutput.Location = new System.Drawing.Point(3, 3);
            this.imgOutput.Name = "imgOutput";
            this.imgOutput.Size = new System.Drawing.Size(766, 448);
            this.imgOutput.TabIndex = 12;
            this.imgOutput.TabStop = false;
            // 
            // pnlDrag
            // 
            this.pnlDrag.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlDrag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDrag.BackgroundImage")));
            this.pnlDrag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDrag.Location = new System.Drawing.Point(3, 309);
            this.pnlDrag.Name = "pnlDrag";
            this.pnlDrag.Size = new System.Drawing.Size(100, 182);
            this.pnlDrag.TabIndex = 14;
            this.pnlDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDOwn_event);
            this.pnlDrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_event);
            this.pnlDrag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_event);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 494);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlControls);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlControls.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlIPInput.ResumeLayout(false);
            this.pnlIPInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdMinimize;
        private System.Windows.Forms.Button cmdMaximize;
        private System.Windows.Forms.FlowLayoutPanel pnlControls;
        private System.Windows.Forms.Button cmdWindow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel pnlIPInput;
        private System.Windows.Forms.Label lblIPAdress;
        private System.Windows.Forms.TextBox txtIPInput;
        private System.Windows.Forms.PictureBox imgOutput;
        private System.Windows.Forms.Panel pnlDrag;
    }
}

