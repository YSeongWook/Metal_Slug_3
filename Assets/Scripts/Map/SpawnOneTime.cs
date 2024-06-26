using UnityEngine;

public class SpawnOneTime : MonoBehaviour
{
    public bool random = false;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (GameManager.Instance.IsPlayer(collider))
        {
            if (!random) GetComponent<EventSpawn>().Trigger();
            else GetComponent<EventSpawn>().TriggerRandomCollectible();
            
            GetComponent<Collider2D>().enabled = false;
        }
    }
}