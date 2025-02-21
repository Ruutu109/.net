
namespace Student_Details
{
    partial class frm_StudentDetail
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
            this.pnl_StudentDetail = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_StudentDetail = new System.Windows.Forms.Label();
            this.pnl_StudentDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_StudentDetail
            // 
            this.pnl_StudentDetail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_StudentDetail.AutoSize = true;
            this.pnl_StudentDetail.BackColor = System.Drawing.Color.Coral;
            this.pnl_StudentDetail.Controls.Add(this.lbl_StudentDetail);
            this.pnl_StudentDetail.Location = new System.Drawing.Point(-80, -15);
            this.pnl_StudentDetail.Name = "pnl_StudentDetail";
            this.pnl_StudentDetail.Size = new System.Drawing.Size(1167, 162);
            this.pnl_StudentDetail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lbl_StudentDetail
            // 
            this.lbl_StudentDetail.AutoSize = true;
            this.lbl_StudentDetail.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_StudentDetail.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentDetail.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_StudentDetail.Location = new System.Drawing.Point(274, 33);
            this.lbl_StudentDetail.Name = "lbl_StudentDetail";
            this.lbl_StudentDetail.Size = new System.Drawing.Size(698, 109);
            this.lbl_StudentDetail.TabIndex = 0;
            this.lbl_StudentDetail.Text = "Student Details";
            this.lbl_StudentDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_StudentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_StudentDetail);
            this.Name = "frm_StudentDetail";
            this.Text = "Student Details";
            this.pnl_StudentDetail.ResumeLayout(false);
            this.pnl_StudentDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_StudentDetail;
        private System.Windows.Forms.Label lbl_StudentDetail;
        private System.Windows.Forms.Label label1;
    }
}