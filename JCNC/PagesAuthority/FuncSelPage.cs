using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JCNCShareMemory;

namespace PagesAuthority
{
    public partial class FuncSelPage : Form
    {
        static JCNCShareMemory.ShareMemory.MFC_Flag MFC_Flag;
        static JCNCShareMemory.ShareMemory.Level Level;
        bool FileSaveFinish; 

        public FuncSelPage()
        {
            ShareMemory.PageInitFinshed = false;
            FileSaveFinish = true;
            InitializeComponent();
        }

        public static void SetMFCFlag(JCNCShareMemory.ShareMemory.MFC_Flag m_MFC_Flag)
        {
            FuncSelPage.MFC_Flag = m_MFC_Flag;
        }

        public static void SetAuthorityLevel(JCNCShareMemory.ShareMemory.Level m_Level)
        {
            Level = m_Level;
        }

        private void FuncAct1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!FileSaveFinish)
            {
                return;
            }
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if(MONLev1.Default.Func01){
                                MONLev1.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else{
                                MONLev1.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            MONLev1.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev2:
                             if(MONLev2.Default.Func01){
                                MONLev2.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                             }
                            else{
                                MONLev2.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            MONLev2.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev3:
                             if(MONLev3.Default.Func01){
                                MONLev3.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else{
                                MONLev3.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;                          
                            }
                            FileSaveFinish = false;
                            MONLev3.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev4:
                                 if(MONLev4.Default.Func01){
                                MONLev4.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else{
                                MONLev4.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;                          
                            }
                            FileSaveFinish = false;
                            MONLev4.Default.Save();
                            FileSaveFinish = true;
                        break;
                        case ShareMemory.Level.Lev5:
                             if(MONLev5.Default.Func01){
                                MONLev5.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else{
                                MONLev5.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;                          
                            }
                            FileSaveFinish = false;
                            MONLev5.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev6:
                             if(MONLev6.Default.Func01){
                                MONLev6.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else{
                                MONLev6.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;                          
                            }
                            FileSaveFinish = false;
                            MONLev6.Default.Save();
                            FileSaveFinish = true;
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if(PROGLev1.Default.Func01){
                                PROGLev1.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else{
                                PROGLev1.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;                          
                            }
                            FileSaveFinish = false;
                            PROGLev1.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev2:
                             if(PROGLev2.Default.Func01){
                                PROGLev2.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else{
                                PROGLev2.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;                          
                            }
                            FileSaveFinish = false;
                            PROGLev2.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev3:
                             if(PROGLev3.Default.Func01){
                                PROGLev3.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else{
                                PROGLev3.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;                          
                            }
                            FileSaveFinish = false;
                            PROGLev3.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev4:
                                 if(PROGLev4.Default.Func01){
                                PROGLev4.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else{
                                PROGLev4.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;                          
                            }
                            FileSaveFinish = false;
                            PROGLev4.Default.Save();
                            FileSaveFinish = true;
                        break;
                        case ShareMemory.Level.Lev5:
                             if(PROGLev5.Default.Func01){
                                PROGLev5.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else{
                                PROGLev5.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;                          
                            }
                            FileSaveFinish = false;
                             PROGLev5.Default.Save();
                            FileSaveFinish = true;
                           break;
                        case ShareMemory.Level.Lev6:
                             if(PROGLev6.Default.Func01){
                                PROGLev6.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else{
                                PROGLev6.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;                          
                            }
                            FileSaveFinish = false;
                             PROGLev6.Default.Save();
                            FileSaveFinish = true;
                           break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func01)
                            {
                                OFFLev1.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            OFFLev1.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func01)
                            {
                                OFFLev2.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            OFFLev2.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func01)
                            {
                                OFFLev3.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            OFFLev3.Default.Save();
                            FileSaveFinish = true;
                           break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func01)
                            {
                                OFFLev4.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            OFFLev4.Default.Save();
                            FileSaveFinish = true;
                          break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func01)
                            {
                                OFFLev5.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            OFFLev5.Default.Save();
                            FileSaveFinish = true;
                           break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func01)
                            {
                                OFFLev6.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            OFFLev6.Default.Save();
                            FileSaveFinish = true;
                          break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func01)
                            {
                                DIALev1.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            DIALev1.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func01)
                            {
                                DIALev2.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            DIALev2.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func01)
                            {
                                DIALev3.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            DIALev3.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func01)
                            {
                                DIALev4.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            DIALev4.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func01)
                            {
                                DIALev5.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            DIALev5.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func01)
                            {
                                DIALev6.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            DIALev6.Default.Save();
                            FileSaveFinish = true;
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func01)
                            {
                                MAINLev1.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            MAINLev1.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func01)
                            {
                                MAINLev2.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            MAINLev2.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func01)
                            {
                                MAINLev3.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            MAINLev3.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func01)
                            {
                                MAINLev4.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                             MAINLev4.Default.Save();
                            FileSaveFinish = true;
                           break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func01)
                            {
                                MAINLev5.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            MAINLev5.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func01)
                            {
                                MAINLev6.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            MAINLev6.Default.Save();
                            FileSaveFinish = true;
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func01)
                            {
                                PARAMLev1.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            PARAMLev1.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func01)
                            {
                                PARAMLev2.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            PARAMLev2.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func01)
                            {
                                PARAMLev3.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            PARAMLev3.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func01)
                            {
                                PARAMLev4.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            PARAMLev4.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func01)
                            {
                                PARAMLev5.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            PARAMLev5.Default.Save();
                            FileSaveFinish = true;
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func01)
                            {
                                PARAMLev6.Default.Func01 = false;
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func01 = true;
                                FuncAct1.BackColor = Color.Blue;
                            }
                            FileSaveFinish = false;
                            PARAMLev6.Default.Save();
                            FileSaveFinish = true;
                            break;
                    }
                    break;
            }
        }

        private void FuncAct2_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func02)
                            {
                                MONLev1.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            MONLev1.Default.Save();
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func02)
                            {
                                MONLev2.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            MONLev2.Default.Save();
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func02)
                            {
                                MONLev3.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            MONLev3.Default.Save();
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func02)
                            {
                                MONLev4.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            MONLev4.Default.Save();
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func02)
                            {
                                MONLev5.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            MONLev5.Default.Save();
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func02)
                            {
                                MONLev6.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            MONLev6.Default.Save();
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func02)
                            {
                                PROGLev1.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func02)
                            {
                                PROGLev2.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func02)
                            {
                                PROGLev3.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func02)
                            {
                                PROGLev4.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func02)
                            {
                                PROGLev5.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func02)
                            {
                                PROGLev6.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func02)
                            {
                                OFFLev1.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func02)
                            {
                                OFFLev2.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func02)
                            {
                                OFFLev3.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func02)
                            {
                                OFFLev4.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func02)
                            {
                                OFFLev5.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func02)
                            {
                                OFFLev6.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func02)
                            {
                                DIALev1.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func02)
                            {
                                DIALev2.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func02)
                            {
                                DIALev3.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func02)
                            {
                                DIALev4.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func02)
                            {
                                DIALev5.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func02)
                            {
                                DIALev6.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func02)
                            {
                                MAINLev1.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func02)
                            {
                                MAINLev2.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func02)
                            {
                                MAINLev3.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func02)
                            {
                                MAINLev4.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func02)
                            {
                                MAINLev5.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func02)
                            {
                                MAINLev6.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func02)
                            {
                                PARAMLev1.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func02)
                            {
                                PARAMLev2.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func02)
                            {
                                PARAMLev3.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func02)
                            {
                                PARAMLev4.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func02)
                            {
                                PARAMLev5.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func02)
                            {
                                PARAMLev6.Default.Func02 = false;
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func02 = true;
                                FuncAct2.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct3_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func03)
                            {
                                MONLev1.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func03)
                            {
                                MONLev2.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func03)
                            {
                                MONLev3.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func03)
                            {
                                MONLev4.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func03)
                            {
                                MONLev5.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func03)
                            {
                                MONLev6.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func03)
                            {
                                PROGLev1.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func03)
                            {
                                PROGLev2.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func03)
                            {
                                PROGLev3.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func03)
                            {
                                PROGLev4.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func03)
                            {
                                PROGLev5.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func03)
                            {
                                PROGLev6.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func03)
                            {
                                OFFLev1.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func03)
                            {
                                OFFLev2.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func03)
                            {
                                OFFLev3.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func03)
                            {
                                OFFLev4.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func03)
                            {
                                OFFLev5.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func03)
                            {
                                OFFLev6.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func03)
                            {
                                DIALev1.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func03)
                            {
                                DIALev2.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func03)
                            {
                                DIALev3.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func03)
                            {
                                DIALev4.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func03)
                            {
                                DIALev5.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func03)
                            {
                                DIALev6.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func03)
                            {
                                MAINLev1.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func03)
                            {
                                MAINLev2.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func03)
                            {
                                MAINLev3.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func03)
                            {
                                MAINLev4.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func03)
                            {
                                MAINLev5.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func03)
                            {
                                MAINLev6.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func03)
                            {
                                PARAMLev1.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func03)
                            {
                                PARAMLev2.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func03)
                            {
                                PARAMLev3.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func03)
                            {
                                PARAMLev4.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func03)
                            {
                                PARAMLev5.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func03)
                            {
                                PARAMLev6.Default.Func03 = false;
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func03 = true;
                                FuncAct3.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct4_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func04)
                            {
                                MONLev1.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func04)
                            {
                                MONLev2.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func04)
                            {
                                MONLev3.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func04)
                            {
                                MONLev4.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func04)
                            {
                                MONLev5.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func04)
                            {
                                MONLev6.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func04)
                            {
                                PROGLev1.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func04)
                            {
                                PROGLev2.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func04)
                            {
                                PROGLev3.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func04)
                            {
                                PROGLev4.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func04)
                            {
                                PROGLev5.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func04)
                            {
                                PROGLev6.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func04)
                            {
                                OFFLev1.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func04)
                            {
                                OFFLev2.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func04)
                            {
                                OFFLev3.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func04)
                            {
                                OFFLev4.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func04)
                            {
                                OFFLev5.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func04)
                            {
                                OFFLev6.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func04)
                            {
                                DIALev1.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func04)
                            {
                                DIALev2.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func04)
                            {
                                DIALev3.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func04)
                            {
                                DIALev4.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func04)
                            {
                                DIALev5.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func04)
                            {
                                DIALev6.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func04)
                            {
                                MAINLev1.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func04)
                            {
                                MAINLev2.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func04)
                            {
                                MAINLev3.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func04)
                            {
                                MAINLev4.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func04)
                            {
                                MAINLev5.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func04)
                            {
                                MAINLev6.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func04)
                            {
                                PARAMLev1.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func04)
                            {
                                PARAMLev2.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func04)
                            {
                                PARAMLev3.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func04)
                            {
                                PARAMLev4.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func04)
                            {
                                PARAMLev5.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func04)
                            {
                                PARAMLev6.Default.Func04 = false;
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func04 = true;
                                FuncAct4.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct5_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func05)
                            {
                                MONLev1.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func05)
                            {
                                MONLev2.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func05)
                            {
                                MONLev3.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func05)
                            {
                                MONLev4.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func05)
                            {
                                MONLev5.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func05)
                            {
                                MONLev6.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func05)
                            {
                                PROGLev1.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func05)
                            {
                                PROGLev2.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func05)
                            {
                                PROGLev3.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func05)
                            {
                                PROGLev4.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func05)
                            {
                                PROGLev5.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func05)
                            {
                                PROGLev6.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func05)
                            {
                                OFFLev1.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func05)
                            {
                                OFFLev2.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func05)
                            {
                                OFFLev3.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func05)
                            {
                                OFFLev4.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func05)
                            {
                                OFFLev5.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func05)
                            {
                                OFFLev6.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func05)
                            {
                                DIALev1.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func05)
                            {
                                DIALev2.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func05)
                            {
                                DIALev3.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func05)
                            {
                                DIALev4.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func05)
                            {
                                DIALev5.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func05)
                            {
                                DIALev6.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func05)
                            {
                                MAINLev1.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func05)
                            {
                                MAINLev2.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func05)
                            {
                                MAINLev3.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func05)
                            {
                                MAINLev4.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func05)
                            {
                                MAINLev5.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func05)
                            {
                                MAINLev6.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func05)
                            {
                                PARAMLev1.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func05)
                            {
                                PARAMLev2.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func05)
                            {
                                PARAMLev3.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func05)
                            {
                                PARAMLev4.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func05)
                            {
                                PARAMLev5.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func05)
                            {
                                PARAMLev6.Default.Func05 = false;
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func05 = true;
                                FuncAct5.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct6_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func06)
                            {
                                MONLev1.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func06)
                            {
                                MONLev2.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func06)
                            {
                                MONLev3.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func06)
                            {
                                MONLev4.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func06)
                            {
                                MONLev5.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func06)
                            {
                                MONLev6.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func06)
                            {
                                PROGLev1.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func06)
                            {
                                PROGLev2.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func06)
                            {
                                PROGLev3.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func06)
                            {
                                PROGLev4.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func06)
                            {
                                PROGLev5.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func06)
                            {
                                PROGLev6.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func06)
                            {
                                OFFLev1.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func06)
                            {
                                OFFLev2.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func06)
                            {
                                OFFLev3.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func06)
                            {
                                OFFLev4.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func06)
                            {
                                OFFLev5.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func06)
                            {
                                OFFLev6.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func06)
                            {
                                DIALev1.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func06)
                            {
                                DIALev2.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func06)
                            {
                                DIALev3.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func06)
                            {
                                DIALev4.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func06)
                            {
                                DIALev5.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func06)
                            {
                                DIALev6.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func06)
                            {
                                MAINLev1.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func06)
                            {
                                MAINLev2.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func06)
                            {
                                MAINLev3.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func06)
                            {
                                MAINLev4.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func06)
                            {
                                MAINLev5.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func06)
                            {
                                MAINLev6.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func06)
                            {
                                PARAMLev1.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func06)
                            {
                                PARAMLev2.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func06)
                            {
                                PARAMLev3.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func06)
                            {
                                PARAMLev4.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func06)
                            {
                                PARAMLev5.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func06)
                            {
                                PARAMLev6.Default.Func06 = false;
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func06 = true;
                                FuncAct6.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct7_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func07)
                            {
                                MONLev1.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func07)
                            {
                                MONLev2.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func07)
                            {
                                MONLev3.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func07)
                            {
                                MONLev4.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func07)
                            {
                                MONLev5.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func07)
                            {
                                MONLev6.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func07)
                            {
                                PROGLev1.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func07)
                            {
                                PROGLev2.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func07)
                            {
                                PROGLev3.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func07)
                            {
                                PROGLev4.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func07)
                            {
                                PROGLev5.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func07)
                            {
                                PROGLev6.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func07)
                            {
                                OFFLev1.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func07)
                            {
                                OFFLev2.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func07)
                            {
                                OFFLev3.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func07)
                            {
                                OFFLev4.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func07)
                            {
                                OFFLev5.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func07)
                            {
                                OFFLev6.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func07)
                            {
                                DIALev1.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func07)
                            {
                                DIALev2.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func07)
                            {
                                DIALev3.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func07)
                            {
                                DIALev4.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func07)
                            {
                                DIALev5.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func07)
                            {
                                DIALev6.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func07)
                            {
                                MAINLev1.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func07)
                            {
                                MAINLev2.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func07)
                            {
                                MAINLev3.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func07)
                            {
                                MAINLev4.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func07)
                            {
                                MAINLev5.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func07)
                            {
                                MAINLev6.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func07)
                            {
                                PARAMLev1.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func07)
                            {
                                PARAMLev2.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func07)
                            {
                                PARAMLev3.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func07)
                            {
                                PARAMLev4.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func07)
                            {
                                PARAMLev5.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func07)
                            {
                                PARAMLev6.Default.Func07 = false;
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func07 = true;
                                FuncAct7.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct8_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func08)
                            {
                                MONLev1.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func08)
                            {
                                MONLev2.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func08)
                            {
                                MONLev3.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func08)
                            {
                                MONLev4.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func08)
                            {
                                MONLev5.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func08)
                            {
                                MONLev6.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func08)
                            {
                                PROGLev1.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func08)
                            {
                                PROGLev2.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func08)
                            {
                                PROGLev3.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func08)
                            {
                                PROGLev4.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func08)
                            {
                                PROGLev5.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func08)
                            {
                                PROGLev6.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func08)
                            {
                                OFFLev1.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func08)
                            {
                                OFFLev2.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func08)
                            {
                                OFFLev3.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func08)
                            {
                                OFFLev4.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func08)
                            {
                                OFFLev5.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func08)
                            {
                                OFFLev6.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func08)
                            {
                                DIALev1.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func08)
                            {
                                DIALev2.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func08)
                            {
                                DIALev3.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func08)
                            {
                                DIALev4.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func08)
                            {
                                DIALev5.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func08)
                            {
                                DIALev6.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func08)
                            {
                                MAINLev1.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func08)
                            {
                                MAINLev2.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func08)
                            {
                                MAINLev3.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func08)
                            {
                                MAINLev4.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func08)
                            {
                                MAINLev5.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func08)
                            {
                                MAINLev6.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func08)
                            {
                                PARAMLev1.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func08)
                            {
                                PARAMLev2.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func08)
                            {
                                PARAMLev3.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func08)
                            {
                                PARAMLev4.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func08)
                            {
                                PARAMLev5.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func08)
                            {
                                PARAMLev6.Default.Func08 = false;
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func08 = true;
                                FuncAct8.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct9_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func09)
                            {
                                MONLev1.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func09)
                            {
                                MONLev2.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func09)
                            {
                                MONLev3.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func09)
                            {
                                MONLev4.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func09)
                            {
                                MONLev5.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func09)
                            {
                                MONLev6.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func09)
                            {
                                PROGLev1.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func09)
                            {
                                PROGLev2.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func09)
                            {
                                PROGLev3.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func09)
                            {
                                PROGLev4.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func09)
                            {
                                PROGLev5.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func09)
                            {
                                PROGLev6.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func09)
                            {
                                OFFLev1.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func09)
                            {
                                OFFLev2.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func09)
                            {
                                OFFLev3.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func09)
                            {
                                OFFLev4.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func09)
                            {
                                OFFLev5.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func09)
                            {
                                OFFLev6.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func09)
                            {
                                DIALev1.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func09)
                            {
                                DIALev2.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func09)
                            {
                                DIALev3.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func09)
                            {
                                DIALev4.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func09)
                            {
                                DIALev5.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func09)
                            {
                                DIALev6.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func09)
                            {
                                MAINLev1.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func09)
                            {
                                MAINLev2.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func09)
                            {
                                MAINLev3.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func09)
                            {
                                MAINLev4.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func09)
                            {
                                MAINLev5.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func09)
                            {
                                MAINLev6.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func09)
                            {
                                PARAMLev1.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func09)
                            {
                                PARAMLev2.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func09)
                            {
                                PARAMLev3.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func09)
                            {
                                PARAMLev4.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func09)
                            {
                                PARAMLev5.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func09)
                            {
                                PARAMLev6.Default.Func09 = false;
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func09 = true;
                                FuncAct9.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct10_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func10)
                            {
                                MONLev1.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func10)
                            {
                                MONLev2.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func10)
                            {
                                MONLev3.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func10)
                            {
                                MONLev4.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func10)
                            {
                                MONLev5.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func10)
                            {
                                MONLev6.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func10)
                            {
                                PROGLev1.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func10)
                            {
                                PROGLev2.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func10)
                            {
                                PROGLev3.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func10)
                            {
                                PROGLev4.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func10)
                            {
                                PROGLev5.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func10)
                            {
                                PROGLev6.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func10)
                            {
                                OFFLev1.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func10)
                            {
                                OFFLev2.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func10)
                            {
                                OFFLev3.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func10)
                            {
                                OFFLev4.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func10)
                            {
                                OFFLev5.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func10)
                            {
                                OFFLev6.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func10)
                            {
                                DIALev1.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func10)
                            {
                                DIALev2.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func10)
                            {
                                DIALev3.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func10)
                            {
                                DIALev4.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func10)
                            {
                                DIALev5.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func10)
                            {
                                DIALev6.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func10)
                            {
                                MAINLev1.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func10)
                            {
                                MAINLev2.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func10)
                            {
                                MAINLev3.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func10)
                            {
                                MAINLev4.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func10)
                            {
                                MAINLev5.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func10)
                            {
                                MAINLev6.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func10)
                            {
                                PARAMLev1.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func10)
                            {
                                PARAMLev2.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func10)
                            {
                                PARAMLev3.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func10)
                            {
                                PARAMLev4.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func10)
                            {
                                PARAMLev5.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func10)
                            {
                                PARAMLev6.Default.Func10 = false;
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func10 = true;
                                FuncAct10.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct11_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func11)
                            {
                                MONLev1.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func11)
                            {
                                MONLev2.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func11)
                            {
                                MONLev3.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func11)
                            {
                                MONLev4.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func11)
                            {
                                MONLev5.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func11)
                            {
                                MONLev6.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func11)
                            {
                                PROGLev1.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func11)
                            {
                                PROGLev2.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func11)
                            {
                                PROGLev3.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func11)
                            {
                                PROGLev4.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func11)
                            {
                                PROGLev5.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func11)
                            {
                                PROGLev6.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func11)
                            {
                                OFFLev1.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func11)
                            {
                                OFFLev2.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func11)
                            {
                                OFFLev3.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func11)
                            {
                                OFFLev4.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func11)
                            {
                                OFFLev5.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func11)
                            {
                                OFFLev6.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func11)
                            {
                                DIALev1.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func11)
                            {
                                DIALev2.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func11)
                            {
                                DIALev3.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func11)
                            {
                                DIALev4.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func11)
                            {
                                DIALev5.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func11)
                            {
                                DIALev6.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func11)
                            {
                                MAINLev1.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func11)
                            {
                                MAINLev2.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func11)
                            {
                                MAINLev3.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func11)
                            {
                                MAINLev4.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func11)
                            {
                                MAINLev5.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func11)
                            {
                                MAINLev6.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func11)
                            {
                                PARAMLev1.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func11)
                            {
                                PARAMLev2.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func11)
                            {
                                PARAMLev3.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func11)
                            {
                                PARAMLev4.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func11)
                            {
                                PARAMLev5.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func11)
                            {
                                PARAMLev6.Default.Func11 = false;
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func11 = true;
                                FuncAct11.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct12_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func12)
                            {
                                MONLev1.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func12)
                            {
                                MONLev2.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func12)
                            {
                                MONLev3.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func12)
                            {
                                MONLev4.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func12)
                            {
                                MONLev5.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func12)
                            {
                                MONLev6.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func12)
                            {
                                PROGLev1.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func12)
                            {
                                PROGLev2.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func12)
                            {
                                PROGLev3.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func12)
                            {
                                PROGLev4.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func12)
                            {
                                PROGLev5.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func12)
                            {
                                PROGLev6.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func12)
                            {
                                OFFLev1.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func12)
                            {
                                OFFLev2.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func12)
                            {
                                OFFLev3.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func12)
                            {
                                OFFLev4.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func12)
                            {
                                OFFLev5.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func12)
                            {
                                OFFLev6.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func12)
                            {
                                DIALev1.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func12)
                            {
                                DIALev2.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func12)
                            {
                                DIALev3.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func12)
                            {
                                DIALev4.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func12)
                            {
                                DIALev5.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func12)
                            {
                                DIALev6.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func12)
                            {
                                MAINLev1.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func12)
                            {
                                MAINLev2.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func12)
                            {
                                MAINLev3.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func12)
                            {
                                MAINLev4.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func12)
                            {
                                MAINLev5.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func12)
                            {
                                MAINLev6.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func12)
                            {
                                PARAMLev1.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func12)
                            {
                                PARAMLev2.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func12)
                            {
                                PARAMLev3.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func12)
                            {
                                PARAMLev4.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func12)
                            {
                                PARAMLev5.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func12)
                            {
                                PARAMLev6.Default.Func12 = false;
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func12 = true;
                                FuncAct12.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct13_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func13)
                            {
                                MONLev1.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func13)
                            {
                                MONLev2.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func13)
                            {
                                MONLev3.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func13)
                            {
                                MONLev4.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func13)
                            {
                                MONLev5.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func13)
                            {
                                MONLev6.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func13)
                            {
                                PROGLev1.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func13)
                            {
                                PROGLev2.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func13)
                            {
                                PROGLev3.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func13)
                            {
                                PROGLev4.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func13)
                            {
                                PROGLev5.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func13)
                            {
                                PROGLev6.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func13)
                            {
                                OFFLev1.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func13)
                            {
                                OFFLev2.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func13)
                            {
                                OFFLev3.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func13)
                            {
                                OFFLev4.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func13)
                            {
                                OFFLev5.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func13)
                            {
                                OFFLev6.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func13)
                            {
                                DIALev1.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func13)
                            {
                                DIALev2.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func13)
                            {
                                DIALev3.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func13)
                            {
                                DIALev4.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func13)
                            {
                                DIALev5.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func13)
                            {
                                DIALev6.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func13)
                            {
                                MAINLev1.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func13)
                            {
                                MAINLev2.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func13)
                            {
                                MAINLev3.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func13)
                            {
                                MAINLev4.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func13)
                            {
                                MAINLev5.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func13)
                            {
                                MAINLev6.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func13)
                            {
                                PARAMLev1.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func13)
                            {
                                PARAMLev2.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func13)
                            {
                                PARAMLev3.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func13)
                            {
                                PARAMLev4.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func13)
                            {
                                PARAMLev5.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func13)
                            {
                                PARAMLev6.Default.Func13 = false;
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func13 = true;
                                FuncAct13.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct14_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func14)
                            {
                                MONLev1.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func14)
                            {
                                MONLev2.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func14)
                            {
                                MONLev3.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func14)
                            {
                                MONLev4.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func14)
                            {
                                MONLev5.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func14)
                            {
                                MONLev6.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func14)
                            {
                                PROGLev1.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func14)
                            {
                                PROGLev2.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func14)
                            {
                                PROGLev3.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func14)
                            {
                                PROGLev4.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func14)
                            {
                                PROGLev5.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func14)
                            {
                                PROGLev6.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func14)
                            {
                                OFFLev1.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func14)
                            {
                                OFFLev2.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func14)
                            {
                                OFFLev3.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func14)
                            {
                                OFFLev4.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func14)
                            {
                                OFFLev5.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func14)
                            {
                                OFFLev6.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func14)
                            {
                                DIALev1.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func14)
                            {
                                DIALev2.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func14)
                            {
                                DIALev3.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func14)
                            {
                                DIALev4.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func14)
                            {
                                DIALev5.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func14)
                            {
                                DIALev6.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func14)
                            {
                                MAINLev1.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func14)
                            {
                                MAINLev2.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func14)
                            {
                                MAINLev3.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func14)
                            {
                                MAINLev4.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func14)
                            {
                                MAINLev5.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func14)
                            {
                                MAINLev6.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func14)
                            {
                                PARAMLev1.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func14)
                            {
                                PARAMLev2.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func14)
                            {
                                PARAMLev3.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func14)
                            {
                                PARAMLev4.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func14)
                            {
                                PARAMLev5.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func14)
                            {
                                PARAMLev6.Default.Func14 = false;
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func14 = true;
                                FuncAct14.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct15_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func15)
                            {
                                MONLev1.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func15)
                            {
                                MONLev2.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func15)
                            {
                                MONLev3.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func15)
                            {
                                MONLev4.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func15)
                            {
                                MONLev5.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func15)
                            {
                                MONLev6.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func15)
                            {
                                PROGLev1.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func15)
                            {
                                PROGLev2.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func15)
                            {
                                PROGLev3.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func15)
                            {
                                PROGLev4.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func15)
                            {
                                PROGLev5.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func15)
                            {
                                PROGLev6.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func15)
                            {
                                OFFLev1.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func15)
                            {
                                OFFLev2.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func15)
                            {
                                OFFLev3.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func15)
                            {
                                OFFLev4.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func15)
                            {
                                OFFLev5.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func15)
                            {
                                OFFLev6.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func15)
                            {
                                DIALev1.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func15)
                            {
                                DIALev2.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func15)
                            {
                                DIALev3.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func15)
                            {
                                DIALev4.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func15)
                            {
                                DIALev5.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func15)
                            {
                                DIALev6.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func15)
                            {
                                MAINLev1.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func15)
                            {
                                MAINLev2.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func15)
                            {
                                MAINLev3.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func15)
                            {
                                MAINLev4.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func15)
                            {
                                MAINLev5.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func15)
                            {
                                MAINLev6.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func15)
                            {
                                PARAMLev1.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func15)
                            {
                                PARAMLev2.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func15)
                            {
                                PARAMLev3.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func15)
                            {
                                PARAMLev4.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func15)
                            {
                                PARAMLev5.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func15)
                            {
                                PARAMLev6.Default.Func15 = false;
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func15 = true;
                                FuncAct15.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct16_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func16)
                            {
                                MONLev1.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func16)
                            {
                                MONLev2.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func16)
                            {
                                MONLev3.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func16)
                            {
                                MONLev4.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func16)
                            {
                                MONLev5.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func16)
                            {
                                MONLev6.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func16)
                            {
                                PROGLev1.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func16)
                            {
                                PROGLev2.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func16)
                            {
                                PROGLev3.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func16)
                            {
                                PROGLev4.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func16)
                            {
                                PROGLev5.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func16)
                            {
                                PROGLev6.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func16)
                            {
                                OFFLev1.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func16)
                            {
                                OFFLev2.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func16)
                            {
                                OFFLev3.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func16)
                            {
                                OFFLev4.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func16)
                            {
                                OFFLev5.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func16)
                            {
                                OFFLev6.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func16)
                            {
                                DIALev1.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func16)
                            {
                                DIALev2.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func16)
                            {
                                DIALev3.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func16)
                            {
                                DIALev4.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func16)
                            {
                                DIALev5.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func16)
                            {
                                DIALev6.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func16)
                            {
                                MAINLev1.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func16)
                            {
                                MAINLev2.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func16)
                            {
                                MAINLev3.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func16)
                            {
                                MAINLev4.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func16)
                            {
                                MAINLev5.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func16)
                            {
                                MAINLev6.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func16)
                            {
                                PARAMLev1.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func16)
                            {
                                PARAMLev2.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func16)
                            {
                                PARAMLev3.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func16)
                            {
                                PARAMLev4.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func16)
                            {
                                PARAMLev5.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func16)
                            {
                                PARAMLev6.Default.Func16 = false;
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func16 = true;
                                FuncAct16.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct17_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func17)
                            {
                                MONLev1.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func17)
                            {
                                MONLev2.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func17)
                            {
                                MONLev3.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func17)
                            {
                                MONLev4.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func17)
                            {
                                MONLev5.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func17)
                            {
                                MONLev6.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func17)
                            {
                                PROGLev1.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func17)
                            {
                                PROGLev2.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func17)
                            {
                                PROGLev3.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func17)
                            {
                                PROGLev4.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func17)
                            {
                                PROGLev5.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func17)
                            {
                                PROGLev6.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func17)
                            {
                                OFFLev1.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func17)
                            {
                                OFFLev2.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func17)
                            {
                                OFFLev3.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func17)
                            {
                                OFFLev4.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func17)
                            {
                                OFFLev5.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func17)
                            {
                                OFFLev6.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func17)
                            {
                                DIALev1.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func17)
                            {
                                DIALev2.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func17)
                            {
                                DIALev3.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func17)
                            {
                                DIALev4.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func17)
                            {
                                DIALev5.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func17)
                            {
                                DIALev6.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func17)
                            {
                                MAINLev1.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func17)
                            {
                                MAINLev2.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func17)
                            {
                                MAINLev3.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func17)
                            {
                                MAINLev4.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func17)
                            {
                                MAINLev5.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func17)
                            {
                                MAINLev6.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func17)
                            {
                                PARAMLev1.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func17)
                            {
                                PARAMLev2.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func17)
                            {
                                PARAMLev3.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func17)
                            {
                                PARAMLev4.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func17)
                            {
                                PARAMLev5.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func17)
                            {
                                PARAMLev6.Default.Func17 = false;
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func17 = true;
                                FuncAct17.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct18_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func18)
                            {
                                MONLev1.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func18)
                            {
                                MONLev2.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func18)
                            {
                                MONLev3.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func18)
                            {
                                MONLev4.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func18)
                            {
                                MONLev5.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func18)
                            {
                                MONLev6.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func18)
                            {
                                PROGLev1.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func18)
                            {
                                PROGLev2.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func18)
                            {
                                PROGLev3.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func18)
                            {
                                PROGLev4.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func18)
                            {
                                PROGLev5.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func18)
                            {
                                PROGLev6.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func18)
                            {
                                OFFLev1.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func18)
                            {
                                OFFLev2.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func18)
                            {
                                OFFLev3.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func18)
                            {
                                OFFLev4.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func18)
                            {
                                OFFLev5.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func18)
                            {
                                OFFLev6.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func18)
                            {
                                DIALev1.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func18)
                            {
                                DIALev2.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func18)
                            {
                                DIALev3.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func18)
                            {
                                DIALev4.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func18)
                            {
                                DIALev5.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func18)
                            {
                                DIALev6.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func18)
                            {
                                MAINLev1.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func18)
                            {
                                MAINLev2.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func18)
                            {
                                MAINLev3.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func18)
                            {
                                MAINLev4.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func18)
                            {
                                MAINLev5.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func18)
                            {
                                MAINLev6.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func18)
                            {
                                PARAMLev1.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func18)
                            {
                                PARAMLev2.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func18)
                            {
                                PARAMLev3.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func18)
                            {
                                PARAMLev4.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func18)
                            {
                                PARAMLev5.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func18)
                            {
                                PARAMLev6.Default.Func18 = false;
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func18 = true;
                                FuncAct18.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct19_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func19)
                            {
                                MONLev1.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func19)
                            {
                                MONLev2.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func19)
                            {
                                MONLev3.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func19)
                            {
                                MONLev4.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func19)
                            {
                                MONLev5.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func19)
                            {
                                MONLev6.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func19)
                            {
                                PROGLev1.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func19)
                            {
                                PROGLev2.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func19)
                            {
                                PROGLev3.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func19)
                            {
                                PROGLev4.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func19)
                            {
                                PROGLev5.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func19)
                            {
                                PROGLev6.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func19)
                            {
                                OFFLev1.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func19)
                            {
                                OFFLev2.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func19)
                            {
                                OFFLev3.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func19)
                            {
                                OFFLev4.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func19)
                            {
                                OFFLev5.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func19)
                            {
                                OFFLev6.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func19)
                            {
                                DIALev1.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func19)
                            {
                                DIALev2.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func19)
                            {
                                DIALev3.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func19)
                            {
                                DIALev4.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func19)
                            {
                                DIALev5.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func19)
                            {
                                DIALev6.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func19)
                            {
                                MAINLev1.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func19)
                            {
                                MAINLev2.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func19)
                            {
                                MAINLev3.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func19)
                            {
                                MAINLev4.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func19)
                            {
                                MAINLev5.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func19)
                            {
                                MAINLev6.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func19)
                            {
                                PARAMLev1.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func19)
                            {
                                PARAMLev2.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func19)
                            {
                                PARAMLev3.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func19)
                            {
                                PARAMLev4.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func19)
                            {
                                PARAMLev5.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func19)
                            {
                                PARAMLev6.Default.Func19 = false;
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func19 = true;
                                FuncAct19.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct20_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func20)
                            {
                                MONLev1.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func20)
                            {
                                MONLev2.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func20)
                            {
                                MONLev3.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func20)
                            {
                                MONLev4.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func20)
                            {
                                MONLev5.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func20)
                            {
                                MONLev6.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func20)
                            {
                                PROGLev1.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func20)
                            {
                                PROGLev2.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func20)
                            {
                                PROGLev3.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func20)
                            {
                                PROGLev4.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func20)
                            {
                                PROGLev5.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func20)
                            {
                                PROGLev6.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func20)
                            {
                                OFFLev1.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func20)
                            {
                                OFFLev2.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func20)
                            {
                                OFFLev3.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func20)
                            {
                                OFFLev4.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func20)
                            {
                                OFFLev5.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func20)
                            {
                                OFFLev6.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func20)
                            {
                                DIALev1.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func20)
                            {
                                DIALev2.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func20)
                            {
                                DIALev3.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func20)
                            {
                                DIALev4.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func20)
                            {
                                DIALev5.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func20)
                            {
                                DIALev6.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func20)
                            {
                                MAINLev1.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func20)
                            {
                                MAINLev2.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func20)
                            {
                                MAINLev3.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func20)
                            {
                                MAINLev4.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func20)
                            {
                                MAINLev5.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func20)
                            {
                                MAINLev6.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func20)
                            {
                                PARAMLev1.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func20)
                            {
                                PARAMLev2.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func20)
                            {
                                PARAMLev3.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func20)
                            {
                                PARAMLev4.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func20)
                            {
                                PARAMLev5.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func20)
                            {
                                PARAMLev6.Default.Func20 = false;
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func20 = true;
                                FuncAct20.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct21_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func21)
                            {
                                MONLev1.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func21)
                            {
                                MONLev2.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func21)
                            {
                                MONLev3.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func21)
                            {
                                MONLev4.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func21)
                            {
                                MONLev5.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func21)
                            {
                                MONLev6.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func21)
                            {
                                PROGLev1.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func21)
                            {
                                PROGLev2.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func21)
                            {
                                PROGLev3.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func21)
                            {
                                PROGLev4.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func21)
                            {
                                PROGLev5.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func21)
                            {
                                PROGLev6.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func21)
                            {
                                OFFLev1.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func21)
                            {
                                OFFLev2.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func21)
                            {
                                OFFLev3.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func21)
                            {
                                OFFLev4.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func21)
                            {
                                OFFLev5.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func21)
                            {
                                OFFLev6.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func21)
                            {
                                DIALev1.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func21)
                            {
                                DIALev2.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func21)
                            {
                                DIALev3.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func21)
                            {
                                DIALev4.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func21)
                            {
                                DIALev5.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func21)
                            {
                                DIALev6.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func21)
                            {
                                MAINLev1.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func21)
                            {
                                MAINLev2.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func21)
                            {
                                MAINLev3.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func21)
                            {
                                MAINLev4.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func21)
                            {
                                MAINLev5.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func21)
                            {
                                MAINLev6.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func21)
                            {
                                PARAMLev1.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func21)
                            {
                                PARAMLev2.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func21)
                            {
                                PARAMLev3.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func21)
                            {
                                PARAMLev4.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func21)
                            {
                                PARAMLev5.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func21)
                            {
                                PARAMLev6.Default.Func21 = false;
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func21 = true;
                                FuncAct21.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct22_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func22)
                            {
                                MONLev1.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func22)
                            {
                                MONLev2.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func22)
                            {
                                MONLev3.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func22)
                            {
                                MONLev4.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func22)
                            {
                                MONLev5.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func22)
                            {
                                MONLev6.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func22)
                            {
                                PROGLev1.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func22)
                            {
                                PROGLev2.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func22)
                            {
                                PROGLev3.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func22)
                            {
                                PROGLev4.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func22)
                            {
                                PROGLev5.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func22)
                            {
                                PROGLev6.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func22)
                            {
                                OFFLev1.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func22)
                            {
                                OFFLev2.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func22)
                            {
                                OFFLev3.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func22)
                            {
                                OFFLev4.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func22)
                            {
                                OFFLev5.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func22)
                            {
                                OFFLev6.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func22)
                            {
                                DIALev1.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func22)
                            {
                                DIALev2.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func22)
                            {
                                DIALev3.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func22)
                            {
                                DIALev4.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func22)
                            {
                                DIALev5.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func22)
                            {
                                DIALev6.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func22)
                            {
                                MAINLev1.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func22)
                            {
                                MAINLev2.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func22)
                            {
                                MAINLev3.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func22)
                            {
                                MAINLev4.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func22)
                            {
                                MAINLev5.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func22)
                            {
                                MAINLev6.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func22)
                            {
                                PARAMLev1.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func22)
                            {
                                PARAMLev2.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func22)
                            {
                                PARAMLev3.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func22)
                            {
                                PARAMLev4.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func22)
                            {
                                PARAMLev5.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func22)
                            {
                                PARAMLev6.Default.Func22 = false;
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func22 = true;
                                FuncAct22.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct23_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func23)
                            {
                                MONLev1.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func23)
                            {
                                MONLev2.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func23)
                            {
                                MONLev3.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func23)
                            {
                                MONLev4.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func23)
                            {
                                MONLev5.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func23)
                            {
                                MONLev6.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func23)
                            {
                                PROGLev1.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func23)
                            {
                                PROGLev2.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func23)
                            {
                                PROGLev3.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func23)
                            {
                                PROGLev4.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func23)
                            {
                                PROGLev5.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func23)
                            {
                                PROGLev6.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func23)
                            {
                                OFFLev1.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func23)
                            {
                                OFFLev2.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func23)
                            {
                                OFFLev3.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func23)
                            {
                                OFFLev4.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func23)
                            {
                                OFFLev5.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func23)
                            {
                                OFFLev6.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func23)
                            {
                                DIALev1.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func23)
                            {
                                DIALev2.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func23)
                            {
                                DIALev3.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func23)
                            {
                                DIALev4.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func23)
                            {
                                DIALev5.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func23)
                            {
                                DIALev6.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func23)
                            {
                                MAINLev1.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func23)
                            {
                                MAINLev2.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func23)
                            {
                                MAINLev3.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func23)
                            {
                                MAINLev4.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func23)
                            {
                                MAINLev5.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func23)
                            {
                                MAINLev6.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func23)
                            {
                                PARAMLev1.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func23)
                            {
                                PARAMLev2.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func23)
                            {
                                PARAMLev3.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func23)
                            {
                                PARAMLev4.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func23)
                            {
                                PARAMLev5.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func23)
                            {
                                PARAMLev6.Default.Func23 = false;
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func23 = true;
                                FuncAct23.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct24_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func24)
                            {
                                MONLev1.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func24)
                            {
                                MONLev2.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func24)
                            {
                                MONLev3.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func24)
                            {
                                MONLev4.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func24)
                            {
                                MONLev5.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func24)
                            {
                                MONLev6.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func24)
                            {
                                PROGLev1.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func24)
                            {
                                PROGLev2.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func24)
                            {
                                PROGLev3.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func24)
                            {
                                PROGLev4.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func24)
                            {
                                PROGLev5.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func24)
                            {
                                PROGLev6.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func24)
                            {
                                OFFLev1.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func24)
                            {
                                OFFLev2.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func24)
                            {
                                OFFLev3.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func24)
                            {
                                OFFLev4.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func24)
                            {
                                OFFLev5.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func24)
                            {
                                OFFLev6.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func24)
                            {
                                DIALev1.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func24)
                            {
                                DIALev2.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func24)
                            {
                                DIALev3.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func24)
                            {
                                DIALev4.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func24)
                            {
                                DIALev5.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func24)
                            {
                                DIALev6.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func24)
                            {
                                MAINLev1.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func24)
                            {
                                MAINLev2.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func24)
                            {
                                MAINLev3.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func24)
                            {
                                MAINLev4.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func24)
                            {
                                MAINLev5.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func24)
                            {
                                MAINLev6.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func24)
                            {
                                PARAMLev1.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func24)
                            {
                                PARAMLev2.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func24)
                            {
                                PARAMLev3.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func24)
                            {
                                PARAMLev4.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func24)
                            {
                                PARAMLev5.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func24)
                            {
                                PARAMLev6.Default.Func24 = false;
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func24 = true;
                                FuncAct24.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncAct25_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MONLev1.Default.Func25)
                            {
                                MONLev1.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev1.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MONLev2.Default.Func25)
                            {
                                MONLev2.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev2.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MONLev3.Default.Func25)
                            {
                                MONLev3.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev3.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MONLev4.Default.Func25)
                            {
                                MONLev4.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev4.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MONLev5.Default.Func25)
                            {
                                MONLev5.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev5.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MONLev6.Default.Func25)
                            {
                                MONLev6.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MONLev6.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PROGLev1.Default.Func25)
                            {
                                PROGLev1.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev1.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PROGLev2.Default.Func25)
                            {
                                PROGLev2.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev2.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PROGLev3.Default.Func25)
                            {
                                PROGLev3.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev3.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PROGLev4.Default.Func25)
                            {
                                PROGLev4.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev4.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PROGLev5.Default.Func25)
                            {
                                PROGLev5.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev5.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PROGLev6.Default.Func25)
                            {
                                PROGLev6.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PROGLev6.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (OFFLev1.Default.Func25)
                            {
                                OFFLev1.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev1.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (OFFLev2.Default.Func25)
                            {
                                OFFLev2.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev2.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (OFFLev3.Default.Func25)
                            {
                                OFFLev3.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev3.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (OFFLev4.Default.Func25)
                            {
                                OFFLev4.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev4.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (OFFLev5.Default.Func25)
                            {
                                OFFLev5.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev5.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (OFFLev6.Default.Func25)
                            {
                                OFFLev6.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                OFFLev6.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (DIALev1.Default.Func25)
                            {
                                DIALev1.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev1.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (DIALev2.Default.Func25)
                            {
                                DIALev2.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev2.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (DIALev3.Default.Func25)
                            {
                                DIALev3.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev3.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (DIALev4.Default.Func25)
                            {
                                DIALev4.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev4.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (DIALev5.Default.Func25)
                            {
                                DIALev5.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev5.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (DIALev6.Default.Func25)
                            {
                                DIALev6.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                DIALev6.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (MAINLev1.Default.Func25)
                            {
                                MAINLev1.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev1.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (MAINLev2.Default.Func25)
                            {
                                MAINLev2.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev2.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (MAINLev3.Default.Func25)
                            {
                                MAINLev3.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev3.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (MAINLev4.Default.Func25)
                            {
                                MAINLev4.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev4.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (MAINLev5.Default.Func25)
                            {
                                MAINLev5.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev5.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (MAINLev6.Default.Func25)
                            {
                                MAINLev6.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                MAINLev6.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (PARAMLev1.Default.Func25)
                            {
                                PARAMLev1.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev1.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (PARAMLev2.Default.Func25)
                            {
                                PARAMLev2.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev2.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (PARAMLev3.Default.Func25)
                            {
                                PARAMLev3.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev3.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (PARAMLev4.Default.Func25)
                            {
                                PARAMLev4.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev4.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (PARAMLev5.Default.Func25)
                            {
                                PARAMLev5.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev5.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (PARAMLev6.Default.Func25)
                            {
                                PARAMLev6.Default.Func25 = false;
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                PARAMLev6.Default.Func25 = true;
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        }

        private void FuncSelPage_Paint(object sender, PaintEventArgs e)
        {
            FuncOanelPagePaint();
        }
    }
}
