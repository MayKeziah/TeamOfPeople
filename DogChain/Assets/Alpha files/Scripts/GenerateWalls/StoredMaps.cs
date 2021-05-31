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

public Vector2[][] PermRoom6 = {
new Vector2[]{
new Vector2(67.39542f, -5.5f)
, 
new Vector2(68.39542f, -5.5f)
, 
new Vector2(69.39542f, -5.5f)
, 
new Vector2(70.39542f, -5.5f)
, 
new Vector2(71.39542f, -5.5f)
, 
new Vector2(72.39542f, -5.5f)
, 
new Vector2(73.39542f, -5.5f)
, 
new Vector2(74.39542f, -5.5f)
, 
new Vector2(75.39542f, -5.5f)
, 
new Vector2(76.39542f, -5.5f)
}
, 
new Vector2[]{
new Vector2(67.39542f, 4.5f)
, 
new Vector2(68.39542f, 4.5f)
, 
new Vector2(69.39542f, 4.5f)
, 
new Vector2(70.39542f, 4.5f)
, 
new Vector2(71.39542f, 4.5f)
, 
new Vector2(72.39542f, 4.5f)
, 
new Vector2(73.39542f, 4.5f)
, 
new Vector2(74.39542f, 4.5f)
, 
new Vector2(75.39542f, 4.5f)
, 
new Vector2(76.39542f, 4.5f)
}
};

public Vector2[][] PermRoom7 = {
new Vector2[]{
new Vector2(87.39542f, -5.5f)
, 
new Vector2(87.39542f, -4.5f)
, 
new Vector2(87.39542f, -3.5f)
, 
new Vector2(87.39542f, -2.5f)
, 
new Vector2(87.39542f, -1.5f)
, 
new Vector2(87.39542f, -0.5f)
, 
new Vector2(87.39542f, 0.5f)
, 
new Vector2(87.39542f, 1.5f)
, 
new Vector2(87.39542f, 2.5f)
, 
new Vector2(87.39542f, 3.5f)
, 
new Vector2(87.39542f, 4.5f)
}
};

public Vector2[][] PermRoom8 = {
new Vector2[]{
new Vector2(76.39542f, 5.5f)
, 
new Vector2(76.39542f, 6.5f)
, 
new Vector2(76.39542f, 7.5f)
, 
new Vector2(76.39542f, 8.5f)
, 
new Vector2(76.39542f, 9.5f)
, 
new Vector2(76.39542f, 10.5f)
, 
new Vector2(76.39542f, 11.5f)
, 
new Vector2(76.39542f, 12.5f)
, 
new Vector2(76.39542f, 13.5f)
, 
new Vector2(76.39542f, 14.5f)
}
, 
new Vector2[]{
new Vector2(77.39542f, 14.5f)
, 
new Vector2(78.39542f, 14.5f)
, 
new Vector2(79.39542f, 14.5f)
, 
new Vector2(80.39542f, 14.5f)
, 
new Vector2(81.39542f, 14.5f)
, 
new Vector2(82.39542f, 14.5f)
, 
new Vector2(83.39542f, 14.5f)
, 
new Vector2(84.39542f, 14.5f)
, 
new Vector2(85.39542f, 14.5f)
, 
new Vector2(86.39542f, 14.5f)
}
};

public Vector2[][] PermRoom9 = {
new Vector2[]{
new Vector2(88.39542f, 4.5f)
, 
new Vector2(89.39542f, 4.5f)
, 
new Vector2(90.39542f, 4.5f)
, 
new Vector2(91.39542f, 4.5f)
, 
new Vector2(92.39542f, 4.5f)
, 
new Vector2(93.39542f, 4.5f)
, 
new Vector2(94.39542f, 4.5f)
, 
new Vector2(95.39542f, 4.5f)
, 
new Vector2(96.39542f, 4.5f)
, 
new Vector2(97.39542f, 4.5f)
}
, 
new Vector2[]{
new Vector2(87.39542f, 14.5f)
, 
new Vector2(88.39542f, 14.5f)
, 
new Vector2(89.39542f, 14.5f)
, 
new Vector2(90.39542f, 14.5f)
, 
new Vector2(91.39542f, 14.5f)
, 
new Vector2(92.39542f, 14.5f)
, 
new Vector2(93.39542f, 14.5f)
, 
new Vector2(94.39542f, 14.5f)
, 
new Vector2(95.39542f, 14.5f)
, 
new Vector2(96.39542f, 14.5f)
}
, 
new Vector2[]{
new Vector2(98.39542f, 4.5f)
, 
new Vector2(99.39542f, 4.5f)
, 
new Vector2(100.3954f, 4.5f)
, 
new Vector2(101.3954f, 4.5f)
, 
new Vector2(102.3954f, 4.5f)
, 
new Vector2(103.3954f, 4.5f)
, 
new Vector2(104.3954f, 4.5f)
, 
new Vector2(105.3954f, 4.5f)
, 
new Vector2(106.3954f, 4.5f)
, 
new Vector2(107.3954f, 4.5f)
}
, 
new Vector2[]{
new Vector2(97.39542f, 14.5f)
, 
new Vector2(98.39542f, 14.5f)
, 
new Vector2(99.39542f, 14.5f)
, 
new Vector2(100.3954f, 14.5f)
, 
new Vector2(101.3954f, 14.5f)
, 
new Vector2(102.3954f, 14.5f)
, 
new Vector2(103.3954f, 14.5f)
, 
new Vector2(104.3954f, 14.5f)
, 
new Vector2(105.3954f, 14.5f)
, 
new Vector2(106.3954f, 14.5f)
}
, 
new Vector2[]{
new Vector2(108.3954f, 4.5f)
, 
new Vector2(109.3954f, 4.5f)
, 
new Vector2(110.3954f, 4.5f)
, 
new Vector2(111.3954f, 4.5f)
, 
new Vector2(112.3954f, 4.5f)
, 
new Vector2(113.3954f, 4.5f)
, 
new Vector2(114.3954f, 4.5f)
, 
new Vector2(115.3954f, 4.5f)
, 
new Vector2(116.3954f, 4.5f)
, 
new Vector2(117.3954f, 4.5f)
}
, 
new Vector2[]{
new Vector2(107.3954f, 14.5f)
, 
new Vector2(108.3954f, 14.5f)
, 
new Vector2(109.3954f, 14.5f)
, 
new Vector2(110.3954f, 14.5f)
, 
new Vector2(111.3954f, 14.5f)
, 
new Vector2(112.3954f, 14.5f)
, 
new Vector2(113.3954f, 14.5f)
, 
new Vector2(114.3954f, 14.5f)
, 
new Vector2(115.3954f, 14.5f)
, 
new Vector2(116.3954f, 14.5f)
}
, 
new Vector2[]{
new Vector2(117.3954f, 5.5f)
, 
new Vector2(117.3954f, 6.5f)
, 
new Vector2(117.3954f, 7.5f)
, 
new Vector2(117.3954f, 8.5f)
, 
new Vector2(117.3954f, 9.5f)
, 
new Vector2(117.3954f, 10.5f)
, 
new Vector2(117.3954f, 11.5f)
, 
new Vector2(117.3954f, 12.5f)
, 
new Vector2(117.3954f, 13.5f)
, 
new Vector2(117.3954f, 14.5f)
}
};

