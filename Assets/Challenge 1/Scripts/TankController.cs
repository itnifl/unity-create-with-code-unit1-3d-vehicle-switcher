using UnityEngine;

public class TankController : MonoBehaviour
{
	public float speed = 5f;
	public float rotationSpeed = 75f;

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

		// Move forward/backward
		transform.Translate(Vector3.forward * verticalInput * speed * Time.fixedDeltaTime);

		// Rotate left/right
		transform.Rotate(Vector3.up * horizontalInput * rotationSpeed * Time.fixedDeltaTime);
	}

	public void SetActive(bool active)
	{
		isActive = active;
	}
}
