using System;
using System.Windows.Forms;
using Memory;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Input;

namespace Skyrim
{
    public partial class Form1 : Form
    {

        // Constants 
        private const String GAME_NAME = "TESV";

        // Imports
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        // Fields
        private static Mem memory = new Mem();
        private static int gameProcessID;

        // Keys
        private static Key moveFoward = Key.W;
        private static Key moveBackwards = Key.S;
        private static Key moveRight = Key.D;
        private static Key moveLeft = Key.A;
        // Mouse Movements
        private static Key lookUp = Key.NumPad8;
        private static Key lookDown = Key.NumPad2;
        private static Key lookRight = Key.NumPad6;
        private static Key lookLeft = Key.NumPad4;
        // Speed
        private static int cameraSpeed = 2;
        private static float lookSpeed = 0.01f;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetWindowLong(this.Handle, -20, GetWindowLong(this.Handle, -20) | 0x80000 | 0x20);
            TransparencyKey = System.Drawing.Color.Black;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            timer1.Enabled = true;
            timer2.Enabled = true;
            Top = 0;
            Left = 0;
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

        /// <summary>
        /// Rounds a integer number to a certain number
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int RoundIntNumber(int i, int round) {
            return ((int)Math.Round(i / 10.0)) * round;
        }

        /// <summary>
        /// Look controls for the camera
        /// </summary>
        /// <param name="yaw"></param>
        /// <param name="pitch"></param>
        public void LookControls(float yaw, float pitch) {
            if (Keyboard.IsKeyDown(lookUp) ||
                Keyboard.IsKeyDown(lookDown) ||
                Keyboard.IsKeyDown(lookRight) ||
                Keyboard.IsKeyDown(lookLeft))
            {

                if (Keyboard.IsKeyDown(lookUp)) 
                    pitch -= lookSpeed;
                if (Keyboard.IsKeyDown(lookDown)) 
                    pitch += lookSpeed;
                if (Keyboard.IsKeyDown(lookRight))
                    yaw += lookSpeed;
                if (Keyboard.IsKeyDown(lookLeft))
                    yaw -= lookSpeed;

                // Save the changes to the game
                writeMemory(FreeCamera.getYaw(), FreeCamera.RETURN_TYPE, yaw.ToString());
                writeMemory(FreeCamera.getPitch(), FreeCamera.RETURN_TYPE, pitch.ToString());
            }
        }

        /// <summary>
        /// Movement controls for the camera
        /// </summary>
        /// <param name="yPos"></param>
        /// <param name="xPos"></param>
        /// <param name="zPos"></param>
        /// <param name="yaw"></param>
        /// <param name="pitch"></param>
        public void MovementControls(float yPos, float xPos, float zPos, float yaw, float pitch) {
            // Movement controls
            if (Keyboard.IsKeyDown(moveFoward) ||
                Keyboard.IsKeyDown(moveBackwards) ||
                Keyboard.IsKeyDown(moveRight) ||
                Keyboard.IsKeyDown(moveLeft))
            {

                if (Keyboard.IsKeyDown(moveFoward)) {
                    zPos -= cameraSpeed * (float)Math.Sin(pitch);
                    xPos += cameraSpeed * (float)Math.Cos(pitch) * (float)Math.Sin(yaw);
                    yPos += cameraSpeed * (float)Math.Cos(pitch) * (float)Math.Cos(yaw);
                } if (Keyboard.IsKeyDown(moveBackwards)) {
                    zPos += cameraSpeed * (float)Math.Sin(pitch);
                    xPos -= cameraSpeed * (float)Math.Cos(pitch) * (float)Math.Sin(yaw);
                    yPos -= cameraSpeed * (float)Math.Cos(pitch) * (float)Math.Cos(yaw);
                } if (Keyboard.IsKeyDown(moveLeft)) {
                    xPos -= cameraSpeed * (float)Math.Cos(yaw);
                    yPos += cameraSpeed * (float)Math.Sin(yaw);
                } if (Keyboard.IsKeyDown(moveRight)) {
                    xPos += cameraSpeed * (float)Math.Cos(yaw);
                    yPos -= cameraSpeed * (float)Math.Sin(yaw);
                }

                // Save the changes to the game
                writeMemory(FreeCamera.getYPos(), FreeCamera.RETURN_TYPE, yPos.ToString());
                writeMemory(FreeCamera.getXPos(), FreeCamera.RETURN_TYPE, xPos.ToString());
                writeMemory(FreeCamera.getZPos(), FreeCamera.RETURN_TYPE, zPos.ToString());
            }
        }

        /// <summary>
        /// Display informaiton on the screen
        /// </summary>
        /// <param name="yPos"></param>
        /// <param name="xPos"></param>
        /// <param name="zPos"></param>
        /// <param name="yaw"></param>
        /// <param name="pitch"></param>
        public void DisplayInformation(float yPos, float xPos, float zPos, float yaw, float pitch) {
            this.Invoke(new MethodInvoker(delegate
            {
                LyPos.Text = yPos.ToString();
                LxPos.Text = xPos.ToString();
                LzPos.Text = zPos.ToString();
                label2.Text = yaw.ToString();
                label3.Text = pitch.ToString();
            }));
        }

        /// <summary>
        /// Timer for the getting and setting of the information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Set form to be the top window
            TopMost = true;

            if (gameProcessID > 0)
            {
                // Get floats from memory
                float yPos = memory.readFloat(GAME_NAME + ".exe+" + FreeCamera.getYPos());
                float xPos = memory.readFloat(GAME_NAME + ".exe+" + FreeCamera.getXPos());
                float zPos = memory.readFloat(GAME_NAME + ".exe+" + FreeCamera.getZPos());
                float yaw = memory.readFloat(GAME_NAME + ".exe+" + FreeCamera.getYaw());
                float pitch = memory.readFloat(GAME_NAME + ".exe+" + FreeCamera.getPitch());

                LookControls(yaw, pitch);
                MovementControls(yPos, xPos, zPos, yaw, pitch);
                DisplayInformation(yPos, xPos, zPos, yaw, pitch);
            }
        }

        /// <summary>
        /// Timer for checking if the game is opened or not, and if not finding it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
