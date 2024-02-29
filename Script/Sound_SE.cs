using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Sound_SE : MonoBehaviour
{
    const int N = 100;
    public static AudioClip[] sound = new AudioClip[N];
    public AudioClip[] sound_se;

    public static AudioSource audioSource_tmp;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource_tmp = audioSource;
        for (int i = 0;i < sound_se.Length;i++)
        {
            sound[i] = sound_se[i];
        }
    }

    public static void AudioStop()
    {
        audioSource_tmp.Stop();
    }

    public static void Sairen()
    {
        audioSource_tmp.PlayOneShot(sound[0]);
    }
    public static void Sairen2()
    {
        audioSource_tmp.PlayOneShot(sound[1]);
    }
    public static void Heri()
    {
        audioSource_tmp.PlayOneShot(sound[2]);
    }
    public static void Engin()
    {
        audioSource_tmp.PlayOneShot(sound[3]);
    }
    public static void Suzume()
    {
        audioSource_tmp.PlayOneShot(sound[4]);
    }
    public static void Karasu_long()
    {
        audioSource_tmp.PlayOneShot(sound[5]);
    }
    public static void Karasu()
    {
        audioSource_tmp.PlayOneShot(sound[6]);
    }
    public static void Wan()
    {
        audioSource_tmp.PlayOneShot(sound[7]);
    }
    public static void Neko()
    {
        audioSource_tmp.PlayOneShot(sound[8]);
    }
    public static void Humikiri()
    {
        audioSource_tmp.PlayOneShot(sound[9]);
    }

}
