using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JCNCShareMemory;
using System.Drawing;

namespace PagesAuthority
{
    public partial class FuncSelPage
    {
        void FuncOanelPagePaint() {
            switch (MFC_Flag)
            {
                case ShareMemory.MFC_Flag.MON:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (!MONLev1.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!MONLev1.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (!MONLev2.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!MONLev2.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (!MONLev3.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!MONLev3.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (!MONLev4.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!MONLev4.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (!MONLev5.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!MONLev5.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (!MONLev6.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!MONLev6.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PROG:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (!PROGLev1.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!PROGLev1.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (!PROGLev2.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!PROGLev2.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (!PROGLev3.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!PROGLev3.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (!PROGLev4.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!PROGLev4.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (!PROGLev5.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!PROGLev5.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (!PROGLev6.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!PROGLev6.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.OFF:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (!OFFLev1.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!OFFLev1.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (!OFFLev2.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!OFFLev2.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (!OFFLev3.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!OFFLev3.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (!OFFLev4.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!OFFLev4.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (!OFFLev5.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!OFFLev5.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (!OFFLev6.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!OFFLev6.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.DIA:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (!DIALev1.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!DIALev1.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (!DIALev2.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!DIALev2.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (!DIALev3.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!DIALev3.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (!DIALev4.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!DIALev4.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (!DIALev5.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!DIALev5.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (!DIALev6.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!DIALev6.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.MAIN:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (!MAINLev1.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!MAINLev1.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (!MAINLev2.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!MAINLev2.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (!MAINLev3.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!MAINLev3.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (!MAINLev4.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!MAINLev4.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (!MAINLev5.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!MAINLev5.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (!MAINLev6.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!MAINLev6.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
                case ShareMemory.MFC_Flag.PARAM:
                    switch (Level)
                    {
                        case ShareMemory.Level.Lev1:
                            if (!PARAMLev1.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!PARAMLev1.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev2:
                            if (!PARAMLev2.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!PARAMLev2.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev3:
                            if (!PARAMLev3.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!PARAMLev3.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev4:
                            if (!PARAMLev4.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!PARAMLev4.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev5:
                            if (!PARAMLev5.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!PARAMLev5.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                        case ShareMemory.Level.Lev6:
                            if (!PARAMLev6.Default.Func01)
                            {
                                FuncAct1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct1.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func02)
                            {
                                FuncAct2.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct2.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func03)
                            {
                                FuncAct3.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct3.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func04)
                            {
                                FuncAct4.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct4.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func05)
                            {
                                FuncAct5.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct5.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func06)
                            {
                                FuncAct6.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct6.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func07)
                            {
                                FuncAct7.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct7.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func08)
                            {
                                FuncAct8.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct8.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func09)
                            {
                                FuncAct9.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct9.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func10)
                            {
                                FuncAct10.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct10.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func11)
                            {
                                FuncAct11.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct11.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func12)
                            {
                                FuncAct12.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct12.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func13)
                            {
                                FuncAct13.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct13.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func14)
                            {
                                FuncAct14.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct14.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func15)
                            {
                                FuncAct15.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct15.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func16)
                            {
                                FuncAct16.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct16.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func17)
                            {
                                FuncAct17.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct17.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func18)
                            {
                                FuncAct18.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct18.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func19)
                            {
                                FuncAct19.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct19.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func20)
                            {
                                FuncAct20.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct20.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func21)
                            {
                                FuncAct21.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct21.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func22)
                            {
                                FuncAct22.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct22.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func23)
                            {
                                FuncAct23.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct23.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func24)
                            {
                                FuncAct24.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct24.BackColor = Color.Blue;
                            }
                            if (!PARAMLev6.Default.Func25)
                            {
                                FuncAct25.BackColor = System.Drawing.SystemColors.AppWorkspace;
                            }
                            else
                            {
                                FuncAct25.BackColor = Color.Blue;
                            }
                            break;
                    }
                    break;
            }
        
        }
    }
}