public Vector2[][] PermRoom10 = {
new Vector2[]{
new Vector2(76.39542f, -15.5f)
, 
new Vector2(76.39542f, -14.5f)
, 
new Vector2(76.39542f, -13.5f)
, 
new Vector2(76.39542f, -12.5f)
, 
new Vector2(76.39542f, -11.5f)
, 
new Vector2(76.39542f, -10.5f)
, 
new Vector2(76.39542f, -9.5f)
, 
new Vector2(76.39542f, -8.5f)
, 
new Vector2(76.39542f, -7.5f)
, 
new Vector2(76.39542f, -6.5f)
}
, 
new Vector2[]{
new Vector2(77.39542f, -15.5f)
, 
new Vector2(78.39542f, -15.5f)
, 
new Vector2(79.39542f, -15.5f)
, 
new Vector2(80.39542f, -15.5f)
, 
new Vector2(81.39542f, -15.5f)
, 
new Vector2(82.39542f, -15.5f)
, 
new Vector2(83.39542f, -15.5f)
, 
new Vector2(84.39542f, -15.5f)
, 
new Vector2(85.39542f, -15.5f)
, 
new Vector2(86.39542f, -15.5f)
}
, 
new Vector2[]{
new Vector2(87.39542f, -15.5f)
, 
new Vector2(88.39542f, -15.5f)
, 
new Vector2(89.39542f, -15.5f)
, 
new Vector2(90.39542f, -15.5f)
, 
new Vector2(91.39542f, -15.5f)
, 
new Vector2(92.39542f, -15.5f)
, 
new Vector2(93.39542f, -15.5f)
, 
new Vector2(94.39542f, -15.5f)
, 
new Vector2(95.39542f, -15.5f)
, 
new Vector2(96.39542f, -15.5f)
}
, 
new Vector2[]{
new Vector2(88.39542f, -5.5f)
, 
new Vector2(89.39542f, -5.5f)
, 
new Vector2(90.39542f, -5.5f)
, 
new Vector2(91.39542f, -5.5f)
, 
new Vector2(92.39542f, -5.5f)
, 
new Vector2(93.39542f, -5.5f)
, 
new Vector2(94.39542f, -5.5f)
, 
new Vector2(95.39542f, -5.5f)
, 
new Vector2(96.39542f, -5.5f)
, 
new Vector2(97.39542f, -5.5f)
}
, 
new Vector2[]{
new Vector2(98.39542f, -5.5f)
, 
new Vector2(99.39542f, -5.5f)
, 
new Vector2(100.3954f, -5.5f)
, 
new Vector2(101.3954f, -5.5f)
, 
new Vector2(102.3954f, -5.5f)
, 
new Vector2(103.3954f, -5.5f)
, 
new Vector2(104.3954f, -5.5f)
, 
new Vector2(105.3954f, -5.5f)
, 
new Vector2(106.3954f, -5.5f)
, 
new Vector2(107.3954f, -5.5f)
}
, 
new Vector2[]{
new Vector2(108.3954f, -14.5f)
, 
new Vector2(108.3954f, -13.5f)
, 
new Vector2(108.3954f, -12.5f)
, 
new Vector2(108.3954f, -11.5f)
, 
new Vector2(108.3954f, -10.5f)
, 
new Vector2(108.3954f, -9.5f)
, 
new Vector2(108.3954f, -8.5f)
, 
new Vector2(108.3954f, -7.5f)
, 
new Vector2(108.3954f, -6.5f)
, 
new Vector2(108.3954f, -5.5f)
}
, 
new Vector2[]{
new Vector2(108.3954f, -23.5f)
, 
new Vector2(108.3954f, -22.5f)
, 
new Vector2(108.3954f, -21.5f)
, 
new Vector2(108.3954f, -20.5f)
, 
new Vector2(108.3954f, -19.5f)
, 
new Vector2(108.3954f, -18.5f)
, 
new Vector2(108.3954f, -17.5f)
, 
new Vector2(108.3954f, -16.5f)
, 
new Vector2(108.3954f, -15.5f)
, 
new Vector2(108.3954f, -14.5f)
}
, 
new Vector2[]{
new Vector2(97.39542f, -24.5f)
, 
new Vector2(97.39542f, -23.5f)
, 
new Vector2(97.39542f, -22.5f)
, 
new Vector2(97.39542f, -21.5f)
, 
new Vector2(97.39542f, -20.5f)
, 
new Vector2(97.39542f, -19.5f)
, 
new Vector2(97.39542f, -18.5f)
, 
new Vector2(97.39542f, -17.5f)
, 
new Vector2(97.39542f, -16.5f)
, 
new Vector2(97.39542f, -15.5f)
}
, 
new Vector2[]{
new Vector2(108.3954f, -33.5f)
, 
new Vector2(108.3954f, -32.5f)
, 
new Vector2(108.3954f, -31.5f)
, 
new Vector2(108.3954f, -30.5f)
, 
new Vector2(108.3954f, -29.5f)
, 
new Vector2(108.3954f, -28.5f)
, 
new Vector2(108.3954f, -27.5f)
, 
new Vector2(108.3954f, -26.5f)
, 
new Vector2(108.3954f, -25.5f)
, 
new Vector2(108.3954f, -24.5f)
}
, 
new Vector2[]{
new Vector2(96.39542f, -24.5f)
, 
new Vector2(95.39542f, -24.5f)
, 
new Vector2(94.39542f, -24.5f)
, 
new Vector2(93.39542f, -24.5f)
, 
new Vector2(92.39542f, -24.5f)
, 
new Vector2(91.39542f, -24.5f)
, 
new Vector2(90.39542f, -24.5f)
, 
new Vector2(89.39542f, -24.5f)
, 
new Vector2(88.39542f, -24.5f)
, 
new Vector2(87.39542f, -24.5f)
}
, 
new Vector2[]{
new Vector2(87.39542f, -33.5f)
, 
new Vector2(87.39542f, -32.5f)
, 
new Vector2(87.39542f, -31.5f)
, 
new Vector2(87.39542f, -30.5f)
, 
new Vector2(87.39542f, -29.5f)
, 
new Vector2(87.39542f, -28.5f)
, 
new Vector2(87.39542f, -27.5f)
, 
new Vector2(87.39542f, -26.5f)
, 
new Vector2(87.39542f, -25.5f)
, 
new Vector2(87.39542f, -24.5f)
}
, 
new Vector2[]{
new Vector2(87.39542f, -34.5f)
, 
new Vector2(88.39542f, -34.5f)
, 
new Vector2(89.39542f, -34.5f)
, 
new Vector2(90.39542f, -34.5f)
, 
new Vector2(91.39542f, -34.5f)
, 
new Vector2(92.39542f, -34.5f)
, 
new Vector2(93.39542f, -34.5f)
, 
new Vector2(94.39542f, -34.5f)
, 
new Vector2(95.39542f, -34.5f)
, 
new Vector2(96.39542f, -34.5f)
}
, 
new Vector2[]{
new Vector2(97.39542f, -34.5f)
, 
new Vector2(98.39542f, -34.5f)
, 
new Vector2(99.39542f, -34.5f)
, 
new Vector2(100.3954f, -34.5f)
, 
new Vector2(101.3954f, -34.5f)
, 
new Vector2(102.3954f, -34.5f)
, 
new Vector2(103.3954f, -34.5f)
, 
new Vector2(104.3954f, -34.5f)
, 
new Vector2(105.3954f, -34.5f)
, 
new Vector2(106.3954f, -34.5f)
, 
new Vector2(107.3954f, -34.5f)
, 
new Vector2(108.3954f, -34.5f)
}
};

