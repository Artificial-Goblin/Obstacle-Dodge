using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = -1;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You've hit obstacles this many times: " + hits);
        }
    }
}
