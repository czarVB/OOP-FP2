namespace Final_Project_GUI
{
    partial class frmBoard
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
            this.pnlPlayerHand = new System.Windows.Forms.Panel();
            this.pnlOpponentHand = new System.Windows.Forms.Panel();
            this.pnlPlayArea = new System.Windows.Forms.Panel();
            this.pnlTalon = new System.Windows.Forms.Panel();
            this.pbTrumpSuit = new System.Windows.Forms.PictureBox();
            this.pbTalon = new System.Windows.Forms.PictureBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.pnlTalon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrumpSuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTalon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPlayerHand
            // 
            this.pnlPlayerHand.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlPlayerHand.Location = new System.Drawing.Point(12, 493);
            this.pnlPlayerHand.Name = "pnlPlayerHand";
            this.pnlPlayerHand.Size = new System.Drawing.Size(1326, 176);
            this.pnlPlayerHand.TabIndex = 0;
            this.pnlPlayerHand.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
            this.pnlPlayerHand.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // pnlOpponentHand
            // 
            this.pnlOpponentHand.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlOpponentHand.Location = new System.Drawing.Point(12, 12);
            this.pnlOpponentHand.Name = "pnlOpponentHand";
            this.pnlOpponentHand.Size = new System.Drawing.Size(1326, 176);
            this.pnlOpponentHand.TabIndex = 1;
            // 
            // pnlPlayArea
            // 
            this.pnlPlayArea.BackColor = System.Drawing.Color.DarkGray;
            this.pnlPlayArea.Location = new System.Drawing.Point(12, 208);
            this.pnlPlayArea.Name = "pnlPlayArea";
            this.pnlPlayArea.Size = new System.Drawing.Size(1078, 264);
            this.pnlPlayArea.TabIndex = 2;
            this.pnlPlayArea.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
            this.pnlPlayArea.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // pnlTalon
            // 
            this.pnlTalon.Controls.Add(this.pbTrumpSuit);
            this.pnlTalon.Controls.Add(this.pbTalon);
            this.pnlTalon.Controls.Add(this.btnAction);
            this.pnlTalon.Location = new System.Drawing.Point(1096, 208);
            this.pnlTalon.Name = "pnlTalon";
            this.pnlTalon.Size = new System.Drawing.Size(242, 264);
            this.pnlTalon.TabIndex = 3;
            // 
            // pbTrumpSuit
            // 
            this.pbTrumpSuit.Location = new System.Drawing.Point(124, 3);
            this.pbTrumpSuit.Name = "pbTrumpSuit";
            this.pbTrumpSuit.Size = new System.Drawing.Size(115, 176);
            this.pbTrumpSuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrumpSuit.TabIndex = 2;
            this.pbTrumpSuit.TabStop = false;
            // 
            // pbTalon
            // 
            this.pbTalon.Location = new System.Drawing.Point(3, 3);
            this.pbTalon.Name = "pbTalon";
            this.pbTalon.Size = new System.Drawing.Size(115, 176);
            this.pbTalon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTalon.TabIndex = 1;
            this.pbTalon.TabStop = false;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(3, 185);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(236, 76);
            this.btnAction.TabIndex = 0;
            this.btnAction.Text = "Pass";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // frmBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 681);
            this.Controls.Add(this.pnlTalon);
            this.Controls.Add(this.pnlPlayArea);
            this.Controls.Add(this.pnlOpponentHand);
            this.Controls.Add(this.pnlPlayerHand);
            this.Name = "frmBoard";
            this.Text = "Durak";
            this.Load += new System.EventHandler(this.frmBoard_Load);
            this.pnlTalon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrumpSuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTalon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlayerHand;
        private System.Windows.Forms.Panel pnlOpponentHand;
        private System.Windows.Forms.Panel pnlPlayArea;
        private System.Windows.Forms.Panel pnlTalon;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.PictureBox pbTrumpSuit;
        private System.Windows.Forms.PictureBox pbTalon;
    }
}

