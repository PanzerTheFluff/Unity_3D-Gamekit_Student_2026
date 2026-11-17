using UnityEngine;
public enum ElementalPower
{
None,
Fire,
Ice,
Lightning,
Earth
}

[System.Serializable]
public struct CharacterInformation
{
    public string name;
    public ElementalPower elementalPower;
    public float speed;
    public int health;
    public bool canFly;
    public int damagePower;
    
}
public class WS2 : MonoBehaviour
{
    public ElementalPower elementKraft;

    public CharacterInformation characterinformation;

    public int[] highScores;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        Debug.Log(elementKraft);

        Debug.Log(CharacterInformation.name);

        Debug.Log(highScores[2]);

        foreach (CharacterInformation) ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
