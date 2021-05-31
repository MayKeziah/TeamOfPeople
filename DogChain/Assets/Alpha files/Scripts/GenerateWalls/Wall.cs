using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Wall
{ 
    public int len;
    public int x;
    public int y;
    public Direction towards;
    public string type;
  public Wall(int length, int xStart, int yStart, Direction direction, string wallType)
  {
    len = length;
    x = xStart;
    y = yStart;
    towards = direction;
    type = wallType;
  }
}
