﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using ObjectWeb.Asm;
using ObjectWeb.Asm.Tree;

namespace Java_Corruptor.UI.Components.EngineControls;

public partial class FunctionEngineControl
{
    private string[] _limiters, _values;
    public FunctionEngineControl() => InitializeComponent();

    public override void Prepare()
    {
        base.Prepare();
        _limiters = lbLimiterFunctions.SelectedItems.Cast<string>().ToArray();
        _values = lbValueFunctions.SelectedItems.Cast<string>().ToArray();
    }

    public override void UpdateUI()
    {
        foreach (string limiter in _limiters)
            lbLimiterFunctions.SetSelected(Array.IndexOf(lbLimiterFunctions.Items.Cast<string>().ToArray(), limiter), true);
        foreach (string value in _values)
            lbValueFunctions.SetSelected(Array.IndexOf(lbValueFunctions.Items.Cast<string>().ToArray(), value), true);
    }

    public override InsnList DoCorrupt(AbstractInsnNode insn, AsmParser parser, ref int replaces)
    {
        InsnList list = new();
        if (insn.Opcode != Opcodes.Invokestatic)
            return list;

        MethodInsnNode methodInsnNode = (MethodInsnNode)insn;
        if (methodInsnNode.Owner != "java/lang/Math" || methodInsnNode.Desc != "(D)D")
            return list;

        if (Array.IndexOf(_limiters, methodInsnNode.Name) != -1)
        {
            //TODO: leaving this unfinished code here. it's impossible to implement this without being able to store the value in a variable.
            /*if (_runtimeRandom)
            {
                // we can't use branching code in the corruptor, so:
                // we'll make an array of the selected functions
                // call java/lang/Math.random()D and multiply it by the length of the array
                // cast the result to an int and use it as an index to select a function
                // then call that function
                
                // String[] functions = new String[] { "func1(D)D", "func2(D)D", "func3(D)D" };
                list.Add(new LdcInsnNode(JType.GetObjectType("java/lang/Math")));
                list.Add(new LdcInsnNode(_values.Length));
                list.Add(new TypeInsnNode(Opcodes.Anewarray, "java/lang/String"));
                for (int i = 0; i < _values.Length; i++)
                {
                    list.Add(new InsnNode(Opcodes.Dup));
                    list.Add(new LdcInsnNode(i));
                    list.Add(new LdcInsnNode(_values[i]));
                    list.Add(new InsnNode(Opcodes.Aastore));
                }
                
                list.Add(new MethodInsnNode(Opcodes.Invokestatic, "java/lang/Math", "random", "()D", false));
                list.Add(new LdcInsnNode(_values.Length));
                list.Add(new InsnNode(Opcodes.Dmul));
                list.Add(new InsnNode(Opcodes.D2I));
                list.Add(new InsnNode(Opcodes.Aaload));
                
                list.Add(new InsnNode(Opcodes.Iconst_1));
                list.Add(new TypeInsnNode(Opcodes.Anewarray, "java/lang/Class"));
                list.Add(new InsnNode(Opcodes.Dup));
                list.Add(new InsnNode(Opcodes.Iconst_0));
                list.Add(new FieldInsnNode(Opcodes.Getstatic, "java/lang/Double", "TYPE", "Ljava/lang/Class;"));
                list.Add(new InsnNode(Opcodes.Aastore));
                
                list.Add(new MethodInsnNode(Opcodes.Invokevirtual, "java/lang/Class", "getMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", false));
                list.Add(new InsnNode(Opcodes.Aconst_Null));
                list.Add(new InsnNode(Opcodes.Iconst_1));
                list.Add(new TypeInsnNode(Opcodes.Anewarray, "java/lang/Object"));
                list.Add(new InsnNode(Opcodes.Dup));
                list.Add(new InsnNode(Opcodes.Iconst_0));
                
            }
            else
            {*/
                string newMethod = _values[JavaGeneralParametersForm.Random.Next(_values.Length)];
                if (newMethod == "POP,random()")
                {
                    list.Add(new InsnNode(Opcodes.Pop));
                    list.Add(new MethodInsnNode(Opcodes.Invokestatic, "java/lang/Math", "random", "()D", false));
                }
                else if (newMethod == "round" && methodInsnNode.Name != "round")
                {
                    list.Add(new MethodInsnNode(Opcodes.Invokestatic, "java/lang/Math", "round", "(D)J", false));
                    list.Add(new InsnNode(Opcodes.L2D));
                }
                else if (methodInsnNode.Name == "round" && newMethod != "round")
                {
                    methodInsnNode.Name = newMethod;
                    list.Add(methodInsnNode.Clone());
                    list.Add(new InsnNode(Opcodes.D2L));
                }
                else
                {
                    methodInsnNode.Name = newMethod;
                    list.Add(methodInsnNode.Clone());
                }
            //}
        }
        else
            list.Add(insn);

        replaces = 1;
        return list;
    }

    public override ExpandoObject EngineSettings
    {
        get
        {
            if (_engineSettings is not null)
                return _engineSettings;
            dynamic settings = new ExpandoObject();
            settings.LimiterFunctions = _limiters;
            settings.ValueFunctions = _values;
            _engineSettings = settings;
            return settings;
        }
        set
        {
            dynamic settings = value;
            if (settings.LimiterFunctions is Array)
                _limiters = settings.LimiterFunctions;
            else
                _limiters = ((IEnumerable<object>)settings.LimiterFunctions).Select(x => (string)x).ToArray();
            if (settings.ValueFunctions is Array)
                _values = settings.ValueFunctions;
            else
                _values = ((IEnumerable<object>)settings.ValueFunctions).Select(x => (string)x).ToArray();
        }
    }
}