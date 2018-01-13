using UnityEngine.UI;
using UnityEngine;

public class ChainCollider : MonoBehaviour {

    private int m_score;
    [SerializeField] private Text m_scoreText;

    private void SetScore() {
        m_scoreText.text = "SCORE: " + m_score.ToString();
    }

    void Start() {
        m_score = 0;
        SetScore();
    }

    void OnTriggerEnter2D(Collider2D colliderHitten) {
        Chain_physics.m_isFireing = false;

        if (colliderHitten.tag == "Ball") {
            m_score += 10;
            colliderHitten.GetComponent<Ball>().Split();
            Debug.Log("Destroying ball");
            SetScore();
        }

    }

}
