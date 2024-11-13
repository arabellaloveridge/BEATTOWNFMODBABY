using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class All_SFX : MonoBehaviour
{

    FMOD.Studio.EventInstance walking;
    FMOD.Studio.EventInstance UISelect;
    FMOD.Studio.EventInstance CUANG;
    FMOD.Studio.EventInstance FishBattle;
    FMOD.Studio.EventInstance FishSlap;
    FMOD.Studio.EventInstance Swing;
    FMOD.Studio.EventInstance Push;
    FMOD.Studio.EventInstance PlayerHurt;

    bool Cuda_Count = false;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Cuda_Count set false");
        Debug.Log(gameObject.name);

        UISelect = FMODUnity.RuntimeManager.CreateInstance("event:/Ring Sounds/UI/UI Click");
        walking = FMODUnity.RuntimeManager.CreateInstance("event:/Ring Sounds/Action/RingStep");
        CUANG = FMODUnity.RuntimeManager.CreateInstance("event:/Ring Sounds/UI/CUANG");
        FishBattle = FMODUnity.RuntimeManager.CreateInstance("event:/Fish_Battle");
        FishSlap = FMODUnity.RuntimeManager.CreateInstance("event:/Ring Sounds/Action/Fish Slap Hit");
        Swing = FMODUnity.RuntimeManager.CreateInstance("event:/Ring Sounds/Action/Carry");
        Push = FMODUnity.RuntimeManager.CreateInstance("event:/Ring Sounds/Action/Push");
        PlayerHurt = FMODUnity.RuntimeManager.CreateInstance("event:/Ring Sounds/Player Hurt");
        PlayFishBattle();
        

    }

   public void UpdateCudaCount()
{
    Cuda_Count = true;

    FishBattle.setParameterByName("Cuda_Count", Cuda_Count ? 1 : 0);

    Debug.Log("cuda count: " + Cuda_Count);
}


    public void PlayWalkingSound()
    {
        walking.start();
    }

    public void OnUIButtonPressed()
    {

        UISelect.start();

    }

    public void PlayCUANG()
    {
        CUANG.start();
    }

    public void PlayFishBattle()
    {
        FishBattle.start();
    }

    public void PlayFishSlap()
    {
        FishSlap.start();
    }

    public void PlaySwing()
    {
        Swing.start();
    }

    public void PlayPush()
    {
        Push.start();
    }

    public void PlayPlayerHurt()
    {
        PlayerHurt.start();
    }




    // Update is called once per frame
    void Update()
    {

        Debug.Log("cuda count: " + Cuda_Count);



    }
}