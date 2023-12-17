using UnityEngine;
using UnityEngine.Events;

public class DecisionsSaver : MonoBehaviour
{

    [SerializeField] 
    private UnityEvent onGoodWoman;
    
    [SerializeField] 
    private UnityEvent onBadWoman;
    
    public void SaveDecisionOneGood()
    {
        PlayerPrefs.SetInt("DecisionOne", 1);
        PlayerPrefs.Save();
    }
    
    public void SaveDecisionOneBad()
    {
        PlayerPrefs.SetInt("DecisionOne", 0);
        PlayerPrefs.Save();
    }
    
    public void SaveDecisionTwoGood()
    {
        PlayerPrefs.SetInt("DecisionTwo", 1);
        PlayerPrefs.Save();
    }
    
    public void SaveDecisionTwoBad()
    {
        PlayerPrefs.SetInt("DecisionTwo", 0);
        PlayerPrefs.Save();
    }

    public void DoJudge()
    {
        SaveDecisionOneGood();
        SaveDecisionTwoGood();
        
        int goodOptionOne = PlayerPrefs.GetInt("DecisionOne");
        int goodOptionTwo = PlayerPrefs.GetInt("DecisionTwo");
        if (goodOptionOne <= 0 || goodOptionTwo <= 0)
        {
            onBadWoman.Invoke();
        }
        else
        {
            onGoodWoman.Invoke();
        }
    }
}
