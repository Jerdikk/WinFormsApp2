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

public class MouseButtonEvent : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MouseButtonEvent(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MouseButtonEvent obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MouseButtonEvent() {
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
          BitesPINVOKE.delete_MouseButtonEvent(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public int type {
    set {
      BitesPINVOKE.MouseButtonEvent_type_set(swigCPtr, value);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = BitesPINVOKE.MouseButtonEvent_type_get(swigCPtr);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int x {
    set {
      BitesPINVOKE.MouseButtonEvent_x_set(swigCPtr, value);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = BitesPINVOKE.MouseButtonEvent_x_get(swigCPtr);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int y {
    set {
      BitesPINVOKE.MouseButtonEvent_y_set(swigCPtr, value);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = BitesPINVOKE.MouseButtonEvent_y_get(swigCPtr);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public byte button {
    set {
      BitesPINVOKE.MouseButtonEvent_button_set(swigCPtr, value);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      byte ret = BitesPINVOKE.MouseButtonEvent_button_get(swigCPtr);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public byte clicks {
    set {
      BitesPINVOKE.MouseButtonEvent_clicks_set(swigCPtr, value);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      byte ret = BitesPINVOKE.MouseButtonEvent_clicks_get(swigCPtr);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public MouseButtonEvent() : this(BitesPINVOKE.new_MouseButtonEvent(), true) {
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
