using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoredMaps
{

/*****************************************************
 * Walls
 *****************************************************/
public Vector2[][] PermRoom1 = {
new Vector2[]{
new Vector2(-0.6045742f, -4.5f)
, 
new Vector2(-0.6045742f, -3.5f)
, 
new Vector2(-0.6045742f, -2.5f)
, 
new Vector2(-0.6045742f, -1.5f)
, 
new Vector2(-0.6045742f, -0.5f)
, 
new Vector2(-0.6045742f, 0.5f)
, 
new Vector2(-0.6045742f, 1.5f)
, 
new Vector2(-0.6045742f, 2.5f)
, 
new Vector2(-0.6045742f, 3.5f)
, 
new Vector2(-0.6045742f, 4.5f)
}
, 
new Vector2[]{
new Vector2(-0.6045742f, -5.5f)
, 
new Vector2(0.3954258f, -5.5f)
, 
new Vector2(1.395426f, -5.5f)
, 
new Vector2(2.395426f, -5.5f)
, 
new Vector2(3.395426f, -5.5f)
, 
new Vector2(4.395426f, -5.5f)
, 
new Vector2(5.395426f, -5.5f)
, 
new Vector2(6.395426f, -5.5f)
, 
new Vector2(7.395426f, -5.5f)
, 
new Vector2(8.395426f, -5.5f)
}
, 
new Vector2[]{
new Vector2(0.3954258f, 4.5f)
, 
new Vector2(1.395426f, 4.5f)
, 
new Vector2(2.395426f, 4.5f)
, 
new Vector2(3.395426f, 4.5f)
, 
new Vector2(4.395426f, 4.5f)
, 
new Vector2(5.395426f, 4.5f)
, 
new Vector2(6.395426f, 4.5f)
, 
new Vector2(7.395426f, 4.5f)
, 
new Vector2(8.395426f, 4.5f)
, 
new Vector2(9.395426f, 4.5f)
}
, 
new Vector2[]{
new Vector2(9.395426f, -5.5f)
, 
new Vector2(9.395426f, -4.5f)
, 
new Vector2(9.395426f, -3.5f)
, 
new Vector2(9.395426f, -2.5f)
, 
new Vector2(9.395426f, -1.5f)
}
};

public Vector2[][] PermRoom2 = {
new Vector2[]{
new Vector2(10.39543f, -5.5f)
, 
new Vector2(11.39543f, -5.5f)
, 
new Vector2(12.39543f, -5.5f)
, 
new Vector2(13.39543f, -5.5f)
, 
new Vector2(14.39543f, -5.5f)
, 
new Vector2(15.39543f, -5.5f)
, 
new Vector2(16.39543f, -5.5f)
, 
new Vector2(17.39543f, -5.5f)
, 
new Vector2(18.39543f, -5.5f)
, 
new Vector2(19.39543f, -5.5f)
}
, 
new Vector2[]{
new Vector2(10.39543f, 4.5f)
, 
new Vector2(11.39543f, 4.5f)
, 
new Vector2(12.39543f, 4.5f)
, 
new Vector2(13.39543f, 4.5f)
, 
new Vector2(14.39543f, 4.5f)
, 
new Vector2(15.39543f, 4.5f)
, 
new Vector2(16.39543f, 4.5f)
, 
new Vector2(17.39543f, 4.5f)
, 
new Vector2(18.39543f, 4.5f)
, 
new Vector2(19.39543f, 4.5f)
}
};

public Vector2[][] PermRoom3 = {
new Vector2[]{
new Vector2(20.39543f, -14.5f)
, 
new Vector2(20.39543f, -13.5f)
, 
new Vector2(20.39543f, -12.5f)
, 
new Vector2(20.39543f, -11.5f)
, 
new Vector2(20.39543f, -10.5f)
, 
new Vector2(20.39543f, -9.5f)
, 
new Vector2(20.39543f, -8.5f)
, 
new Vector2(20.39543f, -7.5f)
, 
new Vector2(20.39543f, -6.5f)
, 
new Vector2(20.39543f, -5.5f)
}
, 
new Vector2[]{
new Vector2(20.39543f, 4.5f)
, 
new Vector2(20.39543f, 5.5f)
, 
new Vector2(20.39543f, 6.5f)
, 
new Vector2(20.39543f, 7.5f)
, 
new Vector2(20.39543f, 8.5f)
, 
new Vector2(20.39543f, 9.5f)
, 
new Vector2(20.39543f, 10.5f)
, 
new Vector2(20.39543f, 11.5f)
, 
new Vector2(20.39543f, 12.5f)
, 
new Vector2(20.39543f, 13.5f)
}
, 
new Vector2[]{
new Vector2(21.39543f, -14.5f)
, 
new Vector2(22.39543f, -14.5f)
, 
new Vector2(23.39543f, -14.5f)
, 
new Vector2(24.39543f, -14.5f)
, 
new Vector2(25.39543f, -14.5f)
, 
new Vector2(26.39543f, -14.5f)
, 
new Vector2(27.39543f, -14.5f)
, 
new Vector2(28.39543f, -14.5f)
, 
new Vector2(29.39543f, -14.5f)
, 
new Vector2(30.39543f, -14.5f)
}
, 
new Vector2[]{
new Vector2(21.39543f, 13.5f)
, 
new Vector2(22.39543f, 13.5f)
, 
new Vector2(23.39543f, 13.5f)
, 
new Vector2(24.39543f, 13.5f)
, 
new Vector2(25.39543f, 13.5f)
, 
new Vector2(26.39543f, 13.5f)
, 
new Vector2(27.39543f, 13.5f)
, 
new Vector2(28.39543f, 13.5f)
, 
new Vector2(29.39543f, 13.5f)
, 
new Vector2(30.39543f, 13.5f)
}
, 
new Vector2[]{
new Vector2(36.39542f, 13.5f)
, 
new Vector2(37.39542f, 13.5f)
, 
new Vector2(38.39542f, 13.5f)
, 
new Vector2(39.39542f, 13.5f)
, 
new Vector2(40.39542f, 13.5f)
, 
new Vector2(41.39542f, 13.5f)
, 
new Vector2(42.39542f, 13.5f)
, 
new Vector2(43.39542f, 13.5f)
, 
new Vector2(44.39542f, 13.5f)
, 
new Vector2(45.39542f, 13.5f)
}
, 
new Vector2[]{
new Vector2(36.39542f, -14.5f)
, 
new Vector2(37.39542f, -14.5f)
, 
new Vector2(38.39542f, -14.5f)
, 
new Vector2(39.39542f, -14.5f)
, 
new Vector2(40.39542f, -14.5f)
, 
new Vector2(41.39542f, -14.5f)
, 
new Vector2(42.39542f, -14.5f)
, 
new Vector2(43.39542f, -14.5f)
, 
new Vector2(44.39542f, -14.5f)
, 
new Vector2(45.39542f, -14.5f)
}
, 
new Vector2[]{
new Vector2(46.39542f, 4.5f)
, 
new Vector2(46.39542f, 5.5f)
, 
new Vector2(46.39542f, 6.5f)
, 
new Vector2(46.39542f, 7.5f)
, 
new Vector2(46.39542f, 8.5f)
, 
new Vector2(46.39542f, 9.5f)
, 
new Vector2(46.39542f, 10.5f)
, 
new Vector2(46.39542f, 11.5f)
, 
new Vector2(46.39542f, 12.5f)
, 
new Vector2(46.39542f, 13.5f)
}
, 
new Vector2[]{
new Vector2(46.39542f, -14.5f)
, 
new Vector2(46.39542f, -13.5f)
, 
new Vector2(46.39542f, -12.5f)
, 
new Vector2(46.39542f, -11.5f)
, 
new Vector2(46.39542f, -10.5f)
, 
new Vector2(46.39542f, -9.5f)
, 
new Vector2(46.39542f, -8.5f)
, 
new Vector2(46.39542f, -7.5f)
, 
new Vector2(46.39542f, -6.5f)
, 
new Vector2(46.39542f, -5.5f)
}
};

public Vector2[][] PermRoom4 = {
new Vector2[]{
new Vector2(47.39542f, -5.5f)
, 
new Vector2(48.39542f, -5.5f)
, 
new Vector2(49.39542f, -5.5f)
, 
new Vector2(50.39542f, -5.5f)
, 
new Vector2(51.39542f, -5.5f)
, 
new Vector2(52.39542f, -5.5f)
, 
new Vector2(53.39542f, -5.5f)
, 
new Vector2(54.39542f, -5.5f)
, 
new Vector2(55.39542f, -5.5f)
, 
new Vector2(56.39542f, -5.5f)
}
, 
new Vector2[]{
new Vector2(47.39542f, 4.5f)
, 
new Vector2(48.39542f, 4.5f)
, 
new Vector2(49.39542f, 4.5f)
, 
new Vector2(50.39542f, 4.5f)
, 
new Vector2(51.39542f, 4.5f)
, 
new Vector2(52.39542f, 4.5f)
, 
new Vector2(53.39542f, 4.5f)
, 
new Vector2(54.39542f, 4.5f)
, 
new Vector2(55.39542f, 4.5f)
, 
new Vector2(56.39542f, 4.5f)
}
};

public Vector2[][] PermRoom5 = {
new Vector2[]{
new Vector2(57.39542f, -5.5f)
, 
new Vector2(58.39542f, -5.5f)
, 
new Vector2(59.39542f, -5.5f)
, 
new Vector2(60.39542f, -5.5f)
, 
new Vector2(61.39542f, -5.5f)
, 
new Vector2(62.39542f, -5.5f)
, 
new Vector2(63.39542f, -5.5f)
, 
new Vector2(64.39542f, -5.5f)
, 
new Vector2(65.39542f, -5.5f)
, 
new Vector2(66.39542f, -5.5f)
}
, 
new Vector2[]{
new Vector2(57.39542f, 4.5f)
, 
new Vector2(58.39542f, 4.5f)
, 
new Vector2(59.39542f, 4.5f)
, 
new Vector2(60.39542f, 4.5f)
, 
new Vector2(61.39542f, 4.5f)
, 
new Vector2(62.39542f, 4.5f)
, 
new Vector2(63.39542f, 4.5f)
, 
new Vector2(64.39542f, 4.5f)
, 
new Vector2(65.39542f, 4.5f)
, 
new Vector2(66.39542f, 4.5f)
}
};





/*****************************************************
 * Doors
 *****************************************************/
public Vector2[][] TempRoom1 = {
new Vector2[]{
new Vector2(9.395426f, -0.5f)
, 
new Vector2(9.395426f, 0.5f)
, 
new Vector2(9.395426f, 1.5f)
, 
new Vector2(9.395426f, 2.5f)
, 
new Vector2(9.395426f, 3.5f)
}
};
public Vector2[][] TempRoom2 = {
};

public Vector2[][] TempRoom3 = {
new Vector2[]{
new Vector2(31.39543f, 13.5f)
, 
new Vector2(32.39542f, 13.5f)
, 
new Vector2(33.39542f, 13.5f)
, 
new Vector2(34.39542f, 13.5f)
, 
new Vector2(35.39542f, 13.5f)
}
, 
new Vector2[]{
new Vector2(31.39543f, -14.5f)
, 
new Vector2(32.39542f, -14.5f)
, 
new Vector2(33.39542f, -14.5f)
, 
new Vector2(34.39542f, -14.5f)
, 
new Vector2(35.39542f, -14.5f)
}
};

public Vector2[][] TempRoom4 = {
};
public Vector2[][] TempRoom5 = {
};




public Vector2[][][] getPermanent()
{
  Vector2[][][] rooms = {PermRoom1, PermRoom2, PermRoom3, PermRoom4, PermRoom5};
  return rooms;
}

public Vector2[][][] getTemporary()
{
  Vector2[][][] doors = {TempRoom1, TempRoom2, TempRoom3, TempRoom4, TempRoom5};
  return doors;
}

}