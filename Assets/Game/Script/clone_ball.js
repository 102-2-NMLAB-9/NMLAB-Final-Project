//ball
@HideInInspector
var object:GameObject = null;

var grenadeobj : GameObject;
var mySkin : GUISkin; 
var showWindow:int = 0;
var state:int = 0;
var showWindow2:int = 0;
var undelete = ["Terraingreen", "Terrainrock", "Terrainwhite", "Terrainyellow", "Me"];
var shoot: boolean = false;

function OnGUI()
{
	GUI.skin = mySkin;	 
	GUILayout.BeginHorizontal();
	if(GUILayout.Button("create"))
	{	
        showWindow++;
	}
	if(GUILayout.Button("destroy"))
	{	
        showWindow2++;
	}
	GUILayout.EndHorizontal();
	if(showWindow%2==1)
	{    
	   GUI.Window(0,Rect(250,10,1040,610),doWindow,"選單");
	}
	if(showWindow2%2==1)
	{    
	   GUI.Window(0,Rect(250,10,420,410),doWindow2,"選單");
	}
}

function doWindow(windowID:int){
    if(GUI.Button(Rect(10,20,200,60),"spider"))
    {  
        showWindow++;
       	state = 0;
        object=GameObject.Find("Spider01");
    }  
    if(GUI.Button(Rect(215,20,200,60),"bench"))
    {  
        showWindow++;
        state = 0;
        object=GameObject.Find("Table_Wood");        
        //Debug.Log("spider"); 
    }      
    if(GUI.Button(Rect(420,20,200,60),"black chair"))
    {  
        showWindow++;
       	state = 0;
        object=GameObject.Find("plasticchair_white");
    }  
    if(GUI.Button(Rect(625,20,200,60),"shell chair"))
    {  
        showWindow++;
        state = 0;
        object=GameObject.Find("Amphi100_Chair02");        
    }     
    if(GUI.Button(Rect(830,20,200,60),"tabouret"))
    {  
        showWindow++;
       	state = 0;
        object=GameObject.Find("tabouret_2");
    }          
    if(GUI.Button(Rect(10,85,200,60),"chair"))
    {  
        object=GameObject.Find("Chair_Metal_02");            
        showWindow++;
        state = 0;
    }  
    if(GUI.Button(Rect(215,85,200,60),"table"))
    {  
        object=GameObject.Find("Table_Metal");      
        showWindow++;
        state = 0;
    }     
    if(GUI.Button(Rect(420,85,200,60),"flower1"))
    {  
        showWindow++;
       	state = 0;
        object=GameObject.Find("Furniture_foliageplant_08_LOD1");
    }  
    if(GUI.Button(Rect(625,85,200,60),"flower2"))
    {  
        showWindow++;
        state = 0;
        object=GameObject.Find("Furniture_foliageplant_10_LOD0");        
    }     
    if(GUI.Button(Rect(830,85,200,60),"pergola"))
    {  
        showWindow++;
       	state = 0;
        object=GameObject.Find("Furniture_flowerstand_01_LOD1");
    }      
    if(GUI.Button(Rect(10,150,200,60),"sofa1"))
    {  
        object=GameObject.Find("sofa1");       
        showWindow++;
        state = 0;
    }  
    if(GUI.Button(Rect(215,150,200,60),"sofa2"))
    {  
        object=GameObject.Find("sofa2");       
        showWindow++;
        state = 0;
    }  
    if(GUI.Button(Rect(420,150,200,60),"building1"))
    {  
        showWindow++;
       	state = 0;
        object=GameObject.Find("Building_10");
    }  
    if(GUI.Button(Rect(625,150,200,60),"building2"))
    {  
        showWindow++;
        state = 0;
        object=GameObject.Find("Building_11");        
        //Debug.Log("spider"); 
    }     
    if(GUI.Button(Rect(830,150,200,60),"building3"))
    {  
        showWindow++;
       	state = 0;
        object=GameObject.Find("MedievelHouse");
    }      
    if(GUI.Button(Rect(10,215,200,60),"book"))
    {  
    	object = GameObject.Find("book_0001c");
        showWindow++;
        state = 0;
    }  
    if(GUI.Button(Rect(215,215,200,60),"gorilla"))
    {  
        object=GameObject.Find("Gorilla");       
        showWindow++;
        state = 0;
    }      
    if(GUI.Button(Rect(420,215,200,60),"palm tree"))
    {  
        showWindow++;
       	state = 0;
        object=GameObject.Find("Palm");
    }  
    if(GUI.Button(Rect(625,215,200,60),"cactus"))
    {  
        showWindow++;
        state = 0;
        object=GameObject.Find("Cactus_Tall_03");        
    }     
    if(GUI.Button(Rect(830,215,200,60),"horse"))
    {  
        showWindow++;
       	state = 0;
        object=GameObject.Find("Horse");
    }      
    if(GUI.Button(Rect(10,280,200,60),"pylon"))
    {  
        object=GameObject.Find("pylon_2lanes_lod0");       
        showWindow++;
        state = 0;
    }  
    if(GUI.Button(Rect(215,280,200,60),"tower"))
    {  
        object=GameObject.Find("Watchtower_Main");       
        showWindow++;
        state = 0;
    }  
    if(GUI.Button(Rect(420,280,200,60),"brick"))
    {  
        showWindow++;
       	state = 0;
        object=GameObject.Find("Brick_Red_01");
    }  
    if(GUI.Button(Rect(625,280,200,60),"stone"))
    {  
        showWindow++;
        state = 0;
        object=GameObject.Find("stone");        
    }     
    if(GUI.Button(Rect(830,280,200,60),"spider"))
    {  
        showWindow++;
       	state = 0;
        object=GameObject.Find("Spider01");
    }      
    if(GUI.Button(Rect(10,345,200,60),"horse"))
    {  
        object=GameObject.Find("Horse");      
        showWindow++;
        state = 0;
    }  
    if(GUI.Button(Rect(215,345,200,60),"elephant"))
    {  
        showWindow++;
        state = 0;
    }         
    if(GUI.Button(Rect(420,345,200,60),"spider"))
    {  
        showWindow++;
       	state = 0;
        object=GameObject.Find("Spider01");
    }  
    if(GUI.Button(Rect(625,345,200,60),"bench"))
    {  
        showWindow++;
        state = 0;
        object=GameObject.Find("Table_Wood");        
        //Debug.Log("spider"); 
    }     
    if(GUI.Button(Rect(830,345,200,60),"spider"))
    {  
        showWindow++;
       	state = 0;
        object=GameObject.Find("Spider01");
    }       
    if(GUI.Button(Rect(10,410,200,60),"sofa1"))
    {  
        object=GameObject.Find("sofa1");      
        showWindow++;
        state = 0;
    }  
    if(GUI.Button(Rect(215,410,200,60),"elephant"))
    {  
        showWindow++;
        state = 0;
    }      
    if(GUI.Button(Rect(420,410,200,60),"spider"))
    {  
        showWindow++;
       	state = 0;
        object=GameObject.Find("Spider01");
    }  
    if(GUI.Button(Rect(625,410,200,60),"bench"))
    {  
        showWindow++;
        state = 0;
        object=GameObject.Find("Table_Wood");        
        //Debug.Log("spider"); 
    }     
    if(GUI.Button(Rect(830,410,200,60),"spider"))
    {  
        showWindow++;
       	state = 0;
        object=GameObject.Find("Spider01");
    }        
    if(GUI.Button(Rect(10,475,200,60),"sofa1"))
    {  
        object=GameObject.Find("sofa1");      
        showWindow++;
        state = 0;
    }  
    if(GUI.Button(Rect(215,475,200,60),"elephant"))
    {  
        showWindow++;
        state = 0;
    }      
    if(GUI.Button(Rect(420,475,200,60),"spider"))
    {  
        showWindow++;
       	state = 0;
        object=GameObject.Find("Spider01");
    }  
    if(GUI.Button(Rect(625,475,200,60),"bench"))
    {  
        showWindow++;
        state = 0;
        object=GameObject.Find("Table_Wood");        
        //Debug.Log("spider"); 
    }     
    if(GUI.Button(Rect(830,475,200,60),"spider"))
    {  
        showWindow++;
       	state = 0;
        object=GameObject.Find("Spider01");
    }      
    if(GUI.Button(Rect(10,540,200,60),"sofa1"))
    {  
        object=GameObject.Find("sofa1");      
        showWindow++;
        state = 0;
    }  
    if(GUI.Button(Rect(215,540,200,60),"elephant"))
    {  
        showWindow++;
        state = 0;
    }    
    if(GUI.Button(Rect(420,540,200,60),"spider"))
    {  
        showWindow++;
       	state = 0;
        object=GameObject.Find("Spider01");
    }  
    if(GUI.Button(Rect(625,540,200,60),"bench"))
    {  
        showWindow++;
        state = 0;
        object=GameObject.Find("Table_Wood");        
        //Debug.Log("spider"); 
    }     
    if(GUI.Button(Rect(830,540,200,60),"spider"))
    {  
        showWindow++;
       	state = 0;
        object=GameObject.Find("Spider01");
    }             
}  

