using System.Linq;
using UnityEngine;

public class AnnoyingBalls : Ball {
    public override void Split()
    {
        Debug.Log("Spliting balls");
        if (m_nextBall != null)
        {
            foreach (var i in Enumerable.Range(0, 5))
            {
                Ball left = Instantiate(m_nextBall, m_rigidBody.position + Vector2.left, Quaternion.identity);
                Ball right = Instantiate(m_nextBall, m_rigidBody.position + Vector2.right, Quaternion.identity);
                left.SetForce(new Vector2(-1f + i, 5f + i));
                right.SetForce(new Vector2(1f + i, 5f + i));
            }
        }
        Destroy(gameObject);
    }
}
