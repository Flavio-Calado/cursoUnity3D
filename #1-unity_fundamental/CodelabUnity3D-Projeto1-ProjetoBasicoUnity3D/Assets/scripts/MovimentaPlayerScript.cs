using UnityEngine;
using System.Collections;

public class MovimentaPlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // pega a posição atual do player no jogo
        Vector3 posicao = transform.position;
        float movimentoLateral = Input.GetAxis("Horizontal");
        float movimentoVertical = Input.GetAxis("Vertical");
        // faz a multiplicação do movimento pelo tempo entre os frames
		movimentoLateral = movimentoLateral * Time.deltaTime;
		movimentoVertical = movimentoVertical * Time.deltaTime;
        // aplica os movimentos sobre o player
        transform.Translate(movimentoLateral, 0f, movimentoVertical);
	}
}
