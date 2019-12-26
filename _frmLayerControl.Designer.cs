namespace SuperMap.Desktop.LayerControl
{
    partial class _frmLayerControl
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
            this.btnLayerControl = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLayerControl
            // 
            this.btnLayerControl.Location = new System.Drawing.Point(225, 90);
            this.btnLayerControl.Margin = new System.Windows.Forms.Padding(4);
            this.btnLayerControl.Name = "btnLayerControl";
            this.btnLayerControl.Size = new System.Drawing.Size(96, 42);
            this.btnLayerControl.TabIndex = 0;
            this.btnLayerControl.Text = "确定";
            this.btnLayerControl.UseVisualStyleBackColor = true;
            this.btnLayerControl.Click += new System.EventHandler(this.btnLayerControl_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(18, 27);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(89, 18);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "过滤条件:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(128, 22);
            this.txtX.Margin = new System.Windows.Forms.Padding(4);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(204, 28);
            this.txtX.TabIndex = 3;
            // 
            // _frmLayerControl
            // 
            this.AcceptButton = this.btnLayerControl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 150);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnLayerControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "_frmLayerControl";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图层显示";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLayerControl;
        private System.Windows.Forms.Label lblX;
        //private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtX;
        //private System.Windows.Forms.TextBox txtY;
        //private System.Windows.Forms.Timer timer1;
    }
}