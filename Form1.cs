using org.ogre;
using WinFormsApp2.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{

    public partial class Form1 : Form
    {
      
        bool isRunning;
        MyOgreApp ogreApp;
        public Form1()
        {
            InitializeComponent();
            IntPtr t = userControl11.Handle;
            ogreApp = new MyOgreApp();
            ogreApp.Init(t,this.Width,this.Height);

            isRunning = true;
            Thread thread = new Thread(Go);
            thread.Start();
        }

        private void Go(object? obj)
        {
            while (isRunning)
            {
              
                Thread.Sleep(10);
                Application.DoEvents();
                ogreApp.Update();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRunning = false;
            Thread.Sleep(100);
          ogreApp.Close();
        }
    }

}