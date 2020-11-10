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

		if (Input.GetKeyUp(KeyCode.Z))
		{
			foreach (var d in this.myCollection)
			{
				Debug.Log(d.ID);
			}
		}
	}

	void OnTriggerEnter2D(Collider c)
	{
		if (c.tag.Equals("MyCollectable"))
		{
			var collect = c.gameObject.GetComponent<MyCollectable>();
			MyCollectableData data = new MyCollectableData();

			data.ID = collect.ID;
			data.size = collect.size;

			this.myCollection.Add(data);
			Destroy(c.gameObject);
		}
	}
}


