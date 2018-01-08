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

public class GfQuatd : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GfQuatd(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GfQuatd obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GfQuatd() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_GfQuatd(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public GfQuatd() : this(UsdCsPINVOKE.new_GfQuatd__SWIG_0(), true) {
  }

  public GfQuatd(double realVal) : this(UsdCsPINVOKE.new_GfQuatd__SWIG_1(realVal), true) {
  }

  public GfQuatd(double real, double i, double j, double k) : this(UsdCsPINVOKE.new_GfQuatd__SWIG_2(real, i, j, k), true) {
  }

  public GfQuatd(double real, GfVec3d imaginary) : this(UsdCsPINVOKE.new_GfQuatd__SWIG_3(real, GfVec3d.getCPtr(imaginary)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfQuatd(GfQuatf other) : this(UsdCsPINVOKE.new_GfQuatd__SWIG_4(GfQuatf.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfQuatd(GfQuath other) : this(UsdCsPINVOKE.new_GfQuatd__SWIG_5(GfQuath.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static GfQuatd GetIdentity() {
    GfQuatd ret = new GfQuatd(UsdCsPINVOKE.GfQuatd_GetIdentity(), true);
    return ret;
  }

  public double GetReal() {
    double ret = UsdCsPINVOKE.GfQuatd_GetReal(swigCPtr);
    return ret;
  }

  public void SetReal(double real) {
    UsdCsPINVOKE.GfQuatd_SetReal(swigCPtr, real);
  }

  public GfVec3d GetImaginary() {
    GfVec3d ret = new GfVec3d(UsdCsPINVOKE.GfQuatd_GetImaginary(swigCPtr), false);
    return ret;
  }

  public void SetImaginary(GfVec3d imaginary) {
    UsdCsPINVOKE.GfQuatd_SetImaginary__SWIG_0(swigCPtr, GfVec3d.getCPtr(imaginary));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetImaginary(double i, double j, double k) {
    UsdCsPINVOKE.GfQuatd_SetImaginary__SWIG_1(swigCPtr, i, j, k);
  }

  public double GetLength() {
    double ret = UsdCsPINVOKE.GfQuatd_GetLength(swigCPtr);
    return ret;
  }

  public GfQuatd GetNormalized(double eps) {
    GfQuatd ret = new GfQuatd(UsdCsPINVOKE.GfQuatd_GetNormalized__SWIG_0(swigCPtr, eps), true);
    return ret;
  }

  public GfQuatd GetNormalized() {
    GfQuatd ret = new GfQuatd(UsdCsPINVOKE.GfQuatd_GetNormalized__SWIG_1(swigCPtr), true);
    return ret;
  }

  public double Normalize(double eps) {
    double ret = UsdCsPINVOKE.GfQuatd_Normalize__SWIG_0(swigCPtr, eps);
    return ret;
  }

  public double Normalize() {
    double ret = UsdCsPINVOKE.GfQuatd_Normalize__SWIG_1(swigCPtr);
    return ret;
  }

  public GfQuatd GetConjugate() {
    GfQuatd ret = new GfQuatd(UsdCsPINVOKE.GfQuatd_GetConjugate(swigCPtr), true);
    return ret;
  }

  public GfQuatd GetInverse() {
    GfQuatd ret = new GfQuatd(UsdCsPINVOKE.GfQuatd_GetInverse(swigCPtr), true);
    return ret;
  }

  public static bool Equals(GfQuatd lhs, GfQuatd rhs) {
    bool ret = UsdCsPINVOKE.GfQuatd_Equals(GfQuatd.getCPtr(lhs), GfQuatd.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  override public int GetHashCode() {
    int ret = UsdCsPINVOKE.GfQuatd_GetHashCode(swigCPtr);
    return ret;
  }

    public static bool operator==(GfQuatd lhs, GfQuatd rhs){
	    // The Swig binding glue will re-enter this operator comparing to null, so 
	    // that case must be handled explicitly to avoid an infinite loop. This is still
	    // not great, since it crosses the C#/C++ barrier twice. A better approache might
	    // be to return a simple value from C++ that can be compared in C#.
      bool lnull = lhs as object == null;
      bool rnull = rhs as object == null;
      return (lnull == rnull) && ((lnull && rnull) || GfQuatd.Equals(lhs, rhs));
    }

    public static bool operator !=(GfQuatd lhs, GfQuatd rhs) {
        return !(lhs == rhs);
    }

	  override public bool Equals(object rhs) {
		  return GfQuatd.Equals(this, rhs as GfQuatd);
	  }
  
}

}
