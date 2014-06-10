//ball
var object:GameObject = null;
var mySkin : GUISkin; 
var showWindow:int = 0;
var state:int = 0;
var undelete = ["Terraingreen", "Terrainrock", "Terrainwhite", "Terrainyellow", "Me"];

function OnGUI()
{
	GUI.skin = mySkin;	 
	if(GUILayout.Button("create"))
	{	
        showWindow++;
	}
	if(showWindow%2==1)
	{    
	   GUI.Window(0,Rect(250,10,420,410),doWindow,"選單");
	}

}

function doWindow(windowID:int){  
    if(GUI.Button(Rect(10,20,200,60),"spider"))
    {  
        showWindow++;
        object=GameObject.Find("Spider01");
    }  
    if(GUI.Button(Rect(215,20,200,60),"table"))
    {  
        showWindow++;
        object=GameObject.Find("Table_Wood");        
        //Debug.Log("spider"); 
    }      
    if(GUI.Button(Rect(10,85,200,60),"chair"))
    {  
        object=GameObject.Find("Chair_Metal_02");            
        showWindow++;    
    }  
    if(GUI.Button(Rect(215,85,200,60),"spider"))
    {  
        showWindow++;
    }     
    if(GUI.Button(Rect(10,150,200,60),"spider"))
    {  
        showWindow++;
    }  
    if(GUI.Button(Rect(215,150,200,60),"spider"))
    {  
        showWindow++;
    }  
    if(GUI.Button(Rect(10,215,200,60),"spider"))
    {  
        showWindow++;
    }  
    if(GUI.Button(Rect(215,215,200,60),"spider"))
    {  
        showWindow++;
    }      
    if(GUI.Button(Rect(10,280,200,60),"spider"))
    {  
        showWindow++;
    }  
    if(GUI.Button(Rect(215,280,200,60),"spider"))
    {  
        showWindow++;
    }  
    if(GUI.Button(Rect(10,345,200,60),"spider"))
    {  
        showWindow++;
    }  
    if(GUI.Button(Rect(215,345,200,60),"elephant"))
    {  
        showWindow++;
    }         
}  

    function Update() 
	{
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
			if(check)
			{		
				Destroy(obj);
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
