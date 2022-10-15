using UnityEngine;

namespace CubeMoving
{
	public class CubeMovement : MonoBehaviour
	{
		private float movementSpeed;
		private float destroyDistance;
		private Vector3 initialPosition;
		private Transform tr;

		private void Awake()
		{
			tr = transform;
		}

		private void Update()
		{
			tr.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
			if (Vector3.Distance(tr.position, initialPosition) > destroyDistance)
				Destroy(gameObject);
		}

		public void Move(float speed, float distance)
		{
			movementSpeed = speed;
			destroyDistance = distance;
			initialPosition = tr.position;
		}
	}
}