public Vector2[][] PermRoom11 = {
new Vector2[]{
new Vector2(28.39543f, -24.5f)
, 
new Vector2(28.39543f, -23.5f)
, 
new Vector2(28.39543f, -22.5f)
, 
new Vector2(28.39543f, -21.5f)
, 
new Vector2(28.39543f, -20.5f)
, 
new Vector2(28.39543f, -19.5f)
, 
new Vector2(28.39543f, -18.5f)
, 
new Vector2(28.39543f, -17.5f)
, 
new Vector2(28.39543f, -16.5f)
, 
new Vector2(28.39543f, -15.5f)
}
, 
new Vector2[]{
new Vector2(38.39542f, -24.5f)
, 
new Vector2(38.39542f, -23.5f)
, 
new Vector2(38.39542f, -22.5f)
, 
new Vector2(38.39542f, -21.5f)
, 
new Vector2(38.39542f, -20.5f)
, 
new Vector2(38.39542f, -19.5f)
, 
new Vector2(38.39542f, -18.5f)
, 
new Vector2(38.39542f, -17.5f)
, 
new Vector2(38.39542f, -16.5f)
, 
new Vector2(38.39542f, -15.5f)
}
, 
new Vector2[]{
new Vector2(28.39543f, -34.5f)
, 
new Vector2(28.39543f, -33.5f)
, 
new Vector2(28.39543f, -32.5f)
, 
new Vector2(28.39543f, -31.5f)
, 
new Vector2(28.39543f, -30.5f)
, 
new Vector2(28.39543f, -29.5f)
, 
new Vector2(28.39543f, -28.5f)
, 
new Vector2(28.39543f, -27.5f)
, 
new Vector2(28.39543f, -26.5f)
, 
new Vector2(28.39543f, -25.5f)
}
, 
new Vector2[]{
new Vector2(38.39542f, -34.5f)
, 
new Vector2(38.39542f, -33.5f)
, 
new Vector2(38.39542f, -32.5f)
, 
new Vector2(38.39542f, -31.5f)
, 
new Vector2(38.39542f, -30.5f)
, 
new Vector2(38.39542f, -29.5f)
, 
new Vector2(38.39542f, -28.5f)
, 
new Vector2(38.39542f, -27.5f)
, 
new Vector2(38.39542f, -26.5f)
, 
new Vector2(38.39542f, -25.5f)
}
, 
new Vector2[]{
new Vector2(38.39542f, -44.5f)
, 
new Vector2(38.39542f, -43.5f)
, 
new Vector2(38.39542f, -42.5f)
, 
new Vector2(38.39542f, -41.5f)
, 
new Vector2(38.39542f, -40.5f)
, 
new Vector2(38.39542f, -39.5f)
, 
new Vector2(38.39542f, -38.5f)
, 
new Vector2(38.39542f, -37.5f)
, 
new Vector2(38.39542f, -36.5f)
, 
new Vector2(38.39542f, -35.5f)
}
};

