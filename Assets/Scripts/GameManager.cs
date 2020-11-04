using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float GameTime = 61;
	public Text GameTimeText;
	
    void Update()
    {
		if((int)GameTime == 0)
		{
			SceneManager.LoadScene("Ending");
		}
		
		else if((int)GameTime != 0)
		{
			GameTime -= Time.deltaTime;
			GameTimeText.text ="Time: "+ (int)GameTime;
		}
    }
}
