using UnityEngine;
using System.Collections;

public class Screenshot : MonoBehaviour {

	
	// Check for screenshot key each frame
	void Update()
	{
		// take screenshot on up->down transition of F9 key
		if (Input.GetKeyDown("c"))
		{        
			string screenshotFilename;
			do
			{
				PlayerPrefs.SetInt("Screenshot", PlayerPrefs.GetInt("Screenshot") + 1);
				screenshotFilename = "screenshot" + PlayerPrefs.GetInt("Screenshot") + ".png";
				
			} while (System.IO.File.Exists(screenshotFilename));
			
			Application.CaptureScreenshot(screenshotFilename);
		}
	}
}
