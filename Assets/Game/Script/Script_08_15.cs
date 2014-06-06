using UnityEngine;
using System.Collections;

public class Script_08_15 : MonoBehaviour {

	void Update() 
	{
		//鼠标按下左键
		if(Input.GetMouseButtonDown(0))
		{
			//创建一条射线以摄像机为原点
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			//射线碰撞到游戏地形时
			if (Physics.Raycast(ray, out hit))
			{
				//创建立方体
				GameObject objCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
				objCube.transform.position = hit.point;

			}
		}
	}
}
