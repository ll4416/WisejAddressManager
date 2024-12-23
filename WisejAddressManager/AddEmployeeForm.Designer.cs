namespace WisejAddressManager
{
    partial class AddEmployeeForm
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

        #region Wisej.NET Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InvalidMessage = new Wisej.Web.Label();
            this.ConfirmButton = new Wisej.Web.Button();
            this.CancelButton = new Wisej.Web.Button();
            this.TitleBox = new Wisej.Web.TextBox();
            this.FirstNameBox = new Wisej.Web.TextBox();
            this.LastNameBox = new Wisej.Web.TextBox();
            this.PhoneNumberBox = new Wisej.Web.TextBox();
            this.EmailBox = new Wisej.Web.TextBox();
            this.SuspendLayout();
            // 
            // InvalidMessage
            // 
            this.InvalidMessage.AutoSize = true;
            this.InvalidMessage.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.InvalidMessage.ForeColor = System.Drawing.Color.FromName("@danger");
            this.InvalidMessage.Location = new System.Drawing.Point(37, 208);
            this.InvalidMessage.Name = "InvalidMessage";
            this.InvalidMessage.Size = new System.Drawing.Size(150, 18);
            this.InvalidMessage.TabIndex = 6;
            this.InvalidMessage.Text = "All Fields Must Be Filled";
            this.InvalidMessage.Visible = false;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.LightGreen;
            this.ConfirmButton.Location = new System.Drawing.Point(204, 195);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(125, 40);
            this.ConfirmButton.TabIndex = 5;
            this.ConfirmButton.Text = "Add Employee";
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.LightCoral;
            this.CancelButton.Location = new System.Drawing.Point(335, 195);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 40);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TitleBox
            // 
            this.TitleBox.AutoSize = false;
            this.TitleBox.Label.Position = Wisej.Web.LabelPosition.Inside;
            this.TitleBox.LabelText = "Title";
            this.TitleBox.Location = new System.Drawing.Point(25, 15);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(410, 30);
            this.TitleBox.TabIndex = 0;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.AutoSize = false;
            this.FirstNameBox.Label.Position = Wisej.Web.LabelPosition.Inside;
            this.FirstNameBox.LabelText = "First Name";
            this.FirstNameBox.Location = new System.Drawing.Point(25, 51);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(410, 30);
            this.FirstNameBox.TabIndex = 1;
            // 
            // LastNameBox
            // 
            this.LastNameBox.AutoSize = false;
            this.LastNameBox.Label.Position = Wisej.Web.LabelPosition.Inside;
            this.LastNameBox.LabelText = "Last Name";
            this.LastNameBox.Location = new System.Drawing.Point(25, 87);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(410, 30);
            this.LastNameBox.TabIndex = 2;
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.AutoSize = false;
            this.PhoneNumberBox.Label.Position = Wisej.Web.LabelPosition.Inside;
            this.PhoneNumberBox.LabelText = "Phone Number";
            this.PhoneNumberBox.Location = new System.Drawing.Point(25, 123);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(410, 30);
            this.PhoneNumberBox.TabIndex = 3;
            // 
            // EmailBox
            // 
            this.EmailBox.AutoSize = false;
            this.EmailBox.Label.Position = Wisej.Web.LabelPosition.Inside;
            this.EmailBox.LabelText = "Email";
            this.EmailBox.Location = new System.Drawing.Point(25, 159);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(410, 30);
            this.EmailBox.TabIndex = 4;
            // 
            // AddEmployeeForm
            // 
            this.AcceptButton = this.ConfirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(458, 263);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.InvalidMessage);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.PhoneNumberBox);
            this.Controls.Add(this.EmailBox);
            this.HeaderBackColor = System.Drawing.Color.FromName("@focusShadow");
            this.HeaderForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEmployeeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Add Employee";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Label InvalidMessage;
        private Wisej.Web.Button ConfirmButton;
        private new Wisej.Web.Button CancelButton;
        private Wisej.Web.TextBox TitleBox;
        private Wisej.Web.TextBox FirstNameBox;
        private Wisej.Web.TextBox LastNameBox;
        private Wisej.Web.TextBox PhoneNumberBox;
        private Wisej.Web.TextBox EmailBox;
    }
}