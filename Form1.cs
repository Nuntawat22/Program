namespace Program
{
    public partial class Form1 : Form
    {
        Player _newPlayer;
        public Form1()
        {
            InitializeComponent();
        }

        private void SM_Click(object sender, EventArgs e)
        {
            string name = tbN.Text;
            string lastname = tbN2.Text;
            string studentid = tbID.Text;
            string mail = tbmail.Text;
            string phone = tbphone.Text;
            string major = tbmajor.Text;
            string displayname = tbNgame.Text;
            int iAge = 0;

            try
            {
                string age = tbage.Text;
                iAge= Int32.Parse(age);
                /*_newPlayer = new Player(name, lastname, studentid, major, displayname, mail, phone, iAge);*/
                /*this.DialogResult = DialogResult.OK;
                this.Close();*/
            }
            catch(FormatException ex){
                //Do something if have some exception
                MessageBox.Show("คุณใส่ข้อมูลไม่ถูกต้อง");
                return;
            }
            Player player = new Player(name, lastname, studentid, major, displayname, mail, phone, iAge);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public Player getPlayer() 
        { 
            return _newPlayer; 
        }
    }
}