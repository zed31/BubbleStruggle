using UnityEngine;

public class Chain_physics : MonoBehaviour {

    public static bool m_isFireing;

    [SerializeField] private Transform m_player;

    [SerializeField] private float m_speed = 20f;

    // Use this for initialization
    void Start()
    {
        m_isFireing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Shoot")) {
            m_isFireing = true;
        }
        if (m_isFireing)
        {
            transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * m_speed;
        }
        else
        {
            transform.position = m_player.position;
            transform.localScale = new Vector3(1f, 0f, 1f);
        }
    }
}
