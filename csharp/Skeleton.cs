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

public class Skeleton : Resource {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Skeleton(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.Skeleton_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Skeleton obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_Skeleton(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public Skeleton(ResourceManager creator, string name, uint handle, string group, bool isManual, ManualResourceLoader loader) : this(OgrePINVOKE.new_Skeleton__SWIG_0(ResourceManager.getCPtr(creator), name, handle, group, isManual, ManualResourceLoader.getCPtr(loader)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Skeleton(ResourceManager creator, string name, uint handle, string group, bool isManual) : this(OgrePINVOKE.new_Skeleton__SWIG_1(ResourceManager.getCPtr(creator), name, handle, group, isManual), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Skeleton(ResourceManager creator, string name, uint handle, string group) : this(OgrePINVOKE.new_Skeleton__SWIG_2(ResourceManager.getCPtr(creator), name, handle, group), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual Bone createBone() {
    global::System.IntPtr cPtr = OgrePINVOKE.Skeleton_createBone__SWIG_0(swigCPtr);
    Bone ret = (cPtr == global::System.IntPtr.Zero) ? null : new Bone(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Bone createBone(ushort handle) {
    global::System.IntPtr cPtr = OgrePINVOKE.Skeleton_createBone__SWIG_1(swigCPtr, handle);
    Bone ret = (cPtr == global::System.IntPtr.Zero) ? null : new Bone(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Bone createBone(string name) {
    global::System.IntPtr cPtr = OgrePINVOKE.Skeleton_createBone__SWIG_2(swigCPtr, name);
    Bone ret = (cPtr == global::System.IntPtr.Zero) ? null : new Bone(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Bone createBone(string name, ushort handle) {
    global::System.IntPtr cPtr = OgrePINVOKE.Skeleton_createBone__SWIG_3(swigCPtr, name, handle);
    Bone ret = (cPtr == global::System.IntPtr.Zero) ? null : new Bone(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ushort getNumBones() {
    ushort ret = OgrePINVOKE.Skeleton_getNumBones(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BoneList getRootBones() {
    BoneList ret = new BoneList(OgrePINVOKE.Skeleton_getRootBones(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BoneList getBones() {
    BoneList ret = new BoneList(OgrePINVOKE.Skeleton_getBones(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Bone getBone(ushort handle) {
    global::System.IntPtr cPtr = OgrePINVOKE.Skeleton_getBone__SWIG_0(swigCPtr, handle);
    Bone ret = (cPtr == global::System.IntPtr.Zero) ? null : new Bone(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Bone getBone(string name) {
    global::System.IntPtr cPtr = OgrePINVOKE.Skeleton_getBone__SWIG_1(swigCPtr, name);
    Bone ret = (cPtr == global::System.IntPtr.Zero) ? null : new Bone(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool hasBone(string name) {
    bool ret = OgrePINVOKE.Skeleton_hasBone(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setBindingPose() {
    OgrePINVOKE.Skeleton_setBindingPose(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void reset(bool resetManualBones) {
    OgrePINVOKE.Skeleton_reset__SWIG_0(swigCPtr, resetManualBones);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void reset() {
    OgrePINVOKE.Skeleton_reset__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Animation createAnimation(string name, float length) {
    global::System.IntPtr cPtr = OgrePINVOKE.Skeleton_createAnimation(swigCPtr, name, length);
    Animation ret = (cPtr == global::System.IntPtr.Zero) ? null : new Animation(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Animation getAnimation(string name, SWIGTYPE_p_p_Ogre__LinkedSkeletonAnimationSource linker) {
    global::System.IntPtr cPtr = OgrePINVOKE.Skeleton_getAnimation__SWIG_0(swigCPtr, name, SWIGTYPE_p_p_Ogre__LinkedSkeletonAnimationSource.getCPtr(linker));
    Animation ret = (cPtr == global::System.IntPtr.Zero) ? null : new Animation(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Animation getAnimation(string name) {
    global::System.IntPtr cPtr = OgrePINVOKE.Skeleton_getAnimation__SWIG_1(swigCPtr, name);
    Animation ret = (cPtr == global::System.IntPtr.Zero) ? null : new Animation(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Animation _getAnimationImpl(string name, SWIGTYPE_p_p_Ogre__LinkedSkeletonAnimationSource linker) {
    global::System.IntPtr cPtr = OgrePINVOKE.Skeleton__getAnimationImpl__SWIG_0(swigCPtr, name, SWIGTYPE_p_p_Ogre__LinkedSkeletonAnimationSource.getCPtr(linker));
    Animation ret = (cPtr == global::System.IntPtr.Zero) ? null : new Animation(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Animation _getAnimationImpl(string name) {
    global::System.IntPtr cPtr = OgrePINVOKE.Skeleton__getAnimationImpl__SWIG_1(swigCPtr, name);
    Animation ret = (cPtr == global::System.IntPtr.Zero) ? null : new Animation(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool hasAnimation(string name) {
    bool ret = OgrePINVOKE.Skeleton_hasAnimation(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void removeAnimation(string name) {
    OgrePINVOKE.Skeleton_removeAnimation(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setAnimationState(AnimationStateSet animSet) {
    OgrePINVOKE.Skeleton_setAnimationState(swigCPtr, AnimationStateSet.getCPtr(animSet));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void _initAnimationState(AnimationStateSet animSet) {
    OgrePINVOKE.Skeleton__initAnimationState(swigCPtr, AnimationStateSet.getCPtr(animSet));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void _refreshAnimationState(AnimationStateSet animSet) {
    OgrePINVOKE.Skeleton__refreshAnimationState(swigCPtr, AnimationStateSet.getCPtr(animSet));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void _getBoneMatrices(Affine3 pMatrices) {
    OgrePINVOKE.Skeleton__getBoneMatrices(swigCPtr, Affine3.getCPtr(pMatrices));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ushort getNumAnimations() {
    ushort ret = OgrePINVOKE.Skeleton_getNumAnimations(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Animation getAnimation(ushort index) {
    global::System.IntPtr cPtr = OgrePINVOKE.Skeleton_getAnimation__SWIG_2(swigCPtr, index);
    Animation ret = (cPtr == global::System.IntPtr.Zero) ? null : new Animation(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SkeletonAnimationBlendMode getBlendMode() {
    SkeletonAnimationBlendMode ret = (SkeletonAnimationBlendMode)OgrePINVOKE.Skeleton_getBlendMode(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setBlendMode(SkeletonAnimationBlendMode state) {
    OgrePINVOKE.Skeleton_setBlendMode(swigCPtr, (int)state);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void _updateTransforms() {
    OgrePINVOKE.Skeleton__updateTransforms(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void optimiseAllAnimations(bool preservingIdentityNodeTracks) {
    OgrePINVOKE.Skeleton_optimiseAllAnimations__SWIG_0(swigCPtr, preservingIdentityNodeTracks);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void optimiseAllAnimations() {
    OgrePINVOKE.Skeleton_optimiseAllAnimations__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void addLinkedSkeletonAnimationSource(string skelName, float scale) {
    OgrePINVOKE.Skeleton_addLinkedSkeletonAnimationSource__SWIG_0(swigCPtr, skelName, scale);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void addLinkedSkeletonAnimationSource(string skelName) {
    OgrePINVOKE.Skeleton_addLinkedSkeletonAnimationSource__SWIG_1(swigCPtr, skelName);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void removeAllLinkedSkeletonAnimationSources() {
    OgrePINVOKE.Skeleton_removeAllLinkedSkeletonAnimationSources(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_std__vectorT_Ogre__LinkedSkeletonAnimationSource_t getLinkedSkeletonAnimationSources() {
    SWIGTYPE_p_std__vectorT_Ogre__LinkedSkeletonAnimationSource_t ret = new SWIGTYPE_p_std__vectorT_Ogre__LinkedSkeletonAnimationSource_t(OgrePINVOKE.Skeleton_getLinkedSkeletonAnimationSources(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void _notifyManualBonesDirty() {
    OgrePINVOKE.Skeleton__notifyManualBonesDirty(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void _notifyManualBoneStateChange(Bone bone) {
    OgrePINVOKE.Skeleton__notifyManualBoneStateChange(swigCPtr, Bone.getCPtr(bone));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool getManualBonesDirty() {
    bool ret = OgrePINVOKE.Skeleton_getManualBonesDirty(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool hasManualBones() {
    bool ret = OgrePINVOKE.Skeleton_hasManualBones(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void _mergeSkeletonAnimations(Skeleton source, SWIGTYPE_p_std__vectorT_unsigned_short_t boneHandleMap, StringList animations) {
    OgrePINVOKE.Skeleton__mergeSkeletonAnimations__SWIG_0(swigCPtr, Skeleton.getCPtr(source), SWIGTYPE_p_std__vectorT_unsigned_short_t.getCPtr(boneHandleMap), StringList.getCPtr(animations));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void _mergeSkeletonAnimations(Skeleton source, SWIGTYPE_p_std__vectorT_unsigned_short_t boneHandleMap) {
    OgrePINVOKE.Skeleton__mergeSkeletonAnimations__SWIG_1(swigCPtr, Skeleton.getCPtr(source), SWIGTYPE_p_std__vectorT_unsigned_short_t.getCPtr(boneHandleMap));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void _buildMapBoneByHandle(Skeleton source, SWIGTYPE_p_std__vectorT_unsigned_short_t boneHandleMap) {
    OgrePINVOKE.Skeleton__buildMapBoneByHandle(swigCPtr, Skeleton.getCPtr(source), SWIGTYPE_p_std__vectorT_unsigned_short_t.getCPtr(boneHandleMap));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void _buildMapBoneByName(Skeleton source, SWIGTYPE_p_std__vectorT_unsigned_short_t boneHandleMap) {
    OgrePINVOKE.Skeleton__buildMapBoneByName(swigCPtr, Skeleton.getCPtr(source), SWIGTYPE_p_std__vectorT_unsigned_short_t.getCPtr(boneHandleMap));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}