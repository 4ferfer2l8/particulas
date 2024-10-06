using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chorao : MonoBehaviour
{
    public ParticleSystem tearParticles;

    // Função para iniciar o choro (ativar as partículas)
    public void StartCrying()
    {
        if (tearParticles != null)
        {
            tearParticles.Play();
        }
    }
}

