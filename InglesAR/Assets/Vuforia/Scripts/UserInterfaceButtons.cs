using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UserInterfaceButtons : MonoBehaviour
{
	public float scalingSpeed = 0.03f;
	public float rotationSpeed = 70.0f;
	public float translationSpeed = 5.0f;
//	public GameObject Model;
	bool repeatScaleUp = false;
	bool repeatScaleDown = false;
	bool repeatRotateLeft = false;
	bool repeatRotateRight = false;
	bool repeatPositionUp = false;
	bool repeatPositionDown = false;
	bool repeatPositionLeft = false;
	bool repeatPositionRight = false;
    public int score = 0;
    public GameObject LandFalse;
    public GameObject SmokeTrue;
    public GameObject RockTrue;
    public GameObject LavaFalse;
    public GameObject FireTrue;
    public GameObject WaterFalse;
    public GameObject PaternText;
    public GameObject WaterTrue;
    public GameObject SmokeFalse;
    public GameObject FireFalse;
    public GameObject LandTrue;

    public GameObject BlueTrue;
    public GameObject OrangeTrue;
    public GameObject RedTrue;
    public GameObject YellowFalse;
    public GameObject RedFalse;
    public GameObject OrangeFalse;
    public GameObject PaternText2;
    public GameObject YellowTrue;
    public GameObject BlueFalse;
    public GameObject GreenFalse;
    public GameObject GreenTrue;

    public GameObject AppleTrue;
    public GameObject BananaTrue;
    public GameObject WatermelonTrue;
    public GameObject BananaFalse;
    public GameObject AvocadoFalse;
    public GameObject AppleFalse;
    public GameObject PaternText3;
    public GameObject AvocadoTrue;
    public GameObject StrawberryFalse;
    public GameObject WatermelonFalse;
    public GameObject StrawberryTrue;
    public GameObject Fase2;
    
    

    void Update ()
	{
        Fase2.SetActive(false);
       


        if (repeatScaleUp) {
			ScaleUpButton ();
		}

		if (repeatScaleDown) {
			ScaleDownButton ();
		}

		if (repeatRotateRight) {
			RotationRightButton();
		}

		if (repeatRotateLeft) {
			RotationLeftButton();
		}

		if (repeatPositionUp) {
			PositionUpButton();
		}

		if (repeatPositionDown) {
			PositionDownButton();
		}

		if (repeatPositionLeft) {
			PositionLeftButton();
		}

		if (repeatPositionRight) {
			PositionRightButton();
		}

        if (score >= 50)
        {
            Fase2.SetActive(true);

            //SceneManager.LoadScene(SceneFase2);

            //Application.LoadLevel(SceneFase2);
        }
        /*if (score >= 30)
        {
            Fase3.SetActive(true);

        }*/

        
    }


    public void LandFalseButton()
    {

        Debug.Log("botao clicado");
        LandFalse.SetActive(false);
        SmokeTrue.SetActive(false);
        PaternText.SetActive(false);
    }

    public void SmokeTrueButton()
    {
        ScoreScript.scoreValue += 10;
        Debug.Log("botao clicado");
        LandFalse.SetActive(false);
        SmokeTrue.SetActive(false);
        PaternText.SetActive(false);
    }
    public void RockTrueButton()
    {
        ScoreScript.scoreValue += 10;
        Debug.Log("botao clicado");
        RockTrue.gameObject.SetActive(false);
        LavaFalse.gameObject.SetActive(false);
        PaternText.SetActive(false);
    }
    public void LavaTrueButton()
    {
        ScoreScript.scoreValue += 10;
        Debug.Log("botao clicado");
        RockTrue.gameObject.SetActive(false);
        LavaFalse.gameObject.SetActive(false);
        PaternText.SetActive(false);
    }
        public void FireButtonTrue()
    {
       
        ScoreScript.scoreValue += 10;
        Debug.Log("botao clicado");
        FireTrue.gameObject.SetActive(false);
        WaterFalse.gameObject.SetActive(false);
        PaternText.SetActive(false);
    }
    public void WaterButtonFalse()
    {

        Debug.Log("botao clicado");
        FireTrue.gameObject.SetActive(false);
        WaterFalse.gameObject.SetActive(false);
        PaternText.SetActive(false);

    }

    public void WaterButtonTrue()
    {
        ScoreScript.scoreValue += 10;
        Debug.Log("botao clicado");
        SmokeFalse.gameObject.SetActive(false);
        WaterTrue.gameObject.SetActive(false);
        PaternText.SetActive(false);

        score = score + 10;
  
    }

    public void SmokeFalseButton()
    {

        Debug.Log("botao clicado");
        WaterTrue.SetActive(false);
        SmokeFalse.SetActive(false);
        PaternText.SetActive(false);
    }

    public void LandTrueButton()
    {
        ScoreScript.scoreValue += 10;
        Debug.Log("botao clicado");
        LandTrue.SetActive(false);
        FireFalse.SetActive(false);
        PaternText.SetActive(false);
    }

    public void FireButtonFalse()
    {
        
        Debug.Log("botao clicado");
        FireFalse.gameObject.SetActive(false);
        LandTrue.gameObject.SetActive(false);
        PaternText.SetActive(false);
    }

    public void Fase2Button(string SceneFase2)
    {
        
 
        if (score >= 50)
        { 

            Application.LoadLevel(SceneFase2);

        }
       
    }

    public void BlueButtonTrue()
    {
        ScoreScript.scoreValue += 10;
        Debug.Log("botao clicado");
        OrangeFalse.gameObject.SetActive(false);
        BlueTrue.gameObject.SetActive(false);
        PaternText2.SetActive(false);
        
    }

    public void OrangeButtonFalse()
    {

        Debug.Log("botao clicado");
        OrangeFalse.gameObject.SetActive(false);
        BlueTrue.gameObject.SetActive(false);
        PaternText2.SetActive(false);
        
    }

    public void RedButtonFalse()
    {

        Debug.Log("botao clicado");
        RedFalse.gameObject.SetActive(false);
        YellowTrue.gameObject.SetActive(false);
        PaternText2.SetActive(false);
    }

    public void YellowButtonTrue()
    {
        ScoreScript.scoreValue += 10;
        Debug.Log("botao clicado");
        RedFalse.gameObject.SetActive(false);
        YellowTrue.gameObject.SetActive(false);
        PaternText2.SetActive(false);
    }

    public void RedButtonTrue()
    {
        ScoreScript.scoreValue += 10;
        Debug.Log("botao clicado");
        RedTrue.gameObject.SetActive(false);
        BlueFalse.gameObject.SetActive(false);
        PaternText2.SetActive(false);

        
    }

    public void BlueButtonFalse()
    {

        Debug.Log("botao clicado");
        RedTrue.gameObject.SetActive(false);
        BlueFalse.gameObject.SetActive(false);
        PaternText2.SetActive(false);
    }

    public void GreenButtonFalse()
    {

        Debug.Log("botao clicado");
        OrangeTrue.gameObject.SetActive(false);
        GreenFalse.gameObject.SetActive(false);
        PaternText2.SetActive(false);
    }

    public void OrangeButtonTrue()
    {
        ScoreScript.scoreValue += 10;
        Debug.Log("botao clicado");
        OrangeTrue.gameObject.SetActive(false);
        GreenFalse.gameObject.SetActive(false);
        PaternText2.SetActive(false);
    }

    public void GreenButtonTrue()
    {
        ScoreScript.scoreValue += 10;
        Debug.Log("botao clicado");
        GreenTrue.gameObject.SetActive(false);
        YellowFalse.gameObject.SetActive(false);
        PaternText2.SetActive(false);
    }

    public void YellowButtonFalse()
    {

        Debug.Log("botao clicado");
        GreenTrue.gameObject.SetActive(false);
        YellowFalse.gameObject.SetActive(false);
        PaternText2.SetActive(false);
    }

    public void BananaButtonFalse()
    {
        ScoreScript.scoreValue += 10;
        Debug.Log("botao clicado");
        AppleTrue.gameObject.SetActive(false);
        BananaFalse.gameObject.SetActive(false);
        PaternText3.SetActive(false);
    }

    public void AppleButtonTrue()
    {
        ScoreScript.scoreValue += 10;
        Debug.Log("botao clicado");
        AppleTrue.gameObject.SetActive(false);
        BananaFalse.gameObject.SetActive(false);
        PaternText3.SetActive(false);
    }

    public void AvocadoButtonFalse()
    {

        Debug.Log("botao clicado");
        AvocadoFalse.gameObject.SetActive(false);
        BananaTrue.gameObject.SetActive(false);
        PaternText3.SetActive(false);
    }

    public void BananaButtonTrue()
    {
        ScoreScript.scoreValue += 10;
        Debug.Log("botao clicado");
        AvocadoFalse.gameObject.SetActive(false);
        BananaTrue.gameObject.SetActive(false);
        PaternText3.SetActive(false);
    }

    public void AppleButtonFalse()
    {

        Debug.Log("botao clicado");
        AppleFalse.gameObject.SetActive(false);
        WatermelonTrue.gameObject.SetActive(false);
        PaternText3.SetActive(false);
    }

    public void WatermelonButtonTrue()
    {
        ScoreScript.scoreValue += 10;
        Debug.Log("botao clicado");
        AppleFalse.gameObject.SetActive(false);
        WatermelonTrue.gameObject.SetActive(false);
        PaternText3.SetActive(false);

        
    }

    public void WatermelonButtonFalse()
    {

        Debug.Log("botao clicado");
        StrawberryTrue.gameObject.SetActive(false);
        WatermelonFalse.gameObject.SetActive(false);
        PaternText3.SetActive(false);
    }

    public void StrawberryButtonTrue()
    {
        ScoreScript.scoreValue += 10;
        Debug.Log("botao clicado");
        StrawberryTrue.gameObject.SetActive(false);
        WatermelonFalse.gameObject.SetActive(false);
        PaternText3.SetActive(false);
    }

    public void StrawberryButtonFalse()
    {

        Debug.Log("botao clicado");
        StrawberryFalse.gameObject.SetActive(false);
        AvocadoTrue.gameObject.SetActive(false);
        PaternText3.SetActive(false);
    }

    public void AvocadoButtonTrue()
    {

        Debug.Log("botao clicado");
        StrawberryFalse.gameObject.SetActive(false);
        AvocadoTrue.gameObject.SetActive(false);
        PaternText3.SetActive(false);
    }

    public void CloseAppButton ()
	{
		Application.Quit ();
	}

	public void RotationRightButton ()
	{
		// transform.Rotate (0, -rotationSpeed * Time.deltaTime, 0);
		GameObject.FindWithTag ("Model").transform.Rotate (0, -rotationSpeed * Time.deltaTime, 0);
	}

	public void RotationLeftButton ()
	{
		// transform.Rotate (0, rotationSpeed * Time.deltaTime, 0);
		GameObject.FindWithTag ("Model").transform.Rotate (0, rotationSpeed * Time.deltaTime, 0);
	}

	public void RotationRightButtonRepeat ()
	{
		// transform.Rotate (0, -rotationSpeed * Time.deltaTime, 0);
		repeatRotateRight=true;
	}
	
	public void RotationLeftButtonRepeat ()
	{
		// transform.Rotate (0, rotationSpeed * Time.deltaTime, 0);
		repeatRotateLeft=true;
	}

	public void ScaleUpButton ()
	{
		// transform.localScale += new Vector3(scalingSpeed, scalingSpeed, scalingSpeed);
			GameObject.FindWithTag ("Model").transform.localScale += new Vector3 (scalingSpeed, scalingSpeed, scalingSpeed);
		}

	public void ScaleUpButtonRepeat ()
	{
		repeatScaleUp = true;
		Debug.Log ("Up");
	}
	public void ScaleDownButtonRepeat ()
	{
		repeatScaleDown = true;
		Debug.Log ("Down");
	}
	public void PositionDownButtonRepeat ()
	{
		repeatPositionDown = true;
	}
	public void PositionUpButtonRepeat ()
	{
		repeatPositionUp = true;
	}
	public void PositionLeftButtonRepeat ()
	{
		repeatPositionLeft = true;
	}
	public void PositionRightButtonRepeat ()
	{
		repeatPositionRight = true;
	}
	
	public void ScaleUpButtonOff ()
	{
		repeatScaleUp = false;
		Debug.Log ("Off");
	}
	public void ScaleDownButtonOff ()
	{
		repeatScaleDown = false;
		Debug.Log ("Off");
	}

	public void RotateLeftButtonOff ()
	{
		repeatRotateLeft = false;
		Debug.Log ("Off");
	}

	public void RotateRightButtonOff ()
	{
		repeatRotateRight = false;
		Debug.Log ("Off");
	}
	public void PositionRightButtonOff ()
	{
		repeatPositionRight = false;
		Debug.Log ("Off");
	}
	public void PositionLeftButtonOff ()
	{
		repeatPositionLeft = false;
		Debug.Log ("Off");
	}
	public void PositionUpButtonOff ()
	{
		repeatPositionUp = false;
		Debug.Log ("Off");
	}
	public void PositionDownButtonOff ()
	{
		repeatPositionDown = false;
		Debug.Log ("Off");
	}
	
	public void ScaleDownButton ()
	{
		// transform.localScale += new Vector3(-scalingSpeed, -scalingSpeed, -scalingSpeed);
		GameObject.FindWithTag ("Model").transform.localScale += new Vector3 (-scalingSpeed, -scalingSpeed, -scalingSpeed);
	}

	public void PositionUpButton ()
	{
		GameObject.FindWithTag ("Model").transform.Translate (0, 0, -translationSpeed * Time.deltaTime);
	}

	public void PositionDownButton ()
	{

		GameObject.FindWithTag ("Model").transform.Translate (0, 0, translationSpeed * Time.deltaTime);
	}

	public void PositionRightButton ()
	{
		GameObject.FindWithTag ("Model").transform.Translate (-translationSpeed * Time.deltaTime, 0, 0);
	}

	public void PositionLeftButton ()
	{
		GameObject.FindWithTag ("Model").transform.Translate (translationSpeed * Time.deltaTime, 0, 0);  // backward
	}

	/*public void ChangeScene (string a)
	{
		Application.LoadLevel (a);
	}*/

	public void AnyButton ()
	{
		Debug.Log ("Any");
	}
}
