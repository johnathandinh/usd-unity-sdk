//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class GfRotation : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GfRotation(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GfRotation obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GfRotation() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_GfRotation(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public GfRotation() : this(UsdCsPINVOKE.new_GfRotation__SWIG_0(), true) {
  }

  public GfRotation(GfVec3d axis, double angle) : this(UsdCsPINVOKE.new_GfRotation__SWIG_1(GfVec3d.getCPtr(axis), angle), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfRotation(GfQuaternion quaternion) : this(UsdCsPINVOKE.new_GfRotation__SWIG_2(GfQuaternion.getCPtr(quaternion)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfRotation(GfQuatd quat) : this(UsdCsPINVOKE.new_GfRotation__SWIG_3(GfQuatd.getCPtr(quat)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfRotation(GfVec3d rotateFrom, GfVec3d rotateTo) : this(UsdCsPINVOKE.new_GfRotation__SWIG_4(GfVec3d.getCPtr(rotateFrom), GfVec3d.getCPtr(rotateTo)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfRotation SetAxisAngle(GfVec3d axis, double angle) {
    GfRotation ret = new GfRotation(UsdCsPINVOKE.GfRotation_SetAxisAngle(swigCPtr, GfVec3d.getCPtr(axis), angle), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfRotation SetQuat(GfQuatd quat) {
    GfRotation ret = new GfRotation(UsdCsPINVOKE.GfRotation_SetQuat(swigCPtr, GfQuatd.getCPtr(quat)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfRotation SetQuaternion(GfQuaternion quat) {
    GfRotation ret = new GfRotation(UsdCsPINVOKE.GfRotation_SetQuaternion(swigCPtr, GfQuaternion.getCPtr(quat)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfRotation SetRotateInto(GfVec3d rotateFrom, GfVec3d rotateTo) {
    GfRotation ret = new GfRotation(UsdCsPINVOKE.GfRotation_SetRotateInto(swigCPtr, GfVec3d.getCPtr(rotateFrom), GfVec3d.getCPtr(rotateTo)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfRotation SetIdentity() {
    GfRotation ret = new GfRotation(UsdCsPINVOKE.GfRotation_SetIdentity(swigCPtr), false);
    return ret;
  }

  public GfVec3d GetAxis() {
    GfVec3d ret = new GfVec3d(UsdCsPINVOKE.GfRotation_GetAxis(swigCPtr), false);
    return ret;
  }

  public double GetAngle() {
    double ret = UsdCsPINVOKE.GfRotation_GetAngle(swigCPtr);
    return ret;
  }

  public GfQuaternion GetQuaternion() {
    GfQuaternion ret = new GfQuaternion(UsdCsPINVOKE.GfRotation_GetQuaternion(swigCPtr), true);
    return ret;
  }

  public GfQuatd GetQuat() {
    GfQuatd ret = new GfQuatd(UsdCsPINVOKE.GfRotation_GetQuat(swigCPtr), true);
    return ret;
  }

  public GfRotation GetInverse() {
    GfRotation ret = new GfRotation(UsdCsPINVOKE.GfRotation_GetInverse(swigCPtr), true);
    return ret;
  }

  public GfVec3d Decompose(GfVec3d axis0, GfVec3d axis1, GfVec3d axis2) {
    GfVec3d ret = new GfVec3d(UsdCsPINVOKE.GfRotation_Decompose(swigCPtr, GfVec3d.getCPtr(axis0), GfVec3d.getCPtr(axis1), GfVec3d.getCPtr(axis2)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void DecomposeRotation(GfMatrix4d rot, GfVec3d TwAxis, GfVec3d FBAxis, GfVec3d LRAxis, double handedness, ref double thetaTw, ref double thetaFB, ref double thetaLR, ref double thetaSw, bool useHint, ref double swShift) {
    UsdCsPINVOKE.GfRotation_DecomposeRotation__SWIG_0(GfMatrix4d.getCPtr(rot), GfVec3d.getCPtr(TwAxis), GfVec3d.getCPtr(FBAxis), GfVec3d.getCPtr(LRAxis), handedness, ref thetaTw, ref thetaFB, ref thetaLR, ref thetaSw, useHint, ref swShift);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void DecomposeRotation(GfMatrix4d rot, GfVec3d TwAxis, GfVec3d FBAxis, GfVec3d LRAxis, double handedness, ref double thetaTw, ref double thetaFB, ref double thetaLR, ref double thetaSw, bool useHint) {
    UsdCsPINVOKE.GfRotation_DecomposeRotation__SWIG_1(GfMatrix4d.getCPtr(rot), GfVec3d.getCPtr(TwAxis), GfVec3d.getCPtr(FBAxis), GfVec3d.getCPtr(LRAxis), handedness, ref thetaTw, ref thetaFB, ref thetaLR, ref thetaSw, useHint);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void DecomposeRotation(GfMatrix4d rot, GfVec3d TwAxis, GfVec3d FBAxis, GfVec3d LRAxis, double handedness, ref double thetaTw, ref double thetaFB, ref double thetaLR, ref double thetaSw) {
    UsdCsPINVOKE.GfRotation_DecomposeRotation__SWIG_2(GfMatrix4d.getCPtr(rot), GfVec3d.getCPtr(TwAxis), GfVec3d.getCPtr(FBAxis), GfVec3d.getCPtr(LRAxis), handedness, ref thetaTw, ref thetaFB, ref thetaLR, ref thetaSw);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void DecomposeRotation(GfMatrix4d rot, GfVec3d TwAxis, GfVec3d FBAxis, GfVec3d LRAxis, double handedness, ref double thetaTw, ref double thetaFB, ref double thetaLR) {
    UsdCsPINVOKE.GfRotation_DecomposeRotation__SWIG_3(GfMatrix4d.getCPtr(rot), GfVec3d.getCPtr(TwAxis), GfVec3d.getCPtr(FBAxis), GfVec3d.getCPtr(LRAxis), handedness, ref thetaTw, ref thetaFB, ref thetaLR);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static GfRotation RotateOntoProjected(GfVec3d v1, GfVec3d v2, GfVec3d axis) {
    GfRotation ret = new GfRotation(UsdCsPINVOKE.GfRotation_RotateOntoProjected(GfVec3d.getCPtr(v1), GfVec3d.getCPtr(v2), GfVec3d.getCPtr(axis)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfVec3f TransformDir(GfVec3f vec) {
    GfVec3f ret = new GfVec3f(UsdCsPINVOKE.GfRotation_TransformDir__SWIG_0(swigCPtr, GfVec3f.getCPtr(vec)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfVec3d TransformDir(GfVec3d vec) {
    GfVec3d ret = new GfVec3d(UsdCsPINVOKE.GfRotation_TransformDir__SWIG_1(swigCPtr, GfVec3d.getCPtr(vec)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool Equals(GfRotation lhs, GfRotation rhs) {
    bool ret = UsdCsPINVOKE.GfRotation_Equals(GfRotation.getCPtr(lhs), GfRotation.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  override public int GetHashCode() {
    int ret = UsdCsPINVOKE.GfRotation_GetHashCode(swigCPtr);
    return ret;
  }

    public static bool operator==(GfRotation lhs, GfRotation rhs){
	    // The Swig binding glue will re-enter this operator comparing to null, so 
	    // that case must be handled explicitly to avoid an infinite loop. This is still
	    // not great, since it crosses the C#/C++ barrier twice. A better approache might
	    // be to return a simple value from C++ that can be compared in C#.
      bool lnull = lhs as object == null;
      bool rnull = rhs as object == null;
      return (lnull == rnull) && ((lnull && rnull) || GfRotation.Equals(lhs, rhs));
    }

    public static bool operator !=(GfRotation lhs, GfRotation rhs) {
        return !(lhs == rhs);
    }

	  override public bool Equals(object rhs) {
		  return GfRotation.Equals(this, rhs as GfRotation);
	  }
  
}

}
