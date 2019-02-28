using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioFile[] audioFiles;

    private float timeToReset;

    private bool timerIsSet = false;

    private string tmpName;

    private float tmpVol;

    private bool isLowered = false;

    void Awake()
    {
        if (instance == null)
        {

            instance = this;

        }

        else if (instance != this)
        {

            Destroy(gameObject);

        }

        DontDestroyOnLoad(gameObject);

        foreach (var s in audioFiles)
        {

            s.source = gameObject.AddComponent<AudioSource>();

            s.source.clip = s.audioClip;

            s.source.volume = s.volume;

            s.source.loop = s.isLooping;

            if (s.playOnAwake)
            {
                s.source.Play();
            }

        }
    }
    public void Play(string name)
    {

        AudioFile s = Array.Find(instance.audioFiles, AudioFile => AudioFile.audioName == name);

        if (s == null)
        {

            Debug.LogError("Sound name" + name + "not found!");

            return;

        }

        else
        {

            s.source.Play();

        }

    }

    public void StopMusic(string name)
    {

        AudioFile s = Array.Find(instance.audioFiles, AudioFile => AudioFile.audioName == name);

        if (s == null)
        {

            Debug.LogError("Sound name" + name + "not found!");

            return;

        }

        else
        {

            s.source.Stop();

        }

    }

    public void PauseMusic(string name)
    {

        AudioFile s = Array.Find(instance.audioFiles, AudioFile => AudioFile.audioName == name);

        if (s == null)
        {

            Debug.LogError("Sound name" + name + "not found!");

            return;

        }

        else
        {

            s.source.Pause();

        }

    }

    public void UnPauseMusic(string name)
    {

        AudioFile s = Array.Find(instance.audioFiles, AudioFile => AudioFile.audioName == name);

        if (s == null)
        {

            Debug.LogError("Sound name" + name + "not found!");

            return;

        }

        else
        {

            s.source.UnPause();

        }

    }

    public void LowerVolume(string name, float _duration)
    {

        if (instance.isLowered == false)
        {

            AudioFile s = Array.Find(instance.audioFiles, AudioFile => AudioFile.audioName == name);

            if (s == null)
            {

                Debug.LogError("Sound name" + name + "not found!");

                return;

            }

            else
            {

                instance.tmpName = name;

                instance.tmpVol = s.volume;

                instance.timeToReset = Time.time + _duration;

                instance.timerIsSet = true;

                s.source.volume = s.source.volume / 3;

            }

            instance.isLowered = true;

        }
    }

    void ResetVol()
    {

        AudioFile s = Array.Find(instance.audioFiles, AudioFile => AudioFile.audioName == tmpName);

        s.source.volume = tmpVol;

        isLowered = false;

    }

    private void Update()
    {

        if(Time.time >= timeToReset && timerIsSet)
        {

            ResetVol();

            timerIsSet = false;

        }

    }


}