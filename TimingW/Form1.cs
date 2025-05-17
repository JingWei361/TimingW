namespace TimingW
{
    public partial class Form1 : Form
    {
        private int totalKeyPressCount = 0;
        // �O���ثe����ơA��l�� 60
        private int seconds = 60;
        public Form1()
        {
            InitializeComponent();
            // ��ܪ�l��Ʀb���ҤW
            labelTimer.Text = seconds.ToString();
            // 1 ��
            timer1.Interval = 1000;
            // ���U���s�I���ƥ�
            btnStart.Click += btnStart_Click;
            // ������������L�ƥ�
            this.KeyPreview = true; 
            this.KeyDown += Form1_KeyDown;
        }

        private void labelTimer_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // �]�w��Ƭ� 100
            seconds = 60;
            // ��s��ܪ����
            labelTimer.Text = seconds.ToString();
            // �Ұʭp�ɾ�
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // �C���� 1 ��
            seconds--;
            // ��s��ܪ����
            labelTimer.Text = seconds.ToString();
            // �p�G��Ƥw�� 0�A�N����p�ɨ���ܰT����
            if (seconds <= 0)
            {
                // ����p�ɾ�
                timer1.Stop();
                // ��ܹ�ܮ�
                MessageBox.Show($"�ɶ���!�`�@���F{totalKeyPressCount}�B");
            }
        }

            private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // �p�G���U���O W�BA�BS �� D ��
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.A || e.KeyCode == Keys.S || e.KeyCode == Keys.D)
            {
                totalKeyPressCount++;
                labelCount.Text = $"�B��: {totalKeyPressCount}";
            }
        }
    }
}

