// Decompiled with JetBrains decompiler
// Type: bb
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;

public class bb
{
  private static char[] c = new char[1]{ ';' };
  private static string[] d = new string[2]{ "\r\n", "\n" };
  private string[][] a;
  private int[] b;

  [SpecialName]
  public int d()
  {
    if (this.a == null)
      return 0;
    return this.a.Length;
  }

  public string c(int A_0, bb.DataType A_1)
  {
    int index1 = (int) A_1;
    if (this.a == null || this.a.Length <= A_0 || (this.b == null || this.b.Length <= index1))
      return string.Empty;
    string[] strArray = this.a[A_0];
    if (strArray == null || strArray.Length == 0)
      return string.Empty;
    int index2 = this.b[index1];
    if (index2 < 0 || index2 >= strArray.Length || strArray[index2] == null)
      return string.Empty;
    return strArray[index2];
  }

  public bool d(int A_0, bb.DataType A_1)
  {
    return !string.IsNullOrEmpty(this.c(A_0, A_1));
  }

  public string[] e(int A_0, bb.DataType A_1)
  {
    string str = this.c(A_0, A_1);
    if (string.IsNullOrEmpty(str))
      return (string[]) null;
    return str.Split('|');
  }

  public kx f(int A_0, bb.DataType A_1)
  {
    string s = this.c(A_0, A_1);
    long result = 0;
    long.TryParse(s, out result);
    return kx.g(result);
  }

  public float g(int A_0, bb.DataType A_1)
  {
    string s = this.c(A_0, A_1);
    float result = 0.0f;
    float.TryParse(s, NumberStyles.Float, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, out result);
    return result;
  }

  public int h(int A_0, bb.DataType A_1)
  {
    string s = this.c(A_0, A_1);
    int result = 0;
    int.TryParse(s, out result);
    return result;
  }

  public void c(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.c(aim.a(A_0, "name", string.Empty));
    string str1 = aim.a(A_0, "structure", string.Empty);
    if (string.IsNullOrEmpty(str1))
      return;
    this.b = new int[9];
    for (int index = 0; index < this.b.Length; ++index)
      this.b[index] = -1;
    string[] strArray1 = str1.Split(bb.c, StringSplitOptions.RemoveEmptyEntries);
    for (int index = 0; index < strArray1.Length; ++index)
    {
      string str2 = strArray1[index];
      bb.DataType dataType = bb.DataType.Invalid;
      try
      {
        dataType = (bb.DataType) Enum.Parse(typeof (bb.DataType), str2, true);
      }
      catch
      {
      }
      if (dataType == bb.DataType.Invalid)
      {
        this.b = (int[]) null;
        return;
      }
      this.b[(int) dataType] = index;
    }
    string[] strArray2 = A_0.InnerText.Split(bb.d, StringSplitOptions.RemoveEmptyEntries);
    if (strArray2 == null || strArray2.Length == 0)
      return;
    List<string> stringList = new List<string>(strArray2.Length);
    for (int index = 0; index < strArray2.Length; ++index)
    {
      string str2 = strArray2[index].Trim();
      if (!string.IsNullOrEmpty(str2))
        stringList.Add(str2);
    }
    this.a = new string[stringList.Count][];
    for (int index = 0; index < stringList.Count; ++index)
      this.a[index] = stringList[index].Split(';');
  }

  public bool c(g8 A_0, List<string> A_1)
  {
    return true;
  }

  public enum DataType
  {
    Fame = 0,
    Lp = 1,
    LpThreshold = 2,
    MissionTargetMinTier = 3,
    MissionTargetMaxTier = 4,
    MissionItemMinTier = 5,
    MissionItemMaxTier = 6,
    UnlockTier = 7,
    UnlockSpells = 8,
    Invalid = 9,
    Num = 9,
  }
}
