using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleBurst : MonoBehaviour
{

    public ParticleSystem collisonParticleSystem;
    public SpriteRenderer sr;
    public bool once = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && once)
        {
            var em = collisonParticleSystem.emission;
            var dur = collisonParticleSystem.duration;

            em.enabled = true;
            collisonParticleSystem.Play();

            once = false;
            Destroy(sr);
            Invoke(nameof(DestroyObj), dur);
        }
    }

    void DestroyObj()
    {
        Destroy(gameObject);
    }
}
