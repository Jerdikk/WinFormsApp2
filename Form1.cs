using org.ogre;
using WinFormsApp2.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{

    public partial class Form1 : Form
    {

        bool isRunning;
        bool isFormClosing;
        MyOgreApp ogreApp;
        public Form1()
        {
            InitializeComponent();
            IntPtr t = userControl11.Handle;
            ogreApp = new MyOgreApp();
            ogreApp.Init(t, this.Width, this.Height);

            userControl11.KeyDown += MyKeyDown;
            userControl11.KeyPress += MyKeyPress;
            userControl11.KeyUp += MyKeyUp;

            isRunning = true;
            isFormClosing = false;
            Thread thread = new Thread(Go);
            thread.Start();
        }

        private void MyKeyUp(object? sender, KeyEventArgs e)
        {
            int y = 1;
            y++;

        }

        private void MyKeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                isRunning = false;
            }

        }

        private void MyKeyDown(object? sender, KeyEventArgs e)
        {
            int y = 1;
            y++;

        }

        private void Go(object? obj)
        {
            while (isRunning)
            {
                Thread.Sleep(10);
                Application.DoEvents();
                ogreApp.Update();
            }
            ogreApp.Close();

            if (!isFormClosing)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    // close the form on the forms thread
                    this.Close();
                });
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isFormClosing = true;
            isRunning = false;
            Thread.Sleep(100);
        }
      
    }

}