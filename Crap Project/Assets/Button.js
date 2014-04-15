var textAreaString = "Cards";

function OnGUI () 
{
	GUI.Box (Rect (10,10,180,330), "Game Menu");
		
	textAreaString = GUI.TextArea (Rect (50, 40, 100, 150), textAreaString);
	
	
	if (GUI.Button (Rect (50,200,100,40), "Random Card")) 
	{
		Application.LoadLevel (2);
		print("You Picked a Random Card!");
	}
	
	if (GUI.Button (Rect (20,250,160,80), "PLAY")) 
	{
		Application.LoadLevel (1);
		print("Kill them Nazis!");
	}
}