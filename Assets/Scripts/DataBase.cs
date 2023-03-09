using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proyecto26;

public class DataBase : MonoBehaviour
{
    private string database_url = "https://carproject-d35a0-default-rtdb.asia-southeast1.firebasedatabase.app/";
    User user = new User();
    public string username = "taoyngwie_Test";


    public void save_toFirebase() //save data
    {
        user.sendX = ControllerSystem.instance.SendToFirebaseX;
        user.sendY = ControllerSystem.instance.SendToFirebaseY;
        RestClient.Put(database_url + "/" + ".json", user);
    }

    // Update is called once per frame
    void Update()
    {
        save_toFirebase();

    }
}