public Vector2[][] PermRoom12 = {
new Vector2[]{
new Vector2(27.39543f, -34.5f)
, 
new Vector2(26.39543f, -34.5f)
, 
new Vector2(25.39543f, -34.5f)
, 
new Vector2(24.39543f, -34.5f)
, 
new Vector2(23.39543f, -34.5f)
, 
new Vector2(22.39543f, -34.5f)
, 
new Vector2(21.39543f, -34.5f)
, 
new Vector2(20.39543f, -34.5f)
, 
new Vector2(19.39543f, -34.5f)
, 
new Vector2(18.39543f, -34.5f)
}
, 
new Vector2[]{
new Vector2(27.39543f, -44.5f)
, 
new Vector2(26.39543f, -44.5f)
, 
new Vector2(25.39543f, -44.5f)
, 
new Vector2(24.39543f, -44.5f)
, 
new Vector2(23.39543f, -44.5f)
, 
new Vector2(22.39543f, -44.5f)
, 
new Vector2(21.39543f, -44.5f)
, 
new Vector2(20.39543f, -44.5f)
, 
new Vector2(19.39543f, -44.5f)
, 
new Vector2(18.39543f, -44.5f)
}
, 
new Vector2[]{
new Vector2(17.39543f, -34.5f)
, 
new Vector2(16.39543f, -34.5f)
, 
new Vector2(15.39543f, -34.5f)
, 
new Vector2(14.39543f, -34.5f)
, 
new Vector2(13.39543f, -34.5f)
, 
new Vector2(12.39543f, -34.5f)
, 
new Vector2(11.39543f, -34.5f)
, 
new Vector2(10.39543f, -34.5f)
, 
new Vector2(9.395426f, -34.5f)
, 
new Vector2(8.395426f, -34.5f)
}
, 
new Vector2[]{
new Vector2(17.39543f, -44.5f)
, 
new Vector2(16.39543f, -44.5f)
, 
new Vector2(15.39543f, -44.5f)
, 
new Vector2(14.39543f, -44.5f)
, 
new Vector2(13.39543f, -44.5f)
, 
new Vector2(12.39543f, -44.5f)
, 
new Vector2(11.39543f, -44.5f)
, 
new Vector2(10.39543f, -44.5f)
, 
new Vector2(9.395426f, -44.5f)
, 
new Vector2(8.395426f, -44.5f)
}
, 
new Vector2[]{
new Vector2(7.395426f, -44.5f)
, 
new Vector2(6.395426f, -44.5f)
, 
new Vector2(5.395426f, -44.5f)
, 
new Vector2(4.395426f, -44.5f)
, 
new Vector2(3.395426f, -44.5f)
, 
new Vector2(2.395426f, -44.5f)
, 
new Vector2(1.395426f, -44.5f)
, 
new Vector2(0.3954258f, -44.5f)
, 
new Vector2(-0.6045742f, -44.5f)
, 
new Vector2(-1.604574f, -44.5f)
}
, 
new Vector2[]{
new Vector2(7.395426f, -34.5f)
, 
new Vector2(6.395426f, -34.5f)
, 
new Vector2(5.395426f, -34.5f)
, 
new Vector2(4.395426f, -34.5f)
, 
new Vector2(3.395426f, -34.5f)
, 
new Vector2(2.395426f, -34.5f)
, 
new Vector2(1.395426f, -34.5f)
, 
new Vector2(0.3954258f, -34.5f)
, 
new Vector2(-0.6045742f, -34.5f)
, 
new Vector2(-1.604574f, -34.5f)
}
, 
new Vector2[]{
new Vector2(-2.604574f, -44.5f)
, 
new Vector2(-2.604574f, -45.5f)
, 
new Vector2(-2.604574f, -46.5f)
, 
new Vector2(-2.604574f, -47.5f)
, 
new Vector2(-2.604574f, -48.5f)
, 
new Vector2(-2.604574f, -49.5f)
, 
new Vector2(-2.604574f, -50.5f)
, 
new Vector2(-2.604574f, -51.5f)
, 
new Vector2(-2.604574f, -52.5f)
, 
new Vector2(-2.604574f, -53.5f)
}
, 
new Vector2[]{
new Vector2(-2.604574f, -34.5f)
, 
new Vector2(-3.604574f, -34.5f)
, 
new Vector2(-4.604574f, -34.5f)
, 
new Vector2(-5.604574f, -34.5f)
, 
new Vector2(-6.604574f, -34.5f)
, 
new Vector2(-7.604574f, -34.5f)
, 
new Vector2(-8.604574f, -34.5f)
, 
new Vector2(-9.604574f, -34.5f)
, 
new Vector2(-10.60457f, -34.5f)
, 
new Vector2(-11.60457f, -34.5f)
}
, 
new Vector2[]{
new Vector2(-11.60457f, -35.5f)
, 
new Vector2(-11.60457f, -36.5f)
, 
new Vector2(-11.60457f, -37.5f)
, 
new Vector2(-11.60457f, -38.5f)
, 
new Vector2(-11.60457f, -39.5f)
, 
new Vector2(-11.60457f, -40.5f)
, 
new Vector2(-11.60457f, -41.5f)
, 
new Vector2(-11.60457f, -42.5f)
, 
new Vector2(-11.60457f, -43.5f)
, 
new Vector2(-11.60457f, -44.5f)
}
, 
new Vector2[]{
new Vector2(-11.60457f, -44.5f)
, 
new Vector2(-11.60457f, -45.5f)
, 
new Vector2(-11.60457f, -46.5f)
, 
new Vector2(-11.60457f, -47.5f)
, 
new Vector2(-11.60457f, -48.5f)
, 
new Vector2(-11.60457f, -49.5f)
, 
new Vector2(-11.60457f, -50.5f)
, 
new Vector2(-11.60457f, -51.5f)
, 
new Vector2(-11.60457f, -52.5f)
, 
new Vector2(-11.60457f, -53.5f)
}
, 
new Vector2[]{
new Vector2(-11.60457f, -54.5f)
, 
new Vector2(-10.60457f, -54.5f)
, 
new Vector2(-9.604574f, -54.5f)
, 
new Vector2(-8.604574f, -54.5f)
, 
new Vector2(-7.604574f, -54.5f)
, 
new Vector2(-6.604574f, -54.5f)
, 
new Vector2(-5.604574f, -54.5f)
, 
new Vector2(-4.604574f, -54.5f)
, 
new Vector2(-3.604574f, -54.5f)
, 
new Vector2(-2.604574f, -54.5f)
}
};
public Vector2[][] PermRoom13 = {
new Vector2[]{
new Vector2(27.39543f, -54.5f)
, 
new Vector2(27.39543f, -53.5f)
, 
new Vector2(27.39543f, -52.5f)
, 
new Vector2(27.39543f, -51.5f)
, 
new Vector2(27.39543f, -50.5f)
, 
new Vector2(27.39543f, -49.5f)
, 
new Vector2(27.39543f, -48.5f)
, 
new Vector2(27.39543f, -47.5f)
, 
new Vector2(27.39543f, -46.5f)
, 
new Vector2(27.39543f, -45.5f)
}
, 
new Vector2[]{
new Vector2(39.39542f, -44.5f)
, 
new Vector2(40.39542f, -44.5f)
, 
new Vector2(41.39542f, -44.5f)
, 
new Vector2(42.39542f, -44.5f)
, 
new Vector2(43.39542f, -44.5f)
, 
new Vector2(44.39542f, -44.5f)
, 
new Vector2(45.39542f, -44.5f)
, 
new Vector2(46.39542f, -44.5f)
, 
new Vector2(47.39542f, -44.5f)
, 
new Vector2(48.39542f, -44.5f)
}
, 
new Vector2[]{
new Vector2(28.39543f, -54.5f)
, 
new Vector2(29.39543f, -54.5f)
, 
new Vector2(30.39543f, -54.5f)
, 
new Vector2(31.39543f, -54.5f)
, 
new Vector2(32.39542f, -54.5f)
, 
new Vector2(33.39542f, -54.5f)
, 
new Vector2(34.39542f, -54.5f)
, 
new Vector2(35.39542f, -54.5f)
, 
new Vector2(36.39542f, -54.5f)
, 
new Vector2(37.39542f, -54.5f)
}
, 
new Vector2[]{
new Vector2(49.39542f, -53.5f)
, 
new Vector2(49.39542f, -52.5f)
, 
new Vector2(49.39542f, -51.5f)
, 
new Vector2(49.39542f, -50.5f)
, 
new Vector2(49.39542f, -49.5f)
, 
new Vector2(49.39542f, -48.5f)
, 
new Vector2(49.39542f, -47.5f)
, 
new Vector2(49.39542f, -46.5f)
, 
new Vector2(49.39542f, -45.5f)
, 
new Vector2(49.39542f, -44.5f)
}
, 
new Vector2[]{
new Vector2(38.39542f, -63.5f)
, 
new Vector2(38.39542f, -62.5f)
, 
new Vector2(38.39542f, -61.5f)
, 
new Vector2(38.39542f, -60.5f)
, 
new Vector2(38.39542f, -59.5f)
, 
new Vector2(38.39542f, -58.5f)
, 
new Vector2(38.39542f, -57.5f)
, 
new Vector2(38.39542f, -56.5f)
, 
new Vector2(38.39542f, -55.5f)
, 
new Vector2(38.39542f, -54.5f)
}
, 
new Vector2[]{
new Vector2(50.39542f, -53.5f)
, 
new Vector2(51.39542f, -53.5f)
, 
new Vector2(52.39542f, -53.5f)
, 
new Vector2(53.39542f, -53.5f)
, 
new Vector2(54.39542f, -53.5f)
, 
new Vector2(55.39542f, -53.5f)
, 
new Vector2(56.39542f, -53.5f)
, 
new Vector2(57.39542f, -53.5f)
, 
new Vector2(58.39542f, -53.5f)
, 
new Vector2(59.39542f, -53.5f)
}
, 
new Vector2[]{
new Vector2(39.39542f, -63.5f)
, 
new Vector2(40.39542f, -63.5f)
, 
new Vector2(41.39542f, -63.5f)
, 
new Vector2(42.39542f, -63.5f)
, 
new Vector2(43.39542f, -63.5f)
, 
new Vector2(44.39542f, -63.5f)
, 
new Vector2(45.39542f, -63.5f)
, 
new Vector2(46.39542f, -63.5f)
, 
new Vector2(47.39542f, -63.5f)
, 
new Vector2(48.39542f, -63.5f)
}
, 
new Vector2[]{
new Vector2(60.39542f, -62.5f)
, 
new Vector2(60.39542f, -61.5f)
, 
new Vector2(60.39542f, -60.5f)
, 
new Vector2(60.39542f, -59.5f)
, 
new Vector2(60.39542f, -58.5f)
, 
new Vector2(60.39542f, -57.5f)
, 
new Vector2(60.39542f, -56.5f)
, 
new Vector2(60.39542f, -55.5f)
, 
new Vector2(60.39542f, -54.5f)
, 
new Vector2(60.39542f, -53.5f)
}
, 
new Vector2[]{
new Vector2(49.39542f, -72.5f)
, 
new Vector2(49.39542f, -71.5f)
, 
new Vector2(49.39542f, -70.5f)
, 
new Vector2(49.39542f, -69.5f)
, 
new Vector2(49.39542f, -68.5f)
, 
new Vector2(49.39542f, -67.5f)
, 
new Vector2(49.39542f, -66.5f)
, 
new Vector2(49.39542f, -65.5f)
, 
new Vector2(49.39542f, -64.5f)
, 
new Vector2(49.39542f, -63.5f)
}
, 
new Vector2[]{
new Vector2(50.39542f, -72.5f)
, 
new Vector2(51.39542f, -72.5f)
, 
new Vector2(52.39542f, -72.5f)
, 
new Vector2(53.39542f, -72.5f)
, 
new Vector2(54.39542f, -72.5f)
, 
new Vector2(55.39542f, -72.5f)
, 
new Vector2(56.39542f, -72.5f)
, 
new Vector2(57.39542f, -72.5f)
, 
new Vector2(58.39542f, -72.5f)
, 
new Vector2(59.39542f, -72.5f)
}
, 
new Vector2[]{
new Vector2(60.39542f, -63.5f)
, 
new Vector2(61.39542f, -63.5f)
, 
new Vector2(62.39542f, -63.5f)
, 
new Vector2(63.39542f, -63.5f)
, 
new Vector2(64.39542f, -63.5f)
, 
new Vector2(65.39542f, -63.5f)
, 
new Vector2(66.39542f, -63.5f)
, 
new Vector2(67.39542f, -63.5f)
, 
new Vector2(68.39542f, -63.5f)
, 
new Vector2(69.39542f, -63.5f)
}
, 
new Vector2[]{
new Vector2(60.39542f, -72.5f)
, 
new Vector2(61.39542f, -72.5f)
, 
new Vector2(62.39542f, -72.5f)
, 
new Vector2(63.39542f, -72.5f)
, 
new Vector2(64.39542f, -72.5f)
, 
new Vector2(65.39542f, -72.5f)
, 
new Vector2(66.39542f, -72.5f)
, 
new Vector2(67.39542f, -72.5f)
, 
new Vector2(68.39542f, -72.5f)
, 
new Vector2(69.39542f, -72.5f)
}
, 
new Vector2[]{
new Vector2(70.39542f, -63.5f)
, 
new Vector2(71.39542f, -63.5f)
, 
new Vector2(72.39542f, -63.5f)
, 
new Vector2(73.39542f, -63.5f)
, 
new Vector2(74.39542f, -63.5f)
, 
new Vector2(75.39542f, -63.5f)
, 
new Vector2(76.39542f, -63.5f)
, 
new Vector2(77.39542f, -63.5f)
, 
new Vector2(78.39542f, -63.5f)
, 
new Vector2(79.39542f, -63.5f)
}
, 
new Vector2[]{
new Vector2(70.39542f, -72.5f)
, 
new Vector2(71.39542f, -72.5f)
, 
new Vector2(72.39542f, -72.5f)
, 
new Vector2(73.39542f, -72.5f)
, 
new Vector2(74.39542f, -72.5f)
, 
new Vector2(75.39542f, -72.5f)
, 
new Vector2(76.39542f, -72.5f)
, 
new Vector2(77.39542f, -72.5f)
, 
new Vector2(78.39542f, -72.5f)
, 
new Vector2(79.39542f, -72.5f)
}
, 
new Vector2[]{
new Vector2(80.39542f, -63.5f)
, 
new Vector2(80.39542f, -64.5f)
, 
new Vector2(80.39542f, -65.5f)
, 
new Vector2(80.39542f, -66.5f)
, 
new Vector2(80.39542f, -67.5f)
, 
new Vector2(80.39542f, -68.5f)
, 
new Vector2(80.39542f, -69.5f)
, 
new Vector2(80.39542f, -70.5f)
, 
new Vector2(80.39542f, -71.5f)
, 
new Vector2(80.39542f, -72.5f)
}
};

