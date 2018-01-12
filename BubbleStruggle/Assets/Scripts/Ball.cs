using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    [SerializeField] private Vector2 m_startForce;

    [SerializeField] private Rigidbody2D m_rigidBody;

    [SerializeField] private Ball m_nextBall;

	// Use this for initialization
	void Start () {
        m_rigidBody.AddForce(m_startForce, ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void split() {
        if (m_nextBall != null) {
            Ball left = Instantiate(m_nextBall, m_rigidBody.position + Vector2.left, Quaternion.identity);
            Ball right = Instantiate(m_nextBall, m_rigidBody.position + Vector2.right, Quaternion.identity);
            left.m_startForce = new Vector2(2f, 3f);
            right.m_startForce = new Vector2(-2f, 3f);
        }
        Destroy(gameObject);
    }
}
