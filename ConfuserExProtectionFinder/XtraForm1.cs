using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System.IO;
using de4dot.blocks;
using de4dot.blocks.cflow;
using System.Runtime.InteropServices;
using System.Reflection;

namespace ConfuserExProtectionFinder
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }
        #region drop
        private void TextBox1DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void TextBox1DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Array array = (Array)e.Data.GetData(DataFormats.FileDrop);
                if (array != null)
                {
                    string text = array.GetValue(0).ToString();
                    int num = text.LastIndexOf(".", StringComparison.Ordinal);
                    if (num != -1)
                    {
                        string text2 = text.Substring(num);
                        text2 = text2.ToLower();
                        if (text2 == ".exe" || text2 == ".dll")
                        {
                            Activate();
                            path.Text = text;

                        }
                    }
                }
            }
            catch
            {
            }
        }
        #endregion
        public void  ResetLabels()
        {
            Packer.ForeColor = Color.White;
            ILDasm.ForeColor = Color.White;
            AT.ForeColor = Color.White;
            Constants.ForeColor = Color.White;
            ADebug.ForeColor = Color.White;
            ADump.ForeColor = Color.White;
            CFlow.ForeColor = Color.White;
            Resource.ForeColor = Color.White;
            RF.ForeColor = Color.White;

            Packer.Text = "?";
            ILDasm.Text = "?";
            AT.Text = "?";
            Constants.Text = "?";
            ADebug.Text = "?";
            ADump.Text = "?";
            CFlow.Text = "?";
            Resource.Text = "?";
            RF.Text = "?";
            Protector.Text = "?";

            PackerMode.Text = "/";
            Predicate.Text = "/";
            ModeRF.Text = "/";
            ATMode.Text = "/";
            ModeConstants.Text = "/";
            EncodingRF.Text = "/";
            ResourceMode.Text = "/";
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ResetLabels();
            ModuleDefMD module = null;
            try
            {
                 module = ModuleDefMD.Load(path.Text);
            }
           catch
            {
                Infos.Text = "Can't Load Assembly....";
                return;
            }
            Infos.Text = "Assembly Loaded";
            Protector.Text = FindProtectorName(module);
            ChangeText(ILDasm, AntiILDasm(module));
            bool Packed = IsPacked(module);
            if (Packed)
            {
                ChangeText(Packer, true);
                PackerMode.Text = FindModePacker(module);
                XtraMessageBox.Show("Can't go deeper because of packer. Please remove it and scan again !", "Aborting...");
                Infos.Text = "Can't go deeper because of packer. Please remove it and scan again !";
            }
            else
            {
                ChangeText(Packer, false);
                bool Tampered = IsTampered(module);
                if (Tampered)
                {
                    ATMode.Text = ATModeChecker();
                    ChangeText(AT, true);
                    Infos.Text = "Scan with Anti-Tamper may be imprecise and can fail, pay attention !";
                    ChangeText(Constants, ConstantsAT(module));
                    ChangeTextAT(ADebug, TryFindAntiDebug(module));
                    ChangeTextAT(ADump, TryFindAntiDump(module));
                    bool Flow = IsFlowed(module, module.GlobalType.FindStaticConstructor());
                    ChangeText(CFlow, Flow);
                    if (Flow)
                    {
                        Predicate.Text = CFlowPredicate(module, module.GlobalType.FindStaticConstructor());
                    }
                    bool NormalRProxy = NormalProxyAT(module);
                    bool StrongRProxy = StrongProxy(module);
                    if (StrongRProxy || NormalRProxy)
                    {
                        if (NormalRProxy)
                        {
                            ModeRF.Text = "Mild";
                        }
                        else
                        {
                            ModeRF.Text = "Strong";

                        }

                        RF.ForeColor = Color.Lime;
                        RF.Text = "Found";
                    }
                    else
                    {
                        RF.ForeColor = Color.Red;
                        RF.Text = "Not Found";
                    }
                    bool Resourcess = TryGetResource(module);
                    ChangeText(Resource, Resourcess);
                }
                else
                {
                    ChangeText(AT, false);
                    ChangeText(ADebug, AntiDebug(module));
                    ChangeText(ADump, AntiDump(module));
                    bool Flow = IsFlowed(module, module.EntryPoint);
                    ChangeText(CFlow, Flow);
                    if (Flow)
                    {
                        Predicate.Text = CFlowPredicate(module, module.EntryPoint);
                    }
                    bool Constant = ConstantsAT(module);
                    ChangeText(Constants, Constant);
                    if (Constant)
                    {
                        ModeConstants.Text = ConstantsMode();
                        Cfg.Text = IsCFG(module);
                    }
                    bool NormalRProxy = NormalProxy(module);
                    bool StrongRProxy = StrongProxy(module);
                    if (NormalRProxy || StrongRProxy)
                    {
                        RF.ForeColor = Color.Lime;
                        RF.Text = "Found";
                        if (NormalRProxy)
                        {
                            ModeRF.Text = "Mild";
                        }
                        else
                        {
                            EncodingRF.Text = FindEncodingRF();
                            ModeRF.Text = "Strong";
                        }
                    }
                    else
                    {
                        RF.ForeColor = Color.Red;
                        RF.Text = "Not Found";
                    }
                    bool res = Resources(module);
                    ChangeText(Resource, res);
                    if(res)
                    {
                        ResourceMode.Text = ResourceModeChecker();
                    }
                }

            }
            Infos.Text = "Scan finished !";
        }
        //Try to find a Proxy meth of Resources decryption. Works even without proxy
        public static bool TryGetResource(ModuleDefMD module)
        {
            TypeDef type = module.GlobalType;
            foreach (MethodDef method in type.Methods)
            {
                if (method.ReturnType.ReflectionFullName == module.Import(typeof(Assembly)).ToTypeSig().ReflectionFullName)
                {
                    if (method.MethodSig.Params.Count == 2 && method.MethodSig.Params[0].ToString().Contains("Object") && method.MethodSig.Params[1].ToString().Contains("ResolveEventArgs"))
                    {
                        //Extra check to strengthen result
                        return FindField(module);
                    }
                }
            }
            return false;
        }
        public static bool FindField(ModuleDefMD module)
        {
            TypeDef type = module.GlobalType;
            foreach (FieldDef fld in type.Fields)
            {
               if(fld.FieldType.ReflectionFullName == module.Import(typeof(Assembly)).ToTypeSig().ReflectionFullName)
                {
                    return true;
                }
            }
            return false;
        }
        public static string ResourceModeChecker()
        {
            MethodDef method = ResMeth;
            if (method.Body.Variables.Count < 15)
            {
                return "Normal";
            }
            else
            {
                return "Dynamic";
            }
        }
        public string FindModePacker(ModuleDefMD module)
        {
            foreach(TypeDef type in module.Types)
            {
                foreach(MethodDef method in type.Methods.Where(m => m.HasBody && m.Body.HasInstructions))
                {
                    if (method.MethodSig.RetType.ReflectionFullName == module.Import(typeof(GCHandle)).ToTypeSig().ReflectionFullName)
                    {
                        if(method.MethodSig.Params.Count ==2 && method.MethodSig.Params[0].ToString().Contains("UInt32[]") && method.MethodSig.Params[1].ToString().Contains("UInt32"))
                        {
                            if(method.Body.Variables.Count >=14)
                            {
                                return "Dynamic";
                            }
                            else
                            {
                                return "Normal";
                            }
                        }
                    }
                    
                }
            }
            return "Not Found";
        }
        public string CFlowPredicate(ModuleDefMD module, MethodDef method)
        {
            List<string> FoundFlow = new List<string>();
            Blocks blocks = new Blocks(method);
           List<Block> BlockList =  blocks.MethodBlocks.GetAllBlocks();
            foreach (Block b in BlockList)
            {
                if (b.LastInstr.OpCode == OpCodes.Switch)
                {
                    if (isExpressionBlock(b) || isolderExpCflow(b))
                    {
                        FoundFlow.Add("Expression");
                    }
                    else if (isNative(b) || isolderNatCflow(b))
                    {
                        FoundFlow.Add("x86");
                    }
                    else
                    {
                        FoundFlow.Add("Switch");
                    }
                }
            }
            return String.Join(", ", FoundFlow.Distinct().ToArray());
        }
        #region CFlowMode
        //Thanks to Cawk for this part
        public static bool isExpressionBlock(Block block)
        {
            bool flag = block.Instructions.Count < 7;
            if (!flag)
            {
                if (block.FirstInstr.IsStloc())
                {
                    return true;
                }

            }
                return false;
        }
        public static bool isolderNatCflow(Block block)
        {
            bool flag = block.Instructions.Count != 2;
            if (!flag)
            {
                bool flag2 = block.FirstInstr.OpCode != OpCodes.Call;
                if (!flag2)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool isolderExpCflow(Block block)
        {
            bool flag = block.Instructions.Count <= 2;
            if (!flag)
            {
                bool flag2 = !block.FirstInstr.IsStloc();
                if (!flag2)
                {
                    return true;
                }
            }
            return false;
        }
        private bool isNative(Block block)
        {
            bool flag = block.Instructions.Count <= 5;
            if (!flag)
            {
                bool flag2 = block.FirstInstr.OpCode != OpCodes.Call;
                if (!flag2)
                {
                    return true;
                }
            }
            return false;
        }
        private bool isSwitchBlock(Block block)
        {
            if (block.Instructions.Count > 6 && block.FirstInstr.IsLdcI4())
            {
                return true;
            }
            return false;
        }
        #endregion
        public static bool IsFlowed(ModuleDefMD module, MethodDef method)
        {
            for(int i = 0; i < method.Body.Instructions.Count;i++)
            {
                if(method.Body.Instructions[i].OpCode == OpCodes.Switch)
                {
                    return true;
                }
            }
            return false;
        }
        public static string ConstantsMode()
        {
            for(int i = 0; i < ConstantsMeth.Body.Instructions.Count;i++)
            {
                if (ConstantsMeth.Body.Instructions[i].OpCode == OpCodes.Call)
                {
                    try
                    {
                        MethodDef native = (MethodDef)ConstantsMeth.Body.Instructions[i].Operand;
                        if (native.IsNative)
                        {
                            return "x86";
                        }
                    }
                    catch
                    {

                    }
                  
                }
            }
            return IsDynamic(ConstantsMeth.Module);
        }
        public static string IsCFG(ModuleDefMD module)
        {
            foreach (TypeDef type in module.Types.Where(type => type.IsSealed && type.IsBeforeFieldInit && type.HasMethods && type.HasFields))
            {
                try
                {
                    MethodDef ctor = type.Methods.First(m => m.IsConstructor);
                    if (ctor.IsSpecialName && ctor.IsHideBySig && ctor.MethodSig.Params.Count == 1 && ctor.MethodSig.Params[0].ToString().Contains("UInt32"))
                    {
                        return "Yes";
                    }
                }
                catch
                {

                }
                
            }
            return "No";
        }
        private static string IsDynamic(ModuleDef module)
        {
            TypeDef type = module.GlobalType;
            foreach(MethodDef method in type.Methods.Where(m => m.MethodSig.RetType.ReflectionFullName  == module.Import(module.CorLibTypes.Void).ReflectionFullName && m.MethodSig.Params.Count == 0))
            {
                for(int i = 0; i < method.Body.Instructions.Count-1;i++)
                {
                    if (method.Body.Instructions[i].OpCode == OpCodes.Call && method.Body.Instructions[i].Operand.ToString().Contains("InitializeArray"))
                    {
                        //Other check to strengthen result
                        if(IsNotResource(method))
                        {
                            return (method.Body.Variables.Count < 15) ? "Normal" : "Dynamic";
                        }
                    }
                }
               
            }
            return "Not Found";
        }

        private static bool IsNotResource(MethodDef method)
        {
            for (int i = method.Body.Instructions.Count - 1; i > 0; i--)
            {
                if (method.Body.Instructions[i].OpCode == OpCodes.Callvirt && method.Body.Instructions[i].Operand.ToString().Contains("add_AssemblyResolve"))
                {
                    //Other check to strengthen result
                    return false;
                }
            }
            return true;
        }

        public static MethodDef StrongMeth = null;
        public static string FindEncodingRF()
        {
            for (int i = 0; i < StrongMeth.Body.Instructions.Count - 1; i++)
            {
                if (StrongMeth.Body.Instructions[i].OpCode == OpCodes.Call)
                {
                    try
                    {
                        MethodDef native = (MethodDef)StrongMeth.Body.Instructions[i].Operand;
                        if (native.IsNative)
                        {
                            return "x86";
                        }
                    }
                    catch
                    {

                    }

                }
            }
            return IsExpressionRF(StrongMeth.Module);
        }
        public static string IsExpressionRF(ModuleDef module)
        {
            MethodDef method = StrongMeth;
            for(int i = 0; i < method.Body.Instructions.Count-1;i++)
            {
                if(method.Body.Instructions[i].OpCode == OpCodes.Stloc_3)
                {
                    return FindMulInNext(method, i);
                }
            }
            return "Not Found";
        }

        private static string FindMulInNext(MethodDef method, int z)
        {
            for(int i = z; i < z+8;z++)
            {
                if(method.Body.Instructions[i].OpCode == OpCodes.Mul)
                {
                    return "Normal";
                }
            }
            return "Expression";
        }
        
        public static bool StrongProxy(ModuleDefMD module)
        {
            TypeDef type = module.GlobalType;
            
            foreach (MethodDef method in type.Methods)
            {
                if (method.Parameters.Count == 2 && method.FullName.ToString().Contains("RuntimeFieldHandle"))
                {
                    StrongMeth = method;
                    return true;
                }
            }
            return false;
        }
        public static bool NormalProxyAT(ModuleDefMD module)
        {
            TypeDef type = module.EntryPoint.DeclaringType;
            foreach (MethodDef method in type.Methods.Where(m => m.MethodSig.Params.Count == 1))
            {
               if(method.MethodSig.Params[0].ToString().Contains("Form"))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool NormalProxy(ModuleDefMD module)
        {
            TypeDef type = module.EntryPoint.DeclaringType;
            foreach(MethodDef method in type.Methods.Where(m => m.HasBody && m.Body.HasInstructions && m.MethodSig.Params.Count ==0 && m.Body.Instructions.Count < 5))
            {
               for(int i = 0; i < method.Body.Instructions.Count-1;i++)
                {
                    if(method.Body.Instructions[i].OpCode == OpCodes.Call)
                    {
                      
                        if (method.Body.Instructions[i].Operand.ToString().Contains("EnableVisualStyles"))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        //Try to find a Proxy meth of Anti-Dump. Can't work if RefProxy is not enabled....
        public static bool TryFindAntiDump(ModuleDefMD module)
        {
            TypeDef type = module.GlobalType;
            foreach (MethodDef method in type.Methods)
            {
                if (method.ReturnType.ReflectionFullName == module.Import(typeof(Type)).ToTypeSig().ReflectionFullName)
                {
                    if (method.MethodSig.Params.Count == 1 && method.MethodSig.Params[0].ToString().Contains("RuntimeTypeHandle"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //Try to find a Proxy meth of Anti-Debug. Can't work if RefProxy is not enabled....
        public static bool TryFindAntiDebug(ModuleDefMD module)
        {
            TypeDef type = module.GlobalType;
            foreach (MethodDef method in type.Methods)
            { 
                if (method.ReturnType.ReflectionFullName == module.Import(typeof(System.Threading.Thread)).ToTypeSig().ReflectionFullName)
                {
                    if(method.MethodSig.Params.Count == 1 && method.MethodSig.Params[0].ToString().Contains("ParameterizedThreadStart"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static string FindProtectorName(ModuleDefMD module)
        {
            foreach (CustomAttribute attr in module.CustomAttributes)
            {
                if(attr.ToString().Contains("ConfusedBy"))
                {
                    return attr.ConstructorArguments[0].Value.ToString();
                }
            }
            return "Not Found";
        }
        public static bool Resources(ModuleDefMD module)
        {
            TypeDef type = module.GlobalType;
            foreach (MethodDef method in type.Methods)
            {
                if (method.HasBody && method.Body.HasInstructions)
                {
                    //Can be bigger
                    if (method.Body.Variables.Count >= 10)
                    {
                        for (int i = method.Body.Instructions.Count - 1; i > 0; i--)
                        {
                            if (method.Body.Instructions[i].OpCode == OpCodes.Callvirt && method.Body.Instructions[i].Operand.ToString().Contains("add_AssemblyResolve"))
                            {
                                //Other check to strengthen result
                                return GetCurrentDomain(method);
                            }
                        }
                    }
                }
            }
            return false;
        }
        public static MethodDef ResMeth = null;
        public static bool GetCurrentDomain(MethodDef method)
        {
            for (int i = method.Body.Instructions.Count - 1; i >0; i--)
            {
                if (method.Body.Instructions[i].OpCode == OpCodes.Call && method.Body.Instructions[i].Operand.ToString().Contains("get_CurrentDomain"))
                {
                    ResMeth = method;
                    return true;
                }
            }
            return false;

        }
        public static bool AntiDebug(ModuleDefMD module)
        {
            TypeDef type = module.GlobalType;
            foreach(MethodDef method in type.Methods)
            {
                if(method.HasBody && method.Body.HasInstructions)
                {
                    //Can be bigger
                    if(method.Body.Variables.Count >=5)
                    {
                        for(int i = 0; i < method.Body.Instructions.Count-1;i++)
                        {
                            if(method.Body.Instructions[i].OpCode == OpCodes.Ldtoken && method.Body.Instructions[i].Operand.ToString().Contains("Environment"))
                            {
                                //Other check to strengthen result
                                return FindThread(method);
                            }
                        }
                    }
                }
            }
            return false;
        }
        public static bool AntiDump(ModuleDefMD module)
        {
            TypeDef type = module.GlobalType;
            foreach (MethodDef method in type.Methods)
            {
                //Check VirtualProtect
                if(method.HasImplMap && method.ImplMap.Name.Contains("VirtualProtect"))
                {
                    return FindRef(module, method);
                }
            }
            return false;
        }
        public static bool FindRef(ModuleDefMD module, MethodDef VirtualProtect)
        {
            TypeDef type = module.GlobalType;
            foreach (MethodDef method in type.Methods)
            {
                if (method.HasBody && method.Body.HasInstructions)
                {
                    //Can be bigger
                    if (method.Body.Variables.Count >= 40)
                    {
                        for (int i = 0; i < method.Body.Instructions.Count - 1; i++)
                        {
                            if (method.Body.Instructions[i].OpCode == OpCodes.Call && method.Body.Instructions[i].Operand.ToString().Contains(VirtualProtect.Name))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        public static bool FindThread(MethodDef method)
        {
            for (int i = 0; i < method.Body.Instructions.Count - 1; i++)
            {
                if(method.Body.Instructions[i].OpCode == OpCodes.Newobj && method.Body.Instructions[i].Operand.ToString().Contains("ParameterizedThreadStart"))
                {
                    return true;
                }
            }
            return false;

            }
        public static MethodDef ConstantsMeth = null;
        public static bool ConstantsAT(ModuleDefMD module)
        {
            TypeDef type = module.GlobalType;
            foreach(MethodDef method in type.Methods)
            {
                if(method.ReturnType.IsGenericMethodParameter)
                {
                    ConstantsMeth = method;
                    return true;
                }
            }
            return false;
        }
        public static bool AntiILDasm(ModuleDefMD module)
        {
            foreach(CustomAttribute attr in module.CustomAttributes)
            {
                if(attr.ToString().Contains("Ildasm"))
                {
                    return true;
                }
            }
            return false;
        }
        public static string ATModeChecker()
        {
            MethodDef method = ATMeth;
            if(method.Body.Variables.Count <26)
            {
                return "Normal";
            }
            else
            {
                return "Dynamic";
            }
        }
        public static MethodDef ATMeth = null;
        public static bool IsTampered(ModuleDefMD module)
        {
            var AmountOfSections = module.MetaData.PEImage.ImageSectionHeaders;
            if (AmountOfSections.Count == 3)
            {
                return false;
            }
            else
            {
                MethodDef cctor = module.GlobalType.FindStaticConstructor();
                if(cctor == null)
                {
                    return false;
                }
                //cctor should be first instructions. But in some mods, it's not in instructions 0 so let's give
                //us some instructions to find it
                for(int i = 0; i < 10;i++)
                {
                    if(cctor.Body.Instructions[i].OpCode == OpCodes.Call)
                    {
                        try
                        {
                            MethodDef method = (MethodDef)cctor.Body.Instructions[i].Operand;
                            for (int z = 0; z < method.Body.Instructions.Count; z++)
                            {
                                if (method.Body.Instructions[z].OpCode == OpCodes.Call)
                                {
                                    string operand = method.Body.Instructions[z].Operand.ToString();
                                    if (operand.Contains("GetHINSTANCE"))
                                    {
                                        ATMeth = method;
                                        return true;
                                    }
                                }
                            }
                        }
                        catch
                        {

                        }
                    }
                }
            }
            return false;
        }
        public static bool IsPacked(ModuleDefMD module)
        {
            MethodDef method = module.EntryPoint;
           
            for(int i = 0; i < method.Body.Instructions.Count-1;i++)
            {
                if(method.Body.Instructions[i].OpCode == OpCodes.Call)
                {
                    string operand = method.Body.Instructions[i].Operand.ToString();
                    if(operand.Contains("Free") && operand.Contains("GCHandle"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static void ChangeTextAT(Label lab, bool yes)
        {
            if (yes)
            {
                lab.ForeColor = Color.Lime;
                lab.Text = "Found";
            }
            else
            {
                lab.ForeColor = Color.Red;
                lab.Text = "Can't find because of Anti-Tamper";
            }
        }
        public static void ChangeText(Label lab, bool yes)
        {
            if(yes)
            {
                lab.ForeColor = Color.Lime;
                lab.Text = "Found";
            }
            else
            {
                lab.ForeColor = Color.Red;
                lab.Text = "Not found";
            }
        }
    }
}