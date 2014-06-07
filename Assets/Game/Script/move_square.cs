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
	public GUISkin mySkin = null;
	
	void Start()
	{
		//acquire controller
		controller = GetComponent<CharacterController>();
	}
	
	void OnGUI()
	{
		GUI.skin = mySkin;
		if (transform.position.y < 0.0) 
		{
			transform.position = new Vector3(1000, 10, 200);
		}
		//rotate controller
		GUILayout.Space(80);
		if(GUILayout.RepeatButton("rotate left"))
		{
			transform.Rotate(0,-rotateSpeed, 0);
		}
		GUILayout.Space(10);
		if(GUILayout.RepeatButton("rotate right"))
		{
			transform.Rotate(0,rotateSpeed, 0);
		}
		GUILayout.Space(10);
		//move
		if(GUILayout.RepeatButton("move forward"))
		{
			Vector3 forward = transform.TransformDirection(Vector3.forward);
			controller.Move(forward*moveSpeed);
		}
		GUILayout.Space(10);
		if(GUILayout.RepeatButton("move backward"))
		{
			Vector3 forward = transform.TransformDirection(Vector3.forward);
			controller.Move( forward*-moveSpeed);
		}
		GUILayout.Space(10);
		//fly
		if(GUILayout.RepeatButton("fly"))
		{
			transform.Translate(0, 0.5f, 0);   
		}
		GUILayout.Space(10);
		if(GUILayout.RepeatButton("land"))
		{
			if (transform.position.y > 1.0)
			{
				transform.Translate(0, -0.5f, 0);
			}
	
		}
	}
}
