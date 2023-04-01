namespace Rena.Interop.Xcb;

public partial struct xcb_query_best_size_reply_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte pad0;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint16_t")]
    public ushort width;

    [NativeTypeName("uint16_t")]
    public ushort height;
}
