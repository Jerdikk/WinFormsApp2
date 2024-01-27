using org.ogre;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{

    public partial class Form1 : Form
    {
        org.ogre.ApplicationContext ctx;
        bool isRunning;
        public Form1()
        {
            InitializeComponent();
            IntPtr t = userControl11.Handle;

            ctx = new org.ogre.ApplicationContext("OgreTutorialApp");
            ctx.initApp();

            ctx.destroyWindow("OgreTutorialApp");

            org.ogre.NameValueMap misc = new NameValueMap();
            misc["externalWindowHandle"] = t.ToString();


            RenderWindow window = ctx.getRoot().createRenderWindow("Main RenderWindow", (uint)this.Width, (uint)this.Height, false, misc);

            // get a pointer to the already created root
            Root root = ctx.getRoot();
            SceneManager scnMgr = root.createSceneManager();

            // register our scene with the RTSS
            ShaderGenerator shadergen = ShaderGenerator.getSingleton();
            shadergen.addSceneManager(scnMgr);

            // without light we would just get a black screen    
            Light light = scnMgr.createLight("MainLight");
            SceneNode lightNode = scnMgr.getRootSceneNode().createChildSceneNode();
            lightNode.setPosition(0, 10, 15);
            lightNode.attachObject(light);

            // also need to tell where we are
            SceneNode camNode = scnMgr.getRootSceneNode().createChildSceneNode();
            camNode.setPosition(0, 0, 15);
            camNode.lookAt(new Vector3(0, 0, -1), Node.TransformSpace.TS_PARENT);

            // create the camera
            Camera cam = scnMgr.createCamera("myCam");
            cam.setNearClipDistance(5); // specific to this sample
            cam.setAutoAspectRatio(true);
            camNode.attachObject(cam);

            Viewport viewport = window.addViewport(cam);
            viewport.setBackgroundColour(ColourValue.Black);

            cam.setAspectRatio((float)viewport.getActualWidth() / (float)viewport.getActualHeight());

            // and tell it to render into the main window
            //ctx.getRenderWindow().addViewport(cam);

            // finally something to render
            Entity ent = scnMgr.createEntity("Sinbad.mesh");
            SceneNode node = scnMgr.getRootSceneNode().createChildSceneNode();
            node.attachObject(ent);


            isRunning = true;
            Thread thread = new Thread(Go);
            thread.Start();
        }

        private void Go(object? obj)
        {
            while (isRunning)
            {
                ctx.getRoot().renderOneFrame();
                Thread.Sleep(10);
                Application.DoEvents();

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRunning = false;
            Thread.Sleep(100);
            ctx.closeApp();
        }
    }

}