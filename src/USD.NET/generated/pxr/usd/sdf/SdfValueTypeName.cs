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

public class SdfValueTypeName : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SdfValueTypeName(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SdfValueTypeName obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SdfValueTypeName() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_SdfValueTypeName(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SdfValueTypeName() : this(UsdCsPINVOKE.new_SdfValueTypeName(), true) {
  }

  public TfToken GetAsToken() {
    TfToken ret = new TfToken(UsdCsPINVOKE.SdfValueTypeName_GetAsToken(swigCPtr), true);
    return ret;
  }

  public TfType GetTfType() {
    TfType ret = new TfType(UsdCsPINVOKE.SdfValueTypeName_GetTfType(swigCPtr), false);
    return ret;
  }

  public TfToken GetRole() {
    TfToken ret = new TfToken(UsdCsPINVOKE.SdfValueTypeName_GetRole(swigCPtr), false);
    return ret;
  }

  public VtValue GetDefaultValue() {
    VtValue ret = new VtValue(UsdCsPINVOKE.SdfValueTypeName_GetDefaultValue(swigCPtr), false);
    return ret;
  }

  public SdfValueTypeName GetScalarType() {
    SdfValueTypeName ret = new SdfValueTypeName(UsdCsPINVOKE.SdfValueTypeName_GetScalarType(swigCPtr), true);
    return ret;
  }

  public SdfValueTypeName GetArrayType() {
    SdfValueTypeName ret = new SdfValueTypeName(UsdCsPINVOKE.SdfValueTypeName_GetArrayType(swigCPtr), true);
    return ret;
  }

  public bool IsScalar() {
    bool ret = UsdCsPINVOKE.SdfValueTypeName_IsScalar(swigCPtr);
    return ret;
  }

  public bool IsArray() {
    bool ret = UsdCsPINVOKE.SdfValueTypeName_IsArray(swigCPtr);
    return ret;
  }

  public ulong GetHash() {
    ulong ret = UsdCsPINVOKE.SdfValueTypeName_GetHash(swigCPtr);
    return ret;
  }

  public TfTokenVector GetAliasesAsTokens() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.SdfValueTypeName_GetAliasesAsTokens(swigCPtr), true);
    return ret;
  }

  public static bool Equals(SdfValueTypeName lhs, SdfValueTypeName rhs) {
    bool ret = UsdCsPINVOKE.SdfValueTypeName_Equals(SdfValueTypeName.getCPtr(lhs), SdfValueTypeName.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  override public int GetHashCode() {
    int ret = UsdCsPINVOKE.SdfValueTypeName_GetHashCode(swigCPtr);
    return ret;
  }

    public static bool operator==(SdfValueTypeName lhs, SdfValueTypeName rhs){
	    // The Swig binding glue will re-enter this operator comparing to null, so 
	    // that case must be handled explicitly to avoid an infinite loop. This is still
	    // not great, since it crosses the C#/C++ barrier twice. A better approache might
	    // be to return a simple value from C++ that can be compared in C#.
      bool lnull = lhs as object == null;
      bool rnull = rhs as object == null;
      return (lnull == rnull) && ((lnull && rnull) || SdfValueTypeName.Equals(lhs, rhs));
    }

    public static bool operator !=(SdfValueTypeName lhs, SdfValueTypeName rhs) {
        return !(lhs == rhs);
    }

	  override public bool Equals(object rhs) {
		  return SdfValueTypeName.Equals(this, rhs as SdfValueTypeName);
	  }
  
}

}
