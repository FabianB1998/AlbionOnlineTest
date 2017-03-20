// Decompiled with JetBrains decompiler
// Type: m
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.Duelling;
using System;

public class m
{
  public static string a(DuellingMsgEvents A_0, string A_1, kx A_2)
  {
    switch (A_0)
    {
      case DuellingMsgEvents.PlayerReceivedChallenge:
        return kr.a("@DUELLING_INFO_PLAYER_RECEIVED_CHALLENGE", new object[1]{ (object) A_1 });
      case DuellingMsgEvents.PlayerSentChallenge:
        if (A_2.p() > 0L)
          return kr.a("@DUELLING_INFO_PLAYER_SENT_CHALLENGE", new object[2]{ (object) A_1, (object) A_2.j().ToString() });
        return kr.a("@DUELLING_INFO_PLAYER_SENT_CHALLENGE_NOSILVER", new object[1]{ (object) A_1 });
      case DuellingMsgEvents.PlayerHasDuelPending:
        return kr.a("@DUELLING_ERROR_PLAYER_HAS_DUEL_PENDING", new object[1]{ (object) A_1 });
      case DuellingMsgEvents.YouHaveDuelPending:
        return kr.b("@DUELLING_ERROR_YOU_ALREADY_HAVE_DUEL_PENDING");
      case DuellingMsgEvents.PlayerIsAlreadyInDuel:
        return kr.a("@DUELLING_ERROR_PLAYER_IS_ALREADY_DUELLING", new object[1]{ (object) A_1 });
      case DuellingMsgEvents.YouAreAlreadyInDuel:
        return kr.b("@DUELLING_ERROR_YOU_ARE_ALREADY_DUELLING");
      case DuellingMsgEvents.PlayerIsDead:
        return kr.a("@DUELLING_ERROR_PLAYER_IS_DEAD", new object[1]{ (object) A_1 });
      case DuellingMsgEvents.YouAreDead:
        return kr.b("@DUELLING_ERROR_YOU_ARE_DEAD");
      case DuellingMsgEvents.PlayerNotFound:
        return kr.a("@DUELLING_ERROR_PLAYER_NOT_FOUND", new object[1]{ (object) A_1 });
      case DuellingMsgEvents.PlayerOutOfRange:
        return kr.b("@DUELLING_ERROR_PLAYER_OUT_OF_RANGE");
      case DuellingMsgEvents.ChallengeAccepted:
        return kr.b("@DUELLING_INFO_PLAYER_ACCEPTED_CHALLENGE");
      case DuellingMsgEvents.ChallengeDenied:
        if (string.IsNullOrEmpty(A_1))
          return kr.b("@DUELLING_INFO_YOU_DENIED_CHALLENGE");
        if (A_1 == "_unknown_")
          return kr.b("@DUELLING_INFO_UNKNOWN_PLAYER_DENIED_CHALLENGE");
        return kr.a("@DUELLING_INFO_PLAYER_DENIED_CHALLENGE", new object[1]{ (object) A_1 });
      case DuellingMsgEvents.NoActiveDuel:
        return kr.b("@DUELLING_ERROR_NO_ACTIVE_DUEL");
      case DuellingMsgEvents.WaitForDuelIssueingInterval:
        return kr.a("@DUELLING_ERROR_WAIT_ISSUEING_INTERVAL", new object[1]{ (object) 10 });
      case DuellingMsgEvents.NotEnoughSilver:
        return kr.b("@DUELLING_ERROR_NOT_ENOUGH_SILVER");
      case DuellingMsgEvents.PlayerIsBusy:
        return kr.a("@DUELLING_INFO_PLAYER_BUSY", new object[1]{ (object) A_1 });
      default:
        return A_0.ToString();
    }
  }

  public static string c(short A_0, string A_1, kx A_2)
  {
    switch (A_0)
    {
      case 0:
        return m.a(DuellingMsgEvents.PlayerReceivedChallenge, A_1, A_2);
      case 2610:
        return m.a(DuellingMsgEvents.PlayerNotFound, A_1, A_2);
      case 2612:
        return m.a(DuellingMsgEvents.YouHaveDuelPending, A_1, A_2);
      case 2613:
        return m.a(DuellingMsgEvents.YouAreAlreadyInDuel, A_1, A_2);
      case 2614:
        return m.a(DuellingMsgEvents.PlayerIsDead, A_1, A_2);
      case 2615:
        return m.a(DuellingMsgEvents.PlayerOutOfRange, A_1, A_2);
      case 2616:
        return m.a(DuellingMsgEvents.NotEnoughSilver, A_1, A_2);
      case 2617:
        return m.a(DuellingMsgEvents.PlayerHasDuelPending, A_1, A_2);
      case 2618:
        return m.a(DuellingMsgEvents.PlayerIsAlreadyInDuel, A_1, A_2);
      case 2619:
        return m.a(DuellingMsgEvents.PlayerIsBusy, A_1, A_2);
      default:
        return kr.b("@DUELLING_ERROR_CHALLENGE_FAILED");
    }
  }

