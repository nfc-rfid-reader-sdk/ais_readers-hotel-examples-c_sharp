using System;
using System.Collections.Generic;
using System.Text;

using System.Runtime.InteropServices;
using System.IO;

namespace cs_ais_hotel_dll
{
    enum DL_STATUS
    {

        DL_OK = 0x00,

        //###############################################################
        TIMEOUT_ERROR,
        CRC_ERROR,

        NULL_POINTER,
        PARAMETERS_ERROR,

        MEMORY_ALLOCATION_ERROR,

        NOT_INITIALIZED,
        ALREADY_INITIALIZED,

        BUFFER_OVERFLOW,

        TIMESTAMP_INVALID,

        EVENT_BUSY,
        //###############################################################
        // resource busy
        RESOURCE_NOT_ACQUIRED,
        RESOURCE_ALREADY_ACQUIRED,
        RESOURCE_BUSY,
        //###############################################################
        FILE_OVERSIZE,
        FILE_EMPTY,
        FILE_LOCKED, // when file is fill, and not read yet
        //###############################################################

        //###############################################################
        // open multi
        DEVICE_OPENING_ERROR,
        DEVICE_CAN_NOT_OPEN,
        DEVICE_ALREADY_OPENED,
        DEVICE_NOT_OPENED,
        DEVICE_INDEX_OUT_OF_BOUND,
        DEVICE_CLOSE_ERROR,
        //###############################################################
        // LOG
        LOG_BUFFER_OVERFLOW,
        LOG_EMPTY,
        LOG_NOT_CORRECT,

        // response
        CMD_RESPONSE_UNKNOWN_COMMAND,
        CMD_RESPONSE_WRONG_CMD,
        CMD_RESPONSE_COMMAND_FAILED,
        CMD_RESPONSE_NO_AUTHORIZATION,
        CMD_RESPONSE_UNSUCCESS,
        CMD_RESPONSE_SIZE_OVERFLOW,

        //###############################################################
        // USB RF
        CMD_BRAKE_RTE, // RTE arrived while CMD_IN_PROGRESS
        //###############################################################
        ITEM_IS_ALREADY_IN_LIST,
        ITEM_NOT_IN_LIST,

        //###############################################################
        THREAD_FAILURE,
        //---------------------
        ERR_OBJ_NOT_CREATED,
        //---------------------

        //###############################################################
        // HAMMING
        DL_HAMMING_NOT_ACK,
        DL_HAMMING_WRONG_ACK,
        DL_HAMMING_WRONG_REPLAY,

        //  Formatted transfer
        DL_HAMMING_TERR_TIMEOUT,
        DL_HAMMING_TERR_BAD_FRAME,
        DL_HAMMING_TERR_BAD_SUM,
        DL_HAMMING_TERR_BAD_CODE,
        DL_HAMMING_TERR_TOO_OLD,
        DL_HAMMING_TERR_NOISE, // Warning returned by DecodeFrame()
        DL_HAMMING_TERR_ERROR_MASK,
        ERROR_SOME_REPLAY_FALULT,
        //###############################################################
        NO_DEVICES,
        //###############################################################
        // FTDI
        NO_FTDI_COMM_DEVICES = 0x10000,
        NO_FTDI_COMM_DEVICES_OPENED,
        //	USB_CLOSE_ERROR,
        ERR_FTDI_READ,
        ERR_FTDI_READ_LESS_DATA,
        ERR_FTDI_WRITE,
        ERR_FTDI_WRITE_LESS_DATA,

        DL_FT_ERROR_SET_TIMEOUT,

        // FTSTATUS
        DL_FT_ = 0x10010,
        DL_FT_INVALID_HANDLE,
        DL_FT_DEVICE_NOT_FOUND,
        DL_FT_DEVICE_NOT_OPENED,
        DL_FT_IO_ERROR,
        DL_FT_INSUFFICIENT_RESOURCES,
        DL_FT_INVALID_PARAMETER,
        DL_FT_INVALID_BAUD_RATE,

        DL_FT_DEVICE_NOT_OPENED_FOR_ERASE,
        DL_FT_DEVICE_NOT_OPENED_FOR_WRITE,
        DL_FT_FAILED_TO_WRITE_DEVICE,
        DL_FT_EEPROM_READ_FAILED,
        DL_FT_EEPROM_WRITE_FAILED,
        DL_FT_EEPROM_ERASE_FAILED,
        DL_FT_EEPROM_NOT_PRESENT,
        DL_FT_EEPROM_NOT_PROGRAMMED,
        DL_FT_INVALID_ARGS,
        DL_FT_NOT_SUPPORTED,
        DL_FT_OTHER_ERROR,
        DL_FT_DEVICE_LIST_NOT_READY,

        //---------------------

        READER_ERRORS_ = 0x1100,
        READER_UID_ERROR,
        READER_LOG_ERROR,

