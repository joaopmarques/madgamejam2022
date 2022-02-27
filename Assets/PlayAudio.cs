using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
  public AudioSource audioSource;

  public AudioClip shootClip;
  public float shootVolume = 0.5f;
  
  public AudioClip hurtClip;
  public float hurtVolume = 0.5f;

  public void PlayShoot()
  {
    audioSource.PlayOneShot(shootClip, shootVolume);
  }

  public void PlayHurt()
  {
    audioSource.PlayOneShot(hurtClip, hurtVolume);
  }
}
