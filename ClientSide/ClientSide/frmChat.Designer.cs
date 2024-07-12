namespace ClientSide
{
    partial class frmChat
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
            this.rtbAllMsgs = new System.Windows.Forms.RichTextBox();
            this.rtbMsg = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbAllMsgs
            // 
            this.rtbAllMsgs.Location = new System.Drawing.Point(12, 12);
            this.rtbAllMsgs.Name = "rtbAllMsgs";
            this.rtbAllMsgs.ReadOnly = true;
            this.rtbAllMsgs.Size = new System.Drawing.Size(776, 358);
            this.rtbAllMsgs.TabIndex = 0;
            this.rtbAllMsgs.Text = "";
            // 
            // rtbMsg
            // 
            this.rtbMsg.Location = new System.Drawing.Point(12, 376);
            this.rtbMsg.Name = "rtbMsg";
            this.rtbMsg.Size = new System.Drawing.Size(684, 35);
            this.rtbMsg.TabIndex = 1;
            this.rtbMsg.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(701, 376);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(85, 35);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // frmChat
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtbMsg);
            this.Controls.Add(this.rtbAllMsgs);
            this.Name = "frmChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAllMsgs;
        private System.Windows.Forms.RichTextBox rtbMsg;
        private System.Windows.Forms.Button btnSend;
    }
}