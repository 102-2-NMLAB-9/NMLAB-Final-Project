//ball
var obj : GameObject;

function Start()
{
	//acquire ball
	obj = GameObject.Find("Sphere");
}

function OnGUI()
{
	
	if(GUILayout.Button("start clone",GUILayout.Height(50))){
	
		//example about clone ball
		var clone :GameObject = Instantiate(obj, obj.transform.position, obj.transform.rotation);
		//destroy after 5 minutes
		Destroy (clone, 5);
	}
}