﻿using org.ogre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Classes
{  
    public class MyOgreApp : org.ogre.ApplicationContext
    {
        //org.ogre.ApplicationContext ctx;
        Root root;
        SceneManager scnMgr;
        ShaderGenerator shadergen;
        Viewport viewport;      
        RenderWindow window;

        IntPtr myIntPtr;
        int myWidth;
        int myHeight;

        public MyOgreApp() : base("OgreTutorialApp")
        {
            //ctx = new org.ogre.ApplicationContext("OgreTutorialApp");
        }



        public override void setup()
        {
            base.setup();
            base.destroyWindow("OgreTutorialApp");

            org.ogre.NameValueMap misc = new NameValueMap();
            misc["externalWindowHandle"] = myIntPtr.ToString();

            window = base.getRoot().createRenderWindow("Main RenderWindow", (uint)myWidth, (uint)myHeight, false, misc);

          //  
        }

        public void Init(IntPtr t, int Width, int Height)
        {
            myIntPtr = t;
            myWidth = Width;
            myHeight = Height;
            base.initApp();
           
            //base.destroyWindow("OgreTutorialApp");

            // get a pointer to the already created root
            root = getRoot();
            scnMgr = root.createSceneManager();

            /*
             *        scnMgr->setAmbientLight(Ogre::ColourValue(0, 0, 0));
        scnMgr->setShadowTechnique(Ogre::ShadowTechnique::SHADOWTYPE_STENCIL_ADDITIVE);
             */


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


            /*
             *  camNode->setPosition(200, 500, 400);
        camNode->lookAt(Ogre::Vector3(0, 0, 0), Ogre::Node::TransformSpace::TS_WORLD);
             */


            //camNode.setPosition(0, 0, 15);
            //camNode.lookAt(new Vector3(0, 0, -1), Node.TransformSpace.TS_PARENT);

            camNode.setPosition(200, 500, 400);
            camNode.lookAt(new Vector3(0, 0, 0), Node.TransformSpace.TS_WORLD);

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

            Plane plane = new Plane(new Vector3(0, 1, 0), 0);

            MeshManager.getSingleton().createPlane("ground", "General", plane, 2560, 2560, 20, 20, true, 1, 5, 5, new Vector3(0, 0, 1));
            Entity ent = scnMgr.createEntity("GroundEntity", "ground");
            SceneNode node = scnMgr.getRootSceneNode().createChildSceneNode("GroundNode", new Vector3(640.0f, 0.0f, 640.0f));
            node.attachObject(ent);
            ent.setMaterialName("Examples/RustySteel");
            /*
        

        ent = scnMgr->createEntity("GroundEntity", "ground");
        node = scnMgr->getRootSceneNode()->createChildSceneNode("GroundNode", Ogre::Vector3(640.0f, 0.0f, 640.0f));
        node->attachObject(ent);


        //! [planecreate]

        //! [planenoshadow]
        ent->setCastShadows(false);
        //! [planenoshadow]

        //! [planesetmat]
        ent->setMaterialName("Examples/RustySteel");
             */


            // finally something to render
            Entity ent1 = scnMgr.createEntity("Sinbad.mesh");
            SceneNode node1 = scnMgr.getRootSceneNode().createChildSceneNode();
            node1.attachObject(ent1);
          
        }

        public void Update()
        {
            base.pollEvents();
            getRoot().renderOneFrame();
        }

        public void Close()
        {
            base.closeApp();
        }

    }
}
