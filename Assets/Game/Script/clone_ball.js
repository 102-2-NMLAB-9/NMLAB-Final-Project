//ball
var object:GameObject = null;
var mySkin : GUISkin; 
var showWindow:int = 0;
var state:int = 0;
var showWindow2:int = 0;
var undelete = ["Terraingreen", "Terrainrock", "Terrainwhite", "Terrainyellow", "Me"];

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
	   GUI.Window(0,Rect(250,10,420,410),doWindow,"選單");
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
    if(GUI.Button(Rect(10,150,200,60),"horse"))
    {  
        object=GameObject.Find("Horse");       
        showWindow++;
        state = 0;
    }  
    if(GUI.Button(Rect(215,150,200,60),"sofa2"))
    {  
        object=GameObject.Find("sofa2");       
        showWindow++;
        state = 0;
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
    if(GUI.Button(Rect(10,345,200,60),"sofa1"))
    {  
        object=GameObject.Find("sofa1");      
        showWindow++;
        state = 0;
    }  
    if(GUI.Button(Rect(215,345,200,60),"elephant"))
    {  
        showWindow++;
        state = 0;
    }         
}  

function doWindow2(windowID:int){  
    if(GUI.Button(Rect(10,20,200,60),"flame"))
    {
    	state = 1;
        showWindow2++;
        object=GameObject.Find("Flame"); 
    }
    if(GUI.Button(Rect(215,20,200,60),"destroy"))
    {
        state = 1;
        showWindow2++;
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
				var clone :GameObject = Instantiate(object, hit.point, object.transform.rotation);
		        Destroy (clone, 2);
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
