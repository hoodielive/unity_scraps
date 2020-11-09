using System.Unity;

public class MyCollectable : MonoBehaviour 
{
	void Start() { } 
	void Update() { } 

	void OnTriggerEnter2D(Collider c)
	{
		Debug.Log("You have bumped into me!!!");
	}
}
