using BookStore_Repository.Entities;
using Services;

namespace BookStore_DucND
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            BookManagementMemberService se = new BookManagementMemberService();
            BookManagementMember account = se.CheckLogin(email, password);
            if (account == null)
            {
                MessageBox.Show("Login lỗi", "Lỗi đăng nhập",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (account.MemberRole != 1)
            {
                MessageBox.Show("Bạn không phải admin", "Lỗi đăng nhập",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmBookManager bookMgt = new frmBookManager();
            bookMgt.Show();
            this.Hide();
        }
    }
}