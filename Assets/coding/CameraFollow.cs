using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // 通常是 Player
    public Vector3 offset = new Vector3(0f, 2f, -5f); // 相机与目标的偏移
    public float smoothSpeed = 5f;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        transform.position = smoothedPosition;
        transform.LookAt(target); // 让相机一直朝向目标
    }
}
