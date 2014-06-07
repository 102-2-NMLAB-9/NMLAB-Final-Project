//ball
var obj : GameObject;
var mySkin : GUISkin;

function Start()
{
	//acquire ball
	obj = GameObject.Find("Sphere");
}

function OnGUI()
{
	GUI.skin = mySkin;
	if(GUILayout.RepeatButton("start clone")){
	
		//example about clone ball
		var clone :GameObject = Instantiate(obj, obj.transform.position, obj.transform.rotation);
		//destroy after 5 minutes
		Destroy (clone, 60);
	}
}