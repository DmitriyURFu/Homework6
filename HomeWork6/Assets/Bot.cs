using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Bot : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private NavMeshAgent bot;

    private void Start()
    {
        bot = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        bot.destination = player.transform.position;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(1);
        }

    }
}
