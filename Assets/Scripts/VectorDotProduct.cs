using UnityEngine;

public class VectorDotProduct : MonoBehaviour
{
    public GameObject secondCube;
    public Vector3 firstVector;
    public Vector3 secondVector;
    [ReadOnly]
    public float resultScalar;

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, firstVector);
        Gizmos.color = Color.green;
        Gizmos.DrawRay(secondCube.transform.position, secondVector);
        resultScalar = Vector3.Dot(firstVector.normalized, secondVector.normalized);
    }
}
