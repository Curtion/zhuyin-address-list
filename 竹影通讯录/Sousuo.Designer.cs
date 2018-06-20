namespace 竹影通讯录
{
    partial class Sousuo
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
            this.SouOK = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.SuoContent = new CCWin.SkinControl.SkinTextBox();
            this.SouContent = new System.Windows.Forms.ComboBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // SouOK
            // 
            this.SouOK.BackColor = System.Drawing.Color.Transparent;
            this.SouOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.SouOK.DownBack = null;
            this.SouOK.Location = new System.Drawing.Point(35, 121);
            this.SouOK.MouseBack = null;
            this.SouOK.Name = "SouOK";
            this.SouOK.NormlBack = null;
            this.SouOK.Size = new System.Drawing.Size(233, 67);
            this.SouOK.TabIndex = 5;
            this.SouOK.Text = "立即搜索";
            this.SouOK.UseVisualStyleBackColor = false;
            this.SouOK.Click += new System.EventHandler(this.SouOK_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(32, 57);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(68, 17);
            this.skinLabel1.TabIndex = 4;
            this.skinLabel1.Text = "搜索方式：";
            // 
            // SuoContent
            // 
            this.SuoContent.BackColor = System.Drawing.Color.Transparent;
            this.SuoContent.DownBack = null;
            this.SuoContent.Icon = null;
            this.SuoContent.IconIsButton = false;
            this.SuoContent.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.SuoContent.IsPasswordChat = '\0';
            this.SuoContent.IsSystemPasswordChar = false;
            this.SuoContent.Lines = new string[0];
            this.SuoContent.Location = new System.Drawing.Point(117, 77);
            this.SuoContent.Margin = new System.Windows.Forms.Padding(0);
            this.SuoContent.MaxLength = 32767;
            this.SuoContent.MinimumSize = new System.Drawing.Size(28, 28);
            this.SuoContent.MouseBack = null;
            this.SuoContent.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.SuoContent.Multiline = false;
            this.SuoContent.Name = "SuoContent";
            this.SuoContent.NormlBack = null;
            this.SuoContent.Padding = new System.Windows.Forms.Padding(5);
            this.SuoContent.ReadOnly = false;
            this.SuoContent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SuoContent.Size = new System.Drawing.Size(151, 28);
            // 
            // 
            // 
            this.SuoContent.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SuoContent.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuoContent.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.SuoContent.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.SuoContent.SkinTxt.Name = "BaseText";
            this.SuoContent.SkinTxt.Size = new System.Drawing.Size(141, 18);
            this.SuoContent.SkinTxt.TabIndex = 0;
            this.SuoContent.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.SuoContent.SkinTxt.WaterText = "";
            this.SuoContent.TabIndex = 3;
            this.SuoContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SuoContent.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.SuoContent.WaterText = "";
            this.SuoContent.WordWrap = true;
            // 
            // SouContent
            // 
            this.SouContent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SouContent.FormattingEnabled = true;
            this.SouContent.Location = new System.Drawing.Point(117, 54);
            this.SouContent.Name = "SouContent";
            this.SouContent.Size = new System.Drawing.Size(151, 20);
            this.SouContent.TabIndex = 6;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(32, 88);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(68, 17);
            this.skinLabel2.TabIndex = 7;
            this.skinLabel2.Text = "搜索内容：";
            // 
            // Sousuo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 214);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.SouContent);
            this.Controls.Add(this.SouOK);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.SuoContent);
            this.Name = "Sousuo";
            this.Text = "搜索";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton SouOK;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox SuoContent;
        private System.Windows.Forms.ComboBox SouContent;
        private CCWin.SkinControl.SkinLabel skinLabel2;
    }
}