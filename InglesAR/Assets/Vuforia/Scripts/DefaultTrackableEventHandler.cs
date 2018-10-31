/*==============================================================================
Copyright (c) 2017 PTC Inc. All Rights Reserved.

Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;
using Vuforia;

/// <summary>
/// A custom handler that implements the ITrackableEventHandler interface.
///
/// Changes made to this file could be overwritten when upgrading the Vuforia version.
/// When implementing custom event handler behavior, consider inheriting from this class instead.
/// </summary>
public class DefaultTrackableEventHandler : MonoBehaviour, ITrackableEventHandler
{
    public GameObject LavaButtonFalse;
    public GameObject LandButtonFalse;
    public GameObject RockButtonTrue;
    public GameObject SmokeButtonTrue;
    public GameObject FireButtonTrue;
    public GameObject WaterButtonFalse;
    public GameObject SmokeButtonFalse;
    public GameObject WaterButtonTrue;
    public GameObject FireButtonFalse;
    public GameObject LandButtonTrue;

    public GameObject OrangeButtonFalse;
    public GameObject RedButtonFalse;
    public GameObject BlueButtonTrue;
    public GameObject YellowButtonTrue;
    public GameObject RedButtonTrue;
    public GameObject BlueButtonFalse;
    public GameObject GreenButtonFalse;
    public GameObject OrangeButtonTrue;
    public GameObject YellowButtonFalse;
    public GameObject GreenButtonTrue;
    public GameObject PatternText1;
    public GameObject PatternText2;
    public GameObject PatternText3;

    public GameObject AppleButtonTrue;
    public GameObject BananaButtonTrue;
    public GameObject WatermelonButtonTrue;
    public GameObject BananaButtonFalse;
    public GameObject AvocadoButtonFalse;
    public GameObject AppleButtonFalse;
    public GameObject PaternText3;
    public GameObject AvocadoButtonTrue;
    public GameObject StrawberryButtonFalse;
    public GameObject WatermelonButtonFalse;
    public GameObject StrawberryButtonTrue;
    public GameObject Score;

    public int fumaca=0;

    public AudioSource soundTarget;
    public AudioClip clipTarget;
    private AudioSource[] allAudioSources;


    //function to stop all sounds
    void StopAllAudio()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }
    }

    //function to play sound
    void playSound(string ss)
    {
        clipTarget = (AudioClip)Resources.Load(ss);
        soundTarget.clip = clipTarget;
        soundTarget.loop = false;
        soundTarget.playOnAwake = false;
        soundTarget.Play();
    }



    //-----------End Sound------------


    #region PROTECTED_MEMBER_VARIABLES

    protected TrackableBehaviour mTrackableBehaviour;
    protected TrackableBehaviour.Status m_PreviousStatus;
    protected TrackableBehaviour.Status m_NewStatus;

    #endregion // PROTECTED_MEMBER_VARIABLES

    #region UNITY_MONOBEHAVIOUR_METHODS

    protected virtual void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        //Register / add the AudioSource as object
        soundTarget = (AudioSource)gameObject.AddComponent<AudioSource>();

        LandButtonFalse.gameObject.SetActive(false);
        LavaButtonFalse.gameObject.SetActive(false);
        SmokeButtonTrue.gameObject.SetActive(false);
        RockButtonTrue.gameObject.SetActive(false);
        WaterButtonFalse.gameObject.SetActive(false);
        FireButtonTrue.gameObject.SetActive(false);
        WaterButtonTrue.gameObject.SetActive(false);
        SmokeButtonFalse.gameObject.SetActive(false);
        FireButtonFalse.gameObject.SetActive(false);
        LandButtonTrue.gameObject.SetActive(false);
        PatternText1.gameObject.SetActive(false);

        OrangeButtonFalse.gameObject.SetActive(false);
        RedButtonFalse.gameObject.SetActive(false);
        BlueButtonTrue.gameObject.SetActive(false);
        YellowButtonTrue.gameObject.SetActive(false);
        BlueButtonFalse.gameObject.SetActive(false);
        RedButtonTrue.gameObject.SetActive(false);
        OrangeButtonTrue.gameObject.SetActive(false);
        GreenButtonFalse.gameObject.SetActive(false);
        YellowButtonFalse.gameObject.SetActive(false);
        GreenButtonTrue.gameObject.SetActive(false);
        PatternText2.gameObject.SetActive(false);

        BananaButtonFalse.gameObject.SetActive(false);
        AvocadoButtonFalse.gameObject.SetActive(false);
        AppleButtonTrue.gameObject.SetActive(false);
        BananaButtonTrue.gameObject.SetActive(false);
        AppleButtonFalse.gameObject.SetActive(false);
        WatermelonButtonTrue.gameObject.SetActive(false);
        AvocadoButtonTrue.gameObject.SetActive(false);
        StrawberryButtonFalse.gameObject.SetActive(false);
        WatermelonButtonFalse.gameObject.SetActive(false);
        StrawberryButtonTrue.gameObject.SetActive(false);
        PatternText3.gameObject.SetActive(false);
        Score.gameObject.SetActive(false);


        fumaca = 0;
}

    protected virtual void OnDestroy()
    {
        if (mTrackableBehaviour)
            mTrackableBehaviour.UnregisterTrackableEventHandler(this);
    }

    #endregion // UNITY_MONOBEHAVIOUR_METHODS

    #region PUBLIC_METHODS

    /// <summary>
    ///     Implementation of the ITrackableEventHandler function called when the
    ///     tracking state changes.
    /// </summary>
    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {
        m_PreviousStatus = previousStatus;
        m_NewStatus = newStatus;

        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            if (mTrackableBehaviour.TrackableName == "Fumaca")
            {
                Debug.Log("FUMACAAAA");
                Score.gameObject.SetActive(true);
                SmokeButtonTrue.gameObject.SetActive(true);
                LandButtonFalse.gameObject.SetActive(true);
                PatternText1.SetActive(true);


            }

            if (mTrackableBehaviour.TrackableName == "Pedra")
            {
                Score.gameObject.SetActive(true);
                Debug.Log("PEDRAA");
                RockButtonTrue.gameObject.SetActive(true);
                LavaButtonFalse.gameObject.SetActive(true);
                PatternText1.SetActive(true);

            }

            if (mTrackableBehaviour.TrackableName == "Fogo")
            {
                Score.gameObject.SetActive(true);
                Debug.Log("FOGO");
                FireButtonTrue.gameObject.SetActive(true);
                WaterButtonFalse.gameObject.SetActive(true);
                PatternText1.SetActive(true);
                playSound("sounds/fire");

            }

            if(mTrackableBehaviour.TrackableName == "AGUA")
            {
                Score.gameObject.SetActive(true);
                Debug.Log("FOGO");
                SmokeButtonFalse.SetActive(true);
                WaterButtonTrue.SetActive(true);
                PatternText1.SetActive(true);

            }

            if (mTrackableBehaviour.TrackableName == "Terra")
            {
                Score.gameObject.SetActive(true);
                Debug.Log("FOGO");
                LandButtonTrue.SetActive(true);
                FireButtonFalse.SetActive(true);
                PatternText1.SetActive(true);

            }

            if (mTrackableBehaviour.TrackableName == "Azul")
            {
                Score.gameObject.SetActive(true);
                Debug.Log("Azull");
                BlueButtonTrue.SetActive(true);
                OrangeButtonFalse.SetActive(true);
                PatternText2.SetActive(true);

            }

            if (mTrackableBehaviour.TrackableName == "Laranja")
            {
                Score.gameObject.SetActive(true);
                Debug.Log("LARANJAAA");
                OrangeButtonTrue.SetActive(true);
                GreenButtonFalse.SetActive(true);
                PatternText2.SetActive(true);

            }

            if (mTrackableBehaviour.TrackableName == "VERDE")
            {
                Score.gameObject.SetActive(true);
                Debug.Log("verdeee");
                GreenButtonTrue.SetActive(true);
                YellowButtonFalse.SetActive(true);
                PatternText2.SetActive(true);

            }

            if (mTrackableBehaviour.TrackableName == "Vermelho")
            {
                Score.gameObject.SetActive(true);
                Debug.Log("vermelhooooo");
                RedButtonTrue.SetActive(true);
                BlueButtonFalse.SetActive(true);
                PatternText2.SetActive(true);

            }

            if (mTrackableBehaviour.TrackableName == "AMARELO")
            {
                Score.gameObject.SetActive(true);
                Debug.Log("Amareloooo");
                YellowButtonTrue.SetActive(true);
                RedButtonFalse.SetActive(true);
                PatternText2.SetActive(true);

            }

            if (mTrackableBehaviour.TrackableName == "Maca")
            {
                Score.gameObject.SetActive(true);
                Debug.Log("macaaa");
                AppleButtonTrue.SetActive(true);
                BananaButtonFalse.SetActive(true);
                PatternText3.SetActive(true);

            }

            if (mTrackableBehaviour.TrackableName == "Banana")
            {
                Score.gameObject.SetActive(true);
                Debug.Log("banana");
                BananaButtonTrue.SetActive(true);
                AvocadoButtonFalse.SetActive(true);
                PatternText3.SetActive(true);

            }

            if (mTrackableBehaviour.TrackableName == "Watermelon")
            {
                Score.gameObject.SetActive(true);
                Debug.Log("melancia");
                WatermelonButtonTrue.SetActive(true);
                AppleButtonFalse.SetActive(true);
                PatternText3.SetActive(true);

            }

            if (mTrackableBehaviour.TrackableName == "Avocado")
            {
                Score.gameObject.SetActive(true);
                Debug.Log("abacateee");
                AvocadoButtonTrue.SetActive(true);
                StrawberryButtonFalse.SetActive(true);
                PatternText3.SetActive(true);

            }

            if (mTrackableBehaviour.TrackableName == "Strawberry")
            {
                Score.gameObject.SetActive(true);
                Debug.Log("morango");
                StrawberryButtonTrue.SetActive(true);
                WatermelonButtonFalse.SetActive(true);
                PatternText3.SetActive(true);

            }

            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
            OnTrackingFound();
        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                 newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
            OnTrackingLost();
            StopAllAudio();
        }
        else
        {
            // For combo of previousStatus=UNKNOWN + newStatus=UNKNOWN|NOT_FOUND
            // Vuforia is starting, but tracking has not been lost or found yet
            // Call OnTrackingLost() to hide the augmentations
            OnTrackingLost();
        }
    }

    #endregion // PUBLIC_METHODS

    #region PROTECTED_METHODS

    protected virtual void OnTrackingFound()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        // Enable rendering:
        foreach (var component in rendererComponents)
            component.enabled = true;

        // Enable colliders:
        foreach (var component in colliderComponents)
            component.enabled = true;

        // Enable canvas':
        foreach (var component in canvasComponents)
            component.enabled = true;
    }


    protected virtual void OnTrackingLost()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        // Disable rendering:
        foreach (var component in rendererComponents)
            component.enabled = false;

        // Disable colliders:
        foreach (var component in colliderComponents)
            component.enabled = false;

        // Disable canvas':
        foreach (var component in canvasComponents)
            component.enabled = false;
    }

    #endregion // PROTECTED_METHODS
}
