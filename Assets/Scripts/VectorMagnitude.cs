using UnityEngine;

public class VectorMagnitude : MonoBehaviour
{
    public Vector3 positionVector;
    [ReadOnly]
    public float speed;

    private void OnDrawGizmos() {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, positionVector);
        speed = positionVector.magnitude;
    }
}
