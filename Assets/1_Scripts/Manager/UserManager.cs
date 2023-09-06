using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserManager
{
    public string name { get; set; }
    public string img { get; set; }

    public void SetName(string _name)
    {
        name = _name;
    }

    public void SetImg(string _img)
    { 
        img = _img; 
    }
}