using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chorao : MonoBehaviour
{
    public ParticleSystem tearParticles; // Declara uma vari�vel p�blica do tipo 'ParticleSystem'. Isso permite que o sistema de part�culas seja configurado no inspector da Unity.

    public void StartCrying() // M�todo p�blico chamado 'StartCrying'. Esse m�todo pode ser chamado de outros scripts ou a partir de eventos na Unity (como colidir com um objeto, clicar, etc.).
    {
        if (tearParticles != null) // Verifica se a vari�vel 'tearParticles' foi atribu�da. Se ela for nula (n�o atribu�da), o c�digo dentro da condi��o n�o ser� executado.
        {
            tearParticles.Play(); // Se 'tearParticles' n�o for nula, o m�todo 'Play()' � chamado, iniciando a reprodu��o do sistema de part�culas, simulando as l�grimas caindo.
        }
    }
}

