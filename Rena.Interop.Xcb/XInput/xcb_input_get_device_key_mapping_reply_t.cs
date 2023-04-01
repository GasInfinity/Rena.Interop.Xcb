namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_get_device_key_mapping_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte xi_reply_type;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint8_t")]
    public byte keysyms_per_keycode;

    [NativeTypeName("uint8_t[23]")]
    public fixed byte pad0[23];
}
