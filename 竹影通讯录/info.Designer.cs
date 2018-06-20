namespace 竹影通讯录
{
    partial class info
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
            this.Guanyu = new CCWin.SkinControl.SkinLabel();
            this.Guanyu2 = new CCWin.SkinControl.SkinLabel();
            this.Guanyu3 = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // Guanyu
            // 
            this.Guanyu.BackColor = System.Drawing.Color.Transparent;
            this.Guanyu.BorderColor = System.Drawing.Color.White;
            this.Guanyu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Guanyu.Location = new System.Drawing.Point(31, 45);
            this.Guanyu.Name = "Guanyu";
            this.Guanyu.Size = new System.Drawing.Size(300, 30);
            this.Guanyu.TabIndex = 0;
            // 
            // Guanyu2
            // 
            this.Guanyu2.BackColor = System.Drawing.Color.Transparent;
            this.Guanyu2.BorderColor = System.Drawing.Color.White;
            this.Guanyu2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Guanyu2.Location = new System.Drawing.Point(31, 75);
            this.Guanyu2.Name = "Guanyu2";
            this.Guanyu2.Size = new System.Drawing.Size(300, 30);
            this.Guanyu2.TabIndex = 1;
            // 
            // Guanyu3
            // 
            this.Guanyu3.BackColor = System.Drawing.Color.Transparent;
            this.Guanyu3.BorderColor = System.Drawing.Color.White;
            this.Guanyu3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Guanyu3.Location = new System.Drawing.Point(31, 105);
            this.Guanyu3.Name = "Guanyu3";
            this.Guanyu3.Size = new System.Drawing.Size(300, 30);
            this.Guanyu3.TabIndex = 2;
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 176);
            this.Controls.Add(this.Guanyu3);
            this.Controls.Add(this.Guanyu2);
            this.Controls.Add(this.Guanyu);
            this.Name = "info";
            this.Text = "关于";
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinLabel Guanyu;
        private CCWin.SkinControl.SkinLabel Guanyu2;
        private CCWin.SkinControl.SkinLabel Guanyu3;
    }
}