using UnityEngine;
using System.Collections;

public class add_square : Photon.MonoBehaviour {
	
	private int state = 0;
	private float time = 0.0f;
	private string[] undel = new string[]{"Terraingreen", "Terrainrock", "Terrainwhite", "Terrainyellow", "Me"};
	public Transform playerPrefab;
	
	void Update() 
	{
		time += Time.deltaTime;
		//left button click
		if(Input.GetMouseButtonDown(0) && GUIUtility.hotControl == 0)
		{
			state = 1;
			Add ();
		}
		else if(Input.GetMouseButtonDown(1) && GUIUtility.hotControl == 0)
		{
			state = 2;
			Remove();
		}
		else if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
		{
			state = 0;
		}
		
		if (state == 0) 
		{
			time = 0.0f;
		} 
		else if (state == 1 && time > 0.2f) 
		{
			Add();
			time = 0.0f;
		} 
		else if (state == 2 && time > 0.2f)
		{
			Remove();
			time = 0.0f;
		}
	}
	
	void Remove()
	{
		//establish a ray
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		//ray hit floor
		if (Physics.Raycast(ray, out hit))
		{
			//destroy square
			bool chk = true;
			GameObject obj = hit.collider.gameObject;
			for(int i=0; i<5; i++)
				if(obj.name == undel[i])
					chk = false;
			if(chk)
			{		
				Destroy(obj);
			}
		}
	}
	
	void Add()
	{
		//establish a ray
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		//ray hit floor
		if (Physics.Raycast(ray, out hit))
		{
			//create spider
			PhotonNetwork.Instantiate(this.playerPrefab.name, hit.point, Quaternion.identity, 0);
		}
	}
}