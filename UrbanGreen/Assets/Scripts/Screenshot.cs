using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshot : MonoBehaviour {
   

    public void CaptureScreenshot()
    {
      ScreenshotManager.SaveScreenshot("ScreenshotName", "UrbanGreen");
    }
}
