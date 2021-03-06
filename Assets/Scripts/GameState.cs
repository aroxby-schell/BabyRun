using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour
{
	public TextMesh coinCounter;
	
	private static bool paused = false;
	private static int coins = 0;
	private float defTimeScale = 1f;
	
	void Start()
	{
		defTimeScale = Time.timeScale;
	}
	
	void Update()
	{
		coinCounter.text = "x"+coins;
	}
	
	public static bool IsPaused()
	{
		return paused;
	}
	
	public static void AddCoins(int count)
	{
		coins += count;
	}
	
	public void OnButtonClicked(object o)
	{
		if(o.ToString()=="Reset")
		{
			if(paused)
			{
				Time.timeScale = defTimeScale;
				paused = false;
			}
			coins = 0;
			Application.LoadLevel( Application.loadedLevel );
		}
		else if(o.ToString()=="Pause")
		{
			if(paused) Time.timeScale = defTimeScale;
			else Time.timeScale = 0f;
			paused = !paused;
		}
	}
}
