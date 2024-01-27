//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace org.ogre {

public class FocusedShadowCameraSetup : DefaultShadowCameraSetup {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FocusedShadowCameraSetup(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.FocusedShadowCameraSetup_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FocusedShadowCameraSetup obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_FocusedShadowCameraSetup(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public FocusedShadowCameraSetup(bool useAggressiveRegion) : this(OgrePINVOKE.new_FocusedShadowCameraSetup__SWIG_0(useAggressiveRegion), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public FocusedShadowCameraSetup() : this(OgrePINVOKE.new_FocusedShadowCameraSetup__SWIG_1(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public static ShadowCameraSetupPtr create(bool useAggressiveRegion) {
    ShadowCameraSetupPtr ret = new ShadowCameraSetupPtr(OgrePINVOKE.FocusedShadowCameraSetup_create__SWIG_0(useAggressiveRegion), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static ShadowCameraSetupPtr create() {
    ShadowCameraSetupPtr ret = new ShadowCameraSetupPtr(OgrePINVOKE.FocusedShadowCameraSetup_create__SWIG_1(), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void getShadowCamera(SceneManager sm, Camera cam, Viewport vp, Light light, Camera texCam, uint iteration) {
    OgrePINVOKE.FocusedShadowCameraSetup_getShadowCamera(swigCPtr, SceneManager.getCPtr(sm), Camera.getCPtr(cam), Viewport.getCPtr(vp), Light.getCPtr(light), Camera.getCPtr(texCam), iteration);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setUseAggressiveFocusRegion(bool aggressive) {
    OgrePINVOKE.FocusedShadowCameraSetup_setUseAggressiveFocusRegion(swigCPtr, aggressive);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getUseAggressiveFocusRegion() {
    bool ret = OgrePINVOKE.FocusedShadowCameraSetup_getUseAggressiveFocusRegion(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}