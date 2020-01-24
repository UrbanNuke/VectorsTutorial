using UnityEngine;

public class VectorSum : MonoBehaviour {
    public GameObject secondCube;
    public Vector3 toSecondCubeVector;
    public Vector3 endVector;

    [ReadOnly]
    public Vector3 sumVector;

    private void OnDrawGizmos() {
        secondCube.transform.position = toSecondCubeVector;

        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, toSecondCubeVector);
        Gizmos.color = Color.green;
        Gizmos.DrawRay(toSecondCubeVector, endVector);
        Gizmos.color = Color.blue;
        sumVector = toSecondCubeVector + endVector;
        Gizmos.DrawLine(transform.position, sumVector);
    }
}
