using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIDIPCR
{
    [Serializable]
    public class Well2
    {
        public const string ExperimentType_AbsoluteQuantitation = "Absolute Quantification";
        public const string ExperimentType_AbsoluteQuantitationOld = "Absolute Quantitation";
        public const string ExperimentType_CopyNumberVariation = "Copy Number Variation";
        public const string ExperimentType_RareEventDetection = "Rare Event Detection";
        public const string ExperimentType_Ratio = "Percentage";
        public const string ExperimentType_Ratio2 = "Ratio";
        public static readonly string Type_NotUsed;
        public static readonly string Type_Unknown;
        public static readonly string Type_Reference;
        public static readonly string Type_PositiveControl;
        public static readonly string Type_NegativeControl;
        public static readonly string Type_Blank;
        public static readonly string Type_NTC;

        public string FixedLabel //1 - 96 标识
        {
            get;
            set;//private set;
        }
        public string SampleName//样本名
        {
            get;
            set;
        }
        public string ExperimentType//实验类型：如"Absolute Quantification"; 
        {
            get;
            set;
        }
        public string ExperimentName//实验名称
        {
            get;
            set;
        }
        public string ExperimentComments
        {
            get;
            set;
        }

        public string[] AssayType; //AssayType[0]: FAM类型如，Well.Type_NotUsed;
        public string[] AssayTarget;//FAM的名称
        public string[] AssayName;//FAM的名称
        
        public float[] Threshold;//阈值
        public bool[] ShowThresholdLine;//显示阈值分割线
        public float?[] ManualThreshold;//手工设置阈值
        public int[] Positives;
        public int[] Negatives;
        public float?[] Concentration;//浓度
        public float?[] MinConfidenceInterval;//99%置信区间的下线
        public float?[] MaxConfidenceInterval;//99%置信区间的上线
        public float?[] MinConfidenceInterval68;//68%置信区间的下线
        public float?[] MaxConfidenceInterval68;//68%置信区间的上线

        public float?[] RWMinConfidenceInterval;
        public float?[] RWMaxConfidenceInterval;
        public float?[] RWMinConfidenceInterval68;
        public float?[] RWMaxConfidenceInterval68;

        public int AcceptedEvents//接受的微滴数
        {
            get;
            set;
        }
        public int TotalEvents
        {
            get;
            set;
        }
        public int PosPos
        {
            get;
            set;
        }
        public int PosNeg
        {
            get;
            set;
        }
        public int NegPos
        {
            get;
            set;
        }
        public int NegNeg
        {
            get;
            set;
        }
        public float? CNV
        {
            get;
            set;
        }
        public float? CNVMin
        {
            get;
            set;
        }
        public float? CNVMax
        {
            get;
            set;
        }
        public float? CNVMin68
        {
            get;
            set;
        }
        public float? CNVMax68
        {
            get;
            set;
        }
        public float? Ratio
        {
            get;
            set;
        }
        public float? RatioMin
        {
            get;
            set;
        }
        public float? RatioMax
        {
            get;
            set;
        }
        public float? RatioMin68
        {
            get;
            set;
        }
        public float? RatioMax68
        {
            get;
            set;
        }
        public float? Ratio2
        {
            get;
            set;
        }
        public float? Ratio2Min
        {
            get;
            set;
        }
        public float? Ratio2Max
        {
            get;
            set;
        }
        public float? Ratio2Min68
        {
            get;
            set;
        }
        public float? Ratio2Max68
        {
            get;
            set;
        }
        public bool Selected
        {
            get;
            set;
        }
        public float ReferenceCopyNumber
        {
            get;
            set;
        }
        public float TargetCopyNumber
        {
            get;
            set;
        }
        public float ReferenceAssayNumber
        {
            get;
            set;
        }
        public float TargetAssayNumber
        {
            get;
            set;
        }
        public float? ReactionVolume//20微升
        {
            get;
            set;
        }
        public float DropletVolume//0.85f??
        {
            get;
            set;
        }

        public float Linkage
        {
            get;
            set;
        }

        public byte SelectedPos//add swz 20170314
        {
            get;
            set;
        }




        public static List<string> TypeNames
        {
            get;
            private set;
        }
        static Well2()
        {
            Well2.Type_NotUsed = "Not Used";
            Well2.Type_Unknown = "Unknown";
            Well2.Type_Reference = "Reference";
            Well2.Type_PositiveControl = "Positive Control";
            Well2.Type_NegativeControl = "Negative Control";
            Well2.Type_Blank = "Blank";
            Well2.Type_NTC = "NTC";
            Well2.TypeNames = new List<string>();
            Well2.TypeNames.Add(Well2.Type_NotUsed);
            Well2.TypeNames.Add(Well2.Type_Unknown);
            Well2.TypeNames.Add(Well2.Type_Reference);
            Well2.TypeNames.Add(Well2.Type_PositiveControl);
            Well2.TypeNames.Add(Well2.Type_NegativeControl);
            Well2.TypeNames.Add(Well2.Type_Blank);
            Well2.TypeNames.Add(Well2.Type_NTC);
        }
        public Well2():this("",null, "Absolute Quantification","",
                                       null,"",null,"",false, false,
                                       null,null,null,null,null,
                                       null,null,null,null,null,
                                       null,null,null,null,
                                       null,null,null,null,
                                       0,null,null,null,null,null,
                                       null,null,null,null,null,
                                       null,null,null,null,null,
                                       false,20f,0.85f,2u,1u,1u,1u,0)
        {

        }
        public void CopyWell(Well2 m)
        {
            this.AssayName = new string[2];
            this.AssayType = new string[2];
            this.AssayTarget = new string[2];
            this.Concentration = new float?[2];
            this.ShowThresholdLine = new bool[2];
            this.MinConfidenceInterval = new float?[2];
            this.MaxConfidenceInterval = new float?[2];
            this.MinConfidenceInterval68 = new float?[2];
            this.MaxConfidenceInterval68 = new float?[2];

            //第一组
            this.FixedLabel = m.FixedLabel;//样本标识
            if (m.SampleName == null)
            {
                this.SampleName = "";
            }
            else
            {
                this.SampleName = m.SampleName;//样本名字
            }
            this.ExperimentType = m.ExperimentType;//实验类型
            this.ExperimentName = m.ExperimentName;//实验名称
            //第二组
            this.AssayType[0] = m.AssayType[0]; //类似 Well.Type_NotUsed;
            this.AssayTarget[0] = m.AssayTarget[0];//FAM 名字

            this.AssayType[1] = m.AssayType[1];
            this.AssayTarget[1] = m.AssayTarget[1];
            this.ShowThresholdLine[0] = m.ShowThresholdLine[0];
            this.ShowThresholdLine[1] = m.ShowThresholdLine[1];
            //第三组
            this.Concentration[0] = m.Concentration[0];
            this.MinConfidenceInterval[0] = m.MinConfidenceInterval[0];
            this.MaxConfidenceInterval[0] = m.MaxConfidenceInterval[0];
            this.MinConfidenceInterval68[0] = m.MinConfidenceInterval68[0];
            this.MaxConfidenceInterval68[0] = m.MaxConfidenceInterval68[0];
            //第四组
            this.Concentration[1] = m.Concentration[1];
            this.MinConfidenceInterval[1] = m.MinConfidenceInterval[1];
            this.MaxConfidenceInterval[1] = m.MaxConfidenceInterval[1];
            this.MinConfidenceInterval68[1] = m.MinConfidenceInterval68[1];
            this.MaxConfidenceInterval68[1] = m.MaxConfidenceInterval68[1];
            //补充第五组
            this.RWMinConfidenceInterval[0] = m.RWMaxConfidenceInterval[0];
            this.RWMaxConfidenceInterval[0] = m.RWMaxConfidenceInterval[0];
            this.RWMinConfidenceInterval68[0] = m.RWMinConfidenceInterval68[0];
            this.RWMaxConfidenceInterval68[0] = m.RWMaxConfidenceInterval68[0];

            this.RWMinConfidenceInterval[1] = m.RWMinConfidenceInterval[1];
            this.RWMaxConfidenceInterval[1] = m.RWMaxConfidenceInterval[1];
            this.RWMinConfidenceInterval68[1] = m.RWMinConfidenceInterval68[1];
            this.RWMaxConfidenceInterval68[1] = m.RWMaxConfidenceInterval68[1];
            //第五组
            this.AcceptedEvents = m.AcceptedEvents;
            this.CNV = m.CNV;
            this.CNVMin = m.CNVMin;
            this.CNVMax = m.CNVMax;
            this.CNVMin68 = m.CNVMin68;
            this.CNVMax68 = m.CNVMax68;
            //第6组
            this.Ratio = m.Ratio;
            this.RatioMin = m.RatioMin;
            this.RatioMax = m.RatioMax;
            this.RatioMin68 = m.RatioMin68;
            this.RatioMax68 = m.RatioMax68;
            //第7组
            this.Ratio2 = m.Ratio2;
            this.Ratio2Min = m.Ratio2Min;
            this.Ratio2Max = m.Ratio2Max;
            this.Ratio2Min68 = m.Ratio2Min68;
            this.Ratio2Max68 = m.Ratio2Max68;

            //第8组
            this.Selected = m.Selected;
            this.ReactionVolume = m.ReactionVolume;
            this.DropletVolume = m.DropletVolume;
            this.ReferenceCopyNumber = m.ReferenceCopyNumber;
            this.TargetCopyNumber = m.TargetCopyNumber;
            this.ReferenceAssayNumber = m.ReferenceAssayNumber;
            this.TargetAssayNumber = m.TargetAssayNumber;
            //其余初始化

            this.ExperimentComments = m.ExperimentComments;//实验名称的注释
            this.Threshold[0] = m.Threshold[0];
            this.Threshold[1] = m.Threshold[1];
            this.ManualThreshold[0] = m.ManualThreshold[0];
            this.ManualThreshold[1] = m.ManualThreshold[1];
            this.Positives[0] = m.Positives[0];
            this.Positives[1] = m.Positives[1];
            this.Negatives[0] = m.Negatives[0];
            this.Negatives[1] = m.Negatives[1];

            this.TotalEvents = m.TotalEvents;

            this.PosPos = m.PosPos;
            this.PosNeg = m.PosNeg;
            this.NegNeg = m.NegNeg;
            this.NegPos = m.NegPos;
            this.Linkage = m.Linkage;
            /*=== 补充 ===*/
            this.SelectedPos = m.SelectedPos;
        }
        public Well2(Well2 w)
        {

        }
        public Well2(string fixedLabel,string sampleName=null,string experimentType = "Absolute Quantification", string experimentName="",
                   string famType=null,string famTarget="",string vicType=null,string vicTarget="",bool showFAMThreshold=false,bool showVICThreshold=false,
                   float? famConcentration = null, float? famMinConfidenceInterval = null, float? famMaxConfidenceInterval = null, float? famMinConfidenceInterval68 = null, float? famMaxConfidenceInterval68 = null, 
                   float? vicConcentration = null, float? vicMinConfidenceInterval = null, float? vicMaxConfidenceInterval = null, float? vicMinConfidenceInterval68 = null, float? vicMaxConfidenceInterval68 = null,
                   float? famRWMinConfidenceInterval = null, float? famRWMaxConfidenceInterval = null, float? famRWMinConfidenceInterval68 = null, float? famRWMaxConfidenceInterval68 = null,
                   float? vicRWMinConfidenceInterval = null, float? vicRWMaxConfidenceInterval = null, float? vicRWMinConfidenceInterval68 = null, float? vicRWMaxConfidenceInterval68 = null,
                   int acceptedEvents = 0, float? cnv = null,  float? cnvMin = null,float? cnvMax = null, float? cnvMin68 = null,float? cnvMax68 = null, 
                   float? ratio = null,  float? ratioMin = null,float? ratioMax = null, float? ratioMin68 = null,float? ratioMax68 = null,  
                   float? ratio2 = null, float? ratio2Min = null,float? ratio2Max = null, float? ratio2Min68 = null, float? ratio2Max68 = null,
                   bool selected=false, float reactionVolume = 20f, float dropletVolume = 0.85f,uint referenceCopyNumber = 2u, uint targetCopyNumber = 1u, uint referenceAssayNumber = 1u, uint targetAssayNumber = 1u,byte selectedPos = 0)
        {

            this.AssayName = new string[2];
            this.AssayType = new string[2];
            this.AssayTarget = new string[2];
            this.Concentration = new float?[2];
            this.ShowThresholdLine = new bool[2];
            this.MinConfidenceInterval = new float?[2];
            this.MaxConfidenceInterval = new float?[2];
            this.MinConfidenceInterval68 = new float?[2];
            this.MaxConfidenceInterval68 = new float?[2];
            this.RWMinConfidenceInterval = new float?[2];
            this.RWMaxConfidenceInterval = new float?[2];
            this.RWMinConfidenceInterval68 = new float?[2];
            this.RWMaxConfidenceInterval68 = new float?[2];

            //第一组
            this.FixedLabel = fixedLabel;//样本标识
            if (sampleName == null)
            {
                this.SampleName = "";
            }
            else
            {
                this.SampleName = sampleName;//样本名字
            }
            this.ExperimentType = experimentType;//实验类型
            this.ExperimentName = experimentName;//实验名称
            //第二组
            this.AssayType[0] = famType;//类似 Well.Type_NotUsed;
            this.AssayTarget[0] = famTarget;//FAM 名字

            this.AssayType[1] = vicType;
            this.AssayTarget[1] = vicTarget;
            this.ShowThresholdLine[0] = showFAMThreshold;
            this.ShowThresholdLine[1] = showVICThreshold;
            //第三组
            this.Concentration[0] = famConcentration;
            this.MinConfidenceInterval[0] = famMinConfidenceInterval;
            this.MaxConfidenceInterval[0] = famMaxConfidenceInterval;
            this.MinConfidenceInterval68[0] = famMinConfidenceInterval68;
            this.MaxConfidenceInterval68[0] = famMaxConfidenceInterval68;
            //第四组
            this.Concentration[1] = vicConcentration;
            this.MinConfidenceInterval[1] = vicMinConfidenceInterval;
            this.MaxConfidenceInterval[1] = vicMaxConfidenceInterval;
            this.MinConfidenceInterval68[1] = vicMinConfidenceInterval68;
            this.MaxConfidenceInterval68[1] = vicMaxConfidenceInterval68;
            //补充第五组
            this.RWMinConfidenceInterval[0] = famRWMinConfidenceInterval;
            this.RWMaxConfidenceInterval[0] = famRWMaxConfidenceInterval;
            this.RWMinConfidenceInterval68[0] = famRWMinConfidenceInterval68;
            this.RWMaxConfidenceInterval68[0] = famRWMaxConfidenceInterval68;

            this.RWMinConfidenceInterval[1] = vicRWMinConfidenceInterval;
            this.RWMaxConfidenceInterval[1] = vicRWMaxConfidenceInterval;
            this.RWMinConfidenceInterval68[1] = vicRWMinConfidenceInterval68;
            this.RWMaxConfidenceInterval68[1] = vicRWMaxConfidenceInterval68;
            //第五组
            this.AcceptedEvents = acceptedEvents;
            this.CNV = cnv;
            this.CNVMin = cnvMin;
            this.CNVMax = cnvMax;
            this.CNVMin68 = cnvMin68;
            this.CNVMax68 = cnvMax68;
            //第6组
            this.Ratio = ratio;
            this.RatioMin = ratioMin;
            this.RatioMax = ratioMax;
            this.RatioMin68 = ratioMin68;
            this.RatioMax68 = ratioMax68;
            //第7组
            this.Ratio2 = ratio2;
            this.Ratio2Min = ratio2Min;
            this.Ratio2Max = ratio2Max;
            this.Ratio2Min68 = ratio2Min68;
            this.Ratio2Max68 = ratio2Max68;

            //第8组
            this.Selected = selected;
            this.ReactionVolume = reactionVolume;
            this.DropletVolume = dropletVolume;
            this.ReferenceCopyNumber = referenceCopyNumber;
            this.TargetCopyNumber = targetCopyNumber;
            this.ReferenceAssayNumber = referenceAssayNumber;
            this.TargetAssayNumber = targetAssayNumber;
            //其余初始化

            this.ExperimentComments = "";//实验名称的注释
            this.Threshold = new float[2];
            this.ManualThreshold = new float?[2];
            this.Positives = new int[2];
            this.Negatives = new int[2];
            this.TotalEvents = 0;

            this.PosPos = 0;
            this.PosNeg = 0;
            this.NegNeg = 0;
            this.NegPos = 0;
            this.Linkage = 0;
            /*=== 补充 ===*/
            this.SelectedPos = selectedPos;

        }


        public static int ConvertToInt(string FixedLabel)
        {
            char c = char.ToUpper(FixedLabel[0]);
            if (c < 'A' || c > 'H')
            {
                return -1;
            }
            int num = (int)(c - 'A');
            int num2;
            try
            {
                num2 = Convert.ToInt32(FixedLabel.Substring(1));
            }
            catch
            {
                int result = -1;
                return result;
            }
            if (num2 < 1 || num2 > 12)
            {
                return -1;
            }
            return num * 12 + (num2 - 1);
        }
        public static Point ConvertToRowColumn(int WellNumber)
        {
            if (WellNumber < 0 || WellNumber > 95)
            {
                return Point.Empty;
            }
            int x = WellNumber / 12 + 1;
            int y = WellNumber % 12 + 1;
            return new Point(x, y);
        }
    }
}
