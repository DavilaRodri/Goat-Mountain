using UnityEngine;

public class Generate : MonoBehaviour
{
	public GameObject rocks;
	int score = -3;
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, 1.5f);
	}
	
	// Update is called once per frame
	void OnGUI () 
	{
		GUI.color = Color.black;
		GUI.Label(new Rect (700, 150, 150,25), "Score: " + score.ToString());
	}
	
	void CreateObstacle()
	{
		Instantiate(rocks);
		score++;
	}
}