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

public class ControllerFloat : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ControllerFloat(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ControllerFloat obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ControllerFloat() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_ControllerFloat(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ControllerFloat(ControllerValueFloatPtr src, ControllerValueFloatPtr dest, ControllerFunctionPtr func) : this(OgrePINVOKE.new_ControllerFloat(ControllerValueFloatPtr.getCPtr(src), ControllerValueFloatPtr.getCPtr(dest), ControllerFunctionPtr.getCPtr(func)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSource(ControllerValueFloatPtr src) {
    OgrePINVOKE.ControllerFloat_setSource(swigCPtr, ControllerValueFloatPtr.getCPtr(src));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ControllerValueFloatPtr getSource() {
    ControllerValueFloatPtr ret = new ControllerValueFloatPtr(OgrePINVOKE.ControllerFloat_getSource(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setDestination(ControllerValueFloatPtr dest) {
    OgrePINVOKE.ControllerFloat_setDestination(swigCPtr, ControllerValueFloatPtr.getCPtr(dest));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ControllerValueFloatPtr getDestination() {
    ControllerValueFloatPtr ret = new ControllerValueFloatPtr(OgrePINVOKE.ControllerFloat_getDestination(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool getEnabled() {
    bool ret = OgrePINVOKE.ControllerFloat_getEnabled(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setEnabled(bool enabled) {
    OgrePINVOKE.ControllerFloat_setEnabled(swigCPtr, enabled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFunction(ControllerFunctionPtr func) {
    OgrePINVOKE.ControllerFloat_setFunction(swigCPtr, ControllerFunctionPtr.getCPtr(func));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ControllerFunctionPtr getFunction() {
    ControllerFunctionPtr ret = new ControllerFunctionPtr(OgrePINVOKE.ControllerFloat_getFunction(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void update() {
    OgrePINVOKE.ControllerFloat_update(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}