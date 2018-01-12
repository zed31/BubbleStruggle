using UnityEngine;

public class ChainCollider : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D colliderHitten) {
        Chain_physics.m_isFireing = false;

        if (colliderHitten.tag == "Ball") {
            colliderHitten.GetComponent<Ball>().split();
        }

    }

}
