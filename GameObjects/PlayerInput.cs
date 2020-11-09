using UnityEngine;
using System.Collections; 

public class PlayerInput : MonoBehaviour
{
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
			this.transform.Translate(Vector3.up, -5);
		}
		
		// Code for the movement of the Player (CP) Right.

		if (Input.GetKey(KeyCode.RightArrow))
		{
			this.transform.Translate(Vector3.up, 5);
		}
	}
}


