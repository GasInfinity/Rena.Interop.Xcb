namespace Rena.Interop.Xcb;

public unsafe partial struct xcb_input_button_state_iterator_t
{
    public xcb_input_button_state_t* data;

    public int rem;

    public int index;
}