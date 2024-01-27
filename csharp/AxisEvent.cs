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

public class AxisEvent : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AxisEvent(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AxisEvent obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AxisEvent() {
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
          BitesPINVOKE.delete_AxisEvent(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public int type {
    set {
      BitesPINVOKE.AxisEvent_type_set(swigCPtr, value);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = BitesPINVOKE.AxisEvent_type_get(swigCPtr);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int which {
    set {
      BitesPINVOKE.AxisEvent_which_set(swigCPtr, value);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = BitesPINVOKE.AxisEvent_which_get(swigCPtr);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public byte axis {
    set {
      BitesPINVOKE.AxisEvent_axis_set(swigCPtr, value);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      byte ret = BitesPINVOKE.AxisEvent_axis_get(swigCPtr);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public short value {
    set {
      BitesPINVOKE.AxisEvent_value_set(swigCPtr, value);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      short ret = BitesPINVOKE.AxisEvent_value_get(swigCPtr);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public AxisEvent() : this(BitesPINVOKE.new_AxisEvent(), true) {
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

}

}