  public static string b(short A_0, string A_1, kx A_2)
  {
    switch (A_0)
    {
      case 0:
        return m.a(DuellingMsgEvents.ChallengeDenied, A_1, A_2);
      case 2670:
        return m.a(DuellingMsgEvents.NoActiveDuel, A_1, A_2);
      default:
        return kr.b("@DUELLING_ERROR_DENY_CHALLENGE_FAILED");
    }
  }

  public static string a(short A_0, string A_1, kx A_2)
  {
    switch (A_0)
    {
      case 0:
        return m.a(DuellingMsgEvents.ChallengeAccepted, A_1, A_2);
      case 2641:
        return m.a(DuellingMsgEvents.YouAreDead, A_1, A_2);
      case 2642:
        return m.a(DuellingMsgEvents.PlayerIsDead, A_1, A_2);
      case 2643:
        return m.a(DuellingMsgEvents.PlayerOutOfRange, A_1, A_2);
      case 2644:
        return m.a(DuellingMsgEvents.NotEnoughSilver, A_1, A_2);
      case 2645:
        return m.a(DuellingMsgEvents.NoActiveDuel, A_1, A_2);
      default:
        return kr.b("@DUELLING_ERROR_ACCEPT_CHALLENGE_FAILED");
    }
  }

  public static string a(DuelEndEvents A_0, string A_1, string A_2, kx A_3)
  {
    string empty = string.Empty;
    string str1 = string.Empty;
    string str2;
    switch (A_0)
    {
      case DuelEndEvents.OutsiderInterruptedDuel:
      case DuelEndEvents.ChallengerKnockedDownByOutsider:
      case DuelEndEvents.ChallengeeKnockedDownByOutsider:
        str2 = kr.a("@GAMEEVENT_DUEL_ENDED_INTERRUPTED_BY_OUTSIDER", new object[2]
        {
          (object) A_1,
          (object) A_2
        });
        break;
      case DuelEndEvents.ChallengerKnockedDownByChallengee:
        str2 = kr.a("@GAMEEVENT_DUEL_ENDED_HONORABLE_WIN", new object[2]
        {
          (object) A_2,
          (object) A_1
        });
        str1 = A_2;
        break;
      case DuelEndEvents.ChallengerKnockedDownByNonPlayer:
        str2 = kr.a("@GAMEEVENT_DUEL_ENDED_UNHONORABLE_WIN", new object[2]
        {
          (object) A_2,
          (object) A_1
        });
        str1 = A_2;
        break;
      case DuelEndEvents.ChallengerInterruptedPreparation:
        str2 = kr.a("@GAMEEVENT_DUEL_ABORTED_IN_PREPARATION", new object[1]
        {
          (object) A_1
        });
        break;
      case DuelEndEvents.ChallengerKilledHimself:
        str2 = kr.a("@GAMEEVENT_DUEL_ENDED_SUICIDE", new object[2]
        {
          (object) A_2,
          (object) A_1
        });
        str1 = A_2;
        break;
      case DuelEndEvents.ChallengerLeftArea:
      case DuelEndEvents.ChallengerDestroyed:
        str2 = kr.a("@GAMEEVENT_DUEL_ENDED_FLED", new object[2]
        {
          (object) A_2,
          (object) A_1
        });
        str1 = A_2;
        break;
      case DuelEndEvents.ChallengeeKnockedDownByChallenger:
        str2 = kr.a("@GAMEEVENT_DUEL_ENDED_HONORABLE_WIN", new object[2]
        {
          (object) A_1,
          (object) A_2
        });
        str1 = A_1;
        break;
      case DuelEndEvents.ChallengeeKnockedDownByNonPlayer:
        str2 = kr.a("@GAMEEVENT_DUEL_ENDED_UNHONORABLE_WIN", new object[2]
        {
          (object) A_1,
          (object) A_2
        });
        str1 = A_1;
        break;
      case DuelEndEvents.ChallengeeInterruptedPreparation:
        str2 = kr.a("@GAMEEVENT_DUEL_ABORTED_IN_PREPARATION", new object[1]
        {
          (object) A_2
        });
        break;
      case DuelEndEvents.ChallengeeKilledHimself:
        str2 = kr.a("@GAMEEVENT_DUEL_ENDED_SUICIDE", new object[2]
        {
          (object) A_1,
          (object) A_2
        });
        str1 = A_1;
        break;
      case DuelEndEvents.ChallengeeLeftArea:
      case DuelEndEvents.ChallengeeDestroyed:
        str2 = kr.a("@GAMEEVENT_DUEL_ENDED_FLED", new object[2]
        {
          (object) A_1,
          (object) A_2
        });
        str1 = A_1;
        break;
      default:
        str2 = "Invalid DuelGameEvent";
        break;
    }
    if (!string.IsNullOrEmpty(str1) && kx.k(A_3, kx.g))
      str2 = str2 + Environment.NewLine + kr.a("@GAMEEVENT_DUEL_WAGER_EARNED", new object[2]
      {
        (object) str1,
        (object) A_3.j().ToString()
      });
    return str2;
  }
}
