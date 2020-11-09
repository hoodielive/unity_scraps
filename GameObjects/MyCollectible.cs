using System.Unity;

public class MyCollectable : MonoBehaviour 
{
	public int ID; 
	public float size; 

	void Start() 
	{
		this.transform.localScale = new Vector3(size, size, size)
	} 
	void Update() { } 

	void OnTriggerEnter2D(Collider c)
	{
		Debug.Log("You have bumped into me!!!");
	}
}
