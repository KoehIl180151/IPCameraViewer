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
            this.imgOutput = new System.Windows.Forms.PictureBox();
            this.pnlIPInput = new System.Windows.Forms.FlowLayoutPanel();
            this.lblIPAdress = new System.Windows.Forms.Label();
            this.txtIPInput = new System.Windows.Forms.TextBox();
            this.pnlIPInputImgOutput = new System.Windows.Forms.TableLayoutPanel();
            this.cmdWindow = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdMaximize = new System.Windows.Forms.Button();
            this.cmdMinimize = new System.Windows.Forms.Button();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.pnlDrag = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgOutput)).BeginInit();
            this.pnlIPInput.SuspendLayout();
            this.pnlIPInputImgOutput.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgOutput
            // 
            this.imgOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgOutput.Location = new System.Drawing.Point(2, 2);
            this.imgOutput.Margin = new System.Windows.Forms.Padding(2);
            this.imgOutput.Name = "imgOutput";
            this.imgOutput.Size = new System.Drawing.Size(589, 284);
            this.imgOutput.TabIndex = 12;
            this.imgOutput.TabStop = false;
            // 
            // pnlIPInput
            // 
            this.pnlIPInput.Controls.Add(this.lblIPAdress);
            this.pnlIPInput.Controls.Add(this.txtIPInput);
            this.pnlIPInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlIPInput.Location = new System.Drawing.Point(2, 290);
            this.pnlIPInput.Margin = new System.Windows.Forms.Padding(2);
            this.pnlIPInput.Name = "pnlIPInput";
            this.pnlIPInput.Size = new System.Drawing.Size(589, 22);
            this.pnlIPInput.TabIndex = 13;
            // 
            // lblIPAdress
            // 
            this.lblIPAdress.AutoSize = true;
            this.lblIPAdress.Location = new System.Drawing.Point(2, 0);
            this.lblIPAdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIPAdress.Name = "lblIPAdress";
            this.lblIPAdress.Size = new System.Drawing.Size(101, 13);
            this.lblIPAdress.TabIndex = 6;
            this.lblIPAdress.Text = "IP Adress (with port)";
            // 
            // txtIPInput
            // 
            this.txtIPInput.Location = new System.Drawing.Point(107, 2);
            this.txtIPInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtIPInput.Name = "txtIPInput";
            this.txtIPInput.Size = new System.Drawing.Size(139, 20);
            this.txtIPInput.TabIndex = 5;
            // 
            // pnlIPInputImgOutput
            // 
            this.pnlIPInputImgOutput.ColumnCount = 1;
            this.pnlIPInputImgOutput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlIPInputImgOutput.Controls.Add(this.pnlIPInput, 0, 1);
            this.pnlIPInputImgOutput.Controls.Add(this.imgOutput, 0, 0);
            this.pnlIPInputImgOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIPInputImgOutput.Location = new System.Drawing.Point(0, 36);
            this.pnlIPInputImgOutput.Margin = new System.Windows.Forms.Padding(2);
            this.pnlIPInputImgOutput.Name = "pnlIPInputImgOutput";
            this.pnlIPInputImgOutput.RowCount = 2;
            this.pnlIPInputImgOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlIPInputImgOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.pnlIPInputImgOutput.Size = new System.Drawing.Size(593, 314);
            this.pnlIPInputImgOutput.TabIndex = 13;
            // 
            // cmdWindow
            // 
            this.cmdWindow.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmdWindow.Image = ((System.Drawing.Image)(resources.GetObject("cmdWindow.Image")));
            this.cmdWindow.Location = new System.Drawing.Point(496, 2);
            this.cmdWindow.Margin = new System.Windows.Forms.Padding(2);
            this.cmdWindow.Name = "cmdWindow";
            this.cmdWindow.Size = new System.Drawing.Size(29, 29);
            this.cmdWindow.TabIndex = 8;
            this.cmdWindow.UseVisualStyleBackColor = false;
            this.cmdWindow.Click += new System.EventHandler(this.cmdWindow_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.cmdClose);
            this.pnlControls.Controls.Add(this.cmdMaximize);
            this.pnlControls.Controls.Add(this.cmdWindow);
            this.pnlControls.Controls.Add(this.cmdMinimize);
            this.pnlControls.Controls.Add(this.cmdStart);
            this.pnlControls.Controls.Add(this.cmdStop);
            this.pnlControls.Controls.Add(this.pnlDrag);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(2);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(593, 36);
            this.pnlControls.TabIndex = 8;
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmdClose.Image = ((System.Drawing.Image)(resources.GetObject("cmdClose.Image")));
            this.cmdClose.Location = new System.Drawing.Point(562, 2);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(2);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(29, 29);
            this.cmdClose.TabIndex = 5;
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdMaximize
            // 
            this.cmdMaximize.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmdMaximize.Image = ((System.Drawing.Image)(resources.GetObject("cmdMaximize.Image")));
            this.cmdMaximize.Location = new System.Drawing.Point(529, 2);
            this.cmdMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.cmdMaximize.Name = "cmdMaximize";
            this.cmdMaximize.Size = new System.Drawing.Size(29, 29);
            this.cmdMaximize.TabIndex = 7;
            this.cmdMaximize.UseVisualStyleBackColor = false;
            this.cmdMaximize.Click += new System.EventHandler(this.cmdMaximize_Click);
            // 
            // cmdMinimize
            // 
            this.cmdMinimize.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmdMinimize.Image = ((System.Drawing.Image)(resources.GetObject("cmdMinimize.Image")));
            this.cmdMinimize.Location = new System.Drawing.Point(463, 2);
            this.cmdMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.cmdMinimize.Name = "cmdMinimize";
            this.cmdMinimize.Size = new System.Drawing.Size(29, 29);
            this.cmdMinimize.TabIndex = 6;
            this.cmdMinimize.UseVisualStyleBackColor = false;
            this.cmdMinimize.Click += new System.EventHandler(this.cmdMinimize_Click);
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(392, 2);
            this.cmdStart.Margin = new System.Windows.Forms.Padding(2);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(67, 29);
            this.cmdStart.TabIndex = 1;
            this.cmdStart.Text = "start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(321, 2);
            this.cmdStop.Margin = new System.Windows.Forms.Padding(2);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(67, 29);
            this.cmdStop.TabIndex = 2;
            this.cmdStop.Text = "stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // pnlDrag
            // 
            this.pnlDrag.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlDrag.Location = new System.Drawing.Point(2, 2);
            this.pnlDrag.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDrag.Name = "pnlDrag";
            this.pnlDrag.Size = new System.Drawing.Size(315, 29);
            this.pnlDrag.TabIndex = 14;
            this.pnlDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDOwn_event);
            this.pnlDrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_event);
            this.pnlDrag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_event);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 350);
            this.Controls.Add(this.pnlIPInputImgOutput);
            this.Controls.Add(this.pnlControls);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgOutput)).EndInit();
            this.pnlIPInput.ResumeLayout(false);
            this.pnlIPInput.PerformLayout();
            this.pnlIPInputImgOutput.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgOutput;
        private System.Windows.Forms.FlowLayoutPanel pnlIPInput;
        private System.Windows.Forms.Label lblIPAdress;
        private System.Windows.Forms.TextBox txtIPInput;
        private System.Windows.Forms.TableLayoutPanel pnlIPInputImgOutput;
        private System.Windows.Forms.Button cmdWindow;
        private System.Windows.Forms.FlowLayoutPanel pnlControls;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdMinimize;
        private System.Windows.Forms.Button cmdMaximize;
        private System.Windows.Forms.Panel pnlDrag;
    }
}

