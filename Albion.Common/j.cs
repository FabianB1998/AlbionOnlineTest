// Decompiled with JetBrains decompiler
// Type: j
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.IO;

public class j : IDisposable
{
  private List<string> c = new List<string>();
  private int d = int.MaxValue;
  private int e = int.MinValue;
  private int f = -1;
  private Dictionary<int, Dictionary<string, string>> h = new Dictionary<int, Dictionary<string, string>>();
  private string i = "log.csv";
  private const char a = ';';
  private static j b;
  private StreamWriter g;

  public j()
  {
    this.g = new StreamWriter(this.i);
  }

  public void Dispose()
  {
    this.g.Dispose();
  }

  public static j a()
  {
    if (j.b == null)
      j.b = new j();
    return j.b;
  }

  public void a(int A_0, string A_1, string A_2)
  {
    this.d = Math.Min(this.d, A_0);
    this.e = Math.Max(this.e, A_0);
    if (!this.c.Contains(A_1))
    {
      this.c.Add(A_1);
      this.g.Close();
      this.g = new StreamWriter(this.i);
      this.f = -1;
    }
    Dictionary<string, string> dictionary;
    if (!this.h.TryGetValue(A_0, out dictionary))
    {
      dictionary = new Dictionary<string, string>();
      this.h.Add(A_0, dictionary);
    }
    if (!dictionary.ContainsKey(A_1))
      dictionary.Add(A_1, A_2);
    this.b();
  }

  public void b()
  {
    if (this.f < 0)
    {
      this.g.Write("Frame");
      this.g.Write(';');
      foreach (string str in this.c)
      {
        this.g.Write(str);
        this.g.Write(';');
      }
      this.g.WriteLine();
      this.f = this.d - 1;
      this.g.Flush();
    }
    while (this.f < this.e - 1)
    {
      ++this.f;
      Dictionary<string, string> dictionary;
      if (this.h.TryGetValue(this.f, out dictionary))
      {
        this.g.Write(this.f);
        this.g.Write(';');
        foreach (string key in this.c)
        {
          string str = "";
          dictionary.TryGetValue(key, out str);
          this.g.Write(str);
          this.g.Write(';');
        }
        this.g.WriteLine();
        this.g.Flush();
      }
    }
  }
}