function doWindow2(windowID:int){
	shoot = false;
    if(GUI.Button(Rect(10,20,200,60),"flame"))
    {
    	state = 1;
        showWindow2++;
        object=GameObject.Find("Flame"); 
    }
    if(GUI.Button(Rect(215,20,200,60),"Grenade"))
    {
        state = 1;
        showWindow2++;
		object = grenadeobj;
		shoot = true;
    }
    if(GUI.Button(Rect(10,85,200,60),"destroy"))
    {
    	state = 1;
        showWindow2++;
    }
    if(GUI.Button(Rect(215,85,200,60),"destroy"))
    {
    	state = 1;
        showWindow2++;
    }
    if(GUI.Button(Rect(10,150,200,60),"destroy"))
    {
        showWindow2++;
        state = 1;
    }
    if(GUI.Button(Rect(215,150,200,60),"spider"))
    {
    	state = 1;
        showWindow2++;
    }  
    if(GUI.Button(Rect(10,215,200,60),"flame"))
    {
    	state = 1;
        showWindow2++;
    }  
    if(GUI.Button(Rect(215,215,200,60),"spider"))
    {
    	state = 1;
        showWindow2++;
    }      
    if(GUI.Button(Rect(10,280,200,60),"spider"))
    {
    	state = 1;
        showWindow2++;
    }  
    if(GUI.Button(Rect(215,280,200,60),"spider"))
    {
    	state = 1;
        showWindow2++;
    }  
    if(GUI.Button(Rect(10,345,200,60),"spider"))
    {
    	state = 1;
        showWindow2++;
    }  
    if(GUI.Button(Rect(215,345,200,60),"elephant"))
    {
    	state = 1;
        showWindow2++;
    }         
}  

    function Update() 
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
	
	function Remove()
	{
		var ray:Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		var hit:RaycastHit;
		if (Physics.Raycast(ray, hit))
		{
			var check:boolean = true;
			var obj:GameObject = hit.collider.gameObject;
			for(var i:int=0; i<5; i++)
			{
				if(obj.name == undelete[i]) {check = false;}
			}
			if( object != null ) {
				if( !shoot) {
					var clone1 :GameObject = Instantiate(object, hit.point, object.transform.rotation);
					Destroy (clone1, 2);
					
					if(check)
					{
						Destroy(obj);
					}
				}else {
					var tmp : GameObject = GameObject.Find("Me");
					var front : Vector3 = tmp.transform.forward;
					var clone2 : GameObject = Instantiate(object, tmp.transform.position+3*front, object.transform.rotation);
					var grenade_rigidbody : Rigidbody = clone2.rigidbody;
					
					if(clone2.rigidbody == null) {
						Debug.Log("Rigidbody NULL");
						grenade_rigidbody = clone2.AddComponent("Rigidbody");
					}
					grenade_rigidbody.velocity = (hit.point - tmp.transform.position).normalized*70;

					if(check) Destroy(obj);
					Destroy (clone2, 1);
				}
		    }			
		}
	}

	function Add()
	{
		var ray:Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		var hit:RaycastHit;
		if (Physics.Raycast(ray, hit))
		{	
		    if(object == null)
		    {
			    var objCube:GameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
			    objCube.transform.position = hit.point;
			    objCube.renderer.material.color = Color.magenta;		    
		    }
		    else
		    {		
		        var clone :GameObject = Instantiate(object, hit.point, object.transform.rotation);
		        Destroy (clone, 60);
		    }
		}
	}	
