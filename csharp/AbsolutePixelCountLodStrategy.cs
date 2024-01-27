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

public class AbsolutePixelCountLodStrategy : PixelCountLodStrategyBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal AbsolutePixelCountLodStrategy(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.AbsolutePixelCountLodStrategy_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AbsolutePixelCountLodStrategy obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_AbsolutePixelCountLodStrategy(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public AbsolutePixelCountLodStrategy() : this(OgrePINVOKE.new_AbsolutePixelCountLodStrategy(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual float getValueImpl(MovableObject movableObject, Camera camera) {
    float ret = OgrePINVOKE.AbsolutePixelCountLodStrategy_getValueImpl(swigCPtr, MovableObject.getCPtr(movableObject), Camera.getCPtr(camera));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static AbsolutePixelCountLodStrategy getSingleton() {
    AbsolutePixelCountLodStrategy ret = new AbsolutePixelCountLodStrategy(OgrePINVOKE.AbsolutePixelCountLodStrategy_getSingleton(), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}