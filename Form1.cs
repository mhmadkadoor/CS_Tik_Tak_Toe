namespace CS_Tik_Tak_Toe
{
    public partial class Form1 : Form
    {

        Boolean checker;
        int plusone;

        Boolean XorOWon = false;
        void ColorChange(char a, char b, char c, string color)
        {
            if (a == '1' || b == '1' || c == '1')
            {
                button1.BackColor = Color.FromName(color);
            }
            if (a == '2' || b == '2' || c == '2')
            {
                button2.BackColor = Color.FromName(color);
            }
            if (a == '3' || b == '3' || c == '3')
            {
                button3.BackColor = Color.FromName(color);
            }
            if (a == '4' || b == '4' || c == '4')
            {
                button4.BackColor = Color.FromName(color);
            }
            if (a == '5' || b == '5' || c == '5')
            {
                button5.BackColor = Color.FromName(color);
            }
            if (a == '6' || b == '6' || c == '6')
            {
                button6.BackColor = Color.FromName(color);
            }
            if (a == '7' || b == '7' || c == '7')
            {
                button7.BackColor = Color.FromName(color);
            }
            if (a == '8' || b == '8' || c == '8')
            {
                button8.BackColor = Color.FromName(color);
            }
            if (a == '9' || b == '9' || c == '9')
            {
                button9.BackColor = Color.FromName(color);
            }
        }

        Byte PLayedMoves = 0;

        void IsTie()
        {
            if (++PLayedMoves == 9)
            {
                ColorChange('1', '2', '3', "Yellow");
                ColorChange('4', '5', '6', "Yellow");
                ColorChange('7', '8', '9', "Yellow");
                MessageBox.Show("It's a Tie", "Tik Tak Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PLayedMoves = 0;
                ClearBoard();
            }
        }
        void Enable_False()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        void Enable_True()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }
        void ClearBoard()
        {
            try
            {
                XorOWon = false;
                checker = false;
                Enable_True();
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                button1.BackColor = Color.SpringGreen;
                button2.BackColor = Color.SpringGreen;
                button3.BackColor = Color.SpringGreen;
                button4.BackColor = Color.SpringGreen;
                button5.BackColor = Color.SpringGreen;
                button6.BackColor = Color.SpringGreen;
                button7.BackColor = Color.SpringGreen;
                button8.BackColor = Color.SpringGreen;
                button9.BackColor = Color.SpringGreen;

                PLayedMoves = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        void X_Wins()
        {
            MessageBox.Show("Player X Wins", "Tik Tak Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            plusone = int.Parse(scrPlayerX.Text);
            scrPlayerX.Text = Convert.ToString(plusone + 1);
            Enable_False();
            XorOWon = true;
        }
        void O_Wins()
        {
            MessageBox.Show("Player O Wins", "Tik Tak Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            plusone = int.Parse(scrPlayerO.Text);
            scrPlayerO.Text = Convert.ToString(plusone + 1);
            Enable_False();
            XorOWon = true;
        }
        void score()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {


                ColorChange('1', '2', '3', "Blue");

                X_Wins();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                ColorChange('4', '5', '6', "Blue");

                X_Wins();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                ColorChange('7', '8', '9', "Blue");

                X_Wins();
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                ColorChange('1', '4', '7', "Blue");

                X_Wins();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                ColorChange('2', '5', '8', "Blue");

                X_Wins();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                ColorChange('3', '6', '9', "Blue");

                X_Wins();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                ColorChange('1', '5', '9', "Blue");

                X_Wins();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                ColorChange('3', '5', '7', "Blue");

                X_Wins();
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                ColorChange('1', '2', '3', "Red");

                O_Wins();
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                ColorChange('4', '5', '6', "Red");

                O_Wins();
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                ColorChange('7', '8', '9', "Red");
                O_Wins();
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                ColorChange('1', '4', '7', "Red");
                O_Wins();
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                ColorChange('2', '5', '8', "Red");
                O_Wins();
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                ColorChange('3', '6', '9', "Red");
                O_Wins();
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                ColorChange('1', '5', '9', "Red");
                O_Wins();
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                ColorChange('3', '5', '7', "Red");
                O_Wins();
            }
            if (!XorOWon)
            {
                IsTie();
            }


        }

        void ClearScore()
        {
            scrPlayerO.Text = "0";
            scrPlayerX.Text = "0";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button1.Text = "X";
                checker = true;
            }
            else
            {
                button1.Text = "O";
                checker = false;
            }
            button1.Enabled = false;
            score();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button2.Text = "X";
                checker = true;
            }
            else
            {
                button2.Text = "O";
                checker = false;
            }
            button2.Enabled = false;
            score();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button3.Text = "X";
                checker = true;
            }
            else
            {
                button3.Text = "O";
                checker = false;
            }
            button3.Enabled = false;
            score();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button4.Text = "X";
                checker = true;
            }
            else
            {
                button4.Text = "O";
                checker = false;
            }
            button4.Enabled = false;
            score();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button5.Text = "X";
                checker = true;
            }
            else
            {
                button5.Text = "O";
                checker = false;
            }
            button5.Enabled = false;
            score();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button6.Text = "X";
                checker = true;
            }
            else
            {
                button6.Text = "O";
                checker = false;
            }
            button6.Enabled = false;
            score();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button7.Text = "X";
                checker = true;
            }
            else
            {
                button7.Text = "O";
                checker = false;
            }
            button7.Enabled = false;
            score();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button8.Text = "X";
                checker = true;
            }
            else
            {
                button8.Text = "O";
                checker = false;
            }
            button8.Enabled = false;
            score();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button9.Text = "X";
                checker = true;
            }
            else
            {
                button9.Text = "O";
                checker = false;
            }
            button9.Enabled = false;
            score();
        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            ClearBoard();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit", "Tik Tak Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Restartbtn_Click(object sender, EventArgs e)
        {
            ClearBoard();
            ClearScore();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void XPlayerIco_Click(object sender, EventArgs e)
        {

        }
    }
}
