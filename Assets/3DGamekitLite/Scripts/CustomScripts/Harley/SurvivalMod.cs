using Gamekit3D;
using UnityEngine;

public class SurvivalMod : MonoBehaviour
{
    [SerializeField] private float thirstLevel = 100f;
    [SerializeField] private float thirstSpeed;
    [SerializeField] private float timer = 10f;

    [SerializeField] private bool thirsty;
    [SerializeField] private bool parched;

    public int waterBottles = 0;

    [SerializeField] private GameObject playerObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerObject = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        thirstLevel -= Mathf.Clamp(thirstSpeed*Time.deltaTime, 0, thirstLevel);

        if (thirstLevel <= 50f && thirsty == false)
        {
            Debug.Log("I'm getting thirsty...");
            thirsty = true;
        }
        if (thirstLevel <= 20f && parched == false)
            {
                Debug.Log("I NEED WATER!");
                parched = true;
            }

        if (thirstLevel <= 0 && thirsty)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                ThirstDamage();
                timer = 10f;
            }
        }
    }

    private void ThirstDamage()
    {
        Damageable.DamageMessage msg = new Damageable.DamageMessage()
                    {
                        amount = 1,
                        damager = this,
                        damageSource = new Vector3(x: 0, y: 0, z: 0),
                        direction = Vector3.forward,
                        stopCamera = false,
                        throwing = false
                    };
                    playerObject.GetComponent<Damageable>().ApplyDamage(msg);
                    Debug.Log("Damage from thirst");
    }

    public void AddWater()
    {
        Debug.Log("Added random water");
    }
}
