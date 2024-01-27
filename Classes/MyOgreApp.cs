using org.ogre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Classes
{
    public class MyOgreApp
    {
        org.ogre.ApplicationContext ctx;
        Root root;
        SceneManager scnMgr;
        ShaderGenerator shadergen;
        Viewport viewport;

        public MyOgreApp() 
        {
            ctx = new org.ogre.ApplicationContext("OgreTutorialApp");
        }

        public void Init(IntPtr t, int Width, int Height)
        {            
            ctx.initApp();

            ctx.destroyWindow("OgreTutorialApp");

            org.ogre.NameValueMap misc = new NameValueMap();
            misc["externalWindowHandle"] = t.ToString();

            RenderWindow window = ctx.getRoot().createRenderWindow("Main RenderWindow", (uint)Width, (uint)Height, false, misc);

            // get a pointer to the already created root
            root = ctx.getRoot();
            scnMgr = root.createSceneManager();

            // register our scene with the RTSS
            shadergen = ShaderGenerator.getSingleton();
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

            viewport = window.addViewport(cam);
            viewport.setBackgroundColour(ColourValue.Black);

            cam.setAspectRatio((float)viewport.getActualWidth() / (float)viewport.getActualHeight());

            // and tell it to render into the main window
            //ctx.getRenderWindow().addViewport(cam);

            // finally something to render
            Entity ent = scnMgr.createEntity("Sinbad.mesh");
            SceneNode node = scnMgr.getRootSceneNode().createChildSceneNode();
            node.attachObject(ent);
        }

        public void Update()
        {
            ctx.getRoot().renderOneFrame();
        }

        public void Close()
        {
            ctx.closeApp();
        }

    }
}
