using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

using kr.co.aim.scomdriver.global;
using kr.co.aim.scomdriver.plugin;
using kr.co.aim.scomdriver.structure;
using kr.co.aim.scomdriver.callback;
using kr.co.aim.scomdriver.timeout;

namespace sampleUI
{
    public partial class Form1 : Form 
    {
        
        bool isInitialized = false;

        private delegate void connectionUpdate(int nStatus);
        private delegate void logUpdate(string log);

        SECSWrapper secsInterface = new SECSWrapper();

        public Form1() 
        {
            InitializeComponent();
            getPrevSettingValue();      
        }

        private void initializeDriver()
        {
            secsInterface.initialize(this);
        }

        private void terminateDriver()
        {
            secsInterface.terminate();
        }

        public void getPrevSettingValue()
        {
            string sTemp;

            sTemp = ConfigureLoader.This().GetItems(ConstantDefine.KEY_PER_COUNT);
            if (!sTemp.Equals(""))
                txtPerSec.Text = sTemp;

            
            sTemp = ConfigureLoader.This().GetItems(ConstantDefine.KEY_MAX_COUNT);
            if (!sTemp.Equals(""))
            {
                txtMsgCount.Text = sTemp;
            }

            sTemp = ConfigureLoader.This().GetItems(ConstantDefine.KEY_STREAM);
            if (!sTemp.Equals(""))
                txtStream.Text = sTemp;

            sTemp = ConfigureLoader.This().GetItems(ConstantDefine.KEY_FUNCTION);
            if (!sTemp.Equals(""))
                txtFunction.Text = sTemp;

            sTemp = ConfigureLoader.This().GetItems(ConstantDefine.KEY_HOT_SEND);
            if (!sTemp.Equals(""))
                txtHotSendMessageName.Text = sTemp;

            
        }


        public void setSettingValue()
        {
            ConfigureLoader.This().SetItems(ConstantDefine.KEY_PER_COUNT, txtPerSec.Text);

            ConfigureLoader.This().SetItems(ConstantDefine.KEY_MAX_COUNT, txtMsgCount.Text);

            ConfigureLoader.This().SetItems(ConstantDefine.KEY_STREAM, txtStream.Text);
            
            ConfigureLoader.This().SetItems(ConstantDefine.KEY_FUNCTION, txtFunction.Text);

            ConfigureLoader.This().SetItems(ConstantDefine.KEY_HOT_SEND, txtHotSendMessageName.Text);

            ConfigureLoader.This().Terminate();
        }

        

        private void btnIsInitialize_Click(object sender, EventArgs e)
        {
            if(isInitialized)
            {
               isInitialized = false;
               btnIsInitialize.Text = "initialize";
               terminateDriver();
            }   
            else
            {
                btnIsInitialize.Text = "terminate";
                isInitialized = true;
                initializeDriver();  

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            setSettingValue();
        }

        public void txtLogUpdate(String txt)
        {
            if (rtbLog.InvokeRequired)
                this.Invoke(new logUpdate(txtLogUpdate), new Object[] { txt });
            else
                rtbLog.Text += "\n" + txt;
        }

        public void txtConnectionUpdate(int nStatus) //0:ready, 1:connected 2:disconnected
        {
            if (btnIsConnected.InvokeRequired)
                this.Invoke(new connectionUpdate(txtConnectionUpdate), new Object[] { nStatus });
            else
            {
                if (nStatus == 0)
                {
                    btnIsConnected.BackColor = Color.Gray;
                    btnIsConnected.Text = "Ready";
                }
                else if (nStatus == 1)
                {
                    btnIsConnected.BackColor = Color.Green;
                    btnIsConnected.Text = "Connected";
                }
                else if (nStatus == 2)
                {
                    btnIsConnected.BackColor = Color.Red;
                    btnIsConnected.Text = "Disconnected";
                }
                else
                {
                    btnIsConnected.BackColor = Color.White;
                    btnIsConnected.Text = "Unknown";
                }
            }
        }

        private void btnHotSend_Click(object sender, EventArgs e)
        {
            secsInterface.hotSend(int.Parse(txtStream.Text), int.Parse(txtFunction.Text), txtHotSendMessageName.Text);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            secsInterface.SendS2F41();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            secsInterface.m_smdFactory.sendRequestMessage(secsInterface.m_smdFactory.makeS2F41());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            secsInterface.m_smdFactory.sendRequestMessage(secsInterface.m_smdFactory.makeS1F10());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            secsInterface.m_smdFactory.sendRequestMessage(secsInterface.m_smdFactory.makeS6F11());
        }


    }
}