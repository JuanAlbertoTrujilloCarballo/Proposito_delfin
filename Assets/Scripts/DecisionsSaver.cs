using UnityEngine;

public class DecisionsSaver : MonoBehaviour
{

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
        PlayerPrefs.SetInt("DecisionOne", 1);
        PlayerPrefs.Save();
    }
    
    public void SaveDecisionTwoBad()
    {
        PlayerPrefs.SetInt("DecisionOne", 0);
        PlayerPrefs.Save();
    }
}