        ////---------------------
        //UNKNOWN_ERROR = 0xFFFFFFFD,
        //NOT_IMPLEMENTED = 0xFFFFFFFE,
        ////---------------------
        //MAX_DL_STATUS = 0xFFFFFFFF,
        //LAST_ERROR = 0xFFFFFFFF
    };

    enum E_CARD_ACTION
    {
	// CARD_FOREIGN
	// strange card - card from different system
	// BASE> LOG = 0x83 | RTE = 0x00
	ACTION_CARD_FOREIGN = 0x00,

	// DISCARDED
	// blocked card - card on blacklist, no valid access right, has no right of passage
	// BASE> LOG= 0xC3 | RTE= 0x20
	ACTION_CARD_DISCARDED = 0x20, // (32 dec)

	// CARD_HACKED
	// Mifare key OK - CRC OK - but bad user data
	// Bad protective data
	// BASE> LOG= 0x84 | RTE= 0x40
	ACTION_CARD_HACKED = 0x40, // (64 dec)

	// CARD_BAD_DATA
	// Mifare key OK - CRC BAD
	// Cards with invalid data - BAD CRC
	// BASE> LOG= 0x-- | RTE= 0x82
	ACTION_CARD_BAD_DATA = 0x50, // (80 dec)

	// CARD_NO_DATA
	// unreadable card - card without or unknown Mifare key
	// BASE> LOG= 0x-- | RTE= 0x81
	ACTION_CARD_NO_DATA = 0x60, // (96 dec)

	// UNLOCKED
	// The correct card
	// BASE> LOG= 0xC2 | RTE= 0x80(+++)
	// TWR> 0x80 (128 dec) - A regular passage (P)
	// TWR> 0x90 (144 dec) - Official exit (S)
	// TWR> 0xA0 (160 dec) - Vehicle pass (V)
	// TWR> 0xB0 (176 dec) - Approved exit (O)
	ACTION_CARD_UNLOCKED = 0x80,
	ACTION_CARD_UNLOCKED_1 = 0x81,
	ACTION_CARD_UNLOCKED_2 = 0x82,
	ACTION_CARD_UNLOCKED_3 = 0x83,
	ACTION_CARD_UNLOCKED_4 = 0x84,
	ACTION_CARD_UNLOCKED_5 = 0x85,
	ACTION_CARD_UNLOCKED_6 = 0x86,
	ACTION_CARD_UNLOCKED_7 = 0x87,
    } ;

    public static class ais
	{
        //---------------------------------------------------------------------
		[DllImport("ais_hotel.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "AIS_Hotel_CommunicationOpen")]
        internal static extern DL_STATUS CommunicationOpen();

        [DllImport("ais_hotel.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "AIS_Hotel_CommunicationClose")]
        internal static extern DL_STATUS CommunicationClose();

        //---------------------------------------------------------------------
        [DllImport("ais_hotel.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "AIS_Hotel_GetStatus")]
        internal static extern DL_STATUS GetStatus(int reader_id, IntPtr is_power_on, IntPtr unreaded_rte, IntPtr status_data);

        //---------------------------------------------------------------------
        [DllImport("ais_hotel.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "AIS_Hotel_TimeGet")]
        internal static extern DL_STATUS TimeGet(int reader_id, IntPtr tm_year, IntPtr tm_mon, IntPtr tm_mday, IntPtr tm_hour, IntPtr tm_min, IntPtr tm_sec);

        [DllImport("ais_hotel.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "AIS_Hotel_TimeSet")]
        internal static extern DL_STATUS TimeSet(int reader_id, string password, int tm_year, int tm_mon, int tm_mday, int tm_hour, int tm_min, int tm_sec);

         //---------------------------------------------------------------------
        [DllImport("ais_hotel.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "AIS_Hotel_CardBlock")]
        internal static extern DL_STATUS CardBlock(int reader_id, string password, int card_sn);
        
        [DllImport("ais_hotel.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "AIS_Hotel_CardUnblock")]
        internal static extern DL_STATUS CardUnblock(int reader_id, string password, int card_sn);

        [DllImport("ais_hotel.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "AIS_Hotel_CardUnblockAll")]
        internal static extern DL_STATUS CardUnblockAll(int reader_id, string password);
        
        //---------------------------------------------------------------------
        [DllImport("ais_hotel.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "AIS_Hotel_GetLastRTE")]
        internal static extern DL_STATUS GetLastRTE(int reader_id, IntPtr new_log, IntPtr action, IntPtr card_id, IntPtr system_id, 
                                            IntPtr tm_year, IntPtr tm_mon, IntPtr tm_mday, IntPtr tm_hour, IntPtr tm_min, IntPtr tm_sec);

        //---------------------------------------------------------------------
        [DllImport("ais_hotel.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "AIS_GetDLLVersion")]
        internal static extern IntPtr GetDLLVersion();

        //[DllImport("ais_hotel.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "dbg_status2str")]
        //internal static extern IntPtr dbg_status2str(DL_STATUS status);
        //[DllImport("ais_hotel.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "dbg_action2str")]
        //internal static extern IntPtr dbg_action2str(int card_action);
    }
}
