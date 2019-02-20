using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Transform player;
    public Text score_text;

    // Update is called once per frame
    void Update()
    {

        string score1 = player.position.z.ToString("0");
        score_text.text = score1;
        
    }
}
