using UnityEngine;

namespace CubeMoving
{
	public class CubeMovement : MonoBehaviour
	{
		private Transform tr;
		private Vector3 initialPosition;

		private void Start()
		{
			tr = transform;
			initialPosition = tr.position;
		}

		private void Update()
		{
			tr.Translate(Vector3.forward * Time.deltaTime * CubeSpawner.instance.Speed);
			if (Vector3.Distance(tr.position, initialPosition) > CubeSpawner.instance.Distance)
				Destroy(gameObject);
		}
	}
}