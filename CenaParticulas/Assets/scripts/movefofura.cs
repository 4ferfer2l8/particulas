using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem; // Permite o uso de tipos do namespace 'ParticleSystem' sem precisar prefixar com 'ParticleSystem'.

public class MoveFofu : MonoBehaviour
{
    public Vector3 moveSpeed; // Um vetor 3D p�blico que define a velocidade de movimento do objeto.
    public float spawnTime = 2f; // Tempo de intervalo entre as mudan�as de velocidade.
    public float spawnDelay = 2f; // Atraso inicial antes de come�ar a mudar a velocidade.

    public ParticleSystem coracao; // Sistema de part�culas p�blico para representar cora��es que ser� ativado em certos eventos. 

    bool canRun; // Vari�vel booleana privada que controla se o objeto pode se mover ou n�o.

    void Start() // M�todo de inicializa��o, chamado uma vez quando o script � ativado.
    {
        canRun = true; // Define que o objeto pode se mover inicialmente.
        moveSpeed = Vector3.left * Time.deltaTime; // Define a velocidade inicial do objeto para mover-se para a esquerda, ajustada com o tempo de frame para movimento suave.
        InvokeRepeating("ChangeSpeed", spawnDelay, spawnTime); // Chama repetidamente o m�todo 'ChangeSpeed' ap�s um atraso inicial ('spawnDelay') e a cada 'spawnTime' segundos.
    }
    void ChangeSpeed() // M�todo que altera a velocidade do objeto aleatoriamente dentro de um intervalo de valores.
    {
        if (canRun == true) // Verifica se o objeto ainda pode se mover.
        {
            moveSpeed = new Vector3(Random.Range(-1, -2), 0, 0) * 0.03f; // Altera a velocidade para um valor aleat�rio no eixo X (entre -1 e -2), multiplicado por 0.03 para reduzir a velocidade.
        }
    }

    void Update() // M�todo chamado uma vez por frame para atualizar a posi��o do objeto.
    {
        transform.position += moveSpeed; // Atualiza a posi��o do objeto com base na velocidade de movimento, movendo-o a cada frame.
    }

    private void OnCollisionEnter2D(Collision2D collision) // M�todo que � chamado quando o objeto colide com outro objeto (usando f�sica 2D).
    {
        if (collision.transform.CompareTag("Player")) // Verifica se o objeto com o qual colidiu tem a tag "Player".
        {
            canRun = false; // Desativa o movimento.
            moveSpeed = Vector3.zero; // Define a velocidade para zero, parando o objeto.

            if (coracao != null) // Verifica se o sistema de part�culas 'coracao' est� atribu�do.
            {
                coracao.Play(); // Inicia o efeito de part�culas.
            }
        }
    }
}
