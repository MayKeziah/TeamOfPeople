        // string[] input = { "Brachiosaurus",
        //                    "Amargasaurus",
        //                    "Mamenchisaurus" };
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SerializeList
{

  public void serialize(List<List<GameObject>> list, string destination)
  {
    using(StreamWriter writetext = new StreamWriter(destination))
    {
        writetext.WriteLine("public Vector2[][] Perm1 = {");
        int wallCount = 0;
        foreach(List<GameObject> wall in list)
        {
          writetext.WriteLine("new Vector2[]{");
          int counter = 0;
          foreach(GameObject brick in wall)
          {
            writetext.WriteLine("new Vector2(" 
             + brick.transform.position.x + "f, "
             + brick.transform.position.y + "f)");
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
