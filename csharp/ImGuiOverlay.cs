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

public class ImGuiOverlay : Overlay {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ImGuiOverlay(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgreOverlayPINVOKE.ImGuiOverlay_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ImGuiOverlay obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgreOverlayPINVOKE.delete_ImGuiOverlay(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ImGuiOverlay() : this(OgreOverlayPINVOKE.new_ImGuiOverlay(), true) {
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_ImFont addFont(string name, string group) {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.ImGuiOverlay_addFont__SWIG_0(swigCPtr, name, group);
    SWIGTYPE_p_ImFont ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_ImFont(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_ImFont addFont(string name) {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.ImGuiOverlay_addFont__SWIG_1(swigCPtr, name);
    SWIGTYPE_p_ImFont ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_ImFont(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void NewFrame() {
    OgreOverlayPINVOKE.ImGuiOverlay_NewFrame();
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void _findVisibleObjects(Camera cam, RenderQueue queue, Viewport vp) {
    OgreOverlayPINVOKE.ImGuiOverlay__findVisibleObjects(swigCPtr, Camera.getCPtr(cam), RenderQueue.getCPtr(queue), Viewport.getCPtr(vp));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

}

}