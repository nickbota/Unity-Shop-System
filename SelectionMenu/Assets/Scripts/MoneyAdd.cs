using UnityEngine;

public class MoneyAdd : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SaveManager.instance.money += 100;
            SaveManager.instance.Save();
        }
        else if (Input.GetKeyDown(KeyCode.F))
        { 
            SaveManager.instance.money -= 100;
            SaveManager.instance.Save();
        }
    }
}