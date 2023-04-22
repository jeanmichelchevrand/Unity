using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    private Vector2 velocity; //Variável que vai guardar a velocidade da câmera.
    private Transform player; //Vai guardar o Transform na variável player.

    public float smoothTimeX; //Variável que vai guardar o tempo que a câmera levar para se mover no eixo X atrás do personagem.
    public float smoothTimeY; //Variável que vai guardar o tempo que a câmera levar para se mover no eixo Y atrás do personagem.

    // Start is called before the first frame update
    void Start() {
        player = GameObject.Find("Player").GetComponent<Transform>(); //Vai buscar o Transform em outro script, no caso no script do jogador(Player).
    }

    void FixedUpdate() {
        float posX = Mathf.SmoothDamp(transform.position.x, player.position.x, ref velocity.x, smoothTimeX); //posX é a variável que vai guardar o os parâmetros da função da classe Mathf.
        float posY = Mathf.SmoothDamp(transform.position.y, player.position.y, ref velocity.y, smoothTimeY); //posY é a variável que vai guardar o os parâmetros da função da classe Mathf.

        transform.position = new Vector3(posX, posY, transform.position.z); //Vai dar uma nova posição para a câmera com base nos eixos X, Y e Z.
    }
}
