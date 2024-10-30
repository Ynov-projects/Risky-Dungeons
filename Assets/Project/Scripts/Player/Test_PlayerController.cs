using UnityEngine;
using Mirror;

public class PlayerController : NetworkBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Vérifie si le joueur actuel est le joueur local
        if (!isLocalPlayer) return;

        // Déplacement simple avec les touches ZQSD ou les flèches directionnelles
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(new Vector3(moveX, 0, moveZ));
    }
}
