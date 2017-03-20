// Decompiled with JetBrains decompiler
// Type: Albion.Common.Time.GameTimeStamp
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Albion.Common.Time
{
  [Serializable]
  public struct GameTimeStamp : IComparable, IComparable<GameTimeStamp>, IEquatable<GameTimeStamp>, ISerializable
  {
    public static readonly GameTimeStamp MaxValue = new GameTimeStamp(long.MaxValue);
    public static readonly GameTimeStamp MinValue = new GameTimeStamp(long.MinValue);
    public static readonly GameTimeStamp Zero = new GameTimeStamp(0L);
    public readonly long Ticks;
    [ThreadStatic]
    private static GameTimeStamp.a pTimeSource;

    public static GameTimeStamp.a TimeSource
    {
      get
      {
        return GameTimeStamp.pTimeSource;
      }
      set
      {
        GameTimeStamp.pTimeSource = value;
      }
    }

    public static GameTimeStamp Now
    {
      get
      {
        if (GameTimeStamp.TimeSource == null)
          return GameTimeStamp.f();
        return GameTimeStamp.TimeSource();
      }
    }

    public static GameTimeStamp Today
    {
      get
      {
        GameTimeStamp now = GameTimeStamp.Now;
        return GameTimeStamp.a(now, now.j());
      }
    }

    public static ahy Time
    {
      get
      {
        return GameTimeStamp.Now.j();
      }
    }

    public static GameTimeStamp NextFullHour
    {
      get
      {
        return GameTimeStamp.b(GameTimeStamp.Now);
      }
    }

    public static GameTimeStamp NextDayStart
    {
      get
      {
        return GameTimeStamp.a(GameTimeStamp.Now);
      }
    }

    static GameTimeStamp()
    {
      GameTimeStamp.TimeSource = new GameTimeStamp.a(GameTimeStamp.f);
    }

    public GameTimeStamp(long A_0)
    {
      this = new GameTimeStamp();
      this.Ticks = A_0;
    }

    public GameTimeStamp(string A_0)
    {
      this = new GameTimeStamp();
      long result;
      if (!long.TryParse(A_0, NumberStyles.Integer, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, out result))
        return;
      this.Ticks = result;
    }

    private GameTimeStamp(SerializationInfo A_0, StreamingContext A_1)
    {
      if (A_0 == null)
        throw new ArgumentNullException("info");
      bool flag = false;
      long num = 0;
      SerializationInfoEnumerator enumerator = A_0.GetEnumerator();
      while (enumerator.MoveNext())
      {
        if (enumerator.Name == "Ticks")
        {
          num = Convert.ToInt64(enumerator.Value, (IFormatProvider) CultureInfo.InvariantCulture);
          flag = true;
          break;
        }
      }
      if (!flag)
        throw new SerializationException("Serialization: Missing GameTimeStamp Data");
      this.Ticks = num;
    }

    public static GameTimeStamp f()
    {
      return new GameTimeStamp(DateTime.UtcNow.Ticks);
    }

    public static GameTimeStamp b(GameTimeStamp A_0)
    {
      long num = A_0.Ticks % 36000000000L;
      return new GameTimeStamp(A_0.Ticks - num + 36000000000L);
    }

    public static GameTimeStamp a(GameTimeStamp A_0)
    {
      long num = A_0.Ticks % 864000000000L;
      return new GameTimeStamp(A_0.Ticks - num + 864000000000L);
    }

    [SpecialName]
    public static bool i(GameTimeStamp A_0, GameTimeStamp A_1)
    {
      return A_0.Ticks < A_1.Ticks;
    }

    [SpecialName]
    public static bool h(GameTimeStamp A_0, GameTimeStamp A_1)
    {
      return A_0.Ticks > A_1.Ticks;
    }

    [SpecialName]
    public static bool g(GameTimeStamp A_0, GameTimeStamp A_1)
    {
      return A_0.Ticks == A_1.Ticks;
    }

    [SpecialName]
    public static bool f(GameTimeStamp A_0, GameTimeStamp A_1)
    {
      return A_0.Ticks != A_1.Ticks;
    }

    [SpecialName]
    public static bool e(GameTimeStamp A_0, GameTimeStamp A_1)
    {
      return A_0.Ticks <= A_1.Ticks;
    }

    [SpecialName]
    public static bool d(GameTimeStamp A_0, GameTimeStamp A_1)
    {
      return A_0.Ticks >= A_1.Ticks;
    }

    [SpecialName]
    public static GameTimeStamp b(GameTimeStamp A_0, ahy A_1)
    {
      return new GameTimeStamp(A_0.Ticks + A_1.o);
    }

    [SpecialName]
    public static GameTimeStamp a(GameTimeStamp A_0, ahy A_1)
    {
      return new GameTimeStamp(A_0.Ticks - A_1.o);
    }

    [SpecialName]
    public static ahy c(GameTimeStamp A_0, GameTimeStamp A_1)
    {
      return new ahy(A_0.Ticks - A_1.Ticks);
    }

    public static GameTimeStamp b(GameTimeStamp A_0, GameTimeStamp A_1)
    {
      if (GameTimeStamp.i(A_0, A_1))
        return A_0;
      return A_1;
    }

    public static GameTimeStamp a(GameTimeStamp A_0, GameTimeStamp A_1)
    {
      if (GameTimeStamp.h(A_0, A_1))
        return A_0;
      return A_1;
    }

    public int CompareTo(object obj)
    {
      if (obj == null || !(obj is GameTimeStamp))
        throw new ArgumentException();
      GameTimeStamp gameTimeStamp = (GameTimeStamp) obj;
      if (this.Ticks > gameTimeStamp.Ticks)
        return 1;
      return this.Ticks == gameTimeStamp.Ticks ? 0 : -1;
    }

    public int CompareTo(GameTimeStamp xOther)
    {
      if (this.Ticks > xOther.Ticks)
        return 1;
      return this.Ticks == xOther.Ticks ? 0 : -1;
    }

    public override bool Equals(object value)
    {
      if (value != null && value is GameTimeStamp)
        return ((GameTimeStamp) value).Ticks == this.Ticks;
      throw new ArgumentException();
    }

    public bool Equals(GameTimeStamp other)
    {
      return other.Ticks == this.Ticks;
    }

    public override int GetHashCode()
    {
      return (int) this.Ticks;
    }

    public override string ToString()
    {
      return this.Ticks.ToString();
    }

    public string h()
    {
      return new ahy(this.Ticks).y();
    }

    public DateTime i()
    {
      return new DateTime(Math.Max(this.Ticks, 0L));
    }

    public ahy j()
    {
      return new ahy(this.Ticks % 864000000000L);
    }

    public GameTimeStamp k()
    {
      return new GameTimeStamp(this.Ticks - this.Ticks % 864000000000L);
    }

    public static GameTimeStamp a(DateTime A_0)
    {
      return new GameTimeStamp(A_0.Ticks);
    }

    void ISerializable.a(SerializationInfo A_0, StreamingContext A_1)
    {
      if (A_0 == null)
        throw new ArgumentNullException("info");
      A_0.AddValue("Ticks", this.Ticks);
    }

    public delegate GameTimeStamp a();
  }
}
