using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace cs_ais_hotel_dll
{
    public partial class frmAISHotelDllTester : Form
    {
        static DL_STATUS result;

        int id = 16;
        string password = "";
        int card_sn = 1;

        private void wr_status(string pre_text, DL_STATUS status)
        {
            string out_text = pre_text + ": ";
            out_text += status;
            out_text += Environment.NewLine;

            richTextBox1.AppendText(out_text);
        }

        public frmAISHotelDllTester()
        {
            InitializeComponent();

            editID.Text = Convert.ToString(id);
            eBlackCard.Text = Convert.ToString(card_sn);
        }

        private void btnPortOpen_Click(object sender, EventArgs e)
        {
            result = ais.CommunicationOpen();
            wr_status("CommunicationOpen", result);
        }

        private void btnPortClose_Click(object sender, EventArgs e)
        {
            result = ais.CommunicationClose();
            wr_status("CommunicationClose", result);
        }

        private void btnGetStatus_Click(object sender, EventArgs e)
        {
            int power_on;
            int rte_unreaded;
            byte[] status_data = new byte[5];

            //        Int32 result = 0;
            //IntPtr hContext = new IntPtr(sizeof(Int32));
            //result = Abc1api.Abc_Context_Create(hContext);

            // Allocating memory for int

            IntPtr ptr_power_on = Marshal.AllocHGlobal(sizeof(int));

            IntPtr ptr_rte_unreaded = Marshal.AllocHGlobal(sizeof(int));

            GCHandle pinnedArray = GCHandle.Alloc(status_data, GCHandleType.Pinned);
            IntPtr ptr_status_data = pinnedArray.AddrOfPinnedObject();

            result = ais.GetStatus(id, ptr_power_on, ptr_rte_unreaded, ptr_status_data);

            wr_status("GetStatus()", result);

            if (result == DL_STATUS.DL_OK)
            {
                power_on = Marshal.ReadInt32(ptr_power_on);
                rte_unreaded = Marshal.ReadInt32(ptr_rte_unreaded);

                string prnout = "power_on= " + power_on + " | rte_unreaded= " + rte_unreaded;
                prnout += " |||| " + BitConverter.ToString(status_data);
                prnout += Environment.NewLine + Environment.NewLine;
                richTextBox1.AppendText(prnout);
            }

            // Free memory
            pinnedArray.Free();
            Marshal.FreeHGlobal(ptr_power_on);
            Marshal.FreeHGlobal(ptr_rte_unreaded);
        }

        private void btnGetTime_Click(object sender, EventArgs e)
        {
            int tm_year;
            int tm_mon;
            int tm_mday;
            int tm_hour;
            int tm_min;
            int tm_sec;

            IntPtr p_tm_year = Marshal.AllocHGlobal(sizeof(int));
            IntPtr p_tm_mon = Marshal.AllocHGlobal(sizeof(int));
            IntPtr p_tm_mday = Marshal.AllocHGlobal(sizeof(int));
            IntPtr p_tm_hour = Marshal.AllocHGlobal(sizeof(int));
            IntPtr p_tm_min = Marshal.AllocHGlobal(sizeof(int));
            IntPtr p_tm_sec = Marshal.AllocHGlobal(sizeof(int));

            result = ais.TimeGet(id, p_tm_year, p_tm_mon, p_tm_mday, p_tm_hour, p_tm_min, p_tm_sec);

            wr_status("TimeGet()", result);

            if (result == DL_STATUS.DL_OK)
            {
                tm_year = Marshal.ReadInt32(p_tm_year);
                tm_mon = Marshal.ReadInt32(p_tm_mon);
                tm_mday = Marshal.ReadInt32(p_tm_mday);
                tm_hour = Marshal.ReadInt32(p_tm_hour);
                tm_min = Marshal.ReadInt32(p_tm_min);
                tm_sec = Marshal.ReadInt32(p_tm_sec);

                string prnout = String.Format("TIME: {0}-{1}-{2} {3}:{4}:{5}", tm_year, tm_mon, tm_mday, tm_hour, tm_min, tm_sec);

                prnout += Environment.NewLine + Environment.NewLine;
                richTextBox1.AppendText(prnout);
            }

            // Free memory
            Marshal.FreeHGlobal(p_tm_year);
            Marshal.FreeHGlobal(p_tm_mon);
            Marshal.FreeHGlobal(p_tm_mday);
            Marshal.FreeHGlobal(p_tm_hour);
            Marshal.FreeHGlobal(p_tm_min);
            Marshal.FreeHGlobal(p_tm_sec);
        }

        private void btnSetTime_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            richTextBox1.AppendText("TRY TO SET TIME: " + now.ToString() + Environment.NewLine);

            result = ais.TimeSet(id, password, now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);

            wr_status("TimeSet()", result);
        }

        private void btnBlockCard_Click(object sender, EventArgs e)
        {
            result = ais.CardBlock(id, password, card_sn);
            wr_status("CardBlock", result);
        }

        private void btnUnblockCard_Click(object sender, EventArgs e)
        {
            result = ais.CardBlock(id, password, card_sn);
            wr_status("CardBlock", result);
        }

        private void btnUnblockAll_Click(object sender, EventArgs e)
        {
            result = ais.CardUnblockAll(id, password);
            wr_status("CardUnblockAll", result);
        }

        private void btnGetDLLVersion_Click(object sender, EventArgs e)
        {
            // string s = "ais.GetDLLVersion()" + Environment.NewLine;

            IntPtr str_ret = ais.GetDLLVersion();
            string s = Marshal.PtrToStringAnsi(str_ret);
            s += Environment.NewLine;

            richTextBox1.AppendText(s);
        }

        private void eBlackCard_Leave(object sender, EventArgs e)
        {
            card_sn = Convert.ToInt32(eBlackCard.Text);

            statusLabel.Text = "card_sn= " + card_sn;
        }

        private void editID_Leave(object sender, EventArgs e)
        {
            id = Convert.ToInt32(editID.Text);

            statusLabel.Text = "id= " + id;
        }

        private void btnGetLastRTE_Click(object sender, EventArgs e)
        {
            int tm_year;
            int tm_mon;
            int tm_mday;
            int tm_hour;
            int tm_min;
            int tm_sec;

            int new_log;
            int action;
            int card_id;
            int system_id;

            IntPtr p_tm_year = Marshal.AllocHGlobal(sizeof(int));
            IntPtr p_tm_mon = Marshal.AllocHGlobal(sizeof(int));
            IntPtr p_tm_mday = Marshal.AllocHGlobal(sizeof(int));
            IntPtr p_tm_hour = Marshal.AllocHGlobal(sizeof(int));
            IntPtr p_tm_min = Marshal.AllocHGlobal(sizeof(int));
            IntPtr p_tm_sec = Marshal.AllocHGlobal(sizeof(int));

            IntPtr p_new_log = Marshal.AllocHGlobal(sizeof(int));
            IntPtr p_action = Marshal.AllocHGlobal(sizeof(int));
            IntPtr p_card_id = Marshal.AllocHGlobal(sizeof(int));
            IntPtr p_system_id = Marshal.AllocHGlobal(sizeof(int));

            result = ais.GetLastRTE(id, p_new_log, p_action, p_card_id, p_system_id,
                p_tm_year, p_tm_mon, p_tm_mday, p_tm_hour, p_tm_min, p_tm_sec);

            wr_status("GetLastRTE()", result);

            if (result == DL_STATUS.DL_OK)
            {
                tm_year = Marshal.ReadInt32(p_tm_year);
                tm_mon = Marshal.ReadInt32(p_tm_mon);
                tm_mday = Marshal.ReadInt32(p_tm_mday);
                tm_hour = Marshal.ReadInt32(p_tm_hour);
                tm_min = Marshal.ReadInt32(p_tm_min);
                tm_sec = Marshal.ReadInt32(p_tm_sec);


                new_log = Marshal.ReadInt32(p_new_log);
                action = Marshal.ReadInt32(p_action);
                card_id = Marshal.ReadInt32(p_card_id);
                system_id = Marshal.ReadInt32(p_system_id);
                
                string prnout = "RTE: ";
       
                if (new_log == 0)
                {
                    prnout += "NO NEW RTE.";
                }
                else
                {
                    prnout += String.Format("action= {0} | card_id= {1} | system_id= {2} || ", action, card_id, system_id);
                    prnout += String.Format("TIME: {0}-{1}-{2} {3}:{4}:{5}", tm_year, tm_mon, tm_mday, tm_hour, tm_min, tm_sec);
                }

                prnout += Environment.NewLine + Environment.NewLine;
                richTextBox1.AppendText(prnout);
            }

            // Free memory
            Marshal.FreeHGlobal(p_tm_year);
            Marshal.FreeHGlobal(p_tm_mon);
            Marshal.FreeHGlobal(p_tm_mday);
            Marshal.FreeHGlobal(p_tm_hour);
            Marshal.FreeHGlobal(p_tm_min);
            Marshal.FreeHGlobal(p_tm_sec);

            Marshal.FreeHGlobal(p_new_log);
            Marshal.FreeHGlobal(p_action);
            Marshal.FreeHGlobal(p_card_id);
            Marshal.FreeHGlobal(p_system_id);
        }


        //     result = ftd2.rf_Clear();
        //if (result != BCDRF_STATUS.DL_OK)
        //{
        //    Console.WriteLine("Unable to clear bcd_rf dll memory.");
        //    Console.ReadKey();
        //    return;
        //}
    }
}
