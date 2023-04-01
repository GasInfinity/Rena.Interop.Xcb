namespace Rena.Interop.Xcb;

public partial struct xcb_input_enter_event_t
{
    [NativeTypeName("uint8_t")]
    public byte response_type;

    [NativeTypeName("uint8_t")]
    public byte extension;

    [NativeTypeName("uint16_t")]
    public ushort sequence;

    [NativeTypeName("uint32_t")]
    public uint length;

    [NativeTypeName("uint16_t")]
    public ushort event_type;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort deviceid;

    [NativeTypeName("xcb_timestamp_t")]
    public uint time;

    [NativeTypeName("xcb_input_device_id_t")]
    public ushort sourceid;

    [NativeTypeName("uint8_t")]
    public byte mode;

    [NativeTypeName("uint8_t")]
    public byte detail;

    [NativeTypeName("xcb_window_t")]
    public uint root;

    [NativeTypeName("xcb_window_t")]
    public uint @event;

    [NativeTypeName("xcb_window_t")]
    public uint child;

    [NativeTypeName("uint32_t")]
    public uint full_sequence;

    [NativeTypeName("xcb_input_fp1616_t")]
    public int root_x;

    [NativeTypeName("xcb_input_fp1616_t")]
    public int root_y;

    [NativeTypeName("xcb_input_fp1616_t")]
    public int event_x;

    [NativeTypeName("xcb_input_fp1616_t")]
    public int event_y;

    [NativeTypeName("uint8_t")]
    public byte same_screen;

    [NativeTypeName("uint8_t")]
    public byte focus;

    [NativeTypeName("uint16_t")]
    public ushort buttons_len;

    public xcb_input_modifier_info_t mods;

    public xcb_input_group_info_t group;
}
