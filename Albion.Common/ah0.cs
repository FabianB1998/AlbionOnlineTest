// Decompiled with JetBrains decompiler
// Type: ah0
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public sealed class ah0
{
  private string a;
  private string b;

  public ah0(string A_0, string A_1)
    : this(A_0.Split(new char[2]{ ':', '\n' }), A_1.Split(new char[2]
    {
      ':',
      '\n'
    }))
  {
  }

  public ah0(string[] A_0, string[] A_1)
  {
    this.a = ah0.a(A_0);
    this.b = ah0.a(A_1);
  }

  public bool b(string A_0)
  {
    bool success = Regex.Match(A_0, this.a, RegexOptions.IgnoreCase).Success;
    bool flag = this.b.Length > 0 && Regex.Match(A_0, this.b, RegexOptions.IgnoreCase).Success;
    if (success)
      return !flag;
    return false;
  }

  private static string a(string[] A_0)
  {
    List<string> stringList = new List<string>();
    for (int index = 0; index < A_0.Length; ++index)
    {
      if (!string.IsNullOrEmpty(A_0[index]))
        stringList.Add(ah0.a(A_0[index]));
    }
    if (stringList.Count == 0)
      return string.Empty;
    return 40.ToString() + string.Join(")|(", stringList.ToArray()) + (object) ')';
  }

  public static string a(string A_0)
  {
    StringBuilder stringBuilder = new StringBuilder();
    char[] charArray = A_0.ToCharArray();
    for (int index = 0; index < charArray.Length; ++index)
    {
      char ch = charArray[index];
      switch (ch)
      {
        case '[':
        case '\\':
        case ']':
        case '^':
        case '{':
        case '|':
        case '}':
        case '$':
        case '(':
        case ')':
        case '+':
        case '-':
        case '.':
          stringBuilder.Append("\\").Append(ch);
          break;
        case '*':
          if (index + 1 < charArray.Length && (int) charArray[index] == 42)
          {
            stringBuilder.Append(".*");
            ++index;
            break;
          }
          stringBuilder.Append("[^[\\/|\\\\]]*");
          break;
        case '/':
          stringBuilder.Append("\\/|\\\\");
          break;
        case '?':
          stringBuilder.Append('.');
          break;
        default:
          stringBuilder.Append(ch);
          break;
      }
    }
    return stringBuilder.ToString();
  }
}