public Vector2[][] PermRoom14 = {
new Vector2[]{
new Vector2(28.39543f, 14.5f)
, 
new Vector2(28.39543f, 15.5f)
, 
new Vector2(28.39543f, 16.5f)
, 
new Vector2(28.39543f, 17.5f)
, 
new Vector2(28.39543f, 18.5f)
, 
new Vector2(28.39543f, 19.5f)
, 
new Vector2(28.39543f, 20.5f)
, 
new Vector2(28.39543f, 21.5f)
, 
new Vector2(28.39543f, 22.5f)
, 
new Vector2(28.39543f, 23.5f)
}
, 
new Vector2[]{
new Vector2(38.39542f, 14.5f)
, 
new Vector2(38.39542f, 15.5f)
, 
new Vector2(38.39542f, 16.5f)
, 
new Vector2(38.39542f, 17.5f)
, 
new Vector2(38.39542f, 18.5f)
, 
new Vector2(38.39542f, 19.5f)
, 
new Vector2(38.39542f, 20.5f)
, 
new Vector2(38.39542f, 21.5f)
, 
new Vector2(38.39542f, 22.5f)
, 
new Vector2(38.39542f, 23.5f)
}
, 
new Vector2[]{
new Vector2(28.39543f, 24.5f)
, 
new Vector2(28.39543f, 25.5f)
, 
new Vector2(28.39543f, 26.5f)
, 
new Vector2(28.39543f, 27.5f)
, 
new Vector2(28.39543f, 28.5f)
, 
new Vector2(28.39543f, 29.5f)
, 
new Vector2(28.39543f, 30.5f)
, 
new Vector2(28.39543f, 31.5f)
, 
new Vector2(28.39543f, 32.5f)
, 
new Vector2(28.39543f, 33.5f)
}
, 
new Vector2[]{
new Vector2(38.39542f, 24.5f)
, 
new Vector2(38.39542f, 25.5f)
, 
new Vector2(38.39542f, 26.5f)
, 
new Vector2(38.39542f, 27.5f)
, 
new Vector2(38.39542f, 28.5f)
, 
new Vector2(38.39542f, 29.5f)
, 
new Vector2(38.39542f, 30.5f)
, 
new Vector2(38.39542f, 31.5f)
, 
new Vector2(38.39542f, 32.5f)
, 
new Vector2(38.39542f, 33.5f)
}
, 
new Vector2[]{
new Vector2(28.39543f, 34.5f)
, 
new Vector2(28.39543f, 35.5f)
, 
new Vector2(28.39543f, 36.5f)
, 
new Vector2(28.39543f, 37.5f)
, 
new Vector2(28.39543f, 38.5f)
, 
new Vector2(28.39543f, 39.5f)
, 
new Vector2(28.39543f, 40.5f)
, 
new Vector2(28.39543f, 41.5f)
, 
new Vector2(28.39543f, 42.5f)
, 
new Vector2(28.39543f, 43.5f)
}
, 
new Vector2[]{
new Vector2(38.39542f, 34.5f)
, 
new Vector2(38.39542f, 35.5f)
, 
new Vector2(38.39542f, 36.5f)
, 
new Vector2(38.39542f, 37.5f)
, 
new Vector2(38.39542f, 38.5f)
, 
new Vector2(38.39542f, 39.5f)
, 
new Vector2(38.39542f, 40.5f)
, 
new Vector2(38.39542f, 41.5f)
, 
new Vector2(38.39542f, 42.5f)
, 
new Vector2(38.39542f, 43.5f)
}
};

