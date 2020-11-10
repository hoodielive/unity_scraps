using UnityEngine;
using System.Collections.Generic;

public class PlayerInput : MonoBehaviour
{
	public List<MyCollectableData> myCollection = new List<MyCollectableData>();
	
	void Awake()
	{
		// Make sure we start clean
		
		this.myCollection.Clear();
	}
	void Start() {  }

	void Update()
	{
		// Code for the movement of the Player (CP) foward.

		if (Input.GetKey(KeyCode.UpArrow))
		{
			this.transform.Translate(Vector3.forward * Time.deltaTime);
		}

		// Code for the movement of the Player (CP) backward.

		if (Input.GetKey(KeyCode.DownArrow))
		{
			this.transform.Translate(Vector3.back * Time.deltaTime);
		}

		// Code for the movement of the Player (CP) left.

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			this.transform.Rotate(Vector3.up, -5);
		}

		// Code for the movement of the Player (CP) Right.

		if (Input.GetKey(KeyCode.RightArrow))
		{
			this.transform.Rotate(Vector3.up, 5);
		}
	}
}


