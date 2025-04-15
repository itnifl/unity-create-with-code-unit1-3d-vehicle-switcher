using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 5, -15);
    public float smoothSpeed = 5f;

    public void SetTarget(GameObject newPlayer)
    {
        player = newPlayer;
    }

    void LateUpdate()
    {
        if (player == null) return;

        Vector3 desiredPosition = player.transform.position + player.transform.TransformDirection(offset);
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        Quaternion desiredRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, smoothSpeed * Time.deltaTime);
    }
}
