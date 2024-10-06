using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chorao : MonoBehaviour
{
    public ParticleSystem tearParticles;

    // Fun��o para iniciar o choro (ativar as part�culas)
    public void StartCrying()
    {
        if (tearParticles != null)
        {
            tearParticles.Play();
        }
    }
}