public Vector2[][] PermRoom15 = {
new Vector2[]{
new Vector2(39.39542f, 43.5f)
, 
new Vector2(40.39542f, 43.5f)
, 
new Vector2(41.39542f, 43.5f)
, 
new Vector2(42.39542f, 43.5f)
, 
new Vector2(43.39542f, 43.5f)
, 
new Vector2(44.39542f, 43.5f)
, 
new Vector2(45.39542f, 43.5f)
, 
new Vector2(46.39542f, 43.5f)
, 
new Vector2(47.39542f, 43.5f)
, 
new Vector2(48.39542f, 43.5f)
}
, 
new Vector2[]{
new Vector2(39.39542f, 53.5f)
, 
new Vector2(40.39542f, 53.5f)
, 
new Vector2(41.39542f, 53.5f)
, 
new Vector2(42.39542f, 53.5f)
, 
new Vector2(43.39542f, 53.5f)
, 
new Vector2(44.39542f, 53.5f)
, 
new Vector2(45.39542f, 53.5f)
, 
new Vector2(46.39542f, 53.5f)
, 
new Vector2(47.39542f, 53.5f)
, 
new Vector2(48.39542f, 53.5f)
}
, 
new Vector2[]{
new Vector2(49.39542f, 43.5f)
, 
new Vector2(50.39542f, 43.5f)
, 
new Vector2(51.39542f, 43.5f)
, 
new Vector2(52.39542f, 43.5f)
, 
new Vector2(53.39542f, 43.5f)
, 
new Vector2(54.39542f, 43.5f)
, 
new Vector2(55.39542f, 43.5f)
, 
new Vector2(56.39542f, 43.5f)
, 
new Vector2(57.39542f, 43.5f)
, 
new Vector2(58.39542f, 43.5f)
}
, 
new Vector2[]{
new Vector2(49.39542f, 53.5f)
, 
new Vector2(50.39542f, 53.5f)
, 
new Vector2(51.39542f, 53.5f)
, 
new Vector2(52.39542f, 53.5f)
, 
new Vector2(53.39542f, 53.5f)
, 
new Vector2(54.39542f, 53.5f)
, 
new Vector2(55.39542f, 53.5f)
, 
new Vector2(56.39542f, 53.5f)
, 
new Vector2(57.39542f, 53.5f)
, 
new Vector2(58.39542f, 53.5f)
}
, 
new Vector2[]{
new Vector2(59.39542f, 43.5f)
, 
new Vector2(60.39542f, 43.5f)
, 
new Vector2(61.39542f, 43.5f)
, 
new Vector2(62.39542f, 43.5f)
, 
new Vector2(63.39542f, 43.5f)
, 
new Vector2(64.39542f, 43.5f)
, 
new Vector2(65.39542f, 43.5f)
, 
new Vector2(66.39542f, 43.5f)
, 
new Vector2(67.39542f, 43.5f)
, 
new Vector2(68.39542f, 43.5f)
}
, 
new Vector2[]{
new Vector2(59.39542f, 53.5f)
, 
new Vector2(60.39542f, 53.5f)
, 
new Vector2(61.39542f, 53.5f)
, 
new Vector2(62.39542f, 53.5f)
, 
new Vector2(63.39542f, 53.5f)
, 
new Vector2(64.39542f, 53.5f)
, 
new Vector2(65.39542f, 53.5f)
, 
new Vector2(66.39542f, 53.5f)
, 
new Vector2(67.39542f, 53.5f)
, 
new Vector2(68.39542f, 53.5f)
}
, 
new Vector2[]{
new Vector2(69.39542f, 43.5f)
, 
new Vector2(69.39542f, 44.5f)
, 
new Vector2(69.39542f, 45.5f)
, 
new Vector2(69.39542f, 46.5f)
, 
new Vector2(69.39542f, 47.5f)
, 
new Vector2(69.39542f, 48.5f)
, 
new Vector2(69.39542f, 49.5f)
, 
new Vector2(69.39542f, 50.5f)
, 
new Vector2(69.39542f, 51.5f)
, 
new Vector2(69.39542f, 52.5f)
, 
new Vector2(69.39542f, 53.5f)
}
};

