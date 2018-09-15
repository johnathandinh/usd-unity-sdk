﻿// Copyright 2018 Jeremy Cowles. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;

namespace USD.NET.Unity {

  [System.Serializable]
  [USD.NET.UsdSchema("PointInstancer")]
  class PointInstancerSample : BoundableSample {
    public USD.NET.Relationship prototypes = new USD.NET.Relationship();
    public int[] protoIndices;
    public long[] ids;
    public long[] invisibleIds;
    public Vector3[] positions;
    public Quaternion[] rotations;
    public Vector3[] scales;
    public Vector3[] velocities;
    public Vector3[] angularVelocities;

    public Matrix4x4[] ComputeInstanceMatrices(USD.NET.Scene scene, string primPath) {
      var prim = scene.GetPrimAtPath(primPath);
      var pi = new pxr.UsdGeomPointInstancer(prim);
      var xforms = new pxr.VtMatrix4dArray();

      pi.ComputeInstanceTransformsAtTime(xforms, scene.Time == null ? pxr.UsdTimeCode.Default() : scene.Time, 0);

      // Slow, but works.
      var matrices = new UnityEngine.Matrix4x4[xforms.size()];
      for (int i = 0; i < xforms.size(); i++) {
        matrices[i] = UnityTypeConverter.FromMatrix(xforms[i]);
      }
      return matrices;
    }
  }
}
