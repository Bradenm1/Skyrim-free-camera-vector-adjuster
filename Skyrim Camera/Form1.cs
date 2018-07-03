using System;
using System.Windows.Forms;
using Memory;

namespace Skyrim
{
    public partial class Form1 : Form
    {
        private const String GAME_NAME = "TESV";
        private static Mem memory = new Mem();
        private static int gameProcessID;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        /// <summary>
        /// Gets the game from the processor list
        /// </summary>
        private void openGame() {
            // Get the process given the name
            gameProcessID = memory.getProcIDFromName(GAME_NAME);
            // Check if the process returned anything
            if (gameProcessID > 0)
                memory.OpenProcess(gameProcessID.ToString());
        }

        /// <summary>
        /// Writes a address if the game is active
        /// </summary>
        /// <param name="address"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
        private void writeMemory(String address, String type, String value) {
            if (gameProcessID > 0)
                memory.writeMemory(GAME_NAME + ".exe+" + address, type, value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gameProcessID > 0) {
                this.Invoke(new MethodInvoker(delegate {
                    yPos.Text = memory.readFloat(GAME_NAME + ".exe+" + FreeCamera.getYPos()).ToString();
                    xPos.Text = memory.readFloat(GAME_NAME + ".exe+" + FreeCamera.getXPos()).ToString();
                    zPos.Text = memory.readFloat(GAME_NAME + ".exe+" + FreeCamera.getZPos()).ToString();
                }));
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (gameProcessID <= 0)
                openGame();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float floatValue = (float)Convert.ToDouble(textBox1.Text);
            writeMemory(FreeCamera.getYPos(), FreeCamera.RETURN_TYPE, floatValue.ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            float floatValue = (float)Convert.ToDouble(textBox2.Text);
            writeMemory(FreeCamera.getXPos(), FreeCamera.RETURN_TYPE, floatValue.ToString());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            float floatValue = (float)Convert.ToDouble(textBox3.Text);
            writeMemory(FreeCamera.getZPos(), FreeCamera.RETURN_TYPE, floatValue.ToString());
        }
    }
}
