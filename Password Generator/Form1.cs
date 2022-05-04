namespace Password_Generator
{
    public partial class Form1 : Form
    {
        const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        const string UPPER_CASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string NUMBERIC = "1234567890";
        const string SPECIAL_CHARACTER = @"~!@#$%^&*()+=-";



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        public string PasswordGenerator(bool lowerCase, bool upperCase, bool mumberic, bool specialCharacter, int length)
        {


            char[] password = new char[length];
            string charSet = "";
            System.Random _random = new Random();
            
            if (lowerCase)
                charSet += LOWER_CASE;
            if (upperCase)
                charSet += UPPER_CASE;
            if (mumberic)
                charSet += NUMBERIC;
            if (specialCharacter)
                charSet += SPECIAL_CHARACTER;
            
            for (int i = 0; i < length; i++)
                password[i] = charSet[_random.Next(charSet.Length - 1)];
            return string.Join(null, password);
        }

        private void button1Generate_Click(object sender, EventArgs e)
        {
            try
            {
                txtPassword.Text = PasswordGenerator(checkBox1Lower.Checked, checkBox2Upper.Checked, checkBox3Numeric.Checked, checkBox4Special.Checked, int.Parse(txtPasswordLength.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}