using UnityEngine;
using UnityEngine.UI;

namespace CubeMoving
{
	public class CubeSpawner : MonoBehaviour
	{
		public static CubeSpawner instance;

		public InputField spawnInterval;
		public InputField movementSpeed;
		public InputField destroyDistance;
		public Material cubeMaterial;

		private float interval;
		private float speed;
		private float distance;
		private float nextTime = 0.0f;

		public float Speed
		{
			get { return speed; }
		}

		public float Distance
		{
			get { return distance; }
		}

		private void Start()
		{
			instance = this;

			GenerateValues();
		}

		private void Update()
		{
			if (Time.time > nextTime + interval)
			{
				nextTime = Time.time;
				Spawn();
			}
		}

		public void GenerateValues()
		{
			interval = float.Parse(spawnInterval.text);
			speed = float.Parse(movementSpeed.text);
			distance = float.Parse(destroyDistance.text);
		}

		private void Spawn()
		{
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			CubeMovement cubeMovement = cube.AddComponent<CubeMovement>();
			cube.GetComponent<Renderer>().material = cubeMaterial;
			cube.transform.SetPositionAndRotation(transform.position, transform.rotation);
		}
	}
}