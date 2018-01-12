using UnityEngine;

public class Ball : MonoBehaviour {
    [SerializeField] protected Vector2 m_startForce;

    [SerializeField] protected Rigidbody2D m_rigidBody;

    [SerializeField] protected Ball m_nextBall;

	// Use this for initialization
	void Start () {
        m_rigidBody.AddForce(m_startForce, ForceMode2D.Impulse);
	}

    public void SetForce(Vector2 force)
    {
        m_startForce = force;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void Split() {
        if (m_nextBall != null) {
            Ball left = Instantiate(m_nextBall, m_rigidBody.position + Vector2.left / 4f, Quaternion.identity);
            Ball right = Instantiate(m_nextBall, m_rigidBody.position + Vector2.right / 4f, Quaternion.identity);
            left.m_startForce = new Vector2(-1f, 5f);
            right.m_startForce = new Vector2(1f, 5f);
        }
        Destroy(gameObject);
    }
}
