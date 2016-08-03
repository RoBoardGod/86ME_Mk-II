﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace _86ME_ver1
{
    public class ME_Motion
    {
        public ArrayList Events;
        public List<string> states;
        public List<string> goto_var; 
        public List<int> used_servos;
        public string name;
        public int trigger_method;
        public int auto_method;
        public int trigger_key;
        public int trigger_keyType;
        public string bt_key;
        public string bt_mode;
        public int wifi602_key;
        public int frames;
        public string ps2_key;
        public int ps2_type;
        public int property;
        public int moton_layer;
        public int comp_range;
        public int control_method;
        public double[] acc_Settings; //LX, HX, LY, HY, LZ, HZ, D
        public ME_Motion()
        {
            this.name = null;
            this.Events = new ArrayList();
            this.trigger_method = 0;
            this.auto_method = 0;
            this.trigger_key = 0;
            this.trigger_keyType = 1;
            this.bt_key = "";
            this.bt_mode = "OneShot";
            this.wifi602_key = 0;
            this.frames = 0;
            this.ps2_key = "PSB_SELECT";
            this.ps2_type = 1;
            this.property = 0;
            this.moton_layer = 0;
            this.comp_range = 180;
            this.control_method = 0;
            this.acc_Settings = new double[7];
            this.goto_var = new List<string>();
            this.states = new List<string>();
            this.used_servos = new List<int>();
        }

        public ME_Motion Copy()
        {
            ME_Motion ret = new ME_Motion();
            ret.name = this.name;
            for (int i = 0; i < this.Events.Count; i++)
            {
                if (this.Events[i] is ME_Frame)
                    ret.Events.Add(((ME_Frame)this.Events[i]).Copy());
                else if (this.Events[i] is ME_Delay)
                    ret.Events.Add(((ME_Delay)this.Events[i]).Copy());
                else if (this.Events[i] is ME_Flag)
                    ret.Events.Add(((ME_Flag)this.Events[i]).Copy());
                else if (this.Events[i] is ME_Goto)
                    ret.Events.Add(((ME_Goto)this.Events[i]).Copy());
                else if (this.Events[i] is ME_Trigger)
                    ret.Events.Add(((ME_Trigger)this.Events[i]).Copy());
                else if (this.Events[i] is ME_Release)
                    ret.Events.Add(((ME_Release)this.Events[i]).Copy());
                else if (this.Events[i] is ME_If)
                    ret.Events.Add(((ME_If)this.Events[i]).Copy());
                else if (this.Events[i] is ME_Compute)
                    ret.Events.Add(((ME_Compute)this.Events[i]).Copy());
            }
            ret.trigger_method = this.trigger_method;
            ret.auto_method = this.auto_method;
            ret.trigger_key = this.trigger_key;
            ret.trigger_keyType = this.trigger_keyType;
            ret.bt_key = this.bt_key;
            ret.bt_mode = this.bt_mode;
            ret.frames = this.frames;
            ret.ps2_key = this.ps2_key;
            ret.ps2_type = this.ps2_type;
            ret.property = this.property;
            ret.moton_layer = this.moton_layer;
            ret.comp_range = this.comp_range;
            ret.control_method = this.control_method;
            ret.acc_Settings = this.acc_Settings;
            ret.goto_var = this.goto_var;
            ret.states = this.states;
            ret.used_servos = this.used_servos;
            return ret;
        }
    }

    public class ME_Trigger
    {
        public string name;
        public int method;
        public ME_Trigger()
        {
            this.name = "";
            this.method = 1;
        }

        public ME_Trigger Copy()
        {
            ME_Trigger ret = new ME_Trigger();
            ret.name = this.name;
            ret.method = this.method;
            return ret;
        }
    }

    public class ME_Frame
    {
        public int[] frame;
        public int delay;
        public int num;
        public byte type;
        public ME_Frame()
        {
            this.frame = new int[45];
            this.delay = 1000;
            this.type = 1;
        }

        public ME_Frame Copy()
        {
            ME_Frame ret = new ME_Frame();
            this.frame.CopyTo(ret.frame, 0);
            ret.delay = this.delay;
            ret.type = this.type;
            return ret;
        }
    }

    public class ME_Delay 
    {
        public int delay;
        public ME_Delay()
        {
            this.delay = 1000;
        }

        public ME_Delay Copy()
        {
            ME_Delay ret = new ME_Delay();
            ret.delay = this.delay;
            return ret;
        }
    }

    public class ME_Goto
    {
        public string name;
        public bool is_goto;
        public string loops;
        public int current_loop;
        public bool infinite;
        public ME_Goto()
        {
            this.name = null;
            this.is_goto = false;
            this.loops = "0";
            this.current_loop = 0;
            this.infinite = false;
        }

        public ME_Goto Copy()
        {
            ME_Goto ret = new ME_Goto();
            ret.name = this.name;
            ret.is_goto = this.is_goto;
            ret.loops = this.loops;
            ret.current_loop = this.current_loop;
            ret.infinite = this.infinite;
            return ret;
        }
    }

    public class ME_Flag
    {
        public string name;
        public string var;
        public ME_Flag()
        {
            this.name = null;
            this.var = null;
        }

        public ME_Flag Copy()
        {
            ME_Flag ret = new ME_Flag();
            ret.name = this.name;
            ret.var = this.var;
            return ret;
        }
    }

    public class ME_Release
    {
        public ME_Release()
        {
        }
        public ME_Release Copy()
        {
            ME_Release ret = new ME_Release();
            return ret;
        }
    }

    public class ME_If
    {
        public int method;
        public int left_var;
        public int right_var;
        public string name;
        public ME_If()
        {
            this.name = null;
            this.method = 0;
            this.left_var = 0;
            this.right_var = 0;
        }

        public ME_If Copy()
        {
            ME_If ret = new ME_If();
            ret.name = this.name;
            ret.method = this.method;
            ret.left_var = this.left_var;
            ret.right_var = this.right_var;
            return ret;
        }
    }

    public class ME_Compute
    {
        public int left_var;
        public int form;
        public int f1_var1;
        public int f1_op;
        public int f1_var2;
        public int f2_op;
        public int f2_var;
        public int f3_var;
        public double f4_const;
        public ME_Compute()
        {
            this.left_var = 0;
            this.form = 0;
            this.f1_var1 = 0;
            this.f1_op = 0;
            this.f1_var2 = 0;
            this.f2_op = 0;
            this.f2_var = 0;
            this.f3_var = 0;
            this.f4_const = 0.0;
        }

        public ME_Compute Copy()
        {
            ME_Compute ret = new ME_Compute();
            ret.left_var = this.left_var;
            ret.form = this.form;
            ret.f1_var1 = this.f1_var1;
            ret.f1_op = this.f1_op;
            ret.f1_var2 = this.f1_var2;
            ret.f2_op = this.f2_op;
            ret.f2_var = this.f2_var;
            ret.f3_var = this.f3_var;
            ret.f4_const = this.f4_const;
            return ret;
        }
    }
}
