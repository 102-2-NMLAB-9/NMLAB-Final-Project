using UnityEngine;
using System.Collections;

public class add_square : MonoBehaviour {

	void Update() 
	{
		//left button click
		if(Input.GetMouseButtonDown(0) && GUIUtility.hotControl == 0)
		{
			//establish a ray
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			//ray hit floor
			if (Physics.Raycast(ray, out hit))
			{
				//create square
				GameObject objCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
				objCube.transform.position = hit.point;

			}
		}
	}
}
