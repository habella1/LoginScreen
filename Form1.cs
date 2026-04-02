namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 2단계 추가: 에러 메시지 초기화
            lblError.Visible = false;  // 처음에는 숨김
            lblError.ForeColor = Color.Red; // 빨간색으로 표시
        }

        private void txtPw_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Text = "아이디";
                txtID.ForeColor = Color.Silver;
            }
        }

        private void txtPw_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "패스워드")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;
                txtPW.UseSystemPasswordChar = true;
            }
        }

        private void txtPw_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPW.Text))
            {
                txtPW.UseSystemPasswordChar = false;
                txtPW.Text = "패스워드";
                txtPW.ForeColor = Color.Silver;
            }
        }

        string myID = "admin";
        string myPW = "superman";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputID = txtID.Text;
            string inputPW = txtPW.Text;

            if (inputID == myID && inputPW == myPW)
            {
                MessageBox.Show("로그인 성공!");
                lblError.Visible = false; // 에러 메시지 숨기기
            }
            else
            {
                // 추가: 실패 시 Label에 메시지 표시
                lblError.Text = "아이디 또는 비밀번호가 잘못되었습니다.";
                lblError.Visible = true;
            }
        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 삑 소리 방지
                txtPW.Focus();             // 패스워드 입력창 포커스
            }

        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 삑 소리 방지
                btnLogin.PerformClick();   // 로그인 버튼 클릭 실행
            }
        }
    }
}
