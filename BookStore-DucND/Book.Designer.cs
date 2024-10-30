namespace BookStore_DucND
{
    partial class frmBook
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
            lblAddAndUpdate = new Label();
            grpBookinfor = new GroupBox();
            txtCategory = new TextBox();
            txtAuthor = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            dtpReleasedDate = new DateTimePicker();
            txtDescription = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            lblCategory = new Label();
            lblAuthor = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblReleasedDate = new Label();
            lblDescription = new Label();
            lblName = new Label();
            lblID = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            grpBookinfor.SuspendLayout();
            SuspendLayout();
            // 
            // lblAddAndUpdate
            // 
            lblAddAndUpdate.AutoSize = true;
            lblAddAndUpdate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddAndUpdate.Location = new Point(55, 19);
            lblAddAndUpdate.Name = "lblAddAndUpdate";
            lblAddAndUpdate.Size = new Size(219, 32);
            lblAddAndUpdate.TabIndex = 0;
            lblAddAndUpdate.Text = "Add/Update Book";
            // 
            // grpBookinfor
            // 
            grpBookinfor.BackColor = Color.FromArgb(192, 255, 192);
            grpBookinfor.Controls.Add(txtCategory);
            grpBookinfor.Controls.Add(txtAuthor);
            grpBookinfor.Controls.Add(txtPrice);
            grpBookinfor.Controls.Add(txtQuantity);
            grpBookinfor.Controls.Add(dtpReleasedDate);
            grpBookinfor.Controls.Add(txtDescription);
            grpBookinfor.Controls.Add(txtName);
            grpBookinfor.Controls.Add(txtID);
            grpBookinfor.Controls.Add(lblCategory);
            grpBookinfor.Controls.Add(lblAuthor);
            grpBookinfor.Controls.Add(lblPrice);
            grpBookinfor.Controls.Add(lblQuantity);
            grpBookinfor.Controls.Add(lblReleasedDate);
            grpBookinfor.Controls.Add(lblDescription);
            grpBookinfor.Controls.Add(lblName);
            grpBookinfor.Controls.Add(lblID);
            grpBookinfor.Location = new Point(51, 54);
            grpBookinfor.Name = "grpBookinfor";
            grpBookinfor.Size = new Size(438, 355);
            grpBookinfor.TabIndex = 1;
            grpBookinfor.TabStop = false;
            grpBookinfor.Text = "  Book Infor  ";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(113, 310);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(304, 23);
            txtCategory.TabIndex = 15;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(112, 275);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(305, 23);
            txtAuthor.TabIndex = 14;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(291, 238);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(126, 23);
            txtPrice.TabIndex = 13;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(112, 238);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 12;
            // 
            // dtpReleasedDate
            // 
            dtpReleasedDate.Location = new Point(112, 200);
            dtpReleasedDate.Name = "dtpReleasedDate";
            dtpReleasedDate.Size = new Size(200, 23);
            dtpReleasedDate.TabIndex = 11;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(112, 95);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(305, 91);
            txtDescription.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(112, 61);
            txtName.Name = "txtName";
            txtName.Size = new Size(305, 23);
            txtName.TabIndex = 9;
            // 
            // txtID
            // 
            txtID.Location = new Point(112, 27);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 8;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(23, 310);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category:";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(23, 278);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(47, 15);
            lblAuthor.TabIndex = 6;
            lblAuthor.Text = "Author:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(234, 241);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(23, 241);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity";
            // 
            // lblReleasedDate
            // 
            lblReleasedDate.AutoSize = true;
            lblReleasedDate.Location = new Point(23, 206);
            lblReleasedDate.Name = "lblReleasedDate";
            lblReleasedDate.Size = new Size(83, 15);
            lblReleasedDate.TabIndex = 3;
            lblReleasedDate.Text = "Released Date:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(23, 98);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(23, 64);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(23, 30);
            lblID.Name = "lblID";
            lblID.Size = new Size(21, 15);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 128, 0);
            btnSave.Location = new Point(317, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 0);
            btnCancel.Location = new Point(414, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(524, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grpBookinfor);
            Controls.Add(lblAddAndUpdate);
            Name = "frmBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book";
            grpBookinfor.ResumeLayout(false);
            grpBookinfor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddAndUpdate;
        private GroupBox grpBookinfor;
        private TextBox txtDescription;
        private TextBox txtName;
        private TextBox txtID;
        private Label lblCategory;
        private Label lblAuthor;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblReleasedDate;
        private Label lblDescription;
        private Label lblName;
        private Label lblID;
        private Button btnSave;
        private Button btnCancel;
        private DateTimePicker dtpReleasedDate;
        private TextBox txtCategory;
        private TextBox txtAuthor;
        private TextBox txtPrice;
        private TextBox txtQuantity;
    }
}