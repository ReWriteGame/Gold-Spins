using UnityEngine;
using UnityEngine.Events;

public class GameRuler : MonoBehaviour
{
    [SerializeField] private Arrow arrow1;
    [SerializeField] private Arrow arrow2;
    [SerializeField] private ScoreCounter scoreCounter;

  

    public void StopGame()
    {
        if(arrow1.collidedObject.GetComponent<Cell>().Value > 0)
            scoreCounter.Add(arrow1.collidedObject.GetComponent<Cell>().Value);
        else scoreCounter.TakeAway(Mathf.Abs(arrow1.collidedObject.GetComponent<Cell>().Value));

        if(arrow2.collidedObject.GetComponent<Cell>().Value > 0)
            scoreCounter.Add(arrow2.collidedObject.GetComponent<Cell>().Value);
        else scoreCounter.TakeAway(Mathf.Abs(arrow2.collidedObject.GetComponent<Cell>().Value));
    }


}
