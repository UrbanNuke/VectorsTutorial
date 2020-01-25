using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMupltiply : MonoBehaviour {

    public float scalar;
    public Vector3 vectorForMultiply;
    [ReadOnly]
    public Vector3 resultVector;

    private void OnDrawGizmos() {
        Gizmos.color = Color.blue;
        resultVector = vectorForMultiply * scalar;
        Gizmos.DrawRay(transform.position, resultVector);
    }
}
