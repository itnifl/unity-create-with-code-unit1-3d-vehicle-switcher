using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float speed = 60f;
    public float turnSpeed = 75f;
    public float verticalTurnSpeed = 50f;

    public bool isActive = false;

    private float verticalInput;
    private float horizontalInput;

    void Update()
    {
        if (!isActive) return;

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        if (!isActive) return;

        transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
        transform.Rotate(Vector3.right * verticalTurnSpeed * verticalInput * Time.fixedDeltaTime);
        transform.Rotate(Vector3.back * turnSpeed * horizontalInput * Time.fixedDeltaTime);

        float rollAngle = Mathf.LerpAngle(transform.eulerAngles.z, -horizontalInput * 45f, Time.fixedDeltaTime);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, rollAngle);
    }

    public void SetActive(bool active)
    {
        isActive = active;
    }
}
