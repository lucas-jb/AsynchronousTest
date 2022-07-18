namespace AsynchronousTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Async1.Text = "Task 1 done!";
            await Task.Delay(1000);
            Async2.Text = "Task 2 done!";
            await Task.Delay(1000);
            Async3.Text = "Task 3 done!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sync1.Text = "Task 1 done!";
            Task.Delay(1000).Wait();
            Sync2.Text = "Task 2 done!";
            Task.Delay(1000).Wait();
            Sync3.Text = "Task 3 done!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Async1.Text = "";
            Async2.Text = "";
            Async3.Text = "";
            Sync1.Text = "";
            Sync2.Text = "";
            Sync3.Text = "";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}