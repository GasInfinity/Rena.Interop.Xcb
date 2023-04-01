namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_randr_set_crtc_config_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte status;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("xcb_timestamp_t")]
    public uint timestamp;

    [NativeTypeName("uint8_t[20]")]
    public fixed byte pad0[20];
}
