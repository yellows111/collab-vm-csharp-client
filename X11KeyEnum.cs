namespace CollabAPI
{
    public enum X11KeyCode : ushort
    {
        /* $Xorg: keysymdef.h,v 1.4 2001/02/09 02:03:23 $ */
        /***********************************************************
        Copyright 1987, 1994, 1998 The Open Group
        Permission to use, copy, modify, distribute, and sell this software and its
        documentation for any purpose is hereby granted without fee, provided that
        the above copyright notice appear in all copies and that both that
        copyright notice and this permission notice appear in supporting
        documentation.
        The above copyright notice and this permission notice shall be included
        in all copies or substantial portions of the Software.
        THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
        OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
        MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
        IN NO EVENT SHALL THE OPEN GROUP BE LIABLE FOR ANY CLAIM, DAMAGES OR
        OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
        ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
        OTHER DEALINGS IN THE SOFTWARE.
        Except as contained in this notice, the name of The Open Group shall
        not be used in advertising or otherwise to promote the sale, use or
        other dealings in this Software without prior written authorization
        from The Open Group.
        Copyright 1987 by Digital Equipment Corporation, Maynard, Massachusetts
         All Rights Reserved
        Permission to use, copy, modify, and distribute this software and its
        documentation for any purpose and without fee is hereby granted,
        provided that the above copyright notice appear in all copies and that
        both that copyright notice and this permission notice appear in
        supporting documentation, and that the name of Digital not be
        used in advertising or publicity pertaining to distribution of the
        software without specific, written prior permission.
        DIGITAL DISCLAIMS ALL WARRANTIES WITH REGARD TO THIS SOFTWARE, INCLUDING
        ALL IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS, IN NO EVENT SHALL
        DIGITAL BE LIABLE FOR ANY SPECIAL, INDIRECT OR CONSEQUENTIAL DAMAGES OR
        ANY DAMAGES WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS,
        WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION,
        ARISING OUT OF OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS
        SOFTWARE.
        ******************************************************************/
        /* $XFree86: $ */
        /*
         * The "X11 Window System Protocol" standard defines in Appendix A the
         * keysym codes. These 29-bit integer values identify characters or
         * functions associated with each key (e.g., via the visible
         * engraving) of a keyboard layout. This file assigns mnemonic macro
         * names for these keysyms.
         *
         * This file is also compiled (by xc/lib/X11/util/makekeys.c) into
         * hash tables that can be accessed with X11 library functions such as
         * XStringToKeysym() and XKeysymToString().
         *
         * Where a keysym corresponds one-to-one to an ISO 10646 / Unicode
         * character, this is noted in a comment that provides both the U+xxxx
         * Unicode position, as well as the official Unicode name of the
         * character.
         *
         * Where the correspondence is either not one-to-one or semantically
         * unclear, the Unicode position and name are enclosed in
         * parentheses. Such legacy keysyms should be considered deprecated
         * and are not recommended for use in future keyboard mappings.
         *
         * For any future extension of the keysyms with characters already
         * found in ISO 10646 / Unicode, the following algorithm shall be
         * used. The new keysym code position will simply be the character's
         * Unicode number plus 0x01000000. The keysym values in the range
         * 0x01000100 to 0x0110ffff are reserved to represent Unicode
         * characters in the range U+0100 to U+10FFFF.
         * 
         * While most newer Unicode-based X11 clients do already accept
         * Unicode-mapped keysyms in the range 0x01000100 to 0x0110ffff, it
         * will remain necessary for clients -- in the interest of
         * compatibility with existing servers -- to also understand the
         * existing legacy keysym values in the range 0x0100 to 0x20ff.
         *
         * Where several mnemonic names are defined for the same keysym in this
         * file, all but the first one listed should be considered deprecated.
         *
         * Mnemonic names for keysyms are defined in this file with lines
         * that match one of these Perl regular expressions:
         *
         * /^\#define XK_([a-zA-Z_0-9]+)\s+0x([0-9a-f]+)\s*\/\* U+([0-9A-F]{4,6}) (.*) \*\/\s*$/
         * /^\#define XK_([a-zA-Z_0-9]+)\s+0x([0-9a-f]+)\s*\/\*\(U+([0-9A-F]{4,6}) (.*)\)\*\/\s*$/
         * /^\#define XK_([a-zA-Z_0-9]+)\s+0x([0-9a-f]+)\s*(\/\*\s*(.*)\s*\*\/)?\s*$/
         *
         * When adding new keysyms to this file, do not forget to also update the
         * mappings in xc/lib/X11/KeyBind.c and the protocol specification in
         * xc/doc/specs/XProtocol/X11.keysyms.
         */
        //XK_VoidSymbol = 0xffffff, /* Void symbol */
        //#ifdef XK_MISCELLANY
        /*
         * TTY function keys, cleverly chosen to map to ASCII, for convenience of
         * programming, but could have been arbitrary (at the cost of lookup
         * tables in client code).
         */
        XK_BackSpace = 0xff08, /* Back space, back char */
        XK_Tab = 0xff09,
        XK_Linefeed = 0xff0a, /* Linefeed, LF */
        XK_Clear = 0xff0b,
        XK_Return = 0xff0d, /* Return, enter */
        XK_Pause = 0xff13, /* Pause, hold */
        XK_Scroll_Lock = 0xff14,
        XK_Sys_Req = 0xff15,
        XK_Escape = 0xff1b,
        XK_Delete = 0xffff, /* Delete, rubout */
                            /* International & multi-key character composition */
        XK_Multi_key = 0xff20, /* Multi-key character compose */
        XK_Codeinput = 0xff37,
        XK_SingleCandidate = 0xff3c,
        XK_MultipleCandidate = 0xff3d,
        XK_PreviousCandidate = 0xff3e,
        /* Japanese keyboard support */
        XK_Kanji = 0xff21, /* Kanji, Kanji convert */
        XK_Muhenkan = 0xff22, /* Cancel Conversion */
        XK_Henkan_Mode = 0xff23, /* Start/Stop Conversion */
        XK_Henkan = 0xff23, /* Alias for Henkan_Mode */
        XK_Romaji = 0xff24, /* to Romaji */
        XK_Hiragana = 0xff25, /* to Hiragana */
        XK_Katakana = 0xff26, /* to Katakana */
        XK_Hiragana_Katakana = 0xff27, /* Hiragana/Katakana toggle */
        XK_Zenkaku = 0xff28, /* to Zenkaku */
        XK_Hankaku = 0xff29, /* to Hankaku */
        XK_Zenkaku_Hankaku = 0xff2a, /* Zenkaku/Hankaku toggle */
        XK_Touroku = 0xff2b, /* Add to Dictionary */
        XK_Massyo = 0xff2c, /* Delete from Dictionary */
        XK_Kana_Lock = 0xff2d, /* Kana Lock */
        XK_Kana_Shift = 0xff2e, /* Kana Shift */
        XK_Eisu_Shift = 0xff2f, /* Alphanumeric Shift */
        XK_Eisu_toggle = 0xff30, /* Alphanumeric toggle */
        XK_Kanji_Bangou = 0xff37, /* Codeinput */
        XK_Zen_Koho = 0xff3d, /* Multiple/All Candidate(s) */
        XK_Mae_Koho = 0xff3e, /* Previous Candidate */
                              /* 0xff31 thru 0xff3f are under XK_KOREAN */
                              /* Cursor control & motion */
        XK_Home = 0xff50,
        XK_Left = 0xff51, /* Move left, left arrow */
        XK_Up = 0xff52, /* Move up, up arrow */
        XK_Right = 0xff53, /* Move right, right arrow */
        XK_Down = 0xff54, /* Move down, down arrow */
        XK_Prior = 0xff55, /* Prior, previous */
        XK_Page_Up = 0xff55,
        XK_Next = 0xff56, /* Next */
        XK_Page_Down = 0xff56,
        XK_End = 0xff57, /* EOL */
        XK_Begin = 0xff58, /* BOL */
                           /* Misc functions */
        XK_Select = 0xff60, /* Select, mark */
        XK_Print = 0xff61,
        XK_Execute = 0xff62, /* Execute, run, do */
        XK_Insert = 0xff63, /* Insert, insert here */
        XK_Undo = 0xff65,
        XK_Redo = 0xff66, /* Redo, again */
        XK_Menu = 0xff67,
        XK_Find = 0xff68, /* Find, search */
        XK_Cancel = 0xff69, /* Cancel, stop, abort, exit */
        XK_Help = 0xff6a, /* Help */
        XK_Break = 0xff6b,
        XK_Mode_switch = 0xff7e, /* Character set switch */
        XK_script_switch = 0xff7e, /* Alias for mode_switch */
        XK_Num_Lock = 0xff7f,
        /* Keypad functions, keypad numbers cleverly chosen to map to ASCII */
        XK_KP_Space = 0xff80, /* Space */
        XK_KP_Tab = 0xff89,
        XK_KP_Enter = 0xff8d, /* Enter */
        XK_KP_F1 = 0xff91, /* PF1, KP_A, ... */
        XK_KP_F2 = 0xff92,
        XK_KP_F3 = 0xff93,
        XK_KP_F4 = 0xff94,
        XK_KP_Home = 0xff95,
        XK_KP_Left = 0xff96,
        XK_KP_Up = 0xff97,
        XK_KP_Right = 0xff98,
        XK_KP_Down = 0xff99,
        XK_KP_Prior = 0xff9a,
        XK_KP_Page_Up = 0xff9a,
        XK_KP_Next = 0xff9b,
        XK_KP_Page_Down = 0xff9b,
        XK_KP_End = 0xff9c,
        XK_KP_Begin = 0xff9d,
        XK_KP_Insert = 0xff9e,
        XK_KP_Delete = 0xff9f,
        XK_KP_Equal = 0xffbd, /* Equals */
        XK_KP_Multiply = 0xffaa,
        XK_KP_Add = 0xffab,
        XK_KP_Separator = 0xffac, /* Separator, often comma */
        XK_KP_Subtract = 0xffad,
        XK_KP_Decimal = 0xffae,
        XK_KP_Divide = 0xffaf,
        XK_KP_0 = 0xffb0,
        XK_KP_1 = 0xffb1,
        XK_KP_2 = 0xffb2,
        XK_KP_3 = 0xffb3,
        XK_KP_4 = 0xffb4,
        XK_KP_5 = 0xffb5,
        XK_KP_6 = 0xffb6,
        XK_KP_7 = 0xffb7,
        XK_KP_8 = 0xffb8,
        XK_KP_9 = 0xffb9,
        /*
         * Auxilliary functions; note the duplicate definitions for left and right
         * function keys; Sun keyboards and a few other manufactures have such
         * function key groups on the left and/or right sides of the keyboard.
         * We've not found a keyboard with more than 35 function keys total.
         */
        XK_F1 = 0xffbe,
        XK_F2 = 0xffbf,
        XK_F3 = 0xffc0,
        XK_F4 = 0xffc1,
        XK_F5 = 0xffc2,
        XK_F6 = 0xffc3,
        XK_F7 = 0xffc4,
        XK_F8 = 0xffc5,
        XK_F9 = 0xffc6,
        XK_F10 = 0xffc7,
        XK_F11 = 0xffc8,
        XK_L1 = 0xffc8,
        XK_F12 = 0xffc9,
        XK_L2 = 0xffc9,
        XK_F13 = 0xffca,
        XK_L3 = 0xffca,
        XK_F14 = 0xffcb,
        XK_L4 = 0xffcb,
        XK_F15 = 0xffcc,
        XK_L5 = 0xffcc,
        XK_F16 = 0xffcd,
        XK_L6 = 0xffcd,
        XK_F17 = 0xffce,
        XK_L7 = 0xffce,
        XK_F18 = 0xffcf,
        XK_L8 = 0xffcf,
        XK_F19 = 0xffd0,
        XK_L9 = 0xffd0,
        XK_F20 = 0xffd1,
        XK_L10 = 0xffd1,
        XK_F21 = 0xffd2,
        XK_R1 = 0xffd2,
        XK_F22 = 0xffd3,
        XK_R2 = 0xffd3,
        XK_F23 = 0xffd4,
        XK_R3 = 0xffd4,
        XK_F24 = 0xffd5,
        XK_R4 = 0xffd5,
        XK_F25 = 0xffd6,
        XK_R5 = 0xffd6,
        XK_F26 = 0xffd7,
        XK_R6 = 0xffd7,
        XK_F27 = 0xffd8,
        XK_R7 = 0xffd8,
        XK_F28 = 0xffd9,
        XK_R8 = 0xffd9,
        XK_F29 = 0xffda,
        XK_R9 = 0xffda,
        XK_F30 = 0xffdb,
        XK_R10 = 0xffdb,
        XK_F31 = 0xffdc,
        XK_R11 = 0xffdc,
        XK_F32 = 0xffdd,
        XK_R12 = 0xffdd,
        XK_F33 = 0xffde,
        XK_R13 = 0xffde,
        XK_F34 = 0xffdf,
        XK_R14 = 0xffdf,
        XK_F35 = 0xffe0,
        XK_R15 = 0xffe0,
        /* Modifiers */
        XK_Shift_L = 0xffe1, /* Left shift */
        XK_Shift_R = 0xffe2, /* Right shift */
        XK_Control_L = 0xffe3, /* Left control */
        XK_Control_R = 0xffe4, /* Right control */
        XK_Caps_Lock = 0xffe5, /* Caps lock */
        XK_Shift_Lock = 0xffe6, /* Shift lock */
        XK_Meta_L = 0xffe7, /* Left meta */
        XK_Meta_R = 0xffe8, /* Right meta */
        XK_Alt_L = 0xffe9, /* Left alt */
        XK_Alt_R = 0xffea, /* Right alt */
        XK_Super_L = 0xffeb, /* Left super */
        XK_Super_R = 0xffec, /* Right super */
        XK_Hyper_L = 0xffed, /* Left hyper */
        XK_Hyper_R = 0xffee, /* Right hyper */
                             //#endif /* XK_MISCELLANY */
                             /*
                              * Keyboard (XKB) Extension function and modifier keys
                              * (from Appendix C of "The X Keyboard Extension: Protocol Specification")
                              * Byte 3 = 0xfe
                              */
                             //#ifdef XK_XKB_KEYS
        XK_ISO_Lock = 0xfe01,
        XK_ISO_Level2_Latch = 0xfe02,
        XK_ISO_Level3_Shift = 0xfe03,
        XK_ISO_Level3_Latch = 0xfe04,
        XK_ISO_Level3_Lock = 0xfe05,
        XK_ISO_Group_Shift = 0xff7e, /* Alias for mode_switch */
        XK_ISO_Group_Latch = 0xfe06,
        XK_ISO_Group_Lock = 0xfe07,
        XK_ISO_Next_Group = 0xfe08,
        XK_ISO_Next_Group_Lock = 0xfe09,
        XK_ISO_Prev_Group = 0xfe0a,
        XK_ISO_Prev_Group_Lock = 0xfe0b,
        XK_ISO_First_Group = 0xfe0c,
        XK_ISO_First_Group_Lock = 0xfe0d,
        XK_ISO_Last_Group = 0xfe0e,
        XK_ISO_Last_Group_Lock = 0xfe0f,
        XK_ISO_Left_Tab = 0xfe20,
        XK_ISO_Move_Line_Up = 0xfe21,
        XK_ISO_Move_Line_Down = 0xfe22,
        XK_ISO_Partial_Line_Up = 0xfe23,
        XK_ISO_Partial_Line_Down = 0xfe24,
        XK_ISO_Partial_Space_Left = 0xfe25,
        XK_ISO_Partial_Space_Right = 0xfe26,
        XK_ISO_Set_Margin_Left = 0xfe27,
        XK_ISO_Set_Margin_Right = 0xfe28,
        XK_ISO_Release_Margin_Left = 0xfe29,
        XK_ISO_Release_Margin_Right = 0xfe2a,
        XK_ISO_Release_Both_Margins = 0xfe2b,
        XK_ISO_Fast_Cursor_Left = 0xfe2c,
        XK_ISO_Fast_Cursor_Right = 0xfe2d,
        XK_ISO_Fast_Cursor_Up = 0xfe2e,
        XK_ISO_Fast_Cursor_Down = 0xfe2f,
        XK_ISO_Continuous_Underline = 0xfe30,
        XK_ISO_Discontinuous_Underline = 0xfe31,
        XK_ISO_Emphasize = 0xfe32,
        XK_ISO_Center_Object = 0xfe33,
        XK_ISO_Enter = 0xfe34,
        XK_dead_grave = 0xfe50,
        XK_dead_acute = 0xfe51,
        XK_dead_circumflex = 0xfe52,
        XK_dead_tilde = 0xfe53,
        XK_dead_macron = 0xfe54,
        XK_dead_breve = 0xfe55,
        XK_dead_abovedot = 0xfe56,
        XK_dead_diaeresis = 0xfe57,
        XK_dead_abovering = 0xfe58,
        XK_dead_doubleacute = 0xfe59,
        XK_dead_caron = 0xfe5a,
        XK_dead_cedilla = 0xfe5b,
        XK_dead_ogonek = 0xfe5c,
        XK_dead_iota = 0xfe5d,
        XK_dead_voiced_sound = 0xfe5e,
        XK_dead_semivoiced_sound = 0xfe5f,
        XK_dead_belowdot = 0xfe60,
        XK_dead_hook = 0xfe61,
        XK_dead_horn = 0xfe62,
        XK_First_Virtual_Screen = 0xfed0,
        XK_Prev_Virtual_Screen = 0xfed1,
        XK_Next_Virtual_Screen = 0xfed2,
        XK_Last_Virtual_Screen = 0xfed4,
        XK_Terminate_Server = 0xfed5,
        XK_AccessX_Enable = 0xfe70,
        XK_AccessX_Feedback_Enable = 0xfe71,
        XK_RepeatKeys_Enable = 0xfe72,
        XK_SlowKeys_Enable = 0xfe73,
        XK_BounceKeys_Enable = 0xfe74,
        XK_StickyKeys_Enable = 0xfe75,
        XK_MouseKeys_Enable = 0xfe76,
        XK_MouseKeys_Accel_Enable = 0xfe77,
        XK_Overlay1_Enable = 0xfe78,
        XK_Overlay2_Enable = 0xfe79,
        XK_AudibleBell_Enable = 0xfe7a,
        XK_Pointer_Left = 0xfee0,
        XK_Pointer_Right = 0xfee1,
        XK_Pointer_Up = 0xfee2,
        XK_Pointer_Down = 0xfee3,
        XK_Pointer_UpLeft = 0xfee4,
        XK_Pointer_UpRight = 0xfee5,
        XK_Pointer_DownLeft = 0xfee6,
        XK_Pointer_DownRight = 0xfee7,
        XK_Pointer_Button_Dflt = 0xfee8,
        XK_Pointer_Button1 = 0xfee9,
        XK_Pointer_Button2 = 0xfeea,
        XK_Pointer_Button3 = 0xfeeb,
        XK_Pointer_Button4 = 0xfeec,
        XK_Pointer_Button5 = 0xfeed,
        XK_Pointer_DblClick_Dflt = 0xfeee,
        XK_Pointer_DblClick1 = 0xfeef,
        XK_Pointer_DblClick2 = 0xfef0,
        XK_Pointer_DblClick3 = 0xfef1,
        XK_Pointer_DblClick4 = 0xfef2,
        XK_Pointer_DblClick5 = 0xfef3,
        XK_Pointer_Drag_Dflt = 0xfef4,
        XK_Pointer_Drag1 = 0xfef5,
        XK_Pointer_Drag2 = 0xfef6,
        XK_Pointer_Drag3 = 0xfef7,
        XK_Pointer_Drag4 = 0xfef8,
        XK_Pointer_Drag5 = 0xfefd,
        XK_Pointer_EnableKeys = 0xfef9,
        XK_Pointer_Accelerate = 0xfefa,
        XK_Pointer_DfltBtnNext = 0xfefb,
        XK_Pointer_DfltBtnPrev = 0xfefc,
        //#endif /* XK_XKB_KEYS */
        /*
         * 3270 Terminal Keys
         * Byte 3 = 0xfd
         */
        //#ifdef XK_3270
        XK_3270_Duplicate = 0xfd01,
        XK_3270_FieldMark = 0xfd02,
        XK_3270_Right2 = 0xfd03,
        XK_3270_Left2 = 0xfd04,
        XK_3270_BackTab = 0xfd05,
        XK_3270_EraseEOF = 0xfd06,
        XK_3270_EraseInput = 0xfd07,
        XK_3270_Reset = 0xfd08,
        XK_3270_Quit = 0xfd09,
        XK_3270_PA1 = 0xfd0a,
        XK_3270_PA2 = 0xfd0b,
        XK_3270_PA3 = 0xfd0c,
        XK_3270_Test = 0xfd0d,
        XK_3270_Attn = 0xfd0e,
        XK_3270_CursorBlink = 0xfd0f,
        XK_3270_AltCursor = 0xfd10,
        XK_3270_KeyClick = 0xfd11,
        XK_3270_Jump = 0xfd12,
        XK_3270_Ident = 0xfd13,
        XK_3270_Rule = 0xfd14,
        XK_3270_Copy = 0xfd15,
        XK_3270_Play = 0xfd16,
        XK_3270_Setup = 0xfd17,
        XK_3270_Record = 0xfd18,
        XK_3270_ChangeScreen = 0xfd19,
        XK_3270_DeleteWord = 0xfd1a,
        XK_3270_ExSelect = 0xfd1b,
        XK_3270_CursorSelect = 0xfd1c,
        XK_3270_PrintScreen = 0xfd1d,
        XK_3270_Enter = 0xfd1e,
        //#endif /* XK_3270 */
        /*
         * Latin 1
         * (ISO/IEC 8859-1 = Unicode U+0020..U+00FF)
         * Byte 3 = 0
         */
        //#ifdef XK_LATIN1
        XK_space = 0x0020, /* U+0020 SPACE */
        XK_exclam = 0x0021, /* U+0021 EXCLAMATION MARK */
        XK_quotedbl = 0x0022, /* U+0022 QUOTATION MARK */
        XK_numbersign = 0x0023, /* U+0023 NUMBER SIGN */
        XK_dollar = 0x0024, /* U+0024 DOLLAR SIGN */
        XK_percent = 0x0025, /* U+0025 PERCENT SIGN */
        XK_ampersand = 0x0026, /* U+0026 AMPERSAND */
        XK_apostrophe = 0x0027, /* U+0027 APOSTROPHE */
        XK_quoteright = 0x0027, /* deprecated */
        XK_parenleft = 0x0028, /* U+0028 LEFT PARENTHESIS */
        XK_parenright = 0x0029, /* U+0029 RIGHT PARENTHESIS */
        XK_asterisk = 0x002a, /* U+002A ASTERISK */
        XK_plus = 0x002b, /* U+002B PLUS SIGN */
        XK_comma = 0x002c, /* U+002C COMMA */
        XK_minus = 0x002d, /* U+002D HYPHEN-MINUS */
        XK_period = 0x002e, /* U+002E FULL STOP */
        XK_slash = 0x002f, /* U+002F SOLIDUS */
        XK_0 = 0x0030, /* U+0030 DIGIT ZERO */
        XK_1 = 0x0031, /* U+0031 DIGIT ONE */
        XK_2 = 0x0032, /* U+0032 DIGIT TWO */
        XK_3 = 0x0033, /* U+0033 DIGIT THREE */
        XK_4 = 0x0034, /* U+0034 DIGIT FOUR */
        XK_5 = 0x0035, /* U+0035 DIGIT FIVE */
        XK_6 = 0x0036, /* U+0036 DIGIT SIX */
        XK_7 = 0x0037, /* U+0037 DIGIT SEVEN */
        XK_8 = 0x0038, /* U+0038 DIGIT EIGHT */
        XK_9 = 0x0039, /* U+0039 DIGIT NINE */
        XK_colon = 0x003a, /* U+003A COLON */
        XK_semicolon = 0x003b, /* U+003B SEMICOLON */
        XK_less = 0x003c, /* U+003C LESS-THAN SIGN */
        XK_equal = 0x003d, /* U+003D EQUALS SIGN */
        XK_greater = 0x003e, /* U+003E GREATER-THAN SIGN */
        XK_question = 0x003f, /* U+003F QUESTION MARK */
        XK_at = 0x0040, /* U+0040 COMMERCIAL AT */
        XK_A = 0x0041, /* U+0041 LATIN CAPITAL LETTER A */
        XK_B = 0x0042, /* U+0042 LATIN CAPITAL LETTER B */
        XK_C = 0x0043, /* U+0043 LATIN CAPITAL LETTER C */
        XK_D = 0x0044, /* U+0044 LATIN CAPITAL LETTER D */
        XK_E = 0x0045, /* U+0045 LATIN CAPITAL LETTER E */
        XK_F = 0x0046, /* U+0046 LATIN CAPITAL LETTER F */
        XK_G = 0x0047, /* U+0047 LATIN CAPITAL LETTER G */
        XK_H = 0x0048, /* U+0048 LATIN CAPITAL LETTER H */
        XK_I = 0x0049, /* U+0049 LATIN CAPITAL LETTER I */
        XK_J = 0x004a, /* U+004A LATIN CAPITAL LETTER J */
        XK_K = 0x004b, /* U+004B LATIN CAPITAL LETTER K */
        XK_L = 0x004c, /* U+004C LATIN CAPITAL LETTER L */
        XK_M = 0x004d, /* U+004D LATIN CAPITAL LETTER M */
        XK_N = 0x004e, /* U+004E LATIN CAPITAL LETTER N */
        XK_O = 0x004f, /* U+004F LATIN CAPITAL LETTER O */
        XK_P = 0x0050, /* U+0050 LATIN CAPITAL LETTER P */
        XK_Q = 0x0051, /* U+0051 LATIN CAPITAL LETTER Q */
        XK_R = 0x0052, /* U+0052 LATIN CAPITAL LETTER R */
        XK_S = 0x0053, /* U+0053 LATIN CAPITAL LETTER S */
        XK_T = 0x0054, /* U+0054 LATIN CAPITAL LETTER T */
        XK_U = 0x0055, /* U+0055 LATIN CAPITAL LETTER U */
        XK_V = 0x0056, /* U+0056 LATIN CAPITAL LETTER V */
        XK_W = 0x0057, /* U+0057 LATIN CAPITAL LETTER W */
        XK_X = 0x0058, /* U+0058 LATIN CAPITAL LETTER X */
        XK_Y = 0x0059, /* U+0059 LATIN CAPITAL LETTER Y */
        XK_Z = 0x005a, /* U+005A LATIN CAPITAL LETTER Z */
        XK_bracketleft = 0x005b, /* U+005B LEFT SQUARE BRACKET */
        XK_backslash = 0x005c, /* U+005C REVERSE SOLIDUS */
        XK_bracketright = 0x005d, /* U+005D RIGHT SQUARE BRACKET */
        XK_asciicircum = 0x005e, /* U+005E CIRCUMFLEX ACCENT */
        XK_underscore = 0x005f, /* U+005F LOW LINE */
        XK_grave = 0x0060, /* U+0060 GRAVE ACCENT */
        XK_quoteleft = 0x0060, /* deprecated */
        XK_a = 0x0061, /* U+0061 LATIN SMALL LETTER A */
        XK_b = 0x0062, /* U+0062 LATIN SMALL LETTER B */
        XK_c = 0x0063, /* U+0063 LATIN SMALL LETTER C */
        XK_d = 0x0064, /* U+0064 LATIN SMALL LETTER D */
        XK_e = 0x0065, /* U+0065 LATIN SMALL LETTER E */
        XK_f = 0x0066, /* U+0066 LATIN SMALL LETTER F */
        XK_g = 0x0067, /* U+0067 LATIN SMALL LETTER G */
        XK_h = 0x0068, /* U+0068 LATIN SMALL LETTER H */
        XK_i = 0x0069, /* U+0069 LATIN SMALL LETTER I */
        XK_j = 0x006a, /* U+006A LATIN SMALL LETTER J */
        XK_k = 0x006b, /* U+006B LATIN SMALL LETTER K */
        XK_l = 0x006c, /* U+006C LATIN SMALL LETTER L */
        XK_m = 0x006d, /* U+006D LATIN SMALL LETTER M */
        XK_n = 0x006e, /* U+006E LATIN SMALL LETTER N */
        XK_o = 0x006f, /* U+006F LATIN SMALL LETTER O */
        XK_p = 0x0070, /* U+0070 LATIN SMALL LETTER P */
        XK_q = 0x0071, /* U+0071 LATIN SMALL LETTER Q */
        XK_r = 0x0072, /* U+0072 LATIN SMALL LETTER R */
        XK_s = 0x0073, /* U+0073 LATIN SMALL LETTER S */
        XK_t = 0x0074, /* U+0074 LATIN SMALL LETTER T */
        XK_u = 0x0075, /* U+0075 LATIN SMALL LETTER U */
        XK_v = 0x0076, /* U+0076 LATIN SMALL LETTER V */
        XK_w = 0x0077, /* U+0077 LATIN SMALL LETTER W */
        XK_x = 0x0078, /* U+0078 LATIN SMALL LETTER X */
        XK_y = 0x0079, /* U+0079 LATIN SMALL LETTER Y */
        XK_z = 0x007a, /* U+007A LATIN SMALL LETTER Z */
        XK_braceleft = 0x007b, /* U+007B LEFT CURLY BRACKET */
        XK_bar = 0x007c, /* U+007C VERTICAL LINE */
        XK_braceright = 0x007d, /* U+007D RIGHT CURLY BRACKET */
        XK_asciitilde = 0x007e, /* U+007E TILDE */
        XK_nobreakspace = 0x00a0, /* U+00A0 NO-BREAK SPACE */
        XK_exclamdown = 0x00a1, /* U+00A1 INVERTED EXCLAMATION MARK */
        XK_cent = 0x00a2, /* U+00A2 CENT SIGN */
        XK_sterling = 0x00a3, /* U+00A3 POUND SIGN */
        XK_currency = 0x00a4, /* U+00A4 CURRENCY SIGN */
        XK_yen = 0x00a5, /* U+00A5 YEN SIGN */
        XK_brokenbar = 0x00a6, /* U+00A6 BROKEN BAR */
        XK_section = 0x00a7, /* U+00A7 SECTION SIGN */
        XK_diaeresis = 0x00a8, /* U+00A8 DIAERESIS */
        XK_copyright = 0x00a9, /* U+00A9 COPYRIGHT SIGN */
        XK_ordfeminine = 0x00aa, /* U+00AA FEMININE ORDINAL INDICATOR */
        XK_guillemotleft = 0x00ab, /* U+00AB LEFT-POINTING DOUBLE ANGLE QUOTATION MARK */
        XK_notsign = 0x00ac, /* U+00AC NOT SIGN */
        XK_hyphen = 0x00ad, /* U+00AD SOFT HYPHEN */
        XK_registered = 0x00ae, /* U+00AE REGISTERED SIGN */
        XK_macron = 0x00af, /* U+00AF MACRON */
        XK_degree = 0x00b0, /* U+00B0 DEGREE SIGN */
        XK_plusminus = 0x00b1, /* U+00B1 PLUS-MINUS SIGN */
        XK_twosuperior = 0x00b2, /* U+00B2 SUPERSCRIPT TWO */
        XK_threesuperior = 0x00b3, /* U+00B3 SUPERSCRIPT THREE */
        XK_acute = 0x00b4, /* U+00B4 ACUTE ACCENT */
        XK_mu = 0x00b5, /* U+00B5 MICRO SIGN */
        XK_paragraph = 0x00b6, /* U+00B6 PILCROW SIGN */
        XK_periodcentered = 0x00b7, /* U+00B7 MIDDLE DOT */
        XK_cedilla = 0x00b8, /* U+00B8 CEDILLA */
        XK_onesuperior = 0x00b9, /* U+00B9 SUPERSCRIPT ONE */
        XK_masculine = 0x00ba, /* U+00BA MASCULINE ORDINAL INDICATOR */
        XK_guillemotright = 0x00bb, /* U+00BB RIGHT-POINTING DOUBLE ANGLE QUOTATION MARK */
        XK_onequarter = 0x00bc, /* U+00BC VULGAR FRACTION ONE QUARTER */
        XK_onehalf = 0x00bd, /* U+00BD VULGAR FRACTION ONE HALF */
        XK_threequarters = 0x00be, /* U+00BE VULGAR FRACTION THREE QUARTERS */
        XK_questiondown = 0x00bf, /* U+00BF INVERTED QUESTION MARK */
        XK_Agrave = 0x00c0, /* U+00C0 LATIN CAPITAL LETTER A WITH GRAVE */
        XK_Aacute = 0x00c1, /* U+00C1 LATIN CAPITAL LETTER A WITH ACUTE */
        XK_Acircumflex = 0x00c2, /* U+00C2 LATIN CAPITAL LETTER A WITH CIRCUMFLEX */
        XK_Atilde = 0x00c3, /* U+00C3 LATIN CAPITAL LETTER A WITH TILDE */
        XK_Adiaeresis = 0x00c4, /* U+00C4 LATIN CAPITAL LETTER A WITH DIAERESIS */
        XK_Aring = 0x00c5, /* U+00C5 LATIN CAPITAL LETTER A WITH RING ABOVE */
        XK_AE = 0x00c6, /* U+00C6 LATIN CAPITAL LETTER AE */
        XK_Ccedilla = 0x00c7, /* U+00C7 LATIN CAPITAL LETTER C WITH CEDILLA */
        XK_Egrave = 0x00c8, /* U+00C8 LATIN CAPITAL LETTER E WITH GRAVE */
        XK_Eacute = 0x00c9, /* U+00C9 LATIN CAPITAL LETTER E WITH ACUTE */
        XK_Ecircumflex = 0x00ca, /* U+00CA LATIN CAPITAL LETTER E WITH CIRCUMFLEX */
        XK_Ediaeresis = 0x00cb, /* U+00CB LATIN CAPITAL LETTER E WITH DIAERESIS */
        XK_Igrave = 0x00cc, /* U+00CC LATIN CAPITAL LETTER I WITH GRAVE */
        XK_Iacute = 0x00cd, /* U+00CD LATIN CAPITAL LETTER I WITH ACUTE */
        XK_Icircumflex = 0x00ce, /* U+00CE LATIN CAPITAL LETTER I WITH CIRCUMFLEX */
        XK_Idiaeresis = 0x00cf, /* U+00CF LATIN CAPITAL LETTER I WITH DIAERESIS */
        XK_ETH = 0x00d0, /* U+00D0 LATIN CAPITAL LETTER ETH */
        XK_Eth = 0x00d0, /* deprecated */
        XK_Ntilde = 0x00d1, /* U+00D1 LATIN CAPITAL LETTER N WITH TILDE */
        XK_Ograve = 0x00d2, /* U+00D2 LATIN CAPITAL LETTER O WITH GRAVE */
        XK_Oacute = 0x00d3, /* U+00D3 LATIN CAPITAL LETTER O WITH ACUTE */
        XK_Ocircumflex = 0x00d4, /* U+00D4 LATIN CAPITAL LETTER O WITH CIRCUMFLEX */
        XK_Otilde = 0x00d5, /* U+00D5 LATIN CAPITAL LETTER O WITH TILDE */
        XK_Odiaeresis = 0x00d6, /* U+00D6 LATIN CAPITAL LETTER O WITH DIAERESIS */
        XK_multiply = 0x00d7, /* U+00D7 MULTIPLICATION SIGN */
        XK_Oslash = 0x00d8, /* U+00D8 LATIN CAPITAL LETTER O WITH STROKE */
        XK_Ooblique = 0x00d8, /* U+00D8 LATIN CAPITAL LETTER O WITH STROKE */
        XK_Ugrave = 0x00d9, /* U+00D9 LATIN CAPITAL LETTER U WITH GRAVE */
        XK_Uacute = 0x00da, /* U+00DA LATIN CAPITAL LETTER U WITH ACUTE */
        XK_Ucircumflex = 0x00db, /* U+00DB LATIN CAPITAL LETTER U WITH CIRCUMFLEX */
        XK_Udiaeresis = 0x00dc, /* U+00DC LATIN CAPITAL LETTER U WITH DIAERESIS */
        XK_Yacute = 0x00dd, /* U+00DD LATIN CAPITAL LETTER Y WITH ACUTE */
        XK_THORN = 0x00de, /* U+00DE LATIN CAPITAL LETTER THORN */
        XK_Thorn = 0x00de, /* deprecated */
        XK_ssharp = 0x00df, /* U+00DF LATIN SMALL LETTER SHARP S */
        XK_agrave = 0x00e0, /* U+00E0 LATIN SMALL LETTER A WITH GRAVE */
        XK_aacute = 0x00e1, /* U+00E1 LATIN SMALL LETTER A WITH ACUTE */
        XK_acircumflex = 0x00e2, /* U+00E2 LATIN SMALL LETTER A WITH CIRCUMFLEX */
        XK_atilde = 0x00e3, /* U+00E3 LATIN SMALL LETTER A WITH TILDE */
        XK_adiaeresis = 0x00e4, /* U+00E4 LATIN SMALL LETTER A WITH DIAERESIS */
        XK_aring = 0x00e5, /* U+00E5 LATIN SMALL LETTER A WITH RING ABOVE */
        XK_ae = 0x00e6, /* U+00E6 LATIN SMALL LETTER AE */
        XK_ccedilla = 0x00e7, /* U+00E7 LATIN SMALL LETTER C WITH CEDILLA */
        XK_egrave = 0x00e8, /* U+00E8 LATIN SMALL LETTER E WITH GRAVE */
        XK_eacute = 0x00e9, /* U+00E9 LATIN SMALL LETTER E WITH ACUTE */
        XK_ecircumflex = 0x00ea, /* U+00EA LATIN SMALL LETTER E WITH CIRCUMFLEX */
        XK_ediaeresis = 0x00eb, /* U+00EB LATIN SMALL LETTER E WITH DIAERESIS */
        XK_igrave = 0x00ec, /* U+00EC LATIN SMALL LETTER I WITH GRAVE */
        XK_iacute = 0x00ed, /* U+00ED LATIN SMALL LETTER I WITH ACUTE */
        XK_icircumflex = 0x00ee, /* U+00EE LATIN SMALL LETTER I WITH CIRCUMFLEX */
        XK_idiaeresis = 0x00ef, /* U+00EF LATIN SMALL LETTER I WITH DIAERESIS */
        XK_eth = 0x00f0, /* U+00F0 LATIN SMALL LETTER ETH */
        XK_ntilde = 0x00f1, /* U+00F1 LATIN SMALL LETTER N WITH TILDE */
        XK_ograve = 0x00f2, /* U+00F2 LATIN SMALL LETTER O WITH GRAVE */
        XK_oacute = 0x00f3, /* U+00F3 LATIN SMALL LETTER O WITH ACUTE */
        XK_ocircumflex = 0x00f4, /* U+00F4 LATIN SMALL LETTER O WITH CIRCUMFLEX */
        XK_otilde = 0x00f5, /* U+00F5 LATIN SMALL LETTER O WITH TILDE */
        XK_odiaeresis = 0x00f6, /* U+00F6 LATIN SMALL LETTER O WITH DIAERESIS */
        XK_division = 0x00f7, /* U+00F7 DIVISION SIGN */
        XK_oslash = 0x00f8, /* U+00F8 LATIN SMALL LETTER O WITH STROKE */
        XK_ooblique = 0x00f8, /* U+00F8 LATIN SMALL LETTER O WITH STROKE */
        XK_ugrave = 0x00f9, /* U+00F9 LATIN SMALL LETTER U WITH GRAVE */
        XK_uacute = 0x00fa, /* U+00FA LATIN SMALL LETTER U WITH ACUTE */
        XK_ucircumflex = 0x00fb, /* U+00FB LATIN SMALL LETTER U WITH CIRCUMFLEX */
        XK_udiaeresis = 0x00fc, /* U+00FC LATIN SMALL LETTER U WITH DIAERESIS */
        XK_yacute = 0x00fd, /* U+00FD LATIN SMALL LETTER Y WITH ACUTE */
        XK_thorn = 0x00fe, /* U+00FE LATIN SMALL LETTER THORN */
        XK_ydiaeresis = 0x00ff, /* U+00FF LATIN SMALL LETTER Y WITH DIAERESIS */
                                //#endif /* XK_LATIN1 */
                                /*
                                 * Latin 2
                                 * Byte 3 = 1
                                 */
                                //#ifdef XK_LATIN2
        XK_Aogonek = 0x01a1, /* U+0104 LATIN CAPITAL LETTER A WITH OGONEK */
        XK_breve = 0x01a2, /* U+02D8 BREVE */
        XK_Lstroke = 0x01a3, /* U+0141 LATIN CAPITAL LETTER L WITH STROKE */
        XK_Lcaron = 0x01a5, /* U+013D LATIN CAPITAL LETTER L WITH CARON */
        XK_Sacute = 0x01a6, /* U+015A LATIN CAPITAL LETTER S WITH ACUTE */
        XK_Scaron = 0x01a9, /* U+0160 LATIN CAPITAL LETTER S WITH CARON */
        XK_Scedilla = 0x01aa, /* U+015E LATIN CAPITAL LETTER S WITH CEDILLA */
        XK_Tcaron = 0x01ab, /* U+0164 LATIN CAPITAL LETTER T WITH CARON */
        XK_Zacute = 0x01ac, /* U+0179 LATIN CAPITAL LETTER Z WITH ACUTE */
        XK_Zcaron = 0x01ae, /* U+017D LATIN CAPITAL LETTER Z WITH CARON */
        XK_Zabovedot = 0x01af, /* U+017B LATIN CAPITAL LETTER Z WITH DOT ABOVE */
        XK_aogonek = 0x01b1, /* U+0105 LATIN SMALL LETTER A WITH OGONEK */
        XK_ogonek = 0x01b2, /* U+02DB OGONEK */
        XK_lstroke = 0x01b3, /* U+0142 LATIN SMALL LETTER L WITH STROKE */
        XK_lcaron = 0x01b5, /* U+013E LATIN SMALL LETTER L WITH CARON */
        XK_sacute = 0x01b6, /* U+015B LATIN SMALL LETTER S WITH ACUTE */
        XK_caron = 0x01b7, /* U+02C7 CARON */
        XK_scaron = 0x01b9, /* U+0161 LATIN SMALL LETTER S WITH CARON */
        XK_scedilla = 0x01ba, /* U+015F LATIN SMALL LETTER S WITH CEDILLA */
        XK_tcaron = 0x01bb, /* U+0165 LATIN SMALL LETTER T WITH CARON */
        XK_zacute = 0x01bc, /* U+017A LATIN SMALL LETTER Z WITH ACUTE */
        XK_doubleacute = 0x01bd, /* U+02DD DOUBLE ACUTE ACCENT */
        XK_zcaron = 0x01be, /* U+017E LATIN SMALL LETTER Z WITH CARON */
        XK_zabovedot = 0x01bf, /* U+017C LATIN SMALL LETTER Z WITH DOT ABOVE */
        XK_Racute = 0x01c0, /* U+0154 LATIN CAPITAL LETTER R WITH ACUTE */
        XK_Abreve = 0x01c3, /* U+0102 LATIN CAPITAL LETTER A WITH BREVE */
        XK_Lacute = 0x01c5, /* U+0139 LATIN CAPITAL LETTER L WITH ACUTE */
        XK_Cacute = 0x01c6, /* U+0106 LATIN CAPITAL LETTER C WITH ACUTE */
        XK_Ccaron = 0x01c8, /* U+010C LATIN CAPITAL LETTER C WITH CARON */
        XK_Eogonek = 0x01ca, /* U+0118 LATIN CAPITAL LETTER E WITH OGONEK */
        XK_Ecaron = 0x01cc, /* U+011A LATIN CAPITAL LETTER E WITH CARON */
        XK_Dcaron = 0x01cf, /* U+010E LATIN CAPITAL LETTER D WITH CARON */
        XK_Dstroke = 0x01d0, /* U+0110 LATIN CAPITAL LETTER D WITH STROKE */
        XK_Nacute = 0x01d1, /* U+0143 LATIN CAPITAL LETTER N WITH ACUTE */
        XK_Ncaron = 0x01d2, /* U+0147 LATIN CAPITAL LETTER N WITH CARON */
        XK_Odoubleacute = 0x01d5, /* U+0150 LATIN CAPITAL LETTER O WITH DOUBLE ACUTE */
        XK_Rcaron = 0x01d8, /* U+0158 LATIN CAPITAL LETTER R WITH CARON */
        XK_Uring = 0x01d9, /* U+016E LATIN CAPITAL LETTER U WITH RING ABOVE */
        XK_Udoubleacute = 0x01db, /* U+0170 LATIN CAPITAL LETTER U WITH DOUBLE ACUTE */
        XK_Tcedilla = 0x01de, /* U+0162 LATIN CAPITAL LETTER T WITH CEDILLA */
        XK_racute = 0x01e0, /* U+0155 LATIN SMALL LETTER R WITH ACUTE */
        XK_abreve = 0x01e3, /* U+0103 LATIN SMALL LETTER A WITH BREVE */
        XK_lacute = 0x01e5, /* U+013A LATIN SMALL LETTER L WITH ACUTE */
        XK_cacute = 0x01e6, /* U+0107 LATIN SMALL LETTER C WITH ACUTE */
        XK_ccaron = 0x01e8, /* U+010D LATIN SMALL LETTER C WITH CARON */
        XK_eogonek = 0x01ea, /* U+0119 LATIN SMALL LETTER E WITH OGONEK */
        XK_ecaron = 0x01ec, /* U+011B LATIN SMALL LETTER E WITH CARON */
        XK_dcaron = 0x01ef, /* U+010F LATIN SMALL LETTER D WITH CARON */
        XK_dstroke = 0x01f0, /* U+0111 LATIN SMALL LETTER D WITH STROKE */
        XK_nacute = 0x01f1, /* U+0144 LATIN SMALL LETTER N WITH ACUTE */
        XK_ncaron = 0x01f2, /* U+0148 LATIN SMALL LETTER N WITH CARON */
        XK_odoubleacute = 0x01f5, /* U+0151 LATIN SMALL LETTER O WITH DOUBLE ACUTE */
        XK_udoubleacute = 0x01fb, /* U+0171 LATIN SMALL LETTER U WITH DOUBLE ACUTE */
        XK_rcaron = 0x01f8, /* U+0159 LATIN SMALL LETTER R WITH CARON */
        XK_uring = 0x01f9, /* U+016F LATIN SMALL LETTER U WITH RING ABOVE */
        XK_tcedilla = 0x01fe, /* U+0163 LATIN SMALL LETTER T WITH CEDILLA */
        XK_abovedot = 0x01ff, /* U+02D9 DOT ABOVE */
                              //#endif /* XK_LATIN2 */
                              /*
                               * Latin 3
                               * Byte 3 = 2
                               */
                              //#ifdef XK_LATIN3
        XK_Hstroke = 0x02a1, /* U+0126 LATIN CAPITAL LETTER H WITH STROKE */
        XK_Hcircumflex = 0x02a6, /* U+0124 LATIN CAPITAL LETTER H WITH CIRCUMFLEX */
        XK_Iabovedot = 0x02a9, /* U+0130 LATIN CAPITAL LETTER I WITH DOT ABOVE */
        XK_Gbreve = 0x02ab, /* U+011E LATIN CAPITAL LETTER G WITH BREVE */
        XK_Jcircumflex = 0x02ac, /* U+0134 LATIN CAPITAL LETTER J WITH CIRCUMFLEX */
        XK_hstroke = 0x02b1, /* U+0127 LATIN SMALL LETTER H WITH STROKE */
        XK_hcircumflex = 0x02b6, /* U+0125 LATIN SMALL LETTER H WITH CIRCUMFLEX */
        XK_idotless = 0x02b9, /* U+0131 LATIN SMALL LETTER DOTLESS I */
        XK_gbreve = 0x02bb, /* U+011F LATIN SMALL LETTER G WITH BREVE */
        XK_jcircumflex = 0x02bc, /* U+0135 LATIN SMALL LETTER J WITH CIRCUMFLEX */
        XK_Cabovedot = 0x02c5, /* U+010A LATIN CAPITAL LETTER C WITH DOT ABOVE */
        XK_Ccircumflex = 0x02c6, /* U+0108 LATIN CAPITAL LETTER C WITH CIRCUMFLEX */
        XK_Gabovedot = 0x02d5, /* U+0120 LATIN CAPITAL LETTER G WITH DOT ABOVE */
        XK_Gcircumflex = 0x02d8, /* U+011C LATIN CAPITAL LETTER G WITH CIRCUMFLEX */
        XK_Ubreve = 0x02dd, /* U+016C LATIN CAPITAL LETTER U WITH BREVE */
        XK_Scircumflex = 0x02de, /* U+015C LATIN CAPITAL LETTER S WITH CIRCUMFLEX */
        XK_cabovedot = 0x02e5, /* U+010B LATIN SMALL LETTER C WITH DOT ABOVE */
        XK_ccircumflex = 0x02e6, /* U+0109 LATIN SMALL LETTER C WITH CIRCUMFLEX */
        XK_gabovedot = 0x02f5, /* U+0121 LATIN SMALL LETTER G WITH DOT ABOVE */
        XK_gcircumflex = 0x02f8, /* U+011D LATIN SMALL LETTER G WITH CIRCUMFLEX */
        XK_ubreve = 0x02fd, /* U+016D LATIN SMALL LETTER U WITH BREVE */
        XK_scircumflex = 0x02fe, /* U+015D LATIN SMALL LETTER S WITH CIRCUMFLEX */
                                 //#endif /* XK_LATIN3 */
                                 /*
                                  * Latin 4
                                  * Byte 3 = 3
                                  */
                                 //#ifdef XK_LATIN4
        XK_kra = 0x03a2, /* U+0138 LATIN SMALL LETTER KRA */
        XK_kappa = 0x03a2, /* deprecated */
        XK_Rcedilla = 0x03a3, /* U+0156 LATIN CAPITAL LETTER R WITH CEDILLA */
        XK_Itilde = 0x03a5, /* U+0128 LATIN CAPITAL LETTER I WITH TILDE */
        XK_Lcedilla = 0x03a6, /* U+013B LATIN CAPITAL LETTER L WITH CEDILLA */
        XK_Emacron = 0x03aa, /* U+0112 LATIN CAPITAL LETTER E WITH MACRON */
        XK_Gcedilla = 0x03ab, /* U+0122 LATIN CAPITAL LETTER G WITH CEDILLA */
        XK_Tslash = 0x03ac, /* U+0166 LATIN CAPITAL LETTER T WITH STROKE */
        XK_rcedilla = 0x03b3, /* U+0157 LATIN SMALL LETTER R WITH CEDILLA */
        XK_itilde = 0x03b5, /* U+0129 LATIN SMALL LETTER I WITH TILDE */
        XK_lcedilla = 0x03b6, /* U+013C LATIN SMALL LETTER L WITH CEDILLA */
        XK_emacron = 0x03ba, /* U+0113 LATIN SMALL LETTER E WITH MACRON */
        XK_gcedilla = 0x03bb, /* U+0123 LATIN SMALL LETTER G WITH CEDILLA */
        XK_tslash = 0x03bc, /* U+0167 LATIN SMALL LETTER T WITH STROKE */
        XK_ENG = 0x03bd, /* U+014A LATIN CAPITAL LETTER ENG */
        XK_eng = 0x03bf, /* U+014B LATIN SMALL LETTER ENG */
        XK_Amacron = 0x03c0, /* U+0100 LATIN CAPITAL LETTER A WITH MACRON */
        XK_Iogonek = 0x03c7, /* U+012E LATIN CAPITAL LETTER I WITH OGONEK */
        XK_Eabovedot = 0x03cc, /* U+0116 LATIN CAPITAL LETTER E WITH DOT ABOVE */
        XK_Imacron = 0x03cf, /* U+012A LATIN CAPITAL LETTER I WITH MACRON */
        XK_Ncedilla = 0x03d1, /* U+0145 LATIN CAPITAL LETTER N WITH CEDILLA */
        XK_Omacron = 0x03d2, /* U+014C LATIN CAPITAL LETTER O WITH MACRON */
        XK_Kcedilla = 0x03d3, /* U+0136 LATIN CAPITAL LETTER K WITH CEDILLA */
        XK_Uogonek = 0x03d9, /* U+0172 LATIN CAPITAL LETTER U WITH OGONEK */
        XK_Utilde = 0x03dd, /* U+0168 LATIN CAPITAL LETTER U WITH TILDE */
        XK_Umacron = 0x03de, /* U+016A LATIN CAPITAL LETTER U WITH MACRON */
        XK_amacron = 0x03e0, /* U+0101 LATIN SMALL LETTER A WITH MACRON */
        XK_iogonek = 0x03e7, /* U+012F LATIN SMALL LETTER I WITH OGONEK */
        XK_eabovedot = 0x03ec, /* U+0117 LATIN SMALL LETTER E WITH DOT ABOVE */
        XK_imacron = 0x03ef, /* U+012B LATIN SMALL LETTER I WITH MACRON */
        XK_ncedilla = 0x03f1, /* U+0146 LATIN SMALL LETTER N WITH CEDILLA */
        XK_omacron = 0x03f2, /* U+014D LATIN SMALL LETTER O WITH MACRON */
        XK_kcedilla = 0x03f3, /* U+0137 LATIN SMALL LETTER K WITH CEDILLA */
        XK_uogonek = 0x03f9, /* U+0173 LATIN SMALL LETTER U WITH OGONEK */
        XK_utilde = 0x03fd, /* U+0169 LATIN SMALL LETTER U WITH TILDE */
        XK_umacron = 0x03fe, /* U+016B LATIN SMALL LETTER U WITH MACRON */
                             //#endif /* XK_LATIN4 */
                             /*
                              * Latin 8
                              */
                             //#ifdef XK_LATIN8
                             //XK_Babovedot = 0x1001e02, /* U+1E02 LATIN CAPITAL LETTER B WITH DOT ABOVE */
                             //XK_babovedot = 0x1001e03, /* U+1E03 LATIN SMALL LETTER B WITH DOT ABOVE */
                             //XK_Dabovedot = 0x1001e0a, /* U+1E0A LATIN CAPITAL LETTER D WITH DOT ABOVE */
                             //XK_Wgrave = 0x1001e80, /* U+1E80 LATIN CAPITAL LETTER W WITH GRAVE */
                             //XK_Wacute = 0x1001e82, /* U+1E82 LATIN CAPITAL LETTER W WITH ACUTE */
                             //XK_dabovedot = 0x1001e0b, /* U+1E0B LATIN SMALL LETTER D WITH DOT ABOVE */
                             //XK_Ygrave = 0x1001ef2, /* U+1EF2 LATIN CAPITAL LETTER Y WITH GRAVE */
                             //XK_Fabovedot = 0x1001e1e, /* U+1E1E LATIN CAPITAL LETTER F WITH DOT ABOVE */
                             //XK_fabovedot = 0x1001e1f, /* U+1E1F LATIN SMALL LETTER F WITH DOT ABOVE */
                             //XK_Mabovedot = 0x1001e40, /* U+1E40 LATIN CAPITAL LETTER M WITH DOT ABOVE */
                             //XK_mabovedot = 0x1001e41, /* U+1E41 LATIN SMALL LETTER M WITH DOT ABOVE */
                             //XK_Pabovedot = 0x1001e56, /* U+1E56 LATIN CAPITAL LETTER P WITH DOT ABOVE */
                             //XK_wgrave = 0x1001e81, /* U+1E81 LATIN SMALL LETTER W WITH GRAVE */
                             //XK_pabovedot = 0x1001e57, /* U+1E57 LATIN SMALL LETTER P WITH DOT ABOVE */
                             //XK_wacute = 0x1001e83, /* U+1E83 LATIN SMALL LETTER W WITH ACUTE */
                             //XK_Sabovedot = 0x1001e60, /* U+1E60 LATIN CAPITAL LETTER S WITH DOT ABOVE */
                             //XK_ygrave = 0x1001ef3, /* U+1EF3 LATIN SMALL LETTER Y WITH GRAVE */
                             //XK_Wdiaeresis = 0x1001e84, /* U+1E84 LATIN CAPITAL LETTER W WITH DIAERESIS */
                             //XK_wdiaeresis = 0x1001e85, /* U+1E85 LATIN SMALL LETTER W WITH DIAERESIS */
                             //XK_sabovedot = 0x1001e61, /* U+1E61 LATIN SMALL LETTER S WITH DOT ABOVE */
                             //XK_Wcircumflex = 0x1000174, /* U+0174 LATIN CAPITAL LETTER W WITH CIRCUMFLEX */
                             //XK_Tabovedot = 0x1001e6a, /* U+1E6A LATIN CAPITAL LETTER T WITH DOT ABOVE */
                             //XK_Ycircumflex = 0x1000176, /* U+0176 LATIN CAPITAL LETTER Y WITH CIRCUMFLEX */
                             //XK_wcircumflex = 0x1000175, /* U+0175 LATIN SMALL LETTER W WITH CIRCUMFLEX */
                             //XK_tabovedot = 0x1001e6b, /* U+1E6B LATIN SMALL LETTER T WITH DOT ABOVE */
                             //XK_ycircumflex = 0x1000177, /* U+0177 LATIN SMALL LETTER Y WITH CIRCUMFLEX */
                             //#endif /* XK_LATIN8 */
                             /*
                              * Latin 9
                              * Byte 3 = 0x13
                              */
                             //#ifdef XK_LATIN9
        XK_OE = 0x13bc, /* U+0152 LATIN CAPITAL LIGATURE OE */
        XK_oe = 0x13bd, /* U+0153 LATIN SMALL LIGATURE OE */
        XK_Ydiaeresis = 0x13be, /* U+0178 LATIN CAPITAL LETTER Y WITH DIAERESIS */
                                //#endif /* XK_LATIN9 */
                                /*
                                 * Katakana
                                 * Byte 3 = 4
                                 */
                                //#ifdef XK_KATAKANA
        XK_overline = 0x047e, /* U+203E OVERLINE */
        XK_kana_fullstop = 0x04a1, /* U+3002 IDEOGRAPHIC FULL STOP */
        XK_kana_openingbracket = 0x04a2, /* U+300C LEFT CORNER BRACKET */
        XK_kana_closingbracket = 0x04a3, /* U+300D RIGHT CORNER BRACKET */
        XK_kana_comma = 0x04a4, /* U+3001 IDEOGRAPHIC COMMA */
        XK_kana_conjunctive = 0x04a5, /* U+30FB KATAKANA MIDDLE DOT */
        XK_kana_middledot = 0x04a5, /* deprecated */
        XK_kana_WO = 0x04a6, /* U+30F2 KATAKANA LETTER WO */
        XK_kana_a = 0x04a7, /* U+30A1 KATAKANA LETTER SMALL A */
        XK_kana_i = 0x04a8, /* U+30A3 KATAKANA LETTER SMALL I */
        XK_kana_u = 0x04a9, /* U+30A5 KATAKANA LETTER SMALL U */
        XK_kana_e = 0x04aa, /* U+30A7 KATAKANA LETTER SMALL E */
        XK_kana_o = 0x04ab, /* U+30A9 KATAKANA LETTER SMALL O */
        XK_kana_ya = 0x04ac, /* U+30E3 KATAKANA LETTER SMALL YA */
        XK_kana_yu = 0x04ad, /* U+30E5 KATAKANA LETTER SMALL YU */
        XK_kana_yo = 0x04ae, /* U+30E7 KATAKANA LETTER SMALL YO */
        XK_kana_tsu = 0x04af, /* U+30C3 KATAKANA LETTER SMALL TU */
        XK_kana_tu = 0x04af, /* deprecated */
        XK_prolongedsound = 0x04b0, /* U+30FC KATAKANA-HIRAGANA PROLONGED SOUND MARK */
        XK_kana_A = 0x04b1, /* U+30A2 KATAKANA LETTER A */
        XK_kana_I = 0x04b2, /* U+30A4 KATAKANA LETTER I */
        XK_kana_U = 0x04b3, /* U+30A6 KATAKANA LETTER U */
        XK_kana_E = 0x04b4, /* U+30A8 KATAKANA LETTER E */
        XK_kana_O = 0x04b5, /* U+30AA KATAKANA LETTER O */
        XK_kana_KA = 0x04b6, /* U+30AB KATAKANA LETTER KA */
        XK_kana_KI = 0x04b7, /* U+30AD KATAKANA LETTER KI */
        XK_kana_KU = 0x04b8, /* U+30AF KATAKANA LETTER KU */
        XK_kana_KE = 0x04b9, /* U+30B1 KATAKANA LETTER KE */
        XK_kana_KO = 0x04ba, /* U+30B3 KATAKANA LETTER KO */
        XK_kana_SA = 0x04bb, /* U+30B5 KATAKANA LETTER SA */
        XK_kana_SHI = 0x04bc, /* U+30B7 KATAKANA LETTER SI */
        XK_kana_SU = 0x04bd, /* U+30B9 KATAKANA LETTER SU */
        XK_kana_SE = 0x04be, /* U+30BB KATAKANA LETTER SE */
        XK_kana_SO = 0x04bf, /* U+30BD KATAKANA LETTER SO */
        XK_kana_TA = 0x04c0, /* U+30BF KATAKANA LETTER TA */
        XK_kana_CHI = 0x04c1, /* U+30C1 KATAKANA LETTER TI */
        XK_kana_TI = 0x04c1, /* deprecated */
        XK_kana_TSU = 0x04c2, /* U+30C4 KATAKANA LETTER TU */
        XK_kana_TU = 0x04c2, /* deprecated */
        XK_kana_TE = 0x04c3, /* U+30C6 KATAKANA LETTER TE */
        XK_kana_TO = 0x04c4, /* U+30C8 KATAKANA LETTER TO */
        XK_kana_NA = 0x04c5, /* U+30CA KATAKANA LETTER NA */
        XK_kana_NI = 0x04c6, /* U+30CB KATAKANA LETTER NI */
        XK_kana_NU = 0x04c7, /* U+30CC KATAKANA LETTER NU */
        XK_kana_NE = 0x04c8, /* U+30CD KATAKANA LETTER NE */
        XK_kana_NO = 0x04c9, /* U+30CE KATAKANA LETTER NO */
        XK_kana_HA = 0x04ca, /* U+30CF KATAKANA LETTER HA */
        XK_kana_HI = 0x04cb, /* U+30D2 KATAKANA LETTER HI */
        XK_kana_FU = 0x04cc, /* U+30D5 KATAKANA LETTER HU */
        XK_kana_HU = 0x04cc, /* deprecated */
        XK_kana_HE = 0x04cd, /* U+30D8 KATAKANA LETTER HE */
        XK_kana_HO = 0x04ce, /* U+30DB KATAKANA LETTER HO */
        XK_kana_MA = 0x04cf, /* U+30DE KATAKANA LETTER MA */
        XK_kana_MI = 0x04d0, /* U+30DF KATAKANA LETTER MI */
        XK_kana_MU = 0x04d1, /* U+30E0 KATAKANA LETTER MU */
        XK_kana_ME = 0x04d2, /* U+30E1 KATAKANA LETTER ME */
        XK_kana_MO = 0x04d3, /* U+30E2 KATAKANA LETTER MO */
        XK_kana_YA = 0x04d4, /* U+30E4 KATAKANA LETTER YA */
        XK_kana_YU = 0x04d5, /* U+30E6 KATAKANA LETTER YU */
        XK_kana_YO = 0x04d6, /* U+30E8 KATAKANA LETTER YO */
        XK_kana_RA = 0x04d7, /* U+30E9 KATAKANA LETTER RA */
        XK_kana_RI = 0x04d8, /* U+30EA KATAKANA LETTER RI */
        XK_kana_RU = 0x04d9, /* U+30EB KATAKANA LETTER RU */
        XK_kana_RE = 0x04da, /* U+30EC KATAKANA LETTER RE */
        XK_kana_RO = 0x04db, /* U+30ED KATAKANA LETTER RO */
        XK_kana_WA = 0x04dc, /* U+30EF KATAKANA LETTER WA */
        XK_kana_N = 0x04dd, /* U+30F3 KATAKANA LETTER N */
        XK_voicedsound = 0x04de, /* U+309B KATAKANA-HIRAGANA VOICED SOUND MARK */
        XK_semivoicedsound = 0x04df, /* U+309C KATAKANA-HIRAGANA SEMI-VOICED SOUND MARK */
        XK_kana_switch = 0xff7e, /* Alias for mode_switch */
                                 //#endif /* XK_KATAKANA */
                                 /*
                                  * Arabic
                                  * Byte 3 = 5
                                  */
                                 //#ifdef XK_ARABIC
                                 //XK_Farsi_0 = 0x10006f0, /* U+06F0 EXTENDED ARABIC-INDIC DIGIT ZERO */
                                 //XK_Farsi_1 = 0x10006f1, /* U+06F1 EXTENDED ARABIC-INDIC DIGIT ONE */
                                 //XK_Farsi_2 = 0x10006f2, /* U+06F2 EXTENDED ARABIC-INDIC DIGIT TWO */
                                 //XK_Farsi_3 = 0x10006f3, /* U+06F3 EXTENDED ARABIC-INDIC DIGIT THREE */
                                 //XK_Farsi_4 = 0x10006f4, /* U+06F4 EXTENDED ARABIC-INDIC DIGIT FOUR */
                                 //XK_Farsi_5 = 0x10006f5, /* U+06F5 EXTENDED ARABIC-INDIC DIGIT FIVE */
                                 //XK_Farsi_6 = 0x10006f6, /* U+06F6 EXTENDED ARABIC-INDIC DIGIT SIX */
                                 //XK_Farsi_7 = 0x10006f7, /* U+06F7 EXTENDED ARABIC-INDIC DIGIT SEVEN */
                                 //XK_Farsi_8 = 0x10006f8, /* U+06F8 EXTENDED ARABIC-INDIC DIGIT EIGHT */
                                 //XK_Farsi_9 = 0x10006f9, /* U+06F9 EXTENDED ARABIC-INDIC DIGIT NINE */
                                 //XK_Arabic_percent = 0x100066a, /* U+066A ARABIC PERCENT SIGN */
                                 //XK_Arabic_superscript_alef = 0x1000670, /* U+0670 ARABIC LETTER SUPERSCRIPT ALEF */
                                 //XK_Arabic_tteh = 0x1000679, /* U+0679 ARABIC LETTER TTEH */
                                 //XK_Arabic_peh = 0x100067e, /* U+067E ARABIC LETTER PEH */
                                 //XK_Arabic_tcheh = 0x1000686, /* U+0686 ARABIC LETTER TCHEH */
                                 //XK_Arabic_ddal = 0x1000688, /* U+0688 ARABIC LETTER DDAL */
                                 //XK_Arabic_rreh = 0x1000691, /* U+0691 ARABIC LETTER RREH */
                                 //XK_Arabic_comma = 0x05ac, /* U+060C ARABIC COMMA */
                                 //XK_Arabic_fullstop = 0x10006d4, /* U+06D4 ARABIC FULL STOP */
                                 //XK_Arabic_0 = 0x1000660, /* U+0660 ARABIC-INDIC DIGIT ZERO */
                                 //XK_Arabic_1 = 0x1000661, /* U+0661 ARABIC-INDIC DIGIT ONE */
                                 //XK_Arabic_2 = 0x1000662, /* U+0662 ARABIC-INDIC DIGIT TWO */
                                 //XK_Arabic_3 = 0x1000663, /* U+0663 ARABIC-INDIC DIGIT THREE */
                                 //XK_Arabic_4 = 0x1000664, /* U+0664 ARABIC-INDIC DIGIT FOUR */
                                 //XK_Arabic_5 = 0x1000665, /* U+0665 ARABIC-INDIC DIGIT FIVE */
                                 //XK_Arabic_6 = 0x1000666, /* U+0666 ARABIC-INDIC DIGIT SIX */
                                 //XK_Arabic_7 = 0x1000667, /* U+0667 ARABIC-INDIC DIGIT SEVEN */
                                 //XK_Arabic_8 = 0x1000668, /* U+0668 ARABIC-INDIC DIGIT EIGHT */
                                 //XK_Arabic_9 = 0x1000669, /* U+0669 ARABIC-INDIC DIGIT NINE */
                                 //XK_Arabic_semicolon = 0x05bb, /* U+061B ARABIC SEMICOLON */
                                 //XK_Arabic_question_mark = 0x05bf, /* U+061F ARABIC QUESTION MARK */
                                 //XK_Arabic_hamza = 0x05c1, /* U+0621 ARABIC LETTER HAMZA */
                                 //XK_Arabic_maddaonalef = 0x05c2, /* U+0622 ARABIC LETTER ALEF WITH MADDA ABOVE */
                                 //XK_Arabic_hamzaonalef = 0x05c3, /* U+0623 ARABIC LETTER ALEF WITH HAMZA ABOVE */
                                 //XK_Arabic_hamzaonwaw = 0x05c4, /* U+0624 ARABIC LETTER WAW WITH HAMZA ABOVE */
                                 //XK_Arabic_hamzaunderalef = 0x05c5, /* U+0625 ARABIC LETTER ALEF WITH HAMZA BELOW */
                                 //XK_Arabic_hamzaonyeh = 0x05c6, /* U+0626 ARABIC LETTER YEH WITH HAMZA ABOVE */
                                 //XK_Arabic_alef = 0x05c7, /* U+0627 ARABIC LETTER ALEF */
                                 //XK_Arabic_beh = 0x05c8, /* U+0628 ARABIC LETTER BEH */
                                 //XK_Arabic_tehmarbuta = 0x05c9, /* U+0629 ARABIC LETTER TEH MARBUTA */
                                 //XK_Arabic_teh = 0x05ca, /* U+062A ARABIC LETTER TEH */
                                 //XK_Arabic_theh = 0x05cb, /* U+062B ARABIC LETTER THEH */
                                 //XK_Arabic_jeem = 0x05cc, /* U+062C ARABIC LETTER JEEM */
                                 //XK_Arabic_hah = 0x05cd, /* U+062D ARABIC LETTER HAH */
                                 //XK_Arabic_khah = 0x05ce, /* U+062E ARABIC LETTER KHAH */
                                 //XK_Arabic_dal = 0x05cf, /* U+062F ARABIC LETTER DAL */
                                 //XK_Arabic_thal = 0x05d0, /* U+0630 ARABIC LETTER THAL */
                                 //XK_Arabic_ra = 0x05d1, /* U+0631 ARABIC LETTER REH */
                                 //XK_Arabic_zain = 0x05d2, /* U+0632 ARABIC LETTER ZAIN */
                                 //XK_Arabic_seen = 0x05d3, /* U+0633 ARABIC LETTER SEEN */
                                 //XK_Arabic_sheen = 0x05d4, /* U+0634 ARABIC LETTER SHEEN */
                                 //XK_Arabic_sad = 0x05d5, /* U+0635 ARABIC LETTER SAD */
                                 //XK_Arabic_dad = 0x05d6, /* U+0636 ARABIC LETTER DAD */
                                 //XK_Arabic_tah = 0x05d7, /* U+0637 ARABIC LETTER TAH */
                                 //XK_Arabic_zah = 0x05d8, /* U+0638 ARABIC LETTER ZAH */
                                 //XK_Arabic_ain = 0x05d9, /* U+0639 ARABIC LETTER AIN */
                                 //XK_Arabic_ghain = 0x05da, /* U+063A ARABIC LETTER GHAIN */
                                 //XK_Arabic_tatweel = 0x05e0, /* U+0640 ARABIC TATWEEL */
                                 //XK_Arabic_feh = 0x05e1, /* U+0641 ARABIC LETTER FEH */
                                 //XK_Arabic_qaf = 0x05e2, /* U+0642 ARABIC LETTER QAF */
                                 //XK_Arabic_kaf = 0x05e3, /* U+0643 ARABIC LETTER KAF */
                                 //XK_Arabic_lam = 0x05e4, /* U+0644 ARABIC LETTER LAM */
                                 //XK_Arabic_meem = 0x05e5, /* U+0645 ARABIC LETTER MEEM */
                                 //XK_Arabic_noon = 0x05e6, /* U+0646 ARABIC LETTER NOON */
                                 //XK_Arabic_ha = 0x05e7, /* U+0647 ARABIC LETTER HEH */
                                 //XK_Arabic_heh = 0x05e7, /* deprecated */
                                 //XK_Arabic_waw = 0x05e8, /* U+0648 ARABIC LETTER WAW */
                                 //XK_Arabic_alefmaksura = 0x05e9, /* U+0649 ARABIC LETTER ALEF MAKSURA */
                                 //XK_Arabic_yeh = 0x05ea, /* U+064A ARABIC LETTER YEH */
                                 //XK_Arabic_fathatan = 0x05eb, /* U+064B ARABIC FATHATAN */
                                 //XK_Arabic_dammatan = 0x05ec, /* U+064C ARABIC DAMMATAN */
                                 //XK_Arabic_kasratan = 0x05ed, /* U+064D ARABIC KASRATAN */
                                 //XK_Arabic_fatha = 0x05ee, /* U+064E ARABIC FATHA */
                                 //XK_Arabic_damma = 0x05ef, /* U+064F ARABIC DAMMA */
                                 //XK_Arabic_kasra = 0x05f0, /* U+0650 ARABIC KASRA */
                                 //XK_Arabic_shadda = 0x05f1, /* U+0651 ARABIC SHADDA */
                                 //XK_Arabic_sukun = 0x05f2, /* U+0652 ARABIC SUKUN */
                                 //XK_Arabic_madda_above = 0x1000653, /* U+0653 ARABIC MADDAH ABOVE */
                                 //XK_Arabic_hamza_above = 0x1000654, /* U+0654 ARABIC HAMZA ABOVE */
                                 //XK_Arabic_hamza_below = 0x1000655, /* U+0655 ARABIC HAMZA BELOW */
                                 //XK_Arabic_jeh = 0x1000698, /* U+0698 ARABIC LETTER JEH */
                                 //XK_Arabic_veh = 0x10006a4, /* U+06A4 ARABIC LETTER VEH */
                                 //XK_Arabic_keheh = 0x10006a9, /* U+06A9 ARABIC LETTER KEHEH */
                                 //XK_Arabic_gaf = 0x10006af, /* U+06AF ARABIC LETTER GAF */
                                 //XK_Arabic_noon_ghunna = 0x10006ba, /* U+06BA ARABIC LETTER NOON GHUNNA */
                                 //XK_Arabic_heh_doachashmee = 0x10006be, /* U+06BE ARABIC LETTER HEH DOACHASHMEE */
                                 //XK_Farsi_yeh = 0x10006cc, /* U+06CC ARABIC LETTER FARSI YEH */
                                 //XK_Arabic_farsi_yeh = 0x10006cc, /* U+06CC ARABIC LETTER FARSI YEH */
                                 //XK_Arabic_yeh_baree = 0x10006d2, /* U+06D2 ARABIC LETTER YEH BARREE */
                                 //XK_Arabic_heh_goal = 0x10006c1, /* U+06C1 ARABIC LETTER HEH GOAL */
                                 //XK_Arabic_switch = 0xff7e, /* Alias for mode_switch */
                                 //#endif /* XK_ARABIC */
                                 /*
                                  * Cyrillic
                                  * Byte 3 = 6
                                  */
                                 //#ifdef XK_CYRILLIC
                                 //XK_Cyrillic_GHE_bar = 0x1000492, /* U+0492 CYRILLIC CAPITAL LETTER GHE WITH STROKE */
                                 //XK_Cyrillic_ghe_bar = 0x1000493, /* U+0493 CYRILLIC SMALL LETTER GHE WITH STROKE */
                                 //XK_Cyrillic_ZHE_descender = 0x1000496, /* U+0496 CYRILLIC CAPITAL LETTER ZHE WITH DESCENDER */
                                 //XK_Cyrillic_zhe_descender = 0x1000497, /* U+0497 CYRILLIC SMALL LETTER ZHE WITH DESCENDER */
                                 //XK_Cyrillic_KA_descender = 0x100049a, /* U+049A CYRILLIC CAPITAL LETTER KA WITH DESCENDER */
                                 //XK_Cyrillic_ka_descender = 0x100049b, /* U+049B CYRILLIC SMALL LETTER KA WITH DESCENDER */
                                 //XK_Cyrillic_KA_vertstroke = 0x100049c, /* U+049C CYRILLIC CAPITAL LETTER KA WITH VERTICAL STROKE */
                                 //XK_Cyrillic_ka_vertstroke = 0x100049d, /* U+049D CYRILLIC SMALL LETTER KA WITH VERTICAL STROKE */
                                 //XK_Cyrillic_EN_descender = 0x10004a2, /* U+04A2 CYRILLIC CAPITAL LETTER EN WITH DESCENDER */
                                 //XK_Cyrillic_en_descender = 0x10004a3, /* U+04A3 CYRILLIC SMALL LETTER EN WITH DESCENDER */
                                 //XK_Cyrillic_U_straight = 0x10004ae, /* U+04AE CYRILLIC CAPITAL LETTER STRAIGHT U */
                                 //XK_Cyrillic_u_straight = 0x10004af, /* U+04AF CYRILLIC SMALL LETTER STRAIGHT U */
                                 //XK_Cyrillic_U_straight_bar = 0x10004b0, /* U+04B0 CYRILLIC CAPITAL LETTER STRAIGHT U WITH STROKE */
                                 //XK_Cyrillic_u_straight_bar = 0x10004b1, /* U+04B1 CYRILLIC SMALL LETTER STRAIGHT U WITH STROKE */
                                 //XK_Cyrillic_HA_descender = 0x10004b2, /* U+04B2 CYRILLIC CAPITAL LETTER HA WITH DESCENDER */
                                 //XK_Cyrillic_ha_descender = 0x10004b3, /* U+04B3 CYRILLIC SMALL LETTER HA WITH DESCENDER */
                                 //XK_Cyrillic_CHE_descender = 0x10004b6, /* U+04B6 CYRILLIC CAPITAL LETTER CHE WITH DESCENDER */
                                 //XK_Cyrillic_che_descender = 0x10004b7, /* U+04B7 CYRILLIC SMALL LETTER CHE WITH DESCENDER */
                                 //XK_Cyrillic_CHE_vertstroke = 0x10004b8, /* U+04B8 CYRILLIC CAPITAL LETTER CHE WITH VERTICAL STROKE */
                                 //XK_Cyrillic_che_vertstroke = 0x10004b9, /* U+04B9 CYRILLIC SMALL LETTER CHE WITH VERTICAL STROKE */
                                 //XK_Cyrillic_SHHA = 0x10004ba, /* U+04BA CYRILLIC CAPITAL LETTER SHHA */
                                 //XK_Cyrillic_shha = 0x10004bb, /* U+04BB CYRILLIC SMALL LETTER SHHA */
                                 //XK_Cyrillic_SCHWA = 0x10004d8, /* U+04D8 CYRILLIC CAPITAL LETTER SCHWA */
                                 //XK_Cyrillic_schwa = 0x10004d9, /* U+04D9 CYRILLIC SMALL LETTER SCHWA */
                                 //XK_Cyrillic_I_macron = 0x10004e2, /* U+04E2 CYRILLIC CAPITAL LETTER I WITH MACRON */
                                 //XK_Cyrillic_i_macron = 0x10004e3, /* U+04E3 CYRILLIC SMALL LETTER I WITH MACRON */
                                 //XK_Cyrillic_O_bar = 0x10004e8, /* U+04E8 CYRILLIC CAPITAL LETTER BARRED O */
                                 //XK_Cyrillic_o_bar = 0x10004e9, /* U+04E9 CYRILLIC SMALL LETTER BARRED O */
                                 //XK_Cyrillic_U_macron = 0x10004ee, /* U+04EE CYRILLIC CAPITAL LETTER U WITH MACRON */
                                 //XK_Cyrillic_u_macron = 0x10004ef, /* U+04EF CYRILLIC SMALL LETTER U WITH MACRON */
                                 //XK_Serbian_dje = 0x06a1, /* U+0452 CYRILLIC SMALL LETTER DJE */
                                 //XK_Macedonia_gje = 0x06a2, /* U+0453 CYRILLIC SMALL LETTER GJE */
                                 //XK_Cyrillic_io = 0x06a3, /* U+0451 CYRILLIC SMALL LETTER IO */
                                 //XK_Ukrainian_ie = 0x06a4, /* U+0454 CYRILLIC SMALL LETTER UKRAINIAN IE */
                                 //XK_Ukranian_je = 0x06a4, /* deprecated */
                                 //XK_Macedonia_dse = 0x06a5, /* U+0455 CYRILLIC SMALL LETTER DZE */
                                 //XK_Ukrainian_i = 0x06a6, /* U+0456 CYRILLIC SMALL LETTER BYELORUSSIAN-UKRAINIAN I */
                                 //XK_Ukranian_i = 0x06a6, /* deprecated */
                                 //XK_Ukrainian_yi = 0x06a7, /* U+0457 CYRILLIC SMALL LETTER YI */
                                 //XK_Ukranian_yi = 0x06a7, /* deprecated */
                                 //XK_Cyrillic_je = 0x06a8, /* U+0458 CYRILLIC SMALL LETTER JE */
                                 //XK_Serbian_je = 0x06a8, /* deprecated */
                                 //XK_Cyrillic_lje = 0x06a9, /* U+0459 CYRILLIC SMALL LETTER LJE */
                                 //XK_Serbian_lje = 0x06a9, /* deprecated */
                                 //XK_Cyrillic_nje = 0x06aa, /* U+045A CYRILLIC SMALL LETTER NJE */
                                 //XK_Serbian_nje = 0x06aa, /* deprecated */
                                 //XK_Serbian_tshe = 0x06ab, /* U+045B CYRILLIC SMALL LETTER TSHE */
                                 //XK_Macedonia_kje = 0x06ac, /* U+045C CYRILLIC SMALL LETTER KJE */
                                 //XK_Ukrainian_ghe_with_upturn = 0x06ad, /* U+0491 CYRILLIC SMALL LETTER GHE WITH UPTURN */
                                 //XK_Byelorussian_shortu = 0x06ae, /* U+045E CYRILLIC SMALL LETTER SHORT U */
                                 //XK_Cyrillic_dzhe = 0x06af, /* U+045F CYRILLIC SMALL LETTER DZHE */
                                 //XK_Serbian_dze = 0x06af, /* deprecated */
                                 //XK_numerosign = 0x06b0, /* U+2116 NUMERO SIGN */
                                 //XK_Serbian_DJE = 0x06b1, /* U+0402 CYRILLIC CAPITAL LETTER DJE */
                                 //XK_Macedonia_GJE = 0x06b2, /* U+0403 CYRILLIC CAPITAL LETTER GJE */
                                 //XK_Cyrillic_IO = 0x06b3, /* U+0401 CYRILLIC CAPITAL LETTER IO */
                                 //XK_Ukrainian_IE = 0x06b4, /* U+0404 CYRILLIC CAPITAL LETTER UKRAINIAN IE */
                                 //XK_Ukranian_JE = 0x06b4, /* deprecated */
                                 //XK_Macedonia_DSE = 0x06b5, /* U+0405 CYRILLIC CAPITAL LETTER DZE */
                                 //XK_Ukrainian_I = 0x06b6, /* U+0406 CYRILLIC CAPITAL LETTER BYELORUSSIAN-UKRAINIAN I */
                                 //XK_Ukranian_I = 0x06b6, /* deprecated */
                                 //XK_Ukrainian_YI = 0x06b7, /* U+0407 CYRILLIC CAPITAL LETTER YI */
                                 //XK_Ukranian_YI = 0x06b7, /* deprecated */
                                 //XK_Cyrillic_JE = 0x06b8, /* U+0408 CYRILLIC CAPITAL LETTER JE */
                                 //XK_Serbian_JE = 0x06b8, /* deprecated */
                                 //XK_Cyrillic_LJE = 0x06b9, /* U+0409 CYRILLIC CAPITAL LETTER LJE */
                                 //XK_Serbian_LJE = 0x06b9, /* deprecated */
                                 //XK_Cyrillic_NJE = 0x06ba, /* U+040A CYRILLIC CAPITAL LETTER NJE */
                                 //XK_Serbian_NJE = 0x06ba, /* deprecated */
                                 //XK_Serbian_TSHE = 0x06bb, /* U+040B CYRILLIC CAPITAL LETTER TSHE */
                                 //XK_Macedonia_KJE = 0x06bc, /* U+040C CYRILLIC CAPITAL LETTER KJE */
                                 //XK_Ukrainian_GHE_WITH_UPTURN = 0x06bd, /* U+0490 CYRILLIC CAPITAL LETTER GHE WITH UPTURN */
                                 //XK_Byelorussian_SHORTU = 0x06be, /* U+040E CYRILLIC CAPITAL LETTER SHORT U */
                                 //XK_Cyrillic_DZHE = 0x06bf, /* U+040F CYRILLIC CAPITAL LETTER DZHE */
                                 //XK_Serbian_DZE = 0x06bf, /* deprecated */
                                 //XK_Cyrillic_yu = 0x06c0, /* U+044E CYRILLIC SMALL LETTER YU */
                                 //XK_Cyrillic_a = 0x06c1, /* U+0430 CYRILLIC SMALL LETTER A */
                                 //XK_Cyrillic_be = 0x06c2, /* U+0431 CYRILLIC SMALL LETTER BE */
                                 //XK_Cyrillic_tse = 0x06c3, /* U+0446 CYRILLIC SMALL LETTER TSE */
                                 //XK_Cyrillic_de = 0x06c4, /* U+0434 CYRILLIC SMALL LETTER DE */
                                 //XK_Cyrillic_ie = 0x06c5, /* U+0435 CYRILLIC SMALL LETTER IE */
                                 //XK_Cyrillic_ef = 0x06c6, /* U+0444 CYRILLIC SMALL LETTER EF */
                                 //XK_Cyrillic_ghe = 0x06c7, /* U+0433 CYRILLIC SMALL LETTER GHE */
                                 //XK_Cyrillic_ha = 0x06c8, /* U+0445 CYRILLIC SMALL LETTER HA */
                                 //XK_Cyrillic_i = 0x06c9, /* U+0438 CYRILLIC SMALL LETTER I */
                                 //XK_Cyrillic_shorti = 0x06ca, /* U+0439 CYRILLIC SMALL LETTER SHORT I */
                                 //XK_Cyrillic_ka = 0x06cb, /* U+043A CYRILLIC SMALL LETTER KA */
                                 //XK_Cyrillic_el = 0x06cc, /* U+043B CYRILLIC SMALL LETTER EL */
                                 //XK_Cyrillic_em = 0x06cd, /* U+043C CYRILLIC SMALL LETTER EM */
                                 //XK_Cyrillic_en = 0x06ce, /* U+043D CYRILLIC SMALL LETTER EN */
                                 //XK_Cyrillic_o = 0x06cf, /* U+043E CYRILLIC SMALL LETTER O */
                                 //XK_Cyrillic_pe = 0x06d0, /* U+043F CYRILLIC SMALL LETTER PE */
                                 //XK_Cyrillic_ya = 0x06d1, /* U+044F CYRILLIC SMALL LETTER YA */
                                 //XK_Cyrillic_er = 0x06d2, /* U+0440 CYRILLIC SMALL LETTER ER */
                                 //XK_Cyrillic_es = 0x06d3, /* U+0441 CYRILLIC SMALL LETTER ES */
                                 //XK_Cyrillic_te = 0x06d4, /* U+0442 CYRILLIC SMALL LETTER TE */
                                 //XK_Cyrillic_u = 0x06d5, /* U+0443 CYRILLIC SMALL LETTER U */
                                 //XK_Cyrillic_zhe = 0x06d6, /* U+0436 CYRILLIC SMALL LETTER ZHE */
                                 //XK_Cyrillic_ve = 0x06d7, /* U+0432 CYRILLIC SMALL LETTER VE */
                                 //XK_Cyrillic_softsign = 0x06d8, /* U+044C CYRILLIC SMALL LETTER SOFT SIGN */
                                 //XK_Cyrillic_yeru = 0x06d9, /* U+044B CYRILLIC SMALL LETTER YERU */
                                 //XK_Cyrillic_ze = 0x06da, /* U+0437 CYRILLIC SMALL LETTER ZE */
                                 //XK_Cyrillic_sha = 0x06db, /* U+0448 CYRILLIC SMALL LETTER SHA */
                                 //XK_Cyrillic_e = 0x06dc, /* U+044D CYRILLIC SMALL LETTER E */
                                 //XK_Cyrillic_shcha = 0x06dd, /* U+0449 CYRILLIC SMALL LETTER SHCHA */
                                 //XK_Cyrillic_che = 0x06de, /* U+0447 CYRILLIC SMALL LETTER CHE */
                                 //XK_Cyrillic_hardsign = 0x06df, /* U+044A CYRILLIC SMALL LETTER HARD SIGN */
                                 //XK_Cyrillic_YU = 0x06e0, /* U+042E CYRILLIC CAPITAL LETTER YU */
                                 //XK_Cyrillic_A = 0x06e1, /* U+0410 CYRILLIC CAPITAL LETTER A */
                                 //XK_Cyrillic_BE = 0x06e2, /* U+0411 CYRILLIC CAPITAL LETTER BE */
                                 //XK_Cyrillic_TSE = 0x06e3, /* U+0426 CYRILLIC CAPITAL LETTER TSE */
                                 //XK_Cyrillic_DE = 0x06e4, /* U+0414 CYRILLIC CAPITAL LETTER DE */
                                 //XK_Cyrillic_IE = 0x06e5, /* U+0415 CYRILLIC CAPITAL LETTER IE */
                                 //XK_Cyrillic_EF = 0x06e6, /* U+0424 CYRILLIC CAPITAL LETTER EF */
                                 //XK_Cyrillic_GHE = 0x06e7, /* U+0413 CYRILLIC CAPITAL LETTER GHE */
                                 //XK_Cyrillic_HA = 0x06e8, /* U+0425 CYRILLIC CAPITAL LETTER HA */
                                 //XK_Cyrillic_I = 0x06e9, /* U+0418 CYRILLIC CAPITAL LETTER I */
                                 //XK_Cyrillic_SHORTI = 0x06ea, /* U+0419 CYRILLIC CAPITAL LETTER SHORT I */
                                 //XK_Cyrillic_KA = 0x06eb, /* U+041A CYRILLIC CAPITAL LETTER KA */
                                 //XK_Cyrillic_EL = 0x06ec, /* U+041B CYRILLIC CAPITAL LETTER EL */
                                 //XK_Cyrillic_EM = 0x06ed, /* U+041C CYRILLIC CAPITAL LETTER EM */
                                 //XK_Cyrillic_EN = 0x06ee, /* U+041D CYRILLIC CAPITAL LETTER EN */
                                 //XK_Cyrillic_O = 0x06ef, /* U+041E CYRILLIC CAPITAL LETTER O */
                                 //XK_Cyrillic_PE = 0x06f0, /* U+041F CYRILLIC CAPITAL LETTER PE */
                                 //XK_Cyrillic_YA = 0x06f1, /* U+042F CYRILLIC CAPITAL LETTER YA */
                                 //XK_Cyrillic_ER = 0x06f2, /* U+0420 CYRILLIC CAPITAL LETTER ER */
                                 //XK_Cyrillic_ES = 0x06f3, /* U+0421 CYRILLIC CAPITAL LETTER ES */
                                 //XK_Cyrillic_TE = 0x06f4, /* U+0422 CYRILLIC CAPITAL LETTER TE */
                                 //XK_Cyrillic_U = 0x06f5, /* U+0423 CYRILLIC CAPITAL LETTER U */
                                 //XK_Cyrillic_ZHE = 0x06f6, /* U+0416 CYRILLIC CAPITAL LETTER ZHE */
                                 //XK_Cyrillic_VE = 0x06f7, /* U+0412 CYRILLIC CAPITAL LETTER VE */
                                 //XK_Cyrillic_SOFTSIGN = 0x06f8, /* U+042C CYRILLIC CAPITAL LETTER SOFT SIGN */
                                 //XK_Cyrillic_YERU = 0x06f9, /* U+042B CYRILLIC CAPITAL LETTER YERU */
                                 //XK_Cyrillic_ZE = 0x06fa, /* U+0417 CYRILLIC CAPITAL LETTER ZE */
                                 //XK_Cyrillic_SHA = 0x06fb, /* U+0428 CYRILLIC CAPITAL LETTER SHA */
                                 //XK_Cyrillic_E = 0x06fc, /* U+042D CYRILLIC CAPITAL LETTER E */
                                 //XK_Cyrillic_SHCHA = 0x06fd, /* U+0429 CYRILLIC CAPITAL LETTER SHCHA */
                                 //XK_Cyrillic_CHE = 0x06fe, /* U+0427 CYRILLIC CAPITAL LETTER CHE */
                                 //XK_Cyrillic_HARDSIGN = 0x06ff, /* U+042A CYRILLIC CAPITAL LETTER HARD SIGN */
                                 //#endif /* XK_CYRILLIC */
                                 /*
                                  * Greek
                                  * (based on an early draft of, and not quite identical to, ISO/IEC 8859-7)
                                  * Byte 3 = 7
                                  */
                                 //#ifdef XK_GREEK
                                 //XK_Greek_ALPHAaccent = 0x07a1, /* U+0386 GREEK CAPITAL LETTER ALPHA WITH TONOS */
                                 //XK_Greek_EPSILONaccent = 0x07a2, /* U+0388 GREEK CAPITAL LETTER EPSILON WITH TONOS */
                                 //XK_Greek_ETAaccent = 0x07a3, /* U+0389 GREEK CAPITAL LETTER ETA WITH TONOS */
                                 //XK_Greek_IOTAaccent = 0x07a4, /* U+038A GREEK CAPITAL LETTER IOTA WITH TONOS */
                                 //XK_Greek_IOTAdieresis = 0x07a5, /* U+03AA GREEK CAPITAL LETTER IOTA WITH DIALYTIKA */
                                 //XK_Greek_IOTAdiaeresis = 0x07a5, /* old typo */
                                 //XK_Greek_OMICRONaccent = 0x07a7, /* U+038C GREEK CAPITAL LETTER OMICRON WITH TONOS */
                                 //XK_Greek_UPSILONaccent = 0x07a8, /* U+038E GREEK CAPITAL LETTER UPSILON WITH TONOS */
                                 //XK_Greek_UPSILONdieresis = 0x07a9, /* U+03AB GREEK CAPITAL LETTER UPSILON WITH DIALYTIKA */
                                 //XK_Greek_OMEGAaccent = 0x07ab, /* U+038F GREEK CAPITAL LETTER OMEGA WITH TONOS */
                                 //XK_Greek_accentdieresis = 0x07ae, /* U+0385 GREEK DIALYTIKA TONOS */
                                 //XK_Greek_horizbar = 0x07af, /* U+2015 HORIZONTAL BAR */
                                 //XK_Greek_alphaaccent = 0x07b1, /* U+03AC GREEK SMALL LETTER ALPHA WITH TONOS */
                                 //XK_Greek_epsilonaccent = 0x07b2, /* U+03AD GREEK SMALL LETTER EPSILON WITH TONOS */
                                 //XK_Greek_etaaccent = 0x07b3, /* U+03AE GREEK SMALL LETTER ETA WITH TONOS */
                                 //XK_Greek_iotaaccent = 0x07b4, /* U+03AF GREEK SMALL LETTER IOTA WITH TONOS */
                                 //XK_Greek_iotadieresis = 0x07b5, /* U+03CA GREEK SMALL LETTER IOTA WITH DIALYTIKA */
                                 //XK_Greek_iotaaccentdieresis = 0x07b6, /* U+0390 GREEK SMALL LETTER IOTA WITH DIALYTIKA AND TONOS */
                                 //XK_Greek_omicronaccent = 0x07b7, /* U+03CC GREEK SMALL LETTER OMICRON WITH TONOS */
                                 //XK_Greek_upsilonaccent = 0x07b8, /* U+03CD GREEK SMALL LETTER UPSILON WITH TONOS */
                                 //XK_Greek_upsilondieresis = 0x07b9, /* U+03CB GREEK SMALL LETTER UPSILON WITH DIALYTIKA */
                                 //XK_Greek_upsilonaccentdieresis = 0x07ba, /* U+03B0 GREEK SMALL LETTER UPSILON WITH DIALYTIKA AND TONOS */
                                 //XK_Greek_omegaaccent = 0x07bb, /* U+03CE GREEK SMALL LETTER OMEGA WITH TONOS */
                                 //XK_Greek_ALPHA = 0x07c1, /* U+0391 GREEK CAPITAL LETTER ALPHA */
                                 //XK_Greek_BETA = 0x07c2, /* U+0392 GREEK CAPITAL LETTER BETA */
                                 //XK_Greek_GAMMA = 0x07c3, /* U+0393 GREEK CAPITAL LETTER GAMMA */
                                 //XK_Greek_DELTA = 0x07c4, /* U+0394 GREEK CAPITAL LETTER DELTA */
                                 //XK_Greek_EPSILON = 0x07c5, /* U+0395 GREEK CAPITAL LETTER EPSILON */
                                 //XK_Greek_ZETA = 0x07c6, /* U+0396 GREEK CAPITAL LETTER ZETA */
                                 //XK_Greek_ETA = 0x07c7, /* U+0397 GREEK CAPITAL LETTER ETA */
                                 //XK_Greek_THETA = 0x07c8, /* U+0398 GREEK CAPITAL LETTER THETA */
                                 //XK_Greek_IOTA = 0x07c9, /* U+0399 GREEK CAPITAL LETTER IOTA */
                                 //XK_Greek_KAPPA = 0x07ca, /* U+039A GREEK CAPITAL LETTER KAPPA */
                                 //XK_Greek_LAMDA = 0x07cb, /* U+039B GREEK CAPITAL LETTER LAMDA */
                                 //XK_Greek_LAMBDA = 0x07cb, /* U+039B GREEK CAPITAL LETTER LAMDA */
                                 //XK_Greek_MU = 0x07cc, /* U+039C GREEK CAPITAL LETTER MU */
                                 //XK_Greek_NU = 0x07cd, /* U+039D GREEK CAPITAL LETTER NU */
                                 //XK_Greek_XI = 0x07ce, /* U+039E GREEK CAPITAL LETTER XI */
                                 //XK_Greek_OMICRON = 0x07cf, /* U+039F GREEK CAPITAL LETTER OMICRON */
                                 //XK_Greek_PI = 0x07d0, /* U+03A0 GREEK CAPITAL LETTER PI */
                                 //XK_Greek_RHO = 0x07d1, /* U+03A1 GREEK CAPITAL LETTER RHO */
                                 //XK_Greek_SIGMA = 0x07d2, /* U+03A3 GREEK CAPITAL LETTER SIGMA */
                                 //XK_Greek_TAU = 0x07d4, /* U+03A4 GREEK CAPITAL LETTER TAU */
                                 //XK_Greek_UPSILON = 0x07d5, /* U+03A5 GREEK CAPITAL LETTER UPSILON */
                                 //XK_Greek_PHI = 0x07d6, /* U+03A6 GREEK CAPITAL LETTER PHI */
                                 //XK_Greek_CHI = 0x07d7, /* U+03A7 GREEK CAPITAL LETTER CHI */
                                 //XK_Greek_PSI = 0x07d8, /* U+03A8 GREEK CAPITAL LETTER PSI */
                                 //XK_Greek_OMEGA = 0x07d9, /* U+03A9 GREEK CAPITAL LETTER OMEGA */
                                 //XK_Greek_alpha = 0x07e1, /* U+03B1 GREEK SMALL LETTER ALPHA */
                                 //XK_Greek_beta = 0x07e2, /* U+03B2 GREEK SMALL LETTER BETA */
                                 //XK_Greek_gamma = 0x07e3, /* U+03B3 GREEK SMALL LETTER GAMMA */
                                 //XK_Greek_delta = 0x07e4, /* U+03B4 GREEK SMALL LETTER DELTA */
                                 //XK_Greek_epsilon = 0x07e5, /* U+03B5 GREEK SMALL LETTER EPSILON */
                                 //XK_Greek_zeta = 0x07e6, /* U+03B6 GREEK SMALL LETTER ZETA */
                                 //XK_Greek_eta = 0x07e7, /* U+03B7 GREEK SMALL LETTER ETA */
                                 //XK_Greek_theta = 0x07e8, /* U+03B8 GREEK SMALL LETTER THETA */
                                 //XK_Greek_iota = 0x07e9, /* U+03B9 GREEK SMALL LETTER IOTA */
                                 //XK_Greek_kappa = 0x07ea, /* U+03BA GREEK SMALL LETTER KAPPA */
                                 //XK_Greek_lamda = 0x07eb, /* U+03BB GREEK SMALL LETTER LAMDA */
                                 //XK_Greek_lambda = 0x07eb, /* U+03BB GREEK SMALL LETTER LAMDA */
                                 //XK_Greek_mu = 0x07ec, /* U+03BC GREEK SMALL LETTER MU */
                                 //XK_Greek_nu = 0x07ed, /* U+03BD GREEK SMALL LETTER NU */
                                 //XK_Greek_xi = 0x07ee, /* U+03BE GREEK SMALL LETTER XI */
                                 //XK_Greek_omicron = 0x07ef, /* U+03BF GREEK SMALL LETTER OMICRON */
                                 //XK_Greek_pi = 0x07f0, /* U+03C0 GREEK SMALL LETTER PI */
                                 //XK_Greek_rho = 0x07f1, /* U+03C1 GREEK SMALL LETTER RHO */
                                 //XK_Greek_sigma = 0x07f2, /* U+03C3 GREEK SMALL LETTER SIGMA */
                                 //XK_Greek_finalsmallsigma = 0x07f3, /* U+03C2 GREEK SMALL LETTER FINAL SIGMA */
                                 //XK_Greek_tau = 0x07f4, /* U+03C4 GREEK SMALL LETTER TAU */
                                 //XK_Greek_upsilon = 0x07f5, /* U+03C5 GREEK SMALL LETTER UPSILON */
                                 //XK_Greek_phi = 0x07f6, /* U+03C6 GREEK SMALL LETTER PHI */
                                 //XK_Greek_chi = 0x07f7, /* U+03C7 GREEK SMALL LETTER CHI */
                                 //XK_Greek_psi = 0x07f8, /* U+03C8 GREEK SMALL LETTER PSI */
                                 //XK_Greek_omega = 0x07f9, /* U+03C9 GREEK SMALL LETTER OMEGA */
                                 //XK_Greek_switch = 0xff7e, /* Alias for mode_switch */
                                 //#endif /* XK_GREEK */
                                 /*
                                  * Technical
                                  * (from the DEC VT330/VT420 Technical Character Set, http://vt100.net/charsets/technical.html)
                                  * Byte 3 = 8
                                  */
                                 //#ifdef XK_TECHNICAL
        XK_leftradical = 0x08a1, /* U+23B7 RADICAL SYMBOL BOTTOM */
        XK_topleftradical = 0x08a2, /*(U+250C BOX DRAWINGS LIGHT DOWN AND RIGHT)*/
        XK_horizconnector = 0x08a3, /*(U+2500 BOX DRAWINGS LIGHT HORIZONTAL)*/
        XK_topintegral = 0x08a4, /* U+2320 TOP HALF INTEGRAL */
        XK_botintegral = 0x08a5, /* U+2321 BOTTOM HALF INTEGRAL */
        XK_vertconnector = 0x08a6, /*(U+2502 BOX DRAWINGS LIGHT VERTICAL)*/
        XK_topleftsqbracket = 0x08a7, /* U+23A1 LEFT SQUARE BRACKET UPPER CORNER */
        XK_botleftsqbracket = 0x08a8, /* U+23A3 LEFT SQUARE BRACKET LOWER CORNER */
        XK_toprightsqbracket = 0x08a9, /* U+23A4 RIGHT SQUARE BRACKET UPPER CORNER */
        XK_botrightsqbracket = 0x08aa, /* U+23A6 RIGHT SQUARE BRACKET LOWER CORNER */
        XK_topleftparens = 0x08ab, /* U+239B LEFT PARENTHESIS UPPER HOOK */
        XK_botleftparens = 0x08ac, /* U+239D LEFT PARENTHESIS LOWER HOOK */
        XK_toprightparens = 0x08ad, /* U+239E RIGHT PARENTHESIS UPPER HOOK */
        XK_botrightparens = 0x08ae, /* U+23A0 RIGHT PARENTHESIS LOWER HOOK */
        XK_leftmiddlecurlybrace = 0x08af, /* U+23A8 LEFT CURLY BRACKET MIDDLE PIECE */
        XK_rightmiddlecurlybrace = 0x08b0, /* U+23AC RIGHT CURLY BRACKET MIDDLE PIECE */
        XK_topleftsummation = 0x08b1,
        XK_botleftsummation = 0x08b2,
        XK_topvertsummationconnector = 0x08b3,
        XK_botvertsummationconnector = 0x08b4,
        XK_toprightsummation = 0x08b5,
        XK_botrightsummation = 0x08b6,
        XK_rightmiddlesummation = 0x08b7,
        XK_lessthanequal = 0x08bc, /* U+2264 LESS-THAN OR EQUAL TO */
        XK_notequal = 0x08bd, /* U+2260 NOT EQUAL TO */
        XK_greaterthanequal = 0x08be, /* U+2265 GREATER-THAN OR EQUAL TO */
        XK_integral = 0x08bf, /* U+222B INTEGRAL */
        XK_therefore = 0x08c0, /* U+2234 THEREFORE */
        XK_variation = 0x08c1, /* U+221D PROPORTIONAL TO */
        XK_infinity = 0x08c2, /* U+221E INFINITY */
        XK_nabla = 0x08c5, /* U+2207 NABLA */
        XK_approximate = 0x08c8, /* U+223C TILDE OPERATOR */
        XK_similarequal = 0x08c9, /* U+2243 ASYMPTOTICALLY EQUAL TO */
        XK_ifonlyif = 0x08cd, /* U+21D4 LEFT RIGHT DOUBLE ARROW */
        XK_implies = 0x08ce, /* U+21D2 RIGHTWARDS DOUBLE ARROW */
        XK_identical = 0x08cf, /* U+2261 IDENTICAL TO */
        XK_radical = 0x08d6, /* U+221A SQUARE ROOT */
        XK_includedin = 0x08da, /* U+2282 SUBSET OF */
        XK_includes = 0x08db, /* U+2283 SUPERSET OF */
        XK_intersection = 0x08dc, /* U+2229 INTERSECTION */
        XK_union = 0x08dd, /* U+222A UNION */
        XK_logicaland = 0x08de, /* U+2227 LOGICAL AND */
        XK_logicalor = 0x08df, /* U+2228 LOGICAL OR */
        XK_partialderivative = 0x08ef, /* U+2202 PARTIAL DIFFERENTIAL */
        XK_function = 0x08f6, /* U+0192 LATIN SMALL LETTER F WITH HOOK */
        XK_leftarrow = 0x08fb, /* U+2190 LEFTWARDS ARROW */
        XK_uparrow = 0x08fc, /* U+2191 UPWARDS ARROW */
        XK_rightarrow = 0x08fd, /* U+2192 RIGHTWARDS ARROW */
        XK_downarrow = 0x08fe, /* U+2193 DOWNWARDS ARROW */
                               //#endif /* XK_TECHNICAL */
                               /*
                                * Special
                                * (from the DEC VT100 Special Graphics Character Set)
                                * Byte 3 = 9
                                */
                               //#ifdef XK_SPECIAL
        XK_blank = 0x09df,
        XK_soliddiamond = 0x09e0, /* U+25C6 BLACK DIAMOND */
        XK_checkerboard = 0x09e1, /* U+2592 MEDIUM SHADE */
        XK_ht = 0x09e2, /* U+2409 SYMBOL FOR HORIZONTAL TABULATION */
        XK_ff = 0x09e3, /* U+240C SYMBOL FOR FORM FEED */
        XK_cr = 0x09e4, /* U+240D SYMBOL FOR CARRIAGE RETURN */
        XK_lf = 0x09e5, /* U+240A SYMBOL FOR LINE FEED */
        XK_nl = 0x09e8, /* U+2424 SYMBOL FOR NEWLINE */
        XK_vt = 0x09e9, /* U+240B SYMBOL FOR VERTICAL TABULATION */
        XK_lowrightcorner = 0x09ea, /* U+2518 BOX DRAWINGS LIGHT UP AND LEFT */
        XK_uprightcorner = 0x09eb, /* U+2510 BOX DRAWINGS LIGHT DOWN AND LEFT */
        XK_upleftcorner = 0x09ec, /* U+250C BOX DRAWINGS LIGHT DOWN AND RIGHT */
        XK_lowleftcorner = 0x09ed, /* U+2514 BOX DRAWINGS LIGHT UP AND RIGHT */
        XK_crossinglines = 0x09ee, /* U+253C BOX DRAWINGS LIGHT VERTICAL AND HORIZONTAL */
        XK_horizlinescan1 = 0x09ef, /* U+23BA HORIZONTAL SCAN LINE-1 */
        XK_horizlinescan3 = 0x09f0, /* U+23BB HORIZONTAL SCAN LINE-3 */
        XK_horizlinescan5 = 0x09f1, /* U+2500 BOX DRAWINGS LIGHT HORIZONTAL */
        XK_horizlinescan7 = 0x09f2, /* U+23BC HORIZONTAL SCAN LINE-7 */
        XK_horizlinescan9 = 0x09f3, /* U+23BD HORIZONTAL SCAN LINE-9 */
        XK_leftt = 0x09f4, /* U+251C BOX DRAWINGS LIGHT VERTICAL AND RIGHT */
        XK_rightt = 0x09f5, /* U+2524 BOX DRAWINGS LIGHT VERTICAL AND LEFT */
        XK_bott = 0x09f6, /* U+2534 BOX DRAWINGS LIGHT UP AND HORIZONTAL */
        XK_topt = 0x09f7, /* U+252C BOX DRAWINGS LIGHT DOWN AND HORIZONTAL */
        XK_vertbar = 0x09f8, /* U+2502 BOX DRAWINGS LIGHT VERTICAL */
                             //#endif /* XK_SPECIAL */
                             /*
                              * Publishing
                              * (these are probably from a long forgotten DEC Publishing
                              * font that once shipped with DECwrite)
                              * Byte 3 = 0x0a
                              */
                             //#ifdef XK_PUBLISHING
        XK_emspace = 0x0aa1, /* U+2003 EM SPACE */
        XK_enspace = 0x0aa2, /* U+2002 EN SPACE */
        XK_em3space = 0x0aa3, /* U+2004 THREE-PER-EM SPACE */
        XK_em4space = 0x0aa4, /* U+2005 FOUR-PER-EM SPACE */
        XK_digitspace = 0x0aa5, /* U+2007 FIGURE SPACE */
        XK_punctspace = 0x0aa6, /* U+2008 PUNCTUATION SPACE */
        XK_thinspace = 0x0aa7, /* U+2009 THIN SPACE */
        XK_hairspace = 0x0aa8, /* U+200A HAIR SPACE */
        XK_emdash = 0x0aa9, /* U+2014 EM DASH */
        XK_endash = 0x0aaa, /* U+2013 EN DASH */
        XK_signifblank = 0x0aac, /*(U+2423 OPEN BOX)*/
        XK_ellipsis = 0x0aae, /* U+2026 HORIZONTAL ELLIPSIS */
        XK_doubbaselinedot = 0x0aaf, /* U+2025 TWO DOT LEADER */
        XK_onethird = 0x0ab0, /* U+2153 VULGAR FRACTION ONE THIRD */
        XK_twothirds = 0x0ab1, /* U+2154 VULGAR FRACTION TWO THIRDS */
        XK_onefifth = 0x0ab2, /* U+2155 VULGAR FRACTION ONE FIFTH */
        XK_twofifths = 0x0ab3, /* U+2156 VULGAR FRACTION TWO FIFTHS */
        XK_threefifths = 0x0ab4, /* U+2157 VULGAR FRACTION THREE FIFTHS */
        XK_fourfifths = 0x0ab5, /* U+2158 VULGAR FRACTION FOUR FIFTHS */
        XK_onesixth = 0x0ab6, /* U+2159 VULGAR FRACTION ONE SIXTH */
        XK_fivesixths = 0x0ab7, /* U+215A VULGAR FRACTION FIVE SIXTHS */
        XK_careof = 0x0ab8, /* U+2105 CARE OF */
        XK_figdash = 0x0abb, /* U+2012 FIGURE DASH */
        XK_leftanglebracket = 0x0abc, /*(U+27E8 MATHEMATICAL LEFT ANGLE BRACKET)*/
        XK_decimalpoint = 0x0abd, /*(U+002E FULL STOP)*/
        XK_rightanglebracket = 0x0abe, /*(U+27E9 MATHEMATICAL RIGHT ANGLE BRACKET)*/
        XK_marker = 0x0abf,
        XK_oneeighth = 0x0ac3, /* U+215B VULGAR FRACTION ONE EIGHTH */
        XK_threeeighths = 0x0ac4, /* U+215C VULGAR FRACTION THREE EIGHTHS */
        XK_fiveeighths = 0x0ac5, /* U+215D VULGAR FRACTION FIVE EIGHTHS */
        XK_seveneighths = 0x0ac6, /* U+215E VULGAR FRACTION SEVEN EIGHTHS */
        XK_trademark = 0x0ac9, /* U+2122 TRADE MARK SIGN */
        XK_signaturemark = 0x0aca, /*(U+2613 SALTIRE)*/
        XK_trademarkincircle = 0x0acb,
        XK_leftopentriangle = 0x0acc, /*(U+25C1 WHITE LEFT-POINTING TRIANGLE)*/
        XK_rightopentriangle = 0x0acd, /*(U+25B7 WHITE RIGHT-POINTING TRIANGLE)*/
        XK_emopencircle = 0x0ace, /*(U+25CB WHITE CIRCLE)*/
        XK_emopenrectangle = 0x0acf, /*(U+25AF WHITE VERTICAL RECTANGLE)*/
        XK_leftsinglequotemark = 0x0ad0, /* U+2018 LEFT SINGLE QUOTATION MARK */
        XK_rightsinglequotemark = 0x0ad1, /* U+2019 RIGHT SINGLE QUOTATION MARK */
        XK_leftdoublequotemark = 0x0ad2, /* U+201C LEFT DOUBLE QUOTATION MARK */
        XK_rightdoublequotemark = 0x0ad3, /* U+201D RIGHT DOUBLE QUOTATION MARK */
        XK_prescription = 0x0ad4, /* U+211E PRESCRIPTION TAKE */
        XK_minutes = 0x0ad6, /* U+2032 PRIME */
        XK_seconds = 0x0ad7, /* U+2033 DOUBLE PRIME */
        XK_latincross = 0x0ad9, /* U+271D LATIN CROSS */
        XK_hexagram = 0x0ada,
        XK_filledrectbullet = 0x0adb, /*(U+25AC BLACK RECTANGLE)*/
        XK_filledlefttribullet = 0x0adc, /*(U+25C0 BLACK LEFT-POINTING TRIANGLE)*/
        XK_filledrighttribullet = 0x0add, /*(U+25B6 BLACK RIGHT-POINTING TRIANGLE)*/
        XK_emfilledcircle = 0x0ade, /*(U+25CF BLACK CIRCLE)*/
        XK_emfilledrect = 0x0adf, /*(U+25AE BLACK VERTICAL RECTANGLE)*/
        XK_enopencircbullet = 0x0ae0, /*(U+25E6 WHITE BULLET)*/
        XK_enopensquarebullet = 0x0ae1, /*(U+25AB WHITE SMALL SQUARE)*/
        XK_openrectbullet = 0x0ae2, /*(U+25AD WHITE RECTANGLE)*/
        XK_opentribulletup = 0x0ae3, /*(U+25B3 WHITE UP-POINTING TRIANGLE)*/
        XK_opentribulletdown = 0x0ae4, /*(U+25BD WHITE DOWN-POINTING TRIANGLE)*/
        XK_openstar = 0x0ae5, /*(U+2606 WHITE STAR)*/
        XK_enfilledcircbullet = 0x0ae6, /*(U+2022 BULLET)*/
        XK_enfilledsqbullet = 0x0ae7, /*(U+25AA BLACK SMALL SQUARE)*/
        XK_filledtribulletup = 0x0ae8, /*(U+25B2 BLACK UP-POINTING TRIANGLE)*/
        XK_filledtribulletdown = 0x0ae9, /*(U+25BC BLACK DOWN-POINTING TRIANGLE)*/
        XK_leftpointer = 0x0aea, /*(U+261C WHITE LEFT POINTING INDEX)*/
        XK_rightpointer = 0x0aeb, /*(U+261E WHITE RIGHT POINTING INDEX)*/
        XK_club = 0x0aec, /* U+2663 BLACK CLUB SUIT */
        XK_diamond = 0x0aed, /* U+2666 BLACK DIAMOND SUIT */
        XK_heart = 0x0aee, /* U+2665 BLACK HEART SUIT */
        XK_maltesecross = 0x0af0, /* U+2720 MALTESE CROSS */
        XK_dagger = 0x0af1, /* U+2020 DAGGER */
        XK_doubledagger = 0x0af2, /* U+2021 DOUBLE DAGGER */
        XK_checkmark = 0x0af3, /* U+2713 CHECK MARK */
        XK_ballotcross = 0x0af4, /* U+2717 BALLOT X */
        XK_musicalsharp = 0x0af5, /* U+266F MUSIC SHARP SIGN */
        XK_musicalflat = 0x0af6, /* U+266D MUSIC FLAT SIGN */
        XK_malesymbol = 0x0af7, /* U+2642 MALE SIGN */
        XK_femalesymbol = 0x0af8, /* U+2640 FEMALE SIGN */
        XK_telephone = 0x0af9, /* U+260E BLACK TELEPHONE */
        XK_telephonerecorder = 0x0afa, /* U+2315 TELEPHONE RECORDER */
        XK_phonographcopyright = 0x0afb, /* U+2117 SOUND RECORDING COPYRIGHT */
        XK_caret = 0x0afc, /* U+2038 CARET */
        XK_singlelowquotemark = 0x0afd, /* U+201A SINGLE LOW-9 QUOTATION MARK */
        XK_doublelowquotemark = 0x0afe, /* U+201E DOUBLE LOW-9 QUOTATION MARK */
        XK_cursor = 0x0aff,
        //#endif /* XK_PUBLISHING */
        /*
         * APL
         * Byte 3 = 0x0b
         */
        //#ifdef XK_APL
        XK_leftcaret = 0x0ba3, /*(U+003C LESS-THAN SIGN)*/
        XK_rightcaret = 0x0ba6, /*(U+003E GREATER-THAN SIGN)*/
        XK_downcaret = 0x0ba8, /*(U+2228 LOGICAL OR)*/
        XK_upcaret = 0x0ba9, /*(U+2227 LOGICAL AND)*/
        XK_overbar = 0x0bc0, /*(U+00AF MACRON)*/
        XK_downtack = 0x0bc2, /* U+22A5 UP TACK */
        XK_upshoe = 0x0bc3, /*(U+2229 INTERSECTION)*/
        XK_downstile = 0x0bc4, /* U+230A LEFT FLOOR */
        XK_underbar = 0x0bc6, /*(U+005F LOW LINE)*/
        XK_jot = 0x0bca, /* U+2218 RING OPERATOR */
        XK_quad = 0x0bcc, /* U+2395 APL FUNCTIONAL SYMBOL QUAD */
        XK_uptack = 0x0bce, /* U+22A4 DOWN TACK */
        XK_circle = 0x0bcf, /* U+25CB WHITE CIRCLE */
        XK_upstile = 0x0bd3, /* U+2308 LEFT CEILING */
        XK_downshoe = 0x0bd6, /*(U+222A UNION)*/
        XK_rightshoe = 0x0bd8, /*(U+2283 SUPERSET OF)*/
        XK_leftshoe = 0x0bda, /*(U+2282 SUBSET OF)*/
        XK_lefttack = 0x0bdc, /* U+22A2 RIGHT TACK */
        XK_righttack = 0x0bfc, /* U+22A3 LEFT TACK */
                               //#endif /* XK_APL */
                               /*
                                * Hebrew
                                * Byte 3 = 0x0c
                                */
                               //#ifdef XK_HEBREW
        XK_hebrew_doublelowline = 0x0cdf, /* U+2017 DOUBLE LOW LINE */
        XK_hebrew_aleph = 0x0ce0, /* U+05D0 HEBREW LETTER ALEF */
        XK_hebrew_bet = 0x0ce1, /* U+05D1 HEBREW LETTER BET */
        XK_hebrew_beth = 0x0ce1, /* deprecated */
        XK_hebrew_gimel = 0x0ce2, /* U+05D2 HEBREW LETTER GIMEL */
        XK_hebrew_gimmel = 0x0ce2, /* deprecated */
        XK_hebrew_dalet = 0x0ce3, /* U+05D3 HEBREW LETTER DALET */
        XK_hebrew_daleth = 0x0ce3, /* deprecated */
        XK_hebrew_he = 0x0ce4, /* U+05D4 HEBREW LETTER HE */
        XK_hebrew_waw = 0x0ce5, /* U+05D5 HEBREW LETTER VAV */
        XK_hebrew_zain = 0x0ce6, /* U+05D6 HEBREW LETTER ZAYIN */
        XK_hebrew_zayin = 0x0ce6, /* deprecated */
        XK_hebrew_chet = 0x0ce7, /* U+05D7 HEBREW LETTER HET */
        XK_hebrew_het = 0x0ce7, /* deprecated */
        XK_hebrew_tet = 0x0ce8, /* U+05D8 HEBREW LETTER TET */
        XK_hebrew_teth = 0x0ce8, /* deprecated */
        XK_hebrew_yod = 0x0ce9, /* U+05D9 HEBREW LETTER YOD */
        XK_hebrew_finalkaph = 0x0cea, /* U+05DA HEBREW LETTER FINAL KAF */
        XK_hebrew_kaph = 0x0ceb, /* U+05DB HEBREW LETTER KAF */
        XK_hebrew_lamed = 0x0cec, /* U+05DC HEBREW LETTER LAMED */
        XK_hebrew_finalmem = 0x0ced, /* U+05DD HEBREW LETTER FINAL MEM */
        XK_hebrew_mem = 0x0cee, /* U+05DE HEBREW LETTER MEM */
        XK_hebrew_finalnun = 0x0cef, /* U+05DF HEBREW LETTER FINAL NUN */
        XK_hebrew_nun = 0x0cf0, /* U+05E0 HEBREW LETTER NUN */
        XK_hebrew_samech = 0x0cf1, /* U+05E1 HEBREW LETTER SAMEKH */
        XK_hebrew_samekh = 0x0cf1, /* deprecated */
        XK_hebrew_ayin = 0x0cf2, /* U+05E2 HEBREW LETTER AYIN */
        XK_hebrew_finalpe = 0x0cf3, /* U+05E3 HEBREW LETTER FINAL PE */
        XK_hebrew_pe = 0x0cf4, /* U+05E4 HEBREW LETTER PE */
        XK_hebrew_finalzade = 0x0cf5, /* U+05E5 HEBREW LETTER FINAL TSADI */
        XK_hebrew_finalzadi = 0x0cf5, /* deprecated */
        XK_hebrew_zade = 0x0cf6, /* U+05E6 HEBREW LETTER TSADI */
        XK_hebrew_zadi = 0x0cf6, /* deprecated */
        XK_hebrew_qoph = 0x0cf7, /* U+05E7 HEBREW LETTER QOF */
        XK_hebrew_kuf = 0x0cf7, /* deprecated */
        XK_hebrew_resh = 0x0cf8, /* U+05E8 HEBREW LETTER RESH */
        XK_hebrew_shin = 0x0cf9, /* U+05E9 HEBREW LETTER SHIN */
        XK_hebrew_taw = 0x0cfa, /* U+05EA HEBREW LETTER TAV */
        XK_hebrew_taf = 0x0cfa, /* deprecated */
        XK_Hebrew_switch = 0xff7e, /* Alias for mode_switch */
                                   //#endif /* XK_HEBREW */
                                   /*
                                    * Thai
                                    * Byte 3 = 0x0d
                                    */
                                   //#ifdef XK_THAI
        XK_Thai_kokai = 0x0da1, /* U+0E01 THAI CHARACTER KO KAI */
        XK_Thai_khokhai = 0x0da2, /* U+0E02 THAI CHARACTER KHO KHAI */
        XK_Thai_khokhuat = 0x0da3, /* U+0E03 THAI CHARACTER KHO KHUAT */
        XK_Thai_khokhwai = 0x0da4, /* U+0E04 THAI CHARACTER KHO KHWAI */
        XK_Thai_khokhon = 0x0da5, /* U+0E05 THAI CHARACTER KHO KHON */
        XK_Thai_khorakhang = 0x0da6, /* U+0E06 THAI CHARACTER KHO RAKHANG */
        XK_Thai_ngongu = 0x0da7, /* U+0E07 THAI CHARACTER NGO NGU */
        XK_Thai_chochan = 0x0da8, /* U+0E08 THAI CHARACTER CHO CHAN */
        XK_Thai_choching = 0x0da9, /* U+0E09 THAI CHARACTER CHO CHING */
        XK_Thai_chochang = 0x0daa, /* U+0E0A THAI CHARACTER CHO CHANG */
        XK_Thai_soso = 0x0dab, /* U+0E0B THAI CHARACTER SO SO */
        XK_Thai_chochoe = 0x0dac, /* U+0E0C THAI CHARACTER CHO CHOE */
        XK_Thai_yoying = 0x0dad, /* U+0E0D THAI CHARACTER YO YING */
        XK_Thai_dochada = 0x0dae, /* U+0E0E THAI CHARACTER DO CHADA */
        XK_Thai_topatak = 0x0daf, /* U+0E0F THAI CHARACTER TO PATAK */
        XK_Thai_thothan = 0x0db0, /* U+0E10 THAI CHARACTER THO THAN */
        XK_Thai_thonangmontho = 0x0db1, /* U+0E11 THAI CHARACTER THO NANGMONTHO */
        XK_Thai_thophuthao = 0x0db2, /* U+0E12 THAI CHARACTER THO PHUTHAO */
        XK_Thai_nonen = 0x0db3, /* U+0E13 THAI CHARACTER NO NEN */
        XK_Thai_dodek = 0x0db4, /* U+0E14 THAI CHARACTER DO DEK */
        XK_Thai_totao = 0x0db5, /* U+0E15 THAI CHARACTER TO TAO */
        XK_Thai_thothung = 0x0db6, /* U+0E16 THAI CHARACTER THO THUNG */
        XK_Thai_thothahan = 0x0db7, /* U+0E17 THAI CHARACTER THO THAHAN */
        XK_Thai_thothong = 0x0db8, /* U+0E18 THAI CHARACTER THO THONG */
        XK_Thai_nonu = 0x0db9, /* U+0E19 THAI CHARACTER NO NU */
        XK_Thai_bobaimai = 0x0dba, /* U+0E1A THAI CHARACTER BO BAIMAI */
        XK_Thai_popla = 0x0dbb, /* U+0E1B THAI CHARACTER PO PLA */
        XK_Thai_phophung = 0x0dbc, /* U+0E1C THAI CHARACTER PHO PHUNG */
        XK_Thai_fofa = 0x0dbd, /* U+0E1D THAI CHARACTER FO FA */
        XK_Thai_phophan = 0x0dbe, /* U+0E1E THAI CHARACTER PHO PHAN */
        XK_Thai_fofan = 0x0dbf, /* U+0E1F THAI CHARACTER FO FAN */
        XK_Thai_phosamphao = 0x0dc0, /* U+0E20 THAI CHARACTER PHO SAMPHAO */
        XK_Thai_moma = 0x0dc1, /* U+0E21 THAI CHARACTER MO MA */
        XK_Thai_yoyak = 0x0dc2, /* U+0E22 THAI CHARACTER YO YAK */
        XK_Thai_rorua = 0x0dc3, /* U+0E23 THAI CHARACTER RO RUA */
        XK_Thai_ru = 0x0dc4, /* U+0E24 THAI CHARACTER RU */
        XK_Thai_loling = 0x0dc5, /* U+0E25 THAI CHARACTER LO LING */
        XK_Thai_lu = 0x0dc6, /* U+0E26 THAI CHARACTER LU */
        XK_Thai_wowaen = 0x0dc7, /* U+0E27 THAI CHARACTER WO WAEN */
        XK_Thai_sosala = 0x0dc8, /* U+0E28 THAI CHARACTER SO SALA */
        XK_Thai_sorusi = 0x0dc9, /* U+0E29 THAI CHARACTER SO RUSI */
        XK_Thai_sosua = 0x0dca, /* U+0E2A THAI CHARACTER SO SUA */
        XK_Thai_hohip = 0x0dcb, /* U+0E2B THAI CHARACTER HO HIP */
        XK_Thai_lochula = 0x0dcc, /* U+0E2C THAI CHARACTER LO CHULA */
        XK_Thai_oang = 0x0dcd, /* U+0E2D THAI CHARACTER O ANG */
        XK_Thai_honokhuk = 0x0dce, /* U+0E2E THAI CHARACTER HO NOKHUK */
        XK_Thai_paiyannoi = 0x0dcf, /* U+0E2F THAI CHARACTER PAIYANNOI */
        XK_Thai_saraa = 0x0dd0, /* U+0E30 THAI CHARACTER SARA A */
        XK_Thai_maihanakat = 0x0dd1, /* U+0E31 THAI CHARACTER MAI HAN-AKAT */
        XK_Thai_saraaa = 0x0dd2, /* U+0E32 THAI CHARACTER SARA AA */
        XK_Thai_saraam = 0x0dd3, /* U+0E33 THAI CHARACTER SARA AM */
        XK_Thai_sarai = 0x0dd4, /* U+0E34 THAI CHARACTER SARA I */
        XK_Thai_saraii = 0x0dd5, /* U+0E35 THAI CHARACTER SARA II */
        XK_Thai_saraue = 0x0dd6, /* U+0E36 THAI CHARACTER SARA UE */
        XK_Thai_sarauee = 0x0dd7, /* U+0E37 THAI CHARACTER SARA UEE */
        XK_Thai_sarau = 0x0dd8, /* U+0E38 THAI CHARACTER SARA U */
        XK_Thai_sarauu = 0x0dd9, /* U+0E39 THAI CHARACTER SARA UU */
        XK_Thai_phinthu = 0x0dda, /* U+0E3A THAI CHARACTER PHINTHU */
        XK_Thai_maihanakat_maitho = 0x0dde,
        XK_Thai_baht = 0x0ddf, /* U+0E3F THAI CURRENCY SYMBOL BAHT */
        XK_Thai_sarae = 0x0de0, /* U+0E40 THAI CHARACTER SARA E */
        XK_Thai_saraae = 0x0de1, /* U+0E41 THAI CHARACTER SARA AE */
        XK_Thai_sarao = 0x0de2, /* U+0E42 THAI CHARACTER SARA O */
        XK_Thai_saraaimaimuan = 0x0de3, /* U+0E43 THAI CHARACTER SARA AI MAIMUAN */
        XK_Thai_saraaimaimalai = 0x0de4, /* U+0E44 THAI CHARACTER SARA AI MAIMALAI */
        XK_Thai_lakkhangyao = 0x0de5, /* U+0E45 THAI CHARACTER LAKKHANGYAO */
        XK_Thai_maiyamok = 0x0de6, /* U+0E46 THAI CHARACTER MAIYAMOK */
        XK_Thai_maitaikhu = 0x0de7, /* U+0E47 THAI CHARACTER MAITAIKHU */
        XK_Thai_maiek = 0x0de8, /* U+0E48 THAI CHARACTER MAI EK */
        XK_Thai_maitho = 0x0de9, /* U+0E49 THAI CHARACTER MAI THO */
        XK_Thai_maitri = 0x0dea, /* U+0E4A THAI CHARACTER MAI TRI */
        XK_Thai_maichattawa = 0x0deb, /* U+0E4B THAI CHARACTER MAI CHATTAWA */
        XK_Thai_thanthakhat = 0x0dec, /* U+0E4C THAI CHARACTER THANTHAKHAT */
        XK_Thai_nikhahit = 0x0ded, /* U+0E4D THAI CHARACTER NIKHAHIT */
        XK_Thai_leksun = 0x0df0, /* U+0E50 THAI DIGIT ZERO */
        XK_Thai_leknung = 0x0df1, /* U+0E51 THAI DIGIT ONE */
        XK_Thai_leksong = 0x0df2, /* U+0E52 THAI DIGIT TWO */
        XK_Thai_leksam = 0x0df3, /* U+0E53 THAI DIGIT THREE */
        XK_Thai_leksi = 0x0df4, /* U+0E54 THAI DIGIT FOUR */
        XK_Thai_lekha = 0x0df5, /* U+0E55 THAI DIGIT FIVE */
        XK_Thai_lekhok = 0x0df6, /* U+0E56 THAI DIGIT SIX */
        XK_Thai_lekchet = 0x0df7, /* U+0E57 THAI DIGIT SEVEN */
        XK_Thai_lekpaet = 0x0df8, /* U+0E58 THAI DIGIT EIGHT */
        XK_Thai_lekkao = 0x0df9, /* U+0E59 THAI DIGIT NINE */
                                 //#endif /* XK_THAI */
                                 /*
                                  * Korean
                                  * Byte 3 = 0x0e
                                  */
                                 //#ifdef XK_KOREAN
        XK_Hangul = 0xff31, /* Hangul start/stop(toggle) */
        XK_Hangul_Start = 0xff32, /* Hangul start */
        XK_Hangul_End = 0xff33, /* Hangul end, English start */
        XK_Hangul_Hanja = 0xff34, /* Start Hangul->Hanja Conversion */
        XK_Hangul_Jamo = 0xff35, /* Hangul Jamo mode */
        XK_Hangul_Romaja = 0xff36, /* Hangul Romaja mode */
        XK_Hangul_Codeinput = 0xff37, /* Hangul code input mode */
        XK_Hangul_Jeonja = 0xff38, /* Jeonja mode */
        XK_Hangul_Banja = 0xff39, /* Banja mode */
        XK_Hangul_PreHanja = 0xff3a, /* Pre Hanja conversion */
        XK_Hangul_PostHanja = 0xff3b, /* Post Hanja conversion */
        XK_Hangul_SingleCandidate = 0xff3c, /* Single candidate */
        XK_Hangul_MultipleCandidate = 0xff3d, /* Multiple candidate */
        XK_Hangul_PreviousCandidate = 0xff3e, /* Previous candidate */
        XK_Hangul_Special = 0xff3f, /* Special symbols */
        XK_Hangul_switch = 0xff7e, /* Alias for mode_switch */
                                   /* Hangul Consonant Characters */
        XK_Hangul_Kiyeog = 0x0ea1,
        XK_Hangul_SsangKiyeog = 0x0ea2,
        XK_Hangul_KiyeogSios = 0x0ea3,
        XK_Hangul_Nieun = 0x0ea4,
        XK_Hangul_NieunJieuj = 0x0ea5,
        XK_Hangul_NieunHieuh = 0x0ea6,
        XK_Hangul_Dikeud = 0x0ea7,
        XK_Hangul_SsangDikeud = 0x0ea8,
        XK_Hangul_Rieul = 0x0ea9,
        XK_Hangul_RieulKiyeog = 0x0eaa,
        XK_Hangul_RieulMieum = 0x0eab,
        XK_Hangul_RieulPieub = 0x0eac,
        XK_Hangul_RieulSios = 0x0ead,
        XK_Hangul_RieulTieut = 0x0eae,
        XK_Hangul_RieulPhieuf = 0x0eaf,
        XK_Hangul_RieulHieuh = 0x0eb0,
        XK_Hangul_Mieum = 0x0eb1,
        XK_Hangul_Pieub = 0x0eb2,
        XK_Hangul_SsangPieub = 0x0eb3,
        XK_Hangul_PieubSios = 0x0eb4,
        XK_Hangul_Sios = 0x0eb5,
        XK_Hangul_SsangSios = 0x0eb6,
        XK_Hangul_Ieung = 0x0eb7,
        XK_Hangul_Jieuj = 0x0eb8,
        XK_Hangul_SsangJieuj = 0x0eb9,
        XK_Hangul_Cieuc = 0x0eba,
        XK_Hangul_Khieuq = 0x0ebb,
        XK_Hangul_Tieut = 0x0ebc,
        XK_Hangul_Phieuf = 0x0ebd,
        XK_Hangul_Hieuh = 0x0ebe,
        /* Hangul Vowel Characters */
        XK_Hangul_A = 0x0ebf,
        XK_Hangul_AE = 0x0ec0,
        XK_Hangul_YA = 0x0ec1,
        XK_Hangul_YAE = 0x0ec2,
        XK_Hangul_EO = 0x0ec3,
        XK_Hangul_E = 0x0ec4,
        XK_Hangul_YEO = 0x0ec5,
        XK_Hangul_YE = 0x0ec6,
        XK_Hangul_O = 0x0ec7,
        XK_Hangul_WA = 0x0ec8,
        XK_Hangul_WAE = 0x0ec9,
        XK_Hangul_OE = 0x0eca,
        XK_Hangul_YO = 0x0ecb,
        XK_Hangul_U = 0x0ecc,
        XK_Hangul_WEO = 0x0ecd,
        XK_Hangul_WE = 0x0ece,
        XK_Hangul_WI = 0x0ecf,
        XK_Hangul_YU = 0x0ed0,
        XK_Hangul_EU = 0x0ed1,
        XK_Hangul_YI = 0x0ed2,
        XK_Hangul_I = 0x0ed3,
        /* Hangul syllable-final (JongSeong) Characters */
        XK_Hangul_J_Kiyeog = 0x0ed4,
        XK_Hangul_J_SsangKiyeog = 0x0ed5,
        XK_Hangul_J_KiyeogSios = 0x0ed6,
        XK_Hangul_J_Nieun = 0x0ed7,
        XK_Hangul_J_NieunJieuj = 0x0ed8,
        XK_Hangul_J_NieunHieuh = 0x0ed9,
        XK_Hangul_J_Dikeud = 0x0eda,
        XK_Hangul_J_Rieul = 0x0edb,
        XK_Hangul_J_RieulKiyeog = 0x0edc,
        XK_Hangul_J_RieulMieum = 0x0edd,
        XK_Hangul_J_RieulPieub = 0x0ede,
        XK_Hangul_J_RieulSios = 0x0edf,
        XK_Hangul_J_RieulTieut = 0x0ee0,
        XK_Hangul_J_RieulPhieuf = 0x0ee1,
        XK_Hangul_J_RieulHieuh = 0x0ee2,
        XK_Hangul_J_Mieum = 0x0ee3,
        XK_Hangul_J_Pieub = 0x0ee4,
        XK_Hangul_J_PieubSios = 0x0ee5,
        XK_Hangul_J_Sios = 0x0ee6,
        XK_Hangul_J_SsangSios = 0x0ee7,
        XK_Hangul_J_Ieung = 0x0ee8,
        XK_Hangul_J_Jieuj = 0x0ee9,
        XK_Hangul_J_Cieuc = 0x0eea,
        XK_Hangul_J_Khieuq = 0x0eeb,
        XK_Hangul_J_Tieut = 0x0eec,
        XK_Hangul_J_Phieuf = 0x0eed,
        XK_Hangul_J_Hieuh = 0x0eee,
        /* Ancient Hangul Consonant Characters */
        XK_Hangul_RieulYeorinHieuh = 0x0eef,
        XK_Hangul_SunkyeongeumMieum = 0x0ef0,
        XK_Hangul_SunkyeongeumPieub = 0x0ef1,
        XK_Hangul_PanSios = 0x0ef2,
        XK_Hangul_KkogjiDalrinIeung = 0x0ef3,
        XK_Hangul_SunkyeongeumPhieuf = 0x0ef4,
        XK_Hangul_YeorinHieuh = 0x0ef5,
        /* Ancient Hangul Vowel Characters */
        XK_Hangul_AraeA = 0x0ef6,
        XK_Hangul_AraeAE = 0x0ef7,
        /* Ancient Hangul syllable-final (JongSeong) Characters */
        XK_Hangul_J_PanSios = 0x0ef8,
        XK_Hangul_J_KkogjiDalrinIeung = 0x0ef9,
        XK_Hangul_J_YeorinHieuh = 0x0efa,
        /* Korean currency symbol */
        XK_Korean_Won = 0x0eff, /*(U+20A9 WON SIGN)*/
                                //#endif /* XK_KOREAN */
                                /*
                                 * Armenian
                                 */
                                //#ifdef XK_ARMENIAN
                                //XK_Armenian_ligature_ew = 0x1000587, /* U+0587 ARMENIAN SMALL LIGATURE ECH YIWN */
                                //XK_Armenian_full_stop = 0x1000589, /* U+0589 ARMENIAN FULL STOP */
                                //XK_Armenian_verjaket = 0x1000589, /* U+0589 ARMENIAN FULL STOP */
                                //XK_Armenian_separation_mark = 0x100055d, /* U+055D ARMENIAN COMMA */
                                //XK_Armenian_but = 0x100055d, /* U+055D ARMENIAN COMMA */
                                //XK_Armenian_hyphen = 0x100058a, /* U+058A ARMENIAN HYPHEN */
                                //XK_Armenian_yentamna = 0x100058a, /* U+058A ARMENIAN HYPHEN */
                                //XK_Armenian_exclam = 0x100055c, /* U+055C ARMENIAN EXCLAMATION MARK */
                                //XK_Armenian_amanak = 0x100055c, /* U+055C ARMENIAN EXCLAMATION MARK */
                                //XK_Armenian_accent = 0x100055b, /* U+055B ARMENIAN EMPHASIS MARK */
                                //XK_Armenian_shesht = 0x100055b, /* U+055B ARMENIAN EMPHASIS MARK */
                                //XK_Armenian_question = 0x100055e, /* U+055E ARMENIAN QUESTION MARK */
                                //XK_Armenian_paruyk = 0x100055e, /* U+055E ARMENIAN QUESTION MARK */
                                //XK_Armenian_AYB = 0x1000531, /* U+0531 ARMENIAN CAPITAL LETTER AYB */
                                //XK_Armenian_ayb = 0x1000561, /* U+0561 ARMENIAN SMALL LETTER AYB */
                                //XK_Armenian_BEN = 0x1000532, /* U+0532 ARMENIAN CAPITAL LETTER BEN */
                                //XK_Armenian_ben = 0x1000562, /* U+0562 ARMENIAN SMALL LETTER BEN */
                                //XK_Armenian_GIM = 0x1000533, /* U+0533 ARMENIAN CAPITAL LETTER GIM */
                                //XK_Armenian_gim = 0x1000563, /* U+0563 ARMENIAN SMALL LETTER GIM */
                                //XK_Armenian_DA = 0x1000534, /* U+0534 ARMENIAN CAPITAL LETTER DA */
                                //XK_Armenian_da = 0x1000564, /* U+0564 ARMENIAN SMALL LETTER DA */
                                //XK_Armenian_YECH = 0x1000535, /* U+0535 ARMENIAN CAPITAL LETTER ECH */
                                //XK_Armenian_yech = 0x1000565, /* U+0565 ARMENIAN SMALL LETTER ECH */
                                //XK_Armenian_ZA = 0x1000536, /* U+0536 ARMENIAN CAPITAL LETTER ZA */
                                //XK_Armenian_za = 0x1000566, /* U+0566 ARMENIAN SMALL LETTER ZA */
                                //XK_Armenian_E = 0x1000537, /* U+0537 ARMENIAN CAPITAL LETTER EH */
                                //XK_Armenian_e = 0x1000567, /* U+0567 ARMENIAN SMALL LETTER EH */
                                //XK_Armenian_AT = 0x1000538, /* U+0538 ARMENIAN CAPITAL LETTER ET */
                                //XK_Armenian_at = 0x1000568, /* U+0568 ARMENIAN SMALL LETTER ET */
                                //XK_Armenian_TO = 0x1000539, /* U+0539 ARMENIAN CAPITAL LETTER TO */
                                //XK_Armenian_to = 0x1000569, /* U+0569 ARMENIAN SMALL LETTER TO */
                                //XK_Armenian_ZHE = 0x100053a, /* U+053A ARMENIAN CAPITAL LETTER ZHE */
                                //XK_Armenian_zhe = 0x100056a, /* U+056A ARMENIAN SMALL LETTER ZHE */
                                //XK_Armenian_INI = 0x100053b, /* U+053B ARMENIAN CAPITAL LETTER INI */
                                //XK_Armenian_ini = 0x100056b, /* U+056B ARMENIAN SMALL LETTER INI */
                                //XK_Armenian_LYUN = 0x100053c, /* U+053C ARMENIAN CAPITAL LETTER LIWN */
                                //XK_Armenian_lyun = 0x100056c, /* U+056C ARMENIAN SMALL LETTER LIWN */
                                //XK_Armenian_KHE = 0x100053d, /* U+053D ARMENIAN CAPITAL LETTER XEH */
                                //XK_Armenian_khe = 0x100056d, /* U+056D ARMENIAN SMALL LETTER XEH */
                                //XK_Armenian_TSA = 0x100053e, /* U+053E ARMENIAN CAPITAL LETTER CA */
                                //XK_Armenian_tsa = 0x100056e, /* U+056E ARMENIAN SMALL LETTER CA */
                                //XK_Armenian_KEN = 0x100053f, /* U+053F ARMENIAN CAPITAL LETTER KEN */
                                //XK_Armenian_ken = 0x100056f, /* U+056F ARMENIAN SMALL LETTER KEN */
                                //XK_Armenian_HO = 0x1000540, /* U+0540 ARMENIAN CAPITAL LETTER HO */
                                //XK_Armenian_ho = 0x1000570, /* U+0570 ARMENIAN SMALL LETTER HO */
                                //XK_Armenian_DZA = 0x1000541, /* U+0541 ARMENIAN CAPITAL LETTER JA */
                                //XK_Armenian_dza = 0x1000571, /* U+0571 ARMENIAN SMALL LETTER JA */
                                //XK_Armenian_GHAT = 0x1000542, /* U+0542 ARMENIAN CAPITAL LETTER GHAD */
                                //XK_Armenian_ghat = 0x1000572, /* U+0572 ARMENIAN SMALL LETTER GHAD */
                                //XK_Armenian_TCHE = 0x1000543, /* U+0543 ARMENIAN CAPITAL LETTER CHEH */
                                //XK_Armenian_tche = 0x1000573, /* U+0573 ARMENIAN SMALL LETTER CHEH */
                                //XK_Armenian_MEN = 0x1000544, /* U+0544 ARMENIAN CAPITAL LETTER MEN */
                                //XK_Armenian_men = 0x1000574, /* U+0574 ARMENIAN SMALL LETTER MEN */
                                //XK_Armenian_HI = 0x1000545, /* U+0545 ARMENIAN CAPITAL LETTER YI */
                                //XK_Armenian_hi = 0x1000575, /* U+0575 ARMENIAN SMALL LETTER YI */
                                //XK_Armenian_NU = 0x1000546, /* U+0546 ARMENIAN CAPITAL LETTER NOW */
                                //XK_Armenian_nu = 0x1000576, /* U+0576 ARMENIAN SMALL LETTER NOW */
                                //XK_Armenian_SHA = 0x1000547, /* U+0547 ARMENIAN CAPITAL LETTER SHA */
                                //XK_Armenian_sha = 0x1000577, /* U+0577 ARMENIAN SMALL LETTER SHA */
                                //XK_Armenian_VO = 0x1000548, /* U+0548 ARMENIAN CAPITAL LETTER VO */
                                //XK_Armenian_vo = 0x1000578, /* U+0578 ARMENIAN SMALL LETTER VO */
                                //XK_Armenian_CHA = 0x1000549, /* U+0549 ARMENIAN CAPITAL LETTER CHA */
                                //XK_Armenian_cha = 0x1000579, /* U+0579 ARMENIAN SMALL LETTER CHA */
                                //XK_Armenian_PE = 0x100054a, /* U+054A ARMENIAN CAPITAL LETTER PEH */
                                //XK_Armenian_pe = 0x100057a, /* U+057A ARMENIAN SMALL LETTER PEH */
                                //XK_Armenian_JE = 0x100054b, /* U+054B ARMENIAN CAPITAL LETTER JHEH */
                                //XK_Armenian_je = 0x100057b, /* U+057B ARMENIAN SMALL LETTER JHEH */
                                //XK_Armenian_RA = 0x100054c, /* U+054C ARMENIAN CAPITAL LETTER RA */
                                //XK_Armenian_ra = 0x100057c, /* U+057C ARMENIAN SMALL LETTER RA */
                                //XK_Armenian_SE = 0x100054d, /* U+054D ARMENIAN CAPITAL LETTER SEH */
                                //XK_Armenian_se = 0x100057d, /* U+057D ARMENIAN SMALL LETTER SEH */
                                //XK_Armenian_VEV = 0x100054e, /* U+054E ARMENIAN CAPITAL LETTER VEW */
                                //XK_Armenian_vev = 0x100057e, /* U+057E ARMENIAN SMALL LETTER VEW */
                                //XK_Armenian_TYUN = 0x100054f, /* U+054F ARMENIAN CAPITAL LETTER TIWN */
                                //XK_Armenian_tyun = 0x100057f, /* U+057F ARMENIAN SMALL LETTER TIWN */
                                //XK_Armenian_RE = 0x1000550, /* U+0550 ARMENIAN CAPITAL LETTER REH */
                                //XK_Armenian_re = 0x1000580, /* U+0580 ARMENIAN SMALL LETTER REH */
                                //XK_Armenian_TSO = 0x1000551, /* U+0551 ARMENIAN CAPITAL LETTER CO */
                                //XK_Armenian_tso = 0x1000581, /* U+0581 ARMENIAN SMALL LETTER CO */
                                //XK_Armenian_VYUN = 0x1000552, /* U+0552 ARMENIAN CAPITAL LETTER YIWN */
                                //XK_Armenian_vyun = 0x1000582, /* U+0582 ARMENIAN SMALL LETTER YIWN */
                                //XK_Armenian_PYUR = 0x1000553, /* U+0553 ARMENIAN CAPITAL LETTER PIWR */
                                //XK_Armenian_pyur = 0x1000583, /* U+0583 ARMENIAN SMALL LETTER PIWR */
                                //XK_Armenian_KE = 0x1000554, /* U+0554 ARMENIAN CAPITAL LETTER KEH */
                                //XK_Armenian_ke = 0x1000584, /* U+0584 ARMENIAN SMALL LETTER KEH */
                                //XK_Armenian_O = 0x1000555, /* U+0555 ARMENIAN CAPITAL LETTER OH */
                                //XK_Armenian_o = 0x1000585, /* U+0585 ARMENIAN SMALL LETTER OH */
                                //XK_Armenian_FE = 0x1000556, /* U+0556 ARMENIAN CAPITAL LETTER FEH */
                                //XK_Armenian_fe = 0x1000586, /* U+0586 ARMENIAN SMALL LETTER FEH */
                                //XK_Armenian_apostrophe = 0x100055a, /* U+055A ARMENIAN APOSTROPHE */
                                //#endif /* XK_ARMENIAN */
                                /*
                                 * Georgian
                                 */
                                //#ifdef XK_GEORGIAN
                                //XK_Georgian_an = 0x10010d0, /* U+10D0 GEORGIAN LETTER AN */
                                //XK_Georgian_ban = 0x10010d1, /* U+10D1 GEORGIAN LETTER BAN */
                                //XK_Georgian_gan = 0x10010d2, /* U+10D2 GEORGIAN LETTER GAN */
                                //XK_Georgian_don = 0x10010d3, /* U+10D3 GEORGIAN LETTER DON */
                                //XK_Georgian_en = 0x10010d4, /* U+10D4 GEORGIAN LETTER EN */
                                //XK_Georgian_vin = 0x10010d5, /* U+10D5 GEORGIAN LETTER VIN */
                                //XK_Georgian_zen = 0x10010d6, /* U+10D6 GEORGIAN LETTER ZEN */
                                //XK_Georgian_tan = 0x10010d7, /* U+10D7 GEORGIAN LETTER TAN */
                                //XK_Georgian_in = 0x10010d8, /* U+10D8 GEORGIAN LETTER IN */
                                //XK_Georgian_kan = 0x10010d9, /* U+10D9 GEORGIAN LETTER KAN */
                                //XK_Georgian_las = 0x10010da, /* U+10DA GEORGIAN LETTER LAS */
                                //XK_Georgian_man = 0x10010db, /* U+10DB GEORGIAN LETTER MAN */
                                //XK_Georgian_nar = 0x10010dc, /* U+10DC GEORGIAN LETTER NAR */
                                //XK_Georgian_on = 0x10010dd, /* U+10DD GEORGIAN LETTER ON */
                                //XK_Georgian_par = 0x10010de, /* U+10DE GEORGIAN LETTER PAR */
                                //XK_Georgian_zhar = 0x10010df, /* U+10DF GEORGIAN LETTER ZHAR */
                                //XK_Georgian_rae = 0x10010e0, /* U+10E0 GEORGIAN LETTER RAE */
                                //XK_Georgian_san = 0x10010e1, /* U+10E1 GEORGIAN LETTER SAN */
                                //XK_Georgian_tar = 0x10010e2, /* U+10E2 GEORGIAN LETTER TAR */
                                //XK_Georgian_un = 0x10010e3, /* U+10E3 GEORGIAN LETTER UN */
                                //XK_Georgian_phar = 0x10010e4, /* U+10E4 GEORGIAN LETTER PHAR */
                                //XK_Georgian_khar = 0x10010e5, /* U+10E5 GEORGIAN LETTER KHAR */
                                //XK_Georgian_ghan = 0x10010e6, /* U+10E6 GEORGIAN LETTER GHAN */
                                //XK_Georgian_qar = 0x10010e7, /* U+10E7 GEORGIAN LETTER QAR */
                                //XK_Georgian_shin = 0x10010e8, /* U+10E8 GEORGIAN LETTER SHIN */
                                //XK_Georgian_chin = 0x10010e9, /* U+10E9 GEORGIAN LETTER CHIN */
                                //XK_Georgian_can = 0x10010ea, /* U+10EA GEORGIAN LETTER CAN */
                                //XK_Georgian_jil = 0x10010eb, /* U+10EB GEORGIAN LETTER JIL */
                                //XK_Georgian_cil = 0x10010ec, /* U+10EC GEORGIAN LETTER CIL */
                                //XK_Georgian_char = 0x10010ed, /* U+10ED GEORGIAN LETTER CHAR */
                                //XK_Georgian_xan = 0x10010ee, /* U+10EE GEORGIAN LETTER XAN */
                                //XK_Georgian_jhan = 0x10010ef, /* U+10EF GEORGIAN LETTER JHAN */
                                //XK_Georgian_hae = 0x10010f0, /* U+10F0 GEORGIAN LETTER HAE */
                                //XK_Georgian_he = 0x10010f1, /* U+10F1 GEORGIAN LETTER HE */
                                //XK_Georgian_hie = 0x10010f2, /* U+10F2 GEORGIAN LETTER HIE */
                                //XK_Georgian_we = 0x10010f3, /* U+10F3 GEORGIAN LETTER WE */
                                //XK_Georgian_har = 0x10010f4, /* U+10F4 GEORGIAN LETTER HAR */
                                //XK_Georgian_hoe = 0x10010f5, /* U+10F5 GEORGIAN LETTER HOE */
                                //XK_Georgian_fi = 0x10010f6, /* U+10F6 GEORGIAN LETTER FI */
                                //#endif /* XK_GEORGIAN */
                                /*
                                 * Azeri (and other Turkic or Caucasian languages)
                                 */
                                //#ifdef XK_CAUCASUS
                                /* latin */
                                //XK_Xabovedot = 0x1001e8a, /* U+1E8A LATIN CAPITAL LETTER X WITH DOT ABOVE */
                                //XK_Ibreve = 0x100012c, /* U+012C LATIN CAPITAL LETTER I WITH BREVE */
                                //XK_Zstroke = 0x10001b5, /* U+01B5 LATIN CAPITAL LETTER Z WITH STROKE */
                                //XK_Gcaron = 0x10001e6, /* U+01E6 LATIN CAPITAL LETTER G WITH CARON */
                                //XK_Ocaron = 0x10001d1, /* U+01D2 LATIN CAPITAL LETTER O WITH CARON */
                                //XK_Obarred = 0x100019f, /* U+019F LATIN CAPITAL LETTER O WITH MIDDLE TILDE */
                                //XK_xabovedot = 0x1001e8b, /* U+1E8B LATIN SMALL LETTER X WITH DOT ABOVE */
                                //XK_ibreve = 0x100012d, /* U+012D LATIN SMALL LETTER I WITH BREVE */
                                //XK_zstroke = 0x10001b6, /* U+01B6 LATIN SMALL LETTER Z WITH STROKE */
                                //XK_gcaron = 0x10001e7, /* U+01E7 LATIN SMALL LETTER G WITH CARON */
                                //XK_ocaron = 0x10001d2, /* U+01D2 LATIN SMALL LETTER O WITH CARON */
                                //XK_obarred = 0x1000275, /* U+0275 LATIN SMALL LETTER BARRED O */
                                //XK_SCHWA = 0x100018f, /* U+018F LATIN CAPITAL LETTER SCHWA */
                                //XK_schwa = 0x1000259, /* U+0259 LATIN SMALL LETTER SCHWA */
                                //                      /* those are not really Caucasus */
                                //                      /* For Inupiak */
                                //XK_Lbelowdot = 0x1001e36, /* U+1E36 LATIN CAPITAL LETTER L WITH DOT BELOW */
                                //XK_lbelowdot = 0x1001e37, /* U+1E37 LATIN SMALL LETTER L WITH DOT BELOW */
                                //#endif /* XK_CAUCASUS */
                                /*
                                 * Vietnamese
                                 */

        //#ifdef XK_VIETNAMESE
        //XK_Abelowdot = 0x1001ea0, /* U+1EA0 LATIN CAPITAL LETTER A WITH DOT BELOW */
        //XK_abelowdot = 0x1001ea1, /* U+1EA1 LATIN SMALL LETTER A WITH DOT BELOW */
        //XK_Ahook = 0x1001ea2, /* U+1EA2 LATIN CAPITAL LETTER A WITH HOOK ABOVE */
        //XK_ahook = 0x1001ea3, /* U+1EA3 LATIN SMALL LETTER A WITH HOOK ABOVE */
        //XK_Acircumflexacute = 0x1001ea4, /* U+1EA4 LATIN CAPITAL LETTER A WITH CIRCUMFLEX AND ACUTE */
        //XK_acircumflexacute = 0x1001ea5, /* U+1EA5 LATIN SMALL LETTER A WITH CIRCUMFLEX AND ACUTE */
        //XK_Acircumflexgrave = 0x1001ea6, /* U+1EA6 LATIN CAPITAL LETTER A WITH CIRCUMFLEX AND GRAVE */
        //XK_acircumflexgrave = 0x1001ea7, /* U+1EA7 LATIN SMALL LETTER A WITH CIRCUMFLEX AND GRAVE */
        //XK_Acircumflexhook = 0x1001ea8, /* U+1EA8 LATIN CAPITAL LETTER A WITH CIRCUMFLEX AND HOOK ABOVE */
        //XK_acircumflexhook = 0x1001ea9, /* U+1EA9 LATIN SMALL LETTER A WITH CIRCUMFLEX AND HOOK ABOVE */
        //XK_Acircumflextilde = 0x1001eaa, /* U+1EAA LATIN CAPITAL LETTER A WITH CIRCUMFLEX AND TILDE */
        //XK_acircumflextilde = 0x1001eab, /* U+1EAB LATIN SMALL LETTER A WITH CIRCUMFLEX AND TILDE */
        //XK_Acircumflexbelowdot = 0x1001eac, /* U+1EAC LATIN CAPITAL LETTER A WITH CIRCUMFLEX AND DOT BELOW */
        //XK_acircumflexbelowdot = 0x1001ead, /* U+1EAD LATIN SMALL LETTER A WITH CIRCUMFLEX AND DOT BELOW */
        //XK_Abreveacute = 0x1001eae, /* U+1EAE LATIN CAPITAL LETTER A WITH BREVE AND ACUTE */
        //XK_abreveacute = 0x1001eaf, /* U+1EAF LATIN SMALL LETTER A WITH BREVE AND ACUTE */
        //XK_Abrevegrave = 0x1001eb0, /* U+1EB0 LATIN CAPITAL LETTER A WITH BREVE AND GRAVE */
        //XK_abrevegrave = 0x1001eb1, /* U+1EB1 LATIN SMALL LETTER A WITH BREVE AND GRAVE */
        //XK_Abrevehook = 0x1001eb2, /* U+1EB2 LATIN CAPITAL LETTER A WITH BREVE AND HOOK ABOVE */
        //XK_abrevehook = 0x1001eb3, /* U+1EB3 LATIN SMALL LETTER A WITH BREVE AND HOOK ABOVE */
        //XK_Abrevetilde = 0x1001eb4, /* U+1EB4 LATIN CAPITAL LETTER A WITH BREVE AND TILDE */
        //XK_abrevetilde = 0x1001eb5, /* U+1EB5 LATIN SMALL LETTER A WITH BREVE AND TILDE */
        //XK_Abrevebelowdot = 0x1001eb6, /* U+1EB6 LATIN CAPITAL LETTER A WITH BREVE AND DOT BELOW */
        //XK_abrevebelowdot = 0x1001eb7, /* U+1EB7 LATIN SMALL LETTER A WITH BREVE AND DOT BELOW */
        //XK_Ebelowdot = 0x1001eb8, /* U+1EB8 LATIN CAPITAL LETTER E WITH DOT BELOW */
        //XK_ebelowdot = 0x1001eb9, /* U+1EB9 LATIN SMALL LETTER E WITH DOT BELOW */
        //XK_Ehook = 0x1001eba, /* U+1EBA LATIN CAPITAL LETTER E WITH HOOK ABOVE */
        //XK_ehook = 0x1001ebb, /* U+1EBB LATIN SMALL LETTER E WITH HOOK ABOVE */
        //XK_Etilde = 0x1001ebc, /* U+1EBC LATIN CAPITAL LETTER E WITH TILDE */
        //XK_etilde = 0x1001ebd, /* U+1EBD LATIN SMALL LETTER E WITH TILDE */
        //XK_Ecircumflexacute = 0x1001ebe, /* U+1EBE LATIN CAPITAL LETTER E WITH CIRCUMFLEX AND ACUTE */
        //XK_ecircumflexacute = 0x1001ebf, /* U+1EBF LATIN SMALL LETTER E WITH CIRCUMFLEX AND ACUTE */
        //XK_Ecircumflexgrave = 0x1001ec0, /* U+1EC0 LATIN CAPITAL LETTER E WITH CIRCUMFLEX AND GRAVE */
        //XK_ecircumflexgrave = 0x1001ec1, /* U+1EC1 LATIN SMALL LETTER E WITH CIRCUMFLEX AND GRAVE */
        //XK_Ecircumflexhook = 0x1001ec2, /* U+1EC2 LATIN CAPITAL LETTER E WITH CIRCUMFLEX AND HOOK ABOVE */
        //XK_ecircumflexhook = 0x1001ec3, /* U+1EC3 LATIN SMALL LETTER E WITH CIRCUMFLEX AND HOOK ABOVE */
        //XK_Ecircumflextilde = 0x1001ec4, /* U+1EC4 LATIN CAPITAL LETTER E WITH CIRCUMFLEX AND TILDE */
        //XK_ecircumflextilde = 0x1001ec5, /* U+1EC5 LATIN SMALL LETTER E WITH CIRCUMFLEX AND TILDE */
        //XK_Ecircumflexbelowdot = 0x1001ec6, /* U+1EC6 LATIN CAPITAL LETTER E WITH CIRCUMFLEX AND DOT BELOW */
        //XK_ecircumflexbelowdot = 0x1001ec7, /* U+1EC7 LATIN SMALL LETTER E WITH CIRCUMFLEX AND DOT BELOW */
        //XK_Ihook = 0x1001ec8, /* U+1EC8 LATIN CAPITAL LETTER I WITH HOOK ABOVE */
        //XK_ihook = 0x1001ec9, /* U+1EC9 LATIN SMALL LETTER I WITH HOOK ABOVE */
        //XK_Ibelowdot = 0x1001eca, /* U+1ECA LATIN CAPITAL LETTER I WITH DOT BELOW */
        //XK_ibelowdot = 0x1001ecb, /* U+1ECB LATIN SMALL LETTER I WITH DOT BELOW */
        //XK_Obelowdot = 0x1001ecc, /* U+1ECC LATIN CAPITAL LETTER O WITH DOT BELOW */
        //XK_obelowdot = 0x1001ecd, /* U+1ECD LATIN SMALL LETTER O WITH DOT BELOW */
        //XK_Ohook = 0x1001ece, /* U+1ECE LATIN CAPITAL LETTER O WITH HOOK ABOVE */
        //XK_ohook = 0x1001ecf, /* U+1ECF LATIN SMALL LETTER O WITH HOOK ABOVE */
        //XK_Ocircumflexacute = 0x1001ed0, /* U+1ED0 LATIN CAPITAL LETTER O WITH CIRCUMFLEX AND ACUTE */
        //XK_ocircumflexacute = 0x1001ed1, /* U+1ED1 LATIN SMALL LETTER O WITH CIRCUMFLEX AND ACUTE */
        //XK_Ocircumflexgrave = 0x1001ed2, /* U+1ED2 LATIN CAPITAL LETTER O WITH CIRCUMFLEX AND GRAVE */
        //XK_ocircumflexgrave = 0x1001ed3, /* U+1ED3 LATIN SMALL LETTER O WITH CIRCUMFLEX AND GRAVE */
        //XK_Ocircumflexhook = 0x1001ed4, /* U+1ED4 LATIN CAPITAL LETTER O WITH CIRCUMFLEX AND HOOK ABOVE */
        //XK_ocircumflexhook = 0x1001ed5, /* U+1ED5 LATIN SMALL LETTER O WITH CIRCUMFLEX AND HOOK ABOVE */
        //XK_Ocircumflextilde = 0x1001ed6, /* U+1ED6 LATIN CAPITAL LETTER O WITH CIRCUMFLEX AND TILDE */
        //XK_ocircumflextilde = 0x1001ed7, /* U+1ED7 LATIN SMALL LETTER O WITH CIRCUMFLEX AND TILDE */
        //XK_Ocircumflexbelowdot = 0x1001ed8, /* U+1ED8 LATIN CAPITAL LETTER O WITH CIRCUMFLEX AND DOT BELOW */
        //XK_ocircumflexbelowdot = 0x1001ed9, /* U+1ED9 LATIN SMALL LETTER O WITH CIRCUMFLEX AND DOT BELOW */
        //XK_Ohornacute = 0x1001eda, /* U+1EDA LATIN CAPITAL LETTER O WITH HORN AND ACUTE */
        //XK_ohornacute = 0x1001edb, /* U+1EDB LATIN SMALL LETTER O WITH HORN AND ACUTE */
        //XK_Ohorngrave = 0x1001edc, /* U+1EDC LATIN CAPITAL LETTER O WITH HORN AND GRAVE */
        //XK_ohorngrave = 0x1001edd, /* U+1EDD LATIN SMALL LETTER O WITH HORN AND GRAVE */
        //XK_Ohornhook = 0x1001ede, /* U+1EDE LATIN CAPITAL LETTER O WITH HORN AND HOOK ABOVE */
        //XK_ohornhook = 0x1001edf, /* U+1EDF LATIN SMALL LETTER O WITH HORN AND HOOK ABOVE */
        //XK_Ohorntilde = 0x1001ee0, /* U+1EE0 LATIN CAPITAL LETTER O WITH HORN AND TILDE */
        //XK_ohorntilde = 0x1001ee1, /* U+1EE1 LATIN SMALL LETTER O WITH HORN AND TILDE */
        //XK_Ohornbelowdot = 0x1001ee2, /* U+1EE2 LATIN CAPITAL LETTER O WITH HORN AND DOT BELOW */
        //XK_ohornbelowdot = 0x1001ee3, /* U+1EE3 LATIN SMALL LETTER O WITH HORN AND DOT BELOW */
        //XK_Ubelowdot = 0x1001ee4, /* U+1EE4 LATIN CAPITAL LETTER U WITH DOT BELOW */
        //XK_ubelowdot = 0x1001ee5, /* U+1EE5 LATIN SMALL LETTER U WITH DOT BELOW */
        //XK_Uhook = 0x1001ee6, /* U+1EE6 LATIN CAPITAL LETTER U WITH HOOK ABOVE */
        //XK_uhook = 0x1001ee7, /* U+1EE7 LATIN SMALL LETTER U WITH HOOK ABOVE */
        //XK_Uhornacute = 0x1001ee8, /* U+1EE8 LATIN CAPITAL LETTER U WITH HORN AND ACUTE */
        //XK_uhornacute = 0x1001ee9, /* U+1EE9 LATIN SMALL LETTER U WITH HORN AND ACUTE */
        //XK_Uhorngrave = 0x1001eea, /* U+1EEA LATIN CAPITAL LETTER U WITH HORN AND GRAVE */
        //XK_uhorngrave = 0x1001eeb, /* U+1EEB LATIN SMALL LETTER U WITH HORN AND GRAVE */
        //XK_Uhornhook = 0x1001eec, /* U+1EEC LATIN CAPITAL LETTER U WITH HORN AND HOOK ABOVE */
        //XK_uhornhook = 0x1001eed, /* U+1EED LATIN SMALL LETTER U WITH HORN AND HOOK ABOVE */
        //XK_Uhorntilde = 0x1001eee, /* U+1EEE LATIN CAPITAL LETTER U WITH HORN AND TILDE */
        //XK_uhorntilde = 0x1001eef, /* U+1EEF LATIN SMALL LETTER U WITH HORN AND TILDE */
        //XK_Uhornbelowdot = 0x1001ef0, /* U+1EF0 LATIN CAPITAL LETTER U WITH HORN AND DOT BELOW */
        //XK_uhornbelowdot = 0x1001ef1, /* U+1EF1 LATIN SMALL LETTER U WITH HORN AND DOT BELOW */
        //XK_Ybelowdot = 0x1001ef4, /* U+1EF4 LATIN CAPITAL LETTER Y WITH DOT BELOW */
        //XK_ybelowdot = 0x1001ef5, /* U+1EF5 LATIN SMALL LETTER Y WITH DOT BELOW */
        //XK_Yhook = 0x1001ef6, /* U+1EF6 LATIN CAPITAL LETTER Y WITH HOOK ABOVE */
        //XK_yhook = 0x1001ef7, /* U+1EF7 LATIN SMALL LETTER Y WITH HOOK ABOVE */
        //XK_Ytilde = 0x1001ef8, /* U+1EF8 LATIN CAPITAL LETTER Y WITH TILDE */
        //XK_ytilde = 0x1001ef9, /* U+1EF9 LATIN SMALL LETTER Y WITH TILDE */
        //XK_Ohorn = 0x10001a0, /* U+01A0 LATIN CAPITAL LETTER O WITH HORN */
        //XK_ohorn = 0x10001a1, /* U+01A1 LATIN SMALL LETTER O WITH HORN */
        //XK_Uhorn = 0x10001af, /* U+01AF LATIN CAPITAL LETTER U WITH HORN */
        //XK_uhorn = 0x10001b0, /* U+01B0 LATIN SMALL LETTER U WITH HORN */
        //#endif /* XK_VIETNAMESE */
        //#ifdef XK_CURRENCY
        //XK_EcuSign = 0x10020a0, /* U+20A0 EURO-CURRENCY SIGN */
        //XK_ColonSign = 0x10020a1, /* U+20A1 COLON SIGN */
        //XK_CruzeiroSign = 0x10020a2, /* U+20A2 CRUZEIRO SIGN */
        //XK_FFrancSign = 0x10020a3, /* U+20A3 FRENCH FRANC SIGN */
        //XK_LiraSign = 0x10020a4, /* U+20A4 LIRA SIGN */
        //XK_MillSign = 0x10020a5, /* U+20A5 MILL SIGN */
        //XK_NairaSign = 0x10020a6, /* U+20A6 NAIRA SIGN */
        //XK_PesetaSign = 0x10020a7, /* U+20A7 PESETA SIGN */
        //XK_RupeeSign = 0x10020a8, /* U+20A8 RUPEE SIGN */
        //XK_WonSign = 0x10020a9, /* U+20A9 WON SIGN */
        //XK_NewSheqelSign = 0x10020aa, /* U+20AA NEW SHEQEL SIGN */
        //XK_DongSign = 0x10020ab, /* U+20AB DONG SIGN */
        XK_EuroSign = 0x20ac, /* U+20AC EURO SIGN */
                              //#endif /* XK_CURRENCY */
    }

    public static class X11KeyConverter
    {//warning: radioactive, do not expand
        public static char X11KeyToUnicode(X11KeyCode key)
        {
            switch ((ushort)key)
            {
                case 0x0020: return (char)0x0020;
                case 0x0021: return (char)0x0021;
                case 0x0022: return (char)0x0022;
                case 0x0023: return (char)0x0023;
                case 0x0024: return (char)0x0024;
                case 0x0025: return (char)0x0025;
                case 0x0026: return (char)0x0026;
                case 0x0027: return (char)0x0027;
                //case 0x0027: return (char)0x0027;
                case 0x0028: return (char)0x0028;
                case 0x0029: return (char)0x0029;
                case 0x002a: return (char)0x002a;
                case 0x002b: return (char)0x002b;
                case 0x002c: return (char)0x002c;
                case 0x002d: return (char)0x002d;
                case 0x002e: return (char)0x002e;
                case 0x002f: return (char)0x002f;
                case 0x0030: return (char)0x0030;
                case 0x0031: return (char)0x0031;
                case 0x0032: return (char)0x0032;
                case 0x0033: return (char)0x0033;
                case 0x0034: return (char)0x0034;
                case 0x0035: return (char)0x0035;
                case 0x0036: return (char)0x0036;
                case 0x0037: return (char)0x0037;
                case 0x0038: return (char)0x0038;
                case 0x0039: return (char)0x0039;
                case 0x003a: return (char)0x003a;
                case 0x003b: return (char)0x003b;
                case 0x003c: return (char)0x003c;
                case 0x003d: return (char)0x003d;
                case 0x003e: return (char)0x003e;
                case 0x003f: return (char)0x003f;
                case 0x0040: return (char)0x0040;
                case 0x0041: return (char)0x0041;
                case 0x0042: return (char)0x0042;
                case 0x0043: return (char)0x0043;
                case 0x0044: return (char)0x0044;
                case 0x0045: return (char)0x0045;
                case 0x0046: return (char)0x0046;
                case 0x0047: return (char)0x0047;
                case 0x0048: return (char)0x0048;
                case 0x0049: return (char)0x0049;
                case 0x004a: return (char)0x004a;
                case 0x004b: return (char)0x004b;
                case 0x004c: return (char)0x004c;
                case 0x004d: return (char)0x004d;
                case 0x004e: return (char)0x004e;
                case 0x004f: return (char)0x004f;
                case 0x0050: return (char)0x0050;
                case 0x0051: return (char)0x0051;
                case 0x0052: return (char)0x0052;
                case 0x0053: return (char)0x0053;
                case 0x0054: return (char)0x0054;
                case 0x0055: return (char)0x0055;
                case 0x0056: return (char)0x0056;
                case 0x0057: return (char)0x0057;
                case 0x0058: return (char)0x0058;
                case 0x0059: return (char)0x0059;
                case 0x005a: return (char)0x005a;
                case 0x005b: return (char)0x005b;
                case 0x005c: return (char)0x005c;
                case 0x005d: return (char)0x005d;
                case 0x005e: return (char)0x005e;
                case 0x005f: return (char)0x005f;
                case 0x0060: return (char)0x0060;
                //case 0x0060: return (char)0x0060;
                case 0x0061: return (char)0x0061;
                case 0x0062: return (char)0x0062;
                case 0x0063: return (char)0x0063;
                case 0x0064: return (char)0x0064;
                case 0x0065: return (char)0x0065;
                case 0x0066: return (char)0x0066;
                case 0x0067: return (char)0x0067;
                case 0x0068: return (char)0x0068;
                case 0x0069: return (char)0x0069;
                case 0x006a: return (char)0x006a;
                case 0x006b: return (char)0x006b;
                case 0x006c: return (char)0x006c;
                case 0x006d: return (char)0x006d;
                case 0x006e: return (char)0x006e;
                case 0x006f: return (char)0x006f;
                case 0x0070: return (char)0x0070;
                case 0x0071: return (char)0x0071;
                case 0x0072: return (char)0x0072;
                case 0x0073: return (char)0x0073;
                case 0x0074: return (char)0x0074;
                case 0x0075: return (char)0x0075;
                case 0x0076: return (char)0x0076;
                case 0x0077: return (char)0x0077;
                case 0x0078: return (char)0x0078;
                case 0x0079: return (char)0x0079;
                case 0x007a: return (char)0x007a;
                case 0x007b: return (char)0x007b;
                case 0x007c: return (char)0x007c;
                case 0x007d: return (char)0x007d;
                case 0x007e: return (char)0x007e;
                case 0x00a0: return (char)0x00a0;
                case 0x00a1: return (char)0x00a1;
                case 0x00a2: return (char)0x00a2;
                case 0x00a3: return (char)0x00a3;
                case 0x00a4: return (char)0x00a4;
                case 0x00a5: return (char)0x00a5;
                case 0x00a6: return (char)0x00a6;
                case 0x00a7: return (char)0x00a7;
                case 0x00a8: return (char)0x00a8;
                case 0x00a9: return (char)0x00a9;
                case 0x00aa: return (char)0x00aa;
                case 0x00ab: return (char)0x00ab;
                case 0x00ac: return (char)0x00ac;
                case 0x00ad: return (char)0x00ad;
                case 0x00ae: return (char)0x00ae;
                case 0x00af: return (char)0x00af;
                case 0x00b0: return (char)0x00b0;
                case 0x00b1: return (char)0x00b1;
                case 0x00b2: return (char)0x00b2;
                case 0x00b3: return (char)0x00b3;
                case 0x00b4: return (char)0x00b4;
                case 0x00b5: return (char)0x00b5;
                case 0x00b6: return (char)0x00b6;
                case 0x00b7: return (char)0x00b7;
                case 0x00b8: return (char)0x00b8;
                case 0x00b9: return (char)0x00b9;
                case 0x00ba: return (char)0x00ba;
                case 0x00bb: return (char)0x00bb;
                case 0x00bc: return (char)0x00bc;
                case 0x00bd: return (char)0x00bd;
                case 0x00be: return (char)0x00be;
                case 0x00bf: return (char)0x00bf;
                case 0x00c0: return (char)0x00c0;
                case 0x00c1: return (char)0x00c1;
                case 0x00c2: return (char)0x00c2;
                case 0x00c3: return (char)0x00c3;
                case 0x00c4: return (char)0x00c4;
                case 0x00c5: return (char)0x00c5;
                case 0x00c6: return (char)0x00c6;
                case 0x00c7: return (char)0x00c7;
                case 0x00c8: return (char)0x00c8;
                case 0x00c9: return (char)0x00c9;
                case 0x00ca: return (char)0x00ca;
                case 0x00cb: return (char)0x00cb;
                case 0x00cc: return (char)0x00cc;
                case 0x00cd: return (char)0x00cd;
                case 0x00ce: return (char)0x00ce;
                case 0x00cf: return (char)0x00cf;
                case 0x00d0: return (char)0x00d0;
                //case 0x00d0: return (char)0x00d0;
                case 0x00d1: return (char)0x00d1;
                case 0x00d2: return (char)0x00d2;
                case 0x00d3: return (char)0x00d3;
                case 0x00d4: return (char)0x00d4;
                case 0x00d5: return (char)0x00d5;
                case 0x00d6: return (char)0x00d6;
                case 0x00d7: return (char)0x00d7;
                case 0x00d8: return (char)0x00d8;
                case 0x00d9: return (char)0x00d9;
                case 0x00da: return (char)0x00da;
                case 0x00db: return (char)0x00db;
                case 0x00dc: return (char)0x00dc;
                case 0x00dd: return (char)0x00dd;
                case 0x00de: return (char)0x00de;
                //case 0x00de: return (char)0x00de;
                case 0x00df: return (char)0x00df;
                case 0x00e0: return (char)0x00e0;
                case 0x00e1: return (char)0x00e1;
                case 0x00e2: return (char)0x00e2;
                case 0x00e3: return (char)0x00e3;
                case 0x00e4: return (char)0x00e4;
                case 0x00e5: return (char)0x00e5;
                case 0x00e6: return (char)0x00e6;
                case 0x00e7: return (char)0x00e7;
                case 0x00e8: return (char)0x00e8;
                case 0x00e9: return (char)0x00e9;
                case 0x00ea: return (char)0x00ea;
                case 0x00eb: return (char)0x00eb;
                case 0x00ec: return (char)0x00ec;
                case 0x00ed: return (char)0x00ed;
                case 0x00ee: return (char)0x00ee;
                case 0x00ef: return (char)0x00ef;
                case 0x00f0: return (char)0x00f0;
                case 0x00f1: return (char)0x00f1;
                case 0x00f2: return (char)0x00f2;
                case 0x00f3: return (char)0x00f3;
                case 0x00f4: return (char)0x00f4;
                case 0x00f5: return (char)0x00f5;
                case 0x00f6: return (char)0x00f6;
                case 0x00f7: return (char)0x00f7;
                case 0x00f8: return (char)0x00f8;
                case 0x00f9: return (char)0x00f9;
                case 0x00fa: return (char)0x00fa;
                case 0x00fb: return (char)0x00fb;
                case 0x00fc: return (char)0x00fc;
                case 0x00fd: return (char)0x00fd;
                case 0x00fe: return (char)0x00fe;
                case 0x00ff: return (char)0x00ff;
                case 0x01a1: return (char)0x0104;
                case 0x01a2: return (char)0x02d8;
                case 0x01a3: return (char)0x0141;
                case 0x01a5: return (char)0x013d;
                case 0x01a6: return (char)0x015a;
                case 0x01a9: return (char)0x0160;
                case 0x01aa: return (char)0x015e;
                case 0x01ab: return (char)0x0164;
                case 0x01ac: return (char)0x0179;
                case 0x01ae: return (char)0x017d;
                case 0x01af: return (char)0x017b;
                case 0x01b1: return (char)0x0105;
                case 0x01b2: return (char)0x02db;
                case 0x01b3: return (char)0x0142;
                case 0x01b5: return (char)0x013e;
                case 0x01b6: return (char)0x015b;
                case 0x01b7: return (char)0x02c7;
                case 0x01b9: return (char)0x0161;
                case 0x01ba: return (char)0x015f;
                case 0x01bb: return (char)0x0165;
                case 0x01bc: return (char)0x017a;
                case 0x01bd: return (char)0x02dd;
                case 0x01be: return (char)0x017e;
                case 0x01bf: return (char)0x017c;
                case 0x01c0: return (char)0x0154;
                case 0x01c3: return (char)0x0102;
                case 0x01c5: return (char)0x0139;
                case 0x01c6: return (char)0x0106;
                case 0x01c8: return (char)0x010c;
                case 0x01ca: return (char)0x0118;
                case 0x01cc: return (char)0x011a;
                case 0x01cf: return (char)0x010e;
                case 0x01d0: return (char)0x0110;
                case 0x01d1: return (char)0x0143;
                case 0x01d2: return (char)0x0147;
                case 0x01d5: return (char)0x0150;
                case 0x01d8: return (char)0x0158;
                case 0x01d9: return (char)0x016e;
                case 0x01db: return (char)0x0170;
                case 0x01de: return (char)0x0162;
                case 0x01e0: return (char)0x0155;
                case 0x01e3: return (char)0x0103;
                case 0x01e5: return (char)0x013a;
                case 0x01e6: return (char)0x0107;
                case 0x01e8: return (char)0x010d;
                case 0x01ea: return (char)0x0119;
                case 0x01ec: return (char)0x011b;
                case 0x01ef: return (char)0x010f;
                case 0x01f0: return (char)0x0111;
                case 0x01f1: return (char)0x0144;
                case 0x01f2: return (char)0x0148;
                case 0x01f5: return (char)0x0151;
                case 0x01f8: return (char)0x0159;
                case 0x01f9: return (char)0x016f;
                case 0x01fb: return (char)0x0171;
                case 0x01fe: return (char)0x0163;
                case 0x01ff: return (char)0x02d9;
                case 0x02a1: return (char)0x0126;
                case 0x02a6: return (char)0x0124;
                case 0x02a9: return (char)0x0130;
                case 0x02ab: return (char)0x011e;
                case 0x02ac: return (char)0x0134;
                case 0x02b1: return (char)0x0127;
                case 0x02b6: return (char)0x0125;
                case 0x02b9: return (char)0x0131;
                case 0x02bb: return (char)0x011f;
                case 0x02bc: return (char)0x0135;
                case 0x02c5: return (char)0x010a;
                case 0x02c6: return (char)0x0108;
                case 0x02d5: return (char)0x0120;
                case 0x02d8: return (char)0x011c;
                case 0x02dd: return (char)0x016c;
                case 0x02de: return (char)0x015c;
                case 0x02e5: return (char)0x010b;
                case 0x02e6: return (char)0x0109;
                case 0x02f5: return (char)0x0121;
                case 0x02f8: return (char)0x011d;
                case 0x02fd: return (char)0x016d;
                case 0x02fe: return (char)0x015d;
                case 0x03a2: return (char)0x0138;
                case 0x03a3: return (char)0x0156;
                case 0x03a5: return (char)0x0128;
                case 0x03a6: return (char)0x013b;
                case 0x03aa: return (char)0x0112;
                case 0x03ab: return (char)0x0122;
                case 0x03ac: return (char)0x0166;
                case 0x03b3: return (char)0x0157;
                case 0x03b5: return (char)0x0129;
                case 0x03b6: return (char)0x013c;
                case 0x03ba: return (char)0x0113;
                case 0x03bb: return (char)0x0123;
                case 0x03bc: return (char)0x0167;
                case 0x03bd: return (char)0x014a;
                case 0x03bf: return (char)0x014b;
                case 0x03c0: return (char)0x0100;
                case 0x03c7: return (char)0x012e;
                case 0x03cc: return (char)0x0116;
                case 0x03cf: return (char)0x012a;
                case 0x03d1: return (char)0x0145;
                case 0x03d2: return (char)0x014c;
                case 0x03d3: return (char)0x0136;
                case 0x03d9: return (char)0x0172;
                case 0x03dd: return (char)0x0168;
                case 0x03de: return (char)0x016a;
                case 0x03e0: return (char)0x0101;
                case 0x03e7: return (char)0x012f;
                case 0x03ec: return (char)0x0117;
                case 0x03ef: return (char)0x012b;
                case 0x03f1: return (char)0x0146;
                case 0x03f2: return (char)0x014d;
                case 0x03f3: return (char)0x0137;
                case 0x03f9: return (char)0x0173;
                case 0x03fd: return (char)0x0169;
                case 0x03fe: return (char)0x016b;
                case 0x047e: return (char)0x203e;
                case 0x04a1: return (char)0x3002;
                case 0x04a2: return (char)0x300c;
                case 0x04a3: return (char)0x300d;
                case 0x04a4: return (char)0x3001;
                case 0x04a5: return (char)0x30fb;
                case 0x04a6: return (char)0x30f2;
                case 0x04a7: return (char)0x30a1;
                case 0x04a8: return (char)0x30a3;
                case 0x04a9: return (char)0x30a5;
                case 0x04aa: return (char)0x30a7;
                case 0x04ab: return (char)0x30a9;
                case 0x04ac: return (char)0x30e3;
                case 0x04ad: return (char)0x30e5;
                case 0x04ae: return (char)0x30e7;
                case 0x04af: return (char)0x30c3;
                case 0x04b0: return (char)0x30fc;
                case 0x04b1: return (char)0x30a2;
                case 0x04b2: return (char)0x30a4;
                case 0x04b3: return (char)0x30a6;
                case 0x04b4: return (char)0x30a8;
                case 0x04b5: return (char)0x30aa;
                case 0x04b6: return (char)0x30ab;
                case 0x04b7: return (char)0x30ad;
                case 0x04b8: return (char)0x30af;
                case 0x04b9: return (char)0x30b1;
                case 0x04ba: return (char)0x30b3;
                case 0x04bb: return (char)0x30b5;
                case 0x04bc: return (char)0x30b7;
                case 0x04bd: return (char)0x30b9;
                case 0x04be: return (char)0x30bb;
                case 0x04bf: return (char)0x30bd;
                case 0x04c0: return (char)0x30bf;
                case 0x04c1: return (char)0x30c1;
                case 0x04c2: return (char)0x30c4;
                case 0x04c3: return (char)0x30c6;
                case 0x04c4: return (char)0x30c8;
                case 0x04c5: return (char)0x30ca;
                case 0x04c6: return (char)0x30cb;
                case 0x04c7: return (char)0x30cc;
                case 0x04c8: return (char)0x30cd;
                case 0x04c9: return (char)0x30ce;
                case 0x04ca: return (char)0x30cf;
                case 0x04cb: return (char)0x30d2;
                case 0x04cc: return (char)0x30d5;
                case 0x04cd: return (char)0x30d8;
                case 0x04ce: return (char)0x30db;
                case 0x04cf: return (char)0x30de;
                case 0x04d0: return (char)0x30df;
                case 0x04d1: return (char)0x30e0;
                case 0x04d2: return (char)0x30e1;
                case 0x04d3: return (char)0x30e2;
                case 0x04d4: return (char)0x30e4;
                case 0x04d5: return (char)0x30e6;
                case 0x04d6: return (char)0x30e8;
                case 0x04d7: return (char)0x30e9;
                case 0x04d8: return (char)0x30ea;
                case 0x04d9: return (char)0x30eb;
                case 0x04da: return (char)0x30ec;
                case 0x04db: return (char)0x30ed;
                case 0x04dc: return (char)0x30ef;
                case 0x04dd: return (char)0x30f3;
                case 0x04de: return (char)0x309b;
                case 0x04df: return (char)0x309c;
                case 0x05ac: return (char)0x060c;
                case 0x05bb: return (char)0x061b;
                case 0x05bf: return (char)0x061f;
                case 0x05c1: return (char)0x0621;
                case 0x05c2: return (char)0x0622;
                case 0x05c3: return (char)0x0623;
                case 0x05c4: return (char)0x0624;
                case 0x05c5: return (char)0x0625;
                case 0x05c6: return (char)0x0626;
                case 0x05c7: return (char)0x0627;
                case 0x05c8: return (char)0x0628;
                case 0x05c9: return (char)0x0629;
                case 0x05ca: return (char)0x062a;
                case 0x05cb: return (char)0x062b;
                case 0x05cc: return (char)0x062c;
                case 0x05cd: return (char)0x062d;
                case 0x05ce: return (char)0x062e;
                case 0x05cf: return (char)0x062f;
                case 0x05d0: return (char)0x0630;
                case 0x05d1: return (char)0x0631;
                case 0x05d2: return (char)0x0632;
                case 0x05d3: return (char)0x0633;
                case 0x05d4: return (char)0x0634;
                case 0x05d5: return (char)0x0635;
                case 0x05d6: return (char)0x0636;
                case 0x05d7: return (char)0x0637;
                case 0x05d8: return (char)0x0638;
                case 0x05d9: return (char)0x0639;
                case 0x05da: return (char)0x063a;
                case 0x05e0: return (char)0x0640;
                case 0x05e1: return (char)0x0641;
                case 0x05e2: return (char)0x0642;
                case 0x05e3: return (char)0x0643;
                case 0x05e4: return (char)0x0644;
                case 0x05e5: return (char)0x0645;
                case 0x05e6: return (char)0x0646;
                case 0x05e7: return (char)0x0647;
                case 0x05e8: return (char)0x0648;
                case 0x05e9: return (char)0x0649;
                case 0x05ea: return (char)0x064a;
                case 0x05eb: return (char)0x064b;
                case 0x05ec: return (char)0x064c;
                case 0x05ed: return (char)0x064d;
                case 0x05ee: return (char)0x064e;
                case 0x05ef: return (char)0x064f;
                case 0x05f0: return (char)0x0650;
                case 0x05f1: return (char)0x0651;
                case 0x05f2: return (char)0x0652;
                case 0x06a1: return (char)0x0452;
                case 0x06a2: return (char)0x0453;
                case 0x06a3: return (char)0x0451;
                case 0x06a4: return (char)0x0454;
                case 0x06a5: return (char)0x0455;
                case 0x06a6: return (char)0x0456;
                case 0x06a7: return (char)0x0457;
                case 0x06a8: return (char)0x0458;
                case 0x06a9: return (char)0x0459;
                case 0x06aa: return (char)0x045a;
                case 0x06ab: return (char)0x045b;
                case 0x06ac: return (char)0x045c;
                case 0x06ae: return (char)0x045e;
                case 0x06af: return (char)0x045f;
                case 0x06b0: return (char)0x2116;
                case 0x06b1: return (char)0x0402;
                case 0x06b2: return (char)0x0403;
                case 0x06b3: return (char)0x0401;
                case 0x06b4: return (char)0x0404;
                case 0x06b5: return (char)0x0405;
                case 0x06b6: return (char)0x0406;
                case 0x06b7: return (char)0x0407;
                case 0x06b8: return (char)0x0408;
                case 0x06b9: return (char)0x0409;
                case 0x06ba: return (char)0x040a;
                case 0x06bb: return (char)0x040b;
                case 0x06bc: return (char)0x040c;
                case 0x06be: return (char)0x040e;
                case 0x06bf: return (char)0x040f;
                case 0x06c0: return (char)0x044e;
                case 0x06c1: return (char)0x0430;
                case 0x06c2: return (char)0x0431;
                case 0x06c3: return (char)0x0446;
                case 0x06c4: return (char)0x0434;
                case 0x06c5: return (char)0x0435;
                case 0x06c6: return (char)0x0444;
                case 0x06c7: return (char)0x0433;
                case 0x06c8: return (char)0x0445;
                case 0x06c9: return (char)0x0438;
                case 0x06ca: return (char)0x0439;
                case 0x06cb: return (char)0x043a;
                case 0x06cc: return (char)0x043b;
                case 0x06cd: return (char)0x043c;
                case 0x06ce: return (char)0x043d;
                case 0x06cf: return (char)0x043e;
                case 0x06d0: return (char)0x043f;
                case 0x06d1: return (char)0x044f;
                case 0x06d2: return (char)0x0440;
                case 0x06d3: return (char)0x0441;
                case 0x06d4: return (char)0x0442;
                case 0x06d5: return (char)0x0443;
                case 0x06d6: return (char)0x0436;
                case 0x06d7: return (char)0x0432;
                case 0x06d8: return (char)0x044c;
                case 0x06d9: return (char)0x044b;
                case 0x06da: return (char)0x0437;
                case 0x06db: return (char)0x0448;
                case 0x06dc: return (char)0x044d;
                case 0x06dd: return (char)0x0449;
                case 0x06de: return (char)0x0447;
                case 0x06df: return (char)0x044a;
                case 0x06e0: return (char)0x042e;
                case 0x06e1: return (char)0x0410;
                case 0x06e2: return (char)0x0411;
                case 0x06e3: return (char)0x0426;
                case 0x06e4: return (char)0x0414;
                case 0x06e5: return (char)0x0415;
                case 0x06e6: return (char)0x0424;
                case 0x06e7: return (char)0x0413;
                case 0x06e8: return (char)0x0425;
                case 0x06e9: return (char)0x0418;
                case 0x06ea: return (char)0x0419;
                case 0x06eb: return (char)0x041a;
                case 0x06ec: return (char)0x041b;
                case 0x06ed: return (char)0x041c;
                case 0x06ee: return (char)0x041d;
                case 0x06ef: return (char)0x041e;
                case 0x06f0: return (char)0x041f;
                case 0x06f1: return (char)0x042f;
                case 0x06f2: return (char)0x0420;
                case 0x06f3: return (char)0x0421;
                case 0x06f4: return (char)0x0422;
                case 0x06f5: return (char)0x0423;
                case 0x06f6: return (char)0x0416;
                case 0x06f7: return (char)0x0412;
                case 0x06f8: return (char)0x042c;
                case 0x06f9: return (char)0x042b;
                case 0x06fa: return (char)0x0417;
                case 0x06fb: return (char)0x0428;
                case 0x06fc: return (char)0x042d;
                case 0x06fd: return (char)0x0429;
                case 0x06fe: return (char)0x0427;
                case 0x06ff: return (char)0x042a;
                case 0x07a1: return (char)0x0386;
                case 0x07a2: return (char)0x0388;
                case 0x07a3: return (char)0x0389;
                case 0x07a4: return (char)0x038a;
                case 0x07a5: return (char)0x03aa;
                case 0x07a7: return (char)0x038c;
                case 0x07a8: return (char)0x038e;
                case 0x07a9: return (char)0x03ab;
                case 0x07ab: return (char)0x038f;
                case 0x07ae: return (char)0x0385;
                case 0x07af: return (char)0x2015;
                case 0x07b1: return (char)0x03ac;
                case 0x07b2: return (char)0x03ad;
                case 0x07b3: return (char)0x03ae;
                case 0x07b4: return (char)0x03af;
                case 0x07b5: return (char)0x03ca;
                case 0x07b6: return (char)0x0390;
                case 0x07b7: return (char)0x03cc;
                case 0x07b8: return (char)0x03cd;
                case 0x07b9: return (char)0x03cb;
                case 0x07ba: return (char)0x03b0;
                case 0x07bb: return (char)0x03ce;
                case 0x07c1: return (char)0x0391;
                case 0x07c2: return (char)0x0392;
                case 0x07c3: return (char)0x0393;
                case 0x07c4: return (char)0x0394;
                case 0x07c5: return (char)0x0395;
                case 0x07c6: return (char)0x0396;
                case 0x07c7: return (char)0x0397;
                case 0x07c8: return (char)0x0398;
                case 0x07c9: return (char)0x0399;
                case 0x07ca: return (char)0x039a;
                case 0x07cb: return (char)0x039b;
                //case 0x07cb: return (char)0x039b;
                case 0x07cc: return (char)0x039c;
                case 0x07cd: return (char)0x039d;
                case 0x07ce: return (char)0x039e;
                case 0x07cf: return (char)0x039f;
                case 0x07d0: return (char)0x03a0;
                case 0x07d1: return (char)0x03a1;
                case 0x07d2: return (char)0x03a3;
                case 0x07d4: return (char)0x03a4;
                case 0x07d5: return (char)0x03a5;
                case 0x07d6: return (char)0x03a6;
                case 0x07d7: return (char)0x03a7;
                case 0x07d8: return (char)0x03a8;
                case 0x07d9: return (char)0x03a9;
                case 0x07e1: return (char)0x03b1;
                case 0x07e2: return (char)0x03b2;
                case 0x07e3: return (char)0x03b3;
                case 0x07e4: return (char)0x03b4;
                case 0x07e5: return (char)0x03b5;
                case 0x07e6: return (char)0x03b6;
                case 0x07e7: return (char)0x03b7;
                case 0x07e8: return (char)0x03b8;
                case 0x07e9: return (char)0x03b9;
                case 0x07ea: return (char)0x03ba;
                case 0x07eb: return (char)0x03bb;
                case 0x07ec: return (char)0x03bc;
                case 0x07ed: return (char)0x03bd;
                case 0x07ee: return (char)0x03be;
                case 0x07ef: return (char)0x03bf;
                case 0x07f0: return (char)0x03c0;
                case 0x07f1: return (char)0x03c1;
                case 0x07f2: return (char)0x03c3;
                case 0x07f3: return (char)0x03c2;
                case 0x07f4: return (char)0x03c4;
                case 0x07f5: return (char)0x03c5;
                case 0x07f6: return (char)0x03c6;
                case 0x07f7: return (char)0x03c7;
                case 0x07f8: return (char)0x03c8;
                case 0x07f9: return (char)0x03c9;
                case 0x08a1: return (char)0x23b7;
                case 0x08a2: return (char)0x250c;
                case 0x08a3: return (char)0x2500;
                case 0x08a4: return (char)0x2320;
                case 0x08a5: return (char)0x2321;
                case 0x08a6: return (char)0x2502;
                case 0x08a7: return (char)0x23a1;
                case 0x08a8: return (char)0x23a3;
                case 0x08a9: return (char)0x23a4;
                case 0x08aa: return (char)0x23a6;
                case 0x08ab: return (char)0x239b;
                case 0x08ac: return (char)0x239d;
                case 0x08ad: return (char)0x239e;
                case 0x08ae: return (char)0x23a0;
                case 0x08af: return (char)0x23a8;
                case 0x08b0: return (char)0x23ac;
                case 0x08b1: return (char)0x0000;
                case 0x08b2: return (char)0x0000;
                case 0x08b3: return (char)0x0000;
                case 0x08b4: return (char)0x0000;
                case 0x08b5: return (char)0x0000;
                case 0x08b6: return (char)0x0000;
                case 0x08b7: return (char)0x0000;
                case 0x08bc: return (char)0x2264;
                case 0x08bd: return (char)0x2260;
                case 0x08be: return (char)0x2265;
                case 0x08bf: return (char)0x222b;
                case 0x08c0: return (char)0x2234;
                case 0x08c1: return (char)0x221d;
                case 0x08c2: return (char)0x221e;
                case 0x08c5: return (char)0x2207;
                case 0x08c8: return (char)0x223c;
                case 0x08c9: return (char)0x2243;
                case 0x08cd: return (char)0x21d4;
                case 0x08ce: return (char)0x21d2;
                case 0x08cf: return (char)0x2261;
                case 0x08d6: return (char)0x221a;
                case 0x08da: return (char)0x2282;
                case 0x08db: return (char)0x2283;
                case 0x08dc: return (char)0x2229;
                case 0x08dd: return (char)0x222a;
                case 0x08de: return (char)0x2227;
                case 0x08df: return (char)0x2228;
                case 0x08ef: return (char)0x2202;
                case 0x08f6: return (char)0x0192;
                case 0x08fb: return (char)0x2190;
                case 0x08fc: return (char)0x2191;
                case 0x08fd: return (char)0x2192;
                case 0x08fe: return (char)0x2193;
                case 0x09df: return (char)0x0000;
                case 0x09e0: return (char)0x25c6;
                case 0x09e1: return (char)0x2592;
                case 0x09e2: return (char)0x2409;
                case 0x09e3: return (char)0x240c;
                case 0x09e4: return (char)0x240d;
                case 0x09e5: return (char)0x240a;
                case 0x09e8: return (char)0x2424;
                case 0x09e9: return (char)0x240b;
                case 0x09ea: return (char)0x2518;
                case 0x09eb: return (char)0x2510;
                case 0x09ec: return (char)0x250c;
                case 0x09ed: return (char)0x2514;
                case 0x09ee: return (char)0x253c;
                case 0x09ef: return (char)0x23ba;
                case 0x09f0: return (char)0x23bb;
                case 0x09f1: return (char)0x2500;
                case 0x09f2: return (char)0x23bc;
                case 0x09f3: return (char)0x23bd;
                case 0x09f4: return (char)0x251c;
                case 0x09f5: return (char)0x2524;
                case 0x09f6: return (char)0x2534;
                case 0x09f7: return (char)0x252c;
                case 0x09f8: return (char)0x2502;
                case 0x0aa1: return (char)0x2003;
                case 0x0aa2: return (char)0x2002;
                case 0x0aa3: return (char)0x2004;
                case 0x0aa4: return (char)0x2005;
                case 0x0aa5: return (char)0x2007;
                case 0x0aa6: return (char)0x2008;
                case 0x0aa7: return (char)0x2009;
                case 0x0aa8: return (char)0x200a;
                case 0x0aa9: return (char)0x2014;
                case 0x0aaa: return (char)0x2013;
                case 0x0aac: return (char)0x2423;
                case 0x0aae: return (char)0x2026;
                case 0x0aaf: return (char)0x2025;
                case 0x0ab0: return (char)0x2153;
                case 0x0ab1: return (char)0x2154;
                case 0x0ab2: return (char)0x2155;
                case 0x0ab3: return (char)0x2156;
                case 0x0ab4: return (char)0x2157;
                case 0x0ab5: return (char)0x2158;
                case 0x0ab6: return (char)0x2159;
                case 0x0ab7: return (char)0x215a;
                case 0x0ab8: return (char)0x2105;
                case 0x0abb: return (char)0x2012;
                case 0x0abc: return (char)0x27e8;
                case 0x0abd: return (char)0x002e;
                case 0x0abe: return (char)0x27e9;
                case 0x0abf: return (char)0x0000;
                case 0x0ac3: return (char)0x215b;
                case 0x0ac4: return (char)0x215c;
                case 0x0ac5: return (char)0x215d;
                case 0x0ac6: return (char)0x215e;
                case 0x0ac9: return (char)0x2122;
                case 0x0aca: return (char)0x2613;
                case 0x0acb: return (char)0x0000;
                case 0x0acc: return (char)0x25c1;
                case 0x0acd: return (char)0x25b7;
                case 0x0ace: return (char)0x25cb;
                case 0x0acf: return (char)0x25af;
                case 0x0ad0: return (char)0x2018;
                case 0x0ad1: return (char)0x2019;
                case 0x0ad2: return (char)0x201c;
                case 0x0ad3: return (char)0x201d;
                case 0x0ad4: return (char)0x211e;
                case 0x0ad6: return (char)0x2032;
                case 0x0ad7: return (char)0x2033;
                case 0x0ad9: return (char)0x271d;
                case 0x0ada: return (char)0x0000;
                case 0x0adb: return (char)0x25ac;
                case 0x0adc: return (char)0x25c0;
                case 0x0add: return (char)0x25b6;
                case 0x0ade: return (char)0x25cf;
                case 0x0adf: return (char)0x25ae;
                case 0x0ae0: return (char)0x25e6;
                case 0x0ae1: return (char)0x25ab;
                case 0x0ae2: return (char)0x25ad;
                case 0x0ae3: return (char)0x25b3;
                case 0x0ae4: return (char)0x25bd;
                case 0x0ae5: return (char)0x2606;
                case 0x0ae6: return (char)0x2022;
                case 0x0ae7: return (char)0x25aa;
                case 0x0ae8: return (char)0x25b2;
                case 0x0ae9: return (char)0x25bc;
                case 0x0aea: return (char)0x261c;
                case 0x0aeb: return (char)0x261e;
                case 0x0aec: return (char)0x2663;
                case 0x0aed: return (char)0x2666;
                case 0x0aee: return (char)0x2665;
                case 0x0af0: return (char)0x2720;
                case 0x0af1: return (char)0x2020;
                case 0x0af2: return (char)0x2021;
                case 0x0af3: return (char)0x2713;
                case 0x0af4: return (char)0x2717;
                case 0x0af5: return (char)0x266f;
                case 0x0af6: return (char)0x266d;
                case 0x0af7: return (char)0x2642;
                case 0x0af8: return (char)0x2640;
                case 0x0af9: return (char)0x260e;
                case 0x0afa: return (char)0x2315;
                case 0x0afb: return (char)0x2117;
                case 0x0afc: return (char)0x2038;
                case 0x0afd: return (char)0x201a;
                case 0x0afe: return (char)0x201e;
                case 0x0aff: return (char)0x0000;
                case 0x0ba3: return (char)0x003c;
                case 0x0ba6: return (char)0x003e;
                case 0x0ba8: return (char)0x2228;
                case 0x0ba9: return (char)0x2227;
                case 0x0bc0: return (char)0x00af;
                case 0x0bc2: return (char)0x22a5;
                case 0x0bc3: return (char)0x2229;
                case 0x0bc4: return (char)0x230a;
                case 0x0bc6: return (char)0x005f;
                case 0x0bca: return (char)0x2218;
                case 0x0bcc: return (char)0x2395;
                case 0x0bce: return (char)0x22a4;
                case 0x0bcf: return (char)0x25cb;
                case 0x0bd3: return (char)0x2308;
                case 0x0bd6: return (char)0x222a;
                case 0x0bd8: return (char)0x2283;
                case 0x0bda: return (char)0x2282;
                case 0x0bdc: return (char)0x22a2;
                case 0x0bfc: return (char)0x22a3;
                case 0x0cdf: return (char)0x2017;
                case 0x0ce0: return (char)0x05d0;
                case 0x0ce1: return (char)0x05d1;
                //case 0x0ce1: return (char)0x05d1;
                case 0x0ce2: return (char)0x05d2;
                //case 0x0ce2: return (char)0x05d2;
                case 0x0ce3: return (char)0x05d3;
                //case 0x0ce3: return (char)0x05d3;
                case 0x0ce4: return (char)0x05d4;
                case 0x0ce5: return (char)0x05d5;
                case 0x0ce6: return (char)0x05d6;
                //case 0x0ce6: return (char)0x05d6;
                case 0x0ce7: return (char)0x05d7;
                //case 0x0ce7: return (char)0x05d7;
                case 0x0ce8: return (char)0x05d8;
                //case 0x0ce8: return (char)0x05d8;
                case 0x0ce9: return (char)0x05d9;
                case 0x0cea: return (char)0x05da;
                case 0x0ceb: return (char)0x05db;
                case 0x0cec: return (char)0x05dc;
                case 0x0ced: return (char)0x05dd;
                case 0x0cee: return (char)0x05de;
                case 0x0cef: return (char)0x05df;
                case 0x0cf0: return (char)0x05e0;
                case 0x0cf1: return (char)0x05e1;
                //case 0x0cf1: return (char)0x05e1;
                case 0x0cf2: return (char)0x05e2;
                case 0x0cf3: return (char)0x05e3;
                case 0x0cf4: return (char)0x05e4;
                case 0x0cf5: return (char)0x05e5;
                //case 0x0cf5: return (char)0x05e5;
                case 0x0cf6: return (char)0x05e6;
                //case 0x0cf6: return (char)0x05e6;
                case 0x0cf7: return (char)0x05e7;
                //case 0x0cf7: return (char)0x05e7;
                case 0x0cf8: return (char)0x05e8;
                case 0x0cf9: return (char)0x05e9;
                case 0x0cfa: return (char)0x05ea;
                //case 0x0cfa: return (char)0x05ea;
                case 0x0da1: return (char)0x0e01;
                case 0x0da2: return (char)0x0e02;
                case 0x0da3: return (char)0x0e03;
                case 0x0da4: return (char)0x0e04;
                case 0x0da5: return (char)0x0e05;
                case 0x0da6: return (char)0x0e06;
                case 0x0da7: return (char)0x0e07;
                case 0x0da8: return (char)0x0e08;
                case 0x0da9: return (char)0x0e09;
                case 0x0daa: return (char)0x0e0a;
                case 0x0dab: return (char)0x0e0b;
                case 0x0dac: return (char)0x0e0c;
                case 0x0dad: return (char)0x0e0d;
                case 0x0dae: return (char)0x0e0e;
                case 0x0daf: return (char)0x0e0f;
                case 0x0db0: return (char)0x0e10;
                case 0x0db1: return (char)0x0e11;
                case 0x0db2: return (char)0x0e12;
                case 0x0db3: return (char)0x0e13;
                case 0x0db4: return (char)0x0e14;
                case 0x0db5: return (char)0x0e15;
                case 0x0db6: return (char)0x0e16;
                case 0x0db7: return (char)0x0e17;
                case 0x0db8: return (char)0x0e18;
                case 0x0db9: return (char)0x0e19;
                case 0x0dba: return (char)0x0e1a;
                case 0x0dbb: return (char)0x0e1b;
                case 0x0dbc: return (char)0x0e1c;
                case 0x0dbd: return (char)0x0e1d;
                case 0x0dbe: return (char)0x0e1e;
                case 0x0dbf: return (char)0x0e1f;
                case 0x0dc0: return (char)0x0e20;
                case 0x0dc1: return (char)0x0e21;
                case 0x0dc2: return (char)0x0e22;
                case 0x0dc3: return (char)0x0e23;
                case 0x0dc4: return (char)0x0e24;
                case 0x0dc5: return (char)0x0e25;
                case 0x0dc6: return (char)0x0e26;
                case 0x0dc7: return (char)0x0e27;
                case 0x0dc8: return (char)0x0e28;
                case 0x0dc9: return (char)0x0e29;
                case 0x0dca: return (char)0x0e2a;
                case 0x0dcb: return (char)0x0e2b;
                case 0x0dcc: return (char)0x0e2c;
                case 0x0dcd: return (char)0x0e2d;
                case 0x0dce: return (char)0x0e2e;
                case 0x0dcf: return (char)0x0e2f;
                case 0x0dd0: return (char)0x0e30;
                case 0x0dd1: return (char)0x0e31;
                case 0x0dd2: return (char)0x0e32;
                case 0x0dd3: return (char)0x0e33;
                case 0x0dd4: return (char)0x0e34;
                case 0x0dd5: return (char)0x0e35;
                case 0x0dd6: return (char)0x0e36;
                case 0x0dd7: return (char)0x0e37;
                case 0x0dd8: return (char)0x0e38;
                case 0x0dd9: return (char)0x0e39;
                case 0x0dda: return (char)0x0e3a;
                case 0x0dde: return (char)0x0000;
                case 0x0ddf: return (char)0x0e3f;
                case 0x0de0: return (char)0x0e40;
                case 0x0de1: return (char)0x0e41;
                case 0x0de2: return (char)0x0e42;
                case 0x0de3: return (char)0x0e43;
                case 0x0de4: return (char)0x0e44;
                case 0x0de5: return (char)0x0e45;
                case 0x0de6: return (char)0x0e46;
                case 0x0de7: return (char)0x0e47;
                case 0x0de8: return (char)0x0e48;
                case 0x0de9: return (char)0x0e49;
                case 0x0dea: return (char)0x0e4a;
                case 0x0deb: return (char)0x0e4b;
                case 0x0dec: return (char)0x0e4c;
                case 0x0ded: return (char)0x0e4d;
                case 0x0df0: return (char)0x0e50;
                case 0x0df1: return (char)0x0e51;
                case 0x0df2: return (char)0x0e52;
                case 0x0df3: return (char)0x0e53;
                case 0x0df4: return (char)0x0e54;
                case 0x0df5: return (char)0x0e55;
                case 0x0df6: return (char)0x0e56;
                case 0x0df7: return (char)0x0e57;
                case 0x0df8: return (char)0x0e58;
                case 0x0df9: return (char)0x0e59;
                case 0x0ea1: return (char)0x3131;
                case 0x0ea2: return (char)0x3132;
                case 0x0ea3: return (char)0x3133;
                case 0x0ea4: return (char)0x3134;
                case 0x0ea5: return (char)0x3135;
                case 0x0ea6: return (char)0x3136;
                case 0x0ea7: return (char)0x3137;
                case 0x0ea8: return (char)0x3138;
                case 0x0ea9: return (char)0x3139;
                case 0x0eaa: return (char)0x313a;
                case 0x0eab: return (char)0x313b;
                case 0x0eac: return (char)0x313c;
                case 0x0ead: return (char)0x313d;
                case 0x0eae: return (char)0x313e;
                case 0x0eaf: return (char)0x313f;
                case 0x0eb0: return (char)0x3140;
                case 0x0eb1: return (char)0x3141;
                case 0x0eb2: return (char)0x3142;
                case 0x0eb3: return (char)0x3143;
                case 0x0eb4: return (char)0x3144;
                case 0x0eb5: return (char)0x3145;
                case 0x0eb6: return (char)0x3146;
                case 0x0eb7: return (char)0x3147;
                case 0x0eb8: return (char)0x3148;
                case 0x0eb9: return (char)0x3149;
                case 0x0eba: return (char)0x314a;
                case 0x0ebb: return (char)0x314b;
                case 0x0ebc: return (char)0x314c;
                case 0x0ebd: return (char)0x314d;
                case 0x0ebe: return (char)0x314e;
                case 0x0ebf: return (char)0x314f;
                case 0x0ec0: return (char)0x3150;
                case 0x0ec1: return (char)0x3151;
                case 0x0ec2: return (char)0x3152;
                case 0x0ec3: return (char)0x3153;
                case 0x0ec4: return (char)0x3154;
                case 0x0ec5: return (char)0x3155;
                case 0x0ec6: return (char)0x3156;
                case 0x0ec7: return (char)0x3157;
                case 0x0ec8: return (char)0x3158;
                case 0x0ec9: return (char)0x3159;
                case 0x0eca: return (char)0x315a;
                case 0x0ecb: return (char)0x315b;
                case 0x0ecc: return (char)0x315c;
                case 0x0ecd: return (char)0x315d;
                case 0x0ece: return (char)0x315e;
                case 0x0ecf: return (char)0x315f;
                case 0x0ed0: return (char)0x3160;
                case 0x0ed1: return (char)0x3161;
                case 0x0ed2: return (char)0x3162;
                case 0x0ed3: return (char)0x3163;
                case 0x0ed4: return (char)0x11a8;
                case 0x0ed5: return (char)0x11a9;
                case 0x0ed6: return (char)0x11aa;
                case 0x0ed7: return (char)0x11ab;
                case 0x0ed8: return (char)0x11ac;
                case 0x0ed9: return (char)0x11ad;
                case 0x0eda: return (char)0x11ae;
                case 0x0edb: return (char)0x11af;
                case 0x0edc: return (char)0x11b0;
                case 0x0edd: return (char)0x11b1;
                case 0x0ede: return (char)0x11b2;
                case 0x0edf: return (char)0x11b3;
                case 0x0ee0: return (char)0x11b4;
                case 0x0ee1: return (char)0x11b5;
                case 0x0ee2: return (char)0x11b6;
                case 0x0ee3: return (char)0x11b7;
                case 0x0ee4: return (char)0x11b8;
                case 0x0ee5: return (char)0x11b9;
                case 0x0ee6: return (char)0x11ba;
                case 0x0ee7: return (char)0x11bb;
                case 0x0ee8: return (char)0x11bc;
                case 0x0ee9: return (char)0x11bd;
                case 0x0eea: return (char)0x11be;
                case 0x0eeb: return (char)0x11bf;
                case 0x0eec: return (char)0x11c0;
                case 0x0eed: return (char)0x11c1;
                case 0x0eee: return (char)0x11c2;
                case 0x0eef: return (char)0x316d;
                case 0x0ef0: return (char)0x3171;
                case 0x0ef1: return (char)0x3178;
                case 0x0ef2: return (char)0x317f;
                case 0x0ef3: return (char)0x3181;
                case 0x0ef4: return (char)0x3184;
                case 0x0ef5: return (char)0x3186;
                case 0x0ef6: return (char)0x318d;
                case 0x0ef7: return (char)0x318e;
                case 0x0ef8: return (char)0x11eb;
                case 0x0ef9: return (char)0x11f0;
                case 0x0efa: return (char)0x11f9;
                case 0x0eff: return (char)0x20a9;
                case 0x13bc: return (char)0x0152;
                case 0x13bd: return (char)0x0153;
                case 0x13be: return (char)0x0178;
                case 0x20a0: return (char)0x20a0;
                case 0x20a1: return (char)0x20a1;
                case 0x20a2: return (char)0x20a2;
                case 0x20a3: return (char)0x20a3;
                case 0x20a4: return (char)0x20a4;
                case 0x20a5: return (char)0x20a5;
                case 0x20a6: return (char)0x20a6;
                case 0x20a7: return (char)0x20a7;
                case 0x20a8: return (char)0x20a8;
                case 0x20a9: return (char)0x20a9;
                case 0x20aa: return (char)0x20aa;
                case 0x20ab: return (char)0x20ab;
                case 0x20ac: return (char)0x20ac;
                case 0xfd01: return (char)0x0000;
                case 0xfd02: return (char)0x0000;
                case 0xfd03: return (char)0x0000;
                case 0xfd04: return (char)0x0000;
                case 0xfd05: return (char)0x0000;
                case 0xfd06: return (char)0x0000;
                case 0xfd07: return (char)0x0000;
                case 0xfd08: return (char)0x0000;
                case 0xfd09: return (char)0x0000;
                case 0xfd0a: return (char)0x0000;
                case 0xfd0b: return (char)0x0000;
                case 0xfd0c: return (char)0x0000;
                case 0xfd0d: return (char)0x0000;
                case 0xfd0e: return (char)0x0000;
                case 0xfd0f: return (char)0x0000;
                case 0xfd10: return (char)0x0000;
                case 0xfd11: return (char)0x0000;
                case 0xfd12: return (char)0x0000;
                case 0xfd13: return (char)0x0000;
                case 0xfd14: return (char)0x0000;
                case 0xfd15: return (char)0x0000;
                case 0xfd16: return (char)0x0000;
                case 0xfd17: return (char)0x0000;
                case 0xfd18: return (char)0x0000;
                case 0xfd19: return (char)0x0000;
                case 0xfd1a: return (char)0x0000;
                case 0xfd1b: return (char)0x0000;
                case 0xfd1c: return (char)0x0000;
                case 0xfd1d: return (char)0x0000;
                case 0xfd1e: return (char)0x0000;
                case 0xfe01: return (char)0x0000;
                case 0xfe02: return (char)0x0000;
                case 0xfe03: return (char)0x0000;
                case 0xfe04: return (char)0x0000;
                case 0xfe05: return (char)0x0000;
                case 0xfe06: return (char)0x0000;
                case 0xfe07: return (char)0x0000;
                case 0xfe08: return (char)0x0000;
                case 0xfe09: return (char)0x0000;
                case 0xfe0a: return (char)0x0000;
                case 0xfe0b: return (char)0x0000;
                case 0xfe0c: return (char)0x0000;
                case 0xfe0d: return (char)0x0000;
                case 0xfe0e: return (char)0x0000;
                case 0xfe0f: return (char)0x0000;
                case 0xfe20: return (char)0x0000;
                case 0xfe21: return (char)0x0000;
                case 0xfe22: return (char)0x0000;
                case 0xfe23: return (char)0x0000;
                case 0xfe24: return (char)0x0000;
                case 0xfe25: return (char)0x0000;
                case 0xfe26: return (char)0x0000;
                case 0xfe27: return (char)0x0000;
                case 0xfe28: return (char)0x0000;
                case 0xfe29: return (char)0x0000;
                case 0xfe2a: return (char)0x0000;
                case 0xfe2b: return (char)0x0000;
                case 0xfe2c: return (char)0x0000;
                case 0xfe2d: return (char)0x0000;
                case 0xfe2e: return (char)0x0000;
                case 0xfe2f: return (char)0x0000;
                case 0xfe30: return (char)0x0000;
                case 0xfe31: return (char)0x0000;
                case 0xfe32: return (char)0x0000;
                case 0xfe33: return (char)0x0000;
                case 0xfe34: return (char)0x0000;
                case 0xfe50: return (char)0x0300;
                case 0xfe51: return (char)0x0301;
                case 0xfe52: return (char)0x0302;
                case 0xfe53: return (char)0x0303;
                case 0xfe54: return (char)0x0304;
                case 0xfe55: return (char)0x0306;
                case 0xfe56: return (char)0x0307;
                case 0xfe57: return (char)0x0308;
                case 0xfe58: return (char)0x030a;
                case 0xfe59: return (char)0x030b;
                case 0xfe5a: return (char)0x030c;
                case 0xfe5b: return (char)0x0327;
                case 0xfe5c: return (char)0x0328;
                case 0xfe5d: return (char)0x0345;
                case 0xfe5e: return (char)0x3099;
                case 0xfe5f: return (char)0x309a;
                case 0xfe70: return (char)0x0000;
                case 0xfe71: return (char)0x0000;
                case 0xfe72: return (char)0x0000;
                case 0xfe73: return (char)0x0000;
                case 0xfe74: return (char)0x0000;
                case 0xfe75: return (char)0x0000;
                case 0xfe76: return (char)0x0000;
                case 0xfe77: return (char)0x0000;
                case 0xfe78: return (char)0x0000;
                case 0xfe79: return (char)0x0000;
                case 0xfe7a: return (char)0x0000;
                case 0xfed0: return (char)0x0000;
                case 0xfed1: return (char)0x0000;
                case 0xfed2: return (char)0x0000;
                case 0xfed4: return (char)0x0000;
                case 0xfed5: return (char)0x0000;
                case 0xfee0: return (char)0x0000;
                case 0xfee1: return (char)0x0000;
                case 0xfee2: return (char)0x0000;
                case 0xfee3: return (char)0x0000;
                case 0xfee4: return (char)0x0000;
                case 0xfee5: return (char)0x0000;
                case 0xfee6: return (char)0x0000;
                case 0xfee7: return (char)0x0000;
                case 0xfee8: return (char)0x0000;
                case 0xfee9: return (char)0x0000;
                case 0xfeea: return (char)0x0000;
                case 0xfeeb: return (char)0x0000;
                case 0xfeec: return (char)0x0000;
                case 0xfeed: return (char)0x0000;
                case 0xfeee: return (char)0x0000;
                case 0xfeef: return (char)0x0000;
                case 0xfef0: return (char)0x0000;
                case 0xfef1: return (char)0x0000;
                case 0xfef2: return (char)0x0000;
                case 0xfef3: return (char)0x0000;
                case 0xfef4: return (char)0x0000;
                case 0xfef5: return (char)0x0000;
                case 0xfef6: return (char)0x0000;
                case 0xfef7: return (char)0x0000;
                case 0xfef8: return (char)0x0000;
                case 0xfef9: return (char)0x0000;
                case 0xfefa: return (char)0x0000;
                case 0xfefb: return (char)0x0000;
                case 0xfefc: return (char)0x0000;
                case 0xfefd: return (char)0x0000;
                case 0xff08: return (char)0x0008;
                case 0xff09: return (char)0x0009;
                case 0xff0a: return (char)0x000a;
                case 0xff0b: return (char)0x000b;
                case 0xff0d: return (char)0x000d;
                case 0xff13: return (char)0x0013;
                case 0xff14: return (char)0x0014;
                case 0xff15: return (char)0x0015;
                case 0xff1b: return (char)0x001b;
                case 0xff20: return (char)0x0000;
                case 0xff21: return (char)0x0000;
                case 0xff22: return (char)0x0000;
                case 0xff23: return (char)0x0000;
                case 0xff24: return (char)0x0000;
                case 0xff25: return (char)0x0000;
                case 0xff26: return (char)0x0000;
                case 0xff27: return (char)0x0000;
                case 0xff28: return (char)0x0000;
                case 0xff29: return (char)0x0000;
                case 0xff2a: return (char)0x0000;
                case 0xff2b: return (char)0x0000;
                case 0xff2c: return (char)0x0000;
                case 0xff2d: return (char)0x0000;
                case 0xff2e: return (char)0x0000;
                case 0xff2f: return (char)0x0000;
                case 0xff30: return (char)0x0000;
                case 0xff31: return (char)0x0000;
                case 0xff32: return (char)0x0000;
                case 0xff33: return (char)0x0000;
                case 0xff34: return (char)0x0000;
                case 0xff35: return (char)0x0000;
                case 0xff36: return (char)0x0000;
                case 0xff37: return (char)0x0000;
                case 0xff38: return (char)0x0000;
                case 0xff39: return (char)0x0000;
                case 0xff3a: return (char)0x0000;
                case 0xff3b: return (char)0x0000;
                case 0xff3c: return (char)0x0000;
                case 0xff3d: return (char)0x0000;
                case 0xff3e: return (char)0x0000;
                case 0xff3f: return (char)0x0000;
                case 0xff50: return (char)0x0000;
                case 0xff51: return (char)0x0000;
                case 0xff52: return (char)0x0000;
                case 0xff53: return (char)0x0000;
                case 0xff54: return (char)0x0000;
                case 0xff55: return (char)0x0000;
                case 0xff56: return (char)0x0000;
                case 0xff57: return (char)0x0000;
                case 0xff58: return (char)0x0000;
                case 0xff60: return (char)0x0000;
                case 0xff61: return (char)0x0000;
                case 0xff62: return (char)0x0000;
                case 0xff63: return (char)0x0000;
                case 0xff65: return (char)0x0000;
                case 0xff66: return (char)0x0000;
                case 0xff67: return (char)0x0000;
                case 0xff68: return (char)0x0000;
                case 0xff69: return (char)0x0000;
                case 0xff6a: return (char)0x0000;
                case 0xff6b: return (char)0x0000;
                case 0xff7e: return (char)0x0000;
                case 0xff7f: return (char)0x0000;
                case 0xff80: return (char)0x0020;
                case 0xff89: return (char)0x0009;
                case 0xff8d: return (char)0x000d;
                case 0xff91: return (char)0x0000;
                case 0xff92: return (char)0x0000;
                case 0xff93: return (char)0x0000;
                case 0xff94: return (char)0x0000;
                case 0xff95: return (char)0x0000;
                case 0xff96: return (char)0x0000;
                case 0xff97: return (char)0x0000;
                case 0xff98: return (char)0x0000;
                case 0xff99: return (char)0x0000;
                case 0xff9a: return (char)0x0000;
                case 0xff9b: return (char)0x0000;
                case 0xff9c: return (char)0x0000;
                case 0xff9d: return (char)0x0000;
                case 0xff9e: return (char)0x0000;
                case 0xff9f: return (char)0x0000;
                case 0xffaa: return (char)0x002a;
                case 0xffab: return (char)0x002b;
                case 0xffac: return (char)0x002c;
                case 0xffad: return (char)0x002d;
                case 0xffae: return (char)0x002e;
                case 0xffaf: return (char)0x002f;
                case 0xffb0: return (char)0x0030;
                case 0xffb1: return (char)0x0031;
                case 0xffb2: return (char)0x0032;
                case 0xffb3: return (char)0x0033;
                case 0xffb4: return (char)0x0034;
                case 0xffb5: return (char)0x0035;
                case 0xffb6: return (char)0x0036;
                case 0xffb7: return (char)0x0037;
                case 0xffb8: return (char)0x0038;
                case 0xffb9: return (char)0x0039;
                case 0xffbd: return (char)0x003d;
                case 0xffbe: return (char)0x0000;
                case 0xffbf: return (char)0x0000;
                case 0xffc0: return (char)0x0000;
                case 0xffc1: return (char)0x0000;
                case 0xffc2: return (char)0x0000;
                case 0xffc3: return (char)0x0000;
                case 0xffc4: return (char)0x0000;
                case 0xffc5: return (char)0x0000;
                case 0xffc6: return (char)0x0000;
                case 0xffc7: return (char)0x0000;
                case 0xffc8: return (char)0x0000;
                case 0xffc9: return (char)0x0000;
                case 0xffca: return (char)0x0000;
                case 0xffcb: return (char)0x0000;
                case 0xffcc: return (char)0x0000;
                case 0xffcd: return (char)0x0000;
                case 0xffce: return (char)0x0000;
                case 0xffcf: return (char)0x0000;
                case 0xffd0: return (char)0x0000;
                case 0xffd1: return (char)0x0000;
                case 0xffd2: return (char)0x0000;
                case 0xffd3: return (char)0x0000;
                case 0xffd4: return (char)0x0000;
                case 0xffd5: return (char)0x0000;
                case 0xffd6: return (char)0x0000;
                case 0xffd7: return (char)0x0000;
                case 0xffd8: return (char)0x0000;
                case 0xffd9: return (char)0x0000;
                case 0xffda: return (char)0x0000;
                case 0xffdb: return (char)0x0000;
                case 0xffdc: return (char)0x0000;
                case 0xffdd: return (char)0x0000;
                case 0xffde: return (char)0x0000;
                case 0xffdf: return (char)0x0000;
                case 0xffe0: return (char)0x0000;
                case 0xffe1: return (char)0x0000;
                case 0xffe2: return (char)0x0000;
                case 0xffe3: return (char)0x0000;
                case 0xffe4: return (char)0x0000;
                case 0xffe5: return (char)0x0000;
                case 0xffe6: return (char)0x0000;
                case 0xffe7: return (char)0x0000;
                case 0xffe8: return (char)0x0000;
                case 0xffe9: return (char)0x0000;
                case 0xffea: return (char)0x0000;
                case 0xffeb: return (char)0x0000;
                case 0xffec: return (char)0x0000;
                case 0xffed: return (char)0x0000;
                case 0xffee: return (char)0x0000;
                case 0xffff: return (char)0x0000;
                case 0x06ad: return (char)0x0491;
                case 0x06bd: return (char)0x0490;
                case 0x14a1: return (char)0x0000;
                case 0x14a2: return (char)0x0587;
                case 0x14a3: return (char)0x0589;
                case 0x14a4: return (char)0x0029;
                case 0x14a5: return (char)0x0028;
                case 0x14a6: return (char)0x00bb;
                case 0x14a7: return (char)0x00ab;
                case 0x14a8: return (char)0x2014;
                case 0x14a9: return (char)0x002e;
                case 0x14aa: return (char)0x055d;
                case 0x14ab: return (char)0x002c;
                case 0x14ac: return (char)0x2013;
                case 0x14ad: return (char)0x058a;
                case 0x14ae: return (char)0x2026;
                case 0x14af: return (char)0x055c;
                case 0x14b0: return (char)0x055b;
                case 0x14b1: return (char)0x055e;
                case 0x14b2: return (char)0x0531;
                case 0x14b3: return (char)0x0561;
                case 0x14b4: return (char)0x0532;
                case 0x14b5: return (char)0x0562;
                case 0x14b6: return (char)0x0533;
                case 0x14b7: return (char)0x0563;
                case 0x14b8: return (char)0x0534;
                case 0x14b9: return (char)0x0564;
                case 0x14ba: return (char)0x0535;
                case 0x14bb: return (char)0x0565;
                case 0x14bc: return (char)0x0536;
                case 0x14bd: return (char)0x0566;
                case 0x14be: return (char)0x0537;
                case 0x14bf: return (char)0x0567;
                case 0x14c0: return (char)0x0538;
                case 0x14c1: return (char)0x0568;
                case 0x14c2: return (char)0x0539;
                case 0x14c3: return (char)0x0569;
                case 0x14c4: return (char)0x053a;
                case 0x14c5: return (char)0x056a;
                case 0x14c6: return (char)0x053b;
                case 0x14c7: return (char)0x056b;
                case 0x14c8: return (char)0x053c;
                case 0x14c9: return (char)0x056c;
                case 0x14ca: return (char)0x053d;
                case 0x14cb: return (char)0x056d;
                case 0x14cc: return (char)0x053e;
                case 0x14cd: return (char)0x056e;
                case 0x14ce: return (char)0x053f;
                case 0x14cf: return (char)0x056f;
                case 0x14d0: return (char)0x0540;
                case 0x14d1: return (char)0x0570;
                case 0x14d2: return (char)0x0541;
                case 0x14d3: return (char)0x0571;
                case 0x14d4: return (char)0x0542;
                case 0x14d5: return (char)0x0572;
                case 0x14d6: return (char)0x0543;
                case 0x14d7: return (char)0x0573;
                case 0x14d8: return (char)0x0544;
                case 0x14d9: return (char)0x0574;
                case 0x14da: return (char)0x0545;
                case 0x14db: return (char)0x0575;
                case 0x14dc: return (char)0x0546;
                case 0x14dd: return (char)0x0576;
                case 0x14de: return (char)0x0547;
                case 0x14df: return (char)0x0577;
                case 0x14e0: return (char)0x0548;
                case 0x14e1: return (char)0x0578;
                case 0x14e2: return (char)0x0549;
                case 0x14e3: return (char)0x0579;
                case 0x14e4: return (char)0x054a;
                case 0x14e5: return (char)0x057a;
                case 0x14e6: return (char)0x054b;
                case 0x14e7: return (char)0x057b;
                case 0x14e8: return (char)0x054c;
                case 0x14e9: return (char)0x057c;
                case 0x14ea: return (char)0x054d;
                case 0x14eb: return (char)0x057d;
                case 0x14ec: return (char)0x054e;
                case 0x14ed: return (char)0x057e;
                case 0x14ee: return (char)0x054f;
                case 0x14ef: return (char)0x057f;
                case 0x14f0: return (char)0x0550;
                case 0x14f1: return (char)0x0580;
                case 0x14f2: return (char)0x0551;
                case 0x14f3: return (char)0x0581;
                case 0x14f4: return (char)0x0552;
                case 0x14f5: return (char)0x0582;
                case 0x14f6: return (char)0x0553;
                case 0x14f7: return (char)0x0583;
                case 0x14f8: return (char)0x0554;
                case 0x14f9: return (char)0x0584;
                case 0x14fa: return (char)0x0555;
                case 0x14fb: return (char)0x0585;
                case 0x14fc: return (char)0x0556;
                case 0x14fd: return (char)0x0586;
                case 0x14fe: return (char)0x055a;
                case 0x14ff: return (char)0x00a7;
                case 0x15d0: return (char)0x10d0;
                case 0x15d1: return (char)0x10d1;
                case 0x15d2: return (char)0x10d2;
                case 0x15d3: return (char)0x10d3;
                case 0x15d4: return (char)0x10d4;
                case 0x15d5: return (char)0x10d5;
                case 0x15d6: return (char)0x10d6;
                case 0x15d7: return (char)0x10d7;
                case 0x15d8: return (char)0x10d8;
                case 0x15d9: return (char)0x10d9;
                case 0x15da: return (char)0x10da;
                case 0x15db: return (char)0x10db;
                case 0x15dc: return (char)0x10dc;
                case 0x15dd: return (char)0x10dd;
                case 0x15de: return (char)0x10de;
                case 0x15df: return (char)0x10df;
                case 0x15e0: return (char)0x10e0;
                case 0x15e1: return (char)0x10e1;
                case 0x15e2: return (char)0x10e2;
                case 0x15e3: return (char)0x10e3;
                case 0x15e4: return (char)0x10e4;
                case 0x15e5: return (char)0x10e5;
                case 0x15e6: return (char)0x10e6;
                case 0x15e7: return (char)0x10e7;
                case 0x15e8: return (char)0x10e8;
                case 0x15e9: return (char)0x10e9;
                case 0x15ea: return (char)0x10ea;
                case 0x15eb: return (char)0x10eb;
                case 0x15ec: return (char)0x10ec;
                case 0x15ed: return (char)0x10ed;
                case 0x15ee: return (char)0x10ee;
                case 0x15ef: return (char)0x10ef;
                case 0x15f0: return (char)0x10f0;
                case 0x15f1: return (char)0x10f1;
                case 0x15f2: return (char)0x10f2;
                case 0x15f3: return (char)0x10f3;
                case 0x15f4: return (char)0x10f4;
                case 0x15f5: return (char)0x10f5;
                case 0x15f6: return (char)0x10f6;
                case 0x12a1: return (char)0x1e02;
                case 0x12a2: return (char)0x1e03;
                case 0x12a6: return (char)0x1e0a;
                case 0x12a8: return (char)0x1e80;
                case 0x12aa: return (char)0x1e82;
                case 0x12ab: return (char)0x1e0b;
                case 0x12ac: return (char)0x1ef2;
                case 0x12b0: return (char)0x1e1e;
                case 0x12b1: return (char)0x1e1f;
                case 0x12b4: return (char)0x1e40;
                case 0x12b5: return (char)0x1e41;
                case 0x12b7: return (char)0x1e56;
                case 0x12b8: return (char)0x1e81;
                case 0x12b9: return (char)0x1e57;
                case 0x12ba: return (char)0x1e83;
                case 0x12bb: return (char)0x1e60;
                case 0x12bc: return (char)0x1ef3;
                case 0x12bd: return (char)0x1e84;
                case 0x12be: return (char)0x1e85;
                case 0x12bf: return (char)0x1e61;
                case 0x12d0: return (char)0x0174;
                case 0x12d7: return (char)0x1e6a;
                case 0x12de: return (char)0x0176;
                case 0x12f0: return (char)0x0175;
                case 0x12f7: return (char)0x1e6b;
                case 0x12fe: return (char)0x0177;
                case 0x0590: return (char)0x06f0;
                case 0x0591: return (char)0x06f1;
                case 0x0592: return (char)0x06f2;
                case 0x0593: return (char)0x06f3;
                case 0x0594: return (char)0x06f4;
                case 0x0595: return (char)0x06f5;
                case 0x0596: return (char)0x06f6;
                case 0x0597: return (char)0x06f7;
                case 0x0598: return (char)0x06f8;
                case 0x0599: return (char)0x06f9;
                case 0x05a5: return (char)0x066a;
                case 0x05a6: return (char)0x0670;
                case 0x05a7: return (char)0x0679;
                case 0x05a8: return (char)0x067e;
                case 0x05a9: return (char)0x0686;
                case 0x05aa: return (char)0x0688;
                case 0x05ab: return (char)0x0691;
                case 0x05ae: return (char)0x06d4;
                case 0x05b0: return (char)0x0660;
                case 0x05b1: return (char)0x0661;
                case 0x05b2: return (char)0x0662;
                case 0x05b3: return (char)0x0663;
                case 0x05b4: return (char)0x0664;
                case 0x05b5: return (char)0x0665;
                case 0x05b6: return (char)0x0666;
                case 0x05b7: return (char)0x0667;
                case 0x05b8: return (char)0x0668;
                case 0x05b9: return (char)0x0669;
                case 0x05f3: return (char)0x0653;
                case 0x05f4: return (char)0x0654;
                case 0x05f5: return (char)0x0655;
                case 0x05f6: return (char)0x0698;
                case 0x05f7: return (char)0x06a4;
                case 0x05f8: return (char)0x06a9;
                case 0x05f9: return (char)0x06af;
                case 0x05fa: return (char)0x06ba;
                case 0x05fb: return (char)0x06be;
                case 0x05fc: return (char)0x06cc;
                case 0x05fd: return (char)0x06d2;
                case 0x05fe: return (char)0x06c1;
                case 0x0680: return (char)0x0492;
                case 0x0681: return (char)0x0496;
                case 0x0682: return (char)0x049a;
                case 0x0683: return (char)0x049c;
                case 0x0684: return (char)0x04a2;
                case 0x0685: return (char)0x04ae;
                case 0x0686: return (char)0x04b0;
                case 0x0687: return (char)0x04b2;
                case 0x0688: return (char)0x04b6;
                case 0x0689: return (char)0x04b8;
                case 0x068a: return (char)0x04ba;
                case 0x068c: return (char)0x04d8;
                case 0x068d: return (char)0x04e2;
                case 0x068e: return (char)0x04e8;
                case 0x068f: return (char)0x04ee;
                case 0x0690: return (char)0x0493;
                case 0x0691: return (char)0x0497;
                case 0x0692: return (char)0x049b;
                case 0x0693: return (char)0x049d;
                case 0x0694: return (char)0x04a3;
                case 0x0695: return (char)0x04af;
                case 0x0696: return (char)0x04b1;
                case 0x0697: return (char)0x04b3;
                case 0x0698: return (char)0x04b7;
                case 0x0699: return (char)0x04b9;
                case 0x069a: return (char)0x04bb;
                case 0x069c: return (char)0x04d9;
                case 0x069d: return (char)0x04e3;
                case 0x069e: return (char)0x04e9;
                case 0x069f: return (char)0x04ef;
                case 0x16a2: return (char)0x0000;
                case 0x16a3: return (char)0x1e8a;
                case 0x16a5: return (char)0x0000;
                case 0x16a6: return (char)0x012c;
                case 0x16a7: return (char)0x0000;
                case 0x16a8: return (char)0x0000;
                case 0x16a9: return (char)0x01b5;
                case 0x16aa: return (char)0x01e6;
                case 0x16af: return (char)0x019f;
                case 0x16b2: return (char)0x0000;
                case 0x16b3: return (char)0x1e8b;
                case 0x16b4: return (char)0x0000;
                case 0x16b5: return (char)0x0000;
                case 0x16b6: return (char)0x012d;
                case 0x16b7: return (char)0x0000;
                case 0x16b8: return (char)0x0000;
                case 0x16b9: return (char)0x01b6;
                case 0x16ba: return (char)0x01e7;
                case 0x16bd: return (char)0x01d2;
                case 0x16bf: return (char)0x0275;
                case 0x16c6: return (char)0x018f;
                case 0x16f6: return (char)0x0259;
                case 0x16d1: return (char)0x1e36;
                case 0x16d2: return (char)0x0000;
                case 0x16d3: return (char)0x0000;
                case 0x16e1: return (char)0x1e37;
                case 0x16e2: return (char)0x0000;
                case 0x16e3: return (char)0x0000;
                case 0x1ea0: return (char)0x1ea0;
                case 0x1ea1: return (char)0x1ea1;
                case 0x1ea2: return (char)0x1ea2;
                case 0x1ea3: return (char)0x1ea3;
                case 0x1ea4: return (char)0x1ea4;
                case 0x1ea5: return (char)0x1ea5;
                case 0x1ea6: return (char)0x1ea6;
                case 0x1ea7: return (char)0x1ea7;
                case 0x1ea8: return (char)0x1ea8;
                case 0x1ea9: return (char)0x1ea9;
                case 0x1eaa: return (char)0x1eaa;
                case 0x1eab: return (char)0x1eab;
                case 0x1eac: return (char)0x1eac;
                case 0x1ead: return (char)0x1ead;
                case 0x1eae: return (char)0x1eae;
                case 0x1eaf: return (char)0x1eaf;
                case 0x1eb0: return (char)0x1eb0;
                case 0x1eb1: return (char)0x1eb1;
                case 0x1eb2: return (char)0x1eb2;
                case 0x1eb3: return (char)0x1eb3;
                case 0x1eb4: return (char)0x1eb4;
                case 0x1eb5: return (char)0x1eb5;
                case 0x1eb6: return (char)0x1eb6;
                case 0x1eb7: return (char)0x1eb7;
                case 0x1eb8: return (char)0x1eb8;
                case 0x1eb9: return (char)0x1eb9;
                case 0x1eba: return (char)0x1eba;
                case 0x1ebb: return (char)0x1ebb;
                case 0x1ebc: return (char)0x1ebc;
                case 0x1ebd: return (char)0x1ebd;
                case 0x1ebe: return (char)0x1ebe;
                case 0x1ebf: return (char)0x1ebf;
                case 0x1ec0: return (char)0x1ec0;
                case 0x1ec1: return (char)0x1ec1;
                case 0x1ec2: return (char)0x1ec2;
                case 0x1ec3: return (char)0x1ec3;
                case 0x1ec4: return (char)0x1ec4;
                case 0x1ec5: return (char)0x1ec5;
                case 0x1ec6: return (char)0x1ec6;
                case 0x1ec7: return (char)0x1ec7;
                case 0x1ec8: return (char)0x1ec8;
                case 0x1ec9: return (char)0x1ec9;
                case 0x1eca: return (char)0x1eca;
                case 0x1ecb: return (char)0x1ecb;
                case 0x1ecc: return (char)0x1ecc;
                case 0x1ecd: return (char)0x1ecd;
                case 0x1ece: return (char)0x1ece;
                case 0x1ecf: return (char)0x1ecf;
                case 0x1ed0: return (char)0x1ed0;
                case 0x1ed1: return (char)0x1ed1;
                case 0x1ed2: return (char)0x1ed2;
                case 0x1ed3: return (char)0x1ed3;
                case 0x1ed4: return (char)0x1ed4;
                case 0x1ed5: return (char)0x1ed5;
                case 0x1ed6: return (char)0x1ed6;
                case 0x1ed7: return (char)0x1ed7;
                case 0x1ed8: return (char)0x1ed8;
                case 0x1ed9: return (char)0x1ed9;
                case 0x1eda: return (char)0x1eda;
                case 0x1edb: return (char)0x1edb;
                case 0x1edc: return (char)0x1edc;
                case 0x1edd: return (char)0x1edd;
                case 0x1ede: return (char)0x1ede;
                case 0x1edf: return (char)0x1edf;
                case 0x1ee0: return (char)0x1ee0;
                case 0x1ee1: return (char)0x1ee1;
                case 0x1ee2: return (char)0x1ee2;
                case 0x1ee3: return (char)0x1ee3;
                case 0x1ee4: return (char)0x1ee4;
                case 0x1ee5: return (char)0x1ee5;
                case 0x1ee6: return (char)0x1ee6;
                case 0x1ee7: return (char)0x1ee7;
                case 0x1ee8: return (char)0x1ee8;
                case 0x1ee9: return (char)0x1ee9;
                case 0x1eea: return (char)0x1eea;
                case 0x1eeb: return (char)0x1eeb;
                case 0x1eec: return (char)0x1eec;
                case 0x1eed: return (char)0x1eed;
                case 0x1eee: return (char)0x1eee;
                case 0x1eef: return (char)0x1eef;
                case 0x1ef0: return (char)0x1ef0;
                case 0x1ef1: return (char)0x1ef1;
                case 0x1ef4: return (char)0x1ef4;
                case 0x1ef5: return (char)0x1ef5;
                case 0x1ef6: return (char)0x1ef6;
                case 0x1ef7: return (char)0x1ef7;
                case 0x1ef8: return (char)0x1ef8;
                case 0x1ef9: return (char)0x1ef9;
                case 0x1efa: return (char)0x01a0;
                case 0x1efb: return (char)0x01a1;
                case 0x1efc: return (char)0x01af;
                case 0x1efd: return (char)0x01b0;
                case 0x1e9f: return (char)0x0303;
                case 0x1ef2: return (char)0x0300;
                case 0x1ef3: return (char)0x0301;
                case 0x1efe: return (char)0x0309;
                case 0x1eff: return (char)0x0323;
                case 0xfe60: return (char)0x0323;
                case 0xfe61: return (char)0x0309;
                case 0xfe62: return (char)0x031b;
                default: return '\0'; //throw new ArgumentException("oopsie woopsie i fuwed up the cowe oWo");
            }
        }
        public static X11KeyCode UnicodeToX11Key(char uni)
        {
            switch ((ushort)uni)
            {
                case 0x0020: return (X11KeyCode)0x0020;
                case 0x0021: return (X11KeyCode)0x0021;
                case 0x0022: return (X11KeyCode)0x0022;
                case 0x0023: return (X11KeyCode)0x0023;
                case 0x0024: return (X11KeyCode)0x0024;
                case 0x0025: return (X11KeyCode)0x0025;
                case 0x0026: return (X11KeyCode)0x0026;
                case 0x0027: return (X11KeyCode)0x0027;
                //case 0x0027: return (X11KeyCode)0x0027;
                case 0x0028: return (X11KeyCode)0x0028;
                case 0x0029: return (X11KeyCode)0x0029;
                case 0x002a: return (X11KeyCode)0x002a;
                case 0x002b: return (X11KeyCode)0x002b;
                case 0x002c: return (X11KeyCode)0x002c;
                case 0x002d: return (X11KeyCode)0x002d;
                case 0x002e: return (X11KeyCode)0x002e;
                case 0x002f: return (X11KeyCode)0x002f;
                case 0x0030: return (X11KeyCode)0x0030;
                case 0x0031: return (X11KeyCode)0x0031;
                case 0x0032: return (X11KeyCode)0x0032;
                case 0x0033: return (X11KeyCode)0x0033;
                case 0x0034: return (X11KeyCode)0x0034;
                case 0x0035: return (X11KeyCode)0x0035;
                case 0x0036: return (X11KeyCode)0x0036;
                case 0x0037: return (X11KeyCode)0x0037;
                case 0x0038: return (X11KeyCode)0x0038;
                case 0x0039: return (X11KeyCode)0x0039;
                case 0x003a: return (X11KeyCode)0x003a;
                case 0x003b: return (X11KeyCode)0x003b;
                case 0x003c: return (X11KeyCode)0x003c;
                case 0x003d: return (X11KeyCode)0x003d;
                case 0x003e: return (X11KeyCode)0x003e;
                case 0x003f: return (X11KeyCode)0x003f;
                case 0x0040: return (X11KeyCode)0x0040;
                case 0x0041: return (X11KeyCode)0x0041;
                case 0x0042: return (X11KeyCode)0x0042;
                case 0x0043: return (X11KeyCode)0x0043;
                case 0x0044: return (X11KeyCode)0x0044;
                case 0x0045: return (X11KeyCode)0x0045;
                case 0x0046: return (X11KeyCode)0x0046;
                case 0x0047: return (X11KeyCode)0x0047;
                case 0x0048: return (X11KeyCode)0x0048;
                case 0x0049: return (X11KeyCode)0x0049;
                case 0x004a: return (X11KeyCode)0x004a;
                case 0x004b: return (X11KeyCode)0x004b;
                case 0x004c: return (X11KeyCode)0x004c;
                case 0x004d: return (X11KeyCode)0x004d;
                case 0x004e: return (X11KeyCode)0x004e;
                case 0x004f: return (X11KeyCode)0x004f;
                case 0x0050: return (X11KeyCode)0x0050;
                case 0x0051: return (X11KeyCode)0x0051;
                case 0x0052: return (X11KeyCode)0x0052;
                case 0x0053: return (X11KeyCode)0x0053;
                case 0x0054: return (X11KeyCode)0x0054;
                case 0x0055: return (X11KeyCode)0x0055;
                case 0x0056: return (X11KeyCode)0x0056;
                case 0x0057: return (X11KeyCode)0x0057;
                case 0x0058: return (X11KeyCode)0x0058;
                case 0x0059: return (X11KeyCode)0x0059;
                case 0x005a: return (X11KeyCode)0x005a;
                case 0x005b: return (X11KeyCode)0x005b;
                case 0x005c: return (X11KeyCode)0x005c;
                case 0x005d: return (X11KeyCode)0x005d;
                case 0x005e: return (X11KeyCode)0x005e;
                case 0x005f: return (X11KeyCode)0x005f;
                case 0x0060: return (X11KeyCode)0x0060;
                //case 0x0060: return (X11KeyCode)0x0060;
                case 0x0061: return (X11KeyCode)0x0061;
                case 0x0062: return (X11KeyCode)0x0062;
                case 0x0063: return (X11KeyCode)0x0063;
                case 0x0064: return (X11KeyCode)0x0064;
                case 0x0065: return (X11KeyCode)0x0065;
                case 0x0066: return (X11KeyCode)0x0066;
                case 0x0067: return (X11KeyCode)0x0067;
                case 0x0068: return (X11KeyCode)0x0068;
                case 0x0069: return (X11KeyCode)0x0069;
                case 0x006a: return (X11KeyCode)0x006a;
                case 0x006b: return (X11KeyCode)0x006b;
                case 0x006c: return (X11KeyCode)0x006c;
                case 0x006d: return (X11KeyCode)0x006d;
                case 0x006e: return (X11KeyCode)0x006e;
                case 0x006f: return (X11KeyCode)0x006f;
                case 0x0070: return (X11KeyCode)0x0070;
                case 0x0071: return (X11KeyCode)0x0071;
                case 0x0072: return (X11KeyCode)0x0072;
                case 0x0073: return (X11KeyCode)0x0073;
                case 0x0074: return (X11KeyCode)0x0074;
                case 0x0075: return (X11KeyCode)0x0075;
                case 0x0076: return (X11KeyCode)0x0076;
                case 0x0077: return (X11KeyCode)0x0077;
                case 0x0078: return (X11KeyCode)0x0078;
                case 0x0079: return (X11KeyCode)0x0079;
                case 0x007a: return (X11KeyCode)0x007a;
                case 0x007b: return (X11KeyCode)0x007b;
                case 0x007c: return (X11KeyCode)0x007c;
                case 0x007d: return (X11KeyCode)0x007d;
                case 0x007e: return (X11KeyCode)0x007e;
                case 0x00a0: return (X11KeyCode)0x00a0;
                case 0x00a1: return (X11KeyCode)0x00a1;
                case 0x00a2: return (X11KeyCode)0x00a2;
                case 0x00a3: return (X11KeyCode)0x00a3;
                case 0x00a4: return (X11KeyCode)0x00a4;
                case 0x00a5: return (X11KeyCode)0x00a5;
                case 0x00a6: return (X11KeyCode)0x00a6;
                case 0x00a7: return (X11KeyCode)0x00a7;
                case 0x00a8: return (X11KeyCode)0x00a8;
                case 0x00a9: return (X11KeyCode)0x00a9;
                case 0x00aa: return (X11KeyCode)0x00aa;
                case 0x00ab: return (X11KeyCode)0x00ab;
                case 0x00ac: return (X11KeyCode)0x00ac;
                case 0x00ad: return (X11KeyCode)0x00ad;
                case 0x00ae: return (X11KeyCode)0x00ae;
                case 0x00af: return (X11KeyCode)0x00af;
                case 0x00b0: return (X11KeyCode)0x00b0;
                case 0x00b1: return (X11KeyCode)0x00b1;
                case 0x00b2: return (X11KeyCode)0x00b2;
                case 0x00b3: return (X11KeyCode)0x00b3;
                case 0x00b4: return (X11KeyCode)0x00b4;
                case 0x00b5: return (X11KeyCode)0x00b5;
                case 0x00b6: return (X11KeyCode)0x00b6;
                case 0x00b7: return (X11KeyCode)0x00b7;
                case 0x00b8: return (X11KeyCode)0x00b8;
                case 0x00b9: return (X11KeyCode)0x00b9;
                case 0x00ba: return (X11KeyCode)0x00ba;
                case 0x00bb: return (X11KeyCode)0x00bb;
                case 0x00bc: return (X11KeyCode)0x00bc;
                case 0x00bd: return (X11KeyCode)0x00bd;
                case 0x00be: return (X11KeyCode)0x00be;
                case 0x00bf: return (X11KeyCode)0x00bf;
                case 0x00c0: return (X11KeyCode)0x00c0;
                case 0x00c1: return (X11KeyCode)0x00c1;
                case 0x00c2: return (X11KeyCode)0x00c2;
                case 0x00c3: return (X11KeyCode)0x00c3;
                case 0x00c4: return (X11KeyCode)0x00c4;
                case 0x00c5: return (X11KeyCode)0x00c5;
                case 0x00c6: return (X11KeyCode)0x00c6;
                case 0x00c7: return (X11KeyCode)0x00c7;
                case 0x00c8: return (X11KeyCode)0x00c8;
                case 0x00c9: return (X11KeyCode)0x00c9;
                case 0x00ca: return (X11KeyCode)0x00ca;
                case 0x00cb: return (X11KeyCode)0x00cb;
                case 0x00cc: return (X11KeyCode)0x00cc;
                case 0x00cd: return (X11KeyCode)0x00cd;
                case 0x00ce: return (X11KeyCode)0x00ce;
                case 0x00cf: return (X11KeyCode)0x00cf;
                case 0x00d0: return (X11KeyCode)0x00d0;
                //case 0x00d0: return (X11KeyCode)0x00d0;
                case 0x00d1: return (X11KeyCode)0x00d1;
                case 0x00d2: return (X11KeyCode)0x00d2;
                case 0x00d3: return (X11KeyCode)0x00d3;
                case 0x00d4: return (X11KeyCode)0x00d4;
                case 0x00d5: return (X11KeyCode)0x00d5;
                case 0x00d6: return (X11KeyCode)0x00d6;
                case 0x00d7: return (X11KeyCode)0x00d7;
                case 0x00d8: return (X11KeyCode)0x00d8;
                case 0x00d9: return (X11KeyCode)0x00d9;
                case 0x00da: return (X11KeyCode)0x00da;
                case 0x00db: return (X11KeyCode)0x00db;
                case 0x00dc: return (X11KeyCode)0x00dc;
                case 0x00dd: return (X11KeyCode)0x00dd;
                case 0x00de: return (X11KeyCode)0x00de;
                //case 0x00de: return (X11KeyCode)0x00de;
                case 0x00df: return (X11KeyCode)0x00df;
                case 0x00e0: return (X11KeyCode)0x00e0;
                case 0x00e1: return (X11KeyCode)0x00e1;
                case 0x00e2: return (X11KeyCode)0x00e2;
                case 0x00e3: return (X11KeyCode)0x00e3;
                case 0x00e4: return (X11KeyCode)0x00e4;
                case 0x00e5: return (X11KeyCode)0x00e5;
                case 0x00e6: return (X11KeyCode)0x00e6;
                case 0x00e7: return (X11KeyCode)0x00e7;
                case 0x00e8: return (X11KeyCode)0x00e8;
                case 0x00e9: return (X11KeyCode)0x00e9;
                case 0x00ea: return (X11KeyCode)0x00ea;
                case 0x00eb: return (X11KeyCode)0x00eb;
                case 0x00ec: return (X11KeyCode)0x00ec;
                case 0x00ed: return (X11KeyCode)0x00ed;
                case 0x00ee: return (X11KeyCode)0x00ee;
                case 0x00ef: return (X11KeyCode)0x00ef;
                case 0x00f0: return (X11KeyCode)0x00f0;
                case 0x00f1: return (X11KeyCode)0x00f1;
                case 0x00f2: return (X11KeyCode)0x00f2;
                case 0x00f3: return (X11KeyCode)0x00f3;
                case 0x00f4: return (X11KeyCode)0x00f4;
                case 0x00f5: return (X11KeyCode)0x00f5;
                case 0x00f6: return (X11KeyCode)0x00f6;
                case 0x00f7: return (X11KeyCode)0x00f7;
                case 0x00f8: return (X11KeyCode)0x00f8;
                case 0x00f9: return (X11KeyCode)0x00f9;
                case 0x00fa: return (X11KeyCode)0x00fa;
                case 0x00fb: return (X11KeyCode)0x00fb;
                case 0x00fc: return (X11KeyCode)0x00fc;
                case 0x00fd: return (X11KeyCode)0x00fd;
                case 0x00fe: return (X11KeyCode)0x00fe;
                case 0x00ff: return (X11KeyCode)0x00ff;
                case 0x0104: return (X11KeyCode)0x01a1;
                case 0x02d8: return (X11KeyCode)0x01a2;
                case 0x0141: return (X11KeyCode)0x01a3;
                case 0x013d: return (X11KeyCode)0x01a5;
                case 0x015a: return (X11KeyCode)0x01a6;
                case 0x0160: return (X11KeyCode)0x01a9;
                case 0x015e: return (X11KeyCode)0x01aa;
                case 0x0164: return (X11KeyCode)0x01ab;
                case 0x0179: return (X11KeyCode)0x01ac;
                case 0x017d: return (X11KeyCode)0x01ae;
                case 0x017b: return (X11KeyCode)0x01af;
                case 0x0105: return (X11KeyCode)0x01b1;
                case 0x02db: return (X11KeyCode)0x01b2;
                case 0x0142: return (X11KeyCode)0x01b3;
                case 0x013e: return (X11KeyCode)0x01b5;
                case 0x015b: return (X11KeyCode)0x01b6;
                case 0x02c7: return (X11KeyCode)0x01b7;
                case 0x0161: return (X11KeyCode)0x01b9;
                case 0x015f: return (X11KeyCode)0x01ba;
                case 0x0165: return (X11KeyCode)0x01bb;
                case 0x017a: return (X11KeyCode)0x01bc;
                case 0x02dd: return (X11KeyCode)0x01bd;
                case 0x017e: return (X11KeyCode)0x01be;
                case 0x017c: return (X11KeyCode)0x01bf;
                case 0x0154: return (X11KeyCode)0x01c0;
                case 0x0102: return (X11KeyCode)0x01c3;
                case 0x0139: return (X11KeyCode)0x01c5;
                case 0x0106: return (X11KeyCode)0x01c6;
                case 0x010c: return (X11KeyCode)0x01c8;
                case 0x0118: return (X11KeyCode)0x01ca;
                case 0x011a: return (X11KeyCode)0x01cc;
                case 0x010e: return (X11KeyCode)0x01cf;
                case 0x0110: return (X11KeyCode)0x01d0;
                case 0x0143: return (X11KeyCode)0x01d1;
                case 0x0147: return (X11KeyCode)0x01d2;
                case 0x0150: return (X11KeyCode)0x01d5;
                case 0x0158: return (X11KeyCode)0x01d8;
                case 0x016e: return (X11KeyCode)0x01d9;
                case 0x0170: return (X11KeyCode)0x01db;
                case 0x0162: return (X11KeyCode)0x01de;
                case 0x0155: return (X11KeyCode)0x01e0;
                case 0x0103: return (X11KeyCode)0x01e3;
                case 0x013a: return (X11KeyCode)0x01e5;
                case 0x0107: return (X11KeyCode)0x01e6;
                case 0x010d: return (X11KeyCode)0x01e8;
                case 0x0119: return (X11KeyCode)0x01ea;
                case 0x011b: return (X11KeyCode)0x01ec;
                case 0x010f: return (X11KeyCode)0x01ef;
                case 0x0111: return (X11KeyCode)0x01f0;
                case 0x0144: return (X11KeyCode)0x01f1;
                case 0x0148: return (X11KeyCode)0x01f2;
                case 0x0151: return (X11KeyCode)0x01f5;
                case 0x0159: return (X11KeyCode)0x01f8;
                case 0x016f: return (X11KeyCode)0x01f9;
                case 0x0171: return (X11KeyCode)0x01fb;
                case 0x0163: return (X11KeyCode)0x01fe;
                case 0x02d9: return (X11KeyCode)0x01ff;
                case 0x0126: return (X11KeyCode)0x02a1;
                case 0x0124: return (X11KeyCode)0x02a6;
                case 0x0130: return (X11KeyCode)0x02a9;
                case 0x011e: return (X11KeyCode)0x02ab;
                case 0x0134: return (X11KeyCode)0x02ac;
                case 0x0127: return (X11KeyCode)0x02b1;
                case 0x0125: return (X11KeyCode)0x02b6;
                case 0x0131: return (X11KeyCode)0x02b9;
                case 0x011f: return (X11KeyCode)0x02bb;
                case 0x0135: return (X11KeyCode)0x02bc;
                case 0x010a: return (X11KeyCode)0x02c5;
                case 0x0108: return (X11KeyCode)0x02c6;
                case 0x0120: return (X11KeyCode)0x02d5;
                case 0x011c: return (X11KeyCode)0x02d8;
                case 0x016c: return (X11KeyCode)0x02dd;
                case 0x015c: return (X11KeyCode)0x02de;
                case 0x010b: return (X11KeyCode)0x02e5;
                case 0x0109: return (X11KeyCode)0x02e6;
                case 0x0121: return (X11KeyCode)0x02f5;
                case 0x011d: return (X11KeyCode)0x02f8;
                case 0x016d: return (X11KeyCode)0x02fd;
                case 0x015d: return (X11KeyCode)0x02fe;
                case 0x0138: return (X11KeyCode)0x03a2;
                case 0x0156: return (X11KeyCode)0x03a3;
                case 0x0128: return (X11KeyCode)0x03a5;
                case 0x013b: return (X11KeyCode)0x03a6;
                case 0x0112: return (X11KeyCode)0x03aa;
                case 0x0122: return (X11KeyCode)0x03ab;
                case 0x0166: return (X11KeyCode)0x03ac;
                case 0x0157: return (X11KeyCode)0x03b3;
                case 0x0129: return (X11KeyCode)0x03b5;
                case 0x013c: return (X11KeyCode)0x03b6;
                case 0x0113: return (X11KeyCode)0x03ba;
                case 0x0123: return (X11KeyCode)0x03bb;
                case 0x0167: return (X11KeyCode)0x03bc;
                case 0x014a: return (X11KeyCode)0x03bd;
                case 0x014b: return (X11KeyCode)0x03bf;
                case 0x0100: return (X11KeyCode)0x03c0;
                case 0x012e: return (X11KeyCode)0x03c7;
                case 0x0116: return (X11KeyCode)0x03cc;
                case 0x012a: return (X11KeyCode)0x03cf;
                case 0x0145: return (X11KeyCode)0x03d1;
                case 0x014c: return (X11KeyCode)0x03d2;
                case 0x0136: return (X11KeyCode)0x03d3;
                case 0x0172: return (X11KeyCode)0x03d9;
                case 0x0168: return (X11KeyCode)0x03dd;
                case 0x016a: return (X11KeyCode)0x03de;
                case 0x0101: return (X11KeyCode)0x03e0;
                case 0x012f: return (X11KeyCode)0x03e7;
                case 0x0117: return (X11KeyCode)0x03ec;
                case 0x012b: return (X11KeyCode)0x03ef;
                case 0x0146: return (X11KeyCode)0x03f1;
                case 0x014d: return (X11KeyCode)0x03f2;
                case 0x0137: return (X11KeyCode)0x03f3;
                case 0x0173: return (X11KeyCode)0x03f9;
                case 0x0169: return (X11KeyCode)0x03fd;
                case 0x016b: return (X11KeyCode)0x03fe;
                case 0x203e: return (X11KeyCode)0x047e;
                case 0x3002: return (X11KeyCode)0x04a1;
                case 0x300c: return (X11KeyCode)0x04a2;
                case 0x300d: return (X11KeyCode)0x04a3;
                case 0x3001: return (X11KeyCode)0x04a4;
                case 0x30fb: return (X11KeyCode)0x04a5;
                case 0x30f2: return (X11KeyCode)0x04a6;
                case 0x30a1: return (X11KeyCode)0x04a7;
                case 0x30a3: return (X11KeyCode)0x04a8;
                case 0x30a5: return (X11KeyCode)0x04a9;
                case 0x30a7: return (X11KeyCode)0x04aa;
                case 0x30a9: return (X11KeyCode)0x04ab;
                case 0x30e3: return (X11KeyCode)0x04ac;
                case 0x30e5: return (X11KeyCode)0x04ad;
                case 0x30e7: return (X11KeyCode)0x04ae;
                case 0x30c3: return (X11KeyCode)0x04af;
                case 0x30fc: return (X11KeyCode)0x04b0;
                case 0x30a2: return (X11KeyCode)0x04b1;
                case 0x30a4: return (X11KeyCode)0x04b2;
                case 0x30a6: return (X11KeyCode)0x04b3;
                case 0x30a8: return (X11KeyCode)0x04b4;
                case 0x30aa: return (X11KeyCode)0x04b5;
                case 0x30ab: return (X11KeyCode)0x04b6;
                case 0x30ad: return (X11KeyCode)0x04b7;
                case 0x30af: return (X11KeyCode)0x04b8;
                case 0x30b1: return (X11KeyCode)0x04b9;
                case 0x30b3: return (X11KeyCode)0x04ba;
                case 0x30b5: return (X11KeyCode)0x04bb;
                case 0x30b7: return (X11KeyCode)0x04bc;
                case 0x30b9: return (X11KeyCode)0x04bd;
                case 0x30bb: return (X11KeyCode)0x04be;
                case 0x30bd: return (X11KeyCode)0x04bf;
                case 0x30bf: return (X11KeyCode)0x04c0;
                case 0x30c1: return (X11KeyCode)0x04c1;
                case 0x30c4: return (X11KeyCode)0x04c2;
                case 0x30c6: return (X11KeyCode)0x04c3;
                case 0x30c8: return (X11KeyCode)0x04c4;
                case 0x30ca: return (X11KeyCode)0x04c5;
                case 0x30cb: return (X11KeyCode)0x04c6;
                case 0x30cc: return (X11KeyCode)0x04c7;
                case 0x30cd: return (X11KeyCode)0x04c8;
                case 0x30ce: return (X11KeyCode)0x04c9;
                case 0x30cf: return (X11KeyCode)0x04ca;
                case 0x30d2: return (X11KeyCode)0x04cb;
                case 0x30d5: return (X11KeyCode)0x04cc;
                case 0x30d8: return (X11KeyCode)0x04cd;
                case 0x30db: return (X11KeyCode)0x04ce;
                case 0x30de: return (X11KeyCode)0x04cf;
                case 0x30df: return (X11KeyCode)0x04d0;
                case 0x30e0: return (X11KeyCode)0x04d1;
                case 0x30e1: return (X11KeyCode)0x04d2;
                case 0x30e2: return (X11KeyCode)0x04d3;
                case 0x30e4: return (X11KeyCode)0x04d4;
                case 0x30e6: return (X11KeyCode)0x04d5;
                case 0x30e8: return (X11KeyCode)0x04d6;
                case 0x30e9: return (X11KeyCode)0x04d7;
                case 0x30ea: return (X11KeyCode)0x04d8;
                case 0x30eb: return (X11KeyCode)0x04d9;
                case 0x30ec: return (X11KeyCode)0x04da;
                case 0x30ed: return (X11KeyCode)0x04db;
                case 0x30ef: return (X11KeyCode)0x04dc;
                case 0x30f3: return (X11KeyCode)0x04dd;
                case 0x309b: return (X11KeyCode)0x04de;
                case 0x309c: return (X11KeyCode)0x04df;
                case 0x060c: return (X11KeyCode)0x05ac;
                case 0x061b: return (X11KeyCode)0x05bb;
                case 0x061f: return (X11KeyCode)0x05bf;
                case 0x0621: return (X11KeyCode)0x05c1;
                case 0x0622: return (X11KeyCode)0x05c2;
                case 0x0623: return (X11KeyCode)0x05c3;
                case 0x0624: return (X11KeyCode)0x05c4;
                case 0x0625: return (X11KeyCode)0x05c5;
                case 0x0626: return (X11KeyCode)0x05c6;
                case 0x0627: return (X11KeyCode)0x05c7;
                case 0x0628: return (X11KeyCode)0x05c8;
                case 0x0629: return (X11KeyCode)0x05c9;
                case 0x062a: return (X11KeyCode)0x05ca;
                case 0x062b: return (X11KeyCode)0x05cb;
                case 0x062c: return (X11KeyCode)0x05cc;
                case 0x062d: return (X11KeyCode)0x05cd;
                case 0x062e: return (X11KeyCode)0x05ce;
                case 0x062f: return (X11KeyCode)0x05cf;
                case 0x0630: return (X11KeyCode)0x05d0;
                case 0x0631: return (X11KeyCode)0x05d1;
                case 0x0632: return (X11KeyCode)0x05d2;
                case 0x0633: return (X11KeyCode)0x05d3;
                case 0x0634: return (X11KeyCode)0x05d4;
                case 0x0635: return (X11KeyCode)0x05d5;
                case 0x0636: return (X11KeyCode)0x05d6;
                case 0x0637: return (X11KeyCode)0x05d7;
                case 0x0638: return (X11KeyCode)0x05d8;
                case 0x0639: return (X11KeyCode)0x05d9;
                case 0x063a: return (X11KeyCode)0x05da;
                case 0x0640: return (X11KeyCode)0x05e0;
                case 0x0641: return (X11KeyCode)0x05e1;
                case 0x0642: return (X11KeyCode)0x05e2;
                case 0x0643: return (X11KeyCode)0x05e3;
                case 0x0644: return (X11KeyCode)0x05e4;
                case 0x0645: return (X11KeyCode)0x05e5;
                case 0x0646: return (X11KeyCode)0x05e6;
                case 0x0647: return (X11KeyCode)0x05e7;
                case 0x0648: return (X11KeyCode)0x05e8;
                case 0x0649: return (X11KeyCode)0x05e9;
                case 0x064a: return (X11KeyCode)0x05ea;
                case 0x064b: return (X11KeyCode)0x05eb;
                case 0x064c: return (X11KeyCode)0x05ec;
                case 0x064d: return (X11KeyCode)0x05ed;
                case 0x064e: return (X11KeyCode)0x05ee;
                case 0x064f: return (X11KeyCode)0x05ef;
                case 0x0650: return (X11KeyCode)0x05f0;
                case 0x0651: return (X11KeyCode)0x05f1;
                case 0x0652: return (X11KeyCode)0x05f2;
                case 0x0452: return (X11KeyCode)0x06a1;
                case 0x0453: return (X11KeyCode)0x06a2;
                case 0x0451: return (X11KeyCode)0x06a3;
                case 0x0454: return (X11KeyCode)0x06a4;
                case 0x0455: return (X11KeyCode)0x06a5;
                case 0x0456: return (X11KeyCode)0x06a6;
                case 0x0457: return (X11KeyCode)0x06a7;
                case 0x0458: return (X11KeyCode)0x06a8;
                case 0x0459: return (X11KeyCode)0x06a9;
                case 0x045a: return (X11KeyCode)0x06aa;
                case 0x045b: return (X11KeyCode)0x06ab;
                case 0x045c: return (X11KeyCode)0x06ac;
                case 0x045e: return (X11KeyCode)0x06ae;
                case 0x045f: return (X11KeyCode)0x06af;
                case 0x2116: return (X11KeyCode)0x06b0;
                case 0x0402: return (X11KeyCode)0x06b1;
                case 0x0403: return (X11KeyCode)0x06b2;
                case 0x0401: return (X11KeyCode)0x06b3;
                case 0x0404: return (X11KeyCode)0x06b4;
                case 0x0405: return (X11KeyCode)0x06b5;
                case 0x0406: return (X11KeyCode)0x06b6;
                case 0x0407: return (X11KeyCode)0x06b7;
                case 0x0408: return (X11KeyCode)0x06b8;
                case 0x0409: return (X11KeyCode)0x06b9;
                case 0x040a: return (X11KeyCode)0x06ba;
                case 0x040b: return (X11KeyCode)0x06bb;
                case 0x040c: return (X11KeyCode)0x06bc;
                case 0x040e: return (X11KeyCode)0x06be;
                case 0x040f: return (X11KeyCode)0x06bf;
                case 0x044e: return (X11KeyCode)0x06c0;
                case 0x0430: return (X11KeyCode)0x06c1;
                case 0x0431: return (X11KeyCode)0x06c2;
                case 0x0446: return (X11KeyCode)0x06c3;
                case 0x0434: return (X11KeyCode)0x06c4;
                case 0x0435: return (X11KeyCode)0x06c5;
                case 0x0444: return (X11KeyCode)0x06c6;
                case 0x0433: return (X11KeyCode)0x06c7;
                case 0x0445: return (X11KeyCode)0x06c8;
                case 0x0438: return (X11KeyCode)0x06c9;
                case 0x0439: return (X11KeyCode)0x06ca;
                case 0x043a: return (X11KeyCode)0x06cb;
                case 0x043b: return (X11KeyCode)0x06cc;
                case 0x043c: return (X11KeyCode)0x06cd;
                case 0x043d: return (X11KeyCode)0x06ce;
                case 0x043e: return (X11KeyCode)0x06cf;
                case 0x043f: return (X11KeyCode)0x06d0;
                case 0x044f: return (X11KeyCode)0x06d1;
                case 0x0440: return (X11KeyCode)0x06d2;
                case 0x0441: return (X11KeyCode)0x06d3;
                case 0x0442: return (X11KeyCode)0x06d4;
                case 0x0443: return (X11KeyCode)0x06d5;
                case 0x0436: return (X11KeyCode)0x06d6;
                case 0x0432: return (X11KeyCode)0x06d7;
                case 0x044c: return (X11KeyCode)0x06d8;
                case 0x044b: return (X11KeyCode)0x06d9;
                case 0x0437: return (X11KeyCode)0x06da;
                case 0x0448: return (X11KeyCode)0x06db;
                case 0x044d: return (X11KeyCode)0x06dc;
                case 0x0449: return (X11KeyCode)0x06dd;
                case 0x0447: return (X11KeyCode)0x06de;
                case 0x044a: return (X11KeyCode)0x06df;
                case 0x042e: return (X11KeyCode)0x06e0;
                case 0x0410: return (X11KeyCode)0x06e1;
                case 0x0411: return (X11KeyCode)0x06e2;
                case 0x0426: return (X11KeyCode)0x06e3;
                case 0x0414: return (X11KeyCode)0x06e4;
                case 0x0415: return (X11KeyCode)0x06e5;
                case 0x0424: return (X11KeyCode)0x06e6;
                case 0x0413: return (X11KeyCode)0x06e7;
                case 0x0425: return (X11KeyCode)0x06e8;
                case 0x0418: return (X11KeyCode)0x06e9;
                case 0x0419: return (X11KeyCode)0x06ea;
                case 0x041a: return (X11KeyCode)0x06eb;
                case 0x041b: return (X11KeyCode)0x06ec;
                case 0x041c: return (X11KeyCode)0x06ed;
                case 0x041d: return (X11KeyCode)0x06ee;
                case 0x041e: return (X11KeyCode)0x06ef;
                case 0x041f: return (X11KeyCode)0x06f0;
                case 0x042f: return (X11KeyCode)0x06f1;
                case 0x0420: return (X11KeyCode)0x06f2;
                case 0x0421: return (X11KeyCode)0x06f3;
                case 0x0422: return (X11KeyCode)0x06f4;
                case 0x0423: return (X11KeyCode)0x06f5;
                case 0x0416: return (X11KeyCode)0x06f6;
                case 0x0412: return (X11KeyCode)0x06f7;
                case 0x042c: return (X11KeyCode)0x06f8;
                case 0x042b: return (X11KeyCode)0x06f9;
                case 0x0417: return (X11KeyCode)0x06fa;
                case 0x0428: return (X11KeyCode)0x06fb;
                case 0x042d: return (X11KeyCode)0x06fc;
                case 0x0429: return (X11KeyCode)0x06fd;
                case 0x0427: return (X11KeyCode)0x06fe;
                case 0x042a: return (X11KeyCode)0x06ff;
                case 0x0386: return (X11KeyCode)0x07a1;
                case 0x0388: return (X11KeyCode)0x07a2;
                case 0x0389: return (X11KeyCode)0x07a3;
                case 0x038a: return (X11KeyCode)0x07a4;
                case 0x03aa: return (X11KeyCode)0x07a5;
                case 0x038c: return (X11KeyCode)0x07a7;
                case 0x038e: return (X11KeyCode)0x07a8;
                case 0x03ab: return (X11KeyCode)0x07a9;
                case 0x038f: return (X11KeyCode)0x07ab;
                case 0x0385: return (X11KeyCode)0x07ae;
                case 0x2015: return (X11KeyCode)0x07af;
                case 0x03ac: return (X11KeyCode)0x07b1;
                case 0x03ad: return (X11KeyCode)0x07b2;
                case 0x03ae: return (X11KeyCode)0x07b3;
                case 0x03af: return (X11KeyCode)0x07b4;
                case 0x03ca: return (X11KeyCode)0x07b5;
                case 0x0390: return (X11KeyCode)0x07b6;
                case 0x03cc: return (X11KeyCode)0x07b7;
                case 0x03cd: return (X11KeyCode)0x07b8;
                case 0x03cb: return (X11KeyCode)0x07b9;
                case 0x03b0: return (X11KeyCode)0x07ba;
                case 0x03ce: return (X11KeyCode)0x07bb;
                case 0x0391: return (X11KeyCode)0x07c1;
                case 0x0392: return (X11KeyCode)0x07c2;
                case 0x0393: return (X11KeyCode)0x07c3;
                case 0x0394: return (X11KeyCode)0x07c4;
                case 0x0395: return (X11KeyCode)0x07c5;
                case 0x0396: return (X11KeyCode)0x07c6;
                case 0x0397: return (X11KeyCode)0x07c7;
                case 0x0398: return (X11KeyCode)0x07c8;
                case 0x0399: return (X11KeyCode)0x07c9;
                case 0x039a: return (X11KeyCode)0x07ca;
                case 0x039b: return (X11KeyCode)0x07cb;
                //case 0x039b: return (X11KeyCode)0x07cb;
                case 0x039c: return (X11KeyCode)0x07cc;
                case 0x039d: return (X11KeyCode)0x07cd;
                case 0x039e: return (X11KeyCode)0x07ce;
                case 0x039f: return (X11KeyCode)0x07cf;
                case 0x03a0: return (X11KeyCode)0x07d0;
                case 0x03a1: return (X11KeyCode)0x07d1;
                case 0x03a3: return (X11KeyCode)0x07d2;
                case 0x03a4: return (X11KeyCode)0x07d4;
                case 0x03a5: return (X11KeyCode)0x07d5;
                case 0x03a6: return (X11KeyCode)0x07d6;
                case 0x03a7: return (X11KeyCode)0x07d7;
                case 0x03a8: return (X11KeyCode)0x07d8;
                case 0x03a9: return (X11KeyCode)0x07d9;
                case 0x03b1: return (X11KeyCode)0x07e1;
                case 0x03b2: return (X11KeyCode)0x07e2;
                case 0x03b3: return (X11KeyCode)0x07e3;
                case 0x03b4: return (X11KeyCode)0x07e4;
                case 0x03b5: return (X11KeyCode)0x07e5;
                case 0x03b6: return (X11KeyCode)0x07e6;
                case 0x03b7: return (X11KeyCode)0x07e7;
                case 0x03b8: return (X11KeyCode)0x07e8;
                case 0x03b9: return (X11KeyCode)0x07e9;
                case 0x03ba: return (X11KeyCode)0x07ea;
                case 0x03bb: return (X11KeyCode)0x07eb;
                case 0x03bc: return (X11KeyCode)0x07ec;
                case 0x03bd: return (X11KeyCode)0x07ed;
                case 0x03be: return (X11KeyCode)0x07ee;
                case 0x03bf: return (X11KeyCode)0x07ef;
                case 0x03c0: return (X11KeyCode)0x07f0;
                case 0x03c1: return (X11KeyCode)0x07f1;
                case 0x03c3: return (X11KeyCode)0x07f2;
                case 0x03c2: return (X11KeyCode)0x07f3;
                case 0x03c4: return (X11KeyCode)0x07f4;
                case 0x03c5: return (X11KeyCode)0x07f5;
                case 0x03c6: return (X11KeyCode)0x07f6;
                case 0x03c7: return (X11KeyCode)0x07f7;
                case 0x03c8: return (X11KeyCode)0x07f8;
                case 0x03c9: return (X11KeyCode)0x07f9;
                case 0x23b7: return (X11KeyCode)0x08a1;
                case 0x250c: return (X11KeyCode)0x08a2;
                case 0x2500: return (X11KeyCode)0x08a3;
                case 0x2320: return (X11KeyCode)0x08a4;
                case 0x2321: return (X11KeyCode)0x08a5;
                case 0x2502: return (X11KeyCode)0x08a6;
                case 0x23a1: return (X11KeyCode)0x08a7;
                case 0x23a3: return (X11KeyCode)0x08a8;
                case 0x23a4: return (X11KeyCode)0x08a9;
                case 0x23a6: return (X11KeyCode)0x08aa;
                case 0x239b: return (X11KeyCode)0x08ab;
                case 0x239d: return (X11KeyCode)0x08ac;
                case 0x239e: return (X11KeyCode)0x08ad;
                case 0x23a0: return (X11KeyCode)0x08ae;
                case 0x23a8: return (X11KeyCode)0x08af;
                case 0x23ac: return (X11KeyCode)0x08b0;
                case 0x0000: return (X11KeyCode)0x08b1;
                //case 0x0000: return (X11KeyCode)0x08b2;
                //case 0x0000: return (X11KeyCode)0x08b3;
                //case 0x0000: return (X11KeyCode)0x08b4;
                //case 0x0000: return (X11KeyCode)0x08b5;
                //case 0x0000: return (X11KeyCode)0x08b6;
                //case 0x0000: return (X11KeyCode)0x08b7;
                case 0x2264: return (X11KeyCode)0x08bc;
                case 0x2260: return (X11KeyCode)0x08bd;
                case 0x2265: return (X11KeyCode)0x08be;
                case 0x222b: return (X11KeyCode)0x08bf;
                case 0x2234: return (X11KeyCode)0x08c0;
                case 0x221d: return (X11KeyCode)0x08c1;
                case 0x221e: return (X11KeyCode)0x08c2;
                case 0x2207: return (X11KeyCode)0x08c5;
                case 0x223c: return (X11KeyCode)0x08c8;
                case 0x2243: return (X11KeyCode)0x08c9;
                case 0x21d4: return (X11KeyCode)0x08cd;
                case 0x21d2: return (X11KeyCode)0x08ce;
                case 0x2261: return (X11KeyCode)0x08cf;
                case 0x221a: return (X11KeyCode)0x08d6;
                case 0x2282: return (X11KeyCode)0x08da;
                case 0x2283: return (X11KeyCode)0x08db;
                case 0x2229: return (X11KeyCode)0x08dc;
                case 0x222a: return (X11KeyCode)0x08dd;
                case 0x2227: return (X11KeyCode)0x08de;
                case 0x2228: return (X11KeyCode)0x08df;
                case 0x2202: return (X11KeyCode)0x08ef;
                case 0x0192: return (X11KeyCode)0x08f6;
                case 0x2190: return (X11KeyCode)0x08fb;
                case 0x2191: return (X11KeyCode)0x08fc;
                case 0x2192: return (X11KeyCode)0x08fd;
                case 0x2193: return (X11KeyCode)0x08fe;
                //case 0x0000: return (X11KeyCode)0x09df;
                case 0x25c6: return (X11KeyCode)0x09e0;
                case 0x2592: return (X11KeyCode)0x09e1;
                case 0x2409: return (X11KeyCode)0x09e2;
                case 0x240c: return (X11KeyCode)0x09e3;
                case 0x240d: return (X11KeyCode)0x09e4;
                case 0x240a: return (X11KeyCode)0x09e5;
                case 0x2424: return (X11KeyCode)0x09e8;
                case 0x240b: return (X11KeyCode)0x09e9;
                case 0x2518: return (X11KeyCode)0x09ea;
                case 0x2510: return (X11KeyCode)0x09eb;
                //case 0x250c: return (X11KeyCode)0x09ec;
                case 0x2514: return (X11KeyCode)0x09ed;
                case 0x253c: return (X11KeyCode)0x09ee;
                case 0x23ba: return (X11KeyCode)0x09ef;
                case 0x23bb: return (X11KeyCode)0x09f0;
                //case 0x2500: return (X11KeyCode)0x09f1;
                case 0x23bc: return (X11KeyCode)0x09f2;
                case 0x23bd: return (X11KeyCode)0x09f3;
                case 0x251c: return (X11KeyCode)0x09f4;
                case 0x2524: return (X11KeyCode)0x09f5;
                case 0x2534: return (X11KeyCode)0x09f6;
                case 0x252c: return (X11KeyCode)0x09f7;
                //case 0x2502: return (X11KeyCode)0x09f8;
                case 0x2003: return (X11KeyCode)0x0aa1;
                case 0x2002: return (X11KeyCode)0x0aa2;
                case 0x2004: return (X11KeyCode)0x0aa3;
                case 0x2005: return (X11KeyCode)0x0aa4;
                case 0x2007: return (X11KeyCode)0x0aa5;
                case 0x2008: return (X11KeyCode)0x0aa6;
                case 0x2009: return (X11KeyCode)0x0aa7;
                case 0x200a: return (X11KeyCode)0x0aa8;
                case 0x2014: return (X11KeyCode)0x0aa9;
                case 0x2013: return (X11KeyCode)0x0aaa;
                case 0x2423: return (X11KeyCode)0x0aac;
                case 0x2026: return (X11KeyCode)0x0aae;
                case 0x2025: return (X11KeyCode)0x0aaf;
                case 0x2153: return (X11KeyCode)0x0ab0;
                case 0x2154: return (X11KeyCode)0x0ab1;
                case 0x2155: return (X11KeyCode)0x0ab2;
                case 0x2156: return (X11KeyCode)0x0ab3;
                case 0x2157: return (X11KeyCode)0x0ab4;
                case 0x2158: return (X11KeyCode)0x0ab5;
                case 0x2159: return (X11KeyCode)0x0ab6;
                case 0x215a: return (X11KeyCode)0x0ab7;
                case 0x2105: return (X11KeyCode)0x0ab8;
                case 0x2012: return (X11KeyCode)0x0abb;
                case 0x27e8: return (X11KeyCode)0x0abc;
                //case 0x002e: return (X11KeyCode)0x0abd;
                case 0x27e9: return (X11KeyCode)0x0abe;
                //case 0x0000: return (X11KeyCode)0x0abf;
                case 0x215b: return (X11KeyCode)0x0ac3;
                case 0x215c: return (X11KeyCode)0x0ac4;
                case 0x215d: return (X11KeyCode)0x0ac5;
                case 0x215e: return (X11KeyCode)0x0ac6;
                case 0x2122: return (X11KeyCode)0x0ac9;
                case 0x2613: return (X11KeyCode)0x0aca;
                //case 0x0000: return (X11KeyCode)0x0acb;
                case 0x25c1: return (X11KeyCode)0x0acc;
                case 0x25b7: return (X11KeyCode)0x0acd;
                case 0x25cb: return (X11KeyCode)0x0ace;
                case 0x25af: return (X11KeyCode)0x0acf;
                case 0x2018: return (X11KeyCode)0x0ad0;
                case 0x2019: return (X11KeyCode)0x0ad1;
                case 0x201c: return (X11KeyCode)0x0ad2;
                case 0x201d: return (X11KeyCode)0x0ad3;
                case 0x211e: return (X11KeyCode)0x0ad4;
                case 0x2032: return (X11KeyCode)0x0ad6;
                case 0x2033: return (X11KeyCode)0x0ad7;
                case 0x271d: return (X11KeyCode)0x0ad9;
                //case 0x0000: return (X11KeyCode)0x0ada;
                case 0x25ac: return (X11KeyCode)0x0adb;
                case 0x25c0: return (X11KeyCode)0x0adc;
                case 0x25b6: return (X11KeyCode)0x0add;
                case 0x25cf: return (X11KeyCode)0x0ade;
                case 0x25ae: return (X11KeyCode)0x0adf;
                case 0x25e6: return (X11KeyCode)0x0ae0;
                case 0x25ab: return (X11KeyCode)0x0ae1;
                case 0x25ad: return (X11KeyCode)0x0ae2;
                case 0x25b3: return (X11KeyCode)0x0ae3;
                case 0x25bd: return (X11KeyCode)0x0ae4;
                case 0x2606: return (X11KeyCode)0x0ae5;
                case 0x2022: return (X11KeyCode)0x0ae6;
                case 0x25aa: return (X11KeyCode)0x0ae7;
                case 0x25b2: return (X11KeyCode)0x0ae8;
                case 0x25bc: return (X11KeyCode)0x0ae9;
                case 0x261c: return (X11KeyCode)0x0aea;
                case 0x261e: return (X11KeyCode)0x0aeb;
                case 0x2663: return (X11KeyCode)0x0aec;
                case 0x2666: return (X11KeyCode)0x0aed;
                case 0x2665: return (X11KeyCode)0x0aee;
                case 0x2720: return (X11KeyCode)0x0af0;
                case 0x2020: return (X11KeyCode)0x0af1;
                case 0x2021: return (X11KeyCode)0x0af2;
                case 0x2713: return (X11KeyCode)0x0af3;
                case 0x2717: return (X11KeyCode)0x0af4;
                case 0x266f: return (X11KeyCode)0x0af5;
                case 0x266d: return (X11KeyCode)0x0af6;
                case 0x2642: return (X11KeyCode)0x0af7;
                case 0x2640: return (X11KeyCode)0x0af8;
                case 0x260e: return (X11KeyCode)0x0af9;
                case 0x2315: return (X11KeyCode)0x0afa;
                case 0x2117: return (X11KeyCode)0x0afb;
                case 0x2038: return (X11KeyCode)0x0afc;
                case 0x201a: return (X11KeyCode)0x0afd;
                case 0x201e: return (X11KeyCode)0x0afe;
                //case 0x0000: return (X11KeyCode)0x0aff;
                //case 0x003c: return (X11KeyCode)0x0ba3;
                //case 0x003e: return (X11KeyCode)0x0ba6;
                //case 0x2228: return (X11KeyCode)0x0ba8;
                //case 0x2227: return (X11KeyCode)0x0ba9;
                //case 0x00af: return (X11KeyCode)0x0bc0;
                case 0x22a5: return (X11KeyCode)0x0bc2;
                //case 0x2229: return (X11KeyCode)0x0bc3;
                case 0x230a: return (X11KeyCode)0x0bc4;
                //case 0x005f: return (X11KeyCode)0x0bc6;
                case 0x2218: return (X11KeyCode)0x0bca;
                case 0x2395: return (X11KeyCode)0x0bcc;
                case 0x22a4: return (X11KeyCode)0x0bce;
                //case 0x25cb: return (X11KeyCode)0x0bcf;
                case 0x2308: return (X11KeyCode)0x0bd3;
                //case 0x222a: return (X11KeyCode)0x0bd6;
                //case 0x2283: return (X11KeyCode)0x0bd8;
                //case 0x2282: return (X11KeyCode)0x0bda;
                case 0x22a2: return (X11KeyCode)0x0bdc;
                case 0x22a3: return (X11KeyCode)0x0bfc;
                case 0x2017: return (X11KeyCode)0x0cdf;
                case 0x05d0: return (X11KeyCode)0x0ce0;
                case 0x05d1: return (X11KeyCode)0x0ce1;
                //case 0x05d1: return (X11KeyCode)0x0ce1;
                case 0x05d2: return (X11KeyCode)0x0ce2;
                //case 0x05d2: return (X11KeyCode)0x0ce2;
                case 0x05d3: return (X11KeyCode)0x0ce3;
                //case 0x05d3: return (X11KeyCode)0x0ce3;
                case 0x05d4: return (X11KeyCode)0x0ce4;
                case 0x05d5: return (X11KeyCode)0x0ce5;
                case 0x05d6: return (X11KeyCode)0x0ce6;
                //case 0x05d6: return (X11KeyCode)0x0ce6;
                case 0x05d7: return (X11KeyCode)0x0ce7;
                //case 0x05d7: return (X11KeyCode)0x0ce7;
                case 0x05d8: return (X11KeyCode)0x0ce8;
                //case 0x05d8: return (X11KeyCode)0x0ce8;
                case 0x05d9: return (X11KeyCode)0x0ce9;
                case 0x05da: return (X11KeyCode)0x0cea;
                case 0x05db: return (X11KeyCode)0x0ceb;
                case 0x05dc: return (X11KeyCode)0x0cec;
                case 0x05dd: return (X11KeyCode)0x0ced;
                case 0x05de: return (X11KeyCode)0x0cee;
                case 0x05df: return (X11KeyCode)0x0cef;
                case 0x05e0: return (X11KeyCode)0x0cf0;
                case 0x05e1: return (X11KeyCode)0x0cf1;
                //case 0x05e1: return (X11KeyCode)0x0cf1;
                case 0x05e2: return (X11KeyCode)0x0cf2;
                case 0x05e3: return (X11KeyCode)0x0cf3;
                case 0x05e4: return (X11KeyCode)0x0cf4;
                case 0x05e5: return (X11KeyCode)0x0cf5;
                //case 0x05e5: return (X11KeyCode)0x0cf5;
                case 0x05e6: return (X11KeyCode)0x0cf6;
                //case 0x05e6: return (X11KeyCode)0x0cf6;
                case 0x05e7: return (X11KeyCode)0x0cf7;
                //case 0x05e7: return (X11KeyCode)0x0cf7;
                case 0x05e8: return (X11KeyCode)0x0cf8;
                case 0x05e9: return (X11KeyCode)0x0cf9;
                case 0x05ea: return (X11KeyCode)0x0cfa;
                //case 0x05ea: return (X11KeyCode)0x0cfa;
                case 0x0e01: return (X11KeyCode)0x0da1;
                case 0x0e02: return (X11KeyCode)0x0da2;
                case 0x0e03: return (X11KeyCode)0x0da3;
                case 0x0e04: return (X11KeyCode)0x0da4;
                case 0x0e05: return (X11KeyCode)0x0da5;
                case 0x0e06: return (X11KeyCode)0x0da6;
                case 0x0e07: return (X11KeyCode)0x0da7;
                case 0x0e08: return (X11KeyCode)0x0da8;
                case 0x0e09: return (X11KeyCode)0x0da9;
                case 0x0e0a: return (X11KeyCode)0x0daa;
                case 0x0e0b: return (X11KeyCode)0x0dab;
                case 0x0e0c: return (X11KeyCode)0x0dac;
                case 0x0e0d: return (X11KeyCode)0x0dad;
                case 0x0e0e: return (X11KeyCode)0x0dae;
                case 0x0e0f: return (X11KeyCode)0x0daf;
                case 0x0e10: return (X11KeyCode)0x0db0;
                case 0x0e11: return (X11KeyCode)0x0db1;
                case 0x0e12: return (X11KeyCode)0x0db2;
                case 0x0e13: return (X11KeyCode)0x0db3;
                case 0x0e14: return (X11KeyCode)0x0db4;
                case 0x0e15: return (X11KeyCode)0x0db5;
                case 0x0e16: return (X11KeyCode)0x0db6;
                case 0x0e17: return (X11KeyCode)0x0db7;
                case 0x0e18: return (X11KeyCode)0x0db8;
                case 0x0e19: return (X11KeyCode)0x0db9;
                case 0x0e1a: return (X11KeyCode)0x0dba;
                case 0x0e1b: return (X11KeyCode)0x0dbb;
                case 0x0e1c: return (X11KeyCode)0x0dbc;
                case 0x0e1d: return (X11KeyCode)0x0dbd;
                case 0x0e1e: return (X11KeyCode)0x0dbe;
                case 0x0e1f: return (X11KeyCode)0x0dbf;
                case 0x0e20: return (X11KeyCode)0x0dc0;
                case 0x0e21: return (X11KeyCode)0x0dc1;
                case 0x0e22: return (X11KeyCode)0x0dc2;
                case 0x0e23: return (X11KeyCode)0x0dc3;
                case 0x0e24: return (X11KeyCode)0x0dc4;
                case 0x0e25: return (X11KeyCode)0x0dc5;
                case 0x0e26: return (X11KeyCode)0x0dc6;
                case 0x0e27: return (X11KeyCode)0x0dc7;
                case 0x0e28: return (X11KeyCode)0x0dc8;
                case 0x0e29: return (X11KeyCode)0x0dc9;
                case 0x0e2a: return (X11KeyCode)0x0dca;
                case 0x0e2b: return (X11KeyCode)0x0dcb;
                case 0x0e2c: return (X11KeyCode)0x0dcc;
                case 0x0e2d: return (X11KeyCode)0x0dcd;
                case 0x0e2e: return (X11KeyCode)0x0dce;
                case 0x0e2f: return (X11KeyCode)0x0dcf;
                case 0x0e30: return (X11KeyCode)0x0dd0;
                case 0x0e31: return (X11KeyCode)0x0dd1;
                case 0x0e32: return (X11KeyCode)0x0dd2;
                case 0x0e33: return (X11KeyCode)0x0dd3;
                case 0x0e34: return (X11KeyCode)0x0dd4;
                case 0x0e35: return (X11KeyCode)0x0dd5;
                case 0x0e36: return (X11KeyCode)0x0dd6;
                case 0x0e37: return (X11KeyCode)0x0dd7;
                case 0x0e38: return (X11KeyCode)0x0dd8;
                case 0x0e39: return (X11KeyCode)0x0dd9;
                case 0x0e3a: return (X11KeyCode)0x0dda;
                //case 0x0000: return (X11KeyCode)0x0dde;
                case 0x0e3f: return (X11KeyCode)0x0ddf;
                case 0x0e40: return (X11KeyCode)0x0de0;
                case 0x0e41: return (X11KeyCode)0x0de1;
                case 0x0e42: return (X11KeyCode)0x0de2;
                case 0x0e43: return (X11KeyCode)0x0de3;
                case 0x0e44: return (X11KeyCode)0x0de4;
                case 0x0e45: return (X11KeyCode)0x0de5;
                case 0x0e46: return (X11KeyCode)0x0de6;
                case 0x0e47: return (X11KeyCode)0x0de7;
                case 0x0e48: return (X11KeyCode)0x0de8;
                case 0x0e49: return (X11KeyCode)0x0de9;
                case 0x0e4a: return (X11KeyCode)0x0dea;
                case 0x0e4b: return (X11KeyCode)0x0deb;
                case 0x0e4c: return (X11KeyCode)0x0dec;
                case 0x0e4d: return (X11KeyCode)0x0ded;
                case 0x0e50: return (X11KeyCode)0x0df0;
                case 0x0e51: return (X11KeyCode)0x0df1;
                case 0x0e52: return (X11KeyCode)0x0df2;
                case 0x0e53: return (X11KeyCode)0x0df3;
                case 0x0e54: return (X11KeyCode)0x0df4;
                case 0x0e55: return (X11KeyCode)0x0df5;
                case 0x0e56: return (X11KeyCode)0x0df6;
                case 0x0e57: return (X11KeyCode)0x0df7;
                case 0x0e58: return (X11KeyCode)0x0df8;
                case 0x0e59: return (X11KeyCode)0x0df9;
                case 0x3131: return (X11KeyCode)0x0ea1;
                case 0x3132: return (X11KeyCode)0x0ea2;
                case 0x3133: return (X11KeyCode)0x0ea3;
                case 0x3134: return (X11KeyCode)0x0ea4;
                case 0x3135: return (X11KeyCode)0x0ea5;
                case 0x3136: return (X11KeyCode)0x0ea6;
                case 0x3137: return (X11KeyCode)0x0ea7;
                case 0x3138: return (X11KeyCode)0x0ea8;
                case 0x3139: return (X11KeyCode)0x0ea9;
                case 0x313a: return (X11KeyCode)0x0eaa;
                case 0x313b: return (X11KeyCode)0x0eab;
                case 0x313c: return (X11KeyCode)0x0eac;
                case 0x313d: return (X11KeyCode)0x0ead;
                case 0x313e: return (X11KeyCode)0x0eae;
                case 0x313f: return (X11KeyCode)0x0eaf;
                case 0x3140: return (X11KeyCode)0x0eb0;
                case 0x3141: return (X11KeyCode)0x0eb1;
                case 0x3142: return (X11KeyCode)0x0eb2;
                case 0x3143: return (X11KeyCode)0x0eb3;
                case 0x3144: return (X11KeyCode)0x0eb4;
                case 0x3145: return (X11KeyCode)0x0eb5;
                case 0x3146: return (X11KeyCode)0x0eb6;
                case 0x3147: return (X11KeyCode)0x0eb7;
                case 0x3148: return (X11KeyCode)0x0eb8;
                case 0x3149: return (X11KeyCode)0x0eb9;
                case 0x314a: return (X11KeyCode)0x0eba;
                case 0x314b: return (X11KeyCode)0x0ebb;
                case 0x314c: return (X11KeyCode)0x0ebc;
                case 0x314d: return (X11KeyCode)0x0ebd;
                case 0x314e: return (X11KeyCode)0x0ebe;
                case 0x314f: return (X11KeyCode)0x0ebf;
                case 0x3150: return (X11KeyCode)0x0ec0;
                case 0x3151: return (X11KeyCode)0x0ec1;
                case 0x3152: return (X11KeyCode)0x0ec2;
                case 0x3153: return (X11KeyCode)0x0ec3;
                case 0x3154: return (X11KeyCode)0x0ec4;
                case 0x3155: return (X11KeyCode)0x0ec5;
                case 0x3156: return (X11KeyCode)0x0ec6;
                case 0x3157: return (X11KeyCode)0x0ec7;
                case 0x3158: return (X11KeyCode)0x0ec8;
                case 0x3159: return (X11KeyCode)0x0ec9;
                case 0x315a: return (X11KeyCode)0x0eca;
                case 0x315b: return (X11KeyCode)0x0ecb;
                case 0x315c: return (X11KeyCode)0x0ecc;
                case 0x315d: return (X11KeyCode)0x0ecd;
                case 0x315e: return (X11KeyCode)0x0ece;
                case 0x315f: return (X11KeyCode)0x0ecf;
                case 0x3160: return (X11KeyCode)0x0ed0;
                case 0x3161: return (X11KeyCode)0x0ed1;
                case 0x3162: return (X11KeyCode)0x0ed2;
                case 0x3163: return (X11KeyCode)0x0ed3;
                case 0x11a8: return (X11KeyCode)0x0ed4;
                case 0x11a9: return (X11KeyCode)0x0ed5;
                case 0x11aa: return (X11KeyCode)0x0ed6;
                case 0x11ab: return (X11KeyCode)0x0ed7;
                case 0x11ac: return (X11KeyCode)0x0ed8;
                case 0x11ad: return (X11KeyCode)0x0ed9;
                case 0x11ae: return (X11KeyCode)0x0eda;
                case 0x11af: return (X11KeyCode)0x0edb;
                case 0x11b0: return (X11KeyCode)0x0edc;
                case 0x11b1: return (X11KeyCode)0x0edd;
                case 0x11b2: return (X11KeyCode)0x0ede;
                case 0x11b3: return (X11KeyCode)0x0edf;
                case 0x11b4: return (X11KeyCode)0x0ee0;
                case 0x11b5: return (X11KeyCode)0x0ee1;
                case 0x11b6: return (X11KeyCode)0x0ee2;
                case 0x11b7: return (X11KeyCode)0x0ee3;
                case 0x11b8: return (X11KeyCode)0x0ee4;
                case 0x11b9: return (X11KeyCode)0x0ee5;
                case 0x11ba: return (X11KeyCode)0x0ee6;
                case 0x11bb: return (X11KeyCode)0x0ee7;
                case 0x11bc: return (X11KeyCode)0x0ee8;
                case 0x11bd: return (X11KeyCode)0x0ee9;
                case 0x11be: return (X11KeyCode)0x0eea;
                case 0x11bf: return (X11KeyCode)0x0eeb;
                case 0x11c0: return (X11KeyCode)0x0eec;
                case 0x11c1: return (X11KeyCode)0x0eed;
                case 0x11c2: return (X11KeyCode)0x0eee;
                case 0x316d: return (X11KeyCode)0x0eef;
                case 0x3171: return (X11KeyCode)0x0ef0;
                case 0x3178: return (X11KeyCode)0x0ef1;
                case 0x317f: return (X11KeyCode)0x0ef2;
                case 0x3181: return (X11KeyCode)0x0ef3;
                case 0x3184: return (X11KeyCode)0x0ef4;
                case 0x3186: return (X11KeyCode)0x0ef5;
                case 0x318d: return (X11KeyCode)0x0ef6;
                case 0x318e: return (X11KeyCode)0x0ef7;
                case 0x11eb: return (X11KeyCode)0x0ef8;
                case 0x11f0: return (X11KeyCode)0x0ef9;
                case 0x11f9: return (X11KeyCode)0x0efa;
                case 0x20a9: return (X11KeyCode)0x0eff;
                case 0x0152: return (X11KeyCode)0x13bc;
                case 0x0153: return (X11KeyCode)0x13bd;
                case 0x0178: return (X11KeyCode)0x13be;
                case 0x20a0: return (X11KeyCode)0x20a0;
                case 0x20a1: return (X11KeyCode)0x20a1;
                case 0x20a2: return (X11KeyCode)0x20a2;
                case 0x20a3: return (X11KeyCode)0x20a3;
                case 0x20a4: return (X11KeyCode)0x20a4;
                case 0x20a5: return (X11KeyCode)0x20a5;
                case 0x20a6: return (X11KeyCode)0x20a6;
                case 0x20a7: return (X11KeyCode)0x20a7;
                case 0x20a8: return (X11KeyCode)0x20a8;
                //case 0x20a9: return (X11KeyCode)0x20a9;
                case 0x20aa: return (X11KeyCode)0x20aa;
                case 0x20ab: return (X11KeyCode)0x20ab;
                case 0x20ac: return (X11KeyCode)0x20ac;
                //case 0x0000: return (X11KeyCode)0xfd01;
                //case 0x0000: return (X11KeyCode)0xfd02;
                //case 0x0000: return (X11KeyCode)0xfd03;
                //case 0x0000: return (X11KeyCode)0xfd04;
                //case 0x0000: return (X11KeyCode)0xfd05;
                //case 0x0000: return (X11KeyCode)0xfd06;
                //case 0x0000: return (X11KeyCode)0xfd07;
                //case 0x0000: return (X11KeyCode)0xfd08;
                //case 0x0000: return (X11KeyCode)0xfd09;
                //case 0x0000: return (X11KeyCode)0xfd0a;
                //case 0x0000: return (X11KeyCode)0xfd0b;
                //case 0x0000: return (X11KeyCode)0xfd0c;
                //case 0x0000: return (X11KeyCode)0xfd0d;
                //case 0x0000: return (X11KeyCode)0xfd0e;
                //case 0x0000: return (X11KeyCode)0xfd0f;
                //case 0x0000: return (X11KeyCode)0xfd10;
                //case 0x0000: return (X11KeyCode)0xfd11;
                //case 0x0000: return (X11KeyCode)0xfd12;
                //case 0x0000: return (X11KeyCode)0xfd13;
                //case 0x0000: return (X11KeyCode)0xfd14;
                //case 0x0000: return (X11KeyCode)0xfd15;
                //case 0x0000: return (X11KeyCode)0xfd16;
                //case 0x0000: return (X11KeyCode)0xfd17;
                //case 0x0000: return (X11KeyCode)0xfd18;
                //case 0x0000: return (X11KeyCode)0xfd19;
                //case 0x0000: return (X11KeyCode)0xfd1a;
                //case 0x0000: return (X11KeyCode)0xfd1b;
                //case 0x0000: return (X11KeyCode)0xfd1c;
                //case 0x0000: return (X11KeyCode)0xfd1d;
                //case 0x0000: return (X11KeyCode)0xfd1e;
                //case 0x0000: return (X11KeyCode)0xfe01;
                //case 0x0000: return (X11KeyCode)0xfe02;
                //case 0x0000: return (X11KeyCode)0xfe03;
                //case 0x0000: return (X11KeyCode)0xfe04;
                //case 0x0000: return (X11KeyCode)0xfe05;
                //case 0x0000: return (X11KeyCode)0xfe06;
                //case 0x0000: return (X11KeyCode)0xfe07;
                //case 0x0000: return (X11KeyCode)0xfe08;
                //case 0x0000: return (X11KeyCode)0xfe09;
                //case 0x0000: return (X11KeyCode)0xfe0a;
                //case 0x0000: return (X11KeyCode)0xfe0b;
                //case 0x0000: return (X11KeyCode)0xfe0c;
                //case 0x0000: return (X11KeyCode)0xfe0d;
                //case 0x0000: return (X11KeyCode)0xfe0e;
                //case 0x0000: return (X11KeyCode)0xfe0f;
                //case 0x0000: return (X11KeyCode)0xfe20;
                //case 0x0000: return (X11KeyCode)0xfe21;
                //case 0x0000: return (X11KeyCode)0xfe22;
                //case 0x0000: return (X11KeyCode)0xfe23;
                //case 0x0000: return (X11KeyCode)0xfe24;
                //case 0x0000: return (X11KeyCode)0xfe25;
                //case 0x0000: return (X11KeyCode)0xfe26;
                //case 0x0000: return (X11KeyCode)0xfe27;
                //case 0x0000: return (X11KeyCode)0xfe28;
                //case 0x0000: return (X11KeyCode)0xfe29;
                //case 0x0000: return (X11KeyCode)0xfe2a;
                //case 0x0000: return (X11KeyCode)0xfe2b;
                //case 0x0000: return (X11KeyCode)0xfe2c;
                //case 0x0000: return (X11KeyCode)0xfe2d;
                //case 0x0000: return (X11KeyCode)0xfe2e;
                //case 0x0000: return (X11KeyCode)0xfe2f;
                //case 0x0000: return (X11KeyCode)0xfe30;
                //case 0x0000: return (X11KeyCode)0xfe31;
                //case 0x0000: return (X11KeyCode)0xfe32;
                //case 0x0000: return (X11KeyCode)0xfe33;
                //case 0x0000: return (X11KeyCode)0xfe34;
                case 0x0300: return (X11KeyCode)0xfe50;
                case 0x0301: return (X11KeyCode)0xfe51;
                case 0x0302: return (X11KeyCode)0xfe52;
                case 0x0303: return (X11KeyCode)0xfe53;
                case 0x0304: return (X11KeyCode)0xfe54;
                case 0x0306: return (X11KeyCode)0xfe55;
                case 0x0307: return (X11KeyCode)0xfe56;
                case 0x0308: return (X11KeyCode)0xfe57;
                case 0x030a: return (X11KeyCode)0xfe58;
                case 0x030b: return (X11KeyCode)0xfe59;
                case 0x030c: return (X11KeyCode)0xfe5a;
                case 0x0327: return (X11KeyCode)0xfe5b;
                case 0x0328: return (X11KeyCode)0xfe5c;
                case 0x0345: return (X11KeyCode)0xfe5d;
                case 0x3099: return (X11KeyCode)0xfe5e;
                case 0x309a: return (X11KeyCode)0xfe5f;
                //case 0x0000: return (X11KeyCode)0xfe70;
                //case 0x0000: return (X11KeyCode)0xfe71;
                //case 0x0000: return (X11KeyCode)0xfe72;
                //case 0x0000: return (X11KeyCode)0xfe73;
                //case 0x0000: return (X11KeyCode)0xfe74;
                //case 0x0000: return (X11KeyCode)0xfe75;
                //case 0x0000: return (X11KeyCode)0xfe76;
                //case 0x0000: return (X11KeyCode)0xfe77;
                //case 0x0000: return (X11KeyCode)0xfe78;
                //case 0x0000: return (X11KeyCode)0xfe79;
                //case 0x0000: return (X11KeyCode)0xfe7a;
                //case 0x0000: return (X11KeyCode)0xfed0;
                //case 0x0000: return (X11KeyCode)0xfed1;
                //case 0x0000: return (X11KeyCode)0xfed2;
                //case 0x0000: return (X11KeyCode)0xfed4;
                //case 0x0000: return (X11KeyCode)0xfed5;
                //case 0x0000: return (X11KeyCode)0xfee0;
                //case 0x0000: return (X11KeyCode)0xfee1;
                //case 0x0000: return (X11KeyCode)0xfee2;
                //case 0x0000: return (X11KeyCode)0xfee3;
                //case 0x0000: return (X11KeyCode)0xfee4;
                //case 0x0000: return (X11KeyCode)0xfee5;
                //case 0x0000: return (X11KeyCode)0xfee6;
                //case 0x0000: return (X11KeyCode)0xfee7;
                //case 0x0000: return (X11KeyCode)0xfee8;
                //case 0x0000: return (X11KeyCode)0xfee9;
                //case 0x0000: return (X11KeyCode)0xfeea;
                //case 0x0000: return (X11KeyCode)0xfeeb;
                //case 0x0000: return (X11KeyCode)0xfeec;
                //case 0x0000: return (X11KeyCode)0xfeed;
                //case 0x0000: return (X11KeyCode)0xfeee;
                //case 0x0000: return (X11KeyCode)0xfeef;
                //case 0x0000: return (X11KeyCode)0xfef0;
                //case 0x0000: return (X11KeyCode)0xfef1;
                //case 0x0000: return (X11KeyCode)0xfef2;
                //case 0x0000: return (X11KeyCode)0xfef3;
                //case 0x0000: return (X11KeyCode)0xfef4;
                //case 0x0000: return (X11KeyCode)0xfef5;
                //case 0x0000: return (X11KeyCode)0xfef6;
                //case 0x0000: return (X11KeyCode)0xfef7;
                //case 0x0000: return (X11KeyCode)0xfef8;
                //case 0x0000: return (X11KeyCode)0xfef9;
                //case 0x0000: return (X11KeyCode)0xfefa;
                //case 0x0000: return (X11KeyCode)0xfefb;
                //case 0x0000: return (X11KeyCode)0xfefc;
                //case 0x0000: return (X11KeyCode)0xfefd;
                case 0x0008: return (X11KeyCode)0xff08;
                case 0x0009: return (X11KeyCode)0xff09;
                case 0x000a: return (X11KeyCode)0xff0a;
                case 0x000b: return (X11KeyCode)0xff0b;
                case 0x000d: return (X11KeyCode)0xff0d;
                case 0x0013: return (X11KeyCode)0xff13;
                case 0x0014: return (X11KeyCode)0xff14;
                case 0x0015: return (X11KeyCode)0xff15;
                case 0x001b: return (X11KeyCode)0xff1b;
                //case 0x0000: return (X11KeyCode)0xff20;
                //case 0x0000: return (X11KeyCode)0xff21;
                //case 0x0000: return (X11KeyCode)0xff22;
                //case 0x0000: return (X11KeyCode)0xff23;
                //case 0x0000: return (X11KeyCode)0xff24;
                //case 0x0000: return (X11KeyCode)0xff25;
                //case 0x0000: return (X11KeyCode)0xff26;
                //case 0x0000: return (X11KeyCode)0xff27;
                //case 0x0000: return (X11KeyCode)0xff28;
                //case 0x0000: return (X11KeyCode)0xff29;
                //case 0x0000: return (X11KeyCode)0xff2a;
                //case 0x0000: return (X11KeyCode)0xff2b;
                //case 0x0000: return (X11KeyCode)0xff2c;
                //case 0x0000: return (X11KeyCode)0xff2d;
                //case 0x0000: return (X11KeyCode)0xff2e;
                //case 0x0000: return (X11KeyCode)0xff2f;
                //case 0x0000: return (X11KeyCode)0xff30;
                //case 0x0000: return (X11KeyCode)0xff31;
                //case 0x0000: return (X11KeyCode)0xff32;
                //case 0x0000: return (X11KeyCode)0xff33;
                //case 0x0000: return (X11KeyCode)0xff34;
                //case 0x0000: return (X11KeyCode)0xff35;
                //case 0x0000: return (X11KeyCode)0xff36;
                //case 0x0000: return (X11KeyCode)0xff37;
                //case 0x0000: return (X11KeyCode)0xff38;
                //case 0x0000: return (X11KeyCode)0xff39;
                //case 0x0000: return (X11KeyCode)0xff3a;
                //case 0x0000: return (X11KeyCode)0xff3b;
                //case 0x0000: return (X11KeyCode)0xff3c;
                //case 0x0000: return (X11KeyCode)0xff3d;
                //case 0x0000: return (X11KeyCode)0xff3e;
                //case 0x0000: return (X11KeyCode)0xff3f;
                //case 0x0000: return (X11KeyCode)0xff50;
                //case 0x0000: return (X11KeyCode)0xff51;
                //case 0x0000: return (X11KeyCode)0xff52;
                //case 0x0000: return (X11KeyCode)0xff53;
                //case 0x0000: return (X11KeyCode)0xff54;
                //case 0x0000: return (X11KeyCode)0xff55;
                //case 0x0000: return (X11KeyCode)0xff56;
                //case 0x0000: return (X11KeyCode)0xff57;
                //case 0x0000: return (X11KeyCode)0xff58;
                //case 0x0000: return (X11KeyCode)0xff60;
                //case 0x0000: return (X11KeyCode)0xff61;
                //case 0x0000: return (X11KeyCode)0xff62;
                //case 0x0000: return (X11KeyCode)0xff63;
                //case 0x0000: return (X11KeyCode)0xff65;
                //case 0x0000: return (X11KeyCode)0xff66;
                //case 0x0000: return (X11KeyCode)0xff67;
                //case 0x0000: return (X11KeyCode)0xff68;
                //case 0x0000: return (X11KeyCode)0xff69;
                //case 0x0000: return (X11KeyCode)0xff6a;
                //case 0x0000: return (X11KeyCode)0xff6b;
                //case 0x0000: return (X11KeyCode)0xff7e;
                //case 0x0000: return (X11KeyCode)0xff7f;
                //case 0x0020: return (X11KeyCode)0xff80;
                //case 0x0009: return (X11KeyCode)0xff89;
                //case 0x000d: return (X11KeyCode)0xff8d;
                //case 0x0000: return (X11KeyCode)0xff91;
                //case 0x0000: return (X11KeyCode)0xff92;
                //case 0x0000: return (X11KeyCode)0xff93;
                //case 0x0000: return (X11KeyCode)0xff94;
                //case 0x0000: return (X11KeyCode)0xff95;
                //case 0x0000: return (X11KeyCode)0xff96;
                //case 0x0000: return (X11KeyCode)0xff97;
                //case 0x0000: return (X11KeyCode)0xff98;
                //case 0x0000: return (X11KeyCode)0xff99;
                //case 0x0000: return (X11KeyCode)0xff9a;
                //case 0x0000: return (X11KeyCode)0xff9b;
                //case 0x0000: return (X11KeyCode)0xff9c;
                //case 0x0000: return (X11KeyCode)0xff9d;
                //case 0x0000: return (X11KeyCode)0xff9e;
                //case 0x0000: return (X11KeyCode)0xff9f;
                //case 0x002a: return (X11KeyCode)0xffaa;
                //case 0x002b: return (X11KeyCode)0xffab;
                //case 0x002c: return (X11KeyCode)0xffac;
                //case 0x002d: return (X11KeyCode)0xffad;
                //case 0x002e: return (X11KeyCode)0xffae;
                //case 0x002f: return (X11KeyCode)0xffaf;
                //case 0x0030: return (X11KeyCode)0xffb0;
                //case 0x0031: return (X11KeyCode)0xffb1;
                //case 0x0032: return (X11KeyCode)0xffb2;
                //case 0x0033: return (X11KeyCode)0xffb3;
                //case 0x0034: return (X11KeyCode)0xffb4;
                //case 0x0035: return (X11KeyCode)0xffb5;
                //case 0x0036: return (X11KeyCode)0xffb6;
                //case 0x0037: return (X11KeyCode)0xffb7;
                //case 0x0038: return (X11KeyCode)0xffb8;
                //case 0x0039: return (X11KeyCode)0xffb9;
                //case 0x003d: return (X11KeyCode)0xffbd;
                //case 0x0000: return (X11KeyCode)0xffbe;
                //case 0x0000: return (X11KeyCode)0xffbf;
                //case 0x0000: return (X11KeyCode)0xffc0;
                //case 0x0000: return (X11KeyCode)0xffc1;
                //case 0x0000: return (X11KeyCode)0xffc2;
                //case 0x0000: return (X11KeyCode)0xffc3;
                //case 0x0000: return (X11KeyCode)0xffc4;
                //case 0x0000: return (X11KeyCode)0xffc5;
                //case 0x0000: return (X11KeyCode)0xffc6;
                //case 0x0000: return (X11KeyCode)0xffc7;
                //case 0x0000: return (X11KeyCode)0xffc8;
                //case 0x0000: return (X11KeyCode)0xffc9;
                //case 0x0000: return (X11KeyCode)0xffca;
                //case 0x0000: return (X11KeyCode)0xffcb;
                //case 0x0000: return (X11KeyCode)0xffcc;
                //case 0x0000: return (X11KeyCode)0xffcd;
                //case 0x0000: return (X11KeyCode)0xffce;
                //case 0x0000: return (X11KeyCode)0xffcf;
                //case 0x0000: return (X11KeyCode)0xffd0;
                //case 0x0000: return (X11KeyCode)0xffd1;
                //case 0x0000: return (X11KeyCode)0xffd2;
                //case 0x0000: return (X11KeyCode)0xffd3;
                //case 0x0000: return (X11KeyCode)0xffd4;
                //case 0x0000: return (X11KeyCode)0xffd5;
                //case 0x0000: return (X11KeyCode)0xffd6;
                //case 0x0000: return (X11KeyCode)0xffd7;
                //case 0x0000: return (X11KeyCode)0xffd8;
                //case 0x0000: return (X11KeyCode)0xffd9;
                //case 0x0000: return (X11KeyCode)0xffda;
                //case 0x0000: return (X11KeyCode)0xffdb;
                //case 0x0000: return (X11KeyCode)0xffdc;
                //case 0x0000: return (X11KeyCode)0xffdd;
                //case 0x0000: return (X11KeyCode)0xffde;
                //case 0x0000: return (X11KeyCode)0xffdf;
                //case 0x0000: return (X11KeyCode)0xffe0;
                //case 0x0000: return (X11KeyCode)0xffe1;
                //case 0x0000: return (X11KeyCode)0xffe2;
                //case 0x0000: return (X11KeyCode)0xffe3;
                //case 0x0000: return (X11KeyCode)0xffe4;
                //case 0x0000: return (X11KeyCode)0xffe5;
                //case 0x0000: return (X11KeyCode)0xffe6;
                //case 0x0000: return (X11KeyCode)0xffe7;
                //case 0x0000: return (X11KeyCode)0xffe8;
                //case 0x0000: return (X11KeyCode)0xffe9;
                //case 0x0000: return (X11KeyCode)0xffea;
                //case 0x0000: return (X11KeyCode)0xffeb;
                //case 0x0000: return (X11KeyCode)0xffec;
                //case 0x0000: return (X11KeyCode)0xffed;
                //case 0x0000: return (X11KeyCode)0xffee;
                //case 0x0000: return (X11KeyCode)0xffff;
                //case 0x0000: return (X11KeyCode)0xffffff;
                case 0x0491: return (X11KeyCode)0x06ad;
                case 0x0490: return (X11KeyCode)0x06bd;
                //case 0x0000: return (X11KeyCode)0x14a1;
                case 0x0587: return (X11KeyCode)0x14a2;
                case 0x0589: return (X11KeyCode)0x14a3;
                //case 0x0029: return (X11KeyCode)0x14a4;
                //case 0x0028: return (X11KeyCode)0x14a5;
                //case 0x00bb: return (X11KeyCode)0x14a6;
                //case 0x00ab: return (X11KeyCode)0x14a7;
                //case 0x2014: return (X11KeyCode)0x14a8;
                //case 0x002e: return (X11KeyCode)0x14a9;
                case 0x055d: return (X11KeyCode)0x14aa;
                //case 0x002c: return (X11KeyCode)0x14ab;
                //case 0x2013: return (X11KeyCode)0x14ac;
                case 0x058a: return (X11KeyCode)0x14ad;
                //case 0x2026: return (X11KeyCode)0x14ae;
                case 0x055c: return (X11KeyCode)0x14af;
                case 0x055b: return (X11KeyCode)0x14b0;
                case 0x055e: return (X11KeyCode)0x14b1;
                case 0x0531: return (X11KeyCode)0x14b2;
                case 0x0561: return (X11KeyCode)0x14b3;
                case 0x0532: return (X11KeyCode)0x14b4;
                case 0x0562: return (X11KeyCode)0x14b5;
                case 0x0533: return (X11KeyCode)0x14b6;
                case 0x0563: return (X11KeyCode)0x14b7;
                case 0x0534: return (X11KeyCode)0x14b8;
                case 0x0564: return (X11KeyCode)0x14b9;
                case 0x0535: return (X11KeyCode)0x14ba;
                case 0x0565: return (X11KeyCode)0x14bb;
                case 0x0536: return (X11KeyCode)0x14bc;
                case 0x0566: return (X11KeyCode)0x14bd;
                case 0x0537: return (X11KeyCode)0x14be;
                case 0x0567: return (X11KeyCode)0x14bf;
                case 0x0538: return (X11KeyCode)0x14c0;
                case 0x0568: return (X11KeyCode)0x14c1;
                case 0x0539: return (X11KeyCode)0x14c2;
                case 0x0569: return (X11KeyCode)0x14c3;
                case 0x053a: return (X11KeyCode)0x14c4;
                case 0x056a: return (X11KeyCode)0x14c5;
                case 0x053b: return (X11KeyCode)0x14c6;
                case 0x056b: return (X11KeyCode)0x14c7;
                case 0x053c: return (X11KeyCode)0x14c8;
                case 0x056c: return (X11KeyCode)0x14c9;
                case 0x053d: return (X11KeyCode)0x14ca;
                case 0x056d: return (X11KeyCode)0x14cb;
                case 0x053e: return (X11KeyCode)0x14cc;
                case 0x056e: return (X11KeyCode)0x14cd;
                case 0x053f: return (X11KeyCode)0x14ce;
                case 0x056f: return (X11KeyCode)0x14cf;
                case 0x0540: return (X11KeyCode)0x14d0;
                case 0x0570: return (X11KeyCode)0x14d1;
                case 0x0541: return (X11KeyCode)0x14d2;
                case 0x0571: return (X11KeyCode)0x14d3;
                case 0x0542: return (X11KeyCode)0x14d4;
                case 0x0572: return (X11KeyCode)0x14d5;
                case 0x0543: return (X11KeyCode)0x14d6;
                case 0x0573: return (X11KeyCode)0x14d7;
                case 0x0544: return (X11KeyCode)0x14d8;
                case 0x0574: return (X11KeyCode)0x14d9;
                case 0x0545: return (X11KeyCode)0x14da;
                case 0x0575: return (X11KeyCode)0x14db;
                case 0x0546: return (X11KeyCode)0x14dc;
                case 0x0576: return (X11KeyCode)0x14dd;
                case 0x0547: return (X11KeyCode)0x14de;
                case 0x0577: return (X11KeyCode)0x14df;
                case 0x0548: return (X11KeyCode)0x14e0;
                case 0x0578: return (X11KeyCode)0x14e1;
                case 0x0549: return (X11KeyCode)0x14e2;
                case 0x0579: return (X11KeyCode)0x14e3;
                case 0x054a: return (X11KeyCode)0x14e4;
                case 0x057a: return (X11KeyCode)0x14e5;
                case 0x054b: return (X11KeyCode)0x14e6;
                case 0x057b: return (X11KeyCode)0x14e7;
                case 0x054c: return (X11KeyCode)0x14e8;
                case 0x057c: return (X11KeyCode)0x14e9;
                case 0x054d: return (X11KeyCode)0x14ea;
                case 0x057d: return (X11KeyCode)0x14eb;
                case 0x054e: return (X11KeyCode)0x14ec;
                case 0x057e: return (X11KeyCode)0x14ed;
                case 0x054f: return (X11KeyCode)0x14ee;
                case 0x057f: return (X11KeyCode)0x14ef;
                case 0x0550: return (X11KeyCode)0x14f0;
                case 0x0580: return (X11KeyCode)0x14f1;
                case 0x0551: return (X11KeyCode)0x14f2;
                case 0x0581: return (X11KeyCode)0x14f3;
                case 0x0552: return (X11KeyCode)0x14f4;
                case 0x0582: return (X11KeyCode)0x14f5;
                case 0x0553: return (X11KeyCode)0x14f6;
                case 0x0583: return (X11KeyCode)0x14f7;
                case 0x0554: return (X11KeyCode)0x14f8;
                case 0x0584: return (X11KeyCode)0x14f9;
                case 0x0555: return (X11KeyCode)0x14fa;
                case 0x0585: return (X11KeyCode)0x14fb;
                case 0x0556: return (X11KeyCode)0x14fc;
                case 0x0586: return (X11KeyCode)0x14fd;
                case 0x055a: return (X11KeyCode)0x14fe;
                //case 0x00a7: return (X11KeyCode)0x14ff;
                case 0x10d0: return (X11KeyCode)0x15d0;
                case 0x10d1: return (X11KeyCode)0x15d1;
                case 0x10d2: return (X11KeyCode)0x15d2;
                case 0x10d3: return (X11KeyCode)0x15d3;
                case 0x10d4: return (X11KeyCode)0x15d4;
                case 0x10d5: return (X11KeyCode)0x15d5;
                case 0x10d6: return (X11KeyCode)0x15d6;
                case 0x10d7: return (X11KeyCode)0x15d7;
                case 0x10d8: return (X11KeyCode)0x15d8;
                case 0x10d9: return (X11KeyCode)0x15d9;
                case 0x10da: return (X11KeyCode)0x15da;
                case 0x10db: return (X11KeyCode)0x15db;
                case 0x10dc: return (X11KeyCode)0x15dc;
                case 0x10dd: return (X11KeyCode)0x15dd;
                case 0x10de: return (X11KeyCode)0x15de;
                case 0x10df: return (X11KeyCode)0x15df;
                case 0x10e0: return (X11KeyCode)0x15e0;
                case 0x10e1: return (X11KeyCode)0x15e1;
                case 0x10e2: return (X11KeyCode)0x15e2;
                case 0x10e3: return (X11KeyCode)0x15e3;
                case 0x10e4: return (X11KeyCode)0x15e4;
                case 0x10e5: return (X11KeyCode)0x15e5;
                case 0x10e6: return (X11KeyCode)0x15e6;
                case 0x10e7: return (X11KeyCode)0x15e7;
                case 0x10e8: return (X11KeyCode)0x15e8;
                case 0x10e9: return (X11KeyCode)0x15e9;
                case 0x10ea: return (X11KeyCode)0x15ea;
                case 0x10eb: return (X11KeyCode)0x15eb;
                case 0x10ec: return (X11KeyCode)0x15ec;
                case 0x10ed: return (X11KeyCode)0x15ed;
                case 0x10ee: return (X11KeyCode)0x15ee;
                case 0x10ef: return (X11KeyCode)0x15ef;
                case 0x10f0: return (X11KeyCode)0x15f0;
                case 0x10f1: return (X11KeyCode)0x15f1;
                case 0x10f2: return (X11KeyCode)0x15f2;
                case 0x10f3: return (X11KeyCode)0x15f3;
                case 0x10f4: return (X11KeyCode)0x15f4;
                case 0x10f5: return (X11KeyCode)0x15f5;
                case 0x10f6: return (X11KeyCode)0x15f6;
                case 0x1e02: return (X11KeyCode)0x12a1;
                case 0x1e03: return (X11KeyCode)0x12a2;
                case 0x1e0a: return (X11KeyCode)0x12a6;
                case 0x1e80: return (X11KeyCode)0x12a8;
                case 0x1e82: return (X11KeyCode)0x12aa;
                case 0x1e0b: return (X11KeyCode)0x12ab;
                case 0x1ef2: return (X11KeyCode)0x12ac;
                case 0x1e1e: return (X11KeyCode)0x12b0;
                case 0x1e1f: return (X11KeyCode)0x12b1;
                case 0x1e40: return (X11KeyCode)0x12b4;
                case 0x1e41: return (X11KeyCode)0x12b5;
                case 0x1e56: return (X11KeyCode)0x12b7;
                case 0x1e81: return (X11KeyCode)0x12b8;
                case 0x1e57: return (X11KeyCode)0x12b9;
                case 0x1e83: return (X11KeyCode)0x12ba;
                case 0x1e60: return (X11KeyCode)0x12bb;
                case 0x1ef3: return (X11KeyCode)0x12bc;
                case 0x1e84: return (X11KeyCode)0x12bd;
                case 0x1e85: return (X11KeyCode)0x12be;
                case 0x1e61: return (X11KeyCode)0x12bf;
                case 0x0174: return (X11KeyCode)0x12d0;
                case 0x1e6a: return (X11KeyCode)0x12d7;
                case 0x0176: return (X11KeyCode)0x12de;
                case 0x0175: return (X11KeyCode)0x12f0;
                case 0x1e6b: return (X11KeyCode)0x12f7;
                case 0x0177: return (X11KeyCode)0x12fe;
                case 0x06f0: return (X11KeyCode)0x0590;
                case 0x06f1: return (X11KeyCode)0x0591;
                case 0x06f2: return (X11KeyCode)0x0592;
                case 0x06f3: return (X11KeyCode)0x0593;
                case 0x06f4: return (X11KeyCode)0x0594;
                case 0x06f5: return (X11KeyCode)0x0595;
                case 0x06f6: return (X11KeyCode)0x0596;
                case 0x06f7: return (X11KeyCode)0x0597;
                case 0x06f8: return (X11KeyCode)0x0598;
                case 0x06f9: return (X11KeyCode)0x0599;
                case 0x066a: return (X11KeyCode)0x05a5;
                case 0x0670: return (X11KeyCode)0x05a6;
                case 0x0679: return (X11KeyCode)0x05a7;
                case 0x067e: return (X11KeyCode)0x05a8;
                case 0x0686: return (X11KeyCode)0x05a9;
                case 0x0688: return (X11KeyCode)0x05aa;
                case 0x0691: return (X11KeyCode)0x05ab;
                case 0x06d4: return (X11KeyCode)0x05ae;
                case 0x0660: return (X11KeyCode)0x05b0;
                case 0x0661: return (X11KeyCode)0x05b1;
                case 0x0662: return (X11KeyCode)0x05b2;
                case 0x0663: return (X11KeyCode)0x05b3;
                case 0x0664: return (X11KeyCode)0x05b4;
                case 0x0665: return (X11KeyCode)0x05b5;
                case 0x0666: return (X11KeyCode)0x05b6;
                case 0x0667: return (X11KeyCode)0x05b7;
                case 0x0668: return (X11KeyCode)0x05b8;
                case 0x0669: return (X11KeyCode)0x05b9;
                case 0x0653: return (X11KeyCode)0x05f3;
                case 0x0654: return (X11KeyCode)0x05f4;
                case 0x0655: return (X11KeyCode)0x05f5;
                case 0x0698: return (X11KeyCode)0x05f6;
                case 0x06a4: return (X11KeyCode)0x05f7;
                case 0x06a9: return (X11KeyCode)0x05f8;
                case 0x06af: return (X11KeyCode)0x05f9;
                case 0x06ba: return (X11KeyCode)0x05fa;
                case 0x06be: return (X11KeyCode)0x05fb;
                case 0x06cc: return (X11KeyCode)0x05fc;
                case 0x06d2: return (X11KeyCode)0x05fd;
                case 0x06c1: return (X11KeyCode)0x05fe;
                case 0x0492: return (X11KeyCode)0x0680;
                case 0x0496: return (X11KeyCode)0x0681;
                case 0x049a: return (X11KeyCode)0x0682;
                case 0x049c: return (X11KeyCode)0x0683;
                case 0x04a2: return (X11KeyCode)0x0684;
                case 0x04ae: return (X11KeyCode)0x0685;
                case 0x04b0: return (X11KeyCode)0x0686;
                case 0x04b2: return (X11KeyCode)0x0687;
                case 0x04b6: return (X11KeyCode)0x0688;
                case 0x04b8: return (X11KeyCode)0x0689;
                case 0x04ba: return (X11KeyCode)0x068a;
                case 0x04d8: return (X11KeyCode)0x068c;
                case 0x04e2: return (X11KeyCode)0x068d;
                case 0x04e8: return (X11KeyCode)0x068e;
                case 0x04ee: return (X11KeyCode)0x068f;
                case 0x0493: return (X11KeyCode)0x0690;
                case 0x0497: return (X11KeyCode)0x0691;
                case 0x049b: return (X11KeyCode)0x0692;
                case 0x049d: return (X11KeyCode)0x0693;
                case 0x04a3: return (X11KeyCode)0x0694;
                case 0x04af: return (X11KeyCode)0x0695;
                case 0x04b1: return (X11KeyCode)0x0696;
                case 0x04b3: return (X11KeyCode)0x0697;
                case 0x04b7: return (X11KeyCode)0x0698;
                case 0x04b9: return (X11KeyCode)0x0699;
                case 0x04bb: return (X11KeyCode)0x069a;
                case 0x04d9: return (X11KeyCode)0x069c;
                case 0x04e3: return (X11KeyCode)0x069d;
                case 0x04e9: return (X11KeyCode)0x069e;
                case 0x04ef: return (X11KeyCode)0x069f;
                //case 0x0000: return (X11KeyCode)0x16a2;
                case 0x1e8a: return (X11KeyCode)0x16a3;
                //case 0x0000: return (X11KeyCode)0x16a5;
                case 0x012c: return (X11KeyCode)0x16a6;
                //case 0x0000: return (X11KeyCode)0x16a7;
                //case 0x0000: return (X11KeyCode)0x16a8;
                case 0x01b5: return (X11KeyCode)0x16a9;
                case 0x01e6: return (X11KeyCode)0x16aa;
                case 0x019f: return (X11KeyCode)0x16af;
                //case 0x0000: return (X11KeyCode)0x16b2;
                case 0x1e8b: return (X11KeyCode)0x16b3;
                //case 0x0000: return (X11KeyCode)0x16b4;
                //case 0x0000: return (X11KeyCode)0x16b5;
                case 0x012d: return (X11KeyCode)0x16b6;
                //case 0x0000: return (X11KeyCode)0x16b7;
                //case 0x0000: return (X11KeyCode)0x16b8;
                case 0x01b6: return (X11KeyCode)0x16b9;
                case 0x01e7: return (X11KeyCode)0x16ba;
                case 0x01d2: return (X11KeyCode)0x16bd;
                case 0x0275: return (X11KeyCode)0x16bf;
                case 0x018f: return (X11KeyCode)0x16c6;
                case 0x0259: return (X11KeyCode)0x16f6;
                case 0x1e36: return (X11KeyCode)0x16d1;
                //case 0x0000: return (X11KeyCode)0x16d2;
                //case 0x0000: return (X11KeyCode)0x16d3;
                case 0x1e37: return (X11KeyCode)0x16e1;
                //case 0x0000: return (X11KeyCode)0x16e2;
                //case 0x0000: return (X11KeyCode)0x16e3;
                case 0x1ea0: return (X11KeyCode)0x1ea0;
                case 0x1ea1: return (X11KeyCode)0x1ea1;
                case 0x1ea2: return (X11KeyCode)0x1ea2;
                case 0x1ea3: return (X11KeyCode)0x1ea3;
                case 0x1ea4: return (X11KeyCode)0x1ea4;
                case 0x1ea5: return (X11KeyCode)0x1ea5;
                case 0x1ea6: return (X11KeyCode)0x1ea6;
                case 0x1ea7: return (X11KeyCode)0x1ea7;
                case 0x1ea8: return (X11KeyCode)0x1ea8;
                case 0x1ea9: return (X11KeyCode)0x1ea9;
                case 0x1eaa: return (X11KeyCode)0x1eaa;
                case 0x1eab: return (X11KeyCode)0x1eab;
                case 0x1eac: return (X11KeyCode)0x1eac;
                case 0x1ead: return (X11KeyCode)0x1ead;
                case 0x1eae: return (X11KeyCode)0x1eae;
                case 0x1eaf: return (X11KeyCode)0x1eaf;
                case 0x1eb0: return (X11KeyCode)0x1eb0;
                case 0x1eb1: return (X11KeyCode)0x1eb1;
                case 0x1eb2: return (X11KeyCode)0x1eb2;
                case 0x1eb3: return (X11KeyCode)0x1eb3;
                case 0x1eb4: return (X11KeyCode)0x1eb4;
                case 0x1eb5: return (X11KeyCode)0x1eb5;
                case 0x1eb6: return (X11KeyCode)0x1eb6;
                case 0x1eb7: return (X11KeyCode)0x1eb7;
                case 0x1eb8: return (X11KeyCode)0x1eb8;
                case 0x1eb9: return (X11KeyCode)0x1eb9;
                case 0x1eba: return (X11KeyCode)0x1eba;
                case 0x1ebb: return (X11KeyCode)0x1ebb;
                case 0x1ebc: return (X11KeyCode)0x1ebc;
                case 0x1ebd: return (X11KeyCode)0x1ebd;
                case 0x1ebe: return (X11KeyCode)0x1ebe;
                case 0x1ebf: return (X11KeyCode)0x1ebf;
                case 0x1ec0: return (X11KeyCode)0x1ec0;
                case 0x1ec1: return (X11KeyCode)0x1ec1;
                case 0x1ec2: return (X11KeyCode)0x1ec2;
                case 0x1ec3: return (X11KeyCode)0x1ec3;
                case 0x1ec4: return (X11KeyCode)0x1ec4;
                case 0x1ec5: return (X11KeyCode)0x1ec5;
                case 0x1ec6: return (X11KeyCode)0x1ec6;
                case 0x1ec7: return (X11KeyCode)0x1ec7;
                case 0x1ec8: return (X11KeyCode)0x1ec8;
                case 0x1ec9: return (X11KeyCode)0x1ec9;
                case 0x1eca: return (X11KeyCode)0x1eca;
                case 0x1ecb: return (X11KeyCode)0x1ecb;
                case 0x1ecc: return (X11KeyCode)0x1ecc;
                case 0x1ecd: return (X11KeyCode)0x1ecd;
                case 0x1ece: return (X11KeyCode)0x1ece;
                case 0x1ecf: return (X11KeyCode)0x1ecf;
                case 0x1ed0: return (X11KeyCode)0x1ed0;
                case 0x1ed1: return (X11KeyCode)0x1ed1;
                case 0x1ed2: return (X11KeyCode)0x1ed2;
                case 0x1ed3: return (X11KeyCode)0x1ed3;
                case 0x1ed4: return (X11KeyCode)0x1ed4;
                case 0x1ed5: return (X11KeyCode)0x1ed5;
                case 0x1ed6: return (X11KeyCode)0x1ed6;
                case 0x1ed7: return (X11KeyCode)0x1ed7;
                case 0x1ed8: return (X11KeyCode)0x1ed8;
                case 0x1ed9: return (X11KeyCode)0x1ed9;
                case 0x1eda: return (X11KeyCode)0x1eda;
                case 0x1edb: return (X11KeyCode)0x1edb;
                case 0x1edc: return (X11KeyCode)0x1edc;
                case 0x1edd: return (X11KeyCode)0x1edd;
                case 0x1ede: return (X11KeyCode)0x1ede;
                case 0x1edf: return (X11KeyCode)0x1edf;
                case 0x1ee0: return (X11KeyCode)0x1ee0;
                case 0x1ee1: return (X11KeyCode)0x1ee1;
                case 0x1ee2: return (X11KeyCode)0x1ee2;
                case 0x1ee3: return (X11KeyCode)0x1ee3;
                case 0x1ee4: return (X11KeyCode)0x1ee4;
                case 0x1ee5: return (X11KeyCode)0x1ee5;
                case 0x1ee6: return (X11KeyCode)0x1ee6;
                case 0x1ee7: return (X11KeyCode)0x1ee7;
                case 0x1ee8: return (X11KeyCode)0x1ee8;
                case 0x1ee9: return (X11KeyCode)0x1ee9;
                case 0x1eea: return (X11KeyCode)0x1eea;
                case 0x1eeb: return (X11KeyCode)0x1eeb;
                case 0x1eec: return (X11KeyCode)0x1eec;
                case 0x1eed: return (X11KeyCode)0x1eed;
                case 0x1eee: return (X11KeyCode)0x1eee;
                case 0x1eef: return (X11KeyCode)0x1eef;
                case 0x1ef0: return (X11KeyCode)0x1ef0;
                case 0x1ef1: return (X11KeyCode)0x1ef1;
                case 0x1ef4: return (X11KeyCode)0x1ef4;
                case 0x1ef5: return (X11KeyCode)0x1ef5;
                case 0x1ef6: return (X11KeyCode)0x1ef6;
                case 0x1ef7: return (X11KeyCode)0x1ef7;
                case 0x1ef8: return (X11KeyCode)0x1ef8;
                case 0x1ef9: return (X11KeyCode)0x1ef9;
                case 0x01a0: return (X11KeyCode)0x1efa;
                case 0x01a1: return (X11KeyCode)0x1efb;
                case 0x01af: return (X11KeyCode)0x1efc;
                case 0x01b0: return (X11KeyCode)0x1efd;
                //case 0x0303: return (X11KeyCode)0x1e9f;
                //case 0x0300: return (X11KeyCode)0x1ef2;
                //case 0x0301: return (X11KeyCode)0x1ef3;
                case 0x0309: return (X11KeyCode)0x1efe;
                case 0x0323: return (X11KeyCode)0x1eff;
                //case 0x0323: return (X11KeyCode)0xfe60;
                //case 0x0309: return (X11KeyCode)0xfe61;
                case 0x031b: return (X11KeyCode)0xfe62;
                default: return 0; //throw new ArgumentException("oopsie woopsie i fuwed up the cowe oWo");
            }
        }
    }
}
