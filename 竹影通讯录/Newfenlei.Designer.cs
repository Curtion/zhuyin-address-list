namespace 竹影通讯录
{
    partial class Newfenlei
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
            this.NewContent = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.NewOK = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // NewContent
            // 
            this.NewContent.BackColor = System.Drawing.Color.Transparent;
            this.NewContent.DownBack = null;
            this.NewContent.Icon = null;
            this.NewContent.IconIsButton = false;
            this.NewContent.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.NewContent.IsPasswordChat = '\0';
            this.NewContent.IsSystemPasswordChar = false;
            this.NewContent.Lines = new string[0];
            this.NewContent.Location = new System.Drawing.Point(96, 52);
            this.NewContent.Margin = new System.Windows.Forms.Padding(0);
            this.NewContent.MaxLength = 32767;
            this.NewContent.MinimumSize = new System.Drawing.Size(28, 28);
            this.NewContent.MouseBack = null;
            this.NewContent.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.NewContent.Multiline = false;
            this.NewContent.Name = "NewContent";
            this.NewContent.NormlBack = null;
            this.NewContent.Padding = new System.Windows.Forms.Padding(5);
            this.NewContent.ReadOnly = false;
            this.NewContent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NewContent.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.NewContent.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewContent.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewContent.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.NewContent.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.NewContent.SkinTxt.Name = "BaseText";
            this.NewContent.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.NewContent.SkinTxt.TabIndex = 0;
            this.NewContent.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.NewContent.SkinTxt.WaterText = "";
            this.NewContent.TabIndex = 0;
            this.NewContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NewContent.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.NewContent.WaterText = "";
            this.NewContent.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(25, 58);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(68, 17);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "分组名称：";
            // 
            // NewOK
            // 
            this.NewOK.BackColor = System.Drawing.Color.Transparent;
            this.NewOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.NewOK.DownBack = null;
            this.NewOK.Location = new System.Drawing.Point(28, 99);
            this.NewOK.MouseBack = null;
            this.NewOK.Name = "NewOK";
            this.NewOK.NormlBack = null;
            this.NewOK.Size = new System.Drawing.Size(253, 67);
            this.NewOK.TabIndex = 2;
            this.NewOK.Text = "新建分组";
            this.NewOK.UseVisualStyleBackColor = false;
            this.NewOK.Click += new System.EventHandler(this.NewOK_Click);
            // 
            // Newfenlei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 186);
            this.Controls.Add(this.NewOK);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.NewContent);
            this.Name = "Newfenlei";
            this.Text = "新建分组";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinTextBox NewContent;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinButton NewOK;
    }
}