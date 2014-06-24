using UnityEngine;
using System.Collections;

public class photon_clone : Photon.MonoBehaviour 
{
	
	//controller
	CharacterController controller = null;
	//translate speed
	float moveSpeed = 2.0f;
	//rotate speed
	float rotateSpeed = 2.0f;
	public GUISkin mySkin;

	public GameObject[] item;
	int showWindow1 = 0;
	int state = 0;
	int showWindow2 = 0;
	int showWindow3 = 0;
	string[] undelete = new string[] {"Terraingreen", "Terrainrock", "Terrainwhite", "Terrainyellow", "Me"};
	bool shoot = false;
	int yrotaion = 0;
	int order = 23;
	
	void Start()
	{
		//acquire controller
		controller = GetComponent<CharacterController>();
	}
	
	void OnGUI()
	{
		GUI.skin = mySkin;
		Rect windowRect1 = new Rect(250, 10, 1040, 610);
		Rect windowRect2 = new Rect (250, 10, 420, 410);
		Rect windowRect3 = new 	Rect(250,10,420,155);
		GUILayout.BeginHorizontal();
		if(GUILayout.Button("create"))
		{	
			showWindow1++;
			showWindow2=0;
			showWindow3=0;        
		}
		if(GUILayout.Button("destroy"))
		{	
			showWindow2++;
			showWindow1=0;
			showWindow3=0;
		}
		GUILayout.EndHorizontal();	
		GUILayout.Space(5);		
		if(GUILayout.Button("direction"))
		{	
			showWindow3++;
			showWindow1=0;
			showWindow2=0; 
		}	
		if(showWindow1%2==1)
		{    
			windowRect1 = GUI.Window(0, windowRect1, doWindow1, "My Window");
		}  
		if(showWindow2%2==1)
		{    
			windowRect2 = GUI.Window(0, windowRect2, doWindow2, "My Window");
		}  
		if(showWindow3%2==1)
		{    
			windowRect3 = GUI.Window(0, windowRect3, doWindow3, "My Window");
		}
		if (transform.position.y < 0.0) 
		{
			transform.position = new Vector3(1000, 10, 200);
		}
		//rotate controller
		GUILayout.Space(10);
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

	void doWindow1(int windowID)
	{
		if(GUI.Button(new Rect(10,20,200,60),"spider"))
		{  
			showWindow1++;
			state = 0;
			order = 0;
		}  
		if(GUI.Button(new Rect(215,20,200,60),"bench"))
		{  
			showWindow1++;
			state = 0;
			order = 1;       
			//Debug.Log("spider"); 
		}      
		if(GUI.Button(new Rect(420,20,200,60),"black chair"))
		{  
			showWindow1++;
			state = 0;
			order = 2;
		}  
		if(GUI.Button(new Rect(625,20,200,60),"shell chair"))
		{  
			showWindow1++;
			state = 0;
			order = 3;        
		}     
		if(GUI.Button(new Rect(830,20,200,60),"tabouret"))
		{  
			showWindow1++;
			state = 0;
			order = 4;
		}          
		if(GUI.Button(new Rect(10,85,200,60),"chair"))
		{             
			showWindow1++;
			state = 0;
			order = 5;
		}  
		if(GUI.Button(new Rect(215,85,200,60),"table"))
		{       
			showWindow1++;
			state = 0;
			order = 6;
		}     
		if(GUI.Button(new Rect(420,85,200,60),"flower1"))
		{  
			showWindow1++;
			state = 0;
			order = 7;
		}  
		if(GUI.Button(new Rect(625,85,200,60),"flower2"))
		{  
			showWindow1++;
			state = 0;
			order = 8;        
		}     
		if(GUI.Button(new Rect(830,85,200,60),"pergola"))
		{  
			showWindow1++;
			state = 0;
			order = 9;
		}      
		if(GUI.Button(new Rect(10,150,200,60),"sofa1"))
		{        
			showWindow1++;
			state = 0;
			order = 10;
		}  
		if(GUI.Button(new Rect(215,150,200,60),"sofa2"))
		{         
			showWindow1++;
			state = 0;
			order = 11;
		}  
		if(GUI.Button(new Rect(420,150,200,60),"building1"))
		{  
			showWindow1++;
			state = 0;
			order = 12;
		}  
		if(GUI.Button(new Rect(625,150,200,60),"building2"))
		{  
			showWindow1++;
			state = 0;
			order = 13;       
			//Debug.Log("spider"); 
		}     
		if(GUI.Button(new Rect(830,150,200,60),"building3"))
		{  
			showWindow1++;
			state = 0;
			order = 14;
		}      
		if(GUI.Button(new Rect(10,215,200,60),"book"))
		{  
			showWindow1++;
			state = 0;
			order = 15;
		}  
		if(GUI.Button(new Rect(215,215,200,60),"gorilla"))
		{        
			showWindow1++;
			state = 0;
			order = 16;
		}      
		if(GUI.Button(new Rect(420,215,200,60),"palm tree"))
		{  
			showWindow1++;
			state = 0;
			order = 17;
		}  
		if(GUI.Button(new Rect(625,215,200,60),"cactus"))
		{  
			showWindow1++;
			state = 0;
			order = 18;     
		}     
		if(GUI.Button(new Rect(830,215,200,60),"horse"))
		{  
			showWindow1++;
			state = 0;
			order = 19;
		}      
		if(GUI.Button(new Rect(10,280,200,60),"pylon"))
		{         
			showWindow1++;
			state = 0;
			order = 20;
		}  
		if(GUI.Button(new Rect(215,280,200,60),"tower"))
		{        
			showWindow1++;
			state = 0;
			order = 21;
		}  
		if(GUI.Button(new Rect(420,280,200,60),"brick"))
		{  
			showWindow1++;
			state = 0;
			order = 22;
		}  
		if(GUI.Button(new Rect(625,280,200,60),"stone"))
		{  
			showWindow1++;
			state = 0;
			order = 23;       
		}     
		if(GUI.Button(new Rect(830,280,200,60),"stone"))
		{  
			showWindow1++;
			state = 0;
			order = 23;
		}      
		if(GUI.Button(new Rect(10,345,200,60),"stone"))
		{       
			showWindow1++;
			state = 0;
			order = 23;
		}  
		if(GUI.Button(new Rect(215,345,200,60),"stone"))
		{  
			showWindow1++;
			state = 0;
			order = 23;
		}         
		if(GUI.Button(new Rect(420,345,200,60),"stone"))
		{  
			showWindow1++;
			state = 0;
			order = 23;
		}  
		if(GUI.Button(new Rect(625,345,200,60),"stone"))
		{  
			showWindow1++;
			state = 0;
			order = 23;        
			//Debug.Log("spider"); 
		}     
		if(GUI.Button(new Rect(830,345,200,60),"stone"))
		{  
			showWindow1++;
			state = 0;
			order = 23;
		}       
		if(GUI.Button(new Rect(10,410,200,60),"stone"))
		{        
			showWindow1++;
			state = 0;
			order = 23;
		}  
		if(GUI.Button(new Rect(215,410,200,60),"stone"))
		{  
			showWindow1++;
			state = 0;
			order = 23;
		}      
		if(GUI.Button(new Rect(420,410,200,60),"stone"))
		{  
			showWindow1++;
			state = 0;
			order = 23;
		}  
		if(GUI.Button(new Rect(625,410,200,60),"stone"))
		{  
			showWindow1++;
			state = 0;
			order = 23;      
			//Debug.Log("spider"); 
		}     
		if(GUI.Button(new Rect(830,410,200,60),"stone"))
		{  
			showWindow1++;
			state = 0;
			order = 23;
		}        
		if(GUI.Button(new Rect(10,475,200,60),"stone"))
		{      
			showWindow1++;
			state = 0;
			order = 23;
		}  
		if(GUI.Button(new Rect(215,475,200,60),"stone"))
		{  
			showWindow1++;
			state = 0;
			order = 23;
		}      
		if(GUI.Button(new Rect(420,475,200,60),"stone"))
		{  
			showWindow1++;
			state = 0;
			order = 23;
		}  
		if(GUI.Button(new Rect(625,475,200,60),"stone"))
		{  
			showWindow1++;
			state = 0;
			order = 23;        
			//Debug.Log("spider"); 
		}     
		if(GUI.Button(new Rect(830,475,200,60),"stone"))
		{  
			showWindow1++;
			state = 0;
			order = 23;
		}      
		if(GUI.Button(new Rect(10,540,200,60),"stone"))
		{   
			showWindow1++;  
			state = 0;
			order = 23;
		}  
		if(GUI.Button(new Rect(215,540,200,60),"stone"))
		{  
			showWindow1++;   
			state = 0;
			order = 23;
		}    
		if(GUI.Button(new Rect(420,540,200,60),"stone"))
		{  
			showWindow1++;
			state = 0;
			order = 23;
		}  
		if(GUI.Button(new Rect(625,540,200,60),"stone"))
		{  
			showWindow1++;
			state = 0;
			order = 23;
		}     
		if(GUI.Button(new Rect(830,540,200,60),"stone"))
		{  
			showWindow1++;   
			state = 0;
			order = 23;
		}             
	}  
	
	
	void doWindow2(int windowID)
	{
		shoot = false;
		if(GUI.Button(new Rect(10,20,200,60),"flame"))
		{
			state = 1;
			showWindow2++;
			order = 24; 
		}
		if(GUI.Button(new Rect(215,20,200,60),"Grenade"))
		{
			state = 1;
			showWindow2++;
			order = 25;
			shoot = true;
		}
		if(GUI.Button(new Rect(10,85,200,60),"destroy"))
		{
			state = 1;
			showWindow2++;
		}
		if(GUI.Button(new Rect(215,85,200,60),"destroy"))
		{
			state = 1;
			showWindow2++;
		}
		if(GUI.Button(new Rect(10,150,200,60),"destroy"))
		{
			state = 1;
			showWindow2++;
		}
		if(GUI.Button(new Rect(215,150,200,60),"spider"))
		{
			state = 1;
			showWindow2++;
		}  
		if(GUI.Button(new Rect(10,215,200,60),"flame"))
		{
			state = 1;
			showWindow2++;
		}  
		if(GUI.Button(new Rect(215,215,200,60),"spider"))
		{
			state = 1;
			showWindow2++;
		}      
		if(GUI.Button(new Rect(10,280,200,60),"spider"))
		{
			state = 1;
			showWindow2++;
		}  
		if(GUI.Button(new Rect(215,280,200,60),"spider"))
		{
			state = 1;
			showWindow2++;
		}  
		if(GUI.Button(new Rect(10,345,200,60),"spider"))
		{
			state = 1;
			showWindow2++;
		}  
		if(GUI.Button(new Rect(215,345,200,60),"elephant"))
		{
			state = 1;
			showWindow2++;
		}         
	}  
	
	void doWindow3(int windowID)
	{
		if(GUI.Button(new Rect(10,20,200,60),"North"))
		{
			state=0;
			showWindow3++;
			yrotaion=0;
		}
		if(GUI.Button(new Rect(215,20,200,60),"East"))
		{
			state=0;
			showWindow3++;
			yrotaion=90;        
		}
		if(GUI.Button(new Rect(10,85,200,60),"South"))
		{
			state=0;
			showWindow3++;
			yrotaion=180;        
		}
		if(GUI.Button(new Rect(215,85,200,60),"West"))
		{
			state=0;
			showWindow3++;
			yrotaion=270;        
		}            
	} 
	
	void Update() 
	{
		if(Input.GetMouseButtonDown(0) && state == 0 && GUIUtility.hotControl == 0)
		{
			Add ();
			
		}
		else if(Input.GetMouseButtonDown(0) && state == 1 && GUIUtility.hotControl == 0)
		{
			Remove();
		}	
	}
	
	void Remove()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit))
		{
			bool check = true;
			GameObject obj = hit.collider.gameObject;
			for(int i=0; i<5; i++)
			{
				if(obj.name == undelete[i]) {check = false;}
			}
			if( item != null ) {
				if( !shoot) {
					var clone1 = Instantiate(item[order], hit.point, item[order].transform.rotation) as GameObject;
					Destroy (clone1, 2);					
					if(check)
					{
						Destroy(obj);
					}
				}else {
					GameObject tmp = GameObject.Find("Me");
					Vector3 front = tmp.transform.forward.normalized;
					var clone2 = Instantiate(item[order], tmp.transform.position+front, item[order].transform.rotation) as GameObject;
					Rigidbody grenade_rigidbody = clone2.rigidbody;
					

					grenade_rigidbody.velocity = (hit.point - tmp.transform.position).normalized*70;
					Destroy (clone2, 4);
				}
			}			
		}
	}
	
	void Add()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit))
		{	
			if(item == null)
			{
				GameObject objCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
				objCube.transform.position = hit.point;
				objCube.renderer.material.color = Color.magenta;		    
			}
			else
			{			
				Quaternion myrotation = Quaternion.Euler(item[order].transform.eulerAngles.x , yrotaion + item[order].transform.eulerAngles.y , item[order].transform.eulerAngles.z);
				PhotonNetwork.Instantiate(item[order].name, hit.point, myrotation, 0);
			}
		}
	}	
}
