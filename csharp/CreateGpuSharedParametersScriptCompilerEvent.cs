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

public class CreateGpuSharedParametersScriptCompilerEvent : ScriptCompilerEvent {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CreateGpuSharedParametersScriptCompilerEvent(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.CreateGpuSharedParametersScriptCompilerEvent_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CreateGpuSharedParametersScriptCompilerEvent obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_CreateGpuSharedParametersScriptCompilerEvent(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public string mFile {
    set {
      OgrePINVOKE.CreateGpuSharedParametersScriptCompilerEvent_mFile_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = OgrePINVOKE.CreateGpuSharedParametersScriptCompilerEvent_mFile_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string mName {
    set {
      OgrePINVOKE.CreateGpuSharedParametersScriptCompilerEvent_mName_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = OgrePINVOKE.CreateGpuSharedParametersScriptCompilerEvent_mName_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string mResourceGroup {
    set {
      OgrePINVOKE.CreateGpuSharedParametersScriptCompilerEvent_mResourceGroup_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = OgrePINVOKE.CreateGpuSharedParametersScriptCompilerEvent_mResourceGroup_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static string eventType {
    set {
      OgrePINVOKE.CreateGpuSharedParametersScriptCompilerEvent_eventType_set(value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = OgrePINVOKE.CreateGpuSharedParametersScriptCompilerEvent_eventType_get();
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public CreateGpuSharedParametersScriptCompilerEvent(string file, string name, string resourceGroup) : this(OgrePINVOKE.new_CreateGpuSharedParametersScriptCompilerEvent(file, name, resourceGroup), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}