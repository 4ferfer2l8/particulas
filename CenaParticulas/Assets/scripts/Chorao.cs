using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chorao : MonoBehaviour
{
    public ParticleSystem tearParticles; // Declara uma variável pública do tipo 'ParticleSystem'. Isso permite que o sistema de partículas seja configurado no inspector da Unity.

    public void StartCrying() // Método público chamado 'StartCrying'. Esse método pode ser chamado de outros scripts ou a partir de eventos na Unity (como colidir com um objeto, clicar, etc.).
    {
        if (tearParticles != null) // Verifica se a variável 'tearParticles' foi atribuída. Se ela for nula (não atribuída), o código dentro da condição não será executado.
        {
            tearParticles.Play(); // Se 'tearParticles' não for nula, o método 'Play()' é chamado, iniciando a reprodução do sistema de partículas, simulando as lágrimas caindo.
        }
    }
}

