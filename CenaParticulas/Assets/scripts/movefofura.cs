using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem; // Permite o uso de tipos do namespace 'ParticleSystem' sem precisar prefixar com 'ParticleSystem'.

public class MoveFofu : MonoBehaviour
{
    public Vector3 moveSpeed; // Um vetor 3D público que define a velocidade de movimento do objeto.
    public float spawnTime = 2f; // Tempo de intervalo entre as mudanças de velocidade.
    public float spawnDelay = 2f; // Atraso inicial antes de começar a mudar a velocidade.

    public ParticleSystem coracao; // Sistema de partículas público para representar corações que será ativado em certos eventos. 

    bool canRun; // Variável booleana privada que controla se o objeto pode se mover ou não.

    void Start() // Método de inicialização, chamado uma vez quando o script é ativado.
    {
        canRun = true; // Define que o objeto pode se mover inicialmente.
        moveSpeed = Vector3.left * Time.deltaTime; // Define a velocidade inicial do objeto para mover-se para a esquerda, ajustada com o tempo de frame para movimento suave.
        InvokeRepeating("ChangeSpeed", spawnDelay, spawnTime); // Chama repetidamente o método 'ChangeSpeed' após um atraso inicial ('spawnDelay') e a cada 'spawnTime' segundos.
    }
    void ChangeSpeed() // Método que altera a velocidade do objeto aleatoriamente dentro de um intervalo de valores.
    {
        if (canRun == true) // Verifica se o objeto ainda pode se mover.
        {
            moveSpeed = new Vector3(Random.Range(-1, -2), 0, 0) * 0.03f; // Altera a velocidade para um valor aleatório no eixo X (entre -1 e -2), multiplicado por 0.03 para reduzir a velocidade.
        }
    }

    void Update() // Método chamado uma vez por frame para atualizar a posição do objeto.
    {
        transform.position += moveSpeed; // Atualiza a posição do objeto com base na velocidade de movimento, movendo-o a cada frame.
    }

    private void OnCollisionEnter2D(Collision2D collision) // Método que é chamado quando o objeto colide com outro objeto (usando física 2D).
    {
        if (collision.transform.CompareTag("Player")) // Verifica se o objeto com o qual colidiu tem a tag "Player".
        {
            canRun = false; // Desativa o movimento.
            moveSpeed = Vector3.zero; // Define a velocidade para zero, parando o objeto.

            if (coracao != null) // Verifica se o sistema de partículas 'coracao' está atribuído.
            {
                coracao.Play(); // Inicia o efeito de partículas.
            }
        }
    }
}
