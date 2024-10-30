namespace BookStore_DucND
{
    partial class frmBookManager
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
            grbBookinfor = new GroupBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            dtpReleasedDate = new DateTimePicker();
            txtDescription = new TextBox();
            txtcategory = new TextBox();
            txtAuthor = new TextBox();
            lblPrice = new Label();
            txtName = new TextBox();
            txtID = new TextBox();
            lblCategogy = new Label();
            lblAuthor = new Label();
            lblQuantity = new Label();
            lblReleasedDate = new Label();
            lblDescription = new Label();
            lblName = new Label();
            lblID = new Label();
            grbTask = new GroupBox();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            grbSearch = new GroupBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblKeyword = new Label();
            dgvBookList = new DataGridView();
            lblBM = new Label();
            lblBookList = new Label();
            grbBookinfor.SuspendLayout();
            grbTask.SuspendLayout();
            grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // grbBookinfor
            // 
            grbBookinfor.BackColor = Color.FromArgb(128, 255, 255);
            grbBookinfor.Controls.Add(txtPrice);
            grbBookinfor.Controls.Add(txtQuantity);
            grbBookinfor.Controls.Add(dtpReleasedDate);
            grbBookinfor.Controls.Add(txtDescription);
            grbBookinfor.Controls.Add(txtcategory);
            grbBookinfor.Controls.Add(txtAuthor);
            grbBookinfor.Controls.Add(lblPrice);
            grbBookinfor.Controls.Add(txtName);
            grbBookinfor.Controls.Add(txtID);
            grbBookinfor.Controls.Add(lblCategogy);
            grbBookinfor.Controls.Add(lblAuthor);
            grbBookinfor.Controls.Add(lblQuantity);
            grbBookinfor.Controls.Add(lblReleasedDate);
            grbBookinfor.Controls.Add(lblDescription);
            grbBookinfor.Controls.Add(lblName);
            grbBookinfor.Controls.Add(lblID);
            grbBookinfor.Location = new Point(12, 44);
            grbBookinfor.Name = "grbBookinfor";
            grbBookinfor.Size = new Size(422, 330);
            grbBookinfor.TabIndex = 0;
            grbBookinfor.TabStop = false;
            grbBookinfor.Text = "  Book infor  ";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(284, 200);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 15;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(109, 200);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 14;
            // 
            // dtpReleasedDate
            // 
            dtpReleasedDate.Location = new Point(109, 166);
            dtpReleasedDate.Name = "dtpReleasedDate";
            dtpReleasedDate.Size = new Size(200, 23);
            dtpReleasedDate.TabIndex = 13;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(109, 79);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(275, 73);
            txtDescription.TabIndex = 12;
            // 
            // txtcategory
            // 
            txtcategory.Location = new Point(109, 280);
            txtcategory.Name = "txtcategory";
            txtcategory.Size = new Size(275, 23);
            txtcategory.TabIndex = 11;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(109, 242);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(275, 23);
            txtAuthor.TabIndex = 10;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(232, 203);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Price:";
            // 
            // txtName
            // 
            txtName.Location = new Point(109, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(275, 23);
            txtName.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.Location = new Point(109, 19);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 7;
            // 
            // lblCategogy
            // 
            lblCategogy.AutoSize = true;
            lblCategogy.Location = new Point(19, 283);
            lblCategogy.Name = "lblCategogy";
            lblCategogy.Size = new Size(58, 15);
            lblCategogy.TabIndex = 6;
            lblCategogy.Text = "Category:";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(19, 242);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(47, 15);
            lblAuthor.TabIndex = 5;
            lblAuthor.Text = "Author:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(19, 203);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(56, 15);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity:";
            // 
            // lblReleasedDate
            // 
            lblReleasedDate.AutoSize = true;
            lblReleasedDate.Location = new Point(19, 166);
            lblReleasedDate.Name = "lblReleasedDate";
            lblReleasedDate.Size = new Size(83, 15);
            lblReleasedDate.TabIndex = 3;
            lblReleasedDate.Text = "Released Date:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(19, 82);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(19, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(19, 22);
            lblID.Name = "lblID";
            lblID.Size = new Size(21, 15);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // grbTask
            // 
            grbTask.BackColor = Color.Teal;
            grbTask.Controls.Add(btnExit);
            grbTask.Controls.Add(btnDelete);
            grbTask.Controls.Add(btnUpdate);
            grbTask.Controls.Add(btnAdd);
            grbTask.Location = new Point(12, 380);
            grbTask.Name = "grbTask";
            grbTask.Size = new Size(422, 55);
            grbTask.TabIndex = 1;
            grbTask.TabStop = false;
            grbTask.Text = "  Task  ";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.MediumSeaGreen;
            btnExit.Location = new Point(331, 22);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.MediumSeaGreen;
            btnDelete.Location = new Point(232, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumSeaGreen;
            btnUpdate.Location = new Point(125, 22);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.Location = new Point(14, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // grbSearch
            // 
            grbSearch.Controls.Add(txtSearch);
            grbSearch.Controls.Add(btnSearch);
            grbSearch.Controls.Add(lblKeyword);
            grbSearch.Location = new Point(450, 44);
            grbSearch.Name = "grbSearch";
            grbSearch.Size = new Size(336, 65);
            grbSearch.TabIndex = 2;
            grbSearch.TabStop = false;
            grbSearch.Text = "  Search  ";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(80, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(169, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(255, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new Point(18, 28);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(56, 15);
            lblKeyword.TabIndex = 0;
            lblKeyword.Text = "Keyword:";
            // 
            // dgvBookList
            // 
            dgvBookList.BackgroundColor = SystemColors.ButtonFace;
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(450, 147);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowTemplate.Height = 25;
            dgvBookList.Size = new Size(381, 288);
            dgvBookList.TabIndex = 3;
            // 
            // lblBM
            // 
            lblBM.AutoSize = true;
            lblBM.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblBM.ForeColor = Color.Lime;
            lblBM.Location = new Point(12, 0);
            lblBM.Name = "lblBM";
            lblBM.Size = new Size(182, 32);
            lblBM.TabIndex = 4;
            lblBM.Text = "Book Manager";
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookList.Location = new Point(450, 123);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(83, 21);
            lblBookList.TabIndex = 5;
            lblBookList.Text = "Book List:";
            // 
            // frmBookManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(839, 450);
            Controls.Add(lblBookList);
            Controls.Add(lblBM);
            Controls.Add(dgvBookList);
            Controls.Add(grbSearch);
            Controls.Add(grbTask);
            Controls.Add(grbBookinfor);
            Name = "frmBookManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookManager";
            FormClosed += BookManagerForm_FormClosed;
            Load += frmBookManager_Load;
            grbBookinfor.ResumeLayout(false);
            grbBookinfor.PerformLayout();
            grbTask.ResumeLayout(false);
            grbSearch.ResumeLayout(false);
            grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbBookinfor;
        private GroupBox grbTask;
        private GroupBox grbSearch;
        private DataGridView dgvBookList;
        private TextBox txtName;
        private TextBox txtID;
        private Label lblCategogy;
        private Label lblAuthor;
        private Label lblQuantity;
        private Label lblReleasedDate;
        private Label lblDescription;
        private Label lblName;
        private Label lblID;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnSearch;
        private Label lblKeyword;
        private Label lblBM;
        private Label lblPrice;
        private TextBox txtcategory;
        private TextBox txtAuthor;
        private DateTimePicker dtpReleasedDate;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtSearch;
        private Label lblBookList;
    }
}