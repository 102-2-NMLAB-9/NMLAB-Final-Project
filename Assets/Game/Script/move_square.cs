using UnityEngine;
using System.Collections;

public class move_square : MonoBehaviour 
{
	
	//controller
	private CharacterController controller = null;
	//translate speed
	private float moveSpeed = 10.0f;
	//rotate speed
	private float rotateSpeed = 2.0f;
	
	void Start()
	{
		//acquire controller
		controller = GetComponent<CharacterController>();
	}
	
	void OnGUI()
	{
		if (transform.position.y < 0.0) 
		{
			transform.position = new Vector3(1000, 10, 200);
		}
		//rotate controller
		GUILayout.Space(100);
		if(GUILayout.RepeatButton("rotate left", GUILayout.Height(50)))
		{
			transform.Rotate(0,-rotateSpeed, 0);
		}
		if(GUILayout.RepeatButton("rotate right", GUILayout.Height(50)))
		{
			transform.Rotate(0,rotateSpeed, 0);
		}
		
		//move
		if(GUILayout.RepeatButton("move forward", GUILayout.Height(50)))
		{
			Vector3 forward = transform.TransformDirection(Vector3.forward);
			controller.Move(forward*moveSpeed);
		}
		if(GUILayout.RepeatButton("move backward", GUILayout.Height(50)))
		{
			Vector3 forward = transform.TransformDirection(Vector3.forward);
			controller.Move( forward*-moveSpeed);
		}
		
		//fly
		if(GUILayout.RepeatButton("fly", GUILayout.Height(50)))
		{
			transform.Translate(0, 0.5f, 0);   
		}
		if(GUILayout.RepeatButton("land", GUILayout.Height(50)))
		{
			if (transform.position.y > 1.0)
			{
				transform.Translate(0, -0.5f, 0);
			}
	
		}
	}
}
