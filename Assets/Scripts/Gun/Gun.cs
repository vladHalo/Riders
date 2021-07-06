using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour
{
	public float speedRotX, speedRotY;
	public float speed;
	public GameObject bullet;
	
	Rigidbody bulletNew;
	Rendering rendering;
	Vector3 speedFly;
	float g = Physics.gravity.y;
	float X, Y;
	bool shot=true;

	private void Start()
	{
		rendering = GetComponent<Rendering>();
	}

	private void Update()
	{
		if (shot==false) return;

		if (Input.GetKey(KeyCode.Mouse0))
		{
			X += Input.GetAxis("Mouse X") * speedRotX;
			X = Mathf.Clamp(X, -250f, 250f);

			Y -= Input.GetAxis("Mouse Y") * speedRotY;
			Y = Mathf.Clamp(Y, -0.50f, -0.01f);

			rendering.lineRenderer.enabled = true;

			float t = 2 * speed * Mathf.Sin(Y) / g;
			float vX = speed * Mathf.Cos(Y);
			float vY = speed * Mathf.Sin(Y) - g * t;
			speedFly = new Vector3(X, vY, vX);
			rendering.ShowTrajectory(transform.localPosition, speedFly);
		}

		if (Input.GetKeyUp(KeyCode.Mouse0))
		{
			rendering.lineRenderer.enabled = false;
			bulletNew = Instantiate(bullet, transform.position, Quaternion.Euler(X, 0f, 0f)).GetComponent<Rigidbody>();
			bulletNew.AddForce(speedFly, ForceMode.VelocityChange);
			
			shot = false;
			StartCoroutine("Shot");
			X = 0; Y = -0.01f;
		}
	}

	IEnumerator Shot()
	{
		yield return new WaitForSeconds(1f);
		shot = true;
	}
}