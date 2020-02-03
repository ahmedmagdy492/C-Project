namespace testingServer
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.lsRooms = new System.Windows.Forms.ListBox();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(38, 249);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lsRooms
            // 
            this.lsRooms.FormattingEnabled = true;
            this.lsRooms.Location = new System.Drawing.Point(26, 12);
            this.lsRooms.Name = "lsRooms";
            this.lsRooms.Size = new System.Drawing.Size(490, 225);
            this.lsRooms.TabIndex = 1;
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Location = new System.Drawing.Point(412, 243);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(104, 23);
            this.btnCreateRoom.TabIndex = 2;
            this.btnCreateRoom.Text = "Create Room";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 308);
            this.Controls.Add(this.btnCreateRoom);
            this.Controls.Add(this.lsRooms);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox lsRooms;
        private System.Windows.Forms.Button btnCreateRoom;
    }
}

