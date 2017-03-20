// Decompiled with JetBrains decompiler
// Type: j1
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class j1
{
  private Dictionary<string, int[]> a = new Dictionary<string, int[]>();

  public int c(string A_0, int A_1)
  {
    --A_1;
    int[] numArray;
    if (!this.a.TryGetValue(A_0, out numArray) || A_1 < 0 || A_1 >= numArray.Length)
      return 0;
    return numArray[A_1];
  }

  public void c(string A_0, int A_1, int A_2)
  {
    --A_1;
    int[] numArray1;
    if (!this.a.TryGetValue(A_0, out numArray1))
    {
      numArray1 = new int[A_1 + 1];
      this.a[A_0] = numArray1;
    }
    if (A_1 >= numArray1.Length)
    {
      int[] numArray2 = new int[A_1 + 1];
      Array.Copy((Array) numArray1, (Array) numArray2, numArray1.Length);
      this.a[A_0] = numArray1 = numArray2;
    }
    numArray1[A_1] = A_2;
  }

  public int d()
  {
    int num = 0;
    foreach (int[] numArray in this.a.Values)
    {
      for (int index = numArray.Length - 1; index > 0; --index)
      {
        if (numArray[index] > 0)
        {
          if (index + 1 > num)
          {
            num = index + 1;
            break;
          }
          break;
        }
      }
    }
    return num;
  }

  public int c(string A_0)
  {
    int[] numArray;
    if (!this.a.TryGetValue(A_0, out numArray))
      return 0;
    for (int index = numArray.Length - 1; index > 0; --index)
    {
      if (numArray[index] > 0)
        return index + 1;
    }
    return 0;
  }

  public int d(string A_0)
  {
    return this.d(A_0, 1);
  }

  public int d(string A_0, int A_1)
  {
    int[] numArray;
    if (!this.a.TryGetValue(A_0, out numArray))
      return 0;
    for (int index = A_1 - 1; index < numArray.Length; ++index)
    {
      if (numArray[index] > 0)
        return index + 1;
    }
    return 0;
  }

  public int e(string A_0)
  {
    return this.e(A_0, 1);
  }

  public int e(string A_0, int A_1)
  {
    return this.d(A_0, A_1, this.d());
  }

  public int d(string A_0, int A_1, int A_2)
  {
    --A_1;
    --A_2;
    int[] numArray;
    if (!this.a.TryGetValue(A_0, out numArray))
      return 0;
    if (A_1 < 0)
      A_1 = 0;
    if (A_2 >= numArray.Length)
      A_2 = numArray.Length - 1;
    int num = 0;
    for (int index = A_1; index <= A_2; ++index)
      num += numArray[index];
    return num;
  }

  [SpecialName]
  public Dictionary<string, int[]>.KeyCollection e()
  {
    return this.a.Keys;
  }
}