public Vector2[][] PermRoom16 = {
new Vector2[]{
new Vector2(27.39543f, 43.5f)
, 
new Vector2(26.39543f, 43.5f)
, 
new Vector2(25.39543f, 43.5f)
, 
new Vector2(24.39543f, 43.5f)
, 
new Vector2(23.39543f, 43.5f)
, 
new Vector2(22.39543f, 43.5f)
, 
new Vector2(21.39543f, 43.5f)
, 
new Vector2(20.39543f, 43.5f)
, 
new Vector2(19.39543f, 43.5f)
, 
new Vector2(18.39543f, 43.5f)
}
, 
new Vector2[]{
new Vector2(28.39543f, 53.5f)
, 
new Vector2(27.39543f, 53.5f)
, 
new Vector2(26.39543f, 53.5f)
, 
new Vector2(25.39543f, 53.5f)
, 
new Vector2(24.39543f, 53.5f)
, 
new Vector2(23.39543f, 53.5f)
, 
new Vector2(22.39543f, 53.5f)
, 
new Vector2(21.39543f, 53.5f)
, 
new Vector2(20.39543f, 53.5f)
, 
new Vector2(19.39543f, 53.5f)
, 
new Vector2(18.39543f, 53.5f)
}
, 
new Vector2[]{
new Vector2(17.39543f, 43.5f)
, 
new Vector2(16.39543f, 43.5f)
, 
new Vector2(15.39543f, 43.5f)
, 
new Vector2(14.39543f, 43.5f)
, 
new Vector2(13.39543f, 43.5f)
, 
new Vector2(12.39543f, 43.5f)
, 
new Vector2(11.39543f, 43.5f)
, 
new Vector2(10.39543f, 43.5f)
, 
new Vector2(9.395426f, 43.5f)
, 
new Vector2(8.395426f, 43.5f)
}
, 
new Vector2[]{
new Vector2(17.39543f, 53.5f)
, 
new Vector2(16.39543f, 53.5f)
, 
new Vector2(15.39543f, 53.5f)
, 
new Vector2(14.39543f, 53.5f)
, 
new Vector2(13.39543f, 53.5f)
, 
new Vector2(12.39543f, 53.5f)
, 
new Vector2(11.39543f, 53.5f)
, 
new Vector2(10.39543f, 53.5f)
, 
new Vector2(9.395426f, 53.5f)
, 
new Vector2(8.395426f, 53.5f)
}
, 
new Vector2[]{
new Vector2(7.395426f, 53.5f)
, 
new Vector2(6.395426f, 53.5f)
, 
new Vector2(5.395426f, 53.5f)
, 
new Vector2(4.395426f, 53.5f)
, 
new Vector2(3.395426f, 53.5f)
, 
new Vector2(2.395426f, 53.5f)
, 
new Vector2(1.395426f, 53.5f)
, 
new Vector2(0.3954258f, 53.5f)
, 
new Vector2(-0.6045742f, 53.5f)
, 
new Vector2(-1.604574f, 53.5f)
}
, 
new Vector2[]{
new Vector2(-2.604574f, 53.5f)
, 
new Vector2(-2.604574f, 52.5f)
, 
new Vector2(-2.604574f, 51.5f)
, 
new Vector2(-2.604574f, 50.5f)
, 
new Vector2(-2.604574f, 49.5f)
, 
new Vector2(-2.604574f, 48.5f)
, 
new Vector2(-2.604574f, 47.5f)
, 
new Vector2(-2.604574f, 46.5f)
, 
new Vector2(-2.604574f, 45.5f)
, 
new Vector2(-2.604574f, 44.5f)
, 
new Vector2(-2.604574f, 43.5f)
}
};

public Vector2[][] PermRoom17 = {
new Vector2[]{
new Vector2(8.395426f, 33.5f)
, 
new Vector2(8.395426f, 34.5f)
, 
new Vector2(8.395426f, 35.5f)
, 
new Vector2(8.395426f, 36.5f)
, 
new Vector2(8.395426f, 37.5f)
, 
new Vector2(8.395426f, 38.5f)
, 
new Vector2(8.395426f, 39.5f)
, 
new Vector2(8.395426f, 40.5f)
, 
new Vector2(8.395426f, 41.5f)
, 
new Vector2(8.395426f, 42.5f)
}
, 
new Vector2[]{
new Vector2(-2.604574f, 33.5f)
, 
new Vector2(-2.604574f, 34.5f)
, 
new Vector2(-2.604574f, 35.5f)
, 
new Vector2(-2.604574f, 36.5f)
, 
new Vector2(-2.604574f, 37.5f)
, 
new Vector2(-2.604574f, 38.5f)
, 
new Vector2(-2.604574f, 39.5f)
, 
new Vector2(-2.604574f, 40.5f)
, 
new Vector2(-2.604574f, 41.5f)
, 
new Vector2(-2.604574f, 42.5f)
}
, 
new Vector2[]{
new Vector2(-2.604574f, 23.5f)
, 
new Vector2(-2.604574f, 24.5f)
, 
new Vector2(-2.604574f, 25.5f)
, 
new Vector2(-2.604574f, 26.5f)
, 
new Vector2(-2.604574f, 27.5f)
, 
new Vector2(-2.604574f, 28.5f)
, 
new Vector2(-2.604574f, 29.5f)
, 
new Vector2(-2.604574f, 30.5f)
, 
new Vector2(-2.604574f, 31.5f)
, 
new Vector2(-2.604574f, 32.5f)
}
, 
new Vector2[]{
new Vector2(8.395426f, 23.5f)
, 
new Vector2(8.395426f, 24.5f)
, 
new Vector2(8.395426f, 25.5f)
, 
new Vector2(8.395426f, 26.5f)
, 
new Vector2(8.395426f, 27.5f)
, 
new Vector2(8.395426f, 28.5f)
, 
new Vector2(8.395426f, 29.5f)
, 
new Vector2(8.395426f, 30.5f)
, 
new Vector2(8.395426f, 31.5f)
, 
new Vector2(8.395426f, 32.5f)
}
, 
new Vector2[]{
new Vector2(-2.604574f, 13.5f)
, 
new Vector2(-2.604574f, 14.5f)
, 
new Vector2(-2.604574f, 15.5f)
, 
new Vector2(-2.604574f, 16.5f)
, 
new Vector2(-2.604574f, 17.5f)
, 
new Vector2(-2.604574f, 18.5f)
, 
new Vector2(-2.604574f, 19.5f)
, 
new Vector2(-2.604574f, 20.5f)
, 
new Vector2(-2.604574f, 21.5f)
, 
new Vector2(-2.604574f, 22.5f)
}
, 
new Vector2[]{
new Vector2(8.395426f, 13.5f)
, 
new Vector2(8.395426f, 14.5f)
, 
new Vector2(8.395426f, 15.5f)
, 
new Vector2(8.395426f, 16.5f)
, 
new Vector2(8.395426f, 17.5f)
, 
new Vector2(8.395426f, 18.5f)
, 
new Vector2(8.395426f, 19.5f)
, 
new Vector2(8.395426f, 20.5f)
, 
new Vector2(8.395426f, 21.5f)
, 
new Vector2(8.395426f, 22.5f)
}
, 
new Vector2[]{
new Vector2(-1.604574f, 13.5f)
, 
new Vector2(-0.6045742f, 13.5f)
, 
new Vector2(0.3954258f, 13.5f)
, 
new Vector2(1.395426f, 13.5f)
, 
new Vector2(2.395426f, 13.5f)
, 
new Vector2(3.395426f, 13.5f)
, 
new Vector2(4.395426f, 13.5f)
, 
new Vector2(5.395426f, 13.5f)
, 
new Vector2(6.395426f, 13.5f)
, 
new Vector2(7.395426f, 13.5f)
}
};

