using UnityEngine;

class rotate_square : MonoBehaviour {
	
	void Update()
	{
		//rotate
		transform.Rotate(0.0f,Time.deltaTime * 200,0.0f);
		//translate
		transform.Translate(Vector3.forward * Time.deltaTime * 3);
	}
}