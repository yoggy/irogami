namespace irogami
{
    partial class main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.textBoxColorCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxColorCode
            // 
            this.textBoxColorCode.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxColorCode.Location = new System.Drawing.Point(12, 12);
            this.textBoxColorCode.Name = "textBoxColorCode";
            this.textBoxColorCode.Size = new System.Drawing.Size(66, 23);
            this.textBoxColorCode.TabIndex = 0;
            this.textBoxColorCode.Text = "#3399aa";
            this.textBoxColorCode.TextChanged += new System.EventHandler(this.textBoxColorCode_TextChanged);
            this.textBoxColorCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxColorCode_KeyPress);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 163);
            this.Controls.Add(this.textBoxColorCode);
            this.Name = "main";
            this.Text = "main";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.main_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxColorCode;
    }
}

