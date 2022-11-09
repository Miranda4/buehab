using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class userId : MonoBehaviour
{
    public static userId instance;

    [SerializeField] public string id;

    private void Awake()
    {
        if (userId.instance == null)
        {
            userId.instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void crearId()
    {
        string fecha = System.DateTime.UtcNow.ToLocalTime().ToString();
        id = Regex.Replace(fecha, @"[^\d]", "");
    }
}
