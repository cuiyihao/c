namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.BXS = new System.Windows.Forms.Button();
			this.TXS = new System.Windows.Forms.TextBox();
			this.BIJ = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BXS
			// 
			this.BXS.Location = new System.Drawing.Point(66, 340);
			this.BXS.Name = "BXS";
			this.BXS.Size = new System.Drawing.Size(157, 64);
			this.BXS.TabIndex = 0;
			this.BXS.Text = "文章显示";
			this.BXS.UseVisualStyleBackColor = true;
			this.BXS.Click += new System.EventHandler(this.BXS_Click);
			// 
			// TXS
			// 
			this.TXS.Location = new System.Drawing.Point(66, 36);
			this.TXS.Multiline = true;
			this.TXS.Name = "TXS";
			this.TXS.Size = new System.Drawing.Size(682, 265);
			this.TXS.TabIndex = 1;
			// 
			// BIJ
			// 
			this.BIJ.Location = new System.Drawing.Point(488, 340);
			this.BIJ.Name = "BIJ";
			this.BIJ.Size = new System.Drawing.Size(156, 63);
			this.BIJ.TabIndex = 2;
			this.BIJ.Text = "显示统计";
			this.BIJ.UseVisualStyleBackColor = true;
			this.BIJ.Click += new System.EventHandler(this.BIJ_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.BIJ);
			this.Controls.Add(this.TXS);
			this.Controls.Add(this.BXS);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BXS;
		private System.Windows.Forms.TextBox TXS;
		private System.Windows.Forms.Button BIJ;
	}
}

