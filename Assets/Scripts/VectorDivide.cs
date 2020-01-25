using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorDivide : MonoBehaviour
{
    public float scalar;
    public Vector3 vectorForDivide;
    [ReadOnly]
    public Vector3 resultVector;

    private void OnDrawGizmos() {
        Gizmos.color = Color.blue;
        resultVector = vectorForDivide / scalar;
        Gizmos.DrawRay(transform.position, resultVector);
    }
}
