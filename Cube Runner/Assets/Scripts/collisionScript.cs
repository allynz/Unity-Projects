using UnityEngine;

public class collisionScript : MonoBehaviour
{
    public run rn;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            rn.enabled = false;
            FindObjectOfType<gamemanger>().endGame();
        }
    }

}
