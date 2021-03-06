﻿using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;

    public Sound musicPlayed;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.name = s.name;
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;

            s.source.outputAudioMixerGroup = s.mixer.outputAudioMixerGroup;
        }

        musicPlayed = new Sound();
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound : '" + name + "' not found.");
            return;
        }

        if (musicPlayed.name != name)
        {
            Stop();
            s.source.Play();
            musicPlayed = s;
        }
    }

    public void Stop()
    {
        if (musicPlayed.source != null)
            musicPlayed.source.Stop();
    }

    public string GetSoundPlaying()
    {
        return musicPlayed.name;
    }
}
