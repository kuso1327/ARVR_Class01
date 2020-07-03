using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.y<-5)
        {
            Destroy(gameObject);
        }
    }

}
