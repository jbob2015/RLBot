// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace rlbot.flat
{

using global::System;
using global::FlatBuffers;

public struct PlayerInfo : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static PlayerInfo GetRootAsPlayerInfo(ByteBuffer _bb) { return GetRootAsPlayerInfo(_bb, new PlayerInfo()); }
  public static PlayerInfo GetRootAsPlayerInfo(ByteBuffer _bb, PlayerInfo obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public PlayerInfo __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Physics? Physics { get { int o = __p.__offset(4); return o != 0 ? (Physics?)(new Physics()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public ScoreInfo? ScoreInfo { get { int o = __p.__offset(6); return o != 0 ? (ScoreInfo?)(new ScoreInfo()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public bool IsDemolished { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  /// True if your wheels are on the ground, the wall, or the ceiling. False if you're midair or turtling.
  public bool HasWheelContact { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool IsSupersonic { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool IsBot { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  /// True if the player has jumped. Falling off the ceiling / driving off the goal post does not count.
  public bool Jumped { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  ///  True if player has double jumped. False does not mean you have a jump remaining, because the
  ///  aerial timer can run out, and that doesn't affect this flag.
  public bool DoubleJumped { get { int o = __p.__offset(18); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string Name { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(20); }
  public int Team { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Boost { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<PlayerInfo> CreatePlayerInfo(FlatBufferBuilder builder,
      Offset<Physics> physicsOffset = default(Offset<Physics>),
      Offset<ScoreInfo> scoreInfoOffset = default(Offset<ScoreInfo>),
      bool isDemolished = false,
      bool hasWheelContact = false,
      bool isSupersonic = false,
      bool isBot = false,
      bool jumped = false,
      bool doubleJumped = false,
      StringOffset nameOffset = default(StringOffset),
      int team = 0,
      int boost = 0) {
    builder.StartObject(11);
    PlayerInfo.AddBoost(builder, boost);
    PlayerInfo.AddTeam(builder, team);
    PlayerInfo.AddName(builder, nameOffset);
    PlayerInfo.AddScoreInfo(builder, scoreInfoOffset);
    PlayerInfo.AddPhysics(builder, physicsOffset);
    PlayerInfo.AddDoubleJumped(builder, doubleJumped);
    PlayerInfo.AddJumped(builder, jumped);
    PlayerInfo.AddIsBot(builder, isBot);
    PlayerInfo.AddIsSupersonic(builder, isSupersonic);
    PlayerInfo.AddHasWheelContact(builder, hasWheelContact);
    PlayerInfo.AddIsDemolished(builder, isDemolished);
    return PlayerInfo.EndPlayerInfo(builder);
  }

  public static void StartPlayerInfo(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddPhysics(FlatBufferBuilder builder, Offset<Physics> physicsOffset) { builder.AddOffset(0, physicsOffset.Value, 0); }
  public static void AddScoreInfo(FlatBufferBuilder builder, Offset<ScoreInfo> scoreInfoOffset) { builder.AddOffset(1, scoreInfoOffset.Value, 0); }
  public static void AddIsDemolished(FlatBufferBuilder builder, bool isDemolished) { builder.AddBool(2, isDemolished, false); }
  public static void AddHasWheelContact(FlatBufferBuilder builder, bool hasWheelContact) { builder.AddBool(3, hasWheelContact, false); }
  public static void AddIsSupersonic(FlatBufferBuilder builder, bool isSupersonic) { builder.AddBool(4, isSupersonic, false); }
  public static void AddIsBot(FlatBufferBuilder builder, bool isBot) { builder.AddBool(5, isBot, false); }
  public static void AddJumped(FlatBufferBuilder builder, bool jumped) { builder.AddBool(6, jumped, false); }
  public static void AddDoubleJumped(FlatBufferBuilder builder, bool doubleJumped) { builder.AddBool(7, doubleJumped, false); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(8, nameOffset.Value, 0); }
  public static void AddTeam(FlatBufferBuilder builder, int team) { builder.AddInt(9, team, 0); }
  public static void AddBoost(FlatBufferBuilder builder, int boost) { builder.AddInt(10, boost, 0); }
  public static Offset<PlayerInfo> EndPlayerInfo(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<PlayerInfo>(o);
  }
};


}
