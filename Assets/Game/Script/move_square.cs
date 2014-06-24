using UnityEngine;
using System.Collections;

public class move_square : MonoBehaviour 
{
	
	//controller
	CharacterController controller = null;
	//translate speed
	float moveSpeed = 10.0f;
	//rotate speed
	float rotateSpeed = 2.0f;
	public GUISkin mySkin;
	GameObject item = null;
	public GameObject grenadeobj = null; 
	int showWindow1 = 0;
	int state = 0;
	int showWindow2 = 0;
	int showWindow3 = 0;
	string[] undelete = new string[] {"Terraingreen", "Terrainrock", "Terrainwhite", "Terrainyellow", "Me"};
	bool shoot = false;
	int yrotaion = 0;
	
	void Start()
	{
		//acquire controller
		controller = GetComponent<CharacterController>();
	}
	
	void OnGUI()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Application.LoadLevel(0);
		}
		GUI.skin = mySkin;
		Rect windowRect1 = new Rect(250, 10, 1010, 610);
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
		if(GUI.Button(new Rect(10,20,190,60),"spider"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("Spider01");
		}  
		if(GUI.Button(new Rect(210,20,190,60),"bench"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("Table_Wood");        
			//Debug.Log("spider"); 
		}      
		if(GUI.Button(new Rect(410,20,190,60),"black chair"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("plasticchair_white");
		}  
		if(GUI.Button(new Rect(610,20,190,60),"shell chair"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("Amphi100_Chair02");        
		}     
		if(GUI.Button(new Rect(810,20,190,60),"tabouret"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("tabouret_2");
		}          
		if(GUI.Button(new Rect(10,85,190,60),"chair"))
		{  
			item=GameObject.Find("Chair_Metal_02");            
			showWindow1++;
			state = 0;
		}  
		if(GUI.Button(new Rect(210,85,190,60),"table"))
		{  
			item=GameObject.Find("Table_Metal");      
			showWindow1++;
			state = 0;
		}     
		if(GUI.Button(new Rect(410,85,190,60),"flower1"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("Furniture_foliageplant_08_LOD1");
		}  
		if(GUI.Button(new Rect(610,85,190,60),"flower2"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("Furniture_foliageplant_10_LOD0");        
		}     
		if(GUI.Button(new Rect(810,85,190,60),"pergola"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("Furniture_flowerstand_01_LOD1");
		}      
		if(GUI.Button(new Rect(10,150,190,60),"sofa1"))
		{  
			item=GameObject.Find("sofa1");       
			showWindow1++;
			state = 0;
		}  
		if(GUI.Button(new Rect(210,150,190,60),"sofa2"))
		{  
			item=GameObject.Find("sofa2");       
			showWindow1++;
			state = 0;
		}  
		if(GUI.Button(new Rect(410,150,190,60),"building1"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("Building_10");
		}  
		if(GUI.Button(new Rect(610,150,190,60),"building2"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("Building_11");        
		}     
		if(GUI.Button(new Rect(810,150,190,60),"building3"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("building_11");
		}      
		if(GUI.Button(new Rect(10,215,190,60),"book"))
		{  
			item=GameObject.Find("book_0001c");
			showWindow1++;
			state = 0;
		}  
		if(GUI.Button(new Rect(210,215,190,60),"gorilla"))
		{  
			item=GameObject.Find("Gorilla");       
			showWindow1++;
			state = 0;
		}      
		if(GUI.Button(new Rect(410,215,190,60),"palm tree"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("Palm");
		}  
		if(GUI.Button(new Rect(610,215,190,60),"cactus"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("Cactus_Tall_03");        
		}     
		if(GUI.Button(new Rect(810,215,190,60),"horse"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("Horse");
		}      
		if(GUI.Button(new Rect(10,280,190,60),"pylon"))
		{  
			item=GameObject.Find("pylon_2lanes_lod0");       
			showWindow1++;
			state = 0;
		}  
		if(GUI.Button(new Rect(210,280,190,60),"tower"))
		{  
			item=GameObject.Find("Watchtower_Main");       
			showWindow1++;
			state = 0;
		}  
		if(GUI.Button(new Rect(410,280,190,60),"brick"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("Brick_Red_01");
		}  
		if(GUI.Button(new Rect(610,280,190,60),"stone"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("stone");        
		}     
		if(GUI.Button(new Rect(810,280,190,60),"building4"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("building_06");
		}      
		if(GUI.Button(new Rect(10,345,190,60),"piano"))
		{  
			item=GameObject.Find("piano");      
			showWindow1++;
			state = 0;
		}  
		if(GUI.Button(new Rect(210,345,190,60),"cake"))
		{  
			item=GameObject.Find("Cake");     
			showWindow1++;
			state = 0;
		}         
		if(GUI.Button(new Rect(410,345,190,60),"milk"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("Milk");
		}  
		if(GUI.Button(new Rect(610,345,190,60),"ice cream"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("IceCream");        
		}     
		if(GUI.Button(new Rect(810,345,190,60),"hambuger"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("Hambuger");
		}       	
		if(GUI.Button(new Rect(10,410,190,60),"bed"))
		{  
			item=GameObject.Find("bed_LowPoly");      
			showWindow1++;
			state = 0;
		}  
		if(GUI.Button(new Rect(210,410,190,60),"elephant"))
		{  
			showWindow1++;
			state = 0;
		}      
		if(GUI.Button(new Rect(410,410,190,60),"spider"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("Spider01");
		}  
		if(GUI.Button(new Rect(610,410,190,60),"bench"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("Table_Wood");        
			//Debug.Log("spider"); 
		}     
		if(GUI.Button(new Rect(810,410,190,60),"spider"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("Spider01");
		}        
		if(GUI.Button(new Rect(10,475,190,60),"sofa1"))
		{  
			item=GameObject.Find("sofa1");      
			showWindow1++;
			state = 0;
		}  
		if(GUI.Button(new Rect(210,475,190,60),"elephant"))
		{  
			showWindow1++;
			state = 0;
		}      
		if(GUI.Button(new Rect(410,475,190,60),"spider"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("Spider01");
		}  
		if(GUI.Button(new Rect(610,475,190,60),"bench"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("Table_Wood");        
			//Debug.Log("spider"); 
		}     
		if(GUI.Button(new Rect(810,475,190,60),"spider"))
		{  
			showWindow1++;
			state = 0;
			item=GameObject.Find("Spider01");
		}      
		if(GUI.Button(new Rect(10,540,190,60),"normal"))
		{   
			showWindow1++;  
			state = 0;
		}  
		if(GUI.Button(new Rect(210,540,190,60),"north"))
		{  
			showWindow1++;   
			state = 0;               
		}    
		if(GUI.Button(new Rect(410,540,190,60),"south"))
		{  
			showWindow1++;
			state = 0;   		
		}  
		if(GUI.Button(new Rect(610,540,190,60),"east"))
		{  
			showWindow1++;
			state = 0;   
		}     
		if(GUI.Button(new Rect(810,540,190,60),"brick wall"))
		{  
			showWindow1++;   
			state = 0;     	 
			item=GameObject.Find("wallBrickExposed");
		}             
	}  
	
	
	void doWindow2(int windowID)
	{
		shoot = false;
		if(GUI.Button(new Rect(10,20,200,60),"flame"))
		{
			state = 1;
			showWindow2++;
			item=GameObject.Find("Flame"); 
		}
		if(GUI.Button(new Rect(215,20,200,60),"Grenade"))
		{
			state = 1;
			showWindow2++;
			item = grenadeobj;
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
			showWindow2++;
			state = 1;
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
					var clone1 = Instantiate(item, hit.point, item.transform.rotation) as GameObject;
					Destroy (clone1, 2);					
					if(check)
					{
						Destroy(obj);
					}
				}else {
					GameObject tmp = GameObject.Find("Me");
					Vector3 front = tmp.transform.forward.normalized;
					var clone2 = Instantiate(item, tmp.transform.position+front, item.transform.rotation) as GameObject;
					Rigidbody grenade_rigidbody = clone2.rigidbody;
					
					if(clone2.rigidbody == null) 
					{
						grenade_rigidbody = clone2.AddComponent("Rigidbody") as Rigidbody;
					}
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
				
				Quaternion myrotation = Quaternion.Euler(item.transform.eulerAngles.x , yrotaion + item.transform.eulerAngles.y , item.transform.eulerAngles.z);
				var clone = Instantiate(item, hit.point, myrotation) as GameObject;
				Destroy (clone, 60);
			}
		}
	}	
}
