using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorDifference : MonoBehaviour
{
    public GameObject secondCube;
    public Vector3 toSecondCubeVector;

    [ReadOnly]
    public Vector3 differenceVector;

    private void OnDrawGizmos() {
        secondCube.transform.position = toSecondCubeVector;

        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, toSecondCubeVector);
        Gizmos.color = Color.blue;
        differenceVector = toSecondCubeVector - transform.position;
        Gizmos.DrawRay(transform.position, differenceVector);
    }
}
