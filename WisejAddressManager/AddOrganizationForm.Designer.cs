namespace WisejAddressManager
{
    partial class AddOrganizationForm
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
            this.NameBox = new Wisej.Web.TextBox();
            this.StreetBox = new Wisej.Web.TextBox();
            this.ZipBox = new Wisej.Web.TextBox();
            this.CityBox = new Wisej.Web.TextBox();
            this.CountryBox = new Wisej.Web.TextBox();
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
            this.ConfirmButton.DialogResult = Wisej.Web.DialogResult.OK;
            this.ConfirmButton.Location = new System.Drawing.Point(204, 195);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(125, 40);
            this.ConfirmButton.TabIndex = 5;
            this.ConfirmButton.Text = "Add Organization";
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.LightCoral;
            this.CancelButton.DialogResult = Wisej.Web.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(335, 195);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 40);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.AutoSize = false;
            this.NameBox.Label.Position = Wisej.Web.LabelPosition.Inside;
            this.NameBox.LabelText = "Organization Name";
            this.NameBox.Location = new System.Drawing.Point(25, 15);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(410, 30);
            this.NameBox.TabIndex = 0;
            // 
            // StreetBox
            // 
            this.StreetBox.AutoSize = false;
            this.StreetBox.Label.Position = Wisej.Web.LabelPosition.Inside;
            this.StreetBox.LabelText = "Street Address";
            this.StreetBox.Location = new System.Drawing.Point(25, 51);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(410, 30);
            this.StreetBox.TabIndex = 1;
            // 
            // ZipBox
            // 
            this.ZipBox.AutoSize = false;
            this.ZipBox.Label.Position = Wisej.Web.LabelPosition.Inside;
            this.ZipBox.LabelText = "Zip Code";
            this.ZipBox.Location = new System.Drawing.Point(25, 87);
            this.ZipBox.Name = "ZipBox";
            this.ZipBox.Size = new System.Drawing.Size(410, 30);
            this.ZipBox.TabIndex = 2;
            // 
            // CityBox
            // 
            this.CityBox.AutoSize = false;
            this.CityBox.Label.Position = Wisej.Web.LabelPosition.Inside;
            this.CityBox.LabelText = "City";
            this.CityBox.Location = new System.Drawing.Point(25, 123);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(410, 30);
            this.CityBox.TabIndex = 3;
            // 
            // CountryBox
            // 
            this.CountryBox.AutoSize = false;
            this.CountryBox.Label.Position = Wisej.Web.LabelPosition.Inside;
            this.CountryBox.LabelText = "Country";
            this.CountryBox.Location = new System.Drawing.Point(25, 159);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(410, 30);
            this.CountryBox.TabIndex = 4;
            // 
            // AddOrganizationForm
            // 
            this.AcceptButton = this.ConfirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(458, 263);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.InvalidMessage);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.StreetBox);
            this.Controls.Add(this.CountryBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.ZipBox);
            this.HeaderBackColor = System.Drawing.Color.FromName("@focusShadow");
            this.HeaderForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrganizationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "Add Organization";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Label InvalidMessage;
        private Wisej.Web.Button ConfirmButton;
        private new Wisej.Web.Button CancelButton;
        private Wisej.Web.TextBox NameBox;
        private Wisej.Web.TextBox StreetBox;
        private Wisej.Web.TextBox ZipBox;
        private Wisej.Web.TextBox CityBox;
        private Wisej.Web.TextBox CountryBox;
    }
}