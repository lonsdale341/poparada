using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class DemoScript : MonoBehaviour {

	//public bool hideGUI = false;
	public Texture2D texture;
    public UITexture screenshot;
    public UITexture preview_L_L;
    public UITexture preview_L_P;
    public UITexture preview_P_L;
    public UITexture preview_P_P;
	//public Text console;
	//public CanvasGroup ui;
	//public Image screenshot;
	
	void OnEnable ()
	{
		// call backs
		ScreenshotManager.OnScreenshotTaken += ScreenshotTaken;
		ScreenshotManager.OnScreenshotSaved += ScreenshotSaved;	
		ScreenshotManager.OnImageSaved += ImageSaved;
	}

	void OnDisable ()
	{
		ScreenshotManager.OnScreenshotTaken -= ScreenshotTaken;
		ScreenshotManager.OnScreenshotSaved -= ScreenshotSaved;	
		ScreenshotManager.OnImageSaved -= ImageSaved;
	}

	public void OnSaveScreenshotPress()
	{
		ScreenshotManager.SaveScreenshot("Popapada_Photo", "Poparada", "jpeg");
       // ScreenshotManager.SaveImage(texture, "MyImage", "png");
		//if(hideGUI) ui.alpha = 0;
	}

	public void OnSaveImagePress()
	{
		ScreenshotManager.SaveImage(texture, "MyImage", "png");
	}

	void ScreenshotTaken(Texture2D image)
	{
        Debug.Log("Foto=" + " h= " + image.height + "  w=" + image.width);
        Debug.Log("Screen=" + " h= " + Screen.height + "  w=" + Screen.width);
        screenshot.mainTexture = image;
        preview_L_L.mainTexture = image;
        preview_L_P.mainTexture = image;
        preview_P_L.mainTexture = image;
        preview_P_P.mainTexture = image;
       // screenshot.width = image.width;
       // screenshot.height = image.height;
	    screenshot.leftAnchor.absolute = 0;
        screenshot.rightAnchor.absolute = 0;
        screenshot.bottomAnchor.absolute = 0;
        screenshot.topAnchor.absolute = 0;
        DataLevel.Instance.ReguestSetActivePanel_Foto();
	    //console.text += "\nScreenshot has been taken and is now saving...";
	    //screenshot.sprite = Sprite.Create(image, new Rect(0, 0, image.width, image.height), new Vector2(.5f, .5f));
	    //screenshot.color = Color.white;
	    //ui.alpha = 1;
	}
	
	void ScreenshotSaved(string path)
	{
        //Debug.Log("\nScreenshot finished saving to " + path);
		//console.text += "\nScreenshot finished saving to " + path;
	}
	
	void ImageSaved(string path)
	{
		//console.text += "\n" + texture.name + " finished saving to " + path;
	}
}