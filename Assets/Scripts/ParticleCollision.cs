using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
    public ParticleSystem particles1;
    public ParticleSystem particles2;
    public ParticleSystem particles3;
    public ParticleSystem particles4;
    public ParticleSystem particles5;
    public ParticleSystem particles6;
    public ParticleSystem particles7;
    public ParticleSystem particles8;
    public ParticleSystem particles9;
    public ParticleSystem particles10;
    public ParticleSystem particles11;
    public ParticleSystem particles12;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            particles1.Play();
            particles2.Play();
            particles3.Play();
            particles4.Play();
            particles5.Play();
            particles6.Play();
            particles7.Play();
            particles8.Play();
            particles9.Play();
            particles10.Play();
            particles11.Play();
            particles12.Play();
        }
    }
}