public Vector2[][] PermRoom18 = {
new Vector2[]{
new Vector2(39.39542f, 54.5f)
, 
new Vector2(39.39542f, 55.5f)
, 
new Vector2(39.39542f, 56.5f)
, 
new Vector2(39.39542f, 57.5f)
, 
new Vector2(39.39542f, 58.5f)
, 
new Vector2(39.39542f, 59.5f)
, 
new Vector2(39.39542f, 60.5f)
, 
new Vector2(39.39542f, 61.5f)
, 
new Vector2(39.39542f, 62.5f)
, 
new Vector2(39.39542f, 63.5f)
}
, 
new Vector2[]{
new Vector2(28.39543f, 54.5f)
, 
new Vector2(28.39543f, 55.5f)
, 
new Vector2(28.39543f, 56.5f)
, 
new Vector2(28.39543f, 57.5f)
, 
new Vector2(28.39543f, 58.5f)
, 
new Vector2(28.39543f, 59.5f)
, 
new Vector2(28.39543f, 60.5f)
, 
new Vector2(28.39543f, 61.5f)
, 
new Vector2(28.39543f, 62.5f)
, 
new Vector2(28.39543f, 63.5f)
}
, 
new Vector2[]{
new Vector2(39.39542f, 64.5f)
, 
new Vector2(39.39542f, 65.5f)
, 
new Vector2(39.39542f, 66.5f)
, 
new Vector2(39.39542f, 67.5f)
, 
new Vector2(39.39542f, 68.5f)
, 
new Vector2(39.39542f, 69.5f)
, 
new Vector2(39.39542f, 70.5f)
, 
new Vector2(39.39542f, 71.5f)
, 
new Vector2(39.39542f, 72.5f)
, 
new Vector2(39.39542f, 73.5f)
}
, 
new Vector2[]{
new Vector2(28.39543f, 64.5f)
, 
new Vector2(28.39543f, 65.5f)
, 
new Vector2(28.39543f, 66.5f)
, 
new Vector2(28.39543f, 67.5f)
, 
new Vector2(28.39543f, 68.5f)
, 
new Vector2(28.39543f, 69.5f)
, 
new Vector2(28.39543f, 70.5f)
, 
new Vector2(28.39543f, 71.5f)
, 
new Vector2(28.39543f, 72.5f)
, 
new Vector2(28.39543f, 73.5f)
}
, 
new Vector2[]{
new Vector2(29.39543f, 73.5f)
, 
new Vector2(30.39543f, 73.5f)
, 
new Vector2(31.39543f, 73.5f)
, 
new Vector2(32.39542f, 73.5f)
, 
new Vector2(33.39542f, 73.5f)
, 
new Vector2(34.39542f, 73.5f)
, 
new Vector2(35.39542f, 73.5f)
, 
new Vector2(36.39542f, 73.5f)
, 
new Vector2(37.39542f, 73.5f)
, 
new Vector2(38.39542f, 73.5f)
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
public Vector2[][] TempRoom7 = {
  new Vector2[]{
new Vector2(77.39542f, -5.5f)
, 
new Vector2(78.39542f, -5.5f)
, 
new Vector2(79.39542f, -5.5f)
, 
new Vector2(80.39542f, -5.5f)
, 
new Vector2(81.39542f, -5.5f)
, 
new Vector2(82.39542f, -5.5f)
, 
new Vector2(83.39542f, -5.5f)
, 
new Vector2(84.39542f, -5.5f)
, 
new Vector2(85.39542f, -5.5f)
, 
new Vector2(86.39542f, -5.5f)
}
};
public Vector2[][] TempRoom11 = {
new Vector2[]{
new Vector2(28.39543f, -44.5f)
, 
new Vector2(29.39543f, -44.5f)
, 
new Vector2(30.39543f, -44.5f)
, 
new Vector2(31.39543f, -44.5f)
, 
new Vector2(32.39542f, -44.5f)
, 
new Vector2(33.39542f, -44.5f)
, 
new Vector2(34.39542f, -44.5f)
, 
new Vector2(35.39542f, -44.5f)
, 
new Vector2(36.39542f, -44.5f)
, 
new Vector2(37.39542f, -44.5f)
}
};
public Vector2[][] TempRoom16 = {
new Vector2[]{
new Vector2(7.395426f, 43.5f)
, 
new Vector2(6.395426f, 43.5f)
, 
new Vector2(5.395426f, 43.5f)
, 
new Vector2(4.395426f, 43.5f)
, 
new Vector2(3.395426f, 43.5f)
, 
new Vector2(2.395426f, 43.5f)
, 
new Vector2(1.395426f, 43.5f)
, 
new Vector2(0.3954258f, 43.5f)
, 
new Vector2(-0.6045742f, 43.5f)
, 
new Vector2(-1.604574f, 43.5f)
}
};

public Vector2[][] TempRoom18 = {
new Vector2[]{
new Vector2(38.39542f, 53.5f)
, 
new Vector2(37.39542f, 53.5f)
, 
new Vector2(36.39542f, 53.5f)
, 
new Vector2(35.39542f, 53.5f)
, 
new Vector2(34.39542f, 53.5f)
, 
new Vector2(33.39542f, 53.5f)
, 
new Vector2(32.39542f, 53.5f)
, 
new Vector2(31.39542f, 53.5f)
, 
new Vector2(30.39542f, 53.5f)
, 
new Vector2(29.39542f, 53.5f)
}
};




public Vector2[][][] getPermanent()
{
  Vector2[][][] rooms = 
  {
    PermRoom1, PermRoom2, PermRoom3, PermRoom4, PermRoom5, 
    PermRoom6, PermRoom7, PermRoom8, PermRoom9, PermRoom10,
    PermRoom11, PermRoom12, PermRoom13, PermRoom14, PermRoom15,
    PermRoom16, PermRoom17, PermRoom18
  };
  return rooms;
}

public Vector2[][][] getTemporary()
{
  Vector2[][][] doors = 
  {
    TempRoom1, TempRoom3,
    TempRoom7, 
    TempRoom11, 
    TempRoom16, TempRoom18
  };
  return doors;
}

}
