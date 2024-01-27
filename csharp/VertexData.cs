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

public class VertexData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VertexData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VertexData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VertexData() {
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
          OgrePINVOKE.delete_VertexData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public VertexData(HardwareBufferManagerBase mgr) : this(OgrePINVOKE.new_VertexData__SWIG_0(HardwareBufferManagerBase.getCPtr(mgr)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public VertexData() : this(OgrePINVOKE.new_VertexData__SWIG_1(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public VertexData(VertexDeclaration dcl, VertexBufferBinding bind) : this(OgrePINVOKE.new_VertexData__SWIG_2(VertexDeclaration.getCPtr(dcl), VertexBufferBinding.getCPtr(bind)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public VertexDeclaration vertexDeclaration {
    set {
      OgrePINVOKE.VertexData_vertexDeclaration_set(swigCPtr, VertexDeclaration.getCPtr(value));
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = OgrePINVOKE.VertexData_vertexDeclaration_get(swigCPtr);
      VertexDeclaration ret = (cPtr == global::System.IntPtr.Zero) ? null : new VertexDeclaration(cPtr, false);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VertexBufferBinding vertexBufferBinding {
    set {
      OgrePINVOKE.VertexData_vertexBufferBinding_set(swigCPtr, VertexBufferBinding.getCPtr(value));
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = OgrePINVOKE.VertexData_vertexBufferBinding_get(swigCPtr);
      VertexBufferBinding ret = (cPtr == global::System.IntPtr.Zero) ? null : new VertexBufferBinding(cPtr, false);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool mDeleteDclBinding {
    set {
      OgrePINVOKE.VertexData_mDeleteDclBinding_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = OgrePINVOKE.VertexData_mDeleteDclBinding_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint vertexStart {
    set {
      OgrePINVOKE.VertexData_vertexStart_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = OgrePINVOKE.VertexData_vertexStart_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint vertexCount {
    set {
      OgrePINVOKE.VertexData_vertexCount_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = OgrePINVOKE.VertexData_vertexCount_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public class HardwareAnimationData : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal HardwareAnimationData(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(HardwareAnimationData obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~HardwareAnimationData() {
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
            OgrePINVOKE.delete_VertexData_HardwareAnimationData(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
      }
    }
  
    public ushort targetBufferIndex {
      set {
        OgrePINVOKE.VertexData_HardwareAnimationData_targetBufferIndex_set(swigCPtr, value);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        ushort ret = OgrePINVOKE.VertexData_HardwareAnimationData_targetBufferIndex_get(swigCPtr);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public float parametric {
      set {
        OgrePINVOKE.VertexData_HardwareAnimationData_parametric_set(swigCPtr, value);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        float ret = OgrePINVOKE.VertexData_HardwareAnimationData_parametric_get(swigCPtr);
        if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public HardwareAnimationData() : this(OgrePINVOKE.new_VertexData_HardwareAnimationData(), true) {
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    }
  
  }

  public uint hwAnimDataItemsUsed {
    set {
      OgrePINVOKE.VertexData_hwAnimDataItemsUsed_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = OgrePINVOKE.VertexData_hwAnimDataItemsUsed_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_std__vectorT_Ogre__VertexData__HardwareAnimationData_t hwAnimationDataList {
    set {
      OgrePINVOKE.VertexData_hwAnimationDataList_set(swigCPtr, SWIGTYPE_p_std__vectorT_Ogre__VertexData__HardwareAnimationData_t.getCPtr(value));
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = OgrePINVOKE.VertexData_hwAnimationDataList_get(swigCPtr);
      SWIGTYPE_p_std__vectorT_Ogre__VertexData__HardwareAnimationData_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_Ogre__VertexData__HardwareAnimationData_t(cPtr, false);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VertexData clone(bool copyData, HardwareBufferManagerBase mgr) {
    global::System.IntPtr cPtr = OgrePINVOKE.VertexData_clone__SWIG_0(swigCPtr, copyData, HardwareBufferManagerBase.getCPtr(mgr));
    VertexData ret = (cPtr == global::System.IntPtr.Zero) ? null : new VertexData(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VertexData clone(bool copyData) {
    global::System.IntPtr cPtr = OgrePINVOKE.VertexData_clone__SWIG_1(swigCPtr, copyData);
    VertexData ret = (cPtr == global::System.IntPtr.Zero) ? null : new VertexData(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VertexData clone() {
    global::System.IntPtr cPtr = OgrePINVOKE.VertexData_clone__SWIG_2(swigCPtr);
    VertexData ret = (cPtr == global::System.IntPtr.Zero) ? null : new VertexData(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void prepareForShadowVolume() {
    OgrePINVOKE.VertexData_prepareForShadowVolume(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void convertVertexElement(VertexElementSemantic semantic, VertexElementType dstType) {
    OgrePINVOKE.VertexData_convertVertexElement(swigCPtr, (int)semantic, (int)dstType);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public HardwareVertexBufferPtr hardwareShadowVolWBuffer {
    set {
      OgrePINVOKE.VertexData_hardwareShadowVolWBuffer_set(swigCPtr, HardwareVertexBufferPtr.getCPtr(value));
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = OgrePINVOKE.VertexData_hardwareShadowVolWBuffer_get(swigCPtr);
      HardwareVertexBufferPtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new HardwareVertexBufferPtr(cPtr, false);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public void reorganiseBuffers(VertexDeclaration newDeclaration, HardwareBufferManagerBase mgr) {
    OgrePINVOKE.VertexData_reorganiseBuffers__SWIG_0(swigCPtr, VertexDeclaration.getCPtr(newDeclaration), HardwareBufferManagerBase.getCPtr(mgr));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void reorganiseBuffers(VertexDeclaration newDeclaration) {
    OgrePINVOKE.VertexData_reorganiseBuffers__SWIG_1(swigCPtr, VertexDeclaration.getCPtr(newDeclaration));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void closeGapsInBindings() {
    OgrePINVOKE.VertexData_closeGapsInBindings(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeUnusedBuffers() {
    OgrePINVOKE.VertexData_removeUnusedBuffers(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void convertPackedColour(VertexElementType srcType, VertexElementType destType) {
    OgrePINVOKE.VertexData_convertPackedColour(swigCPtr, (int)srcType, (int)destType);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ushort allocateHardwareAnimationElements(ushort count, bool animateNormals) {
    ushort ret = OgrePINVOKE.VertexData_allocateHardwareAnimationElements(swigCPtr, count, animateNormals);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VertexData _cloneRemovingBlendData() {
    global::System.IntPtr cPtr = OgrePINVOKE.VertexData__cloneRemovingBlendData(swigCPtr);
    VertexData ret = (cPtr == global::System.IntPtr.Zero) ? null : new VertexData(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}