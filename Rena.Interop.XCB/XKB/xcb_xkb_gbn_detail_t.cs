namespace Rena.Interop.XCB;

[NativeTypeName("unsigned int")]
public enum xcb_xkb_gbn_detail_t : uint
{
    XCB_XKB_GBN_DETAIL_TYPES = 1,
    XCB_XKB_GBN_DETAIL_COMPAT_MAP = 2,
    XCB_XKB_GBN_DETAIL_CLIENT_SYMBOLS = 4,
    XCB_XKB_GBN_DETAIL_SERVER_SYMBOLS = 8,
    XCB_XKB_GBN_DETAIL_INDICATOR_MAPS = 16,
    XCB_XKB_GBN_DETAIL_KEY_NAMES = 32,
    XCB_XKB_GBN_DETAIL_GEOMETRY = 64,
    XCB_XKB_GBN_DETAIL_OTHER_NAMES = 128,
}