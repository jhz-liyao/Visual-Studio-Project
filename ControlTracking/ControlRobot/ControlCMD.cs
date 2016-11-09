﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace ControlRobot
{
    class ControlCMD
    {
        /*public byte[] leftCMD = { 0xfd, 0x01, 0x00, 0x00, 0x15, 0x02, 0x00, 0x15, 0x01, 0x01, 0x00, 0xf8 };
        public byte[]  rightCMD= { 0xfd, 0x01, 0x02, 0x00, 0x15, 0x00, 0x00, 0x15, 0x01, 0x01, 0x00, 0xf8 };
        public byte[] upCMD = { 0xfd, 0x01, 0x02, 0x00, 0x15, 0x02, 0x00, 0x15, 0x01, 0x01, 0x00, 0xf8 };
        public byte[] downCMD = { 0xfd, 0x01, 0x00, 0x00, 0x15, 0x00, 0x00, 0x15, 0x01, 0x01, 0x00, 0xf8 };
        public byte[] stopCMD = { 0xfd, 0x01, 0x03, 0x00, 0x15, 0x03, 0x00, 0x15, 0x01, 0x01, 0x00, 0xf8 };*/


        public byte[] leftCMD = { 0xfd, 0x01, 0x02, 0x00, 0x32, 0x01, 0x00, 0x32, 0xff, 0x00, 0xf8 };
        public byte[] rightCMD = { 0xfd, 0x01, 0x01, 0x00, 0x32, 0x02, 0x00, 0x32, 0xff, 0x00, 0xf8 };
        public byte[] upCMD = { 0xfd, 0x01, 0x01, 0x00, 0x32, 0x01, 0x00, 0x32, 0xff, 0x00, 0xf8 };
        public byte[] downCMD = { 0xfd, 0x01, 0x02, 0x00, 0x32, 0x02, 0x00, 0x32, 0xff, 0x00, 0xf8 };
        public byte[] stopCMD = { 0xfd, 0x01, 0x03, 0x00, 0x32, 0x03, 0x00, 0x32, 0xff, 0x00, 0xf8 };


        public byte[] curCMD = { 0 };

        public void run(byte[] CMD){
            curCMD = CMD;

        }
    }
}