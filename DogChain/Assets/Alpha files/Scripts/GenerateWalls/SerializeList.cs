        // string[] input = { "Brachiosaurus",
        //                    "Amargasaurus",
        //                    "Mamenchisaurus" };
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SerializeList
{

  public void serialize(List<List<GameObject>> list)
  {
    using(StreamWriter writetext = new StreamWriter("maps.txt"))
    {
        writetext.WriteLine("GameObject[] customMap = {");
        int wallCount = 0;
        foreach(List<GameObject> wall in list)
        {
          writetext.WriteLine("{");
          int counter = 0;
          foreach(GameObject brick in wall)
          {
            writetext.WriteLine("new Vector3(" 
             + brick.transform.position.x + ", "
             + brick.transform.position.y + ", "
             + brick.transform.position.z + ")");
             if (counter != wall.Count - 1) writetext.WriteLine(", ");
             counter++;
          }
          writetext.WriteLine("}");
          if (wallCount != list.Count - 1) writetext.WriteLine(", ");
          wallCount++;
        }
        writetext.WriteLine("};");
    }
  }
}
