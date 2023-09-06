using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using ImageDatas;

public class JsonReader
{
    public ImageInfo ReadCharacterImageJson(string path)
    {
        string json = File.ReadAllText(path);
        return JsonUtility.FromJson<ImageInfo>(json);
    }
}
