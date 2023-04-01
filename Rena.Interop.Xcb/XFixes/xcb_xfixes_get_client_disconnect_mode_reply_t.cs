namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_xfixes_get_client_disconnect_mode_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint32_t")]
    public uint disconnect_mode;

    [NativeTypeName("uint8_t[20]")]
    public fixed byte pad1[20];
}
