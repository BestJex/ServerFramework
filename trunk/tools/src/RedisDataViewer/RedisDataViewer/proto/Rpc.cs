// Generated by ProtoGen, Version=2.4.1.521, Culture=neutral, PublicKeyToken=null.  DO NOT EDIT!
#pragma warning disable
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace org.zhangqi.proto {
  
  public static partial class Rpc {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    #endregion
    #region Extensions
    internal static readonly object Descriptor;
    static Rpc() {
      Descriptor = null;
    }
    #endregion
    
  }
  #region Enums
  public enum RpcNameEnum {
    Regist = 101,
    Login = 102,
    Match = 111,
    CancelMatch = 112,
    GetBattleInfo = 6001,
    Concede = 6002,
    PlacePieces = 6003,
    ForceEndTurn = 6004,
    ReadyToStartGame = 6005,
    ForceReadyToStartGame = 6006,
    ForceOfflinePush = 20001,
    MatchResultPush = 21001,
    BattleEventMsgListPush = 22001,
  }
  
  public enum RpcErrorCodeEnum {
    Ok = 0,
    ServerError = 1,
    ClientError = 2,
    ServerNotAvailable = 3,
    UserNotInBattle = 11,
    BattleNotStart = 12,
    IsNotUserTurn = 13,
    InputLastEventNumError = 14,
    RegisErrorUsernameIsExist = 1011,
    RegisErrorUsernameIllegal = 1012,
    RegisErrorPasswordIllegal = 1013,
    LoginErrorUsernameIsNotExist = 1021,
    LoginErrorPasswordWrong = 1022,
    LoginErrorForbid = 1023,
    MatchErrorMatching = 1111,
    MatchErrorPlaying = 1112,
    MatchErrorOtherActionState = 1113,
    CancelMatchErrorPlaying = 1121,
    CancelMatchErrorNotMatching = 1122,
    PlacePiecesErrorIndexError = 60031,
    PlacePiecesErrorIndexIsNotEmpty = 60032,
    ReadyToStartGameErrorAlreadyReady = 60051,
    ForceReadyToStartGameErrorAlreadyStart = 60052,
  }
  
  #endregion
  
}

#endregion Designer generated code
#pragma warning restore
