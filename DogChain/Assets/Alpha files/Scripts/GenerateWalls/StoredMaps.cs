using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class StoredMaps
{
public Vector2[][] Temp1 = {
new Vector2[]{
new Vector2(-15.73529f, 0.5f)
, 
new Vector2(-14.73529f, 0.5f)
, 
new Vector2(-13.73529f, 0.5f)
, 
new Vector2(-12.73529f, 0.5f)
, 
new Vector2(-11.73529f, 0.5f)
, 
new Vector2(-10.73529f, 0.5f)
, 
new Vector2(-9.735294f, 0.5f)
, 
new Vector2(-8.735294f, 0.5f)
, 
new Vector2(-7.735294f, 0.5f)
, 
new Vector2(-6.735294f, 0.5f)
, 
new Vector2(-5.735294f, 0.5f)
, 
new Vector2(-4.735294f, 0.5f)
, 
new Vector2(-3.735294f, 0.5f)
, 
new Vector2(-2.735294f, 0.5f)
, 
new Vector2(-1.735294f, 0.5f)
, 
new Vector2(-0.7352943f, 0.5f)
, 
new Vector2(0.2647057f, 0.5f)
, 
new Vector2(1.264706f, 0.5f)
, 
new Vector2(2.264706f, 0.5f)
}
};



public Vector2[][] Perm1 = {
new Vector2[]{
new Vector2(-7.735294f, -9.5f)
, 
new Vector2(-7.735294f, -8.5f)
, 
new Vector2(-7.735294f, -7.5f)
, 
new Vector2(-7.735294f, -6.5f)
, 
new Vector2(-7.735294f, -5.5f)
, 
new Vector2(-7.735294f, -4.5f)
, 
new Vector2(-7.735294f, -3.5f)
, 
new Vector2(-7.735294f, -2.5f)
, 
new Vector2(-7.735294f, -1.5f)
, 
new Vector2(-7.735294f, -0.5f)
, 
new Vector2(-7.735294f, 0.5f)
, 
new Vector2(-7.735294f, 1.5f)
, 
new Vector2(-7.735294f, 2.5f)
, 
new Vector2(-7.735294f, 3.5f)
, 
new Vector2(-7.735294f, 4.5f)
, 
new Vector2(-7.735294f, 5.5f)
, 
new Vector2(-7.735294f, 6.5f)
, 
new Vector2(-7.735294f, 7.5f)
, 
new Vector2(-7.735294f, 8.5f)
}
, 
new Vector2[]{
new Vector2(2.264706f, -9.5f)
, 
new Vector2(2.264706f, -8.5f)
, 
new Vector2(2.264706f, -7.5f)
, 
new Vector2(2.264706f, -6.5f)
, 
new Vector2(2.264706f, -5.5f)
, 
new Vector2(2.264706f, -4.5f)
, 
new Vector2(2.264706f, -3.5f)
, 
new Vector2(2.264706f, -2.5f)
, 
new Vector2(2.264706f, -1.5f)
, 
new Vector2(2.264706f, -0.5f)
, 
new Vector2(2.264706f, 0.5f)
, 
new Vector2(2.264706f, 1.5f)
, 
new Vector2(2.264706f, 2.5f)
, 
new Vector2(2.264706f, 3.5f)
, 
new Vector2(2.264706f, 4.5f)
, 
new Vector2(2.264706f, 5.5f)
, 
new Vector2(2.264706f, 6.5f)
, 
new Vector2(2.264706f, 7.5f)
, 
new Vector2(2.264706f, 8.5f)
}
, 
new Vector2[]{
new Vector2(7.264706f, -9.5f)
, 
new Vector2(7.264706f, -8.5f)
, 
new Vector2(7.264706f, -7.5f)
, 
new Vector2(7.264706f, -6.5f)
, 
new Vector2(7.264706f, -5.5f)
, 
new Vector2(7.264706f, -4.5f)
, 
new Vector2(7.264706f, -3.5f)
, 
new Vector2(7.264706f, -2.5f)
, 
new Vector2(7.264706f, -1.5f)
, 
new Vector2(7.264706f, -0.5f)
, 
new Vector2(7.264706f, 0.5f)
, 
new Vector2(7.264706f, 1.5f)
, 
new Vector2(7.264706f, 2.5f)
, 
new Vector2(7.264706f, 3.5f)
, 
new Vector2(7.264706f, 4.5f)
, 
new Vector2(7.264706f, 5.5f)
, 
new Vector2(7.264706f, 6.5f)
, 
new Vector2(7.264706f, 7.5f)
, 
new Vector2(7.264706f, 8.5f)
}
, 
new Vector2[]{
new Vector2(-15.73529f, -9.5f)
, 
new Vector2(-15.73529f, -8.5f)
, 
new Vector2(-15.73529f, -7.5f)
, 
new Vector2(-15.73529f, -6.5f)
, 
new Vector2(-15.73529f, -5.5f)
, 
new Vector2(-15.73529f, -4.5f)
, 
new Vector2(-15.73529f, -3.5f)
, 
new Vector2(-15.73529f, -2.5f)
, 
new Vector2(-15.73529f, -1.5f)
, 
new Vector2(-15.73529f, -0.5f)
, 
new Vector2(-15.73529f, 0.5f)
, 
new Vector2(-15.73529f, 1.5f)
, 
new Vector2(-15.73529f, 2.5f)
, 
new Vector2(-15.73529f, 3.5f)
, 
new Vector2(-15.73529f, 4.5f)
, 
new Vector2(-15.73529f, 5.5f)
, 
new Vector2(-15.73529f, 6.5f)
, 
new Vector2(-15.73529f, 7.5f)
, 
new Vector2(-15.73529f, 8.5f)
}
, 
new Vector2[]{
new Vector2(-15.73529f, -9.5f)
, 
new Vector2(-15.73529f, -8.5f)
, 
new Vector2(-15.73529f, -7.5f)
, 
new Vector2(-15.73529f, -6.5f)
, 
new Vector2(-15.73529f, -5.5f)
, 
new Vector2(-15.73529f, -4.5f)
, 
new Vector2(-15.73529f, -3.5f)
, 
new Vector2(-15.73529f, -2.5f)
, 
new Vector2(-15.73529f, -1.5f)
, 
new Vector2(-15.73529f, -0.5f)
, 
new Vector2(-15.73529f, 0.5f)
, 
new Vector2(-15.73529f, 1.5f)
, 
new Vector2(-15.73529f, 2.5f)
, 
new Vector2(-15.73529f, 3.5f)
, 
new Vector2(-15.73529f, 4.5f)
, 
new Vector2(-15.73529f, 5.5f)
, 
new Vector2(-15.73529f, 6.5f)
, 
new Vector2(-15.73529f, 7.5f)
, 
new Vector2(-15.73529f, 8.5f)
}
};





}