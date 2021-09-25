
namespace SPP_2
{
    partial class ResizeForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.widthLab = new System.Windows.Forms.Label();
            this.heightLab = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.ResizeBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.tableLayoutPanel1.Controls.Add(this.widthLab, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.heightLab, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.widthBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.heightBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ResizeBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CancelBtn, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(271, 124);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // widthLab
            // 
            this.widthLab.AutoSize = true;
            this.widthLab.Dock = System.Windows.Forms.DockStyle.Left;
            this.widthLab.Location = new System.Drawing.Point(3, 0);
            this.widthLab.Name = "widthLab";
            this.widthLab.Size = new System.Drawing.Size(60, 45);
            this.widthLab.TabIndex = 0;
            this.widthLab.Text = "New width:";
            // 
            // heightLab
            // 
            this.heightLab.AutoSize = true;
            this.heightLab.Dock = System.Windows.Forms.DockStyle.Left;
            this.heightLab.Location = new System.Drawing.Point(3, 45);
            this.heightLab.Name = "heightLab";
            this.heightLab.Size = new System.Drawing.Size(64, 45);
            this.heightLab.TabIndex = 1;
            this.heightLab.Text = "New height:";
            // 
            // widthBox
            // 
            this.widthBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.widthBox.Location = new System.Drawing.Point(137, 3);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(131, 20);
            this.widthBox.TabIndex = 2;
            this.widthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // heightBox
            // 
            this.heightBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heightBox.Location = new System.Drawing.Point(137, 48);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(131, 20);
            this.heightBox.TabIndex = 3;
            this.heightBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // ResizeBtn
            // 
            this.ResizeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResizeBtn.Location = new System.Drawing.Point(3, 93);
            this.ResizeBtn.Name = "ResizeBtn";
            this.ResizeBtn.Size = new System.Drawing.Size(128, 28);
            this.ResizeBtn.TabIndex = 4;
            this.ResizeBtn.Text = "Resize";
            this.ResizeBtn.UseVisualStyleBackColor = true;
            this.ResizeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ResizeBtn_MouseClick);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelBtn.Location = new System.Drawing.Point(137, 93);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(131, 28);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CancelBtn_MouseClick);
            // 
            // ResizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 124);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResizeForm";
            this.Text = "Resize";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label widthLab;
        private System.Windows.Forms.Label heightLab;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Button ResizeBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}