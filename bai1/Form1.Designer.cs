namespace bai1
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
            this.components = new System.ComponentModel.Container();
            this.txt_hienthi = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btntuchien = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_hienthi
            // 
            this.txt_hienthi.Location = new System.Drawing.Point(107, 47);
            this.txt_hienthi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_hienthi.Name = "txt_hienthi";
            this.txt_hienthi.Size = new System.Drawing.Size(345, 22);
            this.txt_hienthi.TabIndex = 0;
            this.txt_hienthi.TextChanged += new System.EventHandler(this.txt_hienthi_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btntuchien
            // 
            this.btntuchien.Location = new System.Drawing.Point(107, 123);
            this.btntuchien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntuchien.Name = "btntuchien";
            this.btntuchien.Size = new System.Drawing.Size(131, 34);
            this.btntuchien.TabIndex = 2;
            this.btntuchien.Text = "Thực hiện";
            this.btntuchien.UseVisualStyleBackColor = true;
            this.btntuchien.Click += new System.EventHandler(this.btntuchien_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(319, 123);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(135, 33);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 246);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntuchien);
            this.Controls.Add(this.txt_hienthi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_hienthi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btntuchien;
        private System.Windows.Forms.Button btnthoat;
    }
}

