using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    public AudioSource source;

    public void stopMusic()
    {
        source.Stop();
    }
}
