using System;
using System.Diagnostics;    


namespace BetterSeliwareLauncher


{
    public partial class SeliwareLauncher : Form
    {
        public SeliwareLauncher()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool Roblox = Process.GetProcessesByName("RobloxPlayerBeta").Any();
            if (Roblox = true)
            {
                Process.Start("C:\\Users\\Godot\\Desktop\\SeliwareLauncher\\SeliwareLauncher.exe");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool Multi_Instance = Process.GetProcessesByName("Multiple_ROBLOX").Any();
            if (Multi_Instance)
            {
                MessageBox.Show("Multi-Instance already running");
            }
            else
            {
                Process.Start("C:\\Users\\Godot\\Desktop\\SeliwareLauncher\\Multiple_ROBLOX.exe");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.ShowDialog();
        }
    }
}
