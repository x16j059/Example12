namespace Example12
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxMonth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJudge = new System.Windows.Forms.Button();
            this.LbLResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxMonth
            // 
            this.tbxMonth.Location = new System.Drawing.Point(12, 65);
            this.tbxMonth.Name = "tbxMonth";
            this.tbxMonth.Size = new System.Drawing.Size(100, 19);
            this.tbxMonth.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "月";
            // 
            // btnJudge
            // 
            this.btnJudge.Location = new System.Drawing.Point(197, 63);
            this.btnJudge.Name = "btnJudge";
            this.btnJudge.Size = new System.Drawing.Size(75, 23);
            this.btnJudge.TabIndex = 2;
            this.btnJudge.Text = "判定";
            this.btnJudge.UseVisualStyleBackColor = true;
            this.btnJudge.Click += new System.EventHandler(this.btnJudge_Click);
            // 
            // LbLResult
            // 
            this.LbLResult.AutoSize = true;
            this.LbLResult.Location = new System.Drawing.Point(54, 162);
            this.LbLResult.Name = "LbLResult";
            this.LbLResult.Size = new System.Drawing.Size(37, 12);
            this.LbLResult.TabIndex = 3;
            this.LbLResult.Text = "(空白)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LbLResult);
            this.Controls.Add(this.btnJudge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMonth);
            this.Name = "Form1";
            this.Text = "月判定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJudge;
        private System.Windows.Forms.Label LbLResult;
    }
}

