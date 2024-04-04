namespace Expense_Money
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtuser = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtpass = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Expense_Money.Properties.Resources.ccx4;
            this.pictureBox1.Location = new System.Drawing.Point(75, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtuser
            // 
            this.txtuser.AllowPromptAsInput = true;
            this.txtuser.AnimateReadOnly = false;
            this.txtuser.AsciiOnly = false;
            this.txtuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtuser.BeepOnError = false;
            this.txtuser.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtuser.Depth = 0;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtuser.HidePromptOnLeave = false;
            this.txtuser.HideSelection = true;
            this.txtuser.Hint = "User Name";
            this.txtuser.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtuser.LeadingIcon = null;
            this.txtuser.Location = new System.Drawing.Point(25, 256);
            this.txtuser.Mask = "";
            this.txtuser.MaxLength = 32767;
            this.txtuser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtuser.Name = "txtuser";
            this.txtuser.PasswordChar = '\0';
            this.txtuser.PrefixSuffixText = null;
            this.txtuser.PromptChar = '_';
            this.txtuser.ReadOnly = false;
            this.txtuser.RejectInputOnFirstFailure = false;
            this.txtuser.ResetOnPrompt = true;
            this.txtuser.ResetOnSpace = true;
            this.txtuser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtuser.SelectedText = "";
            this.txtuser.SelectionLength = 0;
            this.txtuser.SelectionStart = 0;
            this.txtuser.ShortcutsEnabled = true;
            this.txtuser.Size = new System.Drawing.Size(255, 48);
            this.txtuser.SkipLiterals = true;
            this.txtuser.TabIndex = 7;
            this.txtuser.TabStop = false;
            this.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtuser.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtuser.TrailingIcon = null;
            this.txtuser.UseSystemPasswordChar = false;
            this.txtuser.ValidatingType = null;
            // 
            // txtpass
            // 
            this.txtpass.AllowPromptAsInput = true;
            this.txtpass.AnimateReadOnly = false;
            this.txtpass.AsciiOnly = false;
            this.txtpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtpass.BeepOnError = false;
            this.txtpass.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtpass.Depth = 0;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtpass.HidePromptOnLeave = false;
            this.txtpass.HideSelection = true;
            this.txtpass.Hint = "Password";
            this.txtpass.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtpass.LeadingIcon = null;
            this.txtpass.Location = new System.Drawing.Point(25, 310);
            this.txtpass.Mask = "";
            this.txtpass.MaxLength = 32767;
            this.txtpass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '●';
            this.txtpass.PrefixSuffixText = null;
            this.txtpass.PromptChar = '_';
            this.txtpass.ReadOnly = false;
            this.txtpass.RejectInputOnFirstFailure = false;
            this.txtpass.ResetOnPrompt = true;
            this.txtpass.ResetOnSpace = true;
            this.txtpass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtpass.SelectedText = "";
            this.txtpass.SelectionLength = 0;
            this.txtpass.SelectionStart = 0;
            this.txtpass.ShortcutsEnabled = true;
            this.txtpass.Size = new System.Drawing.Size(255, 48);
            this.txtpass.SkipLiterals = true;
            this.txtpass.TabIndex = 8;
            this.txtpass.TabStop = false;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpass.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtpass.TrailingIcon = null;
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.ValidatingType = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Lao", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login to Expenses ";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Tomato;
            this.btnexit.Location = new System.Drawing.Point(153, 364);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(127, 50);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "EXIT";
            this.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.LimeGreen;
            this.btnlogin.Location = new System.Drawing.Point(23, 364);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(124, 50);
            this.btnlogin.TabIndex = 10;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 513);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogin);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtuser;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnlogin;
    }
}