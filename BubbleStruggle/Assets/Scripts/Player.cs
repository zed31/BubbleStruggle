using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    private float m_speed = 4f;
    [SerializeField]
    private Rigidbody2D m_rigidBody;
    private float m_movement = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        m_movement = Input.GetAxisRaw("Horizontal") * m_speed;
	}

    void FixedUpdate() {
        m_rigidBody.MovePosition(m_rigidBody.position + Vector2.right * (m_movement * Time.fixedDeltaTime));
    }
}
