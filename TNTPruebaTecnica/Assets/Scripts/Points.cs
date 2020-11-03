using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public ScoreManager scoreManager;
    public GameObject goal;
    bool active;

    private void Start()
    {
        scoreManager = ScoreManager.instance;
        active = true;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal")
        {            
            ScoreManager.Score1++;
            
            goal.SetActive(true);

            Debug.Log("Goal" + ScoreManager.Score1);

            StartCoroutine(Wait());
            
        }
    }
    public void ResetPosition()
    {
        Destroy(this.gameObject);
        scoreManager.ResetPosition();
    }
    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(1f);
        ResetPosition();
    }
   

}
