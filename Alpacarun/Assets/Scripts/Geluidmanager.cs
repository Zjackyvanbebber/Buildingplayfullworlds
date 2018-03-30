using UnityEngine.Audio;
using System;
using UnityEngine;

public class Geluidmanager : MonoBehaviour {

    public Geluidset[] sounds;

    public static Geluidmanager instance;


	void Awake () {

        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Geluidset s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            
        }
		
	}

    void Start()
    {
        Play("Theme");
    }

   
    public void Play (string name) {

        Geluidset s = Array.Find(sounds, Geluidset => Geluidset.name == name);
        s.source.Play();
	}
}
