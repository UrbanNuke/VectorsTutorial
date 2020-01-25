using UnityEngine;

public class VectorCrossProduct : MonoBehaviour {
    public Vector3 firstVector;
    public Vector3 secondVector;

    [ReadOnly]
    public Vector3 crossProduct;

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, firstVector);
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, secondVector);

        crossProduct = Vector3.Cross(firstVector, secondVector);
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, crossProduct);
    }
